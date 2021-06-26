using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ход_конем
{
    public partial class fmAbout : Form
    {
        public fmAbout()
        {
            InitializeComponent();
        }

        private void fmDescription_Load(object sender, EventArgs e)
        {
            button1.Text = this.Tag.ToString();
        }
    }
}
