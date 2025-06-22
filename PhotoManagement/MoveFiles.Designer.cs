namespace PhotoManagement
{
    partial class MoveFiles
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            grpSource = new GroupBox();
            sourceGrid = new DataGridView();
            btnSelectFolderSource = new Button();
            txtSourceFolder = new TextBox();
            btnMove = new Button();
            grpTarget = new GroupBox();
            targetGrid = new DataGridView();
            btnSelectFolderTarget = new Button();
            txtTargetFolder = new TextBox();
            progressBar1 = new ProgressBar();
            lblFileName = new Label();
            lblPercentage = new Label();
            grpSource.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sourceGrid).BeginInit();
            grpTarget.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)targetGrid).BeginInit();
            SuspendLayout();
            // 
            // grpSource
            // 
            grpSource.Controls.Add(sourceGrid);
            grpSource.Controls.Add(btnSelectFolderSource);
            grpSource.Controls.Add(txtSourceFolder);
            grpSource.Location = new Point(4, 0);
            grpSource.Name = "grpSource";
            grpSource.Size = new Size(366, 318);
            grpSource.TabIndex = 0;
            grpSource.TabStop = false;
            grpSource.Text = "Source";
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
            sourceGrid.Location = new Point(8, 51);
            sourceGrid.Name = "sourceGrid";
            sourceGrid.Size = new Size(352, 261);
            sourceGrid.TabIndex = 7;
            // 
            // btnSelectFolderSource
            // 
            btnSelectFolderSource.Location = new Point(258, 22);
            btnSelectFolderSource.Name = "btnSelectFolderSource";
            btnSelectFolderSource.Size = new Size(102, 23);
            btnSelectFolderSource.TabIndex = 1;
            btnSelectFolderSource.Text = "Select Folder";
            btnSelectFolderSource.UseVisualStyleBackColor = true;
            btnSelectFolderSource.Click += BtnSelectFolderSource_Click;
            // 
            // txtSourceFolder
            // 
            txtSourceFolder.Location = new Point(8, 22);
            txtSourceFolder.Name = "txtSourceFolder";
            txtSourceFolder.ReadOnly = true;
            txtSourceFolder.Size = new Size(244, 23);
            txtSourceFolder.TabIndex = 0;
            // 
            // btnMove
            // 
            btnMove.Location = new Point(376, 151);
            btnMove.Name = "btnMove";
            btnMove.Size = new Size(60, 23);
            btnMove.TabIndex = 2;
            btnMove.Text = "Move";
            btnMove.UseVisualStyleBackColor = true;
            btnMove.Click += BtnMove_Click;
            // 
            // grpTarget
            // 
            grpTarget.Controls.Add(targetGrid);
            grpTarget.Controls.Add(btnSelectFolderTarget);
            grpTarget.Controls.Add(txtTargetFolder);
            grpTarget.Location = new Point(444, 0);
            grpTarget.Name = "grpTarget";
            grpTarget.Size = new Size(366, 318);
            grpTarget.TabIndex = 3;
            grpTarget.TabStop = false;
            grpTarget.Text = "Target";
            // 
            // targetGrid
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            targetGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            targetGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            targetGrid.DefaultCellStyle = dataGridViewCellStyle4;
            targetGrid.Location = new Point(8, 51);
            targetGrid.Name = "targetGrid";
            targetGrid.Size = new Size(352, 261);
            targetGrid.TabIndex = 7;
            // 
            // btnSelectFolderTarget
            // 
            btnSelectFolderTarget.Location = new Point(258, 22);
            btnSelectFolderTarget.Name = "btnSelectFolderTarget";
            btnSelectFolderTarget.Size = new Size(102, 23);
            btnSelectFolderTarget.TabIndex = 1;
            btnSelectFolderTarget.Text = "Select Folder";
            btnSelectFolderTarget.UseVisualStyleBackColor = true;
            btnSelectFolderTarget.Click += BtnSelectFolderTarget_Click;
            // 
            // txtTargetFolder
            // 
            txtTargetFolder.Location = new Point(8, 22);
            txtTargetFolder.Name = "txtTargetFolder";
            txtTargetFolder.ReadOnly = true;
            txtTargetFolder.Size = new Size(244, 23);
            txtTargetFolder.TabIndex = 0;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(451, 335);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(352, 23);
            progressBar1.TabIndex = 8;
            // 
            // lblFileName
            // 
            lblFileName.AutoSize = true;
            lblFileName.Location = new Point(12, 338);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(0, 15);
            lblFileName.TabIndex = 9;
            // 
            // lblPercentage
            // 
            lblPercentage.AutoSize = true;
            lblPercentage.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPercentage.Location = new Point(394, 340);
            lblPercentage.Name = "lblPercentage";
            lblPercentage.Size = new Size(27, 15);
            lblPercentage.TabIndex = 10;
            lblPercentage.Text = "0 %";
            // 
            // MoveFiles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 362);
            Controls.Add(lblPercentage);
            Controls.Add(lblFileName);
            Controls.Add(progressBar1);
            Controls.Add(grpTarget);
            Controls.Add(btnMove);
            Controls.Add(grpSource);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "MoveFiles";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Move Files";
            grpSource.ResumeLayout(false);
            grpSource.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sourceGrid).EndInit();
            grpTarget.ResumeLayout(false);
            grpTarget.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)targetGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpSource;
        private Button btnMove;
        private Button btnSelectFolderSource;
        private TextBox txtSourceFolder;
        private DataGridView sourceGrid;
        private GroupBox grpTarget;
        private DataGridView targetGrid;
        private Button btnSelectFolderTarget;
        private TextBox txtTargetFolder;
        private ProgressBar progressBar1;
        private Label lblFileName;
        private Label lblPercentage;
    }
}