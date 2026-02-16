namespace HomeworkReminder
{
    partial class Form1
    {
        
        private System.ComponentModel.IContainer components = null;

     
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

     
        private void InitializeComponent()
        {
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.cboSubject = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
           
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(50, 50);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(95, 17);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Homework ID:";
           
            this.txtID.Location = new System.Drawing.Point(200, 47);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(200, 22);
            this.txtID.TabIndex = 1;
         
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(50, 100);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(107, 17);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Homework Title:";
           
            this.txtTitle.Location = new System.Drawing.Point(200, 97);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(400, 22);
            this.txtTitle.TabIndex = 3;
          
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(50, 150);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(59, 17);
            this.lblSubject.TabIndex = 4;
            this.lblSubject.Text = "Subject:";
          
            this.cboSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSubject.FormattingEnabled = true;
            this.cboSubject.Items.AddRange(new object[] {
            "Mathematics",
            "Science",
            "English",
            "History",
            "Computer Programming"});
            this.cboSubject.Location = new System.Drawing.Point(200, 147);
            this.cboSubject.Name = "cboSubject";
            this.cboSubject.Size = new System.Drawing.Size(200, 24);
            this.cboSubject.TabIndex = 5;
           
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(50, 200);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(52, 17);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status:";
           
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Not Started",
            "Doing",
            "Finished"});
            this.cboStatus.Location = new System.Drawing.Point(200, 197);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(200, 24);
            this.cboStatus.TabIndex = 7;
          
            this.btnAdd.BackColor = System.Drawing.Color.LightGreen;
            this.btnAdd.Location = new System.Drawing.Point(200, 260);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 40);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
          
            this.btnClear.Location = new System.Drawing.Point(320, 260);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 40);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
           
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(440, 260);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 40);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
           
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cboSubject);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "โปรแกรมบันทึกการบ้าน";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.ComboBox cboSubject;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}