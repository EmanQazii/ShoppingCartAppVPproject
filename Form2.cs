using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WinFormsApp1;

namespace ShoppingCartApp
{
    public partial class Form2 : Form
    {
        private Dictionary<string, CartItem> cartProducts; 
        private Form1 _form1;
        private int total;
        private int product_count;
        private string selectedPaymentMethod;

        public Form2(Dictionary<string, CartItem> cartProducts, Form1 form1)
        {
            InitializeComponent();
            this.cartProducts = cartProducts;
            DisplayOrderDetails();

            rb_card.CheckedChanged += rb_card_CheckedChanged;

            CardText.Visible = false;
            card_label.Visible = false;


            _form1 = form1;

            decimal subTotal = _form1.CalculateSubTotal();
            total=CalculatePrices(subTotal);


       
            

        }


        public Form2()
        {
            InitializeComponent();

            
        }
       
        private void button1_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(AddressText.Text))
            {
                MessageBox.Show("Address cannot be empty.");
                return;
            }
            string phonePattern = @"^\d{11}$";
            string phoneInput = PhoneText.Text.Trim();
            if (!Regex.IsMatch(phoneInput, phonePattern))
            {
                MessageBox.Show("Please enter a valid 11-digit phone number.");
                return;
            }

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            string emailInput = EmailText.Text.Trim();

            if (!Regex.IsMatch(emailInput, emailPattern))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            string selectedPaymentMethod = "";
            if (rb_card.Checked)
            {
                selectedPaymentMethod = "Credit Card";
                string creditCardPattern = @"^\d{16}$"; // Assuming 16-digit credit card
                if (!Regex.IsMatch(CardText.Text, creditCardPattern))
                {
                    MessageBox.Show("Please enter a valid 16-digit credit card number.");
                    return;
                }
            }
            else 
            if (rb_cash.Checked)
            {
                selectedPaymentMethod = "Cash on Delivery";
            }

            if (string.IsNullOrEmpty(selectedPaymentMethod))
            {
                MessageBox.Show("Please select a payment method.");
            }


            string CustomerName = NameText.Text;
            string CustomerAddress = AddressText.Text;
            string CustomerPhoneNo = PhoneText.Text;
            string CustomerEmail = EmailText.Text;

            Invoice(total,CustomerName,CustomerPhoneNo,CustomerEmail);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void rb_card_CheckedChanged(object sender, EventArgs e)
        {
            bool isCardSelected = rb_card.Checked;
            CardText.Visible = isCardSelected;
            card_label.Visible=isCardSelected;
        }
        private void DisplayOrderDetails()
        {
            orderlayoutpanel.Controls.Clear();

            foreach (var item in cartProducts.Values)
            {
                product_count++;

                if (item.Product.Stock == null || item.Product.Category == null || item.Quantity == null || item.Product.Image == null || item.Product.Price == null || item.Product.Name == null)
                {
                    continue;
                }
                var orderProductPanel = new Panel
                {
                    Width = 360,
                    Height = 35,
                    Padding = new Padding(3)
                };

                byte[] imageBytes = item.Product.Image;
                if (imageBytes == null)
                {
                    continue;
                }
                MemoryStream ms = new MemoryStream(imageBytes);
                Image pdImage = Image.FromStream(ms);
                var orderPictureBox = new PictureBox
                {
                    Image = pdImage,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Width = 40,
                    Height = 35
                };
                var orderNameLabel = new Label
                {
                    Text = item.Product.Name,
                    AutoSize = true,
                    Location = new Point(40, 3),
                    Font = new Font("Candara", 10, FontStyle.Regular)
                };
                var orderQuantityLabel = new Label
                {
                    Text = $"Qty : {item.Quantity}",
                    AutoSize = true,
                    Location = new Point(290, 3),
                    Font = new Font("Arial", 8)
                };

                orderProductPanel.Controls.Add(orderPictureBox);
                orderProductPanel.Controls.Add(orderNameLabel);
                orderProductPanel.Controls.Add(orderQuantityLabel);

                orderlayoutpanel.Controls.Add(orderProductPanel);

            }
        }

        private int CalculatePrices(decimal subTotal)
        {
            decimal discount_rate = 0.05m;
            decimal tax_rate = 0.02m;
            decimal discount = 0, discount_amount = 0, tax = 0, total_amount = 0;
            if (subTotal >= 5000)
            {
                discount = subTotal * discount_rate;
                discount_amount = subTotal - discount;
            }
            else
            {
                discount = subTotal * 0;
                discount_amount = subTotal - discount;
            }
            tax = discount_amount * tax_rate;
            total_amount = tax + discount_amount;

            int int_sub = Convert.ToInt32(subTotal);
            int int_discount = Convert.ToInt32(discount);
            int int_tax = Convert.ToInt32(tax);
            int int_total = Convert.ToInt32(total_amount);

            subtotal_label.Text = $"Subtotal: Rs {int_sub}";
            discount_label.Text = $"Discount: Rs {int_discount}";
            tax_label.Text = $"Tax: Rs {int_tax}";
            total_label.Text = $"Total Amount: Rs {int_total}";

            return int_total ;
        }
        private void Invoice(int total, string c_name,string c_phone, string c_email)
        {
            //Format for invoice string.
            string invoice = $@"
            Your order has been placed!
                    ORDER DETAILS
            Customer Name  : {c_name}
            Phone#         : {c_phone}
            No of Products : {product_count}
            Delivery Time  : 5-7 days
            Total Amount   : Rs {total}";

            MessageBox.Show(invoice, "CONFIRMATION NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
