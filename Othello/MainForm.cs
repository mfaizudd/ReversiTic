using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Othello
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        MainMenu mm = new MainMenu();
        private void MainForm_Load(object sender, EventArgs e)
        {
            Support.adduc(mm, panel2);
        }
    }
}
