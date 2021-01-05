using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace DuplicateFiles
{
    public partial class Form1 : Form
    {
        List<string> listlvExclude = new List<string>();
        List<string> listViewItem = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            listView1.Visible = true;
            btnBack.Visible = true;
            groupBox1.Visible = false;
            label1.Visible = true;
            btnDeleteAll.Visible = true;
            
            if (lvExclude.Items.Count != 0)
            {
                listlvExclude.Clear();
                foreach (ListViewItem item in lvExclude.Items)
                    if (item.Checked)
                        listlvExclude.Add(item.Text.Substring(0, item.Text.Length - 4));
            }
            listlvExclude.Add("C:\\Windows");
            listViewItem.Clear();
            foreach (ListViewItem item in lvTurnOn.Items)
            {
                if (item.Checked)
                    listViewItem.Add(item.Text);
            }
            Task.Run(() =>
            {
                Parallel.ForEach(listViewItem, el =>
                {
                    string path = el; // Исходная директория
                    label1.Invoke((MethodInvoker)delegate
                    {
                        label1.Text = "Идёт поиск всех папок!";
                    });
                            
                    var files = GetFiles(path.Substring(0, path.Length - 3), "*.*", listlvExclude.Contains);
                            
                    label1.Invoke((MethodInvoker)delegate
                    {
                        label1.Text = " Идёт отбор по вашим критериям!";

                    });

                    var duplicateGroups = GroupBy(files);
                    if (duplicateGroups != null)
                    {
                        foreach (var group in duplicateGroups)
                        {
                            listView1.Invoke((MethodInvoker)delegate
                            {
                                listView1.Groups.Add(new ListViewGroup("Файлов " + group.Count().ToString(), HorizontalAlignment.Left));
                            });
                            Parallel.ForEach(group, file =>
                            {
                                listView1.Invoke((MethodInvoker)delegate
                                {
                                    string[] row = { Path.GetFileName(file), file, new FileInfo(file).Length.ToString(), File.GetLastWriteTime(file).ToString() };
                                    listView1.Items.Add(new ListViewItem(listView1.Groups[listView1.Groups.Count - 1])).SubItems.AddRange(row);
                                });
                            });
                        }
                    }
                });
                MessageBox.Show("Конец!");
            });

        }
    

        private IEnumerable<IGrouping<(string, string, string, string), string>> GroupBy(List<string> files)
        {
            return files.
            //      Исключаем файлы с атрибутом "только для чтения"
            Where(file => cbOnlyForReading.Checked ? !new FileInfo(file).IsReadOnly : true).
            //      Исключаем системные файлы
            Where(file => cbSystemic.Checked ? !new FileInfo(file).Attributes.HasFlag(FileAttributes.System) : true).
            //      Исключаем скрытые файлы
            Where(file => cbHidden.Checked ? !new FileInfo(file).Attributes.HasFlag(FileAttributes.Hidden) : true).
            //      Исключаем файлы с нулевым байтом
            Where(file => cbZeroByteFiles.Checked ? file.Length != 0 : true).
            //      Исключаем файлы которые меньше numSizeLess.Value
            Where(file => cbSizeLess.Checked ? new FileInfo(file).Length > 1048576 * numSizeLess.Value : true).
            //      Исключаем файлы которые больше numSizeOver.Value
            Where(file => cbSizeOver.Checked ? new FileInfo(file).Length < 1048576 * numSizeOver.Value : true).
            GroupBy(file => (
            //      Поиск по пути файла
            cbName.Checked ? Path.GetFileName(file) : null,
            //      Поиск по длине файла
            cbSize.Checked ? new FileInfo(file).Length.ToString() : null,
            //      Поиск до дате изменения файла
            cbDateChange.Checked ? File.GetLastWriteTime(file).ToString() : null,
            //      Поиск по Хеш-коду файла
            cbContent.Checked ? new FileInfo(file).Length.GetHashCode().ToString() : null
            //      Группируем файлы, если их больше одного
            )).Where(group => group.Count() > 1).AsParallel();
        }

        private List<string> GetFiles(string path, string pattern, Predicate<string> excludeDirectory)
        {
            var files = new List<string>();

            if (!excludeDirectory(path))
                try
                { 
                    files.AddRange(Directory.GetFiles(path, pattern, System.IO.SearchOption.TopDirectoryOnly));
                    foreach (var directory in Directory.GetDirectories(path))
                        files.AddRange(GetFiles(directory, pattern, excludeDirectory));
                }
                //      Если папка недоступка пропускаем её
                catch (UnauthorizedAccessException) { }

            return files;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            listView1.Groups.Clear();
            listView1.Items.Clear();
            listView1.Visible = false;
            label1.Visible = false;
            btnBack.Visible = false;
            btnDeleteAll.Enabled = false;
            groupBox1.Visible = true;
        }

        private void cbSizeLess_CheckedChanged(object sender, EventArgs e)
        {
            //  Если выбран cbSizeLess, то активировать numSizeLess
            numSizeLess.Enabled = cbSizeLess.Checked ? true : false;
        }

        private void cbSizeOver_CheckedChanged(object sender, EventArgs e)
        {
            //  Если выбран cbSizeOver, то активировать numSizeOver
            numSizeOver.Enabled = cbSizeOver.Checked ? true : false;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
            "Вы действительно хотите вернуть стандартные настройки поиска дубликатов?\nВсе сделанные вами изменения будут удалены.",
            "Поиск файлов-дубликатов",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);
            if (dialog == DialogResult.Yes)
            {
                cbName.Checked = true;
                cbSize.Checked = true;
                cbDateChange.Checked = true;
                cbContent.Checked = false;
                cbZeroByteFiles.Checked = true;
                cbOnlyForReading.Checked = true;
                cbSystemic.Checked = true;
                cbHidden.Checked = true;
                cbSizeLess.Checked = true;
                numSizeLess.Enabled = true;
                numSizeLess.Value = 1;
                cbSizeOver.Checked = false;
                numSizeOver.Value = 1000;
                numSizeOver.Enabled = false;
                foreach (ListViewItem el in lvTurnOn.Items)
                    el.Checked = true;
            }
            //this.TopMost = true;

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            bool flag = false;
            foreach (ListViewItem el in lvTurnOn.Items)
                if (el.Checked)
                    flag = true;
            if (flag)
                btnSearch.Enabled = true;
            else
                btnSearch.Enabled = false;
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            fTurnOn fTurnOn = new fTurnOn();
            fTurnOn.Owner = this;
            fTurnOn.ShowDialog();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string line = "";
            if (tabControl1.SelectedIndex == 0)
            {
                ListView.SelectedListViewItemCollection breakfast = lvTurnOn.SelectedItems;
                foreach (ListViewItem item in breakfast)
                    line = item.SubItems[0].Text;
            }
            else
            {
                ListView.SelectedListViewItemCollection breakfast = lvExclude.SelectedItems;
                foreach (ListViewItem item in breakfast)
                    line = item.SubItems[0].Text;
            }
            fTurnOn fTurnOn = new fTurnOn();
            fTurnOn.Owner = this;
            fTurnOn.tbReview.Text = line.Substring(0, line.Length - 4);
            fTurnOn.ShowDialog();
        }

        private void lvTurnOn_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvTurnOnSelectedItems();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection SelectedIndex = lvTurnOn.SelectedIndices;
            foreach (int item in SelectedIndex)
                lvTurnOn.Items.Remove(lvTurnOn.Items[item]);
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
                lvTurnOnSelectedItems();
            else
                lvExcludeSelectedItems();
        }

        private void lvExclude_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvExcludeSelectedItems();
        }

        void lvTurnOnSelectedItems()
        {
            ListView.SelectedListViewItemCollection SelectedListViewItem = lvTurnOn.SelectedItems;
            if (SelectedListViewItem.Count != 0)
                foreach (ListViewItem item in SelectedListViewItem)
                {
                    if (item.Text == "C:\\*.*" || item.Text == "D:\\*.*")
                    {
                        btnChange.Enabled = false;
                        btnDelete.Enabled = false;
                    }
                    else
                    {
                        btnChange.Enabled = true;
                        btnDelete.Enabled = true;
                    }
                }
            else
            {
                btnChange.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        void lvExcludeSelectedItems()
        {
            ListView.SelectedListViewItemCollection SelectedListViewItem = lvExclude.SelectedItems;
            if (SelectedListViewItem.Count != 0)
            {
                btnChange.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                btnChange.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Checked)
                {
                    FileSystem.DeleteFile(item.SubItems[2].Text, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                    listView1.Items.Remove(item);
                }
            }
        }
    }
}
