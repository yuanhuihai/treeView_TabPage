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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void addTab(string name)
        {
            TabPage tab = new TabPage();
            tab.Text = name;
            neirong ab = new neirong();
            ab.TopLevel = false;
            tab.Controls.Add(ab);
            tabControl1.TabPages.Add(tab);
            ab.Show();
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
           

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (e.Node.Level == 1)
                {

                   

                    TreeNode node = this.treeView1.SelectedNode;
                    while (node.Parent != null)
                    {
                        node = node.Parent;
                    }
                    string ParentNodeText = node.Text; //父节点名

                    transValue.nodeFahter = node.Text;
                    transValue.nodeChild = e.Node.Text;

                    addTab(node.Text+"+"+e.Node.Text);



                }
            }
          
        }
    }
}
