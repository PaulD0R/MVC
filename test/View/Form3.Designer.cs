namespace lab7
{
    partial class Form3
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
            this.buttonConsole = new System.Windows.Forms.Button();
            this.buttonForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonConsole
            // 
            this.buttonConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonConsole.Location = new System.Drawing.Point(101, 156);
            this.buttonConsole.Name = "buttonConsole";
            this.buttonConsole.Size = new System.Drawing.Size(228, 62);
            this.buttonConsole.TabIndex = 1;
            this.buttonConsole.Text = "Консоль";
            this.buttonConsole.UseVisualStyleBackColor = true;
            this.buttonConsole.Click += new System.EventHandler(this.buttonConsole_Click);
            // 
            // buttonForm
            // 
            this.buttonForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonForm.Location = new System.Drawing.Point(101, 64);
            this.buttonForm.Name = "buttonForm";
            this.buttonForm.Size = new System.Drawing.Size(228, 62);
            this.buttonForm.TabIndex = 2;
            this.buttonForm.Text = "Форма";
            this.buttonForm.UseVisualStyleBackColor = true;
            this.buttonForm.Click += new System.EventHandler(this.buttonForm_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(443, 276);
            this.Controls.Add(this.buttonForm);
            this.Controls.Add(this.buttonConsole);
            this.Name = "Form3";
            this.Text = "Start";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonConsole;
        private System.Windows.Forms.Button buttonForm;
    }
}