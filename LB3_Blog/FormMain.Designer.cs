﻿namespace LB3_Blog
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewUsers = new DataGridView();
            panelTop = new Panel();
            buttonSave = new Button();
            panelLeft = new Panel();
            panel1 = new Panel();
            dataGridViewPosts = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            panelTop.SuspendLayout();
            panelLeft.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPosts).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.BackgroundColor = Color.White;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Dock = DockStyle.Fill;
            dataGridViewUsers.Location = new Point(10, 10);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.Size = new Size(393, 360);
            dataGridViewUsers.TabIndex = 0;
            dataGridViewUsers.SelectionChanged += dataGridViewUsers_SelectionChanged;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.White;
            panelTop.Controls.Add(buttonSave);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(10);
            panelTop.Size = new Size(800, 70);
            panelTop.TabIndex = 2;
            // 
            // buttonSave
            // 
            buttonSave.Dock = DockStyle.Left;
            buttonSave.Location = new Point(10, 10);
            buttonSave.Name = "buttonSave";
            buttonSave.Padding = new Padding(10);
            buttonSave.Size = new Size(75, 50);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(dataGridViewUsers);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 70);
            panelLeft.Name = "panelLeft";
            panelLeft.Padding = new Padding(10);
            panelLeft.Size = new Size(413, 380);
            panelLeft.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridViewPosts);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(413, 70);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(387, 380);
            panel1.TabIndex = 4;
            // 
            // dataGridViewPosts
            // 
            dataGridViewPosts.BackgroundColor = Color.White;
            dataGridViewPosts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPosts.Dock = DockStyle.Fill;
            dataGridViewPosts.Location = new Point(10, 10);
            dataGridViewPosts.Name = "dataGridViewPosts";
            dataGridViewPosts.Size = new Size(367, 360);
            dataGridViewPosts.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(panelLeft);
            Controls.Add(panelTop);
            Name = "FormMain";
            Text = "Пользователи";
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            panelTop.ResumeLayout(false);
            panelLeft.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPosts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewUsers;
        private Panel panelTop;
        private Panel panelLeft;
        private Button buttonSave;
        private Panel panel1;
        private DataGridView dataGridViewPosts;
    }
}