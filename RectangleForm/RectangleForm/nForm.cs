using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RectangleForm
{
    public partial class nForm : Form
    {
        private bool nclose = false;
        private void nForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (nclose) return;
            e.Cancel = true;
            Hide();
        }
        public nForm()
        {
            InitializeComponent();
        }

        private void checkBoxClose_CheckedChanged(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public new void Close()
        {
            nclose = true;
            base.Close();
        }
    }
}
