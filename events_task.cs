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
    public partial class events_task : Form
    {
        DateTime dt = DateTime.Now;
        int BetweenMonth = 0;

        private Label[] calendar_days; 
        public events_task()
        {
            InitializeComponent();
        }

        private void events_task_Load(object sender, EventArgs e)
        {
            this.monthly.Text = dt.ToString("yyyy.MM");
        }

        private void prev_btn_Click(object sender, EventArgs e)
        {
            BetweenMonth--;
            DateTime prev_month = dt.AddMonths(BetweenMonth);
            this.monthly.Text = prev_month.ToString("yyyy.MM");
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            BetweenMonth++;
            DateTime prev_month = dt.AddMonths(BetweenMonth);
            this.monthly.Text = prev_month.ToString("yyyy.MM");
        }

        public void edit_calendar()
        {

        }
    }
}
