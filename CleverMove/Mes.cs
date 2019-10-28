using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace CleverMove
{
    public partial class Mes : Form
    {
        public Mes()
        {
            InitializeComponent();
        }

        private void Mes_Load(object sender, EventArgs e)
        {
            SendKeys.Send("{tab}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
