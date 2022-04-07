using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZhuykovSQLApp
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (userNameField.Text.Length > 0 && userSurnameField.Text.Length > 0 && loginField.Text.Length > 0 
                && passField.Text.Length > 0 && confirmPassField.Text.Length > 0 && (passField.Text == confirmPassField.Text))
            {
                ButtonRegister.Enabled = true;
                label5.ForeColor = Color.Green;
                label5.Text = "Вы ввели всё верно";
            }
            else
            {
                ButtonRegister.Enabled = false;
                label5.ForeColor = Color.Red;
                label5.Text = "Проверьте все-ли поля заполнены!\nТакже убедитесь что пароли совпадают!";
            }
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            if (isUserExists())
            {
                return;
            }    
            DateBase db = new DateBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `pass`, `name`, `surname`) " +
                "VALUES (@login, @pass, @name, @surname)", db.getConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginField.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passField.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = userNameField.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = userSurnameField.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт был создан");
            }

            db.closeConnection();
            Close();
        }

        public bool isUserExists()
        {
            DateBase db = new DateBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand сommand = new MySqlCommand("SELECT * FROM `users` Where `login` = @uL", db.getConnection());
            сommand.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginField.Text;

            adapter.SelectCommand = сommand;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Данный логин используется другим пользователем");
                return true;
            }
            else
                return false;
        }
    }
}
