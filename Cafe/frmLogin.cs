using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cafe.Class;

namespace Cafe
{
    public partial class frmLogin : Form
    {
        public static int IdUser;
        public frmLogin()
        {
            InitializeComponent();
            //txtLogin.Validating += txtLogin_Validating;
        }

        public bool checkErrorProvider()
        {
            string checkLogin = errorProvider1.GetError(txtLogin);
            string checkPassword = errorProvider1.GetError(txtPassword);

            if (checkLogin.Trim().Length > 0 || checkPassword.Trim().Length > 0)
            {
                return false;
            }

            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkErrorProvider())
            {
                User newUser = new User();
                string login = txtLogin.Text;
                string password = txtPassword.Text;
                bool check = newUser.validationLogin(login, password);

                if (check)
                {
                    IdUser = newUser.idUser;
                    switch (newUser.privilege)
                    {
                        case "Администратор":
                            this.Hide();
                            txtLogin.Text = "";
                            txtPassword.Text = "";
                            new frmAdmin().Show();
                            break;
                        case "Кассир":
                            this.Hide();
                            new frmSale().Show();
                            break;
                        default:
                            break;

                    }


                }

                else
                {
                    MessageBox.Show("Неправильный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }

        private void txtLogin_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtLogin.Text))
            {
                errorProvider1.SetError(txtLogin, "Не указано имя!");
            }
            else if (txtLogin.Text.Length < 5)   
            {
                errorProvider1.SetError(txtLogin, "Слишком короткое имя!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, "Введите пароль!");
            }
            else if (txtPassword.Text.Length < 5)   
            {
                errorProvider1.SetError(txtPassword, "Слишком короткий пароль!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
