namespace Homework8
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.goodsQuantity = new System.Windows.Forms.TextBox();
            this.goodsName = new System.Windows.Forms.TextBox();
            this.商品编号 = new System.Windows.Forms.Label();
            this.goodsId = new System.Windows.Forms.TextBox();
            this.confirm_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.goodsPrice = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.goodsQuantity, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.goodsName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.商品编号, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.goodsId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.goodsPrice, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(300, 161);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.52941F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.47059F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 136);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "商品名：";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "商品数量：";
            // 
            // goodsQuantity
            // 
            this.goodsQuantity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.goodsQuantity.Location = new System.Drawing.Point(103, 77);
            this.goodsQuantity.Name = "goodsQuantity";
            this.goodsQuantity.Size = new System.Drawing.Size(94, 21);
            this.goodsQuantity.TabIndex = 3;
            // 
            // goodsName
            // 
            this.goodsName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.goodsName.Location = new System.Drawing.Point(103, 43);
            this.goodsName.Name = "goodsName";
            this.goodsName.Size = new System.Drawing.Size(94, 21);
            this.goodsName.TabIndex = 4;
            // 
            // 商品编号
            // 
            this.商品编号.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.商品编号.AutoSize = true;
            this.商品编号.Location = new System.Drawing.Point(32, 12);
            this.商品编号.Name = "商品编号";
            this.商品编号.Size = new System.Drawing.Size(65, 12);
            this.商品编号.TabIndex = 5;
            this.商品编号.Text = "商品编号：";
            // 
            // goodsId
            // 
            this.goodsId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.goodsId.Location = new System.Drawing.Point(103, 8);
            this.goodsId.Name = "goodsId";
            this.goodsId.Size = new System.Drawing.Size(94, 21);
            this.goodsId.TabIndex = 6;
            // 
            // confirm_btn
            // 
            this.confirm_btn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.confirm_btn.Location = new System.Drawing.Point(321, 318);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(75, 23);
            this.confirm_btn.TabIndex = 1;
            this.confirm_btn.Text = "确定";
            this.confirm_btn.UseVisualStyleBackColor = true;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "商品价格：";
            // 
            // goodsPrice
            // 
            this.goodsPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.goodsPrice.Location = new System.Drawing.Point(103, 110);
            this.goodsPrice.Name = "goodsPrice";
            this.goodsPrice.Size = new System.Drawing.Size(94, 21);
            this.goodsPrice.TabIndex = 8;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.confirm_btn);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox goodsQuantity;
        private System.Windows.Forms.TextBox goodsName;
        private System.Windows.Forms.Label 商品编号;
        private System.Windows.Forms.TextBox goodsId;
        private System.Windows.Forms.Button confirm_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox goodsPrice;
    }
}