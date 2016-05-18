using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace FileNameChanger
{
    public partial class FileRenamer : Form
    {
        public FileRenamer()
        {
            InitializeComponent();
            this.AllowDrop = true;

            FileView.Height = this.Height - 35;
            FileView.Location = new Point(this.Width - FileView.Width, 0);
        }



        private void FileDialogDragDrop_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            if (Directory.Exists(dialog.SelectedPath))
            {
                Url.Text = dialog.SelectedPath;
                FileView.Items.Clear();
                DirectoryInfo directinfo = new DirectoryInfo(Url.Text);
                foreach (FileInfo file in directinfo.GetFiles())
                {
                    FileView.Items.Add(file.Name);
                }
            }
        }

        private void RenameButton_Click(object sender, EventArgs e)
        {
            string filelocation = Url.Text;
            if (Directory.Exists(filelocation))
            {
                if (Find.Text != "")
                {
                    DirectoryInfo directinfo = new DirectoryInfo(filelocation);
                    foreach (FileInfo file in directinfo.GetFiles())
                    {
                        string extenstion = file.Extension;
                        if (extensionTextBox.Text.Trim() != "")
                        {
                            extenstion = extensionTextBox.Text;
                        }
                        string filePath = file.Name.Remove(file.Name.LastIndexOf('.')).Replace(Find.Text, Replace.Text) + file.Extension;
                        File.Move(file.FullName,  filelocation + @"//" + filePath.Remove(filePath.LastIndexOf('.')) + "." + extenstion);
                    }
                    FileView.Items.Clear();
                    foreach (FileInfo file in directinfo.GetFiles())
                    {
                        FileView.Items.Add(file.Name);
                    }
                }
            }
            else
            {
                MessageBox.Show("Path Doesn't Exist");
            }
        }
        private void FileRenamer_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(System.Windows.Forms.DataFormats.FileDrop);
            if (Directory.Exists(files[0]))
            {
                Url.Text = files[0];
                FileView.Items.Clear();
                DirectoryInfo directinfo = new DirectoryInfo(Url.Text);
                foreach (FileInfo file in directinfo.GetFiles())
                {
                    FileView.Items.Add(file.Name);
                }
            }
        }

        private void FileRenamer_MouseEnter(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void FileRenamer_MouseLeave(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void FileRenamer_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void Url_TextChanged(object sender, EventArgs e)
        {
            if (Directory.Exists(Url.Text))
            {
                FileView.Items.Clear();
                DirectoryInfo directinfo = new DirectoryInfo(Url.Text);
                foreach (FileInfo file in directinfo.GetFiles())
                {
                    FileView.Items.Add(file.Name);
                }
            }
        }

        private void FileRenamer_ResizeEnd(object sender, EventArgs e)
        {
            FileView.Height = this.Height - 35;
            FileView.Location = new Point(this.Width - FileView.Width, 0);
        }
    }
}
