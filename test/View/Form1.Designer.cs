using System.Drawing;
using System.Windows.Forms;
using test;

namespace lab5
{
    partial class Form1
    {
        private AirportList _airportList { get; set; }
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Create = new System.Windows.Forms.Button();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.checkBoxIsOpen = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericYear = new System.Windows.Forms.NumericUpDown();
            this.numericCountFlight = new System.Windows.Forms.NumericUpDown();
            this.numericCountTicket = new System.Windows.Forms.NumericUpDown();
            this.numericArea = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.findNameTextbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.findButton = new System.Windows.Forms.Button();
            this.airoportsTable = new System.Windows.Forms.DataGridView();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberFlightsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountTicketsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCountFlight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCountTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericArea)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.airoportsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Число рейсев";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Количество билетов";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Площадь";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Открыто";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Город";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Год открытия";
            // 
            // Create
            // 
            this.Create.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Create.Location = new System.Drawing.Point(3, 232);
            this.Create.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(295, 23);
            this.Create.TabIndex = 7;
            this.Create.Text = "Создать";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.create_Click);
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(166, 166);
            this.textBoxCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(125, 22);
            this.textBoxCity.TabIndex = 9;
            this.textBoxCity.Tag = "info";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(166, 23);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(125, 22);
            this.textBoxName.TabIndex = 14;
            this.textBoxName.Tag = "info";
            // 
            // buttonExit
            // 
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonExit.Location = new System.Drawing.Point(1418, 393);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(94, 23);
            this.buttonExit.TabIndex = 19;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // checkBoxIsOpen
            // 
            this.checkBoxIsOpen.AutoSize = true;
            this.checkBoxIsOpen.Location = new System.Drawing.Point(166, 143);
            this.checkBoxIsOpen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxIsOpen.Name = "checkBoxIsOpen";
            this.checkBoxIsOpen.Size = new System.Drawing.Size(18, 17);
            this.checkBoxIsOpen.TabIndex = 20;
            this.checkBoxIsOpen.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.numericYear);
            this.groupBox1.Controls.Add(this.numericCountFlight);
            this.groupBox1.Controls.Add(this.numericCountTicket);
            this.groupBox1.Controls.Add(this.numericArea);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkBoxIsOpen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxCity);
            this.groupBox1.Controls.Add(this.Create);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(301, 257);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Создать";
            // 
            // numericYear
            // 
            this.numericYear.Location = new System.Drawing.Point(166, 196);
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
            this.numericYear.TabIndex = 24;
            this.numericYear.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // numericCountFlight
            // 
            this.numericCountFlight.Location = new System.Drawing.Point(166, 53);
            this.numericCountFlight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericCountFlight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericCountFlight.Name = "numericCountFlight";
            this.numericCountFlight.Size = new System.Drawing.Size(125, 22);
            this.numericCountFlight.TabIndex = 23;
            // 
            // numericCountTicket
            // 
            this.numericCountTicket.Location = new System.Drawing.Point(166, 83);
            this.numericCountTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericCountTicket.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericCountTicket.Name = "numericCountTicket";
            this.numericCountTicket.Size = new System.Drawing.Size(125, 22);
            this.numericCountTicket.TabIndex = 22;
            // 
            // numericArea
            // 
            this.numericArea.Location = new System.Drawing.Point(166, 113);
            this.numericArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericArea.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericArea.Name = "numericArea";
            this.numericArea.Size = new System.Drawing.Size(125, 22);
            this.numericArea.TabIndex = 21;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox2.Controls.Add(this.deleteButton);
            this.groupBox2.Controls.Add(this.findNameTextbox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.findButton);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(12, 281);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(301, 93);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Найти ";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(6, 58);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(135, 23);
            this.deleteButton.TabIndex = 24;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // findNameTextbox
            // 
            this.findNameTextbox.Location = new System.Drawing.Point(92, 26);
            this.findNameTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.findNameTextbox.Name = "findNameTextbox";
            this.findNameTextbox.Size = new System.Drawing.Size(125, 22);
            this.findNameTextbox.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Название:";
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(160, 58);
            this.findButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(135, 23);
            this.findButton.TabIndex = 23;
            this.findButton.Text = "Инфо.";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // airoportsTable
            // 
            this.airoportsTable.AllowUserToAddRows = false;
            this.airoportsTable.AllowUserToResizeColumns = false;
            this.airoportsTable.AllowUserToResizeRows = false;
            this.airoportsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.airoportsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumn,
            this.NumberFlightsColumn,
            this.CountTicketsColumn,
            this.areaColumn,
            this.openColumn,
            this.cityColumn,
            this.yearColumn});
            this.airoportsTable.Location = new System.Drawing.Point(334, 10);
            this.airoportsTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.airoportsTable.Name = "airoportsTable";
            this.airoportsTable.RowHeadersVisible = false;
            this.airoportsTable.RowHeadersWidth = 51;
            this.airoportsTable.Size = new System.Drawing.Size(1072, 364);
            this.airoportsTable.TabIndex = 23;
            this.airoportsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.airoportsTable_CellContentClick);
            this.airoportsTable.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.airoportsTable_CellEndEdit);
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Название";
            this.nameColumn.MinimumWidth = 6;
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            this.nameColumn.Width = 125;
            // 
            // NumberFlightsColumn
            // 
            this.NumberFlightsColumn.HeaderText = "Число рейсев";
            this.NumberFlightsColumn.MaxInputLength = 8;
            this.NumberFlightsColumn.MinimumWidth = 6;
            this.NumberFlightsColumn.Name = "NumberFlightsColumn";
            this.NumberFlightsColumn.Width = 125;
            // 
            // CountTicketsColumn
            // 
            this.CountTicketsColumn.HeaderText = "Число билетов";
            this.CountTicketsColumn.MaxInputLength = 8;
            this.CountTicketsColumn.MinimumWidth = 6;
            this.CountTicketsColumn.Name = "CountTicketsColumn";
            this.CountTicketsColumn.Width = 125;
            // 
            // areaColumn
            // 
            this.areaColumn.HeaderText = "Площадь";
            this.areaColumn.MaxInputLength = 8;
            this.areaColumn.MinimumWidth = 6;
            this.areaColumn.Name = "areaColumn";
            this.areaColumn.Width = 125;
            // 
            // openColumn
            // 
            this.openColumn.HeaderText = "Открыто";
            this.openColumn.MinimumWidth = 6;
            this.openColumn.Name = "openColumn";
            this.openColumn.Width = 125;
            // 
            // cityColumn
            // 
            this.cityColumn.HeaderText = "Город";
            this.cityColumn.MaxInputLength = 8;
            this.cityColumn.MinimumWidth = 6;
            this.cityColumn.Name = "cityColumn";
            this.cityColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cityColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cityColumn.Width = 125;
            // 
            // yearColumn
            // 
            this.yearColumn.HeaderText = "Год открытия";
            this.yearColumn.MaxInputLength = 4;
            this.yearColumn.MinimumWidth = 6;
            this.yearColumn.Name = "yearColumn";
            this.yearColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 388);
            this.Controls.Add(this.airoportsTable);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonExit);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "23ВП2 Дорофейчук Е. Дорофейчук П.";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCountFlight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCountTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericArea)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.airoportsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button Create;
        private TextBox textBoxCity;
        private TextBox textBoxName;
        private Button buttonExit;
        private CheckBox checkBoxIsOpen;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label8;
        private Button findButton;
        private TextBox findNameTextbox;
        private DataGridView airoportsTable;
        private Button deleteButton;
        private NumericUpDown numericYear;
        private NumericUpDown numericCountFlight;
        private NumericUpDown numericCountTicket;
        private NumericUpDown numericArea;
        private DataGridViewTextBoxColumn nameColumn;
        private DataGridViewTextBoxColumn NumberFlightsColumn;
        private DataGridViewTextBoxColumn CountTicketsColumn;
        private DataGridViewTextBoxColumn areaColumn;
        private DataGridViewCheckBoxColumn openColumn;
        private DataGridViewTextBoxColumn cityColumn;
        private DataGridViewTextBoxColumn yearColumn;
    }
}


