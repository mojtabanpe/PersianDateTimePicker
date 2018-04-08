using System;
using System.Drawing;
using System.Windows.Forms;

namespace DatePicker
{
    public partial class Dropdown : UserControl
    {
        private Form dropdownForm;

        public Func<Control> getDropdownControl;

        public Dropdown()
        {
            InitializeComponent();
            txtInputDropdown.TextChanged += TxtInputDropdown_TextChanged;
        }

        public string Value
        {
            get => txtInputDropdown.Text;
            set => txtInputDropdown.Text = value;
        }

        public string inputMask
        {
            get => txtInputDropdown.Mask;
            set => txtInputDropdown.Mask = value;
        }

        public event EventHandler OnValueChanged;

        private void TxtInputDropdown_TextChanged(object sender, EventArgs e)
        {
            if (OnValueChanged != null) OnValueChanged(this, new EventArgs());
        }

        private void btnDropdown_Click(object sender, EventArgs e)
        {
            dropdownForm = new Form();
            dropdownForm.FormBorderStyle = FormBorderStyle.None;
            dropdownForm.BackColor = Color.Gainsboro;
            var screenLocation = PointToScreen(Point.Empty);
            dropdownForm.Width = 497;
            dropdownForm.Height = 215;
            dropdownForm.ShowInTaskbar = false;
            dropdownForm.TopMost = true;
            if (getDropdownControl != null)
            {
                var control = getDropdownControl();
                dropdownForm.Controls.Add(control);
                control.Dock = DockStyle.Fill;
            }

            dropdownForm.Show();
            dropdownForm.Deactivate += (s, args) =>
            {
                dropdownForm.Close();
                dropdownForm = null;
            };
            screenLocation.Y += Height;
            screenLocation.X = screenLocation.X + (Width - dropdownForm.Width);
            dropdownForm.Location = screenLocation;
        }

        public void closeDropdown()
        {
            if (dropdownForm != null) dropdownForm.Close();
        }
    }
}