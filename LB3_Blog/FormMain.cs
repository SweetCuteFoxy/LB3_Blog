using LB3_Blog.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace LB3_Blog
{
    public partial class FormMain : Form
    {
        // Экземпляр контекста данных, который будет использоваться
        // для загрузки и отслеживания изменений о пользователях
        private Models.BlogContext? _db;

        public FormMain()
        {
            InitializeComponent();
        }

        // OnLoad - при загрузки формы
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _db = new Models.BlogContext();

            // Метод Load расширения используется для всех пользователей из БД в DbContext БД.
            _db.Users.Load();
            dataGridViewUsers.DataSource = _db.Users.Local.ToBindingList();
        }

        // OnClosing - при закрытии формы.
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            _db?.Dispose();
            _db = null;
        }

        private void DataGridViewUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (_db != null)
            {
                var currentRow = dataGridViewUsers.CurrentRow;

                if (currentRow == null)
                    return;

                var user = (User)dataGridViewUsers.CurrentRow.DataBoundItem;

                if (user != null)
                {
                    _db.Entry(user).Collection(e => e.Posts).Load();
                    dataGridViewPosts.DataSource = user.Posts;
                }
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            // Этот код вызывает метод SaveChanges(),
            // который сохраняет все изменения в БД
            _db!.SaveChanges();


            dataGridViewUsers.Refresh();
            dataGridViewPosts.Refresh();
        }
    }
}
