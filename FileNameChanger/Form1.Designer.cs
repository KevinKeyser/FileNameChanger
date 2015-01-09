namespace FileNameChanger
{
    partial class FileRenamer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Find = new System.Windows.Forms.TextBox();
            this.Replace = new System.Windows.Forms.TextBox();
            this.RenameButton = new System.Windows.Forms.Button();
            this.Url = new System.Windows.Forms.TextBox();
            this.FileDialogDragDrop = new System.Windows.Forms.PictureBox();
            this.FileView = new System.Windows.Forms.ListBox();
            this.swagTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.FileDialogDragDrop)).BeginInit();
            this.SuspendLayout();
            // 
            // Find
            // 
            this.Find.Location = new System.Drawing.Point(12, 38);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(100, 20);
            this.Find.TabIndex = 1;
            // 
            // Replace
            // 
            this.Replace.Location = new System.Drawing.Point(12, 65);
            this.Replace.Name = "Replace";
            this.Replace.Size = new System.Drawing.Size(100, 20);
            this.Replace.TabIndex = 2;
            // 
            // RenameButton
            // 
            this.RenameButton.Location = new System.Drawing.Point(118, 65);
            this.RenameButton.Name = "RenameButton";
            this.RenameButton.Size = new System.Drawing.Size(75, 23);
            this.RenameButton.TabIndex = 3;
            this.RenameButton.TabStop = false;
            this.RenameButton.Text = "Rename";
            this.RenameButton.UseVisualStyleBackColor = true;
            this.RenameButton.Click += new System.EventHandler(this.RenameButton_Click);
            // 
            // Url
            // 
            this.Url.Location = new System.Drawing.Point(12, 12);
            this.Url.Name = "Url";
            this.Url.Size = new System.Drawing.Size(199, 20);
            this.Url.TabIndex = 0;
            this.Url.TextChanged += new System.EventHandler(this.Url_TextChanged);
            // 
            // FileDialogDragDrop
            // 
            this.FileDialogDragDrop.BackColor = System.Drawing.SystemColors.ControlDark;
            this.FileDialogDragDrop.Location = new System.Drawing.Point(118, 38);
            this.FileDialogDragDrop.Name = "FileDialogDragDrop";
            this.FileDialogDragDrop.Size = new System.Drawing.Size(25, 24);
            this.FileDialogDragDrop.TabIndex = 4;
            this.FileDialogDragDrop.TabStop = false;
            this.FileDialogDragDrop.Click += new System.EventHandler(this.FileDialogDragDrop_Click);
            // 
            // FileView
            // 
            this.FileView.FormattingEnabled = true;
            this.FileView.Location = new System.Drawing.Point(218, 0);
            this.FileView.Name = "FileView";
            this.FileView.Size = new System.Drawing.Size(145, 108);
            this.FileView.TabIndex = 5;
            this.FileView.TabStop = false;
            // 
            // FileRenamer
            // 
            this.AcceptButton = this.RenameButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 108);
            this.Controls.Add(this.FileView);
            this.Controls.Add(this.FileDialogDragDrop);
            this.Controls.Add(this.RenameButton);
            this.Controls.Add(this.Replace);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.Url);
            this.Name = "FileRenamer";
            this.Text = "FileRenamer";
            this.ResizeEnd += new System.EventHandler(this.FileRenamer_ResizeEnd);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FileRenamer_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FileRenamer_DragEnter);
            this.MouseEnter += new System.EventHandler(this.FileRenamer_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.FileRenamer_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.FileDialogDragDrop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Find;
        private System.Windows.Forms.TextBox Replace;
        private System.Windows.Forms.Button RenameButton;
        private System.Windows.Forms.TextBox Url;
        private System.Windows.Forms.PictureBox FileDialogDragDrop;
        private System.Windows.Forms.ListBox FileView;
        private System.Windows.Forms.Timer swagTimer;
    }
}

