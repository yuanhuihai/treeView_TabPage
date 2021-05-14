using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace treeView_TabPage
{
    public partial class neirong : Form
    {
        public neirong()
        {
            InitializeComponent();
        }

        private void neirong_Load(object sender, EventArgs e)
        {
            textBox1.Text = transValue.nodeFahter;
            textBox2.Text = transValue.nodeChild;
        }
    }
}
