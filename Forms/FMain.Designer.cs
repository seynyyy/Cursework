namespace Cursework.Forms
{
    partial class FMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDrivers = new System.Windows.Forms.Button();
            this.btnTransport = new System.Windows.Forms.Button();
            this.btnMaintanceRecord = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.newEntryButton = new System.Windows.Forms.ToolStripButton();
            this.saveEntryButton = new System.Windows.Forms.ToolStripButton();
            this.loadEntryButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.editEntry = new System.Windows.Forms.ToolStripButton();
            this.delEntryBut = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.formReportButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDrivers);
            this.panel1.Controls.Add(this.btnTransport);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 695);
            this.panel1.TabIndex = 0;
            // 
            // btnDrivers
            // 
            this.btnDrivers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnDrivers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDrivers.FlatAppearance.BorderSize = 0;
            this.btnDrivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrivers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDrivers.ForeColor = System.Drawing.Color.White;
            this.btnDrivers.Location = new System.Drawing.Point(0, 230);
            this.btnDrivers.Name = "btnDrivers";
            this.btnDrivers.Size = new System.Drawing.Size(183, 235);
            this.btnDrivers.TabIndex = 1;
            this.btnDrivers.Text = "Водії";
            this.btnDrivers.UseVisualStyleBackColor = false;
            this.btnDrivers.Click += new System.EventHandler(this.btnDrivers_Click);
            // 
            // btnTransport
            // 
            this.btnTransport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnTransport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransport.FlatAppearance.BorderSize = 0;
            this.btnTransport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTransport.ForeColor = System.Drawing.Color.White;
            this.btnTransport.Location = new System.Drawing.Point(0, 0);
            this.btnTransport.Name = "btnTransport";
            this.btnTransport.Size = new System.Drawing.Size(183, 234);
            this.btnTransport.TabIndex = 0;
            this.btnTransport.Text = "Транспорт";
            this.btnTransport.UseVisualStyleBackColor = false;
            this.btnTransport.Click += new System.EventHandler(this.btnTransport_Click);
            // 
            // btnMaintanceRecord
            // 
            this.btnMaintanceRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnMaintanceRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaintanceRecord.FlatAppearance.BorderSize = 0;
            this.btnMaintanceRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintanceRecord.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMaintanceRecord.ForeColor = System.Drawing.Color.White;
            this.btnMaintanceRecord.Location = new System.Drawing.Point(0, 463);
            this.btnMaintanceRecord.Name = "btnMaintanceRecord";
            this.btnMaintanceRecord.Size = new System.Drawing.Size(183, 230);
            this.btnMaintanceRecord.TabIndex = 2;
            this.btnMaintanceRecord.Text = "Тех обслуговування";
            this.btnMaintanceRecord.UseVisualStyleBackColor = false;
            this.btnMaintanceRecord.Click += new System.EventHandler(this.btnMaintenanceRecord_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView);
            this.panel2.Controls.Add(this.toolStrip);
            this.panel2.Location = new System.Drawing.Point(189, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(920, 693);
            this.panel2.TabIndex = 3;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Location = new System.Drawing.Point(-3, 30);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.Height = 35;
            this.dataGridView.Size = new System.Drawing.Size(920, 677);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataGridView_DataError);
            this.dataGridView.SelectionChanged += new System.EventHandler(this.DataGridView_SelectionChanged);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.newEntryButton, this.saveEntryButton, this.loadEntryButton, this.toolStripSeparator, this.editEntry, this.delEntryBut, this.toolStripSeparator1, this.formReportButton, this.toolStripSeparator2 });
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(920, 27);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // newEntryButton
            // 
            this.newEntryButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newEntryButton.Image = global::Cursework.Properties.Resources.plus_sign;
            this.newEntryButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newEntryButton.Name = "newEntryButton";
            this.newEntryButton.Size = new System.Drawing.Size(23, 24);
            this.newEntryButton.Text = "Додати нове входження";
            this.newEntryButton.Click += new System.EventHandler(this.newEntryButton_Click);
            // 
            // saveEntryButton
            // 
            this.saveEntryButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveEntryButton.Image = global::Cursework.Properties.Resources.upload;
            this.saveEntryButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveEntryButton.Name = "saveEntryButton";
            this.saveEntryButton.Size = new System.Drawing.Size(23, 24);
            this.saveEntryButton.Text = "Зберегти";
            this.saveEntryButton.Click += new System.EventHandler(this.saveEntryButton_Click);
            // 
            // loadEntryButton
            // 
            this.loadEntryButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.loadEntryButton.Image = global::Cursework.Properties.Resources.download;
            this.loadEntryButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loadEntryButton.Name = "loadEntryButton";
            this.loadEntryButton.Size = new System.Drawing.Size(23, 24);
            this.loadEntryButton.Text = "Завантаження входжень";
            this.loadEntryButton.Click += new System.EventHandler(this.loadEntryButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // editEntry
            // 
            this.editEntry.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editEntry.Image = global::Cursework.Properties.Resources.edit;
            this.editEntry.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editEntry.Name = "editEntry";
            this.editEntry.Size = new System.Drawing.Size(23, 24);
            this.editEntry.Text = "Змінити входження";
            this.editEntry.Click += new System.EventHandler(this.editEntry_Click);
            // 
            // delEntryBut
            // 
            this.delEntryBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.delEntryBut.Image = global::Cursework.Properties.Resources.bin;
            this.delEntryBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.delEntryBut.Name = "delEntryBut";
            this.delEntryBut.Size = new System.Drawing.Size(23, 24);
            this.delEntryBut.Text = "Видалити входження";
            this.delEntryBut.Click += new System.EventHandler(this.delEntryBut_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // formReportButton
            // 
            this.formReportButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.formReportButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.formReportButton.Name = "formReportButton";
            this.formReportButton.Size = new System.Drawing.Size(128, 24);
            this.formReportButton.Text = "Сформувати звіт";
            this.formReportButton.Click += new System.EventHandler(this.formReportButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1109, 693);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnMaintanceRecord);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1127, 740);
            this.MinimumSize = new System.Drawing.Size(1127, 740);
            this.Name = "FMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Облік транспортного парку";
            this.Load += new System.EventHandler(this.FMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

        private System.Windows.Forms.ToolStripButton formReportButton;

        private System.Windows.Forms.ToolStripButton editEntry;

        private System.Windows.Forms.ToolStripButton delEntryBut;

        private System.Windows.Forms.ToolStripButton newEntryButton;
        private System.Windows.Forms.ToolStripButton loadEntryButton;
        private System.Windows.Forms.ToolStripButton saveEntryButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.DataGridView dataGridView;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTransport;
        private System.Windows.Forms.Button btnMaintanceRecord;
        private System.Windows.Forms.Button btnDrivers;

        #endregion
    }
}
