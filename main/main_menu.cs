using Event_Tasks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventTasks
{
    public partial class main_menu : Form
    {
        DateTime dt = DateTime.Now;
        int BetweenMonth = 0;

        // 動的に追加するツール
        private Label[] CalendarDays;

        // アクセスページ
        show_task_list show_task = new show_task_list(); 
        public main_menu()
        {
            CalendarDays = new Label[42]; // 初期化コンストラクタ
            InitializeComponent();
        }

        private void events_task_Load(object sender, EventArgs e)
        {
            monthly.Text = dt.ToString("yyyy.MM");
            present_month_btn.Text = dt.Day.ToString("d");
            edit_calendar(dt.Date);
        }

        private void prev_btn_Click(object sender, EventArgs e)
        {
            BetweenMonth--;
            DateTime prev_month = dt.AddMonths(BetweenMonth);
            monthly.Text = prev_month.ToString("yyyy.MM");
            edit_calendar(prev_month);
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            BetweenMonth++;
            DateTime next_month = dt.AddMonths(BetweenMonth);
            monthly.Text = next_month.ToString("yyyy.MM");
            edit_calendar(next_month);
        }

        private void edit_calendar(DateTime view_month)
        {
            DateTime firstday = new DateTime(view_month.Year, view_month.Month, 1);
            int firstday_week = (int)firstday.DayOfWeek;

            for (int i = 0; i < 42; i++)
            {
                if (CalendarDays[i] != null)
                {        
                    // カレンダーリセット
                    Controls.Remove(CalendarDays[i]);
                }
            }

            for (int i = 0; i < 42; i++)
            {
                DateTime currentDay = firstday.AddDays(i - firstday_week);
                // カレンダーのデフォルト設定
                CalendarDays[i] = new Label
                {
                    Name = "day_label" + (i + 1),
                    Text = currentDay.Day.ToString("d"),
                    AutoSize = false,
                    Font = new Font("Century Gothic", 12.00F, FontStyle.Regular, GraphicsUnit.Point, 0),
                    ForeColor = SystemColors.ControlText,
                    BackColor = Color.Transparent,
                    BorderStyle = BorderStyle.FixedSingle,
                    Size = new Size(80, 60),
                    Location = new Point(110 + 80 * (i % 7), 80 + 60 * (i / 7))
                };

                // 曜日ごとのテキストカラーの色付け
                // 表示月であるとき
                if (currentDay.Month == view_month.Month)
                {
                    switch (currentDay.DayOfWeek)
                    {
                        case DayOfWeek.Saturday:
                            CalendarDays[i].ForeColor = Color.MediumBlue;
                            break;
                        case DayOfWeek.Sunday:
                            CalendarDays[i].ForeColor = Color.Red;
                            break;
                        default:
                            CalendarDays[i].ForeColor = SystemColors.ControlText;
                            break;
                    }
                }
                // 表示月でないとき
                else
                {
                    switch (currentDay.DayOfWeek)
                    {
                        case DayOfWeek.Saturday:
                            CalendarDays[i].ForeColor = Color.LightSteelBlue;
                            break;
                        case DayOfWeek.Sunday:
                            CalendarDays[i].ForeColor = Color.LightCoral;
                            break;
                        default:
                            CalendarDays[i].ForeColor = SystemColors.ControlDark;
                            break;
                    }
                }

                // 日付が今日の場合
                if (currentDay.Date == dt.Date)
                {
                    CalendarDays[i].Font = new Font("Century Gothic", 16.00F, FontStyle.Bold, GraphicsUnit.Point, 0);
                    CalendarDays[i].ForeColor = Color.Goldenrod;
                }

                // カレンダー生成
                Controls.Add(CalendarDays[i]);
            }
        }

        private void present_month_btn_Click(object sender, EventArgs e)
        {
            BetweenMonth = 0;
            DateTime present_month = dt.AddMonths(BetweenMonth);
            monthly.Text = present_month.ToString("yyyy.MM");
            edit_calendar(present_month);
        }
        private void task_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            show_task.ShowDialog();
            this.Show();
        }

        private void event_btn_Click(object sender, EventArgs e)
        {

        }

        private void consumable_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
