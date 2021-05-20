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
            this.panelQuery = new System.Windows.Forms.Panel();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.textBoxQuery = new System.Windows.Forms.TextBox();
            this.comboBoxQuery = new System.Windows.Forms.ComboBox();
            this.panelService = new System.Windows.Forms.Panel();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonImport = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panelResult = new System.Windows.Forms.Panel();
            this.dataGridViewOrderdetail = new System.Windows.Forms.DataGridView();
            this.goodsIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderSumPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelQuery.SuspendLayout();
            this.panelService.SuspendLayout();
            this.panelResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderdetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // panelQuery
            // 
            this.panelQuery.Controls.Add(this.buttonQuery);
            this.panelQuery.Controls.Add(this.textBoxQuery);
            this.panelQuery.Controls.Add(this.comboBoxQuery);
            this.panelQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuery.Location = new System.Drawing.Point(0, 0);
            this.panelQuery.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelQuery.Name = "panelQuery";
            this.panelQuery.Size = new System.Drawing.Size(1013, 65);
            this.panelQuery.TabIndex = 0;
            // 
            // buttonQuery
            // 
            this.buttonQuery.Location = new System.Drawing.Point(281, 24);
            this.buttonQuery.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(56, 20);
            this.buttonQuery.TabIndex = 2;
            this.buttonQuery.Text = "查询";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // textBoxQuery
            // 
            this.textBoxQuery.Location = new System.Drawing.Point(146, 24);
            this.textBoxQuery.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxQuery.Name = "textBoxQuery";
            this.textBoxQuery.Size = new System.Drawing.Size(105, 21);
            this.textBoxQuery.TabIndex = 1;
            // 
            // comboBoxQuery
            // 
            this.comboBoxQuery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQuery.FormattingEnabled = true;
            this.comboBoxQuery.Location = new System.Drawing.Point(28, 24);
            this.comboBoxQuery.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxQuery.Name = "comboBoxQuery";
            this.comboBoxQuery.Size = new System.Drawing.Size(92, 20);
            this.comboBoxQuery.TabIndex = 0;
            // 
            // panelService
            // 
            this.panelService.Controls.Add(this.buttonExport);
            this.panelService.Controls.Add(this.buttonImport);
            this.panelService.Controls.Add(this.buttonDelete);
            this.panelService.Controls.Add(this.buttonModify);
            this.panelService.Controls.Add(this.buttonAdd);
            this.panelService.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelService.Location = new System.Drawing.Point(0, 65);
            this.panelService.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelService.Name = "panelService";
            this.panelService.Size = new System.Drawing.Size(1013, 37);
            this.panelService.TabIndex = 1;
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(374, 6);
            this.buttonExport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(82, 23);
            this.buttonExport.TabIndex = 4;
            this.buttonExport.Text = "导出订单";
            this.buttonExport.UseVisualStyleBackColor = true;
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(287, 6);
            this.buttonImport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(82, 23);
            this.buttonImport.TabIndex = 3;
            this.buttonImport.Text = "导入订单";
            this.buttonImport.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(200, 6);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(82, 23);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "删除订单";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(114, 6);
            this.buttonModify.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(82, 23);
            this.buttonModify.TabIndex = 1;
            this.buttonModify.Text = "修改订单";
            this.buttonModify.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(28, 6);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(82, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "新建订单";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // panelResult
            // 
            this.panelResult.Controls.Add(this.dataGridViewOrderdetail);
            this.panelResult.Controls.Add(this.dataGridViewOrder);
            this.panelResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelResult.Location = new System.Drawing.Point(0, 102);
            this.panelResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(1013, 455);
            this.panelResult.TabIndex = 2;
            // 
            // dataGridViewOrderdetail
            // 
            this.dataGridViewOrderdetail.AutoGenerateColumns = false;
            this.dataGridViewOrderdetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderdetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goodsIdDataGridViewTextBoxColumn,
            this.goodsNameDataGridViewTextBoxColumn,
            this.goodsNumberDataGridViewTextBoxColumn,
            this.goodsPriceDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn});
            this.dataGridViewOrderdetail.DataSource = this.orderDetailBindingSource;
            this.dataGridViewOrderdetail.Location = new System.Drawing.Point(435, 5);
            this.dataGridViewOrderdetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewOrderdetail.Name = "dataGridViewOrderdetail";
            this.dataGridViewOrderdetail.RowHeadersWidth = 51;
            this.dataGridViewOrderdetail.RowTemplate.Height = 27;
            this.dataGridViewOrderdetail.Size = new System.Drawing.Size(576, 428);
            this.dataGridViewOrderdetail.TabIndex = 1;
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
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(Homework8.Order);
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.AutoGenerateColumns = false;
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIdDataGridViewTextBoxColumn,
            this.orderClientDataGridViewTextBoxColumn,
            this.orderSumPriceDataGridViewTextBoxColumn});
            this.dataGridViewOrder.DataSource = this.orderBindingSource;
            this.dataGridViewOrder.Location = new System.Drawing.Point(9, 5);
            this.dataGridViewOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.RowHeadersWidth = 51;
            this.dataGridViewOrder.RowTemplate.Height = 27;
            this.dataGridViewOrder.Size = new System.Drawing.Size(422, 428);
            this.dataGridViewOrder.TabIndex = 0;
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            this.orderIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderClientDataGridViewTextBoxColumn
            // 
            this.orderClientDataGridViewTextBoxColumn.DataPropertyName = "OrderClient";
            this.orderClientDataGridViewTextBoxColumn.HeaderText = "OrderClient";
            this.orderClientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderClientDataGridViewTextBoxColumn.Name = "orderClientDataGridViewTextBoxColumn";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 557);
            this.Controls.Add(this.panelResult);
            this.Controls.Add(this.panelService);
            this.Controls.Add(this.panelQuery);
            this.Name = "Form1";
            this.Text = "新建订单";
            this.panelQuery.ResumeLayout(false);
            this.panelQuery.PerformLayout();
            this.panelService.ResumeLayout(false);
            this.panelResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderdetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panelQuery;
        private System.Windows.Forms.Button buttonQuery;
        private System.Windows.Forms.TextBox textBoxQuery;
        private System.Windows.Forms.ComboBox comboBoxQuery;
        private System.Windows.Forms.Panel panelService;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.DataGridView dataGridViewOrderdetail;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderDetailBindingSource;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderSumPriceDataGridViewTextBoxColumn;
    }
}

