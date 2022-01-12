namespace Tech_Pro_Lab_1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fromCelsius = new System.Windows.Forms.RadioButton();
            this.fromFahrenheit = new System.Windows.Forms.RadioButton();
            this.fromKalvin = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.convertFromTextfield = new System.Windows.Forms.TextBox();
            this.convertToTextfield = new System.Windows.Forms.TextBox();
            this.convertFrom = new System.Windows.Forms.GroupBox();
            this.convertTo = new System.Windows.Forms.GroupBox();
            this.toCelsius = new System.Windows.Forms.RadioButton();
            this.toFahrenheit = new System.Windows.Forms.RadioButton();
            this.toKalvin = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.convertFrom.SuspendLayout();
            this.convertTo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(748, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperature Calculator";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "Convert ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fromCelsius
            // 
            this.fromCelsius.AutoSize = true;
            this.fromCelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromCelsius.Location = new System.Drawing.Point(39, 14);
            this.fromCelsius.Name = "fromCelsius";
            this.fromCelsius.Size = new System.Drawing.Size(129, 36);
            this.fromCelsius.TabIndex = 2;
            this.fromCelsius.TabStop = true;
            this.fromCelsius.Text = "Celsius";
            this.fromCelsius.UseVisualStyleBackColor = true;
            this.fromCelsius.CheckedChanged += new System.EventHandler(this.fromCelsius_CheckedChanged);
            // 
            // fromFahrenheit
            // 
            this.fromFahrenheit.AutoSize = true;
            this.fromFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromFahrenheit.Location = new System.Drawing.Point(39, 60);
            this.fromFahrenheit.Name = "fromFahrenheit";
            this.fromFahrenheit.Size = new System.Drawing.Size(172, 36);
            this.fromFahrenheit.TabIndex = 3;
            this.fromFahrenheit.TabStop = true;
            this.fromFahrenheit.Text = "Fahrenheit";
            this.fromFahrenheit.UseVisualStyleBackColor = true;
            this.fromFahrenheit.CheckedChanged += new System.EventHandler(this.fromFahrenheit_CheckedChanged);
            // 
            // fromKalvin
            // 
            this.fromKalvin.AutoSize = true;
            this.fromKalvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromKalvin.Location = new System.Drawing.Point(39, 102);
            this.fromKalvin.Name = "fromKalvin";
            this.fromKalvin.Size = new System.Drawing.Size(114, 36);
            this.fromKalvin.TabIndex = 4;
            this.fromKalvin.TabStop = true;
            this.fromKalvin.Text = "Kalvin";
            this.fromKalvin.UseVisualStyleBackColor = true;
            this.fromKalvin.CheckedChanged += new System.EventHandler(this.fromKalvin_CheckedChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(418, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 50);
            this.label3.TabIndex = 5;
            this.label3.Text = "To";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // convertFromTextfield
            // 
            this.convertFromTextfield.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.convertFromTextfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertFromTextfield.Location = new System.Drawing.Point(46, 352);
            this.convertFromTextfield.Name = "convertFromTextfield";
            this.convertFromTextfield.Size = new System.Drawing.Size(257, 30);
            this.convertFromTextfield.TabIndex = 9;
            // 
            // convertToTextfield
            // 
            this.convertToTextfield.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.convertToTextfield.Enabled = false;
            this.convertToTextfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertToTextfield.Location = new System.Drawing.Point(418, 352);
            this.convertToTextfield.Name = "convertToTextfield";
            this.convertToTextfield.Size = new System.Drawing.Size(257, 30);
            this.convertToTextfield.TabIndex = 10;
            // 
            // convertFrom
            // 
            this.convertFrom.BackColor = System.Drawing.SystemColors.ControlDark;
            this.convertFrom.Controls.Add(this.fromCelsius);
            this.convertFrom.Controls.Add(this.fromFahrenheit);
            this.convertFrom.Controls.Add(this.fromKalvin);
            this.convertFrom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.convertFrom.Location = new System.Drawing.Point(46, 178);
            this.convertFrom.Name = "convertFrom";
            this.convertFrom.Size = new System.Drawing.Size(257, 168);
            this.convertFrom.TabIndex = 11;
            this.convertFrom.TabStop = false;
            // 
            // convertTo
            // 
            this.convertTo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.convertTo.Controls.Add(this.toCelsius);
            this.convertTo.Controls.Add(this.toFahrenheit);
            this.convertTo.Controls.Add(this.toKalvin);
            this.convertTo.Location = new System.Drawing.Point(418, 178);
            this.convertTo.Name = "convertTo";
            this.convertTo.Size = new System.Drawing.Size(257, 168);
            this.convertTo.TabIndex = 12;
            this.convertTo.TabStop = false;
            // 
            // toCelsius
            // 
            this.toCelsius.AutoSize = true;
            this.toCelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toCelsius.Location = new System.Drawing.Point(39, 14);
            this.toCelsius.Name = "toCelsius";
            this.toCelsius.Size = new System.Drawing.Size(129, 36);
            this.toCelsius.TabIndex = 2;
            this.toCelsius.TabStop = true;
            this.toCelsius.Text = "Celsius";
            this.toCelsius.UseVisualStyleBackColor = true;
            this.toCelsius.CheckedChanged += new System.EventHandler(this.toCelsius_CheckedChanged);
            // 
            // toFahrenheit
            // 
            this.toFahrenheit.AutoSize = true;
            this.toFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toFahrenheit.Location = new System.Drawing.Point(39, 61);
            this.toFahrenheit.Name = "toFahrenheit";
            this.toFahrenheit.Size = new System.Drawing.Size(172, 36);
            this.toFahrenheit.TabIndex = 3;
            this.toFahrenheit.TabStop = true;
            this.toFahrenheit.Text = "Fahrenheit";
            this.toFahrenheit.UseVisualStyleBackColor = true;
            this.toFahrenheit.CheckedChanged += new System.EventHandler(this.toFahrenheit_CheckedChanged);
            // 
            // toKalvin
            // 
            this.toKalvin.AutoSize = true;
            this.toKalvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toKalvin.Location = new System.Drawing.Point(39, 100);
            this.toKalvin.Name = "toKalvin";
            this.toKalvin.Size = new System.Drawing.Size(114, 36);
            this.toKalvin.TabIndex = 4;
            this.toKalvin.TabStop = true;
            this.toKalvin.Text = "Kalvin";
            this.toKalvin.UseVisualStyleBackColor = true;
            this.toKalvin.CheckedChanged += new System.EventHandler(this.toKalvin_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(46, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "Reset All";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.Color.Brown;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.Location = new System.Drawing.Point(320, 410);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(460, 32);
            this.errorLabel.TabIndex = 14;
            this.errorLabel.Text = "Enter a Valid Input ! Hit Reset All";
            this.errorLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(862, 493);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.convertTo);
            this.Controls.Add(this.convertFrom);
            this.Controls.Add(this.convertToTextfield);
            this.Controls.Add(this.convertFromTextfield);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Temperature Calculator";
            this.convertFrom.ResumeLayout(false);
            this.convertFrom.PerformLayout();
            this.convertTo.ResumeLayout(false);
            this.convertTo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton fromCelsius;
        private System.Windows.Forms.RadioButton fromFahrenheit;
        private System.Windows.Forms.RadioButton fromKalvin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox convertFromTextfield;
        private System.Windows.Forms.TextBox convertToTextfield;
        private System.Windows.Forms.GroupBox convertFrom;
        private System.Windows.Forms.GroupBox convertTo;
        private System.Windows.Forms.RadioButton toCelsius;
        private System.Windows.Forms.RadioButton toFahrenheit;
        private System.Windows.Forms.RadioButton toKalvin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label errorLabel;
    }
}

