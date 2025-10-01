namespace HotelBooking
{
    partial class AllCustomers
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.PictureBox pictureBox5;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllCustomers));
            this.linkLabelHome = new System.Windows.Forms.LinkLabel();
            this.linkLabelTandC = new System.Windows.Forms.LinkLabel();
            this.linkLabelAboutUs = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewAllCustomers = new System.Windows.Forms.DataGridView();
            this.custNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custPhNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBtable1DataSet = new HotelBooking.DBtable1DataSet();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.tableTableAdapter = new HotelBooking.DBtable1DataSetTableAdapters.TableTableAdapter();
            pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBtable1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            pictureBox5.Location = new System.Drawing.Point(377, 410);
            pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new System.Drawing.Size(29, 30);
            pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 41;
            pictureBox5.TabStop = false;
            // 
            // linkLabelHome
            // 
            this.linkLabelHome.AutoSize = true;
            this.linkLabelHome.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabelHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelHome.LinkColor = System.Drawing.Color.White;
            this.linkLabelHome.Location = new System.Drawing.Point(394, 9);
            this.linkLabelHome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelHome.Name = "linkLabelHome";
            this.linkLabelHome.Size = new System.Drawing.Size(49, 18);
            this.linkLabelHome.TabIndex = 1;
            this.linkLabelHome.TabStop = true;
            this.linkLabelHome.Text = "Home";
            this.linkLabelHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelHome_LinkClicked);
            // 
            // linkLabelTandC
            // 
            this.linkLabelTandC.AutoSize = true;
            this.linkLabelTandC.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabelTandC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelTandC.LinkColor = System.Drawing.Color.White;
            this.linkLabelTandC.Location = new System.Drawing.Point(483, 9);
            this.linkLabelTandC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelTandC.Name = "linkLabelTandC";
            this.linkLabelTandC.Size = new System.Drawing.Size(154, 18);
            this.linkLabelTandC.TabIndex = 11;
            this.linkLabelTandC.TabStop = true;
            this.linkLabelTandC.Text = "Terms and Conditions";
            this.linkLabelTandC.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelTandC_LinkClicked);
            // 
            // linkLabelAboutUs
            // 
            this.linkLabelAboutUs.AutoSize = true;
            this.linkLabelAboutUs.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabelAboutUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelAboutUs.LinkColor = System.Drawing.Color.White;
            this.linkLabelAboutUs.Location = new System.Drawing.Point(661, 9);
            this.linkLabelAboutUs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelAboutUs.Name = "linkLabelAboutUs";
            this.linkLabelAboutUs.Size = new System.Drawing.Size(69, 18);
            this.linkLabelAboutUs.TabIndex = 12;
            this.linkLabelAboutUs.TabStop = true;
            this.linkLabelAboutUs.Text = "About Us";
            this.linkLabelAboutUs.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAboutUs_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.White;
            this.linkLabel2.Location = new System.Drawing.Point(752, 9);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(83, 18);
            this.linkLabel2.TabIndex = 13;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Contact Us";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(885, 52);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewAllCustomers
            // 
            this.dataGridViewAllCustomers.AutoGenerateColumns = false;
            this.dataGridViewAllCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.custNameDataGridViewTextBoxColumn,
            this.custPhNoDataGridViewTextBoxColumn,
            this.custEmailDataGridViewTextBoxColumn,
            this.custIDDataGridViewTextBoxColumn});
            this.dataGridViewAllCustomers.DataSource = this.tableBindingSource;
            this.dataGridViewAllCustomers.Location = new System.Drawing.Point(186, 104);
            this.dataGridViewAllCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewAllCustomers.Name = "dataGridViewAllCustomers";
            this.dataGridViewAllCustomers.RowHeadersWidth = 51;
            this.dataGridViewAllCustomers.Size = new System.Drawing.Size(544, 268);
            this.dataGridViewAllCustomers.TabIndex = 19;
            this.dataGridViewAllCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAllCustomers_CellContentClick);
            // 
            // custNameDataGridViewTextBoxColumn
            // 
            this.custNameDataGridViewTextBoxColumn.DataPropertyName = "CustName";
            this.custNameDataGridViewTextBoxColumn.HeaderText = "CustName";
            this.custNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.custNameDataGridViewTextBoxColumn.Name = "custNameDataGridViewTextBoxColumn";
            this.custNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // custPhNoDataGridViewTextBoxColumn
            // 
            this.custPhNoDataGridViewTextBoxColumn.DataPropertyName = "CustPhNo";
            this.custPhNoDataGridViewTextBoxColumn.HeaderText = "CustPhNo";
            this.custPhNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.custPhNoDataGridViewTextBoxColumn.Name = "custPhNoDataGridViewTextBoxColumn";
            this.custPhNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // custEmailDataGridViewTextBoxColumn
            // 
            this.custEmailDataGridViewTextBoxColumn.DataPropertyName = "CustEmail";
            this.custEmailDataGridViewTextBoxColumn.HeaderText = "CustEmail";
            this.custEmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.custEmailDataGridViewTextBoxColumn.Name = "custEmailDataGridViewTextBoxColumn";
            this.custEmailDataGridViewTextBoxColumn.Width = 125;
            // 
            // custIDDataGridViewTextBoxColumn
            // 
            this.custIDDataGridViewTextBoxColumn.DataPropertyName = "CustID";
            this.custIDDataGridViewTextBoxColumn.HeaderText = "CustID";
            this.custIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.custIDDataGridViewTextBoxColumn.Name = "custIDDataGridViewTextBoxColumn";
            this.custIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.dBtable1DataSet;
            // 
            // dBtable1DataSet
            // 
            this.dBtable1DataSet.DataSetName = "DBtable1DataSet";
            this.dBtable1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(853, -2);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(29, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 38;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(885, 462);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 39;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Image = global::HotelBooking.Properties.Resources.linkedin;
            this.pictureBox2.Location = new System.Drawing.Point(485, 410);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox6.Image = global::HotelBooking.Properties.Resources.x;
            this.pictureBox6.Location = new System.Drawing.Point(428, 410);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(29, 30);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 43;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox7.Location = new System.Drawing.Point(-1, 402);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(885, 57);
            this.pictureBox7.TabIndex = 40;
            this.pictureBox7.TabStop = false;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // AllCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 453);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.dataGridViewAllCustomers);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabelAboutUs);
            this.Controls.Add(this.linkLabelTandC);
            this.Controls.Add(this.linkLabelHome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AllCustomers";
            this.Text = "Hotel Booking";
            this.Load += new System.EventHandler(this.AllCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBtable1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabelHome;
        private System.Windows.Forms.LinkLabel linkLabelTandC;
        private System.Windows.Forms.LinkLabel linkLabelAboutUs;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.DataGridView dataGridViewAllCustomers;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private DBtable1DataSet dBtable1DataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private DBtable1DataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn custNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custPhNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custIDDataGridViewTextBoxColumn;
    }
}

