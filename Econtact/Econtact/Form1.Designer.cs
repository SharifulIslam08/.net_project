namespace Econtact
{
    partial class Econtact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Econtact));
            this.econtactid = new System.Windows.Forms.Label();
            this.textBoxContactID = new System.Windows.Forms.TextBox();
            this.pictureBoxlogo = new System.Windows.Forms.PictureBox();
            this.textBoxlastname = new System.Windows.Forms.TextBox();
            this.elastname = new System.Windows.Forms.Label();
            this.textBoxfirstname = new System.Windows.Forms.TextBox();
            this.efirstname = new System.Windows.Forms.Label();
            this.textBoxcontactNO = new System.Windows.Forms.TextBox();
            this.econtactno = new System.Windows.Forms.Label();
            this.egender = new System.Windows.Forms.Label();
            this.eaddress = new System.Windows.Forms.Label();
            this.textBoxaddress = new System.Windows.Forms.TextBox();
            this.comboBoxgender = new System.Windows.Forms.ComboBox();
            this.edelete = new System.Windows.Forms.Button();
            this.eupdate = new System.Windows.Forms.Button();
            this.eclear = new System.Windows.Forms.Button();
            this.eadd = new System.Windows.Forms.Button();
            this.dataGridViewresultboard = new System.Windows.Forms.DataGridView();
            this.esearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.pictureBoxexit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxlogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewresultboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxexit)).BeginInit();
            this.SuspendLayout();
            // 
            // econtactid
            // 
            this.econtactid.AutoSize = true;
            this.econtactid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.econtactid.Location = new System.Drawing.Point(85, 90);
            this.econtactid.Margin = new System.Windows.Forms.Padding(0);
            this.econtactid.Name = "econtactid";
            this.econtactid.Size = new System.Drawing.Size(86, 20);
            this.econtactid.TabIndex = 0;
            this.econtactid.Text = "Contact ID";
            this.econtactid.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxContactID
            // 
            this.textBoxContactID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContactID.Location = new System.Drawing.Point(209, 87);
            this.textBoxContactID.Name = "textBoxContactID";
            this.textBoxContactID.Size = new System.Drawing.Size(210, 26);
            this.textBoxContactID.TabIndex = 1;
            // 
            // pictureBoxlogo
            // 
            this.pictureBoxlogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxlogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxlogo.Image")));
            this.pictureBoxlogo.Location = new System.Drawing.Point(356, 12);
            this.pictureBoxlogo.Name = "pictureBoxlogo";
            this.pictureBoxlogo.Size = new System.Drawing.Size(181, 54);
            this.pictureBoxlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxlogo.TabIndex = 2;
            this.pictureBoxlogo.TabStop = false;
            // 
            // textBoxlastname
            // 
            this.textBoxlastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxlastname.Location = new System.Drawing.Point(209, 176);
            this.textBoxlastname.Name = "textBoxlastname";
            this.textBoxlastname.Size = new System.Drawing.Size(210, 26);
            this.textBoxlastname.TabIndex = 4;
            // 
            // elastname
            // 
            this.elastname.AutoSize = true;
            this.elastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elastname.Location = new System.Drawing.Point(85, 179);
            this.elastname.Margin = new System.Windows.Forms.Padding(0);
            this.elastname.Name = "elastname";
            this.elastname.Size = new System.Drawing.Size(86, 20);
            this.elastname.TabIndex = 3;
            this.elastname.Text = "Last Name";
            // 
            // textBoxfirstname
            // 
            this.textBoxfirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxfirstname.Location = new System.Drawing.Point(209, 129);
            this.textBoxfirstname.Name = "textBoxfirstname";
            this.textBoxfirstname.Size = new System.Drawing.Size(210, 26);
            this.textBoxfirstname.TabIndex = 6;
            // 
            // efirstname
            // 
            this.efirstname.AutoSize = true;
            this.efirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efirstname.Location = new System.Drawing.Point(85, 132);
            this.efirstname.Margin = new System.Windows.Forms.Padding(0);
            this.efirstname.Name = "efirstname";
            this.efirstname.Size = new System.Drawing.Size(86, 20);
            this.efirstname.TabIndex = 5;
            this.efirstname.Text = "First Name";
            // 
            // textBoxcontactNO
            // 
            this.textBoxcontactNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxcontactNO.Location = new System.Drawing.Point(209, 223);
            this.textBoxcontactNO.Name = "textBoxcontactNO";
            this.textBoxcontactNO.Size = new System.Drawing.Size(210, 26);
            this.textBoxcontactNO.TabIndex = 8;
            // 
            // econtactno
            // 
            this.econtactno.AutoSize = true;
            this.econtactno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.econtactno.Location = new System.Drawing.Point(85, 226);
            this.econtactno.Margin = new System.Windows.Forms.Padding(0);
            this.econtactno.Name = "econtactno";
            this.econtactno.Size = new System.Drawing.Size(93, 20);
            this.econtactno.TabIndex = 7;
            this.econtactno.Text = "Contact No.";
            // 
            // egender
            // 
            this.egender.AutoSize = true;
            this.egender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.egender.Location = new System.Drawing.Point(85, 446);
            this.egender.Margin = new System.Windows.Forms.Padding(0);
            this.egender.Name = "egender";
            this.egender.Size = new System.Drawing.Size(63, 20);
            this.egender.TabIndex = 9;
            this.egender.Text = "Gender";
            // 
            // eaddress
            // 
            this.eaddress.AutoSize = true;
            this.eaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eaddress.Location = new System.Drawing.Point(85, 283);
            this.eaddress.Margin = new System.Windows.Forms.Padding(0);
            this.eaddress.Name = "eaddress";
            this.eaddress.Size = new System.Drawing.Size(68, 20);
            this.eaddress.TabIndex = 11;
            this.eaddress.Text = "Address";
            // 
            // textBoxaddress
            // 
            this.textBoxaddress.Location = new System.Drawing.Point(209, 285);
            this.textBoxaddress.Multiline = true;
            this.textBoxaddress.Name = "textBoxaddress";
            this.textBoxaddress.Size = new System.Drawing.Size(210, 136);
            this.textBoxaddress.TabIndex = 12;
            // 
            // comboBoxgender
            // 
            this.comboBoxgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxgender.FormattingEnabled = true;
            this.comboBoxgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxgender.Location = new System.Drawing.Point(209, 446);
            this.comboBoxgender.Name = "comboBoxgender";
            this.comboBoxgender.Size = new System.Drawing.Size(210, 28);
            this.comboBoxgender.TabIndex = 17;
            // 
            // edelete
            // 
            this.edelete.BackColor = System.Drawing.Color.Red;
            this.edelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edelete.Location = new System.Drawing.Point(341, 504);
            this.edelete.Name = "edelete";
            this.edelete.Size = new System.Drawing.Size(101, 40);
            this.edelete.TabIndex = 25;
            this.edelete.Text = "DELETE";
            this.edelete.UseVisualStyleBackColor = false;
            // 
            // eupdate
            // 
            this.eupdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.eupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eupdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.eupdate.Location = new System.Drawing.Point(492, 504);
            this.eupdate.Name = "eupdate";
            this.eupdate.Size = new System.Drawing.Size(101, 40);
            this.eupdate.TabIndex = 24;
            this.eupdate.Text = "UPDATE";
            this.eupdate.UseVisualStyleBackColor = false;
            // 
            // eclear
            // 
            this.eclear.BackColor = System.Drawing.Color.Yellow;
            this.eclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eclear.ForeColor = System.Drawing.SystemColors.Desktop;
            this.eclear.Location = new System.Drawing.Point(651, 504);
            this.eclear.Name = "eclear";
            this.eclear.Size = new System.Drawing.Size(101, 40);
            this.eclear.TabIndex = 23;
            this.eclear.Text = "CLEAR";
            this.eclear.UseVisualStyleBackColor = false;
            // 
            // eadd
            // 
            this.eadd.BackColor = System.Drawing.Color.ForestGreen;
            this.eadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eadd.Location = new System.Drawing.Point(190, 504);
            this.eadd.Name = "eadd";
            this.eadd.Size = new System.Drawing.Size(101, 40);
            this.eadd.TabIndex = 22;
            this.eadd.Text = "ADD";
            this.eadd.UseVisualStyleBackColor = false;
            this.eadd.Click += new System.EventHandler(this.eadd_Click);
            // 
            // dataGridViewresultboard
            // 
            this.dataGridViewresultboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewresultboard.Location = new System.Drawing.Point(465, 132);
            this.dataGridViewresultboard.Name = "dataGridViewresultboard";
            this.dataGridViewresultboard.Size = new System.Drawing.Size(432, 342);
            this.dataGridViewresultboard.TabIndex = 26;
            this.dataGridViewresultboard.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewresultboard_CellContentClick);
            // 
            // esearch
            // 
            this.esearch.AutoSize = true;
            this.esearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.esearch.Location = new System.Drawing.Point(477, 87);
            this.esearch.Margin = new System.Windows.Forms.Padding(0);
            this.esearch.Name = "esearch";
            this.esearch.Size = new System.Drawing.Size(60, 20);
            this.esearch.TabIndex = 27;
            this.esearch.Text = "Search";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(556, 84);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(341, 26);
            this.textBoxSearch.TabIndex = 28;
            // 
            // pictureBoxexit
            // 
            this.pictureBoxexit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxexit.Image")));
            this.pictureBoxexit.Location = new System.Drawing.Point(842, 12);
            this.pictureBoxexit.Name = "pictureBoxexit";
            this.pictureBoxexit.Size = new System.Drawing.Size(55, 50);
            this.pictureBoxexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxexit.TabIndex = 29;
            this.pictureBoxexit.TabStop = false;
            this.pictureBoxexit.Click += new System.EventHandler(this.pictureBoxexit_Click);
            // 
            // Econtact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 565);
            this.Controls.Add(this.pictureBoxexit);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.esearch);
            this.Controls.Add(this.dataGridViewresultboard);
            this.Controls.Add(this.edelete);
            this.Controls.Add(this.eupdate);
            this.Controls.Add(this.eclear);
            this.Controls.Add(this.eadd);
            this.Controls.Add(this.comboBoxgender);
            this.Controls.Add(this.textBoxaddress);
            this.Controls.Add(this.eaddress);
            this.Controls.Add(this.egender);
            this.Controls.Add(this.textBoxcontactNO);
            this.Controls.Add(this.econtactno);
            this.Controls.Add(this.textBoxfirstname);
            this.Controls.Add(this.efirstname);
            this.Controls.Add(this.textBoxlastname);
            this.Controls.Add(this.elastname);
            this.Controls.Add(this.pictureBoxlogo);
            this.Controls.Add(this.textBoxContactID);
            this.Controls.Add(this.econtactid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Econtact";
            this.Text = "Econtact";
            this.Load += new System.EventHandler(this.Econtact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxlogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewresultboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxexit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label econtactid;
        private System.Windows.Forms.TextBox textBoxContactID;
        private System.Windows.Forms.PictureBox pictureBoxlogo;
        private System.Windows.Forms.TextBox textBoxlastname;
        private System.Windows.Forms.Label elastname;
        private System.Windows.Forms.TextBox textBoxfirstname;
        private System.Windows.Forms.Label efirstname;
        private System.Windows.Forms.TextBox textBoxcontactNO;
        private System.Windows.Forms.Label econtactno;
        private System.Windows.Forms.Label egender;
        private System.Windows.Forms.Label eaddress;
        private System.Windows.Forms.TextBox textBoxaddress;
        private System.Windows.Forms.ComboBox comboBoxgender;
        private System.Windows.Forms.Button edelete;
        private System.Windows.Forms.Button eupdate;
        private System.Windows.Forms.Button eclear;
        private System.Windows.Forms.Button eadd;
        private System.Windows.Forms.DataGridView dataGridViewresultboard;
        private System.Windows.Forms.Label esearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.PictureBox pictureBoxexit;
    }
}

