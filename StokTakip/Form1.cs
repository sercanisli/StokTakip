using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Concrete;
using System.Data.Entity;
using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using DataAccess.Concrete.Context;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace StokTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
            _productDal = InstanceFactory.GetInstance<IProductDal>();
            _categoryDal = InstanceFactory.GetInstance<ICategoryDal>();
        }

        private IProductService _productService;
        private ICategoryService _categoryService;
        private IProductDal _productDal;
        private ICategoryDal _categoryDal;


        private void Form1_Load(object sender, EventArgs e)
        {
            ListProductForAddPage();
            ListCategoryForAddPage();

            ListProductForDeletePage();
            ListCategoryForDeletePage();

            ListProductsForUpdatePage();

            LoadComboBoxForDeletePageInProducts();

            LoadComboBoxForAddPageInProducts();

            LoadComboBoxForUpdatePageInProducts();
        }

        private void ListProductsForUpdatePage()
        {
            dgView_Update.DataSource = _productService.GetAll();
        }

        private void ListCategoryForDeletePage()
        {
            dg_View_Delete_Categories.DataSource = _categoryService.GetAll();
        }

        private void ListProductForDeletePage()
        {
            dgView_Delete_Products.DataSource = _productService.GetAll();
        }

        private void ListCategoryForAddPage()
        {
            dgView_Add_Category.DataSource = _categoryService.GetAll();
        }

        private void ListProductForAddPage()
        {
            dgView_Add_Product.DataSource = _productService.GetAll();
        }

        private void LoadComboBoxForDeletePageInProducts()
        {
            cbx_Delete_Products.DataSource = _categoryService.GetAll();
            cbx_Delete_Products.DisplayMember = "CategoryName";
            cbx_Delete_Products.ValueMember = "CategoryId";
        }

        private void LoadComboBoxForAddPageInProducts()
        {
            cmx_Add_ProductCategory.DataSource = _categoryService.GetAll();
            cmx_Add_ProductCategory.DisplayMember = "CategoryName";
            cmx_Add_ProductCategory.ValueMember = "CategoryId";
        }
        private void LoadComboBoxForUpdatePageInProducts()
        {
           cbx_Update_Category.DataSource = _categoryService.GetAll();
           cbx_Update_Category.DisplayMember = "CategoryName";
           cbx_Update_Category.ValueMember = "CategoryId";
        }


        private void cbx_Delete_Products_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgView_Delete_Products.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbx_Delete_Products.SelectedValue));
            }
            catch 
            {
                
            }
        }

        private void btn_Add_Add_Click(object sender, EventArgs e)
        {
            var result=_productDal.ProductExists(tbx_Add_ProductName.Text);
            if (result == false)
            {
                _productService.Add(new Product
                {
                    ProductName = tbx_Add_ProductName.Text,
                    CategoryId = Convert.ToInt32(cmx_Add_ProductCategory.SelectedValue),
                    UnitPrice = Convert.ToInt32(nmrUD_Add_Price.Text),
                    UnitsInStock = Convert.ToInt16(nmrUD_add_UnitInStock.Text)
                });
                MessageBox.Show("Successful");
                tbx_Add_ProductName.Clear();
                ListProductForAddPage();
                ListProductForDeletePage();
                ListProductsForUpdatePage();
                LoadComboBoxForAddPageInProducts();
            }
            else
            {
                MessageBox.Show("Already added");
            }
        }

    

        private void btn_Add_Category_Click(object sender, EventArgs e)
        {
            var result = _categoryDal.CategoryExists(tbx_Add_CategoryName.Text);
            if (result==false)
            {
                _categoryService.Add(new Category
                {
                    CategoryName = tbx_Add_CategoryName.Text
                });
                MessageBox.Show("Successful");
                tbx_Add_CategoryName.Clear();
                ListCategoryForAddPage();
                ListCategoryForDeletePage();
                ListProductsForUpdatePage();
                LoadComboBoxForAddPageInProducts();
            }
            else
            {
                MessageBox.Show("Already Added");
            }
        }

        private void dgView_Update_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbx_Update_ProdductName.Text = dgView_Update.CurrentRow.Cells[1].Value.ToString();
            cbx_Update_Category.SelectedValue = dgView_Update.CurrentRow.Cells[2].Value;
            nmrUD_Update_Price.Text = dgView_Update.CurrentRow.Cells[3].Value.ToString();
            nmrUD_Update_UnitInStock.Text = dgView_Update.CurrentRow.Cells[4].Value.ToString();
        }

        private void btn_Update_Update_Click(object sender, EventArgs e)
        {
            _productService.Update(new Product
            {
                ProductId = Convert.ToInt32(dgView_Update.CurrentRow.Cells[0].Value),
                ProductName = tbx_Update_ProdductName.Text,
                CategoryId = Convert.ToInt32(cbx_Update_Category.SelectedValue),
                UnitPrice = Convert.ToDecimal(nmrUD_Update_Price.Text),
                UnitsInStock = Convert.ToInt16(nmrUD_Update_UnitInStock.Text)
            });
            MessageBox.Show("Successful");
            ListProductsForUpdatePage();
            ListProductForAddPage();
            ListProductForDeletePage();
            LoadComboBoxForUpdatePageInProducts();
        }


        private void btn_Delete_Categories_Click(object sender, EventArgs e)
        {
            try
            {
                _categoryService.Delete(new Category
                {
                    CategoryId = Convert.ToInt32(dg_View_Delete_Categories.CurrentRow.Cells[0].Value)
                });
                MessageBox.Show("Successful");
                ListProductsForUpdatePage();
                ListProductForAddPage();
                ListCategoryForDeletePage();
                ListCategoryForAddPage();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btn_Delete_DeleteProducts_Click_1(object sender, EventArgs e)
        {
            try
            {
                _productService.Delete(new Product
                {
                    ProductId = Convert.ToInt32(dgView_Delete_Products.CurrentRow.Cells[0].Value)
                });
                MessageBox.Show("Successful");
                ListProductsForUpdatePage();
                ListProductForAddPage();
                ListProductForDeletePage();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
