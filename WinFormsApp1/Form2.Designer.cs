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
            // navigationPanel
            navigationPanel.BackColor = Color.Transparent;
            navigationPanel.Dock = DockStyle.Fill;
            navigationPanel.Margin = new Padding(0, 0, 0, 8);
            navigationPanel.Padding = new Padding(0);
            navigationPanel.RightToLeft = RightToLeft.Yes;
            navigationPanel.FlowDirection = FlowDirection.RightToLeft;
            navigationPanel.WrapContents = true;
            navigationPanel.AutoScroll = false;
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
            // actionPanel
            actionPanel.BackColor = Color.White;
            actionPanel.Dock = DockStyle.Fill;
            actionPanel.Padding = new Padding(6, 4, 6, 4);
            actionPanel.RightToLeft = RightToLeft.No;
            actionPanel.FlowDirection = FlowDirection.LeftToRight;
            actionPanel.WrapContents = false;
            actionPanel.AutoScroll = false;
            Controls.Add(rootLayout);
            Resize += Form2_Resize;
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

    }
}
