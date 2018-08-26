using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Telephone_Directory
{
    public partial class administrationForm : Form
    {
        private DirectoryModelContainer DirectoryDB = new DirectoryModelContainer();
        string login;
        public administrationForm(string login)
        {
            this.login = login;
            InitializeComponent();
            DirectoryDB.UsersInfoSet.Load();
            dataGridView1.DataSource = DirectoryDB.UsersInfoSet.Local.ToList();
            deleteBtn.Enabled = editBtn.Enabled = loginTextBox.Enabled = passwordTextBox.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            deleteBtn.Enabled = editBtn.Enabled = true;
            int row = dataGridView1.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dataGridView1[0, row].Value);
            try
            {
                var user = DirectoryDB.UsersInfoSet.Find(id);
                loginTextBox.Text = user.Login;
                passwordTextBox.Text = user.Password;
                if (user.Access_level == "Owner")
                    accessComboBox.SelectedIndex = 0;
                else if (user.Access_level == "Admin")
                    accessComboBox.SelectedIndex = 1;
                else
                    accessComboBox.SelectedIndex = 2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dataGridView1[0, row].Value);
            try
            {
                var user = DirectoryDB.UsersInfoSet.Find(id);
                if (user.Access_level == "Owner")
                    MessageBox.Show("You can`t delete yourself", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    DirectoryDB.UsersInfoSet.Remove(user);
                    DirectoryDB.SaveChanges();
                    MessageBox.Show("Done", "Action", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DirectoryDB.UsersInfoSet.Load();
                    dataGridView1.DataSource = DirectoryDB.UsersInfoSet.Local.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dataGridView1[0, row].Value);
            try
            {
                var user = DirectoryDB.UsersInfoSet.Find(id);
                if (user.Access_level == "Owner")
                    MessageBox.Show("You can`t edit yourself", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if ((user.Access_level == "Admin" || user.Access_level == "User") && accessComboBox.SelectedIndex == 0)
                    MessageBox.Show("You can`t promote user to owner", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    user.Access_level = accessComboBox.Text;
                    DirectoryDB.Entry(user).State = EntityState.Modified;
                    DirectoryDB.SaveChanges();
                    MessageBox.Show("Done", "Action", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DirectoryDB.UsersInfoSet.Load();
                    dataGridView1.DataSource = DirectoryDB.UsersInfoSet.Local.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
