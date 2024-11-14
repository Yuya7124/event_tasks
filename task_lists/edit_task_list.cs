using EventTasks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Tasks
{
    public partial class edit_task_list : Form
    {
        int EditTaskNum = 0;
        DateTime EditDate = DateTime.Now;

        // アクセスページ
        // show_task_list ShowTask = new show_task_list(EditDate);
        main_menu tl_Menu = new main_menu();

        // 検索結果格納リスト
        private List<string> TaskTitle = new List<string>();
        private List<string> TaskDueDate = new List<string>();
        private List<string> TaskPriority = new List<string>();

        // 動的に追加するツール
        private List<TextBox> TaskTitleTextBox = new List<TextBox>();
        private List<NumericUpDown> PriorityBox = new List<NumericUpDown>();
        private List<DateTimePicker> DueDataBox = new List<DateTimePicker>();
        private List<Button> DelTaskButton = new List<Button>();
        private List<Label> TaskNumLabel = new List<Label>();

        public edit_task_list()
        {
            InitializeComponent();
        }

        private void task_list_Load(object sender, EventArgs e)
        {
            database_select(EditDate.ToString());
            tl_Menu.DaySelectTaskDB(EditDate.ToString());
            task_edit_date.Text = EditDate.ToString("yyyy / MM / dd");
            textbox_set();
        }

        private void set_task_btn_Click(object sender, EventArgs e)
        {

        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void database_select(string dayFormat)
        {
            string connectString = "Data Source=WIN-DN6B589V2SO\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

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
                    int ShowTaskNum = (int)count_cmd.ExecuteScalar();

                    SqlCommand cmd = new SqlCommand(query, connection);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // データの取得
                        while (reader.Read())
                        {
                            TaskTitle.Add(reader["task_title"] as string);
                            TaskDueDate.Add(reader["due_date"].ToString());
                            TaskPriority.Add(reader["task_priority"].ToString());
                            Console.WriteLine($"{reader["task_title"]}, {reader["due_date"]}, {reader["task_priority"]}");
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
        }

        private void textbox_set()
        {
            for (int i = 0; i < EditTaskNum; i++)
            {
                AddToolList(i);
                TaskTitleTextBox[i].Text = TaskTitle[i];
                DueDataBox[i].Text = TaskDueDate[i];
                PriorityBox[i].Text = TaskPriority[i];
            }
        }

        // ツール配列のスタイル
        private void AddToolList(int index)
        {
            TaskNumLabel.Add(new Label
            {
                Font = new Font("Century Gothic", 12F, FontStyle.Bold),
                Location = new Point(25, 70 + (21 * index)),
                Name = "task_num_label" + index,
                Size = new Size(30, 21),
                Text = (index + 1).ToString(),
                TextAlign = ContentAlignment.MiddleCenter,
            });

            TaskTitleTextBox.Add(new TextBox
            {
                Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0),
                Location = new Point(50, 70 + (21 * index)),
                Name = "task_text_box" + index,
                Size = new Size(300, 21)
            });

            PriorityBox.Add(new NumericUpDown
            {
                Font = new Font("Century Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0),
                Location = new Point(450, 70 + (21 * index)),
                Maximum = new decimal(new int[] { 5, 0, 0, 0 }),
                Name = "priority_box" + index,
                Size = new Size(70, 21),
                TextAlign = HorizontalAlignment.Right,
                Value = new decimal(new int[] { 1, 0, 0, 0 })
            });

            DueDataBox.Add(new DateTimePicker
            {
                Cursor = Cursors.Default,
                Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0),
                Format = DateTimePickerFormat.Short,
                Location = new Point(350, 70 + (21 * index)),
                Name = "due_data_box" + index,
                RightToLeft = RightToLeft.No,
                Size = new Size(100, 21)
            });

            DelTaskButton.Add(new Button
            {
                BackColor = Color.Red,
                Cursor = Cursors.Default,
                ForeColor = SystemColors.Control,
                Location = new Point(530, 70 + (21 * index)),
                Name = "del_task_btn" + index,
                Size = new Size(21, 21),
                Text = "➖",
                UseVisualStyleBackColor = false
            });
            // DelTaskButton[index].Click += new EventHandler(del_btn_Click);

            // Controlsに追加
            Controls.Add(TaskTitleTextBox[index]);
            Controls.Add(PriorityBox[index]);
            Controls.Add(DueDataBox[index]);
            Controls.Add(DelTaskButton[index]);
            Controls.Add(TaskNumLabel[index]);
        }

        private void task_edit_date_Click(object sender, EventArgs e)
        {

        }
    }
}
