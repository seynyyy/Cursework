using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using Cursework.Models;
using Cursework.Models.Transport;

namespace Cursework.Forms
{
    public partial class FMain : Form
    {
        private enum State
        {
            Transport,
            Driver,
            MaintenanceRecord,
            Report
        }

        private State _currentState;

        private static List<Transport> _transportData = new List<Transport>();

        public static IEnumerable<Transport> TransportData => _transportData;

        private List<Driver> _driversData = new List<Driver>();

        private List<MaintenanceRecord> _maintenanceData = new List<MaintenanceRecord>();

        private TextBox reportTextBox;

        public FMain()
        {
            InitializeComponent();
        }

        private void DataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            Console.WriteLine($"DataGridView error: {e.Exception.Message} at row {e.RowIndex}, column {e.ColumnIndex}");
        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                bool hasSelection = dataGridView.CurrentRow != null && dataGridView.SelectedRows.Count > 0;

                if (this.Controls.Find("editEntry", true).FirstOrDefault() is Button editButton)
                    editButton.Enabled = hasSelection;

                if (this.Controls.Find("delEntryBut", true).FirstOrDefault() is Button deleteButton)
                    deleteButton.Enabled = hasSelection;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Selection changed error: {ex.Message}");
            }
        }

        private void FMain_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;

            if (this.Controls.Find("editEntry", true).FirstOrDefault() is Button editButton)
                editButton.Enabled = false;

            if (this.Controls.Find("delEntryBut", true).FirstOrDefault() is Button deleteButton)
                deleteButton.Enabled = false;

            btnTransport_Click(null, null);
        }

        private void OpenAddTransportForm()
        {
            using (var form = new FTransport())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _transportData.Add(form.Transport);
                }
            }
            dataGridView.Refresh();
        }

        private void OpenAddDriverForm()
        {
            using (var form = new FDriver())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _driversData.Add(form.Driver);
                }
            }
            dataGridView.Refresh();
        }

        private void OpenAddMaintenanceForm()
        {
            using (var form = new FMaintenanceRecord())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _maintenanceData.Add(form.MaintenanceRecord);
                }
            }
            dataGridView.Refresh();
        }

        private void newEntryButton_Click(object sender, EventArgs e)
        {
            switch (_currentState)
            {
                case State.Transport:
                    OpenAddTransportForm();
                    break;
                case State.Driver:
                    OpenAddDriverForm();
                    break;
                case State.MaintenanceRecord:
                    OpenAddMaintenanceForm();
                    break;
                default:
                    MessageBox.Show("Unknown state!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void btnTransport_Click(object sender, EventArgs e)
        {
            if (reportTextBox != null) reportTextBox.Visible = false;
            dataGridView.Visible = true;

            _currentState = State.Transport;

            dataGridView.ClearSelection();
            dataGridView.Columns.Clear();
            dataGridView.DataSource = null;

            if (_transportData.Any())
            {
                dataGridView.DataSource = _transportData;
            }
            else
            {
                dataGridView.DataSource = new List<Transport>();
            }

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Type";
            column.Name = "Тип транспорта";
            dataGridView.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "RegistrationNumber";
            column.Name = "Реєстраційний номер";
            dataGridView.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Make";
            column.Name = "Марка";
            dataGridView.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Model";
            column.Name = "Модель";
            dataGridView.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "YearOfManufacture";
            column.Name = "Рік випуску";
            dataGridView.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Mileage";
            column.Name = "Пробіг";
            dataGridView.Columns.Add(column);

            dataGridView.Refresh();

            if (this.Controls.Find("editEntry", true).FirstOrDefault() is Button editButton)
                editButton.Enabled = false;

            if (this.Controls.Find("delEntryBut", true).FirstOrDefault() is Button deleteButton)
                deleteButton.Enabled = false;
        }

        private void btnDrivers_Click(object sender, EventArgs e)
        {
            if (reportTextBox != null) reportTextBox.Visible = false;
            dataGridView.Visible = true;

            _currentState = State.Driver;

            dataGridView.ClearSelection();
            dataGridView.Columns.Clear();
            dataGridView.DataSource = null;

            if (_driversData.Any())
            {
                dataGridView.DataSource = _driversData;
            }
            else
            {
                dataGridView.DataSource = new List<Driver>();
            }

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name";
            column.Name = "Ім'я";
            dataGridView.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Surname";
            column.Name = "Прізвище";
            dataGridView.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Experience";
            column.Name = "Досвід";
            dataGridView.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "License";
            column.Name = "Ліцензія";
            dataGridView.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "TransportRegistrationNumber";
            column.Name = "Транспорт";
            dataGridView.Columns.Add(column);

            dataGridView.Refresh();

            if (this.Controls.Find("editEntry", true).FirstOrDefault() is Button editButton)
                editButton.Enabled = false;

            if (this.Controls.Find("delEntryBut", true).FirstOrDefault() is Button deleteButton)
                deleteButton.Enabled = false;
        }

        private void btnMaintenanceRecord_Click(object sender, EventArgs e)
        {
            if (reportTextBox != null) reportTextBox.Visible = false;
            dataGridView.Visible = true;

            _currentState = State.MaintenanceRecord;

            dataGridView.ClearSelection();
            dataGridView.Columns.Clear();
            dataGridView.DataSource = null;

            if (_maintenanceData.Any())
            {
                dataGridView.DataSource = _maintenanceData;
            }
            else
            {
                dataGridView.DataSource = new List<MaintenanceRecord>();
            }

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "TransportRegistrationNumber";
            column.Name = "Транспорт";
            dataGridView.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Description";
            column.Name = "Опис";
            dataGridView.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Cost";
            column.Name = "Вартість";
            dataGridView.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Date";
            column.Name = "Дата";
            dataGridView.Columns.Add(column);

            dataGridView.Refresh();

            if (this.Controls.Find("editEntry", true).FirstOrDefault() is Button editButton)
                editButton.Enabled = false;

            if (this.Controls.Find("delEntryBut", true).FirstOrDefault() is Button deleteButton)
                deleteButton.Enabled = false;
        }

        private void formReportButton_Click(object sender, EventArgs e)
        {
            _currentState = State.Report;

            dataGridView.ClearSelection();
            dataGridView.Columns.Clear();
            dataGridView.Visible = false;

            if (reportTextBox == null)
            {
                reportTextBox = new TextBox();
                reportTextBox.Multiline = true;
                reportTextBox.ScrollBars = ScrollBars.Vertical;
                reportTextBox.ReadOnly = true;
                reportTextBox.BackColor = Color.White;
                reportTextBox.Font = new Font("Consolas", 10);
                reportTextBox.Dock = DockStyle.Fill;
                reportTextBox.Location = dataGridView.Location;
                reportTextBox.Size = dataGridView.Size;
                panel2.Controls.Add(reportTextBox);
            }
            reportTextBox.Visible = true;
            reportTextBox.BringToFront();

            if (!_transportData.Any())
            {
                reportTextBox.Text = "Немає даних для формування звіту.";
                return;
            }

            StringBuilder reportBuilder = new StringBuilder();
            reportBuilder.AppendLine("================ ЗВІТ ПРО СТАН АВТОТРАНСПОРТНОГО ПАРКУ ================\r\n");
            reportBuilder.AppendLine($"Дата звіту: {DateTime.Now:dd.MM.yyyy HH:mm}\r\n");
            reportBuilder.AppendLine($"Загальна кількість транспортних засобів: {_transportData.Count}\r\n");

            double totalMileage = _transportData.Sum(t => t.Mileage);
            double averageMileage = _transportData.Any() ? totalMileage / _transportData.Count : 0;
            double totalMaintenanceCost = _transportData.Sum(t => (t is IMaintenance maintenance) ? maintenance.CalculateTotalMaintenanceCost() : 0);

            reportBuilder.AppendLine($"Загальний пробіг всіх ТЗ: {totalMileage:N0} км");
            reportBuilder.AppendLine($"Середній пробіг: {averageMileage:N0} км");
            reportBuilder.AppendLine($"Загальна вартість обслуговування: {totalMaintenanceCost:N2} грн.\r\n");

            reportBuilder.AppendLine("================ ДЕТАЛІ ПО ТРАНСПОРТНИМ ЗАСОБАМ ================\r\n");

            foreach (var transport in _transportData)
            {
                reportBuilder.AppendLine($"--- {transport.Make} {transport.Model} ({transport.Type}) ---");
                reportBuilder.AppendLine($"Реєстраційний номер: {transport.RegistrationNumber}");
                reportBuilder.AppendLine($"Рік випуску: {transport.YearOfManufacture}");
                reportBuilder.AppendLine($"Пробіг: {transport.Mileage:N0} км");

                int vehicleAge = DateTime.Now.Year - transport.YearOfManufacture;
                DateTime nextInspectionDate = CalculateNextInspectionDate(vehicleAge);

                reportBuilder.AppendLine($"Вік транспорту: {vehicleAge} років");
                reportBuilder.AppendLine($"Наступний техогляд: {nextInspectionDate:dd.MM.yyyy}");

                if (transport is IMaintenance maintenance)
                {
                    reportBuilder.AppendLine($"Вартість обслуговування: {maintenance.CalculateTotalMaintenanceCost():N2} грн.");
                }

                reportBuilder.AppendLine(GetVehicleSpecificInfo(transport));

                var assignedDrivers = _driversData.Where(d => d.TransportRegistrationNumber == transport.RegistrationNumber).ToList();
                if (assignedDrivers.Any())
                {
                    reportBuilder.AppendLine("\nЗакріплені водії:");
                    foreach (var driver in assignedDrivers)
                    {
                        reportBuilder.AppendLine($"- {driver.Name} {driver.Surname}, досвід: {driver.Experience} років, ліцензія: {driver.License}");
                    }
                }
                else
                {
                    reportBuilder.AppendLine("\nНемає закріплених водіїв");
                }

                reportBuilder.AppendLine("\n");
            }

            reportTextBox.Text = reportBuilder.ToString();

            if (this.Controls.Find("editEntry", true).FirstOrDefault() is Button editButton)
                editButton.Enabled = false;

            if (this.Controls.Find("delEntryBut", true).FirstOrDefault() is Button deleteButton)
                deleteButton.Enabled = false;
        }

        private DateTime CalculateNextInspectionDate(int vehicleAge)
        {
            DateTime today = DateTime.Now.Date;

            if (vehicleAge < 3)
            {
                return today.AddYears(2);
            }
            else if (vehicleAge < 7)
            {
                return today.AddYears(1);
            }
            else if (vehicleAge < 15)
            {
                return today.AddMonths(6);
            }
            else
            {
                return today.AddMonths(3);
            }
        }

        private string GetVehicleSpecificInfo(Transport transport)
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine();

            switch (transport)
            {
                case Car car:
                    info.AppendLine($"Кількість пасажирів: {car.PassengerCapacity}");
                    break;
                case Truck truck:
                    info.AppendLine($"Вантажопідйомність: {truck.LoadCapacity} т");
                    break;
            }

            return info.ToString();
        }

        private void editEntry_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null || dataGridView.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Будь ласка, виберіть запис для редагування.", "Попередження",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            switch (_currentState)
            {
                case State.Transport:
                    try
                    {
                        var transport = (Transport)dataGridView.CurrentRow.DataBoundItem;
                        using (var form = new FTransport(transport))
                        {
                            if (form.ShowDialog() == DialogResult.OK)
                            {
                                dataGridView.Refresh();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Помилка редагування: {ex.Message}", "Помилка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case State.Driver:
                    try
                    {
                        var driver = (Driver)dataGridView.CurrentRow.DataBoundItem;
                        using (var form = new FDriver(driver))
                        {
                            if (form.ShowDialog() == DialogResult.OK)
                            {
                                dataGridView.Refresh();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Помилка редагування: {ex.Message}", "Помилка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case State.MaintenanceRecord:
                    try
                    {
                        var maintenanceRecord = (MaintenanceRecord)dataGridView.CurrentRow.DataBoundItem;
                        using (var form = new FMaintenanceRecord(maintenanceRecord))
                        {
                            if (form.ShowDialog() == DialogResult.OK)
                            {
                                dataGridView.Refresh();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Помилка редагування: {ex.Message}", "Помилка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                default:
                    MessageBox.Show("Редагування не доступне у поточному режимі.", "Інформація",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        private void delEntryBut_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null || dataGridView.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Будь ласка, виберіть запис для видалення.", "Попередження",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити цей запис?",
                "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                switch (_currentState)
                {
                    case State.Transport:
                        if (dataGridView.CurrentRow.DataBoundItem is Transport transport)
                        {
                            _transportData.Remove(transport);
                            dataGridView.DataSource = null;
                            dataGridView.DataSource = _transportData.Any() ? _transportData : new List<Transport>();
                        }
                        break;

                    case State.Driver:
                        if (dataGridView.CurrentRow.DataBoundItem is Driver driver)
                        {
                            _driversData.Remove(driver);
                            dataGridView.DataSource = null;
                            dataGridView.DataSource = _driversData.Any() ? _driversData : new List<Driver>();
                        }
                        break;

                    case State.MaintenanceRecord:
                        if (dataGridView.CurrentRow.DataBoundItem is MaintenanceRecord record)
                        {
                            _maintenanceData.Remove(record);
                            dataGridView.DataSource = null;
                            dataGridView.DataSource = _maintenanceData.Any() ? _maintenanceData : new List<MaintenanceRecord>();
                        }
                        break;

                    default:
                        MessageBox.Show("Видалення для цього стану не підтримується.", "Помилка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

                dataGridView.Refresh();

                if (this.Controls.Find("editEntry", true).FirstOrDefault() is Button editButton)
                    editButton.Enabled = false;

                if (this.Controls.Find("delEntryBut", true).FirstOrDefault() is Button deleteButton)
                    deleteButton.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка видалення: {ex.Message}", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveEntryButton_Click(object sender, EventArgs e)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Binary Files (*.bin)|*.bin";
                saveFileDialog.Title = "Save Data";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        var formatter = new BinaryFormatter();
                        formatter.Serialize(stream, new Tuple<List<Transport>, List<Driver>, List<MaintenanceRecord>>(
                            _transportData, _driversData, _maintenanceData));
                    }
                }
            }
        }

        private void loadEntryButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Binary Files (*.bin)|*.bin";
                    openFileDialog.Title = "Load Data";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (var stream = new FileStream(openFileDialog.FileName, FileMode.Open))
                        {
                            var formatter = new BinaryFormatter();
                            var data = (Tuple<List<Transport>, List<Driver>, List<MaintenanceRecord>>)formatter.Deserialize(stream);

                            _transportData.Clear();
                            _transportData.AddRange(data.Item1);

                            _driversData.Clear();
                            _driversData.AddRange(data.Item2);

                            _maintenanceData.Clear();
                            _maintenanceData.AddRange(data.Item3);

                            RefreshCurrentView();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка завантаження даних: {ex.Message}", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshCurrentView()
        {
            dataGridView.ClearSelection();

            switch (_currentState)
            {
                case State.Transport:
                    if (reportTextBox != null) reportTextBox.Visible = false;
                    dataGridView.Visible = true;

                    dataGridView.DataSource = null;
                    dataGridView.DataSource = _transportData.Any() ? _transportData : new List<Transport>();
                    break;

                case State.Driver:
                    if (reportTextBox != null) reportTextBox.Visible = false;
                    dataGridView.Visible = true;

                    dataGridView.DataSource = null;
                    dataGridView.DataSource = _driversData.Any() ? _driversData : new List<Driver>();
                    break;

                case State.MaintenanceRecord:
                    if (reportTextBox != null) reportTextBox.Visible = false;
                    dataGridView.Visible = true;

                    dataGridView.DataSource = null;
                    dataGridView.DataSource = _maintenanceData.Any() ? _maintenanceData : new List<MaintenanceRecord>();
                    break;

                case State.Report:
                    formReportButton_Click(null, null);
                    break;
            }

            dataGridView.Refresh();
        }
    }
}
