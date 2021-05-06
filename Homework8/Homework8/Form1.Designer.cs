namespace Homework8
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderSumPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.goodsIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.searchByOrderPrice_button = new System.Windows.Forms.Button();
            this.searchByNumber_button = new System.Windows.Forms.Button();
            this.searchByGoodsName_button = new System.Windows.Forms.Button();
            this.searchByClient_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.create_button = new System.Windows.Forms.Button();
            this.revise_button = new System.Windows.Forms.Button();
            this.import_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIdDataGridViewTextBoxColumn,
            this.orderClientDataGridViewTextBoxColumn,
            this.orderSumPriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(460, 281);
            this.dataGridView1.TabIndex = 2;
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            this.orderIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderClientDataGridViewTextBoxColumn
            // 
            this.orderClientDataGridViewTextBoxColumn.DataPropertyName = "OrderClient";
            this.orderClientDataGridViewTextBoxColumn.HeaderText = "OrderClient";
            this.orderClientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderClientDataGridViewTextBoxColumn.Name = "orderClientDataGridViewTextBoxColumn";
            this.orderClientDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderClientDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderSumPriceDataGridViewTextBoxColumn
            // 
            this.orderSumPriceDataGridViewTextBoxColumn.DataPropertyName = "OrderSumPrice";
            this.orderSumPriceDataGridViewTextBoxColumn.HeaderText = "OrderSumPrice";
            this.orderSumPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderSumPriceDataGridViewTextBoxColumn.Name = "orderSumPriceDataGridViewTextBoxColumn";
            this.orderSumPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderSumPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.AllowNew = true;
            this.orderBindingSource.DataSource = typeof(Homework8.Order);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goodsIdDataGridViewTextBoxColumn,
            this.goodsNameDataGridViewTextBoxColumn,
            this.goodsNumberDataGridViewTextBoxColumn,
            this.goodsPriceDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.orderDetailBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(472, 4);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(591, 281);
            this.dataGridView2.TabIndex = 3;
            // 
            // goodsIdDataGridViewTextBoxColumn
            // 
            this.goodsIdDataGridViewTextBoxColumn.DataPropertyName = "GoodsId";
            this.goodsIdDataGridViewTextBoxColumn.HeaderText = "GoodsId";
            this.goodsIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodsIdDataGridViewTextBoxColumn.Name = "goodsIdDataGridViewTextBoxColumn";
            this.goodsIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // goodsNameDataGridViewTextBoxColumn
            // 
            this.goodsNameDataGridViewTextBoxColumn.DataPropertyName = "GoodsName";
            this.goodsNameDataGridViewTextBoxColumn.HeaderText = "GoodsName";
            this.goodsNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodsNameDataGridViewTextBoxColumn.Name = "goodsNameDataGridViewTextBoxColumn";
            this.goodsNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // goodsNumberDataGridViewTextBoxColumn
            // 
            this.goodsNumberDataGridViewTextBoxColumn.DataPropertyName = "GoodsNumber";
            this.goodsNumberDataGridViewTextBoxColumn.HeaderText = "GoodsNumber";
            this.goodsNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodsNumberDataGridViewTextBoxColumn.Name = "goodsNumberDataGridViewTextBoxColumn";
            this.goodsNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // goodsPriceDataGridViewTextBoxColumn
            // 
            this.goodsPriceDataGridViewTextBoxColumn.DataPropertyName = "GoodsPrice";
            this.goodsPriceDataGridViewTextBoxColumn.HeaderText = "GoodsPrice";
            this.goodsPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodsPriceDataGridViewTextBoxColumn.Name = "goodsPriceDataGridViewTextBoxColumn";
            this.goodsPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderDetailBindingSource
            // 
            this.orderDetailBindingSource.DataMember = "OrderDetails";
            this.orderDetailBindingSource.DataSource = this.orderBindingSource;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.875F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.125F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1067, 289);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 289);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 358);
            this.panel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel4);
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 125);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1067, 111);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查找订单";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.87405F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.12595F));
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 22);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1059, 40);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(427, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "查询关键字：";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox1.Location = new System.Drawing.Point(532, 7);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 25);
            this.textBox1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.24528F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.75472F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 269F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 264F));
            this.tableLayoutPanel3.Controls.Add(this.searchByOrderPrice_button, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.searchByNumber_button, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.searchByGoodsName_button, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.searchByClient_button, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 61);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1059, 46);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // searchByOrderPrice_button
            // 
            this.searchByOrderPrice_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchByOrderPrice_button.Location = new System.Drawing.Point(802, 8);
            this.searchByOrderPrice_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchByOrderPrice_button.Name = "searchByOrderPrice_button";
            this.searchByOrderPrice_button.Size = new System.Drawing.Size(248, 29);
            this.searchByOrderPrice_button.TabIndex = 3;
            this.searchByOrderPrice_button.Text = "按订单总价格查询";
            this.searchByOrderPrice_button.UseVisualStyleBackColor = true;
            // 
            // searchByNumber_button
            // 
            this.searchByNumber_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchByNumber_button.Location = new System.Drawing.Point(4, 8);
            this.searchByNumber_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchByNumber_button.Name = "searchByNumber_button";
            this.searchByNumber_button.Size = new System.Drawing.Size(251, 29);
            this.searchByNumber_button.TabIndex = 0;
            this.searchByNumber_button.Text = "按订单号查询";
            this.searchByNumber_button.UseVisualStyleBackColor = true;
            // 
            // searchByGoodsName_button
            // 
            this.searchByGoodsName_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchByGoodsName_button.Location = new System.Drawing.Point(531, 8);
            this.searchByGoodsName_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchByGoodsName_button.Name = "searchByGoodsName_button";
            this.searchByGoodsName_button.Size = new System.Drawing.Size(257, 29);
            this.searchByGoodsName_button.TabIndex = 1;
            this.searchByGoodsName_button.Text = "按商品名称查询";
            this.searchByGoodsName_button.UseVisualStyleBackColor = true;
            // 
            // searchByClient_button
            // 
            this.searchByClient_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchByClient_button.Location = new System.Drawing.Point(263, 8);
            this.searchByClient_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchByClient_button.Name = "searchByClient_button";
            this.searchByClient_button.Size = new System.Drawing.Size(258, 29);
            this.searchByClient_button.TabIndex = 2;
            this.searchByClient_button.Text = "按客户名查询";
            this.searchByClient_button.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.create_button, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.revise_button, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.import_button, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.delete_button, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1067, 125);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // create_button
            // 
            this.create_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.create_button.Location = new System.Drawing.Point(216, 16);
            this.create_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(100, 29);
            this.create_button.TabIndex = 0;
            this.create_button.Text = "新建订单";
            this.create_button.UseVisualStyleBackColor = true;
            this.create_button.Click += new System.EventHandler(this.create_button_Click);
            // 
            // revise_button
            // 
            this.revise_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.revise_button.Location = new System.Drawing.Point(216, 79);
            this.revise_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.revise_button.Name = "revise_button";
            this.revise_button.Size = new System.Drawing.Size(100, 29);
            this.revise_button.TabIndex = 2;
            this.revise_button.Text = "修改订单";
            this.revise_button.UseVisualStyleBackColor = true;
            this.revise_button.Click += new System.EventHandler(this.revise_button_Click);
            // 
            // import_button
            // 
            this.import_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.import_button.Location = new System.Drawing.Point(750, 79);
            this.import_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.import_button.Name = "import_button";
            this.import_button.Size = new System.Drawing.Size(100, 29);
            this.import_button.TabIndex = 3;
            this.import_button.Text = "导入订单";
            this.import_button.UseVisualStyleBackColor = true;
            this.import_button.Click += new System.EventHandler(this.import_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.delete_button.Location = new System.Drawing.Point(750, 16);
            this.delete_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(100, 29);
            this.delete_button.TabIndex = 1;
            this.delete_button.Text = "删除订单";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 696);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsDataGridViewTextBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button create_button;
        private System.Windows.Forms.Button revise_button;
        private System.Windows.Forms.Button import_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderSumPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderDetailBindingSource;
        public System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button searchByOrderPrice_button;
        private System.Windows.Forms.Button searchByNumber_button;
        private System.Windows.Forms.Button searchByGoodsName_button;
        private System.Windows.Forms.Button searchByClient_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

