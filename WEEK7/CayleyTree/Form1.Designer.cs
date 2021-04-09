
namespace CayleyTree
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
            this.depth = new System.Windows.Forms.TrackBar();
            this.length = new System.Windows.Forms.TrackBar();
            this.ldepth = new System.Windows.Forms.TrackBar();
            this.rdepth = new System.Windows.Forms.TrackBar();
            this.langle = new System.Windows.Forms.TrackBar();
            this.rangle = new System.Windows.Forms.TrackBar();
            this.color = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.draw_panel = new System.Windows.Forms.Panel();
            this.draw = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.depth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ldepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.langle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangle)).BeginInit();
            this.SuspendLayout();
            // 
            // depth
            // 
            this.depth.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.depth.Location = new System.Drawing.Point(1287, 54);
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(269, 90);
            this.depth.TabIndex = 0;
            // 
            // length
            // 
            this.length.Location = new System.Drawing.Point(1287, 150);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(256, 90);
            this.length.TabIndex = 1;
            // 
            // ldepth
            // 
            this.ldepth.Location = new System.Drawing.Point(1287, 246);
            this.ldepth.Maximum = 7;
            this.ldepth.Name = "ldepth";
            this.ldepth.Size = new System.Drawing.Size(269, 90);
            this.ldepth.TabIndex = 2;
            this.ldepth.Scroll += new System.EventHandler(this.ldepth_Scroll);
            // 
            // rdepth
            // 
            this.rdepth.Location = new System.Drawing.Point(1287, 342);
            this.rdepth.Maximum = 7;
            this.rdepth.Name = "rdepth";
            this.rdepth.Size = new System.Drawing.Size(269, 90);
            this.rdepth.TabIndex = 3;
            this.rdepth.Scroll += new System.EventHandler(this.rdepth_Scroll);
            // 
            // langle
            // 
            this.langle.Location = new System.Drawing.Point(1300, 489);
            this.langle.Maximum = 90;
            this.langle.Name = "langle";
            this.langle.Size = new System.Drawing.Size(266, 90);
            this.langle.TabIndex = 4;
            this.langle.Scroll += new System.EventHandler(this.langle_Scroll);
            // 
            // rangle
            // 
            this.rangle.Location = new System.Drawing.Point(1300, 602);
            this.rangle.Maximum = 90;
            this.rangle.Name = "rangle";
            this.rangle.Size = new System.Drawing.Size(273, 90);
            this.rangle.TabIndex = 5;
            this.rangle.Scroll += new System.EventHandler(this.rangle_Scroll);
            // 
            // color
            // 
            this.color.FormattingEnabled = true;
            this.color.Items.AddRange(new object[] {
            "黑色",
            "红色",
            "蓝色"});
            this.color.Location = new System.Drawing.Point(1300, 740);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(321, 32);
            this.color.TabIndex = 7;
            this.color.SelectedIndexChanged += new System.EventHandler(this.color_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1137, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "depth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1137, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "length";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1137, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "ldepth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1137, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "rdepth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1137, 489);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "langle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1137, 611);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 24);
            this.label6.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1149, 740);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "color";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1137, 611);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "rangle";
            // 
            // draw_panel
            // 
            this.draw_panel.Location = new System.Drawing.Point(80, 83);
            this.draw_panel.Name = "draw_panel";
            this.draw_panel.Size = new System.Drawing.Size(949, 809);
            this.draw_panel.TabIndex = 16;
            // 
            // draw
            // 
            this.draw.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.draw.ForeColor = System.Drawing.SystemColors.Control;
            this.draw.Location = new System.Drawing.Point(1141, 850);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(316, 107);
            this.draw.TabIndex = 17;
            this.draw.Text = "draw";
            this.draw.UseVisualStyleBackColor = false;
            this.draw.Click += new System.EventHandler(this.draw_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1695, 973);
            this.Controls.Add(this.draw);
            this.Controls.Add(this.draw_panel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.color);
            this.Controls.Add(this.rangle);
            this.Controls.Add(this.langle);
            this.Controls.Add(this.rdepth);
            this.Controls.Add(this.ldepth);
            this.Controls.Add(this.length);
            this.Controls.Add(this.depth);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.depth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ldepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.langle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar depth;
        private System.Windows.Forms.TrackBar length;
        private System.Windows.Forms.TrackBar ldepth;
        private System.Windows.Forms.TrackBar rdepth;
        private System.Windows.Forms.TrackBar langle;
        private System.Windows.Forms.TrackBar rangle;
        private System.Windows.Forms.ComboBox color;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel draw_panel;
        private System.Windows.Forms.Button draw;
    }
}

