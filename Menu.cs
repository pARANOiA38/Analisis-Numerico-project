using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_AnalisisNumerico2021
{
    public partial class Menu : Form
    {
        public Menu() => InitializeComponent();
        private void btnUni1_Click(object sender, EventArgs e)
        {
            Unidad1 nuevaUnidad1 = new Unidad1();
            nuevaUnidad1.Owner = this;
            nuevaUnidad1.Show();
            nuevaUnidad1.FormClosed += LogOut;

            this.Hide();

        }
        private void button1_Click(object sender, EventArgs e) => this.Close();
        private void LogOut(object sender, FormClosedEventArgs e) => this.Show();
       
    }
}
