namespace DB_lab_Project
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_show = new System.Windows.Forms.Button();
            this.btn_CLO = new System.Windows.Forms.Button();
            this.btn_std_reg = new System.Windows.Forms.Button();
            this.pnl_std_reg = new System.Windows.Forms.Panel();
            this.pnl_std_info = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.dGv_student_data = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet = new DB_lab_Project.ProjectBDataSet();
            this.pnl_clo_rubric = new System.Windows.Forms.Panel();
            this.btn_clo_update = new System.Windows.Forms.Button();
            this.btn_clo_delete = new System.Windows.Forms.Button();
            this.btn_rub_Update = new System.Windows.Forms.Button();
            this.btn_rub_del = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dGv_Clo = new System.Windows.Forms.DataGridView();
            this.cloBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.btn_add_rubric = new System.Windows.Forms.Button();
            this.cmb_clo_select = new System.Windows.Forms.ComboBox();
            this.cloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_addclo = new System.Windows.Forms.Button();
            this.txt_rubric_detail = new System.Windows.Forms.TextBox();
            this.txt_clo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.rubricBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_register = new System.Windows.Forms.Button();
            this.txt_reg_no = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_contact = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.txt_firstname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_std_info = new System.Windows.Forms.Button();
            this.cloTableAdapter = new DB_lab_Project.ProjectBDataSetTableAdapters.CloTableAdapter();
            this.studentTableAdapter = new DB_lab_Project.ProjectBDataSetTableAdapters.StudentTableAdapter();
            this.cloBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rubricTableAdapter = new DB_lab_Project.ProjectBDataSetTableAdapters.RubricTableAdapter();
            this.Idd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateUpdatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iddd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cloIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnl_std_reg.SuspendLayout();
            this.pnl_std_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGv_student_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).BeginInit();
            this.pnl_clo_rubric.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGv_Clo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1046, 44);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "DBMS PROJECT";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_show);
            this.panel2.Controls.Add(this.btn_CLO);
            this.panel2.Controls.Add(this.btn_std_reg);
            this.panel2.Location = new System.Drawing.Point(1, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(158, 582);
            this.panel2.TabIndex = 1;
            // 
            // btn_show
            // 
            this.btn_show.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show.Location = new System.Drawing.Point(0, 214);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(158, 49);
            this.btn_show.TabIndex = 5;
            this.btn_show.Text = "Reports";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // btn_CLO
            // 
            this.btn_CLO.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CLO.Location = new System.Drawing.Point(0, 126);
            this.btn_CLO.Name = "btn_CLO";
            this.btn_CLO.Size = new System.Drawing.Size(158, 49);
            this.btn_CLO.TabIndex = 4;
            this.btn_CLO.Text = "CLO/Rubrics";
            this.btn_CLO.UseVisualStyleBackColor = true;
            this.btn_CLO.Click += new System.EventHandler(this.btn_CLO_Click);
            // 
            // btn_std_reg
            // 
            this.btn_std_reg.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_std_reg.Location = new System.Drawing.Point(0, 48);
            this.btn_std_reg.Name = "btn_std_reg";
            this.btn_std_reg.Size = new System.Drawing.Size(158, 49);
            this.btn_std_reg.TabIndex = 0;
            this.btn_std_reg.Text = "Student Registeration";
            this.btn_std_reg.UseVisualStyleBackColor = true;
            this.btn_std_reg.Click += new System.EventHandler(this.btn_std_reg_Click);
            // 
            // pnl_std_reg
            // 
            this.pnl_std_reg.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnl_std_reg.Controls.Add(this.pnl_std_info);
            this.pnl_std_reg.Controls.Add(this.pnl_clo_rubric);
            this.pnl_std_reg.Controls.Add(this.btn_register);
            this.pnl_std_reg.Controls.Add(this.txt_reg_no);
            this.pnl_std_reg.Controls.Add(this.txt_email);
            this.pnl_std_reg.Controls.Add(this.txt_contact);
            this.pnl_std_reg.Controls.Add(this.label5);
            this.pnl_std_reg.Controls.Add(this.label4);
            this.pnl_std_reg.Controls.Add(this.label3);
            this.pnl_std_reg.Controls.Add(this.txt_lastname);
            this.pnl_std_reg.Controls.Add(this.txt_firstname);
            this.pnl_std_reg.Controls.Add(this.label2);
            this.pnl_std_reg.Controls.Add(this.btn_std_info);
            this.pnl_std_reg.Location = new System.Drawing.Point(165, 92);
            this.pnl_std_reg.Name = "pnl_std_reg";
            this.pnl_std_reg.Size = new System.Drawing.Size(847, 522);
            this.pnl_std_reg.TabIndex = 2;
            this.pnl_std_reg.Visible = false;
            // 
            // pnl_std_info
            // 
            this.pnl_std_info.Controls.Add(this.btn_delete);
            this.pnl_std_info.Controls.Add(this.btn_edit);
            this.pnl_std_info.Controls.Add(this.dGv_student_data);
            this.pnl_std_info.Location = new System.Drawing.Point(0, 0);
            this.pnl_std_info.Name = "pnl_std_info";
            this.pnl_std_info.Size = new System.Drawing.Size(844, 522);
            this.pnl_std_info.TabIndex = 17;
            this.pnl_std_info.Visible = false;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(583, 87);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(115, 23);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(717, 87);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(115, 23);
            this.btn_edit.TabIndex = 1;
            this.btn_edit.Text = "Edit\r\n";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // dGv_student_data
            // 
            this.dGv_student_data.AutoGenerateColumns = false;
            this.dGv_student_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGv_student_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.registrationNumberDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dGv_student_data.DataSource = this.studentBindingSource;
            this.dGv_student_data.Location = new System.Drawing.Point(3, 125);
            this.dGv_student_data.Name = "dGv_student_data";
            this.dGv_student_data.Size = new System.Drawing.Size(829, 347);
            this.dGv_student_data.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "Contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "Contact";
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // registrationNumberDataGridViewTextBoxColumn
            // 
            this.registrationNumberDataGridViewTextBoxColumn.DataPropertyName = "RegistrationNumber";
            this.registrationNumberDataGridViewTextBoxColumn.HeaderText = "RegistrationNumber";
            this.registrationNumberDataGridViewTextBoxColumn.Name = "registrationNumberDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.projectBDataSet;
            // 
            // projectBDataSet
            // 
            this.projectBDataSet.DataSetName = "ProjectBDataSet";
            this.projectBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnl_clo_rubric
            // 
            this.pnl_clo_rubric.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnl_clo_rubric.Controls.Add(this.btn_clo_update);
            this.pnl_clo_rubric.Controls.Add(this.btn_clo_delete);
            this.pnl_clo_rubric.Controls.Add(this.btn_rub_Update);
            this.pnl_clo_rubric.Controls.Add(this.btn_rub_del);
            this.pnl_clo_rubric.Controls.Add(this.label6);
            this.pnl_clo_rubric.Controls.Add(this.label10);
            this.pnl_clo_rubric.Controls.Add(this.dGv_Clo);
            this.pnl_clo_rubric.Controls.Add(this.btn_add_rubric);
            this.pnl_clo_rubric.Controls.Add(this.cmb_clo_select);
            this.pnl_clo_rubric.Controls.Add(this.btn_addclo);
            this.pnl_clo_rubric.Controls.Add(this.txt_rubric_detail);
            this.pnl_clo_rubric.Controls.Add(this.txt_clo);
            this.pnl_clo_rubric.Controls.Add(this.label7);
            this.pnl_clo_rubric.Controls.Add(this.label8);
            this.pnl_clo_rubric.Controls.Add(this.label9);
            this.pnl_clo_rubric.Controls.Add(this.dataGridView3);
            this.pnl_clo_rubric.Location = new System.Drawing.Point(0, 0);
            this.pnl_clo_rubric.Name = "pnl_clo_rubric";
            this.pnl_clo_rubric.Size = new System.Drawing.Size(847, 522);
            this.pnl_clo_rubric.TabIndex = 10;
            this.pnl_clo_rubric.Visible = false;
            // 
            // btn_clo_update
            // 
            this.btn_clo_update.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btn_clo_update.Location = new System.Drawing.Point(268, 389);
            this.btn_clo_update.Name = "btn_clo_update";
            this.btn_clo_update.Size = new System.Drawing.Size(103, 27);
            this.btn_clo_update.TabIndex = 21;
            this.btn_clo_update.Text = "Update";
            this.btn_clo_update.UseVisualStyleBackColor = true;
            this.btn_clo_update.Click += new System.EventHandler(this.btn_clo_update_Click);
            // 
            // btn_clo_delete
            // 
            this.btn_clo_delete.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btn_clo_delete.Location = new System.Drawing.Point(159, 389);
            this.btn_clo_delete.Name = "btn_clo_delete";
            this.btn_clo_delete.Size = new System.Drawing.Size(103, 27);
            this.btn_clo_delete.TabIndex = 20;
            this.btn_clo_delete.Text = "Delete";
            this.btn_clo_delete.UseVisualStyleBackColor = true;
            this.btn_clo_delete.Click += new System.EventHandler(this.btn_clo_delete_Click);
            // 
            // btn_rub_Update
            // 
            this.btn_rub_Update.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btn_rub_Update.Location = new System.Drawing.Point(619, 389);
            this.btn_rub_Update.Name = "btn_rub_Update";
            this.btn_rub_Update.Size = new System.Drawing.Size(99, 27);
            this.btn_rub_Update.TabIndex = 19;
            this.btn_rub_Update.Text = "Update";
            this.btn_rub_Update.UseVisualStyleBackColor = true;
            this.btn_rub_Update.Click += new System.EventHandler(this.btn_rub_Update_Click);
            // 
            // btn_rub_del
            // 
            this.btn_rub_del.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btn_rub_del.Location = new System.Drawing.Point(519, 389);
            this.btn_rub_del.Name = "btn_rub_del";
            this.btn_rub_del.Size = new System.Drawing.Size(94, 27);
            this.btn_rub_del.TabIndex = 18;
            this.btn_rub_del.Text = "Delete";
            this.btn_rub_del.UseVisualStyleBackColor = true;
            this.btn_rub_del.Click += new System.EventHandler(this.btn_rub_del_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(467, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Rubric Table";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(22, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "CLO TABLE\r\n";
            // 
            // dGv_Clo
            // 
            this.dGv_Clo.AutoGenerateColumns = false;
            this.dGv_Clo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGv_Clo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Idd,
            this.nameDataGridViewTextBoxColumn,
            this.dateCreatedDataGridViewTextBoxColumn,
            this.dateUpdatedDataGridViewTextBoxColumn});
            this.dGv_Clo.DataSource = this.cloBindingSource2;
            this.dGv_Clo.Location = new System.Drawing.Point(26, 233);
            this.dGv_Clo.Name = "dGv_Clo";
            this.dGv_Clo.Size = new System.Drawing.Size(345, 150);
            this.dGv_Clo.TabIndex = 14;
            // 
            // cloBindingSource2
            // 
            this.cloBindingSource2.DataMember = "Clo";
            this.cloBindingSource2.DataSource = this.projectBDataSet;
            // 
            // btn_add_rubric
            // 
            this.btn_add_rubric.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btn_add_rubric.Location = new System.Drawing.Point(486, 116);
            this.btn_add_rubric.Name = "btn_add_rubric";
            this.btn_add_rubric.Size = new System.Drawing.Size(135, 27);
            this.btn_add_rubric.TabIndex = 13;
            this.btn_add_rubric.Text = "Add Rubric";
            this.btn_add_rubric.UseVisualStyleBackColor = true;
            this.btn_add_rubric.Click += new System.EventHandler(this.btn_add_rubric_Click);
            // 
            // cmb_clo_select
            // 
            this.cmb_clo_select.DataSource = this.cloBindingSource;
            this.cmb_clo_select.DisplayMember = "Name";
            this.cmb_clo_select.FormattingEnabled = true;
            this.cmb_clo_select.Location = new System.Drawing.Point(154, 66);
            this.cmb_clo_select.Name = "cmb_clo_select";
            this.cmb_clo_select.Size = new System.Drawing.Size(151, 21);
            this.cmb_clo_select.TabIndex = 11;
            // 
            // cloBindingSource
            // 
            this.cloBindingSource.DataMember = "Clo";
            this.cloBindingSource.DataSource = this.projectBDataSet;
            // 
            // btn_addclo
            // 
            this.btn_addclo.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btn_addclo.Location = new System.Drawing.Point(486, 29);
            this.btn_addclo.Name = "btn_addclo";
            this.btn_addclo.Size = new System.Drawing.Size(135, 27);
            this.btn_addclo.TabIndex = 10;
            this.btn_addclo.Text = "Add CLO";
            this.btn_addclo.UseVisualStyleBackColor = true;
            this.btn_addclo.Click += new System.EventHandler(this.btn_addclo_Click);
            // 
            // txt_rubric_detail
            // 
            this.txt_rubric_detail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_rubric_detail.Location = new System.Drawing.Point(154, 99);
            this.txt_rubric_detail.Multiline = true;
            this.txt_rubric_detail.Name = "txt_rubric_detail";
            this.txt_rubric_detail.Size = new System.Drawing.Size(263, 43);
            this.txt_rubric_detail.TabIndex = 8;
            // 
            // txt_clo
            // 
            this.txt_clo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_clo.Location = new System.Drawing.Point(154, 29);
            this.txt_clo.Name = "txt_clo";
            this.txt_clo.Size = new System.Drawing.Size(151, 26);
            this.txt_clo.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(22, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Select CLO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(22, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Rubric Detail";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(22, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "CLO";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Iddd,
            this.cloIdDataGridViewTextBoxColumn,
            this.detailsDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.rubricBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(471, 233);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(245, 150);
            this.dataGridView3.TabIndex = 16;
            // 
            // rubricBindingSource
            // 
            this.rubricBindingSource.DataMember = "Rubric";
            this.rubricBindingSource.DataSource = this.projectBDataSet;
            // 
            // btn_register
            // 
            this.btn_register.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btn_register.Location = new System.Drawing.Point(595, 337);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(161, 42);
            this.btn_register.TabIndex = 15;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click_1);
            // 
            // txt_reg_no
            // 
            this.txt_reg_no.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_reg_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_reg_no.Location = new System.Drawing.Point(280, 236);
            this.txt_reg_no.Name = "txt_reg_no";
            this.txt_reg_no.Size = new System.Drawing.Size(151, 26);
            this.txt_reg_no.TabIndex = 9;
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_email.Location = new System.Drawing.Point(280, 166);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(151, 26);
            this.txt_email.TabIndex = 8;
            // 
            // txt_contact
            // 
            this.txt_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_contact.Location = new System.Drawing.Point(280, 96);
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(151, 26);
            this.txt_contact.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(22, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Registration Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(22, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(22, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contact";
            // 
            // txt_lastname
            // 
            this.txt_lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_lastname.Location = new System.Drawing.Point(595, 32);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(151, 26);
            this.txt_lastname.TabIndex = 3;
            this.txt_lastname.Text = "Last\r\n";
            // 
            // txt_firstname
            // 
            this.txt_firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_firstname.Location = new System.Drawing.Point(280, 32);
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.Size = new System.Drawing.Size(151, 26);
            this.txt_firstname.TabIndex = 2;
            this.txt_firstname.Text = "First\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(22, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // btn_std_info
            // 
            this.btn_std_info.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btn_std_info.Location = new System.Drawing.Point(292, 337);
            this.btn_std_info.Name = "btn_std_info";
            this.btn_std_info.Size = new System.Drawing.Size(161, 42);
            this.btn_std_info.TabIndex = 16;
            this.btn_std_info.Text = "Student Info\r\n";
            this.btn_std_info.UseVisualStyleBackColor = true;
            this.btn_std_info.Click += new System.EventHandler(this.btn_std_info_Click);
            // 
            // cloTableAdapter
            // 
            this.cloTableAdapter.ClearBeforeFill = true;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // cloBindingSource1
            // 
            this.cloBindingSource1.DataMember = "Clo";
            this.cloBindingSource1.DataSource = this.projectBDataSet;
            // 
            // rubricTableAdapter
            // 
            this.rubricTableAdapter.ClearBeforeFill = true;
            // 
            // Idd
            // 
            this.Idd.DataPropertyName = "Id";
            this.Idd.HeaderText = "Id";
            this.Idd.Name = "Idd";
            this.Idd.ReadOnly = true;
            this.Idd.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // dateCreatedDataGridViewTextBoxColumn
            // 
            this.dateCreatedDataGridViewTextBoxColumn.DataPropertyName = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.HeaderText = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.Name = "dateCreatedDataGridViewTextBoxColumn";
            // 
            // dateUpdatedDataGridViewTextBoxColumn
            // 
            this.dateUpdatedDataGridViewTextBoxColumn.DataPropertyName = "DateUpdated";
            this.dateUpdatedDataGridViewTextBoxColumn.HeaderText = "DateUpdated";
            this.dateUpdatedDataGridViewTextBoxColumn.Name = "dateUpdatedDataGridViewTextBoxColumn";
            // 
            // Iddd
            // 
            this.Iddd.DataPropertyName = "Id";
            this.Iddd.HeaderText = "id";
            this.Iddd.Name = "Iddd";
            this.Iddd.ReadOnly = true;
            this.Iddd.Visible = false;
            // 
            // detailsDataGridViewTextBoxColumn
            // 
            this.detailsDataGridViewTextBoxColumn.DataPropertyName = "Details";
            this.detailsDataGridViewTextBoxColumn.HeaderText = "Details";
            this.detailsDataGridViewTextBoxColumn.Name = "detailsDataGridViewTextBoxColumn";
            // 
            // cloIdDataGridViewTextBoxColumn
            // 
            this.cloIdDataGridViewTextBoxColumn.DataPropertyName = "CloId";
            this.cloIdDataGridViewTextBoxColumn.HeaderText = "CloId";
            this.cloIdDataGridViewTextBoxColumn.Name = "cloIdDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1048, 626);
            this.Controls.Add(this.pnl_std_reg);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Welcome_form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnl_std_reg.ResumeLayout(false);
            this.pnl_std_reg.PerformLayout();
            this.pnl_std_info.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGv_student_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).EndInit();
            this.pnl_clo_rubric.ResumeLayout(false);
            this.pnl_clo_rubric.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGv_Clo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnl_std_reg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_std_reg;
        private System.Windows.Forms.Button btn_CLO;
        private System.Windows.Forms.TextBox txt_lastname;
        private System.Windows.Forms.TextBox txt_firstname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_reg_no;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_contact;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private ProjectBDataSet projectBDataSet;
        private System.Windows.Forms.BindingSource cloBindingSource;
        private ProjectBDataSetTableAdapters.CloTableAdapter cloTableAdapter;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private ProjectBDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.BindingSource cloBindingSource1;
        private System.Windows.Forms.BindingSource rubricBindingSource;
        private ProjectBDataSetTableAdapters.RubricTableAdapter rubricTableAdapter;
        private System.Windows.Forms.BindingSource cloBindingSource2;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Panel pnl_std_info;
        private System.Windows.Forms.DataGridView dGv_student_data;
        private System.Windows.Forms.Button btn_std_info;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel pnl_clo_rubric;
        private System.Windows.Forms.Button btn_clo_update;
        private System.Windows.Forms.Button btn_clo_delete;
        private System.Windows.Forms.Button btn_rub_Update;
        private System.Windows.Forms.Button btn_rub_del;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dGv_Clo;
        private System.Windows.Forms.Button btn_add_rubric;
        private System.Windows.Forms.ComboBox cmb_clo_select;
        private System.Windows.Forms.Button btn_addclo;
        private System.Windows.Forms.TextBox txt_rubric_detail;
        private System.Windows.Forms.TextBox txt_clo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idd;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateUpdatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iddd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cloIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailsDataGridViewTextBoxColumn;
    }
}

