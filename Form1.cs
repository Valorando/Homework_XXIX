using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_06_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
            treeView1.BeforeSelect += new TreeViewCancelEventHandler(treeView1_BeforeSelect);

        }

        private void treeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            e.Cancel = true; 
        }

    }
}
