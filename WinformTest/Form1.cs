using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TreeNode petRoot = new TreeNode("동물");

            TreeNode dogTree = new TreeNode("강아지");
            dogTree.Nodes.Add("강아지1");
            dogTree.Nodes.Add("강아지2");
            petRoot.Nodes.Add(dogTree);

            TreeNode catTree = new TreeNode("고양이");
            catTree.Nodes.Add("고양이1");
            catTree.Nodes.Add("고양이2");
            petRoot.Nodes.Add(catTree);
        }

        
    }
}
