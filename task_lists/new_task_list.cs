using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Tasks
{
    public partial class new_task_list : Form
    {
        // 動的に追加するツール
        private List<TextBox> TaskTitleTextBox = new List<TextBox>();
        private List<NumericUpDown> PriorityBox = new List<NumericUpDown>();
        private List<DateTimePicker> DueDataBox = new List<DateTimePicker>();
        private List<Button> DelTaskButton = new List<Button>();
        private List<Label> TaskNumLabel = new List<Label>();


        int task_num = 0;

        public new_task_list()
        {
            InitializeComponent();
        }

        private void task_list_Load(object sender, EventArgs e)
        {
            AddToolList(task_num);
        }

        private void set_task_btn_Click(object sender, EventArgs e)
        {
            task_num++;
            AddToolList(task_num);
        }

        private void del_task_btn_Click(Object sender, EventArgs e)
        {
            string tmp_title = "";
            DateTime tmp_due = DateTime.Now;
            int tmp_priority = 1;

            int index = getArrayIndex(sender);

            // 2つ以上の時
            if (index > -1)
            {
                TaskTitleTextBox[index].Text = "";
                PriorityBox[index].Value = 1;
                DueDataBox[index].Value = DateTime.Now;

                // 削除する行を一番後ろへ
                for (int i = index; i < task_num; i++)
                {
                    TaskTitleTextBox[i].Text = TaskTitleTextBox[i + 1].Text;
                    TaskTitleTextBox[i + 1].Text = tmp_title;
                    tmp_title = TaskTitleTextBox[i].Text;

                    PriorityBox[i].Value = PriorityBox[i + 1].Value;
                    PriorityBox[i + 1].Value = tmp_priority;
                    tmp_priority = (int)PriorityBox[i].Value;

                    DueDataBox[i].Value = DueDataBox[i + 1].Value;
                    DueDataBox[i + 1].Value = tmp_due;
                    tmp_due = DueDataBox[i].Value;
                }
            }

            // 1つの状態で削除ボタンを押したとき
            if (task_num >= -1)
            {
                TaskTitleTextBox[task_num].Text = "";
                PriorityBox[task_num].Value = 1;
                DueDataBox[task_num].Value = DateTime.Now;

                Controls.Remove(TaskTitleTextBox[task_num]);
                Controls.Remove(PriorityBox[task_num]);
                Controls.Remove(DueDataBox[task_num]);
                Controls.Remove(DelTaskButton[task_num]);
                Controls.Remove(TaskNumLabel[task_num]);
                task_num--;
            }
        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            reset_tool();
        }
        
        // 配列番号の取得
        private int getArrayIndex(object sender)
        {
            int ary_index = -1;
            for (int i = 0; i < task_num; i++)
            {
                if (DelTaskButton[i].Equals(sender))
                {
                    ary_index = i;
                    break;
                }
            }
            return ary_index;
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
            DelTaskButton[index].Click += new EventHandler(del_task_btn_Click);

            // Controlsに追加
            Controls.Add(TaskTitleTextBox[index]);
            Controls.Add(PriorityBox[index]);
            Controls.Add(DueDataBox[index]);
            Controls.Add(DelTaskButton[index]);
            Controls.Add(TaskNumLabel[index]);
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < task_num + 1; i++) 
                {
                    database_insert(1, TaskTitleTextBox[i].Text, DueDataBox[i].Value, (int)PriorityBox[i].Value);
                }
                MessageBox.Show("saved completion.");
                reset_tool();
                this.Close();
            }

            catch (Exception ex) {
                MessageBox.Show("An error occurred while saving tasks: " + ex.Message);
            }
        }

        private void reset_tool()
        {
            // Controlsで削除
            for (int i = 0; i <= task_num; i++)
            {
                Controls.Remove(TaskTitleTextBox[i]);
                Controls.Remove(PriorityBox[i]);
                Controls.Remove(DueDataBox[i]);
                Controls.Remove(DelTaskButton[i]);
                Controls.Remove(TaskNumLabel[i]);
            }

            // Listをリセット
            TaskNumLabel.Clear();
            TaskTitleTextBox.Clear();
            PriorityBox.Clear();
            DueDataBox.Clear();
            DelTaskButton.Clear();

            task_num = 0;
            this.Close();
        }

        private void database_insert(int user_id, string task_title, DateTime due_data, int task_priority)
        {
            string connectString = "Data Source=WIN-DN6B589V2SO\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

            using (SqlConnection connection = new SqlConnection(connectString))
            {
                try
                {
                    // データベース接続開始
                    connection.Open();

                    for (int i = 0; i < task_num + 1; i++)
                    {
                        var query_set = string.Format("SET @user_id = {0};", 1) +
                                        string.Format("SET @task_title ='{0}';", TaskTitleTextBox[i].Text) +
                                        string.Format("SET @due_date ='{0}';", DueDataBox[i].Value.ToString("yyyy-MM-dd")) +
                                        string.Format("SET @task_priority = {0};", PriorityBox[i].Value);

                        var query_insert = "INSERT INTO event_tasks.dbo.task(user_id, task_title, due_date, task_priority)" +
                                           "VALUES(@user_id, @task_title, @due_date, @task_priority);";

                        var query = query_set + query_insert;

                        var id_query = "SELECT CAST(SCOPE_IDENTITY() AS int);";

                        using (var transaction = connection.BeginTransaction())
                        using (SqlCommand cmd = new SqlCommand(query) { Connection = connection, Transaction = transaction })
                        {
                            var id = id_query;
                            // データベースコマンドセット
                            try
                            {
                                // コマンドセット
                                cmd.CommandText = query;
                                cmd.Parameters.Add(new SqlParameter("@user_id", user_id));
                                cmd.Parameters.Add(new SqlParameter("@task_title", task_title));
                                cmd.Parameters.Add(new SqlParameter("@due_date", due_data));
                                cmd.Parameters.Add(new SqlParameter("@task_priority", task_priority));
                                // コマンド実行
                                cmd.ExecuteNonQuery();
                                // コミット
                                transaction.Commit();
                            }
                            catch
                            {
                                // ロールバック
                                transaction.Rollback();
                                throw;
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }
                finally
                { 
                    // データベース接続終了
                    connection.Close();
                }
            }
        }
    }
}
