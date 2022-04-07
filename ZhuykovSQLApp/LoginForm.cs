using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZhuykovSQLApp
{
    public partial class LoginForm : Form
    {        
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginField_MouseEnter(object sender, EventArgs e)
        {
            if (loginField.Text == "someone@example.com")
            {
                loginField.Text = "";
                loginField.ForeColor = Color.White;
            }
        }

        private void loginField_MouseLeave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                loginField.Text = "someone@example.com";
                loginField.ForeColor = Color.Gray;
            }
        }

        private void passField_MouseEnter(object sender, EventArgs e)
        {
            if (passField.Text == "password")
            {
                passField.Text = "";
                passField.UseSystemPasswordChar = true;
                passField.ForeColor = Color.White;
            }
        }

        private void passField_MouseLeave(object sender, EventArgs e)
        {
            if (passField.Text == "")
            {
                passField.Text = "password";
                passField.UseSystemPasswordChar = false;

                passField.ForeColor = Color.Gray;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            loginField.Text = "someone@example.com";
            passField.Text  = "password";
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            registerLabel.ForeColor = Color.White;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            registerLabel.ForeColor = Color.Gray;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (passField.UseSystemPasswordChar == true)
            {
                pictureBox3.Visible = false;
                passField.UseSystemPasswordChar = false;
                pictureBox4.Visible = true;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (passField.UseSystemPasswordChar == false)
            {
                pictureBox4.Visible = false;
                passField.UseSystemPasswordChar = true;
                pictureBox3.Visible = true;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
            string loginUser = loginField.Text;
            string passUser = passField.Text;

            DateBase db = new DateBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand сommand = new MySqlCommand("SELECT * FROM `users` Where `login` = @uL AND `pass` = @uP", db.getConnection());

            сommand.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            сommand.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = сommand;
            adapter.Fill(table);

            MySqlCommand сommand1 = new MySqlCommand("SELECT `name` FROM `users` WHERE `login` = @uL", db.getConnection());

            сommand1.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            string userName = "";
                       
            if (table.Rows.Count > 0)
            {
                db.openConnection();
                userName = сommand1.ExecuteScalar().ToString();
                db.closeConnection();
                MessageBox.Show($"Добро пожаловать, {userName}", "Приветственное окно!");
                new Thread(() => { Application.Run(new MainForm()); }).Start();
                Close();
            }
            else
            {
                errorLabel.Visible = true;
                errorLabel.ForeColor = Color.Red;
            }            
        }

        private void registerLabel_Click(object sender, EventArgs e)
        {            
            RegisterForm regForm = new RegisterForm();
            regForm.ShowDialog();
        }
    }
}