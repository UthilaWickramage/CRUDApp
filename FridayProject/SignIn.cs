using FridayProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FridayProject
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            (new SignUp()).Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string username = usernameTxt.Text;
            string password = passwordTxt.Text;
            using (var dbContext = new MyDBContext()) {

                
            }
            
        }
    }

}
