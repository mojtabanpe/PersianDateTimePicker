using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace DatePicker
{
    public partial class DateTimePicker : UserControl
    {
        private int _currentMonth = 0;

        private int _currentYear = 0;

        public EventHandler OnDateDoubleClick;

        public EventHandler OnSelectedDateChanged;

        public DateTimePicker()
        {
            InitializeComponent();

            dgv_Calenar.CurrentCellChanged += Dgv_Calenar_CurrentCellChanged;
            dgv_Calenar.CellDoubleClick += Dgv_Calenar_CellDoubleClick;
            SelectedDate = DateTime.Now;
        }

        public DateTime SelectedDate { get; set; }

        private void Dgv_Calenar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (OnDateDoubleClick != null) OnDateDoubleClick(this, new EventArgs());
        }

        private void Dgv_Calenar_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgv_Calenar.CurrentCell != null && dgv_Calenar.CurrentCell.Tag != null)
            {
                SelectedDate = (DateTime) dgv_Calenar.CurrentCell.Tag;
                lbl_SelectedDate.Text = ((DateTime) dgv_Calenar.CurrentCell.Tag).ToString("dddd dd MMM yyyy");
                OnSelectedDateChanged?.Invoke(this, new EventArgs());
            }
        }

        private void FillGridDays(int year, int month)
        {
            dgv_Calenar.Rows.Clear();

            _currentYear = year;
            _currentMonth = month;

            var calendar = new PersianCalendar();

            lbl_CurrentCalendarDate.Text = new DateTime(year, month, 1, calendar).ToString("MMM yyyy");

            var todayMonthDay = calendar.GetDayOfMonth(DateTime.Now);
            var todayYear = calendar.GetYear(DateTime.Now);
            var todayMonth = calendar.GetMonth(DateTime.Now);

            var lastMonthDays =
                month == 1 ? calendar.GetDaysInMonth(year - 1, 12) : calendar.GetDaysInMonth(year, month - 1);
            var currentMonthDays = calendar.GetDaysInMonth(year, month);
            var fristDayOfWeek = calendar.GetDayOfWeek(new DateTime(year, month, 1, calendar));
            var fristDayOfWeekIndex = 0;
            if (fristDayOfWeek == DayOfWeek.Saturday)

                fristDayOfWeekIndex = 0;

            else

                fristDayOfWeekIndex = (int) fristDayOfWeek + 1;

            var rowIndex = 0;
            var cellIndex = 0;
            dgv_Calenar.Rows.Add(1);

            var lastMonthStartDate = lastMonthDays - fristDayOfWeekIndex + 1;

            for (var dayIndex = lastMonthStartDate; dayIndex <= lastMonthDays; dayIndex++)
            {
                dgv_Calenar.Rows[rowIndex].Cells[cellIndex].Tag = new DateTime(month == 1 ? year - 1 : year,
                    month == 1 ? 12 : month - 1, dayIndex, calendar);
                dgv_Calenar.Rows[rowIndex].Cells[cellIndex].Value = dayIndex;
                dgv_Calenar.Rows[rowIndex].Cells[cellIndex++].Style.ForeColor = Color.SlateGray;
            }

            var SelectedDateExists = false;

            for (var dayIndex = 1; dayIndex <= currentMonthDays; dayIndex++)
            {
                dgv_Calenar.Rows[rowIndex].Cells[cellIndex].Value = dayIndex;
                dgv_Calenar.Rows[rowIndex].Cells[cellIndex].Tag = new DateTime(year, month, dayIndex, calendar);

                var currentCell = new DateTime(year, month, dayIndex, calendar);

                if (dayIndex == todayMonthDay && month == todayMonth && year == todayYear)
                {
                    dgv_Calenar.Rows[rowIndex].Cells[cellIndex].Style.BackColor = Color.Gray;
                    dgv_Calenar.Rows[rowIndex].Cells[cellIndex].Style.ForeColor = Color.White;
                }

                if (currentCell.Year == SelectedDate.Year && currentCell.Month == SelectedDate.Month &&
                    currentCell.Day == SelectedDate.Day)
                {
                    OnSelectedDateChanged?.Invoke(this, new EventArgs());
                    dgv_Calenar.Rows[rowIndex].Cells[cellIndex].Selected = SelectedDateExists = true;
                }

                cellIndex++;
                {
                    if (cellIndex > 6)
                    {
                        cellIndex = 0;
                        rowIndex++;

                        dgv_Calenar.Rows.Add(1);
                    }
                }
            }

            var nextMonthDay = 1;
            if (cellIndex > 0)
                for (var dayIndex = cellIndex; dayIndex <= 6; dayIndex++)
                {
                    dgv_Calenar.Rows[rowIndex].Cells[cellIndex].Tag = new DateTime(month == 12 ? year + 1 : year,
                        month == 12 ? 1 : month + 1, dayIndex, calendar);

                    dgv_Calenar.Rows[rowIndex].Cells[cellIndex].Value = nextMonthDay++;
                    dgv_Calenar.Rows[rowIndex].Cells[cellIndex++].Style.ForeColor = Color.SlateGray;
                }

            foreach (var row in dgv_Calenar.Rows.OfType<DataGridViewRow>()) row.Height = 20;
            if (!SelectedDateExists)
                dgv_Calenar.CurrentCell = null;
        }

        private void DateTimePicker_Load(object sender, EventArgs e)
        {
            var calendar = new PersianCalendar();
            FillGridDays(calendar.GetYear(SelectedDate), calendar.GetMonth(SelectedDate));
        }

        private void btn_NextYear_Click(object sender, EventArgs e)
        {
            FillGridDays(_currentYear + 1, _currentMonth);
        }

        private void btn_LastYear_Click(object sender, EventArgs e)
        {
            FillGridDays(_currentYear - 1, _currentMonth);
        }

        private void btn_NextMonth_Click(object sender, EventArgs e)
        {
            FillGridDays(_currentMonth == 12 ? _currentYear + 1 : _currentYear,
                _currentMonth == 12 ? 1 : _currentMonth + 1);
        }

        private void btn_LastMonth_Click(object sender, EventArgs e)
        {
            FillGridDays(_currentMonth == 1 ? _currentYear - 1 : _currentYear,
                _currentMonth == 1 ? 12 : _currentMonth - 1);
        }

        private void btn_SelecedDate_Click(object sender, EventArgs e)
        {
            var calendar = new PersianCalendar();
            FillGridDays(calendar.GetYear(SelectedDate), calendar.GetMonth(SelectedDate));
        }

        private void btn_GoToToday_Click(object sender, EventArgs e)
        {
            var calendar = new PersianCalendar();
            FillGridDays(calendar.GetYear(DateTime.Now), calendar.GetMonth(DateTime.Now));
        }
    }
}