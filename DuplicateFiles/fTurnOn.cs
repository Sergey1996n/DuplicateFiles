using System;
using System.Windows.Forms;

namespace DuplicateFiles
{
    public partial class fTurnOn : Form
    {
        bool add = false;
        string line;
        public fTurnOn()
        {
            InitializeComponent();
            if (tbReview.Text == "")
                add = true;
            else
            {
                line = tbReview.Text;
                add = false;
            }
        }

        private void btnReview_Click(object sender, EventArgs e)
        {

            if (tbReview.Text == "")
                add = true;
            else
            {
                line = tbReview.Text;
                add = false;
            }
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.ShowNewFolderButton = false;
            if (FBD.ShowDialog() == DialogResult.OK)
                tbReview.Text = FBD.SelectedPath;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Owner is Form1 main)
            {
                if (main.tabControl1.SelectedIndex == 0)
                {
                    if (add)
                    {
                        bool flag = true;
                        foreach (ListViewItem el in main.lvTurnOn.Items)
                            if (el.Text == tbReview.Text + "\\*.*")
                            {
                                flag = false;
                                break;
                            }
                        if (flag)
                        {
                            main.lvTurnOn.Items.Add(tbReview.Text + "\\*.*");
                            main.lvTurnOn.Items[main.lvTurnOn.Items.Count - 1].Checked = true;
                        }
                    }
                    else
                    for (int i = 0; i < main.lvTurnOn.Items.Count; i++)
                        if (main.lvTurnOn.Items[i].Text  == line + "\\*.*")
                        {
                            main.lvTurnOn.Items[i].Text = tbReview.Text + "\\*.*";
                            break;
                        }
                }
                else
                {
                    if (add)
                    {
                        bool flag = true;
                        foreach (ListViewItem el in main.lvExclude.Items)
                            if (el.Text == tbReview.Text + "\\*.*")
                            {
                                flag = false;
                                break;
                            }
                        if (flag)
                        {
                            main.lvExclude.Items.Add(tbReview.Text + "\\*.*");
                            main.lvExclude.Items[main.lvExclude.Items.Count - 1].Checked = true;
                        }

                    }
                    else
                        for (int i = 0; i < main.lvExclude.Items.Count; i++)
                            if (main.lvExclude.Items[i].Text == line + "\\*.*")
                            {
                                main.lvExclude.Items[i].Text = tbReview.Text + "\\*.*";
                                break;
                            }
                }
            }
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
