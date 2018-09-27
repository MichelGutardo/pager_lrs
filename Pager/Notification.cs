/*
 * User: Michel Gutardo Ramos de Lima
 * Date: 01/11/2017
 * Time: 17:41
 */

using System.Text;

namespace PagerLRS
{
    class Notification
    {

        #region Public Properties 
        
        //Values selecteds 
        public string request_id { get; set; }
        public string pager_id { get; set; }
        public string system_id { get; set; }   
        public string notification_type { get; set; }
        
        //Notification with all properties 
        public byte[] full_notification { get; set; }

        #endregion

        #region Private Properties 

        //Strings to mount full_notification 
        private string notification_request_id { get; set; }
        private string notification_pager_id { get; set; }
        private string notification_system_id { get; set; }
        private string notification_message { get; set; }

        #endregion

        #region Private Methods

        //Request ID, if it isn't defined will use the default "41"
        private void SetRequestID()
        {
            this.notification_request_id = " id=\"" + 
                (this.request_id == string.Empty ? "41" : this.request_id) +
                "\"";
        }

        //Pager ID
        private void SetPagerID()
        {
            this.notification_pager_id= " pager=\"2;" + this.pager_id+ "\"";
        }

        //System ID
        private void SetSystemID()
        {
            this.notification_system_id = " system_id=\"" + this.system_id + "\"";
        }

        //Message Type Selected
        private void SetMessage() { 
            this.notification_message = " message=\"" + this.notification_type + "\"";
        }

        #endregion

        #region Public Methods

        //Assembly the whole message
        public void SetFullNotification()
        {
            full_notification = Encoding.ASCII.GetBytes("<PageRequest" +
                                                         this.notification_request_id +
                                                         this.notification_pager_id +
                                                         this.notification_system_id +
                                                         this.notification_message +
                                                         ">\n");
        }

        #endregion

    }
}
