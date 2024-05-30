﻿namespace Event_Tasks
{
    partial class new_task_list
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
            this.save_btn = new System.Windows.Forms.Button();
            this.return_btn = new System.Windows.Forms.Button();
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
            this.menu_name.Size = new System.Drawing.Size(152, 25);
            this.menu_name.TabIndex = 5;
            this.menu_name.Text = "New Task Lists";
            // 
            // set_task_btn
            // 
            this.set_task_btn.BackColor = System.Drawing.Color.SeaGreen;
            this.set_task_btn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.set_task_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.set_task_btn.Location = new System.Drawing.Point(495, 9);
            this.set_task_btn.Name = "set_task_btn";
            this.set_task_btn.Size = new System.Drawing.Size(80, 30);
            this.set_task_btn.TabIndex = 6;
            this.set_task_btn.Text = "➕ 作成";
            this.set_task_btn.UseVisualStyleBackColor = false;
            this.set_task_btn.Click += new System.EventHandler(this.set_task_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.Location = new System.Drawing.Point(495, 421);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(80, 30);
            this.save_btn.TabIndex = 8;
            this.save_btn.Text = "保存";
            this.save_btn.UseVisualStyleBackColor = true;
            // 
            // return_btn
            // 
            this.return_btn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_btn.Location = new System.Drawing.Point(409, 421);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(80, 30);
            this.return_btn.TabIndex = 9;
            this.return_btn.Text = "戻る";
            this.return_btn.UseVisualStyleBackColor = true;
            this.return_btn.Click += new System.EventHandler(this.return_btn_Click);
            // 
            // new_task_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.return_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.set_task_btn);
            this.Controls.Add(this.menu_name);
            this.Controls.Add(this.priority_label);
            this.Controls.Add(this.due_day_label);
            this.Controls.Add(this.task_title_label);
            this.Name = "new_task_list";
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
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button return_btn;
    }
}