using System;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace LearningPlanner_1._0._0
{
    public partial class ReportErrorForm : Form
    {
        public ReportErrorForm()
        {
            InitializeComponent();
        }

        string programMail = "plannerteaminfo@gmail.com";
        string programMailPassword = "kubamichal123";
        string authorsMailK = "benzef@tlen.pl";
        string authorsMailM = "m.biaek91@gmail.com";
        string name;
        string emailAddress;
        string categoryError;
        string describeError;

        


        private void SendErrorMessage()
        {
                        
                name = nameTextbox.Text;
                emailAddress = emailTextBox.Text;
                categoryError = categoryErrorComboBox.SelectedItem.ToString();
                describeError = describeErrorRichTextBox.Text;



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

        private void ReportErrorForm_Load(object sender, EventArgs e)
        {

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
