using LB3_Blog.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace LB3_Blog
{
    public partial class FormMain : Form
    {//создаЄтс€ экземпл€р контекста данных, который будет использоватьс€ дл€ загрузки и отлеживани€ изменний о пользовател€х
        private BlogContext? db;
        public FormMain()
        {
            InitializeComponent();
        }
        //ћетод OnLoad вызывает при загрузке формы
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.db = new BlogContext();
            //ћетод Load расширени€ используетс€ дл€ загрузки всех пользователей из базы данных
            this.db.Users.Load();
            this.dataGridViewUsers.DataSource = db.Users.Local.ToBindingList();

        }
        //ћетод он OnClosing вызываетс€ при закрытии формы 
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this.db?.Dispose();
            this.db = null;
        }

        private void dataGridViewUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (this.db != null)
            {
                var user = (User)this.dataGridViewUsers.CurrentRow.DataBoundItem;
                if (user != null)
                {
                    this.db.Entry(user).Collection(e => e.Posts).Load();
                    this.dataGridViewPosts.DataSource = user.Posts;
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.db!.SaveChanges();
            this.dataGridViewPosts.Refresh();
            this.dataGridViewUsers.Refresh();
        }
    }
}

