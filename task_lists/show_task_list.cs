using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Tasks
{
    public partial class show_task_list : Form
    {
        // アクセスページ
        new_task_list new_task = new new_task_list();
        edit_task_list edit_task = new edit_task_list();

        // 動的に追加するツール
        private List<Label> TaskNumLabel = new List<Label>();
        private List<Label> TaskTitleLabel = new List<Label>();
        private List<Label> TaskDueDateLabel = new List<Label>();
        private List<Label> TaskPriorityLabel = new List<Label>();
        private List<Button> DelTaskButton = new List<Button>();

        public show_task_list()
        {
            InitializeComponent();
        }
        private void task_list_Load(object sender, EventArgs e)
        {
            database_select();
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

        private void database_select()
        {
            string connectString = "Data Source=WIN-DN6B589V2SO\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
            
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                // データベース接続開始
                connection.Open();
                var query = "SELECT task_title, due_date, task_priority FROM event_tasks.dbo.task";
                
                SqlCommand cmd = new SqlCommand(query, connection);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                     // データの取得
                    while (reader.Read())
                    {

                        Console.WriteLine($"{reader["task_title"]} - {reader["due_date"]} - {reader["task_priority"]}");
                    }
                }
            }
        }
    }
}
