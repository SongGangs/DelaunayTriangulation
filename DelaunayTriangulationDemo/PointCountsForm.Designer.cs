namespace DelaunayTriangulationDemo
{
    partial class PointCountsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Ok_Btu = new System.Windows.Forms.Button();
            this.Cancel_Btu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(37, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "点数：";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(130, 62);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown1.TabIndex = 1;
            // 
            // Ok_Btu
            // 
            this.Ok_Btu.Location = new System.Drawing.Point(38, 145);
            this.Ok_Btu.Name = "Ok_Btu";
            this.Ok_Btu.Size = new System.Drawing.Size(75, 23);
            this.Ok_Btu.TabIndex = 2;
            this.Ok_Btu.Text = "确 认";
            this.Ok_Btu.UseVisualStyleBackColor = true;
            this.Ok_Btu.Click += new System.EventHandler(this.Ok_Btu_Click);
            // 
            // Cancel_Btu
            // 
            this.Cancel_Btu.Location = new System.Drawing.Point(174, 145);
            this.Cancel_Btu.Name = "Cancel_Btu";
            this.Cancel_Btu.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Btu.TabIndex = 3;
            this.Cancel_Btu.Text = "取 消";
            this.Cancel_Btu.UseVisualStyleBackColor = true;
            this.Cancel_Btu.Click += new System.EventHandler(this.Cancel_Btu_Click);
            // 
            // PointCountsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 193);
            this.Controls.Add(this.Cancel_Btu);
            this.Controls.Add(this.Ok_Btu);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Name = "PointCountsForm";
            this.Text = "PointCountsForm";
            this.Load += new System.EventHandler(this.PointCountsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button Ok_Btu;
        private System.Windows.Forms.Button Cancel_Btu;
    }
}