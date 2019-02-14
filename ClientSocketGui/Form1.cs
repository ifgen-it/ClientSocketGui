using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;


namespace ClientSocketGui
{
    public partial class Form1 : Form
    {
        // fields

        static int port = 8005;
        static string address = "127.0.0.1";

        static string getHistory = "0";
        static string wantExit = "2";
        static string whoIsOnline = "1";
        static string messageDelivered = "+";

        Socket socket = null;
        bool sentName = false;
        bool wasLogIn = false;
        bool typeMessageNow = false;

        public Form1()
        {
            InitializeComponent();

            // my initializations
            InitServer();

            // tool tips
            tipRefresh.SetToolTip(btnRefresh, "F5");
            tipSend.SetToolTip(btnSend, "Enter");

            // handlers
            btnLogIn.Click += BtnLogIn_Click;
            btnSend.Click += BtnSend_Click;
            btnRefresh.Click += BtnRefresh_Click;
            btnLogOut.Click += BtnLogOut_Click;

            tbMessage.GotFocus += (o, e) => { typeMessageNow = true; };
            tbMessage.LostFocus += (o, e) => { typeMessageNow = false; };

        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            LogOut();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            RefreshChat();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            LogIn();
        }





        // methods

        private void UpdateInfo(string text)
        {
            lbInfo.Text = "Info : " + text;
        }

        private void UpdateServerInfo()
        {
            lbServer.Text = "Server : " + address + " : " + port;
        }

        private void InitServer()
        {
            // READ SERVER CONFIGURATION FROM FILE CONFIG.TXT
            try
            {
                StreamReader rd = new StreamReader("client_config.txt");
                string strServer = rd.ReadLine().Trim();
                string strPort = rd.ReadLine().Trim();
                rd.Close();

                string[] strServers = strServer.Split(' ');
                string[] strPorts = strPort.Split(' ');
                port = int.Parse(strPorts[1]);
                address = strServers[1];
                UpdateInfo("Configuration loaded. Type user name and press 'Log in'");
                UpdateServerInfo();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("\nCheck existance of original file client_config.txt in the directory with program.\n");

                UpdateInfo("Error in the configuration file client_config.txt");
            }

        }

        private bool InitSocket()
        {
            try
            {
                IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse(address), port);
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(ipPoint);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                UpdateInfo("Server is not responding. Make sure that Server is running");
                return false;
            }
            
        }

        private string GetAnswer()
        {

            //  GET ANSWER  
            try
            {
                byte[] data = new byte[256];
                StringBuilder builder = new StringBuilder();
                int bytes = 0;

                do
                {
                    bytes = socket.Receive(data, data.Length, 0);
                    builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                } while (socket.Available > 0);

                Console.WriteLine(DateTime.Now.ToLongTimeString() + " " + builder.ToString() + "\n");

                string ret = builder.ToString(); 
                return ret;

            }
            catch (Exception ex)
            {
                UpdateInfo(ex.Message);
                return ex.Message;
            }
        }

        private string GetTime()
        {
            return DateTime.Now.ToLongTimeString() + " ";
        }

        private void UpdateOnlineUsers()
        {
            try
            {
                string message = whoIsOnline;
                byte[] data = Encoding.Unicode.GetBytes(message);
                socket.Send(data);

                string answer = GetAnswer();

                string users = answer.TrimStart(char.Parse(messageDelivered));
                users = users.TrimStart('\n');

                tbOnlineUsers.Text = users;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                UpdateInfo("Server is not responding");
            }
            
        }

        private string NewLine()
        {
            return new StringBuilder().AppendLine().ToString();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            bool isHandled = true;


            switch (keyData)
            {

                case Keys.F5:
                    if (wasLogIn == true)
                    {
                        RefreshChat();
                        return isHandled;
                    }
                    break;

                case Keys.Enter:
                    if (typeMessageNow == true)
                    {
                        SendMessage();
                        return isHandled;
                    }
                    break;

                default:
                    break;
            }

            return false;
        }

