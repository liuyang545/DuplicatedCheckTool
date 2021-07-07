
namespace DuplicatedCheckTool
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cklDisk = new System.Windows.Forms.CheckedListBox();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.cmbOne = new System.Windows.Forms.ComboBox();
            this.lbResult = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lkFileCount = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // cklDisk
            // 
            this.cklDisk.Dock = System.Windows.Forms.DockStyle.Left;
            this.cklDisk.FormattingEnabled = true;
            this.cklDisk.Items.AddRange(new object[] {
            "B:\\",
            "D:\\",
            "E:\\",
            "F:\\",
            "G:\\",
            "H:\\",
            "I:\\",
            "J:\\",
            "K:\\",
            "L:\\",
            "M:\\",
            "N:\\",
            "O:\\",
            "P:\\",
            "Q:\\",
            "R:\\",
            "S:\\",
            "T:\\",
            "U:\\",
            "V:\\",
            "W:\\",
            "X:\\",
            "Y:\\",
            "Z:\\"});
            this.cklDisk.Location = new System.Drawing.Point(0, 0);
            this.cklDisk.Name = "cklDisk";
            this.cklDisk.Size = new System.Drawing.Size(136, 611);
            this.cklDisk.TabIndex = 0;
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(142, 91);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(91, 23);
            this.btnOne.TabIndex = 1;
            this.btnOne.Text = "Compare One";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(142, 353);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(91, 23);
            this.btnAll.TabIndex = 2;
            this.btnAll.Text = "Compare All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(142, 26);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(91, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load Files";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // cmbOne
            // 
            this.cmbOne.FormattingEnabled = true;
            this.cmbOne.Items.AddRange(new object[] {
            "B:\\",
            "D:\\",
            "E:\\",
            "F:\\",
            "G:\\",
            "H:\\",
            "I:\\",
            "J:\\",
            "K:\\",
            "L:\\",
            "M:\\",
            "N:\\",
            "O:\\",
            "P:\\",
            "Q:\\",
            "R:\\",
            "S:\\",
            "T:\\",
            "U:\\",
            "V:\\",
            "W:\\",
            "X:\\",
            "Y:\\",
            "Z:\\"});
            this.cmbOne.Location = new System.Drawing.Point(143, 221);
            this.cmbOne.Name = "cmbOne";
            this.cmbOne.Size = new System.Drawing.Size(90, 20);
            this.cmbOne.TabIndex = 4;
            // 
            // lbResult
            // 
            this.lbResult.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbResult.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbResult.FormattingEnabled = true;
            this.lbResult.Location = new System.Drawing.Point(250, 0);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(734, 611);
            this.lbResult.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Files:";
            // 
            // lkFileCount
            // 
            this.lkFileCount.AutoSize = true;
            this.lkFileCount.Location = new System.Drawing.Point(142, 411);
            this.lkFileCount.Name = "lkFileCount";
            this.lkFileCount.Size = new System.Drawing.Size(11, 12);
            this.lkFileCount.TabIndex = 7;
            this.lkFileCount.TabStop = true;
            this.lkFileCount.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.lkFileCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.cmbOne);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.cklDisk);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scan Compare Disk";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox cklDisk;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ComboBox cmbOne;
        private System.Windows.Forms.ListBox lbResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lkFileCount;
    }
}

