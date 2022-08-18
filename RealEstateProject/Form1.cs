using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstateProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Context context = new Context();
        private void btnList_Click(object sender, EventArgs e)
        {
            var values = context.Categories.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = txtCategoryName.Text;
            category.CategoryDetails = txtDetails.Text;
            context.Categories.Add(category);
            context.SaveChanges();
            MessageBox.Show("Kategori eklendi");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtCategoryID.Text);
            var values = context.Categories.Where(x => x.CategoryID ==id).FirstOrDefault();
            context.Categories.Remove(values);
            context.SaveChanges();
            MessageBox.Show("Kategori silindi");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id=Convert.ToInt32(txtCategoryID.Text);
            var values = context.Categories.Where(x => x.CategoryID == id).FirstOrDefault();
            values.CategoryName = txtCategoryName.Text;
            values.CategoryDetails = txtDetails.Text;
            context.SaveChanges();
            MessageBox.Show("Kategori Güncellendi");
        }
    }
}
