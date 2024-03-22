using FridayProject.Model;
using FridayProject.Utils;
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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new SignIn()).Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = nameTxt.Text;
            string username = usernameTxt.Text;
            string password = passwordTxt.Text;

            if (username.Length == 0 || name.Length == 0)
            {
                MessageBox.Show("Username and name cannot be empty");
            }
            else if (password.Length < 6 || password.Length > 10)
            {
                MessageBox.Show("Password cannot be empty");

            }
            else
            {
                using (var dbContext = new MyDBContext())
                {
                    User user = new User();
                    user.Name = name;
                    user.Username = username;
                    user.Password = Encryption.Encrypt(password);

                    dbContext.Users.Add(user);
                    dbContext.SaveChanges();
                }
            }
        }
    }
}
