using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelaunayTriangulationDemo
{
    public partial class PointCountsForm : Form
    {
        public int Nums { get; set; }
        public PointCountsForm()
        {
            InitializeComponent();
        }

        private void Ok_Btu_Click(object sender, EventArgs e)
        {
            this.Nums = (int)this.numericUpDown1.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Cancel_Btu_Click(object sender, EventArgs e)
        {
            this.Nums = 0;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void PointCountsForm_Load(object sender, EventArgs e)
        {
            this.Nums = 0;
        }
        
    }
}
