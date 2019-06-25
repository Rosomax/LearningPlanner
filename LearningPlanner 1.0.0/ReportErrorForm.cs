using System;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Linq;
namespace LearningPlanner
{
    public partial class ReportErrorForm : Form
    {
        public ReportErrorForm()
        {
            InitializeComponent();
        }

     const string programMail = "plannerteaminfo@gmail.com";
     const string programMailPassword = "kubamichal123";
     const string authorsMailK = "benzef@tlen.pl";
     const string authorsMailM = "m.biaek91@gmail.com";

        string emailAddress;



      //  EntitiesModel model = new EntitiesModel();
       

        private bool SendMessage(string emailAddr)
        {
          //  var x = model.Uzytkownicy.First(z => z.IDosoby == 4).Haslo;

            
         




            emailAddress = emailAddr;         
            string name = nameTextbox.Text;
            emailAddr = emailTextBox.Text;
            string categoryError = categoryErrorComboBox.SelectedItem.ToString();
            string describeError = describeErrorRichTextBox.Text;

            try
            {                
                MailMessage message = new MailMessage();
                message.To.Add(authorsMailK);
                message.To.Add(authorsMailM);
                message.Subject = ($"Wysłano z learning planner: {categoryError}");
                message.Priority = MailPriority.High;
                message.From = new MailAddress(programMail, "LearningPlannerMail");
                message.Body = ($"{describeError} \n\n Odpowiedz na  {emailAddr} do użytkownika {name}");
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587)
                {
                    EnableSsl = true,
                    Credentials = new NetworkCredential(programMail, programMailPassword)
                };
                smtpClient.Send(message);
                MessageBox.Show("Wyslano wiadomosc!");

                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Nieprawidłowy email");
                return false;
              
            }
        }




        private void SendErrorButton_Click(object sender, EventArgs e)
        {
            if (nameTextbox.Text == string.Empty || emailTextBox.Text == string.Empty || categoryErrorComboBox.SelectedItem == null )
                MessageBox.Show("Uzupełnij wszystkie pola!");
            else
            {
                SendMessage(emailAddress);
            }
        }
    }
}
