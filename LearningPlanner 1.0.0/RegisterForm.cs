using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LearningPlanner_1._0._0
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        // Zmienna obslugiwana przez wlasciwosc
        private string login;
        // Zmienna pomocnicza
        bool logi = false;
        // Wlasciwosc obslugujaca wpisywany login
        public string Login
        {
            get
            {        // Jezeli dlugosc loginu miedzy 3 a 15 znakow
                if ((regLoginTextBox.Text.Length > 3) && (regLoginTextBox.Text.Length < 15))
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
      


        private string password;


        public string Password
        {


            get
            {
                if ((regPassTextBox.Text.Length > 3) && (regPassTextBox.Text.Length < 15))
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
            bool samePassValid = String.Equals(Password, pass);
            string log = Login;


            if ((samePassValid == true) && (logi == true))
            {
                badValueLogin.Visible = false;
                badValuePassword.Visible = false;
                AddUserToDataBase();

            }
            else if((regLoginTextBox.Text.Length<3)&&(samePassValid==true))
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
        Uzytkownicy model = new Uzytkownicy();
        
           private void AddUserToDataBase()
        { 
            model.Login = Login;
            model.Haslo = Password;

            using (EntitiesModel2 entitiesModel = new EntitiesModel2())
            {
                if (entitiesModel.Uzytkownicy.Where(u => u.Login == Login).Any())
                {
                    MessageBox.Show("Podana nazwa uzytkownika jest juz zajęta");
                }
                else
                {
                    entitiesModel.Uzytkownicy.Add(model);
                    entitiesModel.SaveChanges();
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
