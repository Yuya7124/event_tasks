using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        
        public show_task_list()
        {
            InitializeComponent();
        }
        private void task_list_Load(object sender, EventArgs e)
        {
            
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
    }
}
