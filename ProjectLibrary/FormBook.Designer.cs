namespace ProjectLibrary
{
    partial class FormBook
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
            this.lblBooks = new System.Windows.Forms.Label();
            this.lblBookId = new System.Windows.Forms.Label();
            this.lblBook = new System.Windows.Forms.Label();
            this.lblBookNumber = new System.Windows.Forms.Label();
            this.lblBookPublisher = new System.Windows.Forms.Label();
            this.lblBookAuthor = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtBook = new System.Windows.Forms.TextBox();
            this.btnBookDelete = new System.Windows.Forms.Button();
            this.btnBookUpdate = new System.Windows.Forms.Button();
            this.btnBookAdd = new System.Windows.Forms.Button();
            this.btnBookSave = new System.Windows.Forms.Button();
            this.panelbook = new System.Windows.Forms.Panel();
            this.grboxBook = new System.Windows.Forms.GroupBox();
            this.panelbook.SuspendLayout();
            this.grboxBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBooks
            // 
            this.lblBooks.AutoSize = true;
            this.lblBooks.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooks.Location = new System.Drawing.Point(410, 8);
            this.lblBooks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBooks.Name = "lblBooks";
            this.lblBooks.Size = new System.Drawing.Size(147, 50);
            this.lblBooks.TabIndex = 0;
            this.lblBooks.Text = "Books";
            // 
            // lblBookId
            // 
            this.lblBookId.AutoSize = true;
            this.lblBookId.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblBookId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookId.Location = new System.Drawing.Point(24, 39);
            this.lblBookId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(19, 15);
            this.lblBookId.TabIndex = 1;
            this.lblBookId.Text = "Id";
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBook.Location = new System.Drawing.Point(24, 85);
            this.lblBook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(39, 15);
            this.lblBook.TabIndex = 2;
            this.lblBook.Text = "Book";
            // 
            // lblBookNumber
            // 
            this.lblBookNumber.AutoSize = true;
            this.lblBookNumber.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookNumber.Location = new System.Drawing.Point(24, 134);
            this.lblBookNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookNumber.Name = "lblBookNumber";
            this.lblBookNumber.Size = new System.Drawing.Size(59, 15);
            this.lblBookNumber.TabIndex = 3;
            this.lblBookNumber.Text = "Number";
            // 
            // lblBookPublisher
            // 
            this.lblBookPublisher.AutoSize = true;
            this.lblBookPublisher.Location = new System.Drawing.Point(24, 175);
            this.lblBookPublisher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookPublisher.Name = "lblBookPublisher";
            this.lblBookPublisher.Size = new System.Drawing.Size(69, 15);
            this.lblBookPublisher.TabIndex = 4;
            this.lblBookPublisher.Text = "Publisher";
            // 
            // lblBookAuthor
            // 
            this.lblBookAuthor.AutoSize = true;
            this.lblBookAuthor.Location = new System.Drawing.Point(24, 221);
            this.lblBookAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookAuthor.Name = "lblBookAuthor";
            this.lblBookAuthor.Size = new System.Drawing.Size(51, 15);
            this.lblBookAuthor.TabIndex = 5;
            this.lblBookAuthor.Text = "Author";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(145, 36);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(132, 23);
            this.txtId.TabIndex = 6;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(145, 218);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(132, 23);
            this.txtAuthor.TabIndex = 7;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(145, 172);
            this.txtPublisher.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(132, 23);
            this.txtPublisher.TabIndex = 8;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(145, 131);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(132, 23);
            this.txtNumber.TabIndex = 9;
            // 
            // txtBook
            // 
            this.txtBook.Location = new System.Drawing.Point(145, 82);
            this.txtBook.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBook.Name = "txtBook";
            this.txtBook.Size = new System.Drawing.Size(132, 23);
            this.txtBook.TabIndex = 10;
            // 
            // btnBookDelete
            // 
            this.btnBookDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBookDelete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookDelete.Location = new System.Drawing.Point(479, 407);
            this.btnBookDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBookDelete.Name = "btnBookDelete";
            this.btnBookDelete.Size = new System.Drawing.Size(100, 33);
            this.btnBookDelete.TabIndex = 12;
            this.btnBookDelete.Text = "Delete";
            this.btnBookDelete.UseVisualStyleBackColor = false;
            // 
            // btnBookUpdate
            // 
            this.btnBookUpdate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBookUpdate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookUpdate.Location = new System.Drawing.Point(332, 407);
            this.btnBookUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBookUpdate.Name = "btnBookUpdate";
            this.btnBookUpdate.Size = new System.Drawing.Size(100, 33);
            this.btnBookUpdate.TabIndex = 13;
            this.btnBookUpdate.Text = "Update";
            this.btnBookUpdate.UseVisualStyleBackColor = false;
            // 
            // btnBookAdd
            // 
            this.btnBookAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBookAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookAdd.Location = new System.Drawing.Point(196, 407);
            this.btnBookAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBookAdd.Name = "btnBookAdd";
            this.btnBookAdd.Size = new System.Drawing.Size(100, 33);
            this.btnBookAdd.TabIndex = 14;
            this.btnBookAdd.Text = "Add";
            this.btnBookAdd.UseVisualStyleBackColor = false;
            // 
            // btnBookSave
            // 
            this.btnBookSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBookSave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookSave.Location = new System.Drawing.Point(57, 407);
            this.btnBookSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBookSave.Name = "btnBookSave";
            this.btnBookSave.Size = new System.Drawing.Size(100, 33);
            this.btnBookSave.TabIndex = 15;
            this.btnBookSave.Text = "Save";
            this.btnBookSave.UseVisualStyleBackColor = false;
            // 
            // panelbook
            // 
            this.panelbook.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelbook.Controls.Add(this.lblBooks);
            this.panelbook.Location = new System.Drawing.Point(-1, -2);
            this.panelbook.Name = "panelbook";
            this.panelbook.Size = new System.Drawing.Size(979, 69);
            this.panelbook.TabIndex = 17;
            // 
            // grboxBook
            // 
            this.grboxBook.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grboxBook.Controls.Add(this.lblBookId);
            this.grboxBook.Controls.Add(this.lblBook);
            this.grboxBook.Controls.Add(this.lblBookNumber);
            this.grboxBook.Controls.Add(this.lblBookPublisher);
            this.grboxBook.Controls.Add(this.lblBookAuthor);
            this.grboxBook.Controls.Add(this.txtId);
            this.grboxBook.Controls.Add(this.txtBook);
            this.grboxBook.Controls.Add(this.txtAuthor);
            this.grboxBook.Controls.Add(this.txtPublisher);
            this.grboxBook.Controls.Add(this.txtNumber);
            this.grboxBook.Location = new System.Drawing.Point(12, 104);
            this.grboxBook.Name = "grboxBook";
            this.grboxBook.Size = new System.Drawing.Size(319, 283);
            this.grboxBook.TabIndex = 18;
            this.grboxBook.TabStop = false;
            // 
            // FormBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::ProjectLibrary.Properties.Resources.istockphoto_1133787494_612x612;
            this.ClientSize = new System.Drawing.Size(978, 586);
            this.Controls.Add(this.grboxBook);
            this.Controls.Add(this.panelbook);
            this.Controls.Add(this.btnBookSave);
            this.Controls.Add(this.btnBookAdd);
            this.Controls.Add(this.btnBookUpdate);
            this.Controls.Add(this.btnBookDelete);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBook";
            this.panelbook.ResumeLayout(false);
            this.panelbook.PerformLayout();
            this.grboxBook.ResumeLayout(false);
            this.grboxBook.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBooks;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.Label lblBookNumber;
        private System.Windows.Forms.Label lblBookPublisher;
        private System.Windows.Forms.Label lblBookAuthor;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtBook;
        private System.Windows.Forms.Button btnBookDelete;
        private System.Windows.Forms.Button btnBookUpdate;
        private System.Windows.Forms.Button btnBookAdd;
        private System.Windows.Forms.Button btnBookSave;
        private System.Windows.Forms.Panel panelbook;
        private System.Windows.Forms.GroupBox grboxBook;
    }
}