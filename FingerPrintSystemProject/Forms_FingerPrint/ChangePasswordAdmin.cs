﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Forms_FingerPrint
{
    public partial class ChangePasswordAdmin : Form
    {
        public ChangePasswordAdmin()
        {
            InitializeComponent();
        }

        private void tbo_RoleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbo_RoleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._FINGERPRINTDB_MDFDataSet);

        }

        private void ChangePasswordAdmin_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_FINGERPRINTDB_MDFDataSet.tbo_Department". При необходимости она может быть перемещена или удалена.
            this.tbo_DepartmentTableAdapter.Fill(this._FINGERPRINTDB_MDFDataSet.tbo_Department);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_FINGERPRINTDB_MDFDataSet.tbo_LinkDepartmentUser". При необходимости она может быть перемещена или удалена.
            this.tbo_LinkDepartmentUserTableAdapter.Fill(this._FINGERPRINTDB_MDFDataSet.tbo_LinkDepartmentUser);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_FINGERPRINTDB_MDFDataSet.tbo_Profile". При необходимости она может быть перемещена или удалена.
            this.tbo_ProfileTableAdapter.Fill(this._FINGERPRINTDB_MDFDataSet.tbo_Profile);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_FINGERPRINTDB_MDFDataSet.tbo_Role". При необходимости она может быть перемещена или удалена.
            this.tbo_RoleTableAdapter.Fill(this._FINGERPRINTDB_MDFDataSet.tbo_Role);
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap image;

            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    image = new Bitmap(open_dialog.FileName);
                    //this.сompanyLogoPictureBox.Size = image.Size;
                    photoPictureBox.Image = image;
                    photoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    photoPictureBox.Invalidate();
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) //make photo
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            tbo_LinkDepartmentUserBindingSource.EndEdit();
            tbo_ProfileBindingSource.EndEdit();

            tbo_ProfileTableAdapter.Update(_FINGERPRINTDB_MDFDataSet);
            tbo_LinkDepartmentUserTableAdapter.Update(_FINGERPRINTDB_MDFDataSet);
            
            

            string message = "You created New Admin User. You enter to system by this account";
            string caption = "FingerPrintSystem";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            photoPictureBox.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            photoPictureBox.Enabled = true;
            fingerPrintTextBox.Enabled = true;
            button3.Enabled = true;
            iDTextBox1.Enabled = true;
            nameTextBox1.Enabled = true;
            surnameTextBox.Enabled = true;
            patronymicTextBox.Enabled = true;
            birthDateTextBox.Enabled = true;
            scheduleTextBox.Enabled = true;
            passwordTextBox.Enabled = true;
            roleIDTextBox.Enabled = true;
            button6.Enabled = true;
            button5.Enabled = true;
            checkBox2.Enabled = true;
            button7.Enabled = true;
            departmentIDComboBox1.Enabled = true;
            userIDTextBox.Enabled = true;
            accessTextBox.Enabled = true;
            checkBox1.Enabled = true;






            tbo_ProfileBindingSource.AddNew();
            tbo_LinkDepartmentUserBindingSource.AddNew();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            string message = "Are you sure you remove information about this account?";
            string caption = "FingerPrintSystem::Removing Account";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption,buttons,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                tbo_ProfileBindingSource.RemoveCurrent();
                tbo_LinkDepartmentUserBindingSource.RemoveCurrent();
                tbo_LinkDepartmentUserTableAdapter.Update(_FINGERPRINTDB_MDFDataSet);
                tbo_ProfileTableAdapter.Update(_FINGERPRINTDB_MDFDataSet);
                string message1 = "This account was deleted. If you want to create new account you should click on Add Admin User";
                string caption1 = "FingerPrintSystem";
                MessageBoxButtons buttons1 = MessageBoxButtons.OK;
                DialogResult result1;
                result1 = MessageBox.Show(message1, caption1, buttons1);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Enter_Form f1 = new Enter_Form();
            f1.Enabled = false;
            f1.Hide();
            this.Hide();
            FirstEnter fe1 = new FirstEnter();
            fe1.Show();


        }

        private void button3_Click(object sender, EventArgs e) //add fingerprint
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            tbo_LinkDepartmentUserBindingSource.RemoveCurrent();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBox1.Checked == true)
            {
                tbo_LinkDepartmentUserDataGridView.Visible = true;
            }
            else
            {
                tbo_LinkDepartmentUserDataGridView.Visible = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked ==true)
            {
                tbo_ProfileDataGridView.Visible = true;
            }
            else
            {
                tbo_ProfileDataGridView.Visible = false;
            }
        }

        private void fingerPrintLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
