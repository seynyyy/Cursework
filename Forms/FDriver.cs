using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Cursework.Models;

namespace Cursework.Forms
{
    public partial class FDriver : Form
    {
        public Driver Driver;

        // Custom colors
        private readonly Color _primaryColor = Color.FromArgb(51, 102, 153);
        private readonly Color _secondaryColor = Color.FromArgb(240, 240, 240);
        private readonly Color _accentColor = Color.FromArgb(41, 128, 185);

        public FDriver()
        {
            InitializeComponent();
            ApplyCustomStyling();
            Driver = new Driver();
        }
        
        public FDriver(Driver driver)
        {
            InitializeComponent();
            ApplyCustomStyling();
            Driver = driver;
            tbName.Text = driver.Name;
            tbSurname.Text = driver.Surname;
            tbExperiance.Text = driver.Experience.ToString();
            
            switch (driver.License)
            {
                case DriverLicense.A:
                    rbLicenceA.Checked = true;
                    break;
                case DriverLicense.B:
                    rbLicenceB.Checked = true;
                    break;
                case DriverLicense.C:
                    rbLicenceC.Checked = true;
                    break;
            }
            
            cbTransport.Items.Clear();
            cbTransport.Items.AddRange(FMain.TransportData.Select(t => t.RegistrationNumber).ToArray<object>());
            cbTransport.SelectedItem = driver.Transport?.RegistrationNumber;
        }

        private void ApplyCustomStyling()
        {
            // Form styling
            this.BackColor = _secondaryColor;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Інформація про водія";
            this.Icon = SystemIcons.Information;
            
            // Apply styling to text boxes
            foreach(Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.BorderStyle = BorderStyle.FixedSingle;
                    textBox.BackColor = Color.White;
                }
                else if (control is Label label)
                {
                    label.ForeColor = _primaryColor;
                    label.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.FlatStyle = FlatStyle.Flat;
                    comboBox.BackColor = Color.White;
                }
            }
            
            // Group radio buttons in a panel with border
            Panel licensePanel = new Panel();
            licensePanel.BorderStyle = BorderStyle.FixedSingle;
            licensePanel.Location = new Point(188, 146);
            licensePanel.Size = new Size(193, 30);
            licensePanel.BackColor = Color.White;
            
            // Button styling
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.BackColor = _accentColor;
            btnSave.ForeColor = Color.White;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.Cursor = Cursors.Hand;
            btnSave.Size = new Size(120, 45);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Driver.Name = tbName.Text;
            Driver.Surname = tbSurname.Text;
            Driver.Experience = int.Parse(tbExperiance.Text);
            
            if (rbLicenceA.Checked)
                Driver.License = DriverLicense.A;
            else if (rbLicenceB.Checked)
                Driver.License = DriverLicense.B;
            else if (rbLicenceC.Checked)
                Driver.License = DriverLicense.C;

            // Assign selected transport
            var selectedTransport = cbTransport.SelectedItem?.ToString();
            Driver.Transport = FMain.TransportData
                .FirstOrDefault(t => t.RegistrationNumber == selectedTransport);

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
