using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convertor
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Size = new Size(300, 500);
            
        }

        private void bApply_Click(object sender, EventArgs e)
        {
            foreach (var i in this.Controls.OfType<RadioButton>())
            {
                if (i.Checked)
                {
                    Class1.Text = i.Text;
                    break;
                }
            }
            this.Close();

        }

    }
}
