/*
 * User: Michel Gutardo Ramos de Lima
 * Date: 01/11/2017
 * Time: 17:40
 */

using System;
using System.Text;
using System.Windows.Forms;

using System.Net.Sockets;
using System.Net;

namespace PagerLRS
{
    class Connection
    {

        #region Private Properties 

        private Socket sender;
        
        //if will show messages
        private bool debug { get; set; }

        #endregion

        #region Public Properties

        //IP Transmitter
        public string ip  { get; set; }
        
        //Port Transmitter
        public int port   { get; set; }

        #endregion
        
        #region Constructor

        public Connection(bool debug = false)
        {
            this.debug = debug;
        }
        
        #endregion 

        #region Public Methods

        //Connect to transmitter
        public void Connect()
        {
            byte[] bytes = new byte[1024];

            try
            {
                IPAddress ipAddress = IPAddress.Parse(this.ip);
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, this.port);

                sender = new Socket(ipAddress.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);

                try
                {
                    sender.Connect(remoteEP);

                    if(debug)
                    {
                        MessageBox.Show("Connected: " + this.sender.RemoteEndPoint.ToString());
                    }

                    byte[] msg = Encoding.ASCII.GetBytes("<Login services=\"NetPage\" />\n");

                    if (debug)
                    {
                        MessageBox.Show("Connection Response: "+
                                         Encoding.ASCII.GetString(bytes,0,this.sender.Receive(bytes)));
                    }
                    int bytesSent = this.sender.Send(msg);


                    if (debug)
                    {
                        MessageBox.Show("Sender Response: " +
                                          Encoding.ASCII.GetString(bytes, 0, this.sender.Receive(bytes)));
                    }

                }
                catch (ArgumentNullException ane)
                {
                    MessageBox.Show("ArgumentNullException: " + ane.ToString());
                }
                catch (SocketException se)
                {
                    MessageBox.Show("SocketException:" + se.ToString());
                }
                catch (Exception e)
                {
                    MessageBox.Show("Unexpected exception: " + e.ToString());
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        //Send notification to pager
        public void Send(byte[] notification)
        {
            byte[] bytes = new byte[1024];

            int bytesSent = this.sender.Send(notification);
            int bytesRec = this.sender.Receive(bytes);

            if (debug)
            {
                MessageBox.Show(Encoding.ASCII.GetString(bytes, 0, bytesRec));
            }

            bytesSent = this.sender.Send(Encoding.ASCII.GetBytes("</PageRequest>\n"));
            bytesRec = this.sender.Receive(bytes);
        }

        //Close Connection after send notification
        public void CloseConnection()
        {
            this.sender.Shutdown(SocketShutdown.Both);
            this.sender.Close();
        }

        #endregion

    }
}
