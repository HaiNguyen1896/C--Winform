using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCreate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSltPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtFolder.Text = folderBrowserDialog.SelectedPath;
            }
            else
            {
                MessageBox.Show("Bạn chưa chon đường dẫn");
            }
        }

        private void btnCrtFolder_Click(object sender, EventArgs e)
        {
            string path = txtFolder.Text;
            if (path == "")
            {
                MessageBox.Show("Bạn chưa chọn đường dẫn");
            }
            else
            {
                if (Directory.Exists(path))
                {
                    if (txtFolder.Text != "")
                    {
                        int n;
                        bool isNumeric = int.TryParse(txtCrtFolder.Text, out n);
                        if (!isNumeric)
                        {
                            MessageBox.Show("Số lượng phải là số");
                            txtCrtFolder.Text="";
                        }
                        else
                        {
                            if (n < 0)
                            {
                                MessageBox.Show("Số lượng folder phải dương");
                                txtCrtFolder.Text="";
                            }
                            else
                            {
                                for (int i = 0; i < n; i++)
                                {
                                    string folderPath = txtFolder.Text + @"\thumuc" + (i+1);
                                    DirectoryInfo createDir = new DirectoryInfo(folderPath);
                                    createDir.Create();
                                }
                                MessageBox.Show("Tạo thành công "+n+" folder");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn cần nhập số lượng folder");
                    }
                }
                else
                {
                    MessageBox.Show("Đường dẫn không tồn tại");
                }
            }
        }

        private void btnCrtText_Click(object sender, EventArgs e)
        {
            string path = txtFolder.Text;
            if (path == "")
            {
                MessageBox.Show("Bạn chưa chọn đường dẫn");
            }
            else
            {
                if (Directory.Exists(path))
                {
                    if (txtFolder.Text != "")
                    {
                        int n;
                        bool isNumeric = int.TryParse(txtCrtText.Text, out n);
                        if (!isNumeric)
                        {
                            MessageBox.Show("Số lượng phải là số");
                            txtCrtText.Text="";
                        }
                        else
                        {
                            if (n < 0)
                            {
                                MessageBox.Show("Số lượng file phải dương");
                                txtCrtText.Text="";
                            }
                            else
                            {
                                for (int i = 0; i < n; i++)
                                {
                                    string folderPath = txtFolder.Text + @"\file" + (i+1)+".txt";
                                    FileInfo createDir = new FileInfo(folderPath);
                                    createDir.Create();
                                }
                                MessageBox.Show("Tạo thành công "+n+" file txt");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn cần nhập số lượng file");
                    }
                }
                else
                {
                    MessageBox.Show("Đường dẫn không tồn tại");
                }
            }
        }
    }
}