using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LearningPlanner
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        
        string login;
        
        bool logi = false;
        
       public string Login
        {
            get
            {       
                if ((regLoginTextBox.Text.Length >= 3) && (regLoginTextBox.Text.Length < 15))
                {
                    login = regLoginTextBox.Text;
                    logi = true;
                    return login;

                }
                if (regLoginTextBox.Text.Length < 3)
                {
                    badValueLogin.Text = "Login musi się składać z minimum 3 znaków";
                    badValueLogin.Visible = true;
                    return badValueLogin.Text;
                }
                else
                {
                    badValueLogin.Text = "Login może zawierać maksymalnie 15 znaków";
                    badValueLogin.Visible = true;
                    return badValueLogin.Text;
                }
            }
            set
            {
                login = value;
            }

        }

        public const int MinValue = 3;
        public const int MaxValue = 15;

        string password;


        public string Password
        {


            get
            {
                if ((regPassTextBox.Text.Length >= 3) && (regPassTextBox.Text.Length < 15))
                {
                    password = regPassTextBox.Text;
                    return password;
                }
                if (regPassTextBox.Text.Length < 3)
                {
                    badValuePassword.Text = "Hasło musi się składać z minimum 3 znaków";
                    badValuePassword.Visible = true;
                    return badValuePassword.Text;
                }
                else
                {
                    badValuePassword.Text = "Hasło może zawierać maksymalnie 15 znaków";
                    badValuePassword.Visible = true;
                    return badValuePassword.Text;
                }
            }
            set
            {
                password = value;
            }

        }


        void CreateAccount()
        {

            string pass = regPassTextBox2.Text;
            bool samePassValid = string.Equals(Password, pass);
            string log = Login;


            if ((samePassValid) && (logi))
            {
                badValueLogin.Visible = false;
                badValuePassword.Visible = false;
                AddUserToDataBase();

            }
            else if((regLoginTextBox.Text.Length<3)&&(samePassValid))
            {
                badValueLogin.Text = "Login musi się składać z minimum 3 znaków";
                badValuePassword.Visible = false;
            }            

            else 
            {
                badValuePassword.Text = "Podane hasła są niezgodne";
                badValuePassword.Visible = true;
            }

        }
      
        
           private void AddUserToDataBase()
           {
            Users model = new Users
            {
                Login = Login,
                Haslo = Password
            };

            using (EntitiesModel EntitiesModel = new EntitiesModel())
            {
                if (EntitiesModel.Users.Where(u => u.Login == Login).Any())
                {
                    MessageBox.Show("Podana nazwa uzytkownika jest juz zajęta");
                }
                else
                {
                    EntitiesModel.Users.Add(model);
                    EntitiesModel.SaveChanges();
                    MessageBox.Show("Utworzono konto!");
                    Close();
                }
            }
        }
        


        private void RegisterButton_Click(object sender, EventArgs e)
        {
            CreateAccount();
            Refresh();
        }

        
    }
}
