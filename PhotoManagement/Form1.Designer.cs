namespace PhotoManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btnSourceFolder = new Button();
            label1 = new Label();
            txtSourceFolder = new TextBox();
            txtTargetFolder = new TextBox();
            label2 = new Label();
            btnTargetFolder = new Button();
            sourceGrid = new DataGridView();
            groupBox1 = new GroupBox();
            lblSourceTotalFiles = new Label();
            groupBox2 = new GroupBox();
            TargetGrid = new DataGridView();
            lblTargetTotalFiles = new Label();
            btnMove = new Button();
            btnRefresh = new Button();
            lblTotalMovingFiles = new Label();
            lblCurrentFile = new Label();
            progressBar1 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)sourceGrid).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TargetGrid).BeginInit();
            SuspendLayout();
            // 
            // btnSourceFolder
            // 
            btnSourceFolder.Location = new Point(476, 12);
            btnSourceFolder.Name = "btnSourceFolder";
            btnSourceFolder.Size = new Size(100, 23);
            btnSourceFolder.TabIndex = 0;
            btnSourceFolder.Text = "Select Folder";
            btnSourceFolder.UseVisualStyleBackColor = true;
            btnSourceFolder.Click += BtnSourceFolder_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 15);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 1;
            label1.Text = "Source Folder";
            // 
            // txtSourceFolder
            // 
            txtSourceFolder.Location = new Point(114, 12);
            txtSourceFolder.Name = "txtSourceFolder";
            txtSourceFolder.ReadOnly = true;
            txtSourceFolder.Size = new Size(356, 23);
            txtSourceFolder.TabIndex = 2;
            // 
            // txtTargetFolder
            // 
            txtTargetFolder.Location = new Point(730, 12);
            txtTargetFolder.Name = "txtTargetFolder";
            txtTargetFolder.ReadOnly = true;
            txtTargetFolder.Size = new Size(356, 23);
            txtTargetFolder.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(637, 15);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 4;
            label2.Text = "Target Folder";
            // 
            // btnTargetFolder
            // 
            btnTargetFolder.Location = new Point(1093, 12);
            btnTargetFolder.Name = "btnTargetFolder";
            btnTargetFolder.Size = new Size(100, 23);
            btnTargetFolder.TabIndex = 3;
            btnTargetFolder.Text = "Select Folder";
            btnTargetFolder.UseVisualStyleBackColor = true;
            btnTargetFolder.Click += BtnTargetFolder_Click;
            // 
            // sourceGrid
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            sourceGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            sourceGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            sourceGrid.DefaultCellStyle = dataGridViewCellStyle2;
            sourceGrid.Dock = DockStyle.Fill;
            sourceGrid.Location = new Point(3, 19);
            sourceGrid.Name = "sourceGrid";
            sourceGrid.Size = new Size(526, 316);
            sourceGrid.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(sourceGrid);
            groupBox1.Location = new Point(22, 105);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(532, 338);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Source Files";
            // 
            // lblSourceTotalFiles
            // 
            lblSourceTotalFiles.AutoSize = true;
            lblSourceTotalFiles.Location = new Point(25, 475);
            lblSourceTotalFiles.Name = "lblSourceTotalFiles";
            lblSourceTotalFiles.Size = new Size(59, 15);
            lblSourceTotalFiles.TabIndex = 8;
            lblSourceTotalFiles.Text = "Total Files";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TargetGrid);
            groupBox2.Location = new Point(650, 105);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(623, 338);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Target Files";
            // 
            // TargetGrid
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            TargetGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            TargetGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            TargetGrid.DefaultCellStyle = dataGridViewCellStyle4;
            TargetGrid.Dock = DockStyle.Fill;
            TargetGrid.Location = new Point(3, 19);
            TargetGrid.Name = "TargetGrid";
            TargetGrid.Size = new Size(617, 316);
            TargetGrid.TabIndex = 6;
            // 
            // lblTargetTotalFiles
            // 
            lblTargetTotalFiles.AutoSize = true;
            lblTargetTotalFiles.Location = new Point(650, 475);
            lblTargetTotalFiles.Name = "lblTargetTotalFiles";
            lblTargetTotalFiles.Size = new Size(59, 15);
            lblTargetTotalFiles.TabIndex = 10;
            lblTargetTotalFiles.Text = "Total Files";
            // 
            // btnMove
            // 
            btnMove.Location = new Point(560, 266);
            btnMove.Name = "btnMove";
            btnMove.Size = new Size(72, 23);
            btnMove.TabIndex = 11;
            btnMove.Text = "Move";
            btnMove.UseVisualStyleBackColor = true;
            btnMove.Click += BtnMove_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(1093, 53);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 23);
            btnRefresh.TabIndex = 12;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += BtnRefresh_Click;
            // 
            // lblTotalMovingFiles
            // 
            lblTotalMovingFiles.AutoSize = true;
            lblTotalMovingFiles.Location = new Point(25, 61);
            lblTotalMovingFiles.Name = "lblTotalMovingFiles";
            lblTotalMovingFiles.Size = new Size(103, 15);
            lblTotalMovingFiles.TabIndex = 13;
            lblTotalMovingFiles.Text = "Total Moving Files";
            // 
            // lblCurrentFile
            // 
            lblCurrentFile.AutoSize = true;
            lblCurrentFile.Location = new Point(181, 61);
            lblCurrentFile.Name = "lblCurrentFile";
            lblCurrentFile.Size = new Size(68, 15);
            lblCurrentFile.TabIndex = 14;
            lblCurrentFile.Text = "Current File";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(476, 53);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(597, 23);
            progressBar1.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1285, 519);
            Controls.Add(progressBar1);
            Controls.Add(lblCurrentFile);
            Controls.Add(lblTotalMovingFiles);
            Controls.Add(btnRefresh);
            Controls.Add(btnMove);
            Controls.Add(lblTargetTotalFiles);
            Controls.Add(groupBox2);
            Controls.Add(lblSourceTotalFiles);
            Controls.Add(groupBox1);
            Controls.Add(txtTargetFolder);
            Controls.Add(label2);
            Controls.Add(btnTargetFolder);
            Controls.Add(txtSourceFolder);
            Controls.Add(label1);
            Controls.Add(btnSourceFolder);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)sourceGrid).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TargetGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSourceFolder;
        private Label label1;
        private TextBox txtSourceFolder;
        private TextBox txtTargetFolder;
        private Label label2;
        private Button btnTargetFolder;
        private DataGridView sourceGrid;
        private GroupBox groupBox1;
        private Label lblSourceTotalFiles;
        private GroupBox groupBox2;
        private DataGridView TargetGrid;
        private Label lblTargetTotalFiles;
        private Button btnMove;
        private Button btnRefresh;
        private Label lblTotalMovingFiles;
        private Label lblCurrentFile;
        private ProgressBar progressBar1;
    }
}
