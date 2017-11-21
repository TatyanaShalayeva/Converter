using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Convertor
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
            this.textBox1.Text = File.ReadAllText("About.txt");
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
