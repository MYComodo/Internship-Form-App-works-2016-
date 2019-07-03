using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA.SqlWriteExample.Models;

namespace WFA.SqlWriteExample
{
    public partial class FormCategoryProcess : Form
    {
        int selectedCategoryNo;
        int selectedProductNo;
        public FormCategoryProcess()
        {
            InitializeComponent();
            GetCategories();
            GetProduct();

        }

        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            var category = new Category
            {
                CategoryName = txtCategoryName.Text,
                IsActive = true
            };
            if (AddCategory(category))
            {
                GetCategories();

                MessageBox.Show("Kategori Eklendi...");
            }
        }

        public void GetCategories()
        {
            using (DbSentekStore context = new DbSentekStore())
            {
                dgvCategories.DataSource = null;
                dgvCategories.DataSource = context.Categories.Select(c => new { KategoriId = c.CategoryId, KategoriAdi = c.CategoryName, Aktiflik = c.IsActive}).ToList();
            }

            dgvCategories.Columns[0].HeaderText = "Kategori Numarası ";
            dgvCategories.Columns[1].HeaderText = "Kategori Adı ";
            dgvCategories.Columns[2].HeaderText = "Aftiflik";
            
        }

        bool DeleteCategory(int categoryId)
        {

            using (DbSentekStore context = new DbSentekStore())
            {
                
                if (context.Categories.Any(o => o.CategoryId == categoryId))
                {
                    var catego=context.Categories.Where(c => c.CategoryId == categoryId).First();
                    context.Categories.Remove(catego);
                    MessageBox.Show("Silme İşlemi Gerçekleşti ");

                    return context.SaveChanges() > 0;
                }
                else
                {
                    MessageBox.Show("Girdiğiniz Numarada Bir Kayıt Yoktur!!");
                    return true;

                }



            }

        }
        bool AddCategory(Category category)
        {
            using (DbSentekStore context = new DbSentekStore())
            {
                context.Categories.Add(category);

                return context.SaveChanges() > 0;
            }



        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Category category = new Category()
        //    {

        //        CategoryId = Convert.ToInt32(txtCategoryId.Text)

        //    };



        //    DeleteCategory(category);

        //    GetCategories();
        //    txtCategoryId.Text = string.Empty;

        //}

        private void dgvCategories_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedCategoryNo = (int)dgvCategories.SelectedRows[0].Cells[0].Value;

            DialogResult dialogDeleteCategory;
            dialogDeleteCategory = MessageBox.Show("Seçilen kategoriyi silmek istiyormusunuz ! ", "Uyarı !!", MessageBoxButtons.YesNo);
            if (dialogDeleteCategory == DialogResult.Yes)
            {
                DeleteCategory(selectedCategoryNo);
                GetCategories();
            }

            else
            {
                
                
                label8.Text = selectedCategoryNo.ToString();
                GetCategories();
                
            }
            
        }

        bool AddProduct(Product prdct)
        {
            using (DbSentekStore dbase = new DbSentekStore())
            {

               
                dbase.Products.Add(prdct);
                return dbase.SaveChanges() > 0;

            }

        }

        void GetProduct()
        {
            using (DbSentekStore dbase = new DbSentekStore())
            {
                dgvProduct.DataSource = null;
                dgvProduct.DataSource = dbase.Products.Select(p =>
                new
                {
                    ÜrünNo = p.ProductId,
                    ÜrünAdı = p.ProductName,
                    ÜrünTarihi = p.ProductBuyDate,
                    ÜrünAdeti = p.Quantity,
                    ÜrünFiyatı = p.Price,
                }).ToList();
                dgvProduct.Columns[0].HeaderText = "Ürün Numarası ";
                dgvProduct.Columns[1].HeaderText = "Ürün Adı  ";
                dgvProduct.Columns[2].HeaderText = "Ürün Alınış Tarihi ";
                dgvProduct.Columns[3].HeaderText = "Ürün Adeti ";
                dgvProduct.Columns[4].HeaderText = "Ürün Fiyatı ";



            }

        }
        private void btnProductAdd_Click(object sender, EventArgs e)
        {


            #region ZamanKontrol
            DateTime time;
            if (DateTime.TryParse(txtProductBuyTime.Text, out time))
            { txtProductBuyTime.Text = time.ToShortDateString(); }
            else
            { errorProductTime.SetError(txtProductBuyTime, "Format dd/MM/yyyy"); } 
            #endregion

            Product products = new Product()
            {
                ProductName = txtProductName.Text,
                ProductBuyDate = time,
                Price = Convert.ToInt32(txtProductPrice.Text),
                Quantity = Convert.ToInt32(txtProductQuantity.Text),
                IsActive = true,
                CategoryId = selectedCategoryNo
                

               
            };
            

            AddProduct(products);
            GetProduct();
        }

        bool DeleteProduct(string  productName)
        {
            using (DbSentekStore dbase = new DbSentekStore())
            {
               

                if( dbase.Products.Any(p => p.ProductName == productName))
                {
                    Product prdcts = dbase.Products
                        .Where(p => p.ProductName == productName).First();

                    dbase.Products.Remove(prdcts);
                    return dbase.SaveChanges() > 0;

                }

                else
                {
                    MessageBox.Show("Girdiğiniz ürün numarası bulunmamaktadır!!");
                    return true;
                }

            }

        }

        bool UpdateProduct(Product product)
        {
            using(DbSentekStore context = new DbSentekStore())
            {
                if (context.Products.Any(p => p.ProductId == product.ProductId))
                {
                    var prdct = context.Products.First(p => p.ProductId == product.ProductId);

                    prdct.ProductName = product.ProductName;
                    prdct.ProductBuyDate = product.ProductBuyDate;
                    prdct.Quantity = product.Quantity;
                    prdct.Price = product.Price;
                    prdct.IsActive = product.IsActive;
                    prdct.CategoryId = product.CategoryId;


                    
                    return context.SaveChanges()>0;



                }


                return true;
            }

        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {
           

            DeleteProduct(txtProductName.Text);
            txtProductBuyTime.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtProductPrice.Text = string.Empty;
            txtProductQuantity.Text = string.Empty;

            GetProduct();
            btnProductDelete.Enabled = false;
            btnProductUpdate.Enabled = false;
            btnProductAdd.Enabled = true;
            
        }

        private void dgvProduct_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            selectedProductNo = (int)dgvProduct.SelectedRows[0].Cells[0].Value;
            txtProductName.Text = dgvProduct.SelectedRows[0].Cells[1].Value.ToString();
            txtProductBuyTime.Text = dgvProduct.SelectedRows[0].Cells[2].Value.ToString();
            txtProductQuantity.Text = dgvProduct.SelectedRows[0].Cells[3].Value.ToString();
            txtProductPrice.Text = dgvProduct.SelectedRows[0].Cells[3].Value.ToString();
            btnProductUpdate.Enabled = true;
            btnProductDelete.Enabled = true;
            btnProductAdd.Enabled = false;


        }

        private void btnProductUpdate_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                ProductId = selectedProductNo,
                ProductBuyDate = Convert.ToDateTime(txtProductBuyTime.Text),
                ProductName = txtProductName.Text,
                Price = Convert.ToInt32(txtProductPrice.Text),
                Quantity = Convert.ToInt32(txtProductQuantity.Text),
                CategoryId=selectedCategoryNo,
                IsActive =true
                

            };
            UpdateProduct(product);
            GetProduct();
            btnProductUpdate.Enabled = false;
            btnProductAdd.Enabled = true;
            
            
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
