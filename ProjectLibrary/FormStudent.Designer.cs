namespace ProjectLibrary
{
    partial class FormStudent
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBookBorrowing = new System.Windows.Forms.Label();
            this.lblBorrowerStudentId = new System.Windows.Forms.Label();
            this.lblBorrowerStudentName = new System.Windows.Forms.Label();
            this.lblStudentBorrowerYearLevel = new System.Windows.Forms.Label();
            this.lblStudentBorrowerSection = new System.Windows.Forms.Label();
            this.lblStudentBorrowerPhoneNumber = new System.Windows.Forms.Label();
            this.lblStudentBorrowerEmail = new System.Windows.Forms.Label();
            this.txtBorrowerId = new System.Windows.Forms.TextBox();
            this.txtBorrowerName = new System.Windows.Forms.TextBox();
            this.txtboYearLevel = new System.Windows.Forms.TextBox();
            this.txtSection = new System.Windows.Forms.TextBox();
            this.txtPhoneNmber = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnStudentBorrowerSave = new System.Windows.Forms.Button();
            this.btnStudentBorrowerAdd = new System.Windows.Forms.Button();
            this.btnStudentBorrowerUpdate = new System.Windows.Forms.Button();
            this.btnStudentBorrowerDelete = new System.Windows.Forms.Button();
            this.grStudentBorrower = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grTeacherBorrower = new System.Windows.Forms.GroupBox();
            this.lblTeacherBorrowerId = new System.Windows.Forms.Label();
            this.lblTeacherBorrowerName = new System.Windows.Forms.Label();
            this.lblTeacherborrowerDepartment = new System.Windows.Forms.Label();
            this.lblTeacherBorrowerPhoneNumber = new System.Windows.Forms.Label();
            this.lblTeacherBorrowerEmail = new System.Windows.Forms.Label();
            this.txtTeacherBorrowerId = new System.Windows.Forms.TextBox();
            this.txtTeacherBorrowerName = new System.Windows.Forms.TextBox();
            this.txtTeacherBorrowerDepartment = new System.Windows.Forms.TextBox();
            this.txtTeacherBorrowerPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtTeacherBorrowerEmail = new System.Windows.Forms.TextBox();
            this.btnTeacherBorrowerSave = new System.Windows.Forms.Button();
            this.btnTeacherBorrowerAdd = new System.Windows.Forms.Button();
            this.btnTeacherBorrowerUpdate = new System.Windows.Forms.Button();
            this.btnTeacherBorrowerDelete = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.grStudentBorrower.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grTeacherBorrower.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.lblBookBorrowing);
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 62);
            this.panel2.TabIndex = 0;
            // 
            // lblBookBorrowing
            // 
            this.lblBookBorrowing.AutoSize = true;
            this.lblBookBorrowing.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookBorrowing.Location = new System.Drawing.Point(228, 10);
            this.lblBookBorrowing.Name = "lblBookBorrowing";
            this.lblBookBorrowing.Size = new System.Drawing.Size(360, 50);
            this.lblBookBorrowing.TabIndex = 0;
            this.lblBookBorrowing.Text = "Book Borrowing";
            // 
            // lblBorrowerStudentId
            // 
            this.lblBorrowerStudentId.AutoSize = true;
            this.lblBorrowerStudentId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowerStudentId.Location = new System.Drawing.Point(29, 42);
            this.lblBorrowerStudentId.Name = "lblBorrowerStudentId";
            this.lblBorrowerStudentId.Size = new System.Drawing.Size(67, 14);
            this.lblBorrowerStudentId.TabIndex = 1;
            this.lblBorrowerStudentId.Text = "Student Id";
            // 
            // lblBorrowerStudentName
            // 
            this.lblBorrowerStudentName.AutoSize = true;
            this.lblBorrowerStudentName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowerStudentName.Location = new System.Drawing.Point(29, 78);
            this.lblBorrowerStudentName.Name = "lblBorrowerStudentName";
            this.lblBorrowerStudentName.Size = new System.Drawing.Size(89, 14);
            this.lblBorrowerStudentName.TabIndex = 2;
            this.lblBorrowerStudentName.Text = "Student Name";
            // 
            // lblStudentBorrowerYearLevel
            // 
            this.lblStudentBorrowerYearLevel.AutoSize = true;
            this.lblStudentBorrowerYearLevel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentBorrowerYearLevel.Location = new System.Drawing.Point(29, 116);
            this.lblStudentBorrowerYearLevel.Name = "lblStudentBorrowerYearLevel";
            this.lblStudentBorrowerYearLevel.Size = new System.Drawing.Size(68, 14);
            this.lblStudentBorrowerYearLevel.TabIndex = 3;
            this.lblStudentBorrowerYearLevel.Text = "Year Level";
            // 
            // lblStudentBorrowerSection
            // 
            this.lblStudentBorrowerSection.AutoSize = true;
            this.lblStudentBorrowerSection.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentBorrowerSection.Location = new System.Drawing.Point(29, 154);
            this.lblStudentBorrowerSection.Name = "lblStudentBorrowerSection";
            this.lblStudentBorrowerSection.Size = new System.Drawing.Size(50, 14);
            this.lblStudentBorrowerSection.TabIndex = 4;
            this.lblStudentBorrowerSection.Text = "Section";
            // 
            // lblStudentBorrowerPhoneNumber
            // 
            this.lblStudentBorrowerPhoneNumber.AutoSize = true;
            this.lblStudentBorrowerPhoneNumber.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentBorrowerPhoneNumber.Location = new System.Drawing.Point(29, 186);
            this.lblStudentBorrowerPhoneNumber.Name = "lblStudentBorrowerPhoneNumber";
            this.lblStudentBorrowerPhoneNumber.Size = new System.Drawing.Size(93, 14);
            this.lblStudentBorrowerPhoneNumber.TabIndex = 5;
            this.lblStudentBorrowerPhoneNumber.Text = "Phone Number";
            // 
            // lblStudentBorrowerEmail
            // 
            this.lblStudentBorrowerEmail.AutoSize = true;
            this.lblStudentBorrowerEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentBorrowerEmail.Location = new System.Drawing.Point(29, 222);
            this.lblStudentBorrowerEmail.Name = "lblStudentBorrowerEmail";
            this.lblStudentBorrowerEmail.Size = new System.Drawing.Size(39, 14);
            this.lblStudentBorrowerEmail.TabIndex = 6;
            this.lblStudentBorrowerEmail.Text = "Email";
            // 
            // txtBorrowerId
            // 
            this.txtBorrowerId.Location = new System.Drawing.Point(159, 39);
            this.txtBorrowerId.Name = "txtBorrowerId";
            this.txtBorrowerId.Size = new System.Drawing.Size(100, 20);
            this.txtBorrowerId.TabIndex = 7;
            // 
            // txtBorrowerName
            // 
            this.txtBorrowerName.Location = new System.Drawing.Point(159, 71);
            this.txtBorrowerName.Name = "txtBorrowerName";
            this.txtBorrowerName.Size = new System.Drawing.Size(100, 20);
            this.txtBorrowerName.TabIndex = 8;
            // 
            // txtboYearLevel
            // 
            this.txtboYearLevel.Location = new System.Drawing.Point(159, 109);
            this.txtboYearLevel.Name = "txtboYearLevel";
            this.txtboYearLevel.Size = new System.Drawing.Size(100, 20);
            this.txtboYearLevel.TabIndex = 9;
            // 
            // txtSection
            // 
            this.txtSection.Location = new System.Drawing.Point(159, 147);
            this.txtSection.Name = "txtSection";
            this.txtSection.Size = new System.Drawing.Size(100, 20);
            this.txtSection.TabIndex = 10;
            // 
            // txtPhoneNmber
            // 
            this.txtPhoneNmber.Location = new System.Drawing.Point(159, 183);
            this.txtPhoneNmber.Name = "txtPhoneNmber";
            this.txtPhoneNmber.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNmber.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(159, 215);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 12;
            // 
            // btnStudentBorrowerSave
            // 
            this.btnStudentBorrowerSave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentBorrowerSave.Location = new System.Drawing.Point(12, 271);
            this.btnStudentBorrowerSave.Name = "btnStudentBorrowerSave";
            this.btnStudentBorrowerSave.Size = new System.Drawing.Size(75, 32);
            this.btnStudentBorrowerSave.TabIndex = 13;
            this.btnStudentBorrowerSave.Text = "Save";
            this.btnStudentBorrowerSave.UseVisualStyleBackColor = true;
            // 
            // btnStudentBorrowerAdd
            // 
            this.btnStudentBorrowerAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentBorrowerAdd.Location = new System.Drawing.Point(93, 271);
            this.btnStudentBorrowerAdd.Name = "btnStudentBorrowerAdd";
            this.btnStudentBorrowerAdd.Size = new System.Drawing.Size(75, 32);
            this.btnStudentBorrowerAdd.TabIndex = 14;
            this.btnStudentBorrowerAdd.Text = "Add";
            this.btnStudentBorrowerAdd.UseVisualStyleBackColor = true;
            // 
            // btnStudentBorrowerUpdate
            // 
            this.btnStudentBorrowerUpdate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentBorrowerUpdate.Location = new System.Drawing.Point(174, 271);
            this.btnStudentBorrowerUpdate.Name = "btnStudentBorrowerUpdate";
            this.btnStudentBorrowerUpdate.Size = new System.Drawing.Size(75, 32);
            this.btnStudentBorrowerUpdate.TabIndex = 15;
            this.btnStudentBorrowerUpdate.Text = "Update";
            this.btnStudentBorrowerUpdate.UseVisualStyleBackColor = true;
            // 
            // btnStudentBorrowerDelete
            // 
            this.btnStudentBorrowerDelete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentBorrowerDelete.Location = new System.Drawing.Point(255, 271);
            this.btnStudentBorrowerDelete.Name = "btnStudentBorrowerDelete";
            this.btnStudentBorrowerDelete.Size = new System.Drawing.Size(75, 32);
            this.btnStudentBorrowerDelete.TabIndex = 16;
            this.btnStudentBorrowerDelete.Text = "Delete";
            this.btnStudentBorrowerDelete.UseVisualStyleBackColor = true;
            // 
            // grStudentBorrower
            // 
            this.grStudentBorrower.BackColor = System.Drawing.SystemColors.Info;
            this.grStudentBorrower.Controls.Add(this.lblBorrowerStudentId);
            this.grStudentBorrower.Controls.Add(this.lblBorrowerStudentName);
            this.grStudentBorrower.Controls.Add(this.btnStudentBorrowerDelete);
            this.grStudentBorrower.Controls.Add(this.lblStudentBorrowerYearLevel);
            this.grStudentBorrower.Controls.Add(this.btnStudentBorrowerUpdate);
            this.grStudentBorrower.Controls.Add(this.lblStudentBorrowerSection);
            this.grStudentBorrower.Controls.Add(this.btnStudentBorrowerAdd);
            this.grStudentBorrower.Controls.Add(this.lblStudentBorrowerPhoneNumber);
            this.grStudentBorrower.Controls.Add(this.btnStudentBorrowerSave);
            this.grStudentBorrower.Controls.Add(this.txtEmail);
            this.grStudentBorrower.Controls.Add(this.lblStudentBorrowerEmail);
            this.grStudentBorrower.Controls.Add(this.txtPhoneNmber);
            this.grStudentBorrower.Controls.Add(this.txtBorrowerId);
            this.grStudentBorrower.Controls.Add(this.txtSection);
            this.grStudentBorrower.Controls.Add(this.txtBorrowerName);
            this.grStudentBorrower.Controls.Add(this.txtboYearLevel);
            this.grStudentBorrower.Location = new System.Drawing.Point(12, 77);
            this.grStudentBorrower.Name = "grStudentBorrower";
            this.grStudentBorrower.Size = new System.Drawing.Size(347, 324);
            this.grStudentBorrower.TabIndex = 17;
            this.grStudentBorrower.TabStop = false;
            this.grStudentBorrower.Text = "Student";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 407);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 150);
            this.dataGridView1.TabIndex = 18;
            // 
            // grTeacherBorrower
            // 
            this.grTeacherBorrower.BackColor = System.Drawing.SystemColors.Info;
            this.grTeacherBorrower.Controls.Add(this.btnTeacherBorrowerDelete);
            this.grTeacherBorrower.Controls.Add(this.btnTeacherBorrowerUpdate);
            this.grTeacherBorrower.Controls.Add(this.btnTeacherBorrowerAdd);
            this.grTeacherBorrower.Controls.Add(this.btnTeacherBorrowerSave);
            this.grTeacherBorrower.Controls.Add(this.txtTeacherBorrowerEmail);
            this.grTeacherBorrower.Controls.Add(this.txtTeacherBorrowerPhoneNumber);
            this.grTeacherBorrower.Controls.Add(this.txtTeacherBorrowerDepartment);
            this.grTeacherBorrower.Controls.Add(this.txtTeacherBorrowerName);
            this.grTeacherBorrower.Controls.Add(this.txtTeacherBorrowerId);
            this.grTeacherBorrower.Controls.Add(this.lblTeacherBorrowerEmail);
            this.grTeacherBorrower.Controls.Add(this.lblTeacherBorrowerPhoneNumber);
            this.grTeacherBorrower.Controls.Add(this.lblTeacherborrowerDepartment);
            this.grTeacherBorrower.Controls.Add(this.lblTeacherBorrowerName);
            this.grTeacherBorrower.Controls.Add(this.lblTeacherBorrowerId);
            this.grTeacherBorrower.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grTeacherBorrower.Location = new System.Drawing.Point(441, 77);
            this.grTeacherBorrower.Name = "grTeacherBorrower";
            this.grTeacherBorrower.Size = new System.Drawing.Size(347, 324);
            this.grTeacherBorrower.TabIndex = 19;
            this.grTeacherBorrower.TabStop = false;
            this.grTeacherBorrower.Text = "Teacher";
            // 
            // lblTeacherBorrowerId
            // 
            this.lblTeacherBorrowerId.AutoSize = true;
            this.lblTeacherBorrowerId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherBorrowerId.Location = new System.Drawing.Point(30, 42);
            this.lblTeacherBorrowerId.Name = "lblTeacherBorrowerId";
            this.lblTeacherBorrowerId.Size = new System.Drawing.Size(80, 14);
            this.lblTeacherBorrowerId.TabIndex = 0;
            this.lblTeacherBorrowerId.Text = "Employee Id";
            // 
            // lblTeacherBorrowerName
            // 
            this.lblTeacherBorrowerName.AutoSize = true;
            this.lblTeacherBorrowerName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherBorrowerName.Location = new System.Drawing.Point(30, 74);
            this.lblTeacherBorrowerName.Name = "lblTeacherBorrowerName";
            this.lblTeacherBorrowerName.Size = new System.Drawing.Size(103, 14);
            this.lblTeacherBorrowerName.TabIndex = 1;
            this.lblTeacherBorrowerName.Text = "Teacher`s Name";
            // 
            // lblTeacherborrowerDepartment
            // 
            this.lblTeacherborrowerDepartment.AutoSize = true;
            this.lblTeacherborrowerDepartment.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherborrowerDepartment.Location = new System.Drawing.Point(30, 112);
            this.lblTeacherborrowerDepartment.Name = "lblTeacherborrowerDepartment";
            this.lblTeacherborrowerDepartment.Size = new System.Drawing.Size(76, 14);
            this.lblTeacherborrowerDepartment.TabIndex = 2;
            this.lblTeacherborrowerDepartment.Text = "Department";
            // 
            // lblTeacherBorrowerPhoneNumber
            // 
            this.lblTeacherBorrowerPhoneNumber.AutoSize = true;
            this.lblTeacherBorrowerPhoneNumber.Location = new System.Drawing.Point(30, 150);
            this.lblTeacherBorrowerPhoneNumber.Name = "lblTeacherBorrowerPhoneNumber";
            this.lblTeacherBorrowerPhoneNumber.Size = new System.Drawing.Size(93, 14);
            this.lblTeacherBorrowerPhoneNumber.TabIndex = 3;
            this.lblTeacherBorrowerPhoneNumber.Text = "Phone Number";
            // 
            // lblTeacherBorrowerEmail
            // 
            this.lblTeacherBorrowerEmail.AutoSize = true;
            this.lblTeacherBorrowerEmail.Location = new System.Drawing.Point(30, 186);
            this.lblTeacherBorrowerEmail.Name = "lblTeacherBorrowerEmail";
            this.lblTeacherBorrowerEmail.Size = new System.Drawing.Size(39, 14);
            this.lblTeacherBorrowerEmail.TabIndex = 4;
            this.lblTeacherBorrowerEmail.Text = "Email";
            // 
            // txtTeacherBorrowerId
            // 
            this.txtTeacherBorrowerId.Location = new System.Drawing.Point(160, 39);
            this.txtTeacherBorrowerId.Name = "txtTeacherBorrowerId";
            this.txtTeacherBorrowerId.Size = new System.Drawing.Size(100, 21);
            this.txtTeacherBorrowerId.TabIndex = 6;
            // 
            // txtTeacherBorrowerName
            // 
            this.txtTeacherBorrowerName.Location = new System.Drawing.Point(160, 75);
            this.txtTeacherBorrowerName.Name = "txtTeacherBorrowerName";
            this.txtTeacherBorrowerName.Size = new System.Drawing.Size(100, 21);
            this.txtTeacherBorrowerName.TabIndex = 7;
            // 
            // txtTeacherBorrowerDepartment
            // 
            this.txtTeacherBorrowerDepartment.Location = new System.Drawing.Point(160, 109);
            this.txtTeacherBorrowerDepartment.Name = "txtTeacherBorrowerDepartment";
            this.txtTeacherBorrowerDepartment.Size = new System.Drawing.Size(100, 21);
            this.txtTeacherBorrowerDepartment.TabIndex = 8;
            // 
            // txtTeacherBorrowerPhoneNumber
            // 
            this.txtTeacherBorrowerPhoneNumber.Location = new System.Drawing.Point(160, 151);
            this.txtTeacherBorrowerPhoneNumber.Name = "txtTeacherBorrowerPhoneNumber";
            this.txtTeacherBorrowerPhoneNumber.Size = new System.Drawing.Size(100, 21);
            this.txtTeacherBorrowerPhoneNumber.TabIndex = 9;
            // 
            // txtTeacherBorrowerEmail
            // 
            this.txtTeacherBorrowerEmail.Location = new System.Drawing.Point(160, 183);
            this.txtTeacherBorrowerEmail.Name = "txtTeacherBorrowerEmail";
            this.txtTeacherBorrowerEmail.Size = new System.Drawing.Size(100, 21);
            this.txtTeacherBorrowerEmail.TabIndex = 10;
            // 
            // btnTeacherBorrowerSave
            // 
            this.btnTeacherBorrowerSave.Location = new System.Drawing.Point(8, 271);
            this.btnTeacherBorrowerSave.Name = "btnTeacherBorrowerSave";
            this.btnTeacherBorrowerSave.Size = new System.Drawing.Size(75, 23);
            this.btnTeacherBorrowerSave.TabIndex = 11;
            this.btnTeacherBorrowerSave.Text = "Save";
            this.btnTeacherBorrowerSave.UseVisualStyleBackColor = true;
            // 
            // btnTeacherBorrowerAdd
            // 
            this.btnTeacherBorrowerAdd.Location = new System.Drawing.Point(89, 271);
            this.btnTeacherBorrowerAdd.Name = "btnTeacherBorrowerAdd";
            this.btnTeacherBorrowerAdd.Size = new System.Drawing.Size(75, 23);
            this.btnTeacherBorrowerAdd.TabIndex = 12;
            this.btnTeacherBorrowerAdd.Text = "Add";
            this.btnTeacherBorrowerAdd.UseVisualStyleBackColor = true;
            // 
            // btnTeacherBorrowerUpdate
            // 
            this.btnTeacherBorrowerUpdate.Location = new System.Drawing.Point(170, 271);
            this.btnTeacherBorrowerUpdate.Name = "btnTeacherBorrowerUpdate";
            this.btnTeacherBorrowerUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnTeacherBorrowerUpdate.TabIndex = 13;
            this.btnTeacherBorrowerUpdate.Text = "Update";
            this.btnTeacherBorrowerUpdate.UseVisualStyleBackColor = true;
            // 
            // btnTeacherBorrowerDelete
            // 
            this.btnTeacherBorrowerDelete.Location = new System.Drawing.Point(251, 271);
            this.btnTeacherBorrowerDelete.Name = "btnTeacherBorrowerDelete";
            this.btnTeacherBorrowerDelete.Size = new System.Drawing.Size(75, 23);
            this.btnTeacherBorrowerDelete.TabIndex = 14;
            this.btnTeacherBorrowerDelete.Text = "Delete";
            this.btnTeacherBorrowerDelete.UseVisualStyleBackColor = true;
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectLibrary.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(800, 556);
            this.Controls.Add(this.grTeacherBorrower);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grStudentBorrower);
            this.Controls.Add(this.panel2);
            this.Name = "FormStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBookBorrowing";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grStudentBorrower.ResumeLayout(false);
            this.grStudentBorrower.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grTeacherBorrower.ResumeLayout(false);
            this.grTeacherBorrower.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblBookBorrowing;
        private System.Windows.Forms.Label lblBorrowerStudentId;
        private System.Windows.Forms.Label lblBorrowerStudentName;
        private System.Windows.Forms.Label lblStudentBorrowerYearLevel;
        private System.Windows.Forms.Label lblStudentBorrowerSection;
        private System.Windows.Forms.Label lblStudentBorrowerPhoneNumber;
        private System.Windows.Forms.Label lblStudentBorrowerEmail;
        private System.Windows.Forms.TextBox txtBorrowerId;
        private System.Windows.Forms.TextBox txtBorrowerName;
        private System.Windows.Forms.TextBox txtboYearLevel;
        private System.Windows.Forms.TextBox txtSection;
        private System.Windows.Forms.TextBox txtPhoneNmber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnStudentBorrowerSave;
        private System.Windows.Forms.Button btnStudentBorrowerAdd;
        private System.Windows.Forms.Button btnStudentBorrowerUpdate;
        private System.Windows.Forms.Button btnStudentBorrowerDelete;
        private System.Windows.Forms.GroupBox grStudentBorrower;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grTeacherBorrower;
        private System.Windows.Forms.TextBox txtTeacherBorrowerEmail;
        private System.Windows.Forms.TextBox txtTeacherBorrowerPhoneNumber;
        private System.Windows.Forms.TextBox txtTeacherBorrowerDepartment;
        private System.Windows.Forms.TextBox txtTeacherBorrowerName;
        private System.Windows.Forms.TextBox txtTeacherBorrowerId;
        private System.Windows.Forms.Label lblTeacherBorrowerEmail;
        private System.Windows.Forms.Label lblTeacherBorrowerPhoneNumber;
        private System.Windows.Forms.Label lblTeacherborrowerDepartment;
        private System.Windows.Forms.Label lblTeacherBorrowerName;
        private System.Windows.Forms.Label lblTeacherBorrowerId;
        private System.Windows.Forms.Button btnTeacherBorrowerDelete;
        private System.Windows.Forms.Button btnTeacherBorrowerUpdate;
        private System.Windows.Forms.Button btnTeacherBorrowerAdd;
        private System.Windows.Forms.Button btnTeacherBorrowerSave;
    }
}