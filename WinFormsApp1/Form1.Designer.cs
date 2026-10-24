namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Panel formPanel;
        private Label titleLabel;
        private Label employeeCodeLabel;
        private Label fullNameLabel;
        private Label genderLabel;
        private TextBox employeeCodeTextBox;
        private TextBox fullNameTextBox;
        private ComboBox genderComboBox;
        private Button registerButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            formPanel = new Panel();
            titleLabel = new Label();
            employeeCodeLabel = new Label();
            fullNameLabel = new Label();
            genderLabel = new Label();
            employeeCodeTextBox = new TextBox();
            fullNameTextBox = new TextBox();
            genderComboBox = new ComboBox();
            registerButton = new Button();
            formPanel.SuspendLayout();
            SuspendLayout();
            //
            // formPanel
            //
            formPanel.BackColor = Color.White;
            formPanel.Controls.Add(registerButton);
            formPanel.Controls.Add(genderComboBox);
            formPanel.Controls.Add(genderLabel);
            formPanel.Controls.Add(fullNameTextBox);
            formPanel.Controls.Add(fullNameLabel);
            formPanel.Controls.Add(employeeCodeTextBox);
            formPanel.Controls.Add(employeeCodeLabel);
            formPanel.Controls.Add(titleLabel);
            formPanel.Dock = DockStyle.Fill;
            formPanel.Padding = new Padding(28);
            formPanel.RightToLeft = RightToLeft.Yes;
            //
            // titleLabel
            //
            titleLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            titleLabel.ForeColor = Color.FromArgb(31, 55, 86);
            titleLabel.Location = new Point(28, 28);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(464, 48);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "فرم ثبت مشخصات پرسنلی";
            titleLabel.TextAlign = ContentAlignment.MiddleRight;
            //
            // employeeCodeLabel
            //
            employeeCodeLabel.Location = new Point(330, 100);
            employeeCodeLabel.Name = "employeeCodeLabel";
            employeeCodeLabel.Size = new Size(160, 32);
            employeeCodeLabel.TabIndex = 1;
            employeeCodeLabel.Text = "کد پرسنلی:";
            employeeCodeLabel.TextAlign = ContentAlignment.MiddleRight;
            //
            // employeeCodeTextBox
            //
            employeeCodeTextBox.Location = new Point(48, 102);
            employeeCodeTextBox.MaxLength = 20;
            employeeCodeTextBox.Name = "employeeCodeTextBox";
            employeeCodeTextBox.PlaceholderText = "کد پرسنلی را وارد کنید";
            employeeCodeTextBox.RightToLeft = RightToLeft.Yes;
            employeeCodeTextBox.Size = new Size(265, 27);
            employeeCodeTextBox.TabIndex = 2;
            employeeCodeTextBox.KeyPress += EmployeeCodeTextBox_KeyPress;
            //
            // fullNameLabel
            //
            fullNameLabel.Location = new Point(330, 153);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(160, 32);
            fullNameLabel.TabIndex = 3;
            fullNameLabel.Text = "نام و نام خانوادگی:";
            fullNameLabel.TextAlign = ContentAlignment.MiddleRight;
            //
            // fullNameTextBox
            //
            fullNameTextBox.Location = new Point(48, 155);
            fullNameTextBox.MaxLength = 100;
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.PlaceholderText = "نام و نام خانوادگی را وارد کنید";
            fullNameTextBox.RightToLeft = RightToLeft.Yes;
            fullNameTextBox.Size = new Size(265, 27);
            fullNameTextBox.TabIndex = 4;
            //
            // genderLabel
            //
            genderLabel.Location = new Point(330, 206);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(160, 32);
            genderLabel.TabIndex = 5;
            genderLabel.Text = "جنسیت:";
            genderLabel.TextAlign = ContentAlignment.MiddleRight;
            //
            // genderComboBox
            //
            genderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Items.AddRange(new object[] { "زن", "مرد" });
            genderComboBox.Location = new Point(48, 208);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.RightToLeft = RightToLeft.Yes;
            genderComboBox.Size = new Size(265, 28);
            genderComboBox.TabIndex = 6;
            //
            // registerButton
            //
            registerButton.BackColor = Color.FromArgb(37, 99, 235);
            registerButton.FlatAppearance.BorderSize = 0;
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            registerButton.ForeColor = Color.White;
            registerButton.Location = new Point(48, 265);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(442, 44);
            registerButton.TabIndex = 7;
            registerButton.Text = "ثبت اطلاعات";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += RegisterButton_Click;
            //
            // Form1
            //
            AcceptButton = registerButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(520, 360);
            Controls.Add(formPanel);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(480, 340);
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ثبت اطلاعات پرسنلی";
            formPanel.ResumeLayout(false);
            formPanel.PerformLayout();
            ResumeLayout(false);
        }
    }
}
