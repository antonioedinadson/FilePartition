namespace FilePartition
{
    partial class FileTool
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileTool));
            this.txtPATH = new System.Windows.Forms.TextBox();
            this.btnFILE = new System.Windows.Forms.Button();
            this.FileOpen = new System.Windows.Forms.OpenFileDialog();
            this.btnCREATE = new System.Windows.Forms.Button();
            this.btnSAVE = new System.Windows.Forms.Button();
            this.txtSAVE = new System.Windows.Forms.TextBox();
            this.FBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.lbDescSAVE = new System.Windows.Forms.Label();
            this.LBDescGET = new System.Windows.Forms.Label();
            this.txtTotalLines = new System.Windows.Forms.TextBox();
            this.txtTotalFiles = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNAME = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPATH
            // 
            this.txtPATH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPATH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPATH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPATH.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPATH.ForeColor = System.Drawing.Color.Silver;
            this.txtPATH.Location = new System.Drawing.Point(44, 70);
            this.txtPATH.Margin = new System.Windows.Forms.Padding(4);
            this.txtPATH.Name = "txtPATH";
            this.txtPATH.ReadOnly = true;
            this.txtPATH.Size = new System.Drawing.Size(439, 32);
            this.txtPATH.TabIndex = 0;
            this.txtPATH.TextChanged += new System.EventHandler(this.txtPATH_TextChanged);
            // 
            // btnFILE
            // 
            this.btnFILE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFILE.FlatAppearance.BorderSize = 0;
            this.btnFILE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFILE.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFILE.ForeColor = System.Drawing.Color.Gray;
            this.btnFILE.Location = new System.Drawing.Point(490, 70);
            this.btnFILE.Name = "btnFILE";
            this.btnFILE.Size = new System.Drawing.Size(88, 32);
            this.btnFILE.TabIndex = 2;
            this.btnFILE.Text = "SEARCH";
            this.btnFILE.UseVisualStyleBackColor = false;
            this.btnFILE.Click += new System.EventHandler(this.btnFILE_Click);
            // 
            // FileOpen
            // 
            this.FileOpen.FileName = "openFileDialog1";
            // 
            // btnCREATE
            // 
            this.btnCREATE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCREATE.FlatAppearance.BorderSize = 0;
            this.btnCREATE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCREATE.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCREATE.ForeColor = System.Drawing.Color.Gray;
            this.btnCREATE.Location = new System.Drawing.Point(390, 319);
            this.btnCREATE.Name = "btnCREATE";
            this.btnCREATE.Size = new System.Drawing.Size(167, 40);
            this.btnCREATE.TabIndex = 3;
            this.btnCREATE.Text = "CREATE FILES";
            this.btnCREATE.UseVisualStyleBackColor = false;
            this.btnCREATE.Click += new System.EventHandler(this.btnCREATE_Click);
            // 
            // btnSAVE
            // 
            this.btnSAVE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSAVE.FlatAppearance.BorderSize = 0;
            this.btnSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSAVE.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSAVE.ForeColor = System.Drawing.Color.Gray;
            this.btnSAVE.Location = new System.Drawing.Point(490, 133);
            this.btnSAVE.Name = "btnSAVE";
            this.btnSAVE.Size = new System.Drawing.Size(88, 32);
            this.btnSAVE.TabIndex = 6;
            this.btnSAVE.Text = "SEARCH";
            this.btnSAVE.UseVisualStyleBackColor = false;
            this.btnSAVE.Click += new System.EventHandler(this.btnSAVE_Click);
            // 
            // txtSAVE
            // 
            this.txtSAVE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSAVE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSAVE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSAVE.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSAVE.ForeColor = System.Drawing.Color.Silver;
            this.txtSAVE.Location = new System.Drawing.Point(44, 133);
            this.txtSAVE.Margin = new System.Windows.Forms.Padding(4);
            this.txtSAVE.Name = "txtSAVE";
            this.txtSAVE.ReadOnly = true;
            this.txtSAVE.Size = new System.Drawing.Size(439, 32);
            this.txtSAVE.TabIndex = 4;
            // 
            // lbDescSAVE
            // 
            this.lbDescSAVE.AutoSize = true;
            this.lbDescSAVE.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescSAVE.ForeColor = System.Drawing.Color.Gray;
            this.lbDescSAVE.Location = new System.Drawing.Point(41, 115);
            this.lbDescSAVE.Name = "lbDescSAVE";
            this.lbDescSAVE.Size = new System.Drawing.Size(70, 14);
            this.lbDescSAVE.TabIndex = 7;
            this.lbDescSAVE.Text = "SAVE FROM:";
            // 
            // LBDescGET
            // 
            this.LBDescGET.AutoSize = true;
            this.LBDescGET.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBDescGET.ForeColor = System.Drawing.Color.Gray;
            this.LBDescGET.Location = new System.Drawing.Point(41, 52);
            this.LBDescGET.Name = "LBDescGET";
            this.LBDescGET.Size = new System.Drawing.Size(61, 14);
            this.LBDescGET.TabIndex = 8;
            this.LBDescGET.Text = "PATH FILE: ";
            // 
            // txtTotalLines
            // 
            this.txtTotalLines.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTotalLines.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalLines.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalLines.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalLines.ForeColor = System.Drawing.Color.Silver;
            this.txtTotalLines.Location = new System.Drawing.Point(44, 195);
            this.txtTotalLines.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalLines.Name = "txtTotalLines";
            this.txtTotalLines.ReadOnly = true;
            this.txtTotalLines.Size = new System.Drawing.Size(108, 32);
            this.txtTotalLines.TabIndex = 9;
            // 
            // txtTotalFiles
            // 
            this.txtTotalFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTotalFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalFiles.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalFiles.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalFiles.ForeColor = System.Drawing.Color.Silver;
            this.txtTotalFiles.Location = new System.Drawing.Point(169, 195);
            this.txtTotalFiles.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalFiles.Name = "txtTotalFiles";
            this.txtTotalFiles.Size = new System.Drawing.Size(108, 32);
            this.txtTotalFiles.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(41, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 14);
            this.label1.TabIndex = 12;
            this.label1.Text = "TOTAL LINES:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(166, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 14);
            this.label2.TabIndex = 13;
            this.label2.Text = "TOTAL FILES:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(298, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 14);
            this.label3.TabIndex = 15;
            this.label3.Text = "NAME FILE:";
            // 
            // txtNAME
            // 
            this.txtNAME.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNAME.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNAME.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNAME.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNAME.ForeColor = System.Drawing.Color.Silver;
            this.txtNAME.Location = new System.Drawing.Point(301, 195);
            this.txtNAME.Margin = new System.Windows.Forms.Padding(4);
            this.txtNAME.Name = "txtNAME";
            this.txtNAME.Size = new System.Drawing.Size(108, 32);
            this.txtNAME.TabIndex = 14;
            // 
            // FileTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 384);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNAME);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotalFiles);
            this.Controls.Add(this.txtTotalLines);
            this.Controls.Add(this.LBDescGET);
            this.Controls.Add(this.lbDescSAVE);
            this.Controls.Add(this.btnSAVE);
            this.Controls.Add(this.txtSAVE);
            this.Controls.Add(this.btnCREATE);
            this.Controls.Add(this.btnFILE);
            this.Controls.Add(this.txtPATH);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FileTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FilePartitionTool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPATH;
        private System.Windows.Forms.Button btnFILE;
        private System.Windows.Forms.OpenFileDialog FileOpen;
        private System.Windows.Forms.Button btnCREATE;
        private System.Windows.Forms.Button btnSAVE;
        private System.Windows.Forms.TextBox txtSAVE;
        private System.Windows.Forms.FolderBrowserDialog FBrowserDialog;
        private System.Windows.Forms.Label lbDescSAVE;
        private System.Windows.Forms.Label LBDescGET;
        private System.Windows.Forms.TextBox txtTotalLines;
        private System.Windows.Forms.TextBox txtTotalFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNAME;
    }
}

