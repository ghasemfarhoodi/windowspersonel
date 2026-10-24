namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        private readonly List<Control> patientFieldControls = new();
        private readonly Dictionary<Control, int> patientFieldColumnSpans = new();

        public Form2()
        {
            InitializeComponent();
            BuildDynamicControls();
            Shown += (_, _) => ArrangeResponsiveLayout();
        }

        private void BuildDynamicControls()
        {
            AddPatientField("کد ملی", out nationalCodeTextBox, 0, 0, "کد ملی را وارد کنید");
            AddPatientField("کد پرونده", out _, 1, 0, "شماره پرونده");
            AddPatientField("نام", out _, 2, 0, "نام بیمار");
            AddPatientField("نام خانوادگی", out _, 3, 0, "نام خانوادگی");
            AddPatientField("تاریخ تولد", out _, 4, 0, "روز / ماه / سال", showCalendarButton: true);
            AddChoiceField("جنسیت", new[] { "مرد", "زن" }, 0, 1);
            AddChoiceField("وضعیت تأهل", new[] { "متأهل", "مجرد" }, 1, 1);
            AddPatientField("شغل", out _, 2, 1, "شغل بیمار");
            AddPatientField("شماره تماس", out _, 3, 1, "شماره تماس", columnSpan: 2);

            navigationPanel.Controls.Add(CreateNavigationButton("تشکیل پرونده", Color.FromArgb(245, 103, 35)));
            navigationPanel.Controls.Add(CreateNavigationButton("علائم و حال عمومی"));
            navigationPanel.Controls.Add(CreateNavigationButton("معاینات و پارامترها"));
            navigationPanel.Controls.Add(CreateNavigationButton("کنترل قند خون"));
            navigationPanel.Controls.Add(CreateNavigationButton("وضعیت سبک زندگی"));
            navigationPanel.Controls.Add(CreateNavigationButton("داروها و تغییرات"));
            navigationPanel.Controls.Add(CreateNavigationButton("برنامه و تصمیم امروز"));

            sectionsLayout.Controls.Add(CreateSection("دخانیات و آلرژی", new[] { "مصرف دخانیات: هرگز", "مصرف دخانیات: سابق", "مصرف دخانیات: فعلی", "آلرژی دارویی: ندارد", "آلرژی دارویی: دارد" }, "توضیحات دخانیات و آلرژی"), 0, 0);
            sectionsLayout.Controls.Add(CreateSection("سابقه خانوادگی و نوع دیابت", new[] { "دیابت", "بیماری قلبی", "فشار خون", "دیس‌لیپیدمی", "نوع یک", "نوع دو", "سایر" }, "شرح سابقه خانوادگی"), 1, 0);
            sectionsLayout.Controls.Add(CreateSection("سابقه دیابت", new[] { "سابقه کتواسیدوز دیابتی یا قند بسیار بالا", "سابقه افت قند خون", "سابقه بستری به‌علت دیابت" }, "سال تشخیص / مدت بیماری"), 0, 1);
            sectionsLayout.Controls.Add(CreateSection("بیماری‌های همراه", new[] { "فشار خون", "دیس‌لیپیدمی", "چاقی", "نارسایی قلب", "کبد چرب", "تیروئید", "کلیوی مزمن", "آپنه خواب", "سایر" }, "سایر بیماری‌های همراه"), 1, 1);
            sectionsLayout.Controls.Add(CreateSection("عوارض دیابت", new[] { "رتینوپاتی چشم", "بیماری عروق کرونر", "زخم پای دیابتی", "نفروپاتی کلیه", "سکته مغزی", "بدون عارضه شناخته‌شده", "نوروپاتی اعصاب" }, "شرح عوارض"), 0, 2);
            sectionsLayout.Controls.Add(CreateSection("درمان دیابت", new[] { "درمان با انسولین", "داروی خوراکی", "رژیم غذایی", "فعالیت بدنی" }, "سال شروع درمان"), 1, 2);

            actionPanel.Controls.Add(CreateActionButton("حذف", Color.FromArgb(232, 62, 75), DeleteButton_Click));
            actionPanel.Controls.Add(CreateActionButton("ذخیره", Color.FromArgb(101, 47, 210), SaveButton_Click));
            actionPanel.Controls.Add(CreateActionButton("ویرایش", Color.FromArgb(101, 47, 210), null));
            actionPanel.Controls.Add(CreateActionButton("جدید", Color.FromArgb(101, 47, 210), NewButton_Click));

            ArrangeResponsiveLayout();
        }

        private void Form2_Resize(object? sender, EventArgs e)
        {
            ArrangeResponsiveLayout();
        }

        private void ArrangeResponsiveLayout()
        {
            if (rootLayout == null || patientFieldsLayout == null || navigationPanel == null)
                return;

            var availableWidth = rootLayout.ClientSize.Width > 0
                ? rootLayout.ClientSize.Width
                : Math.Max(520, ClientSize.Width - 20);

            var columnCount = availableWidth >= 1320 ? 5
                : availableWidth >= 1080 ? 4
                : availableWidth >= 850 ? 3
                : availableWidth >= 620 ? 2
                : 1;

            patientFieldsLayout.SuspendLayout();
            patientFieldsLayout.Controls.Clear();
            patientFieldsLayout.ColumnStyles.Clear();
            patientFieldsLayout.RowStyles.Clear();
            patientFieldsLayout.ColumnCount = columnCount;
            foreach (Control control in patientFieldControls)
                patientFieldsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F / columnCount));

            var row = 0;
            var column = 0;
            foreach (var field in patientFieldControls)
            {
                var span = columnCount == 5 && patientFieldColumnSpans.TryGetValue(field, out var requestedSpan)
                    ? Math.Min(columnCount, requestedSpan)
                    : 1;

                if (column + span > columnCount)
                {
                    row++;
                    column = 0;
                }

                patientFieldsLayout.Controls.Add(field, column, row);
                if (span > 1)
                    patientFieldsLayout.SetColumnSpan(field, span);

                column += span;
                if (column >= columnCount)
                {
                    row++;
                    column = 0;
                }
            }

            var fieldRows = Math.Max(1, row + (column > 0 ? 1 : 0));
            patientFieldsLayout.RowCount = fieldRows;
            for (var i = 0; i < fieldRows; i++)
                patientFieldsLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            patientPanel.AutoScroll = columnCount == 1;
            patientFieldsLayout.Dock = columnCount == 1 ? DockStyle.Top : DockStyle.Fill;
            patientFieldsLayout.Height = fieldRows * 58;
            rootLayout.RowStyles[1].Height = columnCount == 1
                ? 230
                : 44 + fieldRows * 58;
            patientFieldsLayout.ResumeLayout(true);

            var navWidth = Math.Max(1, navigationPanel.ClientSize.Width);
            var navButtonWidth = Math.Clamp((navWidth - 28) / 7, 134, 215);
            foreach (Control control in navigationPanel.Controls)
                control.Width = navButtonWidth;

            var buttonsPerRow = Math.Max(1, (navWidth + 4) / (navButtonWidth + 4));
            var navRows = (int)Math.Ceiling(navigationPanel.Controls.Count / (double)buttonsPerRow);
            rootLayout.RowStyles[2].Height = navRows * 46;
            navigationPanel.PerformLayout();
            rootLayout.PerformLayout();
        }

        private void NavigationButton_Click(object? sender, EventArgs e)
        {
            if (sender is not Button selectedButton)
                return;

            foreach (var button in navigationPanel.Controls.OfType<Button>())
            {
                button.BackColor = Color.FromArgb(9, 74, 105);
                button.ForeColor = Color.White;
            }

            selectedButton.BackColor = Color.FromArgb(104, 41, 210);
            selectedButton.ForeColor = Color.White;
        }

        private void NewButton_Click(object? sender, EventArgs e)
        {
            foreach (var textBox in this.Controls.OfType<Control>().SelectMany(GetTextBoxes))
                textBox.Clear();

            foreach (var comboBox in this.Controls.OfType<Control>().SelectMany(GetComboBoxes))
                comboBox.SelectedIndex = -1;

            foreach (var radioButton in this.Controls.OfType<Control>().SelectMany(GetRadioButtons))
                radioButton.Checked = false;

            foreach (var checkBox in this.Controls.OfType<Control>().SelectMany(GetCheckBoxes))
                checkBox.Checked = false;

            nationalCodeTextBox.Focus();
        }

        private static IEnumerable<TextBox> GetTextBoxes(Control control)
        {
            if (control is TextBox textBox)
                yield return textBox;
            foreach (Control child in control.Controls)
                foreach (var descendant in GetTextBoxes(child))
                    yield return descendant;
        }

        private static IEnumerable<ComboBox> GetComboBoxes(Control control)
        {
            if (control is ComboBox comboBox)
                yield return comboBox;
            foreach (Control child in control.Controls)
                foreach (var descendant in GetComboBoxes(child))
                    yield return descendant;
        }

        private static IEnumerable<RadioButton> GetRadioButtons(Control control)
        {
            if (control is RadioButton radioButton)
                yield return radioButton;
            foreach (Control child in control.Controls)
                foreach (var descendant in GetRadioButtons(child))
                    yield return descendant;
        }

        private static IEnumerable<CheckBox> GetCheckBoxes(Control control)
        {
            if (control is CheckBox checkBox)
                yield return checkBox;
            foreach (Control child in control.Controls)
                foreach (var descendant in GetCheckBoxes(child))
                    yield return descendant;
        }

        private void SaveButton_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nationalCodeTextBox.Text))
            {
                MessageBox.Show("کد ملی بیمار را وارد کنید.", "اطلاعات ناقص", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                nationalCodeTextBox.Focus();
                return;
            }

            MessageBox.Show("اطلاعات فرم آماده است. برای ذخیره دائمی، اتصال به پایگاه داده لازم است.",
                "فرم بیمار", MessageBoxButtons.OK, MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
        }

        private void DeleteButton_Click(object? sender, EventArgs e)
        {
            if (MessageBox.Show("محتوای واردشده در فرم پاک شود؟", "پاک کردن فرم",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign) == DialogResult.Yes)
                NewButton_Click(sender, e);
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

        private Button CreateActionButton(string text, Color color, EventHandler? handler)
        {
            var button = new Button { Text = text, BackColor = color, ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Font = new Font("Tahoma", 8.5F, FontStyle.Bold), Width = 108, Height = 42, Margin = new Padding(3), Cursor = Cursors.Hand, RightToLeft = RightToLeft.Yes };
            button.FlatAppearance.BorderSize = 0;
            if (handler != null)
                button.Click += handler;
            return button;
        }
    }
}
