using EventTasks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
    public partial class show_task_list : Form
    {
        // アクセスページ
        main_menu menu = new main_menu();
        new_task_list new_task = new new_task_list();
        edit_task_list edit_task = new edit_task_list();

        // 検索結果格納リスト
        private List<string> TaskTitle = new List<string>();
        private List<string> TaskDueDate = new List<string>();
        private List<string> TaskPriority = new List<string>();

        // 動的に追加するツール
        private List<Label> TaskNumLabel = new List<Label>();
        private List<Label> TaskTitleLabel = new List<Label>();
        private List<Label> PriorityLabel = new List<Label>();
        private List<Label> DueDateLabel = new List<Label>();
        private List<Button> DelTaskButton = new List<Button>();

        int show_task_num = 0;

        public show_task_list(string text, DateTime[] dates)
        {
            InitializeComponent();


        }
        private void task_list_Load(object sender, EventArgs e)
        {
            database_select();
            menu.DaySelectTaskDB("3");
            label_set();
        }

        private void set_task_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new_task.ShowDialog();
            this.Show();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            edit_task.ShowDialog();
            this.Show();
        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void database_select()
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
                                "WHERE user_id = 1 AND ";

                    var count_query = "SELECT COUNT(*) " +
                                      "FROM event_tasks.dbo.task " +
                                      "WHERE user_id = 1";
                    
                    SqlCommand count_cmd = new SqlCommand(count_query, connection);
                    show_task_num = (int)count_cmd.ExecuteScalar();
                    
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
                finally { 
                    connection.Close();
                }
            }
        }

        private void label_set()
        {
            for (int i = 0; i < show_task_num; i++)
            {
                AddToolList(i);
                TaskTitleLabel[i].Text = TaskTitle[i];
                DueDateLabel[i].Text = TaskDueDate[i];
                PriorityLabel[i].Text = TaskPriority[i];
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

            TaskTitleLabel.Add(new Label
            {
                Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0),
                Location = new Point(50, 70 + (21 * index)),
                Name = "task_text_box" + index,
                Size = new Size(300, 21)
            });

            PriorityLabel.Add(new Label
            {
                Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0),
                Location = new Point(450, 70 + (21 * index)),
                Name = "priority_box" + index,
                Size = new Size(70, 21),
                TextAlign = ContentAlignment.MiddleCenter
            });

            DueDateLabel.Add(new Label
            {
                Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0),
                Location = new Point(350, 70 + (21 * index)),
                Name = "due_data_box" + index,
                Size = new Size(100, 21),
                TextAlign = ContentAlignment.MiddleCenter
            });

            DelTaskButton.Add(new Button
            {
                BackColor = Color.Red,
                Cursor = Cursors.Default,
                ForeColor = SystemColors.Control,
                Location = new Point(540, 70 + (21 * index)),
                Name = "del_task_btn" + index,
                Size = new Size(21, 21),
                Text = "✔",
                UseVisualStyleBackColor = false,
            });

            // Controlsに追加
            Controls.Add(TaskTitleLabel[index]);
            Controls.Add(PriorityLabel[index]);
            Controls.Add(DueDateLabel[index]);
            Controls.Add(DelTaskButton[index]);
            Controls.Add(TaskNumLabel[index]);
        }
    }
}
