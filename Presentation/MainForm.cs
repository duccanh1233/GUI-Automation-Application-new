using NModbus;
using Presentation.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class MainForm : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        Forms.FormSetting formSetting = new Forms.FormSetting();

        public MainForm()
        {
            InitializeComponent();
            random = new Random();
            btnHome.Visible = false;


        }


        #region SelectThemeColor
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }

            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        #endregion

        #region ActiveButton
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    //panelTitle.BackColor = color;
                    //panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    //ThemeColor.PrimaryColor = color;
                    //ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnHome.Visible = true;
                }
            }
        }
        #endregion

        #region Disable Button
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(59, 80, 124);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        #endregion

        #region Open Child Form


        private void OpenChildForm(Form childForm, object btnSender)
        {

            if (activeForm != null)
            {
                activeForm.Close();
            }

            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelHOME.Controls.Add(childForm);
            this.panelHOME.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();


        }
        #endregion

        private void btnAutoMode_Click(object sender, EventArgs e)
        {
            Forms.FormAutoMode formAutoMode = new Forms.FormAutoMode();
            OpenChildForm(formAutoMode, sender);
            lblTitle.Text = btnAutoMode.Text.Substring(4);
        }

        private void btnManualMode_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormManualMode(), sender);
            lblTitle.Text = btnManualMode.Text.Substring(4);
            //ActivateButton(sender);
        }

        private void btnIOMonitor_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormIOMonitor(), sender);
            lblTitle.Text = btnIOMonitor.Text.Substring(4);
            //ActivateButton(sender);
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {

            OpenChildForm(new Forms.FormConnection(), sender);
            lblTitle.Text = btnConnection.Text.Substring(4);

        }
        private void btnSetting_Click(object sender, EventArgs e)
        {
            Forms.FormSetting formSetting = new Forms.FormSetting();
            OpenChildForm(formSetting, sender);
            lblTitle.Text = btnSetting.Text.Substring(3);

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormReport(), sender);
            lblTitle.Text = btnReport.Text.Substring(2);
        }

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            Forms.FormAlarm formAlarm = new Forms.FormAlarm();
            OpenChildForm(formAlarm, sender);
            lblTitle.Text = btnAlarm.Text.Substring(2);

        }

        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";

            currentButton = null;
            btnHome.Visible = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (panelMenu.Width == 215)
            {
                panelMenu.Width = 60;
            }
            else
                panelMenu.Width = 215;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to log out ?", "Warning",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("vi");
            System.Diagnostics.Debug.WriteLine("---> [DEBUG]: Đang Chọn là cờ Việt ");

            //this.Controls.Clear();
            //InitializeComponent();

            ApplyResourcesToControl(this, new System.ComponentModel.ComponentResourceManager(typeof(MainForm)));
            //ApplyResourcesToControl(this, new System.ComponentModel.ComponentResourceManager(typeof(FormAlarm)));
            //ApplyResourcesToControl(this, new System.ComponentModel.ComponentResourceManager(typeof(FormAutoMode)));
            ApplyResourcesToControl(this, new System.ComponentModel.ComponentResourceManager(typeof(FormConnection)));
            //ApplyResourcesToControl(this, new System.ComponentModel.ComponentResourceManager(typeof(FormIOMonitor)));
            //ApplyResourcesToControl(this, new System.ComponentModel.ComponentResourceManager(typeof(FormManualMode)));
            //ApplyResourcesToControl(this, new System.ComponentModel.ComponentResourceManager(typeof(FormReport)));
            //ApplyResourcesToControl(this, new System.ComponentModel.ComponentResourceManager(typeof(FormSetting)));
            //ApplyResourcesToControl(this, new System.ComponentModel.ComponentResourceManager(typeof(FormTest)));
            //ApplyResourcesToControl(this, new System.ComponentModel.ComponentResourceManager(typeof(SubCreateModel)));
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            System.Diagnostics.Debug.WriteLine("---> [DEBUG]: Đang Chọn là cờ Anh ");

            //this.Controls.Clear(); 
            //InitializeComponent();
            ApplyResourcesToControl(this, new System.ComponentModel.ComponentResourceManager(typeof(MainForm)));
            //ApplyResourcesToControl(this, new System.ComponentModel.ComponentResourceManager(typeof(FormAlarm)));
            //ApplyResourcesToControl(this, new System.ComponentModel.ComponentResourceManager(typeof(FormAutoMode)));
            ApplyResourcesToControl(this, new System.ComponentModel.ComponentResourceManager(typeof(FormConnection)));
            //ApplyResourcesToControl(this, new System.ComponentModel.ComponentResourceManager(typeof(FormIOMonitor)));
            //ApplyResourcesToControl(this, new System.ComponentModel.ComponentResourceManager(typeof(FormManualMode)));
            //ApplyResourcesToControl(this, new System.ComponentModel.ComponentResourceManager(typeof(FormReport)));
            //ApplyResourcesToControl(this, new System.ComponentModel.ComponentResourceManager(typeof(FormSetting)));
            //ApplyResourcesToControl(this, new System.ComponentModel.ComponentResourceManager(typeof(FormTest)));
            //ApplyResourcesToControl(this, new System.ComponentModel.ComponentResourceManager(typeof(SubCreateModel)));
        }
        private void ApplyResourcesToControl(Control control, System.ComponentModel.ComponentResourceManager res)
        {
            res.ApplyResources(control, control.Name);
            foreach (Control child in control.Controls)
            {
                ApplyResourcesToControl(child, res);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }

}
