using System.Drawing;
using System.Windows.Forms;
using lab7;

namespace lab7
{
    partial class Form2
    {
        private Airport _airport;
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
            this.checkBoxIsOpen = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.numericCountFlight = new System.Windows.Forms.NumericUpDown();
            this.numericCountTicket = new System.Windows.Forms.NumericUpDown();
            this.numericYear = new System.Windows.Forms.NumericUpDown();
            this.numericArea = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericCountFlight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCountTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericArea)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Название:";
            // 
            // checkBoxIsOpen
            // 
            this.checkBoxIsOpen.AutoSize = true;
            this.checkBoxIsOpen.Location = new System.Drawing.Point(172, 129);
            this.checkBoxIsOpen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxIsOpen.Name = "checkBoxIsOpen";
            this.checkBoxIsOpen.Size = new System.Drawing.Size(18, 17);
            this.checkBoxIsOpen.TabIndex = 35;
            this.checkBoxIsOpen.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Число рейсев:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Количество билетов:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(172, 18);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(125, 22);
            this.textBoxName.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Площадь:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Открыто";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Город:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Год открытия:";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(172, 155);
            this.textBoxCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(125, 22);
            this.textBoxCity.TabIndex = 30;
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(172, 218);
            this.changeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(125, 23);
            this.changeButton.TabIndex = 28;
            this.changeButton.Text = "Изменить";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 218);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(125, 23);
            this.backButton.TabIndex = 36;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // numericCountFlight
            // 
            this.numericCountFlight.Location = new System.Drawing.Point(172, 44);
            this.numericCountFlight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericCountFlight.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericCountFlight.Name = "numericCountFlight";
            this.numericCountFlight.Size = new System.Drawing.Size(125, 22);
            this.numericCountFlight.TabIndex = 37;
            // 
            // numericCountTicket
            // 
            this.numericCountTicket.Location = new System.Drawing.Point(172, 73);
            this.numericCountTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericCountTicket.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericCountTicket.Name = "numericCountTicket";
            this.numericCountTicket.Size = new System.Drawing.Size(125, 22);
            this.numericCountTicket.TabIndex = 38;
            // 
            // numericYear
            // 
            this.numericYear.Location = new System.Drawing.Point(172, 186);
            this.numericYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericYear.Maximum = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            this.numericYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericYear.Name = "numericYear";
            this.numericYear.Size = new System.Drawing.Size(125, 22);
            this.numericYear.TabIndex = 39;
            this.numericYear.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // numericArea
            // 
            this.numericArea.Location = new System.Drawing.Point(172, 101);
            this.numericArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericArea.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericArea.Name = "numericArea";
            this.numericArea.Size = new System.Drawing.Size(125, 22);
            this.numericArea.TabIndex = 40;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 251);
            this.Controls.Add(this.numericArea);
            this.Controls.Add(this.numericYear);
            this.Controls.Add(this.numericCountTicket);
            this.Controls.Add(this.numericCountFlight);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxIsOpen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.changeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Измените аэропорт";
            ((System.ComponentModel.ISupportInitialize)(this.numericCountFlight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCountTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private CheckBox checkBoxIsOpen;
        private Label label2;
        private Label label3;
        private TextBox textBoxName;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBoxCity;
        private Button changeButton;
        private Button backButton;
        private NumericUpDown numericCountFlight;
        private NumericUpDown numericCountTicket;
        private NumericUpDown numericYear;
        private NumericUpDown numericArea;
    }
}