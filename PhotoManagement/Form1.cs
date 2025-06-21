namespace PhotoManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Form Events
        private void BtnSourceFolder_Click(object sender, EventArgs e)
        {
            txtSourceFolder.Text = SelectFolder();
            BindGrid(txtSourceFolder.Text, sourceGrid, lblSourceTotalFiles);
        }

        private void BtnTargetFolder_Click(object sender, EventArgs e)
        {
            txtTargetFolder.Text = SelectFolder();
            BindGrid(txtTargetFolder.Text, TargetGrid, lblTargetTotalFiles);
        }

        private void BtnMove_Click(object sender, EventArgs e)
        {
            var list = sourceGrid.DataSource;
            var allowedExtensions = new List<string> { ".jpg", ".jpeg", ".gif", ".mp4", ".heic", ".mov", ".png" };

            if (list != null)
            {
                var sourceList = (List<Photos>)list;
                var FilteredList = sourceList.Where(x => allowedExtensions.Contains(x.Extension.ToLower()));
                lblTotalMovingFiles.Text = $"Totel Files: {FilteredList.Count()}";
                lblTotalMovingFiles.Refresh();
                int i = 1;
                progressBar1.Maximum = FilteredList.Count();
                progressBar1.Value = 0;

                foreach (var file in FilteredList)
                {
                    lblCurrentFile.Text = $"{i}: {file.FileName}";
                    lblCurrentFile.Refresh();

                    string targetPath = Path.Combine(txtTargetFolder.Text, file.FileName);
                    File.Move(file.Path, targetPath, true);
                    progressBar1.Value = i;
                    i++;
                }
                MessageBox.Show("Files moved successfully!");
                RefreshGrids();
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            RefreshGrids();
        }

        #endregion



        #region Suporting methods
        private static string SelectFolder()
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Select a folder";
                folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
                folderBrowserDialog.ShowNewFolderButton = false;

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the path of the selected folder
                    return folderBrowserDialog.SelectedPath;
                }
            }
            return string.Empty; // Return an empty string if no folder is selected
        }

        private static void BindGrid(string folderPath, DataGridView grid, Label label)
        {
            if (string.IsNullOrEmpty(folderPath) || !Directory.Exists(folderPath))
            {
                MessageBox.Show("Please select a valid folder.");
                return;
            }

            string[] files = Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories);
            var list = new List<Photos>();
            foreach (var filePath in files)
            {
                var fileInfo = new FileInfo(filePath);

                if (fileInfo.Exists)
                {
                    // Create a new File object and add it to the list
                    list.Add(new Photos(fileInfo.Name, filePath, fileInfo.Extension));
                }
            }

            grid.DataSource = list;
            label.Text = list.Count.ToString();
        }

        private void RefreshGrids()
        {
            BindGrid(txtSourceFolder.Text, sourceGrid, lblSourceTotalFiles);
            BindGrid(txtTargetFolder.Text, TargetGrid, lblTargetTotalFiles);
            progressBar1.Value = 0;
            lblTotalMovingFiles.Text = string.Empty;
            lblCurrentFile.Text = string.Empty;
        }
        #endregion
    }
}
