using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramShop.DLC
{
    public partial class CartForm : Form
    {
        private ShoppingCart cart;

        public CartForm(ShoppingCart shoppingCart)
        {
            InitializeComponent();
            cart = shoppingCart;
            UpdateCartDisplay();
        }

        private void UpdateCartDisplay()
        {
            cartListView1.Items.Clear();
            imageList1.Images.Clear();
            foreach (var product in cart.GetProducts())
            {
                var listViewItem = new ListViewItem($"{product.name} - {product.price:C}")
                {
                    ImageIndex = imageList1.Images.Count
                };
                imageList1.Images.Add(product.photo ?? new Bitmap(64, 64));
                cartListView1.Items.Add(listViewItem);
            }
            totalPriceLabel1.Text = $"Total: {cart.GetTotalPrice():C}";
        }

        private void RemoveFromCartButton_Click(object sender, EventArgs e)
        {
            if (cartListView1.SelectedItems.Count > 0)
            {
                var selectedItem = cartListView1.SelectedItems[0];
                string selectedProductInfo = selectedItem.Text;
                Product selectedProduct = cart.GetProducts().FirstOrDefault(p => $"{p.name} - {p.price:C}" == selectedProductInfo);
                if (selectedProduct != null)
                {
                    cart.RemoveProduct(selectedProduct);
                    UpdateCartDisplay();
                }
            }
        }
    }
}
