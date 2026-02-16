using System;
using System.Windows.Forms;

namespace HomeworkReminder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

          
            if (cboSubject.Items.Count > 0) cboSubject.SelectedIndex = 0;
            if (cboStatus.Items.Count > 0) cboStatus.SelectedIndex = 0;
        }

      
        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(txtID.Text) || string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("กรุณากรอก Homework ID และ Homework Title ให้ครบถ้วน",
                                "แจ้งเตือน",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            string message = $"บันทึกข้อมูลสำเร็จ!\n\n" +
                             $"รหัสการบ้าน: {txtID.Text}\n" +
                             $"ชื่อเรื่อง: {txtTitle.Text}\n" +
                             $"รายวิชา: {cboSubject.SelectedItem}\n" +
                             $"สถานะ: {cboStatus.SelectedItem}";

            MessageBox.Show(message, "Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtTitle.Clear();
            cboSubject.SelectedIndex = 0;
            cboStatus.SelectedIndex = 0;
            txtID.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการปิดโปรแกรมใช่หรือไม่?", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}