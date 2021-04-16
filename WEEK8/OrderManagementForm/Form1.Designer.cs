
using System;
using System.Windows.Forms;

namespace Homework_8
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button8 = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.searchByGoodsNameButton2 = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.searchByCustomerButton1 = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.orderDataGridView = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.indexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queryInputTextBox = new System.Windows.Forms.TextBox();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tableLayoutPanel1.Controls.Add(this.button8, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.addButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.searchByGoodsNameButton2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.updateButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.searchByCustomerButton1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.removeButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.importButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.exportButton, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(781, 271);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(588, 138);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(190, 130);
            this.button8.TabIndex = 7;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(3, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(189, 129);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "添加订单";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // searchByGoodsNameButton2
            // 
            this.searchByGoodsNameButton2.Location = new System.Drawing.Point(393, 138);
            this.searchByGoodsNameButton2.Name = "searchByGoodsNameButton2";
            this.searchByGoodsNameButton2.Size = new System.Drawing.Size(189, 130);
            this.searchByGoodsNameButton2.TabIndex = 6;
            this.searchByGoodsNameButton2.Text = "按货物名查询";
            this.searchByGoodsNameButton2.UseVisualStyleBackColor = true;
            this.searchByGoodsNameButton2.Click += new System.EventHandler(this.searchByGoodsNameButton2_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(198, 3);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(189, 129);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "修改订单";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // searchByCustomerButton1
            // 
            this.searchByCustomerButton1.Location = new System.Drawing.Point(198, 138);
            this.searchByCustomerButton1.Name = "searchByCustomerButton1";
            this.searchByCustomerButton1.Size = new System.Drawing.Size(189, 130);
            this.searchByCustomerButton1.TabIndex = 2;
            this.searchByCustomerButton1.Text = "按客户查询";
            this.searchByCustomerButton1.UseVisualStyleBackColor = true;
            this.searchByCustomerButton1.Click += new System.EventHandler(this.searchByCustomerButton1_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(393, 3);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(189, 129);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "删除订单";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(588, 3);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(190, 129);
            this.importButton.TabIndex = 5;
            this.importButton.Text = "导入订单";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(3, 138);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(189, 130);
            this.exportButton.TabIndex = 2;
            this.exportButton.Text = "导出订单";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // orderDataGridView
            // 
            this.orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIdDataGridViewTextBoxColumn,
            this.Customer,
            this.createTimeDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn});
            this.orderDataGridView.Location = new System.Drawing.Point(384, 470);
            this.orderDataGridView.Name = "orderDataGridView";
            this.orderDataGridView.RowHeadersWidth = 82;
            this.orderDataGridView.RowTemplate.Height = 37;
            this.orderDataGridView.Size = new System.Drawing.Size(889, 71);
            this.orderDataGridView.TabIndex = 2;
            this.orderDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderDataGridView_CellContentClick);
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            this.orderIdDataGridViewTextBoxColumn.Width = 200;
            // 
            // Customer
            // 
            this.Customer.DataPropertyName = "Customer";
            this.Customer.HeaderText = "Customer";
            this.Customer.MinimumWidth = 10;
            this.Customer.Name = "Customer";
            this.Customer.Width = 200;
            // 
            // createTimeDataGridViewTextBoxColumn
            // 
            this.createTimeDataGridViewTextBoxColumn.DataPropertyName = "CreateTime";
            this.createTimeDataGridViewTextBoxColumn.HeaderText = "CreateTime";
            this.createTimeDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.createTimeDataGridViewTextBoxColumn.Name = "createTimeDataGridViewTextBoxColumn";
            this.createTimeDataGridViewTextBoxColumn.Width = 200;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.Width = 200;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.indexDataGridViewTextBoxColumn,
            this.goodsNameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn1});
            this.dataGridView1.Location = new System.Drawing.Point(384, 589);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(1085, 74);
            this.dataGridView1.TabIndex = 3;
            // 
            // indexDataGridViewTextBoxColumn
            // 
            this.indexDataGridViewTextBoxColumn.DataPropertyName = "Index";
            this.indexDataGridViewTextBoxColumn.HeaderText = "Index";
            this.indexDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.indexDataGridViewTextBoxColumn.Name = "indexDataGridViewTextBoxColumn";
            this.indexDataGridViewTextBoxColumn.Width = 200;
            // 
            // goodsNameDataGridViewTextBoxColumn
            // 
            this.goodsNameDataGridViewTextBoxColumn.DataPropertyName = "GoodsName";
            this.goodsNameDataGridViewTextBoxColumn.HeaderText = "GoodsName";
            this.goodsNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.goodsNameDataGridViewTextBoxColumn.Name = "goodsNameDataGridViewTextBoxColumn";
            this.goodsNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 200;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 200;
            // 
            // totalPriceDataGridViewTextBoxColumn1
            // 
            this.totalPriceDataGridViewTextBoxColumn1.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn1.HeaderText = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.totalPriceDataGridViewTextBoxColumn1.Name = "totalPriceDataGridViewTextBoxColumn1";
            this.totalPriceDataGridViewTextBoxColumn1.Width = 200;
            // 
            // queryInputTextBox
            // 
            this.queryInputTextBox.Location = new System.Drawing.Point(967, 150);
            this.queryInputTextBox.Name = "queryInputTextBox";
            this.queryInputTextBox.Size = new System.Drawing.Size(306, 35);
            this.queryInputTextBox.TabIndex = 4;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "typeof(Homework_8.Order)";
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // itemDataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1541, 923);
            this.Controls.Add(this.queryInputTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.orderDataGridView);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "itemDataGridView";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void orderDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button searchByGoodsNameButton2;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button searchByCustomerButton1;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.DataGridView orderDataGridView;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn indexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox queryInputTextBox;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private EventHandler bindingSource1_CurrentChanged;
    }
}

