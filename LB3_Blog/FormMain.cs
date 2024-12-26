using LB3_Blog.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace LB3_Blog
{
    public partial class FormMain : Form
    {
        // ��������� ��������� ������, ������� ����� ��������������
        // ��� �������� � ������������ ��������� � �������������
        private Models.BlogContext? _db;

        public FormMain()
        {
            InitializeComponent();
        }

        // OnLoad - ��� �������� �����
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _db = new Models.BlogContext();

            // ����� Load ���������� ������������ ��� ���� ������������� �� �� � DbContext ��.
            _db.Users.Load();
            dataGridViewUsers.DataSource = _db.Users.Local.ToBindingList();
        }

        // OnClosing - ��� �������� �����.
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
            // ���� ��� �������� ����� SaveChanges(),
            // ������� ��������� ��� ��������� � ��
            _db!.SaveChanges();


            dataGridViewUsers.Refresh();
            dataGridViewPosts.Refresh();
        }
    }
}
