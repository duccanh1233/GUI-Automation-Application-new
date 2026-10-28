
namespace Presentation.Forms
{
    partial class FormConnection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConnection));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbListPLC = new System.Windows.Forms.ComboBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStatusConnectPLC = new System.Windows.Forms.Label();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelText = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtD0 = new System.Windows.Forms.TextBox();
            this.txtD100 = new System.Windows.Forms.TextBox();
            this.txtFloatD200 = new System.Windows.Forms.TextBox();
            this.txtReadD10 = new System.Windows.Forms.TextBox();
            this.txtReadDworkD100 = new System.Windows.Forms.TextBox();
            this.txtReadFloadD200 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbListPLC);
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblStatusConnectPLC);
            this.groupBox1.Controls.Add(this.buttonDisconnect);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.txtIPAddress);
            this.groupBox1.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbbListPLC
            // 
            this.cbbListPLC.AllowDrop = true;
            this.cbbListPLC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbListPLC.FormattingEnabled = true;
            this.cbbListPLC.Items.AddRange(new object[] {
            resources.GetString("cbbListPLC.Items"),
            resources.GetString("cbbListPLC.Items1")});
            resources.ApplyResources(this.cbbListPLC, "cbbListPLC");
            this.cbbListPLC.Name = "cbbListPLC";
            this.cbbListPLC.SelectedIndexChanged += new System.EventHandler(this.comboBoxCPUType_SelectedIndexChanged);
            // 
            // txtPort
            // 
            resources.ApplyResources(this.txtPort, "txtPort");
            this.txtPort.Name = "txtPort";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblStatusConnectPLC
            // 
            resources.ApplyResources(this.lblStatusConnectPLC, "lblStatusConnectPLC");
            this.lblStatusConnectPLC.ForeColor = System.Drawing.Color.Red;
            this.lblStatusConnectPLC.Name = "lblStatusConnectPLC";
            this.lblStatusConnectPLC.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonDisconnect
            // 
            resources.ApplyResources(this.buttonDisconnect, "buttonDisconnect");
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // btnConnect
            // 
            resources.ApplyResources(this.btnConnect, "btnConnect");
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtIPAddress
            // 
            resources.ApplyResources(this.txtIPAddress, "txtIPAddress");
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.TextChanged += new System.EventHandler(this.txtIPAddress_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelText
            // 
            this.panelText.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.panelText, "panelText");
            this.panelText.Name = "panelText";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtD0
            // 
            resources.ApplyResources(this.txtD0, "txtD0");
            this.txtD0.Name = "txtD0";
            this.txtD0.TextChanged += new System.EventHandler(this.txtD0_TextChanged);
            // 
            // txtD100
            // 
            resources.ApplyResources(this.txtD100, "txtD100");
            this.txtD100.Name = "txtD100";
            this.txtD100.TextChanged += new System.EventHandler(this.txtD100_TextChanged);
            // 
            // txtFloatD200
            // 
            resources.ApplyResources(this.txtFloatD200, "txtFloatD200");
            this.txtFloatD200.Name = "txtFloatD200";
            this.txtFloatD200.TextChanged += new System.EventHandler(this.txtFloatD200_TextChanged);
            // 
            // txtReadD10
            // 
            resources.ApplyResources(this.txtReadD10, "txtReadD10");
            this.txtReadD10.Name = "txtReadD10";
            this.txtReadD10.TextChanged += new System.EventHandler(this.txtReadD10_TextChanged);
            // 
            // txtReadDworkD100
            // 
            resources.ApplyResources(this.txtReadDworkD100, "txtReadDworkD100");
            this.txtReadDworkD100.Name = "txtReadDworkD100";
            // 
            // txtReadFloadD200
            // 
            resources.ApplyResources(this.txtReadFloadD200, "txtReadFloadD200");
            this.txtReadFloadD200.Name = "txtReadFloadD200";
            // 
            // FormConnection
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtReadFloadD200);
            this.Controls.Add(this.txtReadDworkD100);
            this.Controls.Add(this.txtReadD10);
            this.Controls.Add(this.txtFloatD200);
            this.Controls.Add(this.txtD100);
            this.Controls.Add(this.txtD0);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelText);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormConnection";
            this.Load += new System.EventHandler(this.FormConnection_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatusConnectPLC;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbListPLC;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtD0;
        private System.Windows.Forms.TextBox txtD100;
        private System.Windows.Forms.TextBox txtFloatD200;
        private System.Windows.Forms.TextBox txtReadD10;
        private System.Windows.Forms.TextBox txtReadDworkD100;
        private System.Windows.Forms.TextBox txtReadFloadD200;
    }
}