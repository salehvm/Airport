namespace Airport
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbCompany = new System.Windows.Forms.ComboBox();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbArrival = new System.Windows.Forms.RadioButton();
            this.rbDepar = new System.Windows.Forms.RadioButton();
            this.cbRunway = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbGate = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddflight = new System.Windows.Forms.Button();
            this.dgvAirportView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirportView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company";
            // 
            // cbCompany
            // 
            this.cbCompany.FormattingEnabled = true;
            this.cbCompany.Location = new System.Drawing.Point(12, 52);
            this.cbCompany.Name = "cbCompany";
            this.cbCompany.Size = new System.Drawing.Size(121, 21);
            this.cbCompany.TabIndex = 1;
            // 
            // cbCountry
            // 
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(12, 154);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(121, 21);
            this.cbCountry.TabIndex = 3;
            this.cbCountry.SelectedIndexChanged += new System.EventHandler(this.cbCountry_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Country";
            // 
            // cbCity
            // 
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Location = new System.Drawing.Point(12, 245);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(121, 21);
            this.cbCity.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "City";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(276, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Type";
            // 
            // rbArrival
            // 
            this.rbArrival.AutoSize = true;
            this.rbArrival.Location = new System.Drawing.Point(281, 52);
            this.rbArrival.Name = "rbArrival";
            this.rbArrival.Size = new System.Drawing.Size(54, 17);
            this.rbArrival.TabIndex = 7;
            this.rbArrival.TabStop = true;
            this.rbArrival.Text = "Arrival";
            this.rbArrival.UseVisualStyleBackColor = true;
            // 
            // rbDepar
            // 
            this.rbDepar.AutoSize = true;
            this.rbDepar.Location = new System.Drawing.Point(353, 52);
            this.rbDepar.Name = "rbDepar";
            this.rbDepar.Size = new System.Drawing.Size(72, 17);
            this.rbDepar.TabIndex = 8;
            this.rbDepar.TabStop = true;
            this.rbDepar.Text = "Departure";
            this.rbDepar.UseVisualStyleBackColor = true;
            // 
            // cbRunway
            // 
            this.cbRunway.FormattingEnabled = true;
            this.cbRunway.Location = new System.Drawing.Point(281, 256);
            this.cbRunway.Name = "cbRunway";
            this.cbRunway.Size = new System.Drawing.Size(121, 21);
            this.cbRunway.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(281, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 31);
            this.label5.TabIndex = 11;
            this.label5.Text = "Runway";
            // 
            // cbGate
            // 
            this.cbGate.FormattingEnabled = true;
            this.cbGate.Location = new System.Drawing.Point(281, 154);
            this.cbGate.Name = "cbGate";
            this.cbGate.Size = new System.Drawing.Size(121, 21);
            this.cbGate.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(281, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 31);
            this.label6.TabIndex = 9;
            this.label6.Text = "Gate";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(499, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 31);
            this.label7.TabIndex = 13;
            this.label7.Text = "Date";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpDate.Location = new System.Drawing.Point(504, 43);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 14;
            // 
            // btnAddflight
            // 
            this.btnAddflight.Location = new System.Drawing.Point(504, 142);
            this.btnAddflight.Name = "btnAddflight";
            this.btnAddflight.Size = new System.Drawing.Size(141, 42);
            this.btnAddflight.TabIndex = 15;
            this.btnAddflight.Text = "Add Flight";
            this.btnAddflight.UseVisualStyleBackColor = true;
            this.btnAddflight.Click += new System.EventHandler(this.btnAddflight_Click);
            // 
            // dgvAirportView
            // 
            this.dgvAirportView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAirportView.Location = new System.Drawing.Point(17, 302);
            this.dgvAirportView.Name = "dgvAirportView";
            this.dgvAirportView.Size = new System.Drawing.Size(987, 249);
            this.dgvAirportView.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 563);
            this.Controls.Add(this.dgvAirportView);
            this.Controls.Add(this.btnAddflight);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbRunway);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbGate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rbDepar);
            this.Controls.Add(this.rbArrival);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbCity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCompany);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirportView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCompany;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbArrival;
        private System.Windows.Forms.RadioButton rbDepar;
        private System.Windows.Forms.ComboBox cbRunway;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbGate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnAddflight;
        private System.Windows.Forms.DataGridView dgvAirportView;
    }
}

