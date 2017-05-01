namespace DelaunayTriangulationDemo
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Net_Btu = new System.Windows.Forms.Button();
            this.RandomPoint_Btu = new System.Windows.Forms.Button();
            this.Paint_panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Clear_Btu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.Paint_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Clear_Btu);
            this.panel1.Controls.Add(this.Net_Btu);
            this.panel1.Controls.Add(this.RandomPoint_Btu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 48);
            this.panel1.TabIndex = 0;
            // 
            // Net_Btu
            // 
            this.Net_Btu.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Net_Btu.Location = new System.Drawing.Point(318, 6);
            this.Net_Btu.Name = "Net_Btu";
            this.Net_Btu.Size = new System.Drawing.Size(77, 35);
            this.Net_Btu.TabIndex = 1;
            this.Net_Btu.Text = "网";
            this.Net_Btu.UseVisualStyleBackColor = true;
            this.Net_Btu.Click += new System.EventHandler(this.Net_Btu_Click);
            // 
            // RandomPoint_Btu
            // 
            this.RandomPoint_Btu.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RandomPoint_Btu.Location = new System.Drawing.Point(58, 6);
            this.RandomPoint_Btu.Name = "RandomPoint_Btu";
            this.RandomPoint_Btu.Size = new System.Drawing.Size(77, 35);
            this.RandomPoint_Btu.TabIndex = 0;
            this.RandomPoint_Btu.Text = "点";
            this.RandomPoint_Btu.UseVisualStyleBackColor = true;
            this.RandomPoint_Btu.Click += new System.EventHandler(this.RandomPoint_Btu_Click);
            // 
            // Paint_panel
            // 
            this.Paint_panel.Controls.Add(this.pictureBox1);
            this.Paint_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Paint_panel.Location = new System.Drawing.Point(0, 48);
            this.Paint_panel.Name = "Paint_panel";
            this.Paint_panel.Size = new System.Drawing.Size(727, 500);
            this.Paint_panel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(727, 500);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Clear_Btu
            // 
            this.Clear_Btu.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Clear_Btu.Location = new System.Drawing.Point(578, 6);
            this.Clear_Btu.Name = "Clear_Btu";
            this.Clear_Btu.Size = new System.Drawing.Size(77, 35);
            this.Clear_Btu.TabIndex = 3;
            this.Clear_Btu.Text = "清空";
            this.Clear_Btu.UseVisualStyleBackColor = true;
            this.Clear_Btu.Click += new System.EventHandler(this.Clear_Btu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 548);
            this.Controls.Add(this.Paint_panel);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.Paint_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Net_Btu;
        private System.Windows.Forms.Button RandomPoint_Btu;
        private System.Windows.Forms.Panel Paint_panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Clear_Btu;
    }
}

