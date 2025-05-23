using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cursework.Forms
{
    partial class FDriver
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbExperiance = new System.Windows.Forms.TextBox();
            this.cbTransport = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.rbLicenceA = new System.Windows.Forms.RadioButton();
            this.rbLicenceB = new System.Windows.Forms.RadioButton();
            this.rbLicenceC = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = _primaryColor;
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ім\'я";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = _primaryColor;
            this.label2.Location = new System.Drawing.Point(18, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Прізвище";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = _primaryColor;
            this.label3.Location = new System.Drawing.Point(18, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Досвід";
            // 
            // tbName
            // 
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.BackColor = System.Drawing.Color.White;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.Location = new System.Drawing.Point(188, 27);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(193, 34);
            this.tbName.TabIndex = 3;
            // 
            // tbSurname
            // 
            this.tbSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSurname.BackColor = System.Drawing.Color.White;
            this.tbSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSurname.Location = new System.Drawing.Point(188, 67);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(193, 34);
            this.tbSurname.TabIndex = 4;
            // 
            // tbExperiance
            // 
            this.tbExperiance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbExperiance.BackColor = System.Drawing.Color.White;
            this.tbExperiance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbExperiance.Location = new System.Drawing.Point(188, 107);
            this.tbExperiance.Name = "tbExperiance";
            this.tbExperiance.Size = new System.Drawing.Size(193, 34);
            this.tbExperiance.TabIndex = 5;
            // 
            // cbTransport
            // 
            this.cbTransport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTransport.BackColor = System.Drawing.Color.White;
            this.cbTransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbTransport.FormattingEnabled = true;
            this.cbTransport.Items.AddRange(new object[] { "A", "B", "C" });
            this.cbTransport.Location = new System.Drawing.Point(188, 185);
            this.cbTransport.Name = "cbTransport";
            this.cbTransport.Size = new System.Drawing.Size(193, 37);
            this.cbTransport.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = _primaryColor;
            this.label4.Location = new System.Drawing.Point(18, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 38);
            this.label4.TabIndex = 7;
            this.label4.Text = "Посвідчення";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.BackColor = _accentColor;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(140, 276);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 45);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Зберегти";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = _primaryColor;
            this.label5.Location = new System.Drawing.Point(18, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 38);
            this.label5.TabIndex = 9;
            this.label5.Text = "Транспорт";
            // 
            // rbLicenceA
            // 
            this.rbLicenceA.Location = new System.Drawing.Point(188, 152);
            this.rbLicenceA.Name = "rbLicenceA";
            this.rbLicenceA.Size = new System.Drawing.Size(38, 24);
            this.rbLicenceA.TabIndex = 10;
            this.rbLicenceA.TabStop = true;
            this.rbLicenceA.Text = "A";
            this.rbLicenceA.UseVisualStyleBackColor = true;
            // 
            // rbLicenceB
            // 
            this.rbLicenceB.Location = new System.Drawing.Point(232, 152);
            this.rbLicenceB.Name = "rbLicenceB";
            this.rbLicenceB.Size = new System.Drawing.Size(38, 24);
            this.rbLicenceB.TabIndex = 11;
            this.rbLicenceB.TabStop = true;
            this.rbLicenceB.Text = "B";
            this.rbLicenceB.UseVisualStyleBackColor = true;
            // 
            // rbLicenceC
            // 
            this.rbLicenceC.Location = new System.Drawing.Point(276, 152);
            this.rbLicenceC.Name = "rbLicenceC";
            this.rbLicenceC.Size = new System.Drawing.Size(38, 24);
            this.rbLicenceC.TabIndex = 12;
            this.rbLicenceC.TabStop = true;
            this.rbLicenceC.Text = "C";
            this.rbLicenceC.UseVisualStyleBackColor = true;
            // 
            // FDriver
            // 
            this.ClientSize = new System.Drawing.Size(415, 328);
            this.Controls.Add(this.rbLicenceC);
            this.Controls.Add(this.rbLicenceB);
            this.Controls.Add(this.rbLicenceA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbTransport);
            this.Controls.Add(this.tbExperiance);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FDriver";
            this.ResumeLayout(false);
            this.PerformLayout();

            // Form styling
            this.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            
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
                else if (control is System.Windows.Forms.RadioButton radio)
                {
                    radio.Font = new System.Drawing.Font("Segoe UI", 10F);
                    radio.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbExperiance;
        private System.Windows.Forms.ComboBox cbTransport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbLicenceA;
        private System.Windows.Forms.RadioButton rbLicenceB;
        private System.Windows.Forms.RadioButton rbLicenceC;
    }
}
