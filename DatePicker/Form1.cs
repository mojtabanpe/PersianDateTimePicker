using System;
using System.Windows.Forms;
using ExtensionsMethod;

namespace DatePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            dropdown1.inputMask = "0000/00/00";
            dropdown1.Value = DateTime.Now.ToString("yyyy/MM/dd");
            dropdown1.RightToLeft = RightToLeft.No;
            dropdown1.OnValueChanged += (obj, args) => { dropdown1.Tag = dropdown1.Value.ConvertToDate(); };
            dropdown1.getDropdownControl += () =>
            {
                var picker = new DateTimePicker();
                picker.OnDateDoubleClick += (obj, args) => { dropdown1.closeDropdown(); };

                if (dropdown1.Tag != null) picker.SelectedDate = (DateTime) dropdown1.Tag;
                picker.OnSelectedDateChanged += (s, args) =>
                {
                    dropdown1.Value = picker.SelectedDate.ToString("yyyy/MM/dd");
                    dropdown1.Tag = picker.SelectedDate;
                };
                return picker;
            };
            base.OnLoad(e);
        }
    }
}