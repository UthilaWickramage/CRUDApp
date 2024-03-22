using FridayProject.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace FridayProject
{
    public partial class ProductRegistration : Form
    {
        private int updatingId = 0;
        public ProductRegistration()
        {
           
            InitializeComponent();
            loadProducts();
            

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string name = nameTxt.Text;
            string description = descTxt.Text;

            double price = double.Parse(priceTxt.Text);
            double discount = double.Parse(discountTxt.Text);
            int qty = int.Parse(qtyTxt.Text);
            string category = categoryTxt.Text;
          
            using (var dbContext = new MyDBContext())
            {
                Product product = dbContext.Products.Find(updatingId);
                if (product == null)
                {
                    product = new Product();
                }
                product.Name = name;
                product.Description = description;
                product.Price = price;
                product.Discount = discount;
                product.Qty = qty;
                product.Category = category;

                dbContext.Products.Update(product);
                dbContext.SaveChanges();
                updatingId = 0;
            }

            MessageBox.Show("Product Saved Successfully!");
            cleanup();
            loadProducts();

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var dbContext = new MyDBContext())
            {
                if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index)
            {
                var data = (Product)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                if (data != null)
                {
                        dbContext.Products.Remove(data);
                        dbContext.SaveChanges();
                        MessageBox.Show("Deleted");
                        loadProducts();
                }
                    return;
            }
            int rowIndex =  e.RowIndex;
           updatingId = (int) dataGridView1.Rows[rowIndex].Cells[0].Value;
            
               Product product =  dbContext.Products.Find(updatingId);
                if(product == null)
                {
                    product = new Product();
                }
   
                nameTxt.Text = product.Name;
                descTxt.Text = product.Description;
                priceTxt.Text = product.Price.ToString();
                discountTxt.Text = product.Discount.ToString();
                qtyTxt.Text = product.Qty.ToString();
                categoryTxt.Text = product.Category;
            }
        }
       

        private void cleanup()
        {
            nameTxt.Text = "";
            descTxt.Text = "";
            priceTxt.Text = "";
            discountTxt.Text = "";
            qtyTxt.Text = "";
            categoryTxt.Text = "";
        }
        private void loadProducts()
        {
            using (var dbContext = new MyDBContext())
            {
                dataGridView1.DataSource = dbContext.Products.ToList();
            }
        }


    }
}
