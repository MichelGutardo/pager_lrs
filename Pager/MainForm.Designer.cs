/*
  * User: Michel Gutardo Ramos de Lima
 * Date: 01/11/2017
 * Time: 17:38
 */
namespace PagerLRS
{
    partial class FrmNotification
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnSend = new System.Windows.Forms.Button();
            this.cbPagerID = new System.Windows.Forms.ComboBox();
            this.cbNotificationType = new System.Windows.Forms.ComboBox();
            this.cbSystemId = new System.Windows.Forms.ComboBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.nuPort = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSystemID = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.lxlIP = new System.Windows.Forms.Label();
            this.lblPagerID = new System.Windows.Forms.Label();
            this.lblNotificationType = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nuPort)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSend
            // 
            this.BtnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSend.ForeColor = System.Drawing.Color.Red;
            this.BtnSend.Location = new System.Drawing.Point(491, 20);
            this.BtnSend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(100, 63);
            this.BtnSend.TabIndex = 0;
            this.BtnSend.Text = "Send";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSendClick);
            // 
            // cbPagerID
            // 
            this.cbPagerID.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cbPagerID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPagerID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPagerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPagerID.FormattingEnabled = true;
            this.cbPagerID.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cbPagerID.Location = new System.Drawing.Point(111, 41);
            this.cbPagerID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbPagerID.Name = "cbPagerID";
            this.cbPagerID.Size = new System.Drawing.Size(68, 25);
            this.cbPagerID.TabIndex = 1;
            this.cbPagerID.Text = "1";
            // 
            // cbNotificationType
            // 
            this.cbNotificationType.AutoCompleteCustomSource.AddRange(new string[] {
            "Flash1Sec",
            "Flash30Sec",
            "Flash5Min",
            "Glow15Times"});
            this.cbNotificationType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbNotificationType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNotificationType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNotificationType.FormattingEnabled = true;
            this.cbNotificationType.Items.AddRange(new object[] {
            "Flash1Sec",
            "Flash30Sec",
            "Flash5Min",
            "Glow15Times"});
            this.cbNotificationType.Location = new System.Drawing.Point(321, 42);
            this.cbNotificationType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbNotificationType.Name = "cbNotificationType";
            this.cbNotificationType.Size = new System.Drawing.Size(136, 25);
            this.cbNotificationType.TabIndex = 2;
            this.cbNotificationType.Text = "Flash30Sec";
            // 
            // cbSystemId
            // 
            this.cbSystemId.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cbSystemId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSystemId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSystemId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSystemId.FormattingEnabled = true;
            this.cbSystemId.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cbSystemId.Location = new System.Drawing.Point(509, 26);
            this.cbSystemId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSystemId.Name = "cbSystemId";
            this.cbSystemId.Size = new System.Drawing.Size(68, 25);
            this.cbSystemId.TabIndex = 3;
            this.cbSystemId.Text = "20";
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP.Location = new System.Drawing.Point(52, 23);
            this.txtIP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(136, 23);
            this.txtIP.TabIndex = 4;
            // 
            // nuPort
            // 
            this.nuPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuPort.Location = new System.Drawing.Point(291, 25);
            this.nuPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nuPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nuPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuPort.Name = "nuPort";
            this.nuPort.Size = new System.Drawing.Size(75, 23);
            this.nuPort.TabIndex = 5;
            this.nuPort.Value = new decimal(new int[] {
            3700,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSystemID);
            this.groupBox1.Controls.Add(this.lblPort);
            this.groupBox1.Controls.Add(this.cbSystemId);
            this.groupBox1.Controls.Add(this.lxlIP);
            this.groupBox1.Controls.Add(this.nuPort);
            this.groupBox1.Controls.Add(this.txtIP);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(599, 70);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection data:";
            // 
            // lblSystemID
            // 
            this.lblSystemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemID.Location = new System.Drawing.Point(392, 26);
            this.lblSystemID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSystemID.Name = "lblSystemID";
            this.lblSystemID.Size = new System.Drawing.Size(109, 23);
            this.lblSystemID.TabIndex = 7;
            this.lblSystemID.Text = "System ID:";
            // 
            // lblPort
            // 
            this.lblPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPort.Location = new System.Drawing.Point(209, 25);
            this.lblPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(73, 23);
            this.lblPort.TabIndex = 6;
            this.lblPort.Text = "Port:";
            // 
            // lxlIP
            // 
            this.lxlIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lxlIP.Location = new System.Drawing.Point(8, 25);
            this.lxlIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lxlIP.Name = "lxlIP";
            this.lxlIP.Size = new System.Drawing.Size(36, 23);
            this.lxlIP.TabIndex = 5;
            this.lxlIP.Text = "IP:";
            // 
            // lblPagerID
            // 
            this.lblPagerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagerID.Location = new System.Drawing.Point(8, 41);
            this.lblPagerID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPagerID.Name = "lblPagerID";
            this.lblPagerID.Size = new System.Drawing.Size(100, 23);
            this.lblPagerID.TabIndex = 8;
            this.lblPagerID.Text = "Pager ID:";
            // 
            // lblNotificationType
            // 
            this.lblNotificationType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificationType.Location = new System.Drawing.Point(197, 43);
            this.lblNotificationType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotificationType.Name = "lblNotificationType";
            this.lblNotificationType.Size = new System.Drawing.Size(116, 23);
            this.lblNotificationType.TabIndex = 9;
            this.lblNotificationType.Text = "Notification:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPagerID);
            this.groupBox2.Controls.Add(this.lblNotificationType);
            this.groupBox2.Controls.Add(this.BtnSend);
            this.groupBox2.Controls.Add(this.cbPagerID);
            this.groupBox2.Controls.Add(this.cbNotificationType);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 92);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(599, 96);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Send Notification";
            // 
            // FrmNotification
            // 
            this.AcceptButton = this.BtnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 201);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNotification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pager Notification (LRS TX-7470)";
            ((System.ComponentModel.ISupportInitialize)(this.nuPort)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Label lblSystemID;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblPagerID;
        private System.Windows.Forms.Label lblNotificationType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.ComboBox cbPagerID;
        private System.Windows.Forms.ComboBox cbNotificationType;
        private System.Windows.Forms.ComboBox cbSystemId;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.NumericUpDown nuPort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lxlIP;
    }
}
