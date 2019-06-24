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
        


        private void SendErrorMessage()
        {

              string  name = nameTextbox.Text;
              string  emailAddress = emailTextBox.Text;
              string  categoryError = categoryErrorComboBox.SelectedItem.ToString();
              string  describeError = describeErrorRichTextBox.Text;



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
                Close();
            
     
        }

    

        private void SendErrorButton_Click(object sender, EventArgs e)
        {
            if (nameTextbox.Text == string.Empty || emailTextBox.Text == string.Empty || categoryErrorComboBox.SelectedItem == null)
                MessageBox.Show("upssss, cos poszlo nie tak!");
            else
            {
                SendErrorMessage();
                MessageBox.Show("Wyslano wiadomosc!");
            }
        }
    }
}
