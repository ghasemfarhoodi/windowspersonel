#nullable disable
namespace WinFormsApp1
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private TableLayoutPanel rootLayout;
        private Panel headerPanel;
        private Label headerTitleLabel;
        private Label headerSectionLabel;
        private Panel patientPanel;
        private Label patientSectionLabel;
        private TableLayoutPanel patientFieldsLayout;
        private TextBox nationalCodeTextBox;
        private FlowLayoutPanel navigationPanel;
        private Panel contentPanel;
        private TableLayoutPanel sectionsLayout;
        private FlowLayoutPanel actionPanel;
        private readonly List<Control> patientFieldControls = new();
        private readonly Dictionary<Control, int> patientFieldColumnSpans = new();

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            rootLayout = new TableLayoutPanel();
            headerPanel = new Panel();
            headerTitleLabel = new Label();
            headerSectionLabel = new Label();
            patientPanel = new Panel();
            patientSectionLabel = new Label();
            patientFieldsLayout = new TableLayoutPanel();
            nationalCodeTextBox = new TextBox();
            navigationPanel = new FlowLayoutPanel();
            contentPanel = new Panel();
            sectionsLayout = new TableLayoutPanel();
            actionPanel = new FlowLayoutPanel();
            rootLayout.SuspendLayout();
            headerPanel.SuspendLayout();
            patientPanel.SuspendLayout();
            patientFieldsLayout.SuspendLayout();
            navigationPanel.SuspendLayout();
            contentPanel.SuspendLayout();
            sectionsLayout.SuspendLayout();
            actionPanel.SuspendLayout();
            SuspendLayout();
            // Form2
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 245, 255);
            ClientSize = new Size(1480, 820);
            MinimumSize = new Size(620, 760);
            Name = "Form2";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "فرم دیابت - اطلاعات بیمار";
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            // rootLayout
            rootLayout.ColumnCount = 1;
            rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            rootLayout.Dock = DockStyle.Fill;
            rootLayout.Padding = new Padding(10, 8, 10, 8);
            rootLayout.RightToLeft = RightToLeft.Yes;
            rootLayout.RowCount = 5;
            rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 176F));
            rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            rootLayout.Controls.Add(headerPanel, 0, 0);
            rootLayout.Controls.Add(patientPanel, 0, 1);
            rootLayout.Controls.Add(navigationPanel, 0, 2);
            rootLayout.Controls.Add(contentPanel, 0, 3);
            rootLayout.Controls.Add(actionPanel, 0, 4);
            // headerPanel
            headerPanel.BackColor = Color.FromArgb(80, 39, 160);
            headerPanel.Controls.Add(headerTitleLabel);
            headerPanel.Controls.Add(headerSectionLabel);
            headerPanel.Dock = DockStyle.Fill;
            headerPanel.Margin = new Padding(0, 0, 0, 8);
            headerPanel.Padding = new Padding(12, 3, 12, 3);
            headerPanel.RightToLeft = RightToLeft.Yes;
            // headerTitleLabel
            headerTitleLabel.Dock = DockStyle.Right;
            headerTitleLabel.Font = new Font("Tahoma", 15F, FontStyle.Bold);
            headerTitleLabel.ForeColor = Color.White;
            headerTitleLabel.Size = new Size(250, 54);
            headerTitleLabel.Text = "فرم دیابت  ▤";
            headerTitleLabel.TextAlign = ContentAlignment.MiddleRight;
            // headerSectionLabel
            headerSectionLabel.Dock = DockStyle.Left;
            headerSectionLabel.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            headerSectionLabel.ForeColor = Color.White;
            headerSectionLabel.Size = new Size(280, 54);
            headerSectionLabel.Text = "♙  اطلاعات کلی بیمار";
            headerSectionLabel.TextAlign = ContentAlignment.MiddleLeft;
            // patientPanel
            patientPanel.BackColor = Color.White;
            patientPanel.BorderStyle = BorderStyle.FixedSingle;
            patientPanel.Controls.Add(patientFieldsLayout);
            patientPanel.Controls.Add(patientSectionLabel);
            patientPanel.Dock = DockStyle.Fill;
            patientPanel.Margin = new Padding(0, 0, 0, 8);
            patientPanel.Padding = new Padding(8, 6, 8, 6);
            patientPanel.RightToLeft = RightToLeft.Yes;
            patientPanel.AutoScroll = false;
            // patientSectionLabel
            patientSectionLabel.BackColor = Color.FromArgb(243, 238, 255);
            patientSectionLabel.Dock = DockStyle.Top;
            patientSectionLabel.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            patientSectionLabel.ForeColor = Color.FromArgb(74, 31, 167);
            patientSectionLabel.Height = 30;
            patientSectionLabel.Text = "مشخصات فردی  ♟";
            patientSectionLabel.RightToLeft = RightToLeft.No;
            patientSectionLabel.TextAlign = ContentAlignment.MiddleRight;
            patientSectionLabel.Padding = new Padding(0, 0, 10, 0);
            // patientFieldsLayout
            patientFieldsLayout.ColumnCount = 5;
            patientFieldsLayout.Dock = DockStyle.Fill;
            patientFieldsLayout.Padding = new Padding(0, 4, 0, 0);
            patientFieldsLayout.RightToLeft = RightToLeft.Yes;
            patientFieldsLayout.RowCount = 2;
            patientFieldsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            patientFieldsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            AddPatientField("کد ملی", out nationalCodeTextBox, 0, 0, "کد ملی را وارد کنید");
            AddPatientField("کد پرونده", out _, 1, 0, "شماره پرونده");
            AddPatientField("نام", out _, 2, 0, "نام بیمار");
            AddPatientField("نام خانوادگی", out _, 3, 0, "نام خانوادگی");
            AddPatientField("تاریخ تولد", out _, 4, 0, "روز / ماه / سال", showCalendarButton: true);
            AddChoiceField("جنسیت", new[] { "مرد", "زن" }, 0, 1);
            AddChoiceField("وضعیت تأهل", new[] { "متأهل", "مجرد" }, 1, 1);
            AddPatientField("شغل", out _, 2, 1, "شغل بیمار");
            AddPatientField("شماره تماس", out _, 3, 1, "شماره تماس", columnSpan: 2);
            // navigationPanel
            navigationPanel.BackColor = Color.Transparent;
            navigationPanel.Dock = DockStyle.Fill;
            navigationPanel.Margin = new Padding(0, 0, 0, 8);
            navigationPanel.Padding = new Padding(0);
            navigationPanel.RightToLeft = RightToLeft.Yes;
            navigationPanel.FlowDirection = FlowDirection.RightToLeft;
            navigationPanel.WrapContents = true;
            navigationPanel.AutoScroll = false;
            navigationPanel.Controls.Add(CreateNavigationButton("تشکیل پرونده", Color.FromArgb(245, 103, 35)));
            navigationPanel.Controls.Add(CreateNavigationButton("علائم و حال عمومی"));
            navigationPanel.Controls.Add(CreateNavigationButton("معاینات و پارامترها"));
            navigationPanel.Controls.Add(CreateNavigationButton("کنترل قند خون"));
            navigationPanel.Controls.Add(CreateNavigationButton("وضعیت سبک زندگی"));
            navigationPanel.Controls.Add(CreateNavigationButton("داروها و تغییرات"));
            navigationPanel.Controls.Add(CreateNavigationButton("برنامه و تصمیم امروز"));
            // contentPanel
            contentPanel.AutoScroll = true;
            contentPanel.BackColor = Color.Transparent;
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Margin = new Padding(0, 0, 0, 8);
            contentPanel.Controls.Add(sectionsLayout);
            contentPanel.RightToLeft = RightToLeft.Yes;
            // sectionsLayout
            sectionsLayout.ColumnCount = 2;
            sectionsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            sectionsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            sectionsLayout.Dock = DockStyle.Top;
            sectionsLayout.Height = 640;
            sectionsLayout.Padding = new Padding(0);
            sectionsLayout.RightToLeft = RightToLeft.Yes;
            sectionsLayout.RowCount = 3;
            sectionsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 34F));
            sectionsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            sectionsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            sectionsLayout.Controls.Add(CreateSection("دخانیات و آلرژی", new[] { "مصرف دخانیات: هرگز", "مصرف دخانیات: سابق", "مصرف دخانیات: فعلی", "آلرژی دارویی: ندارد", "آلرژی دارویی: دارد" }, "توضیحات دخانیات و آلرژی"), 0, 0);
            sectionsLayout.Controls.Add(CreateSection("سابقه خانوادگی و نوع دیابت", new[] { "دیابت", "بیماری قلبی", "فشار خون", "دیس‌لیپیدمی", "نوع یک", "نوع دو", "سایر" }, "شرح سابقه خانوادگی"), 1, 0);
            sectionsLayout.Controls.Add(CreateSection("سابقه دیابت", new[] { "سابقه کتواسیدوز دیابتی یا قند بسیار بالا", "سابقه افت قند خون", "سابقه بستری به‌علت دیابت" }, "سال تشخیص / مدت بیماری"), 0, 1);
            sectionsLayout.Controls.Add(CreateSection("بیماری‌های همراه", new[] { "فشار خون", "دیس‌لیپیدمی", "چاقی", "نارسایی قلب", "کبد چرب", "تیروئید", "کلیوی مزمن", "آپنه خواب", "سایر" }, "سایر بیماری‌های همراه"), 1, 1);
            sectionsLayout.Controls.Add(CreateSection("عوارض دیابت", new[] { "رتینوپاتی چشم", "بیماری عروق کرونر", "زخم پای دیابتی", "نفروپاتی کلیه", "سکته مغزی", "بدون عارضه شناخته‌شده", "نوروپاتی اعصاب" }, "شرح عوارض"), 0, 2);
            sectionsLayout.Controls.Add(CreateSection("درمان دیابت", new[] { "درمان با انسولین", "داروی خوراکی", "رژیم غذایی", "فعالیت بدنی" }, "سال شروع درمان"), 1, 2);
            // actionPanel
            actionPanel.BackColor = Color.White;
            actionPanel.Dock = DockStyle.Fill;
            actionPanel.Padding = new Padding(6, 4, 6, 4);
            actionPanel.RightToLeft = RightToLeft.No;
            actionPanel.FlowDirection = FlowDirection.LeftToRight;
            actionPanel.WrapContents = false;
            actionPanel.AutoScroll = false;
            actionPanel.Controls.Add(CreateActionButton("حذف", Color.FromArgb(232, 62, 75), DeleteButton_Click));
            actionPanel.Controls.Add(CreateActionButton("ذخیره", Color.FromArgb(101, 47, 210), SaveButton_Click));
            actionPanel.Controls.Add(CreateActionButton("ویرایش", Color.FromArgb(101, 47, 210), null));
            actionPanel.Controls.Add(CreateActionButton("جدید", Color.FromArgb(101, 47, 210), NewButton_Click));
            Controls.Add(rootLayout);
            Resize += Form2_Resize;
            ArrangeResponsiveLayout();
            rootLayout.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            patientPanel.ResumeLayout(false);
            patientFieldsLayout.ResumeLayout(false);
            navigationPanel.ResumeLayout(false);
            contentPanel.ResumeLayout(false);
            sectionsLayout.ResumeLayout(false);
            actionPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void AddPatientField(string labelText, out TextBox textBox, int column, int row, string placeholder, int columnSpan = 1, bool showCalendarButton = false)
        {
            var field = new TableLayoutPanel { ColumnCount = 1, RowCount = 2, Dock = DockStyle.Fill, Padding = new Padding(4, 0, 4, 0), RightToLeft = RightToLeft.Yes };
            field.RowStyles.Add(new RowStyle(SizeType.Percent, 48F));
            field.RowStyles.Add(new RowStyle(SizeType.Percent, 52F));
            var label = new Label { Text = labelText, Dock = DockStyle.Fill, ForeColor = Color.FromArgb(43, 31, 118), Font = new Font("Tahoma", 8.5F, FontStyle.Bold), TextAlign = ContentAlignment.MiddleRight, RightToLeft = RightToLeft.Yes };
            textBox = new TextBox { Dock = DockStyle.Fill, BorderStyle = BorderStyle.FixedSingle, PlaceholderText = placeholder, RightToLeft = RightToLeft.Yes, Margin = new Padding(0, 1, 0, 2) };
            field.Controls.Add(label, 0, 0);
            if (showCalendarButton)
            {
                var dateEntryPanel = new Panel { Dock = DockStyle.Fill, RightToLeft = RightToLeft.Yes, Margin = new Padding(0, 1, 0, 2) };
                var calendarButton = new Button { Text = "▦", Dock = DockStyle.Left, Width = 30, FlatStyle = FlatStyle.Flat, ForeColor = Color.FromArgb(98, 38, 205), BackColor = Color.White, Margin = Padding.Empty, TabStop = false };
                calendarButton.FlatAppearance.BorderColor = Color.FromArgb(210, 204, 240);
                textBox.Dock = DockStyle.Fill;
                textBox.Margin = Padding.Empty;
                dateEntryPanel.Controls.Add(textBox);
                dateEntryPanel.Controls.Add(calendarButton);
                field.Controls.Add(dateEntryPanel, 0, 1);
            }
            else
            {
                field.Controls.Add(textBox, 0, 1);
            }
            patientFieldsLayout.Controls.Add(field, column, row);
            patientFieldControls.Add(field);
            if (columnSpan > 1)
                patientFieldColumnSpans[field] = columnSpan;
        }

        private void AddChoiceField(string labelText, string[] choices, int column, int row)
        {
            var field = new TableLayoutPanel { ColumnCount = 1, RowCount = 2, Dock = DockStyle.Fill, Padding = new Padding(4, 0, 4, 0), RightToLeft = RightToLeft.Yes };
            field.RowStyles.Add(new RowStyle(SizeType.Percent, 48F));
            field.RowStyles.Add(new RowStyle(SizeType.Percent, 52F));
            field.Controls.Add(new Label { Text = labelText, Dock = DockStyle.Fill, ForeColor = Color.FromArgb(43, 31, 118), Font = new Font("Tahoma", 8.5F, FontStyle.Bold), TextAlign = ContentAlignment.MiddleRight, RightToLeft = RightToLeft.Yes }, 0, 0);
            var choicePanel = new FlowLayoutPanel { Dock = DockStyle.Fill, FlowDirection = FlowDirection.RightToLeft, WrapContents = false, RightToLeft = RightToLeft.Yes };
            foreach (var choice in choices)
                choicePanel.Controls.Add(new RadioButton { Text = choice, AutoSize = true, Margin = new Padding(3, 2, 6, 1), RightToLeft = RightToLeft.Yes });
            field.Controls.Add(choicePanel, 0, 1);
            patientFieldsLayout.Controls.Add(field, column, row);
        }

        private Button CreateNavigationButton(string text, Color? color = null)
        {
            var button = new Button
            {
                Text = text,
                BackColor = color ?? Color.FromArgb(9, 74, 105),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Tahoma", 8F, FontStyle.Bold),
                Dock = DockStyle.None,
                Width = 215,
                Height = 42,
                Margin = new Padding(2),
                Cursor = Cursors.Hand
            };
            button.FlatAppearance.BorderColor = Color.FromArgb(222, 226, 255);
            button.FlatAppearance.BorderSize = 1;
            button.Click += NavigationButton_Click;
            return button;
        }

        private Control CreateSection(string title, string[] options, string detailLabel)
        {
            var card = new Panel { BackColor = Color.White, BorderStyle = BorderStyle.FixedSingle, Dock = DockStyle.Fill, Margin = new Padding(2), Padding = new Padding(6), RightToLeft = RightToLeft.Yes };
            var layout = new TableLayoutPanel { ColumnCount = 1, RowCount = 3, Dock = DockStyle.Fill, RightToLeft = RightToLeft.Yes };
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            var titleLabel = new Label { Text = title, Dock = DockStyle.Fill, BackColor = Color.FromArgb(243, 238, 255), ForeColor = Color.FromArgb(74, 31, 167), Font = new Font("Tahoma", 9F, FontStyle.Bold), TextAlign = ContentAlignment.MiddleRight, Padding = new Padding(4, 0, 6, 0), RightToLeft = RightToLeft.Yes };
            var optionsPanel = new FlowLayoutPanel { Dock = DockStyle.Fill, FlowDirection = FlowDirection.RightToLeft, WrapContents = true, AutoScroll = true, Padding = new Padding(2), RightToLeft = RightToLeft.Yes };
            foreach (var option in options)
                optionsPanel.Controls.Add(new CheckBox { Text = option, AutoSize = true, ForeColor = Color.FromArgb(36, 38, 67), Margin = new Padding(4, 2, 4, 2), RightToLeft = RightToLeft.Yes, Font = new Font("Tahoma", 8F) });
            var detailBox = new TextBox { Dock = DockStyle.Fill, PlaceholderText = detailLabel, BorderStyle = BorderStyle.FixedSingle, RightToLeft = RightToLeft.Yes, Margin = new Padding(0, 2, 0, 0), Font = new Font("Tahoma", 8F) };
            layout.Controls.Add(titleLabel, 0, 0);
            layout.Controls.Add(optionsPanel, 0, 1);
            layout.Controls.Add(detailBox, 0, 2);
            card.Controls.Add(layout);
            return card;
        }

        private Button CreateActionButton(string text, Color color, EventHandler handler)
        {
            var button = new Button { Text = text, BackColor = color, ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Font = new Font("Tahoma", 8.5F, FontStyle.Bold), Width = 108, Height = 42, Margin = new Padding(3), Cursor = Cursors.Hand, RightToLeft = RightToLeft.Yes };
            button.FlatAppearance.BorderSize = 0;
            if (handler != null)
                button.Click += handler;
            return button;
        }
    }
}
