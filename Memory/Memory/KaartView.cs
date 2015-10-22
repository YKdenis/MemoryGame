using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    public partial class KaartView : UserControl
    {
        public KaartView()
        {
            InitializeComponent();
        }

        private void KaartView_Load(object sender, EventArgs e)
        {
            Image1.Size = new Size(Image1.Width, Image1.Height);
        }

        private void Image1_Click(object sender, EventArgs e)
        {

        }
    }
}
