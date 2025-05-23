using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Cursework.Models;
using Cursework.Models.Transport;

namespace Cursework.Forms
{
    public partial class FMaintenanceRecord : Form
    {
        public readonly MaintenanceRecord MaintenanceRecord;

        // Custom colors
        private readonly Color _primaryColor = Color.FromArgb(51, 102, 153);
        private readonly Color _secondaryColor = Color.FromArgb(240, 240, 240);
        private readonly Color _accentColor = Color.FromArgb(41, 128, 185);

        public FMaintenanceRecord(MaintenanceRecord maintenanceRecord)
        {
            MaintenanceRecord = maintenanceRecord;
            InitializeComponent();
            ApplyCustomStyling();

            tbDescription.Text = maintenanceRecord.Description;
            tbPrice.Text = maintenanceRecord.Cost.ToString(CultureInfo.CurrentCulture);
            dateTimePicker.Value = maintenanceRecord.Date;

            cbTransport.Items.Clear();
            cbTransport.Items.AddRange(FMain.TransportData.Select(t => t.RegistrationNumber).ToArray<object>());
            cbTransport.SelectedItem = maintenanceRecord.Transport?.RegistrationNumber;
        }
        

        public FMaintenanceRecord()
        {
            MaintenanceRecord = new MaintenanceRecord();
            InitializeComponent();
            ApplyCustomStyling();

            // Populate ComboBox with transport options
            cbTransport.Items.Clear();
            cbTransport.Items.AddRange(FMain.TransportData.Select(t => t.RegistrationNumber).ToArray<object>());
        }

        private void ApplyCustomStyling()
        {
            // Form styling
            this.BackColor = _secondaryColor;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Запис про обслуговування";
            this.Icon = SystemIcons.Information;

            // Apply styling to controls
            foreach (Control control in this.Controls)
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
                else if (control is DateTimePicker dateTimePicker)
                {
                    dateTimePicker.Format = DateTimePickerFormat.Short;
                    dateTimePicker.Font = new Font("Segoe UI", 10F);
                }
            }

            // Description box styling
            tbDescription.Multiline = true;
            tbDescription.ScrollBars = ScrollBars.Vertical;
            tbDescription.Font = new Font("Segoe UI", 10F);

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
            MaintenanceRecord.Description = tbDescription.Text;
            MaintenanceRecord.Cost = int.Parse(tbPrice.Text);
            MaintenanceRecord.Date = dateTimePicker.Value;

            // Assign selected transport
            string selectedTransport = cbTransport.SelectedItem?.ToString();
            MaintenanceRecord.Transport = FMain.TransportData
                .FirstOrDefault(t => t.RegistrationNumber == selectedTransport);
            MaintenanceRecord.Transport?.AddMaintenanceRecord(MaintenanceRecord);

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
