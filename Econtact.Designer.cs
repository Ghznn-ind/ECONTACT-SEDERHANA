namespace Econtact
{
    partial class Econtact
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Econtact));
            lblId = new Label();
            txtId = new TextBox();
            txtLname = new TextBox();
            lblLname = new Label();
            txtFname = new TextBox();
            lblFname = new Label();
            txtNo = new TextBox();
            lblNo = new Label();
            txtAddres = new TextBox();
            lblAddres = new Label();
            lblGender = new Label();
            cbGender = new ComboBox();
            txtSearch = new TextBox();
            lblSearch = new Label();
            dgvContact = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnClose = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvContact).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.Location = new Point(46, 152);
            lblId.Name = "lblId";
            lblId.Size = new Size(135, 32);
            lblId.TabIndex = 0;
            lblId.Text = "Contact ID";
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtId.Location = new Point(216, 148);
            txtId.Name = "txtId";
            txtId.Size = new Size(295, 39);
            txtId.TabIndex = 1;
            // 
            // txtLname
            // 
            txtLname.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtLname.Location = new Point(216, 284);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(295, 39);
            txtLname.TabIndex = 3;
            // 
            // lblLname
            // 
            lblLname.AutoSize = true;
            lblLname.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLname.Location = new Point(46, 288);
            lblLname.Name = "lblLname";
            lblLname.Size = new Size(133, 32);
            lblLname.TabIndex = 2;
            lblLname.Text = "Last Name";
            // 
            // txtFname
            // 
            txtFname.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFname.Location = new Point(216, 216);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(295, 39);
            txtFname.TabIndex = 7;
            // 
            // lblFname
            // 
            lblFname.AutoSize = true;
            lblFname.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFname.Location = new Point(46, 219);
            lblFname.Name = "lblFname";
            lblFname.Size = new Size(133, 32);
            lblFname.TabIndex = 6;
            lblFname.Text = "First name";
            // 
            // txtNo
            // 
            txtNo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNo.Location = new Point(216, 352);
            txtNo.Name = "txtNo";
            txtNo.Size = new Size(295, 39);
            txtNo.TabIndex = 9;
            // 
            // lblNo
            // 
            lblNo.AutoSize = true;
            lblNo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNo.Location = new Point(46, 352);
            lblNo.Name = "lblNo";
            lblNo.Size = new Size(143, 32);
            lblNo.TabIndex = 8;
            lblNo.Text = "Contact No";
            // 
            // txtAddres
            // 
            txtAddres.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAddres.Location = new Point(216, 422);
            txtAddres.Multiline = true;
            txtAddres.Name = "txtAddres";
            txtAddres.Size = new Size(295, 142);
            txtAddres.TabIndex = 11;
            // 
            // lblAddres
            // 
            lblAddres.AutoSize = true;
            lblAddres.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddres.Location = new Point(46, 422);
            lblAddres.Name = "lblAddres";
            lblAddres.Size = new Size(106, 32);
            lblAddres.TabIndex = 10;
            lblAddres.Text = "Address";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(46, 591);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(97, 32);
            lblGender.TabIndex = 12;
            lblGender.Text = "Gender";
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(216, 593);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(295, 33);
            cbGender.TabIndex = 14;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(721, 146);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(563, 39);
            txtSearch.TabIndex = 16;
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.KeyPress += txtSearch_KeyPress;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(617, 152);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(87, 32);
            lblSearch.TabIndex = 15;
            lblSearch.Text = "Search";
            // 
            // dgvContact
            // 
            dgvContact.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContact.Location = new Point(614, 216);
            dgvContact.Name = "dgvContact";
            dgvContact.RowHeadersWidth = 62;
            dgvContact.Size = new Size(670, 410);
            dgvContact.TabIndex = 17;
            dgvContact.CellClick += dgvContact_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.ForestGreen;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(46, 701);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(156, 47);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.RoyalBlue;
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(240, 701);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(156, 47);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Crimson;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(431, 701);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(156, 47);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Gold;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(617, 701);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(156, 47);
            btnClear.TabIndex = 21;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnClose
            // 
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(1224, 21);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(60, 54);
            btnClose.SizeMode = PictureBoxSizeMode.StretchImage;
            btnClose.TabIndex = 22;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(483, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(356, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // Econtact
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1319, 769);
            Controls.Add(pictureBox1);
            Controls.Add(btnClose);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvContact);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(cbGender);
            Controls.Add(lblGender);
            Controls.Add(txtAddres);
            Controls.Add(lblAddres);
            Controls.Add(txtNo);
            Controls.Add(lblNo);
            Controls.Add(txtFname);
            Controls.Add(lblFname);
            Controls.Add(txtLname);
            Controls.Add(lblLname);
            Controls.Add(txtId);
            Controls.Add(lblId);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Econtact";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Econtact";
            Load += Econtact_Load;
            ((System.ComponentModel.ISupportInitialize)dgvContact).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private TextBox txtId;
        private TextBox txtLname;
        private Label lblLname;
        private TextBox txtFname;
        private Label lblFname;
        private TextBox txtNo;
        private Label lblNo;
        private TextBox txtAddres;
        private Label lblAddres;
        private Label lblGender;
        private ComboBox cbGender;
        private TextBox txtSearch;
        private Label lblSearch;
        private DataGridView dgvContact;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private PictureBox btnClose;
        private PictureBox pictureBox1;
    }
}
