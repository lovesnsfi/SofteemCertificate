namespace Softeem
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtExcelFilePath = new System.Windows.Forms.TextBox();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOutPutPath = new System.Windows.Forms.TextBox();
            this.btnSelectOut = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPicUrl = new System.Windows.Forms.TextBox();
            this.btnSelectPic = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.picBoxView = new System.Windows.Forms.PictureBox();
            this.bottomStatusStrip = new System.Windows.Forms.StatusStrip();
            this.saveProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxView)).BeginInit();
            this.bottomStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Excel文件";
            // 
            // txtExcelFilePath
            // 
            this.txtExcelFilePath.Location = new System.Drawing.Point(82, 14);
            this.txtExcelFilePath.Name = "txtExcelFilePath";
            this.txtExcelFilePath.ReadOnly = true;
            this.txtExcelFilePath.Size = new System.Drawing.Size(710, 21);
            this.txtExcelFilePath.TabIndex = 1;
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChooseFile.Location = new System.Drawing.Point(810, 13);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(80, 23);
            this.btnChooseFile.TabIndex = 2;
            this.btnChooseFile.Text = "选择Excel";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "生成位置";
            // 
            // txtOutPutPath
            // 
            this.txtOutPutPath.Location = new System.Drawing.Point(82, 77);
            this.txtOutPutPath.Name = "txtOutPutPath";
            this.txtOutPutPath.ReadOnly = true;
            this.txtOutPutPath.Size = new System.Drawing.Size(710, 21);
            this.txtOutPutPath.TabIndex = 4;
            // 
            // btnSelectOut
            // 
            this.btnSelectOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelectOut.Location = new System.Drawing.Point(810, 76);
            this.btnSelectOut.Name = "btnSelectOut";
            this.btnSelectOut.Size = new System.Drawing.Size(80, 23);
            this.btnSelectOut.TabIndex = 2;
            this.btnSelectOut.Text = "选择位置";
            this.btnSelectOut.UseVisualStyleBackColor = true;
            this.btnSelectOut.Click += new System.EventHandler(this.btnSelectOut_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(14, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(702, 351);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "图片模版";
            // 
            // txtPicUrl
            // 
            this.txtPicUrl.Location = new System.Drawing.Point(82, 45);
            this.txtPicUrl.Name = "txtPicUrl";
            this.txtPicUrl.ReadOnly = true;
            this.txtPicUrl.Size = new System.Drawing.Size(710, 21);
            this.txtPicUrl.TabIndex = 1;
            // 
            // btnSelectPic
            // 
            this.btnSelectPic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelectPic.Location = new System.Drawing.Point(810, 44);
            this.btnSelectPic.Name = "btnSelectPic";
            this.btnSelectPic.Size = new System.Drawing.Size(80, 23);
            this.btnSelectPic.TabIndex = 2;
            this.btnSelectPic.Text = "选择图片";
            this.btnSelectPic.UseVisualStyleBackColor = true;
            this.btnSelectPic.Click += new System.EventHandler(this.btnSelectPic_Click);
            // 
            // btnStart
            // 
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Location = new System.Drawing.Point(910, 27);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(66, 54);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "开始生成";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // picBoxView
            // 
            this.picBoxView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxView.Location = new System.Drawing.Point(722, 104);
            this.picBoxView.Name = "picBoxView";
            this.picBoxView.Size = new System.Drawing.Size(253, 351);
            this.picBoxView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxView.TabIndex = 7;
            this.picBoxView.TabStop = false;
            this.picBoxView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.picBoxView_MouseDoubleClick);
            // 
            // bottomStatusStrip
            // 
            this.bottomStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.saveProgressBar});
            this.bottomStatusStrip.Location = new System.Drawing.Point(0, 463);
            this.bottomStatusStrip.Name = "bottomStatusStrip";
            this.bottomStatusStrip.Size = new System.Drawing.Size(987, 22);
            this.bottomStatusStrip.TabIndex = 8;
            this.bottomStatusStrip.Text = "statusStrip1";
            // 
            // saveProgressBar
            // 
            this.saveProgressBar.Name = "saveProgressBar";
            this.saveProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLabel1.Text = "生成进度";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 485);
            this.Controls.Add(this.bottomStatusStrip);
            this.Controls.Add(this.picBoxView);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtOutPutPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelectOut);
            this.Controls.Add(this.btnSelectPic);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.txtPicUrl);
            this.Controls.Add(this.txtExcelFilePath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "软帝结业证制作工具";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxView)).EndInit();
            this.bottomStatusStrip.ResumeLayout(false);
            this.bottomStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExcelFilePath;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOutPutPath;
        private System.Windows.Forms.Button btnSelectOut;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPicUrl;
        private System.Windows.Forms.Button btnSelectPic;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox picBoxView;
        private System.Windows.Forms.StatusStrip bottomStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar saveProgressBar;
    }
}

