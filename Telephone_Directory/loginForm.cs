using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telephone_Directory
{
    public partial class loginForm : Form
    {
        private DirectoryModelContainer DirectoryDB;
        public loginForm()
        {
            InitializeComponent();
            DirectoryDB = new DirectoryModelContainer();
            AllowBtns();
        }

        public void AllowBtns()
        {
            if (loginTextBox.Text.Length == 0 || passwordTextBox.Text.Length == 0)
            {
                loginBtn.Enabled = false;
                signUpBtn.Enabled = false;
            }
            else
            {
                loginBtn.Enabled = true;
                signUpBtn.Enabled = true;
            }
        }
        public void ClearBoxes()
        {
            loginTextBox.Clear();
            passwordTextBox.Clear();
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {
            AllowBtns();
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            AllowBtns();
        }

        //Вход
        private void loginBtn_Click(object sender, EventArgs e)
        {
            var count = (from user in DirectoryDB.UsersInfoSet
                         where user.Login == loginTextBox.Text && user.Password == passwordTextBox.Text
                         select user).Count();
            if (count > 0)
            {
                mainForm mainform = new mainForm(loginTextBox.Text);
                mainform.ShowDialog();
                ClearBoxes();
            }
            else
                MessageBox.Show("Incorrect login or password", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Регистрация
        private void signUpBtn_Click(object sender, EventArgs e)
        {
            var count = (from registered in DirectoryDB.UsersInfoSet
                         where registered.Login == loginTextBox.Text
                         select registered).Count();
            if (count == 0)
            {
                UsersInfo user = new UsersInfo
                {
                    Login = loginTextBox.Text,
                    Password = passwordTextBox.Text,
                    Access_level = "User"
                };
                DirectoryDB.UsersInfoSet.Add(user);
                DirectoryDB.SaveChanges();
                MessageBox.Show("You have successfully registered", "Welcome!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearBoxes();
            }
            else
            {
                MessageBox.Show("This user is already registered.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

