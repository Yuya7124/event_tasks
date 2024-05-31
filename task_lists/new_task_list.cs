using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
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

        private void del_btn_Click(Object sender, EventArgs e)
        {
            Controls.Remove(TaskTitleTextBox[task_num]);
            Controls.Remove(PriorityBox[task_num]);
            Controls.Remove(DueDataBox[task_num]);
            Controls.Remove(DelTaskButton[task_num]);
            Controls.Remove(TaskNumLabel[task_num]);
        }

        private void return_btn_Click(object sender, EventArgs e)
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
                UseVisualStyleBackColor = false,
            });

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
                database_control();
                MessageBox.Show("saved completion.");
            }

            catch (Exception ex) {
                MessageBox.Show("An error occurred while saving tasks: " + ex.Message);
            }
        }

        private void database_control()
        {
            string connectString = System.Configuration.ConfigurationManager.ConnectionStrings["EventTasksDB"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectString))
            {
                connection.Open();

                for (int i = 0; i< task_num; i++)
                {
                    string query = "INSERT INTO [dbo].[task] (title, priority, dueDate) VALUES (@title, @priority, @dueDate)";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        // パラメータの追加
                        // cmd.Parameters.AddWithValue("@user_id", user_id);
                        cmd.Parameters.AddWithValue("@title", TaskTitleTextBox[i].Text);
                        cmd.Parameters.AddWithValue("@priority", PriorityBox[i].Value);
                        cmd.Parameters.AddWithValue("@dueDate", DueDataBox[i].Value);

                        cmd.ExecuteNonQuery();
                    }
                }
            }

        } 
    }
}
