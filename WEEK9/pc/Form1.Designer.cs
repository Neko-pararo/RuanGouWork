
namespace pc
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvResultDataGridView = new System.Windows.Forms.DataGridView();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtUrlTextBox = new System.Windows.Forms.TextBox();
            this.lblInfoLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dgvResultDataGridView);
            this.flowLayoutPanel1.Controls.Add(this.txtUrlTextBox);
            this.flowLayoutPanel1.Controls.Add(this.lblInfoLabel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(135, 75);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(989, 380);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // dgvResultDataGridView
            // 
            this.dgvResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.URL,
            this.status});
            this.dgvResultDataGridView.Location = new System.Drawing.Point(3, 3);
            this.dgvResultDataGridView.Name = "dgvResultDataGridView";
            this.dgvResultDataGridView.RowHeadersWidth = 82;
            this.dgvResultDataGridView.RowTemplate.Height = 37;
            this.dgvResultDataGridView.Size = new System.Drawing.Size(988, 314);
            this.dgvResultDataGridView.TabIndex = 1;
            this.dgvResultDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultDataGridView_CellContentClick);
            // 
            // index
            // 
            this.index.DataPropertyName = "Index";
            this.index.HeaderText = "序号";
            this.index.MinimumWidth = 10;
            this.index.Name = "index";
            this.index.Width = 200;
            // 
            // URL
            // 
            this.URL.DataPropertyName = "URL";
            this.URL.HeaderText = "URL";
            this.URL.MinimumWidth = 10;
            this.URL.Name = "URL";
            this.URL.Width = 200;
            // 
            // status
            // 
            this.status.DataPropertyName = "Status";
            this.status.HeaderText = "状态";
            this.status.MinimumWidth = 10;
            this.status.Name = "status";
            this.status.Width = 200;
            // 
            // txtUrlTextBox
            // 
            this.txtUrlTextBox.Location = new System.Drawing.Point(3, 323);
            this.txtUrlTextBox.Name = "txtUrlTextBox";
            this.txtUrlTextBox.Size = new System.Drawing.Size(504, 35);
            this.txtUrlTextBox.TabIndex = 2;
            // 
            // lblInfoLabel
            // 
            this.lblInfoLabel.AutoSize = true;
            this.lblInfoLabel.Location = new System.Drawing.Point(513, 320);
            this.lblInfoLabel.Name = "lblInfoLabel";
            this.lblInfoLabel.Size = new System.Drawing.Size(154, 24);
            this.lblInfoLabel.TabIndex = 3;
            this.lblInfoLabel.Text = "lblInfoLabel";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(455, 658);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(281, 86);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "开始爬取";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1676, 870);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvResultDataGridView;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox txtUrlTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn URL;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.Label lblInfoLabel;
    }
}

