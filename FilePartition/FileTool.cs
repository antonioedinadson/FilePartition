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

namespace FilePartition
{
    public partial class FileTool : Form
    {

        public string[] lines { get; set; }
        public int totalLines { get; set; }
        public int totalLinesPearFile { get; set; }

        public FileTool()
        {
            InitializeComponent();
        }

        private void btnFILE_Click(object sender, EventArgs e)
        {
            if (FileOpen.ShowDialog() == DialogResult.OK)
            {
                txtPATH.Text = FileOpen.FileName;
                LBDescGET.Text = $"PATH FILE: {FileOpen.FileName}";
            }
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            if (FBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtSAVE.Text = FBrowserDialog.SelectedPath;
                lbDescSAVE.Text = $"SAVE FROM: {FBrowserDialog.SelectedPath}";
            }
        }

        private void txtPATH_TextChanged(object sender, EventArgs e)
        {
            lines = File.ReadAllLines(txtPATH.Text);
            totalLines = File.ReadAllLines(txtPATH.Text).Length;
            txtTotalLines.Text = totalLines.ToString();
        }

        private void btnCREATE_Click(object sender, EventArgs e)
        {
            int totalFiles = Convert.ToInt32(txtTotalFiles.Text);

            if (string.IsNullOrEmpty(txtTotalFiles.Text))
            {
                MessageBox.Show("TOTAL FILES REQUIRE.");
                return;
            }

            if (Convert.ToInt32(txtTotalFiles.Text) > totalLines)
            {
                MessageBox.Show("TOTAL FILES AND GREATER THAN THE QUANTITIES OF LINES.");
                return;
            }

            if (string.IsNullOrEmpty(txtPATH.Text) || string.IsNullOrEmpty(txtSAVE.Text))
            {
                MessageBox.Show("PATH FILE AND/OR PATH SAVE");
                return;
            }

            if (string.IsNullOrEmpty(txtNAME.Text))
            {
                MessageBox.Show("NAME FILE REQUIRED.");
                return;
            }

            totalLinesPearFile = (totalLines / totalFiles);

            int i = 0;
            int count = 0;

            while (i < totalFiles)
            {
                i++;                

                for (int j = 0; j < totalLinesPearFile; j++)
                {
                    using (StreamWriter sw = new StreamWriter($@"{txtSAVE.Text}\{txtNAME.Text}{i}.csv", true))
                    {
                        sw.AutoFlush = true;
                        
                        if(!string.IsNullOrEmpty(lines[count]))
                        {
                            sw.Write($"{lines[count]}\n");
                        }

                    };

                    count++;
                }
            }
                        
            MessageBox.Show("Files Created Successfully!");
        }
    }
}
