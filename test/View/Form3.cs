using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonForm_Click(object sender, EventArgs e)
        {
            Hide();

            var form = new Form1();
            form.Show();
        }

        private void buttonConsole_Click(object sender, EventArgs e)
        {
            Hide();

            var ui = new UI();
            ui.Start();
        }
    }
}
