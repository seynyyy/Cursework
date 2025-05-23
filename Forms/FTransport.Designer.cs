using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cursework.Forms
{
    partial class FTransport
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbRegistrationNumber = new System.Windows.Forms.TextBox();
            this.cbTransportType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMake = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbYearOfManufacture = new System.Windows.Forms.TextBox();
            this.tbMileage = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Реєстраційний номер";
            // 
            // tbRegistrationNumber
            // 
            this.tbRegistrationNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRegistrationNumber.Location = new System.Drawing.Point(300, 61);
            this.tbRegistrationNumber.Name = "tbRegistrationNumber";
            this.tbRegistrationNumber.Size = new System.Drawing.Size(269, 34);
            this.tbRegistrationNumber.TabIndex = 4;
            // 
            // cbTransportType
            // 
            this.cbTransportType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbTransportType.FormattingEnabled = true;
            this.cbTransportType.Items.AddRange(new object[] { "Автомобіль", "Вантажівка", "Мотоцикл" });
            this.cbTransportType.Location = new System.Drawing.Point(24, 12);
            this.cbTransportType.Name = "cbTransportType";
            this.cbTransportType.Size = new System.Drawing.Size(545, 37);
            this.cbTransportType.TabIndex = 7;
            this.cbTransportType.Text = "Тип транспорту";
            this.cbTransportType.SelectedIndexChanged +=
                new System.EventHandler(this.cbTransportType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(24, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 38);
            this.label2.TabIndex = 8;
            this.label2.Text = "Марка";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(24, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 38);
            this.label3.TabIndex = 9;
            this.label3.Text = "Модель";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(24, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 38);
            this.label4.TabIndex = 10;
            this.label4.Text = "Рік випуску";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(24, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(270, 38);
            this.label5.TabIndex = 11;
            this.label5.Text = "Пробіг";
            // 
            // tbMake
            // 
            this.tbMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMake.Location = new System.Drawing.Point(300, 103);
            this.tbMake.Name = "tbMake";
            this.tbMake.Size = new System.Drawing.Size(269, 34);
            this.tbMake.TabIndex = 12;
            // 
            // tbModel
            // 
            this.tbModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbModel.Location = new System.Drawing.Point(300, 143);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(269, 34);
            this.tbModel.TabIndex = 13;
            // 
            // tbYearOfManufacture
            // 
            this.tbYearOfManufacture.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbYearOfManufacture.Location = new System.Drawing.Point(300, 183);
            this.tbYearOfManufacture.Name = "tbYearOfManufacture";
            this.tbYearOfManufacture.Size = new System.Drawing.Size(269, 34);
            this.tbYearOfManufacture.TabIndex = 14;
            // 
            // tbMileage
            // 
            this.tbMileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMileage.Location = new System.Drawing.Point(300, 226);
            this.tbMileage.Name = "tbMileage";
            this.tbMileage.Size = new System.Drawing.Size(269, 34);
            this.tbMileage.TabIndex = 15;
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(24, 264);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(270, 68);
            this.label.TabIndex = 16;
            this.label.Text = "К-сть пасажирів/\r\nвантажопідйомність";
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox.Location = new System.Drawing.Point(300, 280);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(269, 34);
            this.textBox.TabIndex = 17;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(237, 335);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 40);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Зберегти";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FTransport
            // 
            this.ClientSize = new System.Drawing.Size(581, 387);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label);
            this.Controls.Add(this.tbMileage);
            this.Controls.Add(this.tbYearOfManufacture);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.tbMake);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTransportType);
            this.Controls.Add(this.tbRegistrationNumber);
            this.Controls.Add(this.label1);
            this.Name = "FTransport";
            this.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FTransport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

            // TextBox styling
            foreach (System.Windows.Forms.Control control in this.Controls)
            {
                if (control is System.Windows.Forms.TextBox textBox)
                {
                    textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    textBox.Font = new System.Drawing.Font("Segoe UI", 10F);
                    textBox.BackColor = System.Drawing.Color.White;
                }
                else if (control is System.Windows.Forms.Label label)
                {
                    label.Font = new System.Drawing.Font("Segoe UI", 10F);
                    label.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
                }
                else if (control is System.Windows.Forms.ComboBox comboBox)
                {
                    comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    comboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
                }
            }
            
            // Button styling
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(51, 102, 153);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRegistrationNumber;
        private System.Windows.Forms.ComboBox cbTransportType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMake;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbYearOfManufacture;
        private System.Windows.Forms.TextBox tbMileage;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button btnSave;
    }
}
