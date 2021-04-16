
namespace OrderManagementForm
{
    partial class Form2
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
            this.orderIDTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.customerTextBox = new System.Windows.Forms.TextBox();
            this.indexTextBox = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.GoodsNameTextBox = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.okbutton = new System.Windows.Forms.Button();
            this.GoodsNameTextBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderIDTextBox
            // 
            this.orderIDTextBox.Location = new System.Drawing.Point(196, 20);
            this.orderIDTextBox.Name = "orderIDTextBox";
            this.orderIDTextBox.Size = new System.Drawing.Size(196, 35);
            this.orderIDTextBox.TabIndex = 0;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(196, 93);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(196, 35);
            this.PriceTextBox.TabIndex = 1;
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(196, 329);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(196, 35);
            this.QuantityTextBox.TabIndex = 2;
            // 
            // customerTextBox
            // 
            this.customerTextBox.Location = new System.Drawing.Point(196, 165);
            this.customerTextBox.Name = "customerTextBox";
            this.customerTextBox.Size = new System.Drawing.Size(193, 35);
            this.customerTextBox.TabIndex = 3;
            // 
            // indexTextBox
            // 
            this.indexTextBox.Location = new System.Drawing.Point(196, 246);
            this.indexTextBox.Name = "indexTextBox";
            this.indexTextBox.Size = new System.Drawing.Size(193, 35);
            this.indexTextBox.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(196, 404);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(196, 35);
            this.textBox6.TabIndex = 5;
            // 
            // GoodsNameTextBox
            // 
            this.GoodsNameTextBox.Controls.Add(this.label6);
            this.GoodsNameTextBox.Controls.Add(this.label5);
            this.GoodsNameTextBox.Controls.Add(this.label4);
            this.GoodsNameTextBox.Controls.Add(this.label3);
            this.GoodsNameTextBox.Controls.Add(this.label2);
            this.GoodsNameTextBox.Controls.Add(this.label1);
            this.GoodsNameTextBox.Controls.Add(this.orderIDTextBox);
            this.GoodsNameTextBox.Controls.Add(this.textBox6);
            this.GoodsNameTextBox.Controls.Add(this.PriceTextBox);
            this.GoodsNameTextBox.Controls.Add(this.QuantityTextBox);
            this.GoodsNameTextBox.Controls.Add(this.indexTextBox);
            this.GoodsNameTextBox.Controls.Add(this.customerTextBox);
            this.GoodsNameTextBox.Location = new System.Drawing.Point(303, 213);
            this.GoodsNameTextBox.Name = "GoodsNameTextBox";
            this.GoodsNameTextBox.Size = new System.Drawing.Size(392, 522);
            this.GoodsNameTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "orderID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "index";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "GoodsName";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 415);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Quantity";
            // 
            // okbutton
            // 
            this.okbutton.Location = new System.Drawing.Point(925, 617);
            this.okbutton.Name = "okbutton";
            this.okbutton.Size = new System.Drawing.Size(259, 172);
            this.okbutton.TabIndex = 7;
            this.okbutton.Text = "ok";
            this.okbutton.UseVisualStyleBackColor = true;
            this.okbutton.Click += new System.EventHandler(this.okbutton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 883);
            this.Controls.Add(this.okbutton);
            this.Controls.Add(this.GoodsNameTextBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.GoodsNameTextBox.ResumeLayout(false);
            this.GoodsNameTextBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox orderIDTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.TextBox customerTextBox;
        private System.Windows.Forms.TextBox indexTextBox;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Panel GoodsNameTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button okbutton;
    }
}