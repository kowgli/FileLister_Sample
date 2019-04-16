using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileLister
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BPickRootDir_Click(object sender, EventArgs e)
        {
            if(fbdRootDir.ShowDialog() == DialogResult.OK)
            {
                tbRootDir.Text = fbdRootDir.SelectedPath;
            }
        }

        private void BSearch_Click(object sender, EventArgs e)
        {
            string rootDir = tbRootDir.Text;
            int currentDepth = 0;
            int maxDepth = (int) nudMaxDepth.Value;
            ConcurrentBag<string> allFiles = new ConcurrentBag<string>();

            GetFiles(rootDir, currentDepth, maxDepth, allFiles);

            string[] filesSorted = allFiles
                                   .OrderBy(s => s)
                                   .Select(s => s)
                                   .ToArray();

            lboxResult.Items.Clear();
            lboxResult.Items.AddRange(filesSorted);
        }

        private void GetFiles(string directory, int currentDepth, int maxDepth, ConcurrentBag<string> allFiles)
        {
            try
            {
                if (currentDepth >= maxDepth) { return; }

                var dirInfo = new DirectoryInfo(directory);

                var files = dirInfo.GetFiles();

                foreach (var file in files)
                {
                    allFiles.Add(file.FullName);
                }

                var subDirs = dirInfo.GetDirectories();

                Parallel.ForEach(subDirs, subDir =>
                {
                    GetFiles(subDir.FullName, currentDepth + 1, maxDepth, allFiles);
                });
            }
            catch { }
        }
    }
}
