using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramShop.DLC
{
    public partial class ProductsForm : Form
    {
        
        private ShoppingCart cart = new ShoppingCart();
        DB db = new DB();
        SqlCommand cmd;
        private Product product;

        public ProductsForm()
        {
            InitializeComponent();

        }
        public ProductsForm(Product _product) : this() 
        {
            product = _product;
            DisplayProduct();
        }
        private void DisplayProduct()
        {
            nameLabel.Text = product.name;
            desc.Text = product.description;
            priceLabel.Text = $"Price: {product.price.ToString("C")}";
            pictureBox.Image = product.photo; 
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            db.openConnection();

            if (Properties.Settings.Default.id_order == 0)
            {
                cmd = new SqlCommand("Insert into orders values (@client, @date, @summa, @payment)", db.getConnection());
                cmd.Parameters.Add("@client", SqlDbType.Int).Value = 1;
                cmd.Parameters.Add("@date", SqlDbType.Date).Value = DateTime.Now.Date;
                cmd.Parameters.Add("@summa", SqlDbType.Float).Value = 0;
                cmd.Parameters.Add("@payment", SqlDbType.NVarChar).Value = "Картой";
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("Select MAX (id_order) from orders", db.getConnection());
                Properties.Settings.Default.id_order = Convert.ToInt32(cmd.ExecuteScalar());
            }
            cmd = new SqlCommand("INSERT INTO items (id_order, id_product) VALUES (@id_order, @id_prod)", db.getConnection());
            cmd.Parameters.Add("@id_order", SqlDbType.Int, 4).Value = Properties.Settings.Default.id_order;
            cmd.Parameters.Add("@id_prod", SqlDbType.Int, 4).Value = Properties.Settings.Default.id_product;
            cmd.ExecuteNonQuery();
        }

        private void ViewCartButton_Click(object sender, EventArgs e)
        {
            CartForm cartForm = new CartForm(cart);
            cartForm.Show();
        }
    } 
}

public class Product
{
    public int id_product { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public string manufact { get; set; }
    public decimal price { get; set; }
    public Image photo { get; set; }
}

public class ShoppingCart
{
    private List<Product> products = new List<Product>();

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public void RemoveProduct(Product product)
    {
        products.Remove(product);
    }

    public List<Product> GetProducts()
    {
        return products;
    }

    public decimal GetTotalPrice()
    {
        return products.Sum(p => p.price);
    }
}
