namespace EventTasks
{
    partial class events_task
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.sum_label = new System.Windows.Forms.Label();
            this.mon_label = new System.Windows.Forms.Label();
            this.tue_label = new System.Windows.Forms.Label();
            this.wed_label = new System.Windows.Forms.Label();
            this.thu_label = new System.Windows.Forms.Label();
            this.fri_label = new System.Windows.Forms.Label();
            this.sat_label = new System.Windows.Forms.Label();
            this.monthly = new System.Windows.Forms.Label();
            this.prev_btn = new System.Windows.Forms.Button();
            this.next_btn = new System.Windows.Forms.Button();
            this.calendar_grid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sum_label
            // 
            this.sum_label.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum_label.ForeColor = System.Drawing.Color.Red;
            this.sum_label.Location = new System.Drawing.Point(110, 60);
            this.sum_label.Name = "sum_label";
            this.sum_label.Size = new System.Drawing.Size(80, 20);
            this.sum_label.TabIndex = 43;
            this.sum_label.Text = "Sunday";
            this.sum_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mon_label
            // 
            this.mon_label.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mon_label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mon_label.Location = new System.Drawing.Point(190, 60);
            this.mon_label.Name = "mon_label";
            this.mon_label.Size = new System.Drawing.Size(80, 20);
            this.mon_label.TabIndex = 44;
            this.mon_label.Text = "Monday";
            this.mon_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tue_label
            // 
            this.tue_label.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tue_label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tue_label.Location = new System.Drawing.Point(270, 60);
            this.tue_label.Name = "tue_label";
            this.tue_label.Size = new System.Drawing.Size(80, 20);
            this.tue_label.TabIndex = 45;
            this.tue_label.Text = "Tuesday";
            this.tue_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wed_label
            // 
            this.wed_label.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wed_label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.wed_label.Location = new System.Drawing.Point(350, 60);
            this.wed_label.Name = "wed_label";
            this.wed_label.Size = new System.Drawing.Size(80, 20);
            this.wed_label.TabIndex = 46;
            this.wed_label.Text = "Wednesday";
            this.wed_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // thu_label
            // 
            this.thu_label.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thu_label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.thu_label.Location = new System.Drawing.Point(430, 60);
            this.thu_label.Name = "thu_label";
            this.thu_label.Size = new System.Drawing.Size(80, 20);
            this.thu_label.TabIndex = 47;
            this.thu_label.Text = "Thursday";
            this.thu_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fri_label
            // 
            this.fri_label.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fri_label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fri_label.Location = new System.Drawing.Point(510, 60);
            this.fri_label.Name = "fri_label";
            this.fri_label.Size = new System.Drawing.Size(80, 20);
            this.fri_label.TabIndex = 48;
            this.fri_label.Text = "Friday";
            this.fri_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sat_label
            // 
            this.sat_label.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sat_label.ForeColor = System.Drawing.Color.MediumBlue;
            this.sat_label.Location = new System.Drawing.Point(590, 60);
            this.sat_label.Name = "sat_label";
            this.sat_label.Size = new System.Drawing.Size(80, 20);
            this.sat_label.TabIndex = 49;
            this.sat_label.Text = "Saturday";
            this.sat_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // monthly
            // 
            this.monthly.AutoSize = true;
            this.monthly.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthly.Location = new System.Drawing.Point(149, 15);
            this.monthly.Name = "monthly";
            this.monthly.Size = new System.Drawing.Size(134, 39);
            this.monthly.TabIndex = 85;
            this.monthly.Text = "2024.05";
            this.monthly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prev_btn
            // 
            this.prev_btn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prev_btn.Location = new System.Drawing.Point(113, 24);
            this.prev_btn.Name = "prev_btn";
            this.prev_btn.Size = new System.Drawing.Size(30, 30);
            this.prev_btn.TabIndex = 86;
            this.prev_btn.Text = "◀️";
            this.prev_btn.UseVisualStyleBackColor = true;
            this.prev_btn.Click += new System.EventHandler(this.prev_btn_Click);
            // 
            // next_btn
            // 
            this.next_btn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_btn.Location = new System.Drawing.Point(289, 24);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(30, 30);
            this.next_btn.TabIndex = 87;
            this.next_btn.Text = "▶️";
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // calendar_grid
            // 
            this.calendar_grid.BackColor = System.Drawing.Color.Transparent;
            this.calendar_grid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calendar_grid.Location = new System.Drawing.Point(110, 80);
            this.calendar_grid.Name = "calendar_grid";
            this.calendar_grid.Size = new System.Drawing.Size(560, 360);
            this.calendar_grid.TabIndex = 88;
            // 
            // events_task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.prev_btn);
            this.Controls.Add(this.monthly);
            this.Controls.Add(this.sat_label);
            this.Controls.Add(this.fri_label);
            this.Controls.Add(this.thu_label);
            this.Controls.Add(this.wed_label);
            this.Controls.Add(this.tue_label);
            this.Controls.Add(this.mon_label);
            this.Controls.Add(this.sum_label);
            this.Controls.Add(this.calendar_grid);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "events_task";
            this.Text = "Event Tasks";
            this.Load += new System.EventHandler(this.events_task_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label sum_label;
        private System.Windows.Forms.Label mon_label;
        private System.Windows.Forms.Label tue_label;
        private System.Windows.Forms.Label wed_label;
        private System.Windows.Forms.Label thu_label;
        private System.Windows.Forms.Label fri_label;
        private System.Windows.Forms.Label sat_label;
        private System.Windows.Forms.Label monthly;
        private System.Windows.Forms.Button prev_btn;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.Label calendar_grid;
    }
}

