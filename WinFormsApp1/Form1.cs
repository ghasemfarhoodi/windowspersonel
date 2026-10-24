namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EmployeeCodeTextBox_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void RegisterButton_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(employeeCodeTextBox.Text))
            {
                ShowValidationMessage("کد پرسنلی را وارد کنید.", employeeCodeTextBox);
                return;
            }

            if (string.IsNullOrWhiteSpace(fullNameTextBox.Text))
            {
                ShowValidationMessage("نام و نام خانوادگی را وارد کنید.", fullNameTextBox);
                return;
            }

            if (genderComboBox.SelectedIndex < 0)
            {
                ShowValidationMessage("جنسیت را انتخاب کنید.", genderComboBox);
                return;
            }

            MessageBox.Show(
                $"اطلاعات پرسنل با موفقیت ثبت شد.\n\nکد پرسنلی: {employeeCodeTextBox.Text.Trim()}\nنام و نام خانوادگی: {fullNameTextBox.Text.Trim()}\nجنسیت: {genderComboBox.SelectedItem}",
                "ثبت موفق",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
        }

        private void ShowValidationMessage(string message, Control control)
        {
            MessageBox.Show(message, "اطلاعات ناقص", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
            control.Focus();
        }
    }
}
