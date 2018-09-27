/*
 * User: Michel Gutardo Ramos de Lima
 * Date: 01/11/2017
 * Time: 17:38
 */
 
using System;
using System.Windows.Forms;

namespace PagerLRS
{
	public partial class FrmNotification : Form
	{

        #region Private Properties

        private Notification notify;
        private Connection conn;

        #endregion

        #region Constructor

        public FrmNotification()
		{
			InitializeComponent();

            notify = new Notification();
            conn   = new Connection(true);
		}

        #endregion 

        #region Public Methods

        public void BtnSendClick(object sender, EventArgs e)
        {
            BtnSend.Enabled = false;
            this.SetData();
            this.conn.Connect();
            this.conn.Send(this.notify.full_notification);
            this.conn.CloseConnection();
            BtnSend.Enabled = true;
        }

        #endregion 

        #region Private Methods

        //Set connection e message data
        private void SetData()
        {
            this.notify.pager_id          = cbPagerID.Text;
            this.notify.system_id         = cbSystemId.Text;
            this.notify.notification_type = cbNotificationType.Text;
            this.notify.SetFullNotification();

            this.conn.ip = txtIP.Text;
            this.conn.port = Int32.Parse(nuPort.Value.ToString());

        }

        #endregion 

    }
	

}
