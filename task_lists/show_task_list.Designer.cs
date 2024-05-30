namespace Event_Tasks
{
    partial class show_task_list
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.task_title_label = new System.Windows.Forms.Label();
            this.due_day_label = new System.Windows.Forms.Label();
            this.priority_label = new System.Windows.Forms.Label();
            this.menu_name = new System.Windows.Forms.Label();
            this.set_task_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.return_btn = new System.Windows.Forms.Button();
            this.del_task_btn0 = new System.Windows.Forms.Button();
            this.task_num = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // task_title_label
            // 
            this.task_title_label.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.task_title_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.task_title_label.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.task_title_label.Location = new System.Drawing.Point(50, 50);
            this.task_title_label.Name = "task_title_label";
            this.task_title_label.Size = new System.Drawing.Size(300, 20);
            this.task_title_label.TabIndex = 1;
            this.task_title_label.Text = "タイトル";
            this.task_title_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // due_day_label
            // 
            this.due_day_label.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.due_day_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.due_day_label.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.due_day_label.Location = new System.Drawing.Point(350, 50);
            this.due_day_label.Name = "due_day_label";
            this.due_day_label.Size = new System.Drawing.Size(100, 20);
            this.due_day_label.TabIndex = 2;
            this.due_day_label.Text = "期日";
            this.due_day_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // priority_label
            // 
            this.priority_label.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.priority_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priority_label.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priority_label.Location = new System.Drawing.Point(450, 50);
            this.priority_label.Name = "priority_label";
            this.priority_label.Size = new System.Drawing.Size(70, 20);
            this.priority_label.TabIndex = 3;
            this.priority_label.Text = "優先度";
            this.priority_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menu_name
            // 
            this.menu_name.AutoSize = true;
            this.menu_name.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_name.Location = new System.Drawing.Point(13, 9);
            this.menu_name.Name = "menu_name";
            this.menu_name.Size = new System.Drawing.Size(100, 25);
            this.menu_name.TabIndex = 5;
            this.menu_name.Text = "Task Lists";
            // 
            // set_task_btn
            // 
            this.set_task_btn.BackColor = System.Drawing.Color.SeaGreen;
            this.set_task_btn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.set_task_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.set_task_btn.Location = new System.Drawing.Point(505, 10);
            this.set_task_btn.Name = "set_task_btn";
            this.set_task_btn.Size = new System.Drawing.Size(80, 30);
            this.set_task_btn.TabIndex = 6;
            this.set_task_btn.Text = "➕ 作成";
            this.set_task_btn.UseVisualStyleBackColor = false;
            this.set_task_btn.Click += new System.EventHandler(this.set_task_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.Location = new System.Drawing.Point(373, 421);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(80, 30);
            this.edit_btn.TabIndex = 8;
            this.edit_btn.Text = "編集";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // return_btn
            // 
            this.return_btn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_btn.Location = new System.Drawing.Point(145, 421);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(80, 30);
            this.return_btn.TabIndex = 9;
            this.return_btn.Text = "戻る";
            this.return_btn.UseVisualStyleBackColor = true;
            this.return_btn.Click += new System.EventHandler(this.return_btn_Click);
            // 
            // del_task_btn0
            // 
            this.del_task_btn0.BackColor = System.Drawing.Color.Red;
            this.del_task_btn0.Cursor = System.Windows.Forms.Cursors.Default;
            this.del_task_btn0.ForeColor = System.Drawing.SystemColors.Control;
            this.del_task_btn0.Location = new System.Drawing.Point(540, 70);
            this.del_task_btn0.Name = "del_task_btn0";
            this.del_task_btn0.Size = new System.Drawing.Size(21, 21);
            this.del_task_btn0.TabIndex = 14;
            this.del_task_btn0.Text = "✔️";
            this.del_task_btn0.UseVisualStyleBackColor = false;
            // 
            // task_num
            // 
            this.task_num.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.task_num.Location = new System.Drawing.Point(25, 70);
            this.task_num.Name = "task_num";
            this.task_num.Size = new System.Drawing.Size(21, 21);
            this.task_num.TabIndex = 15;
            this.task_num.Text = "1";
            this.task_num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(526, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "完了ボタン";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "TaskTitle01";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(350, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "yyyy/mm.dd";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(450, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "1";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // show_task_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 461);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.task_num);
            this.Controls.Add(this.del_task_btn0);
            this.Controls.Add(this.return_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.set_task_btn);
            this.Controls.Add(this.menu_name);
            this.Controls.Add(this.priority_label);
            this.Controls.Add(this.due_day_label);
            this.Controls.Add(this.task_title_label);
            this.Name = "show_task_list";
            this.Text = "Task Lists";
            this.Load += new System.EventHandler(this.task_list_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label task_title_label;
        private System.Windows.Forms.Label due_day_label;
        private System.Windows.Forms.Label priority_label;
        private System.Windows.Forms.Label menu_name;
        private System.Windows.Forms.Button set_task_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button return_btn;
        private System.Windows.Forms.Button del_task_btn0;
        private System.Windows.Forms.Label task_num;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}