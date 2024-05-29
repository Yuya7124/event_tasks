namespace Event_Tasks
{
    partial class task_list
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
            this.record_day_label = new System.Windows.Forms.Label();
            this.task_title_label = new System.Windows.Forms.Label();
            this.due_day_label = new System.Windows.Forms.Label();
            this.priority_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // record_day_label
            // 
            this.record_day_label.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.record_day_label.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.record_day_label.Location = new System.Drawing.Point(15, 47);
            this.record_day_label.Name = "record_day_label";
            this.record_day_label.Size = new System.Drawing.Size(100, 20);
            this.record_day_label.TabIndex = 0;
            this.record_day_label.Text = "登録日";
            this.record_day_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // task_title_label
            // 
            this.task_title_label.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.task_title_label.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.task_title_label.Location = new System.Drawing.Point(121, 47);
            this.task_title_label.Name = "task_title_label";
            this.task_title_label.Size = new System.Drawing.Size(200, 20);
            this.task_title_label.TabIndex = 1;
            this.task_title_label.Text = "タイトル";
            this.task_title_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // due_day_label
            // 
            this.due_day_label.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.due_day_label.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.due_day_label.Location = new System.Drawing.Point(327, 47);
            this.due_day_label.Name = "due_day_label";
            this.due_day_label.Size = new System.Drawing.Size(100, 20);
            this.due_day_label.TabIndex = 2;
            this.due_day_label.Text = "期日";
            this.due_day_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // priority_label
            // 
            this.priority_label.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.priority_label.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priority_label.Location = new System.Drawing.Point(433, 47);
            this.priority_label.Name = "priority_label";
            this.priority_label.Size = new System.Drawing.Size(70, 20);
            this.priority_label.TabIndex = 3;
            this.priority_label.Text = "優先度";
            this.priority_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(509, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "完了ボタン";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Task Lists";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(512, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "➕ 作成";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // task_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.priority_label);
            this.Controls.Add(this.due_day_label);
            this.Controls.Add(this.task_title_label);
            this.Controls.Add(this.record_day_label);
            this.Name = "task_list";
            this.Text = "Task Lists";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label record_day_label;
        private System.Windows.Forms.Label task_title_label;
        private System.Windows.Forms.Label due_day_label;
        private System.Windows.Forms.Label priority_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}