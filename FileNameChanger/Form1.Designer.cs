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
            this.extensionTextBox = new System.Windows.Forms.TextBox();
            this.FindLabel = new System.Windows.Forms.Label();
            this.extensionButton = new System.Windows.Forms.Button();
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
            this.Url.Size = new System.Drawing.Size(167, 20);
            this.Url.TabIndex = 0;
            this.Url.TextChanged += new System.EventHandler(this.Url_TextChanged);
            // 
            // FileDialogDragDrop
            // 
            this.FileDialogDragDrop.BackColor = System.Drawing.SystemColors.ControlDark;
            this.FileDialogDragDrop.Location = new System.Drawing.Point(187, 12);
            this.FileDialogDragDrop.Name = "FileDialogDragDrop";
            this.FileDialogDragDrop.Size = new System.Drawing.Size(25, 20);
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
            // extensionTextBox
            // 
            this.extensionTextBox.Location = new System.Drawing.Point(12, 91);
            this.extensionTextBox.Name = "extensionTextBox";
            this.extensionTextBox.Size = new System.Drawing.Size(100, 20);
            this.extensionTextBox.TabIndex = 6;
            // 
            // FindLabel
            // 
            this.FindLabel.AutoSize = true;
            this.FindLabel.Location = new System.Drawing.Point(118, 41);
            this.FindLabel.Name = "FindLabel";
            this.FindLabel.Size = new System.Drawing.Size(27, 13);
            this.FindLabel.TabIndex = 7;
            this.FindLabel.Text = "Find";
            // 
            // extensionButton
            // 
            this.extensionButton.Location = new System.Drawing.Point(118, 91);
            this.extensionButton.Name = "extensionButton";
            this.extensionButton.Size = new System.Drawing.Size(75, 23);
            this.extensionButton.TabIndex = 8;
            this.extensionButton.TabStop = false;
            this.extensionButton.Text = "Change Ext";
            this.extensionButton.UseVisualStyleBackColor = true;
            this.extensionButton.Click += new System.EventHandler(this.extensionButton_Click);
            // 
            // FileRenamer
            // 
            this.AcceptButton = this.RenameButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 118);
            this.Controls.Add(this.extensionButton);
            this.Controls.Add(this.FindLabel);
            this.Controls.Add(this.extensionTextBox);
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
        private System.Windows.Forms.TextBox extensionTextBox;
        private System.Windows.Forms.Label FindLabel;
        private System.Windows.Forms.Button extensionButton;
    }
}

