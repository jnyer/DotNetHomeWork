namespace Homework7
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
            this.draw = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.len_value = new System.Windows.Forms.NumericUpDown();
            this.len = new System.Windows.Forms.Label();
            this.n_value = new System.Windows.Forms.NumericUpDown();
            this.n = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.th_2_value = new System.Windows.Forms.NumericUpDown();
            this.th_2 = new System.Windows.Forms.Label();
            this.th_1_value = new System.Windows.Forms.NumericUpDown();
            this.th_1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.per_2_value = new System.Windows.Forms.NumericUpDown();
            this.per_2 = new System.Windows.Forms.Label();
            this.per_1_value = new System.Windows.Forms.NumericUpDown();
            this.per_1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.len_value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_value)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.th_2_value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.th_1_value)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.per_2_value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.per_1_value)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // draw
            // 
            this.draw.Location = new System.Drawing.Point(22, 472);
            this.draw.Margin = new System.Windows.Forms.Padding(2);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(120, 18);
            this.draw.TabIndex = 0;
            this.draw.Text = "draw";
            this.draw.UseVisualStyleBackColor = true;
            this.draw.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.draw);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(641, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(166, 494);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "绘制参数";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.41975F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.58025F));
            this.tableLayoutPanel3.Controls.Add(this.len_value, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.len, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.n_value, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.n, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(162, 77);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // len_value
            // 
            this.len_value.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.len_value.Location = new System.Drawing.Point(65, 46);
            this.len_value.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.len_value.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.len_value.Name = "len_value";
            this.len_value.Size = new System.Drawing.Size(90, 21);
            this.len_value.TabIndex = 4;
            this.len_value.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // len
            // 
            this.len.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.len.AutoSize = true;
            this.len.Location = new System.Drawing.Point(3, 45);
            this.len.Name = "len";
            this.len.Size = new System.Drawing.Size(41, 24);
            this.len.TabIndex = 3;
            this.len.Text = "主干长度";
            // 
            // n_value
            // 
            this.n_value.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.n_value.Location = new System.Drawing.Point(65, 8);
            this.n_value.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.n_value.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n_value.Name = "n_value";
            this.n_value.Size = new System.Drawing.Size(90, 21);
            this.n_value.TabIndex = 2;
            this.n_value.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // n
            // 
            this.n.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.n.AutoSize = true;
            this.n.Location = new System.Drawing.Point(3, 6);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(41, 24);
            this.n.TabIndex = 0;
            this.n.Text = "递归深度";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel4);
            this.groupBox4.Location = new System.Drawing.Point(4, 329);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(150, 140);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "画笔颜色";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel2);
            this.groupBox3.Location = new System.Drawing.Point(2, 229);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(162, 95);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "分支角度";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.17722F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.82278F));
            this.tableLayoutPanel2.Controls.Add(this.th_2_value, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.th_2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.th_1_value, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.th_1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(158, 77);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // th_2_value
            // 
            this.th_2_value.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.th_2_value.Location = new System.Drawing.Point(61, 46);
            this.th_2_value.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.th_2_value.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.th_2_value.Name = "th_2_value";
            this.th_2_value.Size = new System.Drawing.Size(90, 21);
            this.th_2_value.TabIndex = 4;
            this.th_2_value.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // th_2
            // 
            this.th_2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.th_2.AutoSize = true;
            this.th_2.Location = new System.Drawing.Point(3, 51);
            this.th_2.Name = "th_2";
            this.th_2.Size = new System.Drawing.Size(41, 12);
            this.th_2.TabIndex = 3;
            this.th_2.Text = "左分支";
            // 
            // th_1_value
            // 
            this.th_1_value.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.th_1_value.Location = new System.Drawing.Point(61, 8);
            this.th_1_value.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.th_1_value.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.th_1_value.Name = "th_1_value";
            this.th_1_value.Size = new System.Drawing.Size(90, 21);
            this.th_1_value.TabIndex = 2;
            this.th_1_value.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // th_1
            // 
            this.th_1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.th_1.AutoSize = true;
            this.th_1.Location = new System.Drawing.Point(3, 12);
            this.th_1.Name = "th_1";
            this.th_1.Size = new System.Drawing.Size(41, 12);
            this.th_1.TabIndex = 0;
            this.th_1.Text = "右分支";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Location = new System.Drawing.Point(0, 115);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(162, 95);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "分支长度比";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.17722F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.82278F));
            this.tableLayoutPanel1.Controls.Add(this.per_2_value, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.per_2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.per_1_value, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.per_1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(158, 77);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // per_2_value
            // 
            this.per_2_value.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.per_2_value.DecimalPlaces = 1;
            this.per_2_value.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.per_2_value.Location = new System.Drawing.Point(61, 46);
            this.per_2_value.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.per_2_value.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.per_2_value.Name = "per_2_value";
            this.per_2_value.Size = new System.Drawing.Size(90, 21);
            this.per_2_value.TabIndex = 4;
            this.per_2_value.Value = new decimal(new int[] {
            6,
            0,
            0,
            65536});
            // 
            // per_2
            // 
            this.per_2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.per_2.AutoSize = true;
            this.per_2.Location = new System.Drawing.Point(3, 51);
            this.per_2.Name = "per_2";
            this.per_2.Size = new System.Drawing.Size(41, 12);
            this.per_2.TabIndex = 3;
            this.per_2.Text = "左分支";
            // 
            // per_1_value
            // 
            this.per_1_value.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.per_1_value.DecimalPlaces = 1;
            this.per_1_value.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.per_1_value.Location = new System.Drawing.Point(61, 8);
            this.per_1_value.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.per_1_value.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.per_1_value.Name = "per_1_value";
            this.per_1_value.Size = new System.Drawing.Size(90, 21);
            this.per_1_value.TabIndex = 2;
            this.per_1_value.Value = new decimal(new int[] {
            7,
            0,
            0,
            65536});
            // 
            // per_1
            // 
            this.per_1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.per_1.AutoSize = true;
            this.per_1.Location = new System.Drawing.Point(3, 12);
            this.per_1.Name = "per_1";
            this.per_1.Size = new System.Drawing.Size(41, 12);
            this.per_1.TabIndex = 0;
            this.per_1.Text = "右分支";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.button1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.16666F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.83333F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(144, 120);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(28, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "选择颜色...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 82);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Location = new System.Drawing.Point(18, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 70);
            this.panel2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 494);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.len_value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_value)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.th_2_value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.th_1_value)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.per_2_value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.per_1_value)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button draw;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label per_1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.NumericUpDown len_value;
        private System.Windows.Forms.Label len;
        private System.Windows.Forms.NumericUpDown n_value;
        private System.Windows.Forms.Label n;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.NumericUpDown th_2_value;
        private System.Windows.Forms.Label th_2;
        private System.Windows.Forms.NumericUpDown th_1_value;
        private System.Windows.Forms.Label th_1;
        private System.Windows.Forms.NumericUpDown per_2_value;
        private System.Windows.Forms.Label per_2;
        private System.Windows.Forms.NumericUpDown per_1_value;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

