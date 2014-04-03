using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WumpusTest
{
    public partial class ParentForm : Form
    {
        Form currentForm = new HomeScreen();

        public ParentForm()
        {
            InitializeComponent();
            this.Hide();
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {
            UserControl1 foo = new UserControl1();
           
            this.Hide();
            currentForm.Show();
        }
    }
}
