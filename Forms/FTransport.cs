using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Cursework.Models.Transport;

namespace Cursework.Forms
{
    public partial class FTransport : Form
    {
        public Transport Transport;

        // Custom colors
        private readonly Color _primaryColor = Color.FromArgb(51, 102, 153);
        private readonly Color _secondaryColor = Color.FromArgb(240, 240, 240);
        private readonly Color _accentColor = Color.FromArgb(41, 128, 185);

        public FTransport()
        {
            InitializeComponent();
            ApplyCustomStyling();
        }

        public FTransport(Transport transport)
        {
            Transport = transport;
            InitializeComponent();
            ApplyCustomStyling();

            switch (transport.Type)
            {
                case "Car":
                    cbTransportType.Text = "Автомобіль";
                    break;
                case "Truck":
                    cbTransportType.Text = "Вантажівка";
                    break;
                case "Motorbike":
                    cbTransportType.Text = "Мотоцикл";
                    break;
            }

            tbRegistrationNumber.Text = transport.RegistrationNumber;
            tbMake.Text = transport.Make;
            tbModel.Text = transport.Model;
            tbYearOfManufacture.Text = transport.YearOfManufacture.ToString();
            tbMileage.Text = transport.Mileage.ToString();
            cbTransportType.Text = transport.Type;

            switch (transport)
            {
                case Car car:
                    textBox.Text = car.PassengerCapacity.ToString();
                    break;
                case Truck truck:
                    textBox.Text = truck.LoadCapacity.ToString();
                    break;
                case Motorbike _:
                    label.Visible = false;
                    textBox.Visible = false;
                    break;
            }
        }

        private void ApplyCustomStyling()
        {
            // Form styling
            this.BackColor = _secondaryColor;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Інформація про транспорт";
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
                    comboBox.Font = new Font("Segoe UI", 12F);
                    comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                }
            }

            // Group form fields in panels for better organization
            Panel detailsPanel = new Panel();
            detailsPanel.BorderStyle = BorderStyle.FixedSingle;
            detailsPanel.Location = new Point(14, 55);
            detailsPanel.Size = new Size(555, 265);
            detailsPanel.BackColor = Color.White;
            detailsPanel.Padding = new Padding(10);

            // Button styling
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.BackColor = _accentColor;
            btnSave.ForeColor = Color.White;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.Cursor = Cursors.Hand;
            btnSave.Size = new Size(120, 45);

            // Register the form load event for adding mileage update UI
            this.Load += FTransport_Load;
        }

        private void FTransport_Load(object sender, EventArgs e)
        {
            // Add a new panel for updating mileage if editing an existing transport
            if (Transport != null)
            {
                Panel updateMileagePanel = new Panel();
                updateMileagePanel.BorderStyle = BorderStyle.FixedSingle;
                updateMileagePanel.Location = new Point(14, 330);
                updateMileagePanel.Size = new Size(555, 70);
                updateMileagePanel.BackColor = Color.White;
                updateMileagePanel.Padding = new Padding(10);

                Label lblUpdateMileage = new Label();
                lblUpdateMileage.Text = "Оновити пробіг:";
                lblUpdateMileage.Location = new Point(10, 15);
                lblUpdateMileage.AutoSize = true;
                lblUpdateMileage.ForeColor = _primaryColor;
                lblUpdateMileage.Font = new Font("Segoe UI", 12F);

                TextBox tbNewMileage = new TextBox();
                tbNewMileage.Location = new Point(180, 15);
                tbNewMileage.Size = new Size(150, 30);
                tbNewMileage.BorderStyle = BorderStyle.FixedSingle;
                tbNewMileage.Font = new Font("Segoe UI", 12F);

                Button btnUpdateMileage = new Button();
                btnUpdateMileage.Text = "Оновити";
                btnUpdateMileage.Location = new Point(340, 15);
                btnUpdateMileage.Size = new Size(100, 30);
                btnUpdateMileage.FlatStyle = FlatStyle.Flat;
                btnUpdateMileage.BackColor = _accentColor;
                btnUpdateMileage.ForeColor = Color.White;
                btnUpdateMileage.Cursor = Cursors.Hand;
                btnUpdateMileage.Click += (s, args) =>
                {
                    try
                    {
                        double newMileage;
                        if (double.TryParse(tbNewMileage.Text, out newMileage))
                        {
                            Transport.UpdateMileage(newMileage);
                            tbMileage.Text = newMileage.ToString();
                            MessageBox.Show("Пробіг успішно оновлено!", "Успіх", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Будь ласка, введіть коректне значення пробігу!", "Помилка", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (ArgumentException ex)
                    {
                        MessageBox.Show(ex.Message, "Помилка", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                };

                updateMileagePanel.Controls.Add(lblUpdateMileage);
                updateMileagePanel.Controls.Add(tbNewMileage);
                updateMileagePanel.Controls.Add(btnUpdateMileage);

                this.Controls.Add(updateMileagePanel);
                
                // Adjust form height to accommodate the new panel
                this.Height += 85;
                
                // Adjust the position of the Save button
                btnSave.Location = new Point(btnSave.Location.X, btnSave.Location.Y + 85);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (cbTransportType.Text)
            {
                case "Автомобіль":
                    if (Transport == null)
                    {
                        Transport = new Car();
                    }
                    Transport.RegistrationNumber = tbRegistrationNumber.Text;
                    Transport.Make = tbMake.Text;
                    Transport.Model = tbModel.Text;
                    Transport.YearOfManufacture = int.Parse(tbYearOfManufacture.Text);
                    Transport.Mileage = int.Parse(tbMileage.Text);
                    ((Car)Transport).PassengerCapacity = int.Parse(textBox.Text);
                    break;
                case "Вантажівка":
                    if (Transport == null)
                    {
                        Transport = new Truck();
                    }
                    Transport.RegistrationNumber = tbRegistrationNumber.Text;
                    Transport.Make = tbMake.Text;
                    Transport.Model = tbModel.Text;
                    Transport.YearOfManufacture = int.Parse(tbYearOfManufacture.Text);
                    Transport.Mileage = int.Parse(tbMileage.Text);
                    ((Truck)Transport).LoadCapacity = double.Parse(textBox.Text);
                    break;
                case "Мотоцикл":
                    if (Transport == null)
                    {
                        Transport = new Motorbike();
                    }
                    Transport.RegistrationNumber = tbRegistrationNumber.Text;
                    Transport.Make = tbMake.Text;
                    Transport.Model = tbModel.Text;
                    Transport.YearOfManufacture = int.Parse(tbYearOfManufacture.Text);
                    Transport.Mileage = int.Parse(tbMileage.Text);
                    break;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void cbTransportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbTransportType.Text)
            {
                case "Автомобіль":
                    label.Text = "К-сть пасажирів";
                    label.Visible = true;
                    textBox.Visible = true;
                    break;
                case "Вантажівка":
                    label.Text = "Вантажопідйомність";
                    label.Visible = true;
                    textBox.Visible = true;
                    break;
                case "Мотоцикл":
                    label.Visible = false;
                    textBox.Visible = false;
                    break;
            }
        }
    }
}