        private void RefreshChat()
        {
            try
            {
                string message = getHistory;
                byte[] data = Encoding.Unicode.GetBytes(message);
                socket.Send(data);

                string history = GetAnswer();

                if (history.Length == 1 && history.Equals(messageDelivered))
                {
                    UpdateInfo("No messages from other users");
                }
                else
                {
                    if (history.Length > 1)
                    {
                        Console.WriteLine(history);
                        char whatTrim = char.Parse(messageDelivered);
                        history = history.Trim(whatTrim);
                        history = history.TrimStart('\n');
                        Console.WriteLine(history);

                        tbChat.AppendText(history);
                        //tbChat.ScrollToCaret();

                        UpdateInfo("Messages from other users loaded");
                    }
                    else
                    {
                        UpdateInfo("Refresh error");
                    }
                }

                UpdateOnlineUsers();
            }
            catch (Exception ex)
            {
                UpdateInfo(ex.Message);
            }
        }

        private void SendMessage()
        {
            try
            {
                string message = tbMessage.Text.Trim();
                if (message.Equals(""))
                {
                    UpdateInfo("Type message!");
                    return;
                }

                byte[] data = Encoding.Unicode.GetBytes(message);
                socket.Send(data);

                string answer = GetAnswer();

                if (answer.Length == 1 && answer.Equals(messageDelivered))
                {
                    //tbChat.Text += GetTime() + message + NewLine();
                    //tbChat.ScrollToCaret();
                    tbChat.AppendText(GetTime() + message + NewLine());

                    tbMessage.Text = "";
                    tbMessage.Focus();
                    UpdateInfo("Message was delivered");
                }
                else
                {
                    if (answer.Length > 1)
                    {
                        char whatTrim = char.Parse(messageDelivered);
                        string history = answer.Trim(whatTrim);
                        history = history.TrimStart('\n');
                        Console.WriteLine(history);
                        tbChat.AppendText(history);

                        //tbChat.Text += GetTime() + message + NewLine();
                        // tbChat.ScrollToCaret();
                        tbChat.AppendText(GetTime() + message + NewLine());

                        tbMessage.Text = "";
                        tbMessage.Focus();
                        UpdateInfo("History messages loaded. Message was delivered");
                    }
                    else
                    {
                        UpdateInfo("Message delivery error");
                    }
                }
            }
            catch (Exception ex)
            {
                UpdateInfo(ex.Message);
            }
        }

        private void LogOut()
        {
            try
            {
                byte[] data = Encoding.Unicode.GetBytes(wantExit);
                socket.Send(data);
                Console.WriteLine("You was exited from the chat");
                UpdateInfo("You was exited from the chat");

                tbUserName.Enabled = true;
                btnLogIn.Enabled = true;

                // CLOSE SOCKET
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();

                btnSend.Enabled = false;
                btnRefresh.Enabled = false;
                btnLogOut.Enabled = false;

                wasLogIn = false;
            }
            catch (Exception ex)
            {
                UpdateInfo(ex.Message);
            }
        }

        private void LogIn()
        {
            if (InitSocket() == false) return;

            string name = tbUserName.Text.Trim();
            if (name.Equals(""))
            {
                UpdateInfo("Type user name!");
                return;
            }
            tbUserName.Enabled = false;
            btnLogIn.Enabled = false;

            try
            {
                byte[] dataName = Encoding.Unicode.GetBytes(name);
                sentName = true;
                socket.Send(dataName);
            }
            catch (Exception ex)
            {
                UpdateInfo(ex.Message);
            }

            tbChat.Text = "";
            tbOnlineUsers.Text = "";
            tbMessage.Text = "";

            tbChat.Text += GetTime() + GetAnswer() + NewLine();
            UpdateInfo("Type message and press 'Send'");

            UpdateOnlineUsers();

            btnSend.Enabled = true;
            btnRefresh.Enabled = true;
            btnLogOut.Enabled = true;
            wasLogIn = true;
        }



    }
}
