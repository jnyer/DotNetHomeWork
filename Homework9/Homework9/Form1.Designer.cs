namespace Homework9
{
    partial class Form1
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.InfoLab = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.InfoLab);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.TextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(699, 100);
            this.panel2.TabIndex = 0;
            // 
            // TextBox
            // 
            this.TextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TextBox.Location = new System.Drawing.Point(26, 25);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(229, 21);
            this.TextBox.TabIndex = 0;
            this.TextBox.Text = "http://www.cnblogs.com/dstang2000/";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "开始爬取";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.startButton_Click);
            // 
            // InfoLab
            // 
            this.InfoLab.AutoSize = true;
            this.InfoLab.Location = new System.Drawing.Point(26, 85);
            this.InfoLab.Name = "InfoLab";
            this.InfoLab.Size = new System.Drawing.Size(0, 12);
            this.InfoLab.TabIndex = 2;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序号,
            this.Url,
            this.status});
            this.dataGridView.Location = new System.Drawing.Point(12, 106);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(675, 302);
            this.dataGridView.TabIndex = 1;
            // 
            // 序号
            // 
            this.序号.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.序号.DataPropertyName = "Index";
            this.序号.HeaderText = "序号";
            this.序号.Name = "序号";
            this.序号.Width = 54;
            // 
            // Url
            // 
            this.Url.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Url.DataPropertyName = "URL";
            this.Url.HeaderText = "Url";
            this.Url.Name = "Url";
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.status.DataPropertyName = "Status";
            this.status.HeaderText = "状态";
            this.status.Name = "status";
            this.status.Width = 54;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(699, 420);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Label InfoLab;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn Url;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}

