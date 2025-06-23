namespace PhotoManagement
{
    public partial class MoveFiles : Form
    {
        public MoveFiles()
        {
            InitializeComponent();
        }

        private void BtnSelectFolderSource_Click(object sender, EventArgs e)
        {
            var folderPath = txtSourceFolder.Text = SelectFolder();
            if (string.IsNullOrEmpty(folderPath) || !Directory.Exists(folderPath))
            {
                MessageBox.Show("Please select a valid folder.");
                return;
            }

            BindGrid(folderPath, sourceGrid, grpSource);
        }



        private void BtnSelectFolderTarget_Click(object sender, EventArgs e)
        {
            var folderPath = txtTargetFolder.Text = SelectFolder();
            if (string.IsNullOrEmpty(folderPath) || !Directory.Exists(folderPath))
            {
                MessageBox.Show("Please select a valid folder.");
                return;
            }

            BindGrid(folderPath, targetGrid, grpTarget);
        }

        private void BtnMove_Click(object sender, EventArgs e)
        {
            var list = sourceGrid.DataSource as List<Photos>;
            var allowedExtensions = new List<string> { ".jpg", ".jpeg", ".gif", ".mp4", ".heic", ".mov", ".png" };
            if (list != null)
            {
                progressBar1.Maximum = list.Count;
                progressBar1.Value = 0;

                Task.Run(() =>
                {
                    var filteredList = list.Where(x => allowedExtensions.Contains(x.Extension.ToLower())).ToList();
                    int i = 0;
                    var failedFiles = new List<string>();

                    foreach (var file in filteredList)
                    {
                        string targetPath = Path.Combine(txtTargetFolder.Text, file.FileName);
                        try
                        {
                            File.Move(file.Path, targetPath, false); // Do not overwrite
                        }
                        catch (Exception ex)
                        {
                            failedFiles.Add($"{file.FileName}: {ex.Message}");
                        }
                        i++;

                        if (i % 5 == 0 || i == filteredList.Count) // Update UI every 5 files or at the end
                        {
                            this.Invoke(() =>
                            {
                                lblFileName.Text = $"Moving File: {file.FileName}";
                                lblPercentage.Text = $"{((i * 100.0) / filteredList.Count):0.00}%";
                                progressBar1.Value = i;
                            });
                        }
                    }

                    return failedFiles;
                })
                .ContinueWith(t =>
                {
                    if (t.IsFaulted)
                    {
                        MessageBox.Show("An error occurred while moving files: " + t.Exception?.Message);
                    }
                    else if (t.Result != null && t.Result.Count > 0)
                    {
                        MessageBox.Show($"Some files could not be moved:\n{string.Join("\n", t.Result)}");
                    }
                    else
                    {
                        BindGrid(txtTargetFolder.Text, targetGrid, grpTarget);
                        BindGrid(txtSourceFolder.Text, sourceGrid, grpSource);
                      
                        MessageBox.Show($"Files moved successfully!");
                        progressBar1.Value = 0;
                        lblFileName.Text = string.Empty;
                        lblPercentage.Text = string.Empty;
                    }
                }, TaskScheduler.FromCurrentSynchronizationContext());

            }
        }


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

        private static void BindGrid(string folderPath, DataGridView grid, GroupBox groupBox)
        {
            string originalText = groupBox.Text.Split('-')[0].Trim();
            Task.Run(() =>
            {
                return GetFilesList(folderPath);
            }).ContinueWith(t =>
            {
                if (t.IsFaulted)
                {
                    MessageBox.Show("An error occurred while binding the target grid: " + t.Exception?.Message);
                }
                else
                {
                    grid.DataSource = t.Result;
                    groupBox.Text = $"{originalText} - {t.Result.Count} files";
                }
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private static Task<List<Photos>> GetFilesList(string folderPath)
        {
            return Task.Run(() =>
              {

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

                  return list;
              });
        }
        #endregion

    }
}
