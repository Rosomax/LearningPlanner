using System;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

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


        private bool SendErrorMessage()
        {
            
              string  name = nameTextbox.Text;
            emailAddress = emailTextBox.Text;
            string  categoryError = categoryErrorComboBox.SelectedItem.ToString();
              string  describeError = describeErrorRichTextBox.Text;


            if (IsValid(emailAddress))
            {
                MailMessage message = new MailMessage();
                message.To.Add(authorsMailK);
                message.To.Add(authorsMailM);
                message.Subject = ($"Wysłano z learning planner: {categoryError}");
                message.Priority = MailPriority.High;
                message.From = new MailAddress(programMail, "LearningPlannerMail");
                message.Body = ($"{describeError} \n\n Odpowiedz na  {emailAddress} do użytkownika {name}");
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new NetworkCredential(programMail, programMailPassword);
                smtpClient.Send(message);
                MessageBox.Show("Wyslano wiadomosc!");
                Close();
                
                return true;
            }
            

            else
                return false;
     
        }

        private bool IsValid(string emailAddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailAddress);
                
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }




        private void SendErrorButton_Click(object sender, EventArgs e)
        {
            if (nameTextbox.Text == string.Empty || emailTextBox.Text == string.Empty || categoryErrorComboBox.SelectedItem == null )
                MessageBox.Show("upssss, cos poszlo nie tak!");

            else if (SendErrorMessage()==false)
            {
                MessageBox.Show("Nieprawidłowy adres email");
            }
            else
            {
                SendErrorMessage();
                
            }
        }
    }
}
