using Event_Tasks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventTasks
{
    public partial class main_menu : Form
    {
        // 日付取得
        DateTime dt = DateTime.Now;　// 現在の日付
        int BetweenMonth = 0; // 選択月の間

        // 動的に追加するツール
        private Label[] CalendarDays;

        // アクセスページ
        new_task_list NewTask = new new_task_list();

        public main_menu()
        {
            CalendarDays = new Label[42]; // 初期化コンストラクタ
            edit_calendar(dt.Date);
            InitializeComponent();
        }

        private void events_task_Load(object sender, EventArgs e)
        {
            monthly.Text = dt.ToString("yyyy.MM");
            present_month_btn.Text = dt.Day.ToString("d");
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

        // カレンダー生成
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
                string due_day_list = DaySelectTaskDB(currentDay.ToString());
                // カレンダーのデフォルト設定
                if (currentDay.ToString() == due_day_list)
                {
                    CalendarDays[i] = new LinkLabel
                    {
                        Name = "day_label" + (i + 1),
                        Text = currentDay.Day.ToString("d"),
                        Font = new Font("Century Gothic", 15.00F, FontStyle.Bold, GraphicsUnit.Point, 0),
                        ActiveLinkColor = Color.DarkOrange,
                        ForeColor = Color.DarkBlue,
                        BackColor = Color.Transparent,
                        BorderStyle = BorderStyle.FixedSingle,
                        Size = new Size(80, 60),
                        Location = new Point(110 + 80 * (i % 7), 80 + 60 * (i / 7)),
                        LinkVisited = false,
                    };
                    CalendarDays[i].Click += new EventHandler(CalendarDays_Click);
                }
                else
                {
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
                }

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

        private void CalendarDays_Click(object sender, EventArgs e)
        {
            LinkLabel clickedLabel = sender as LinkLabel;
            if (clickedLabel != null)
            {
                // 日付を取得
                int select_d = Int32.Parse(clickedLabel.Text);
                DateTime select_date = dt.AddMonths(BetweenMonth);
                select_date = new DateTime(select_date.Year, select_date.Month, select_d);
                // Console.WriteLine(select_date.ToString("yyyy.MM.dd"));
 
                show_task_list ShowTask = new show_task_list(select_date);
                this.Hide();
                ShowTask.ShowDialog();
                this.Show();
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
            NewTask.ShowDialog();
            this.Show();
        }

        private void event_btn_Click(object sender, EventArgs e)
        {

        }

        private void consumable_btn_Click(object sender, EventArgs e)
        {

        }

        public string DaySelectTaskDB(string dayFormat)
        {
            string connectString = "Data Source=WIN-DN6B589V2SO\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
            string due_day = "";

            using (SqlConnection connection = new SqlConnection(connectString))
            {
                try
                {
                    // データベース接続開始
                    connection.Open();
                    var query = "SELECT user_id, task_title, due_date, task_priority " +
                                "FROM event_tasks.dbo.task " +
                                "WHERE user_id = 1 " +
                                string.Format("AND due_date = '{0}'", dayFormat);

                    var count_query = "SELECT COUNT(*) " +
                                      "FROM event_tasks.dbo.task " +
                                      "WHERE user_id = 1 " +
                                      string.Format("AND due_date = '{0}'", dayFormat);

                    SqlCommand count_cmd = new SqlCommand(count_query, connection);
                    
                    SqlCommand cmd = new SqlCommand(query, connection);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // データの取得
                        while (reader.Read())
                        {
                            due_day = reader["due_date"].ToString();
                            // Console.WriteLine($"{reader["task_title"]}, {reader["due_date"]}, {reader["task_priority"]}");
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                finally
                {
                    connection.Close();
                }
            }
            return due_day;
        }
    }
}
