namespace ShoppingCartApp
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NameText = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label6 = new Label();
            label3 = new Label();
            label4 = new Label();
            AddressText = new TextBox();
            label5 = new Label();
            label7 = new Label();
            PhoneText = new TextBox();
            label8 = new Label();
            label9 = new Label();
            EmailText = new TextBox();
            rb_card = new RadioButton();
            rb_cash = new RadioButton();
            groupBox1 = new GroupBox();
            CardText = new TextBox();
            card_label = new Label();
            label10 = new Label();
            orderlayoutpanel = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            label11 = new Label();
            label12 = new Label();
            subtotal_label = new Label();
            tax_label = new Label();
            discount_label = new Label();
            total_label = new Label();
            groupBox1.SuspendLayout();
            orderlayoutpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // NameText
            // 
            NameText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NameText.Location = new Point(108, 275);
            NameText.Margin = new Padding(3, 2, 3, 2);
            NameText.Multiline = true;
            NameText.Name = "NameText";
            NameText.Size = new Size(269, 32);
            NameText.TabIndex = 0;
            NameText.Text = "\r\n";
            // 
            // label1
            // 
            label1.BackColor = Color.Snow;
            label1.Font = new Font("Candara", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 275);
            label1.Name = "label1";
            label1.Size = new Size(76, 28);
            label1.TabIndex = 4;
            label1.Text = "Name";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(88, 279);
            label2.Name = "label2";
            label2.Size = new Size(14, 24);
            label2.TabIndex = 5;
            label2.Text = ":";
            // 
            // button1
            // 
            button1.BackColor = Color.Snow;
            button1.Location = new Point(47, 553);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(261, 28);
            button1.TabIndex = 10;
            button1.Text = "Place Order";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.BackColor = Color.LightCoral;
            label6.Font = new Font("Candara", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(88, 240);
            label6.Name = "label6";
            label6.Size = new Size(188, 28);
            label6.TabIndex = 11;
            label6.Text = "Customer Details";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(88, 322);
            label3.Name = "label3";
            label3.Size = new Size(14, 24);
            label3.TabIndex = 14;
            label3.Text = ":";
            // 
            // label4
            // 
            label4.BackColor = Color.Snow;
            label4.Font = new Font("Candara", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(9, 318);
            label4.Name = "label4";
            label4.Size = new Size(76, 28);
            label4.TabIndex = 13;
            label4.Text = "Address";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddressText
            // 
            AddressText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddressText.Location = new Point(108, 318);
            AddressText.Margin = new Padding(3, 2, 3, 2);
            AddressText.Multiline = true;
            AddressText.Name = "AddressText";
            AddressText.Size = new Size(269, 32);
            AddressText.TabIndex = 12;
            AddressText.Text = "\r\n";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(88, 367);
            label5.Name = "label5";
            label5.Size = new Size(14, 24);
            label5.TabIndex = 17;
            label5.Text = ":";
            // 
            // label7
            // 
            label7.BackColor = Color.Snow;
            label7.Font = new Font("Candara", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(9, 363);
            label7.Name = "label7";
            label7.Size = new Size(76, 28);
            label7.TabIndex = 16;
            label7.Text = "Phone #";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PhoneText
            // 
            PhoneText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PhoneText.Location = new Point(108, 363);
            PhoneText.Margin = new Padding(3, 2, 3, 2);
            PhoneText.Multiline = true;
            PhoneText.Name = "PhoneText";
            PhoneText.Size = new Size(269, 32);
            PhoneText.TabIndex = 15;
            PhoneText.Text = "\r\n";
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(88, 415);
            label8.Name = "label8";
            label8.Size = new Size(14, 24);
            label8.TabIndex = 20;
            label8.Text = ":";
            // 
            // label9
            // 
            label9.BackColor = Color.Snow;
            label9.Font = new Font("Candara", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(9, 411);
            label9.Name = "label9";
            label9.Size = new Size(76, 28);
            label9.TabIndex = 19;
            label9.Text = "Email";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EmailText
            // 
            EmailText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EmailText.Location = new Point(108, 411);
            EmailText.Margin = new Padding(3, 2, 3, 2);
            EmailText.Multiline = true;
            EmailText.Name = "EmailText";
            EmailText.Size = new Size(269, 32);
            EmailText.TabIndex = 18;
            EmailText.Text = "\r\n";
            // 
            // rb_card
            // 
            rb_card.Font = new Font("Candara", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rb_card.Location = new Point(198, 23);
            rb_card.Name = "rb_card";
            rb_card.Size = new Size(125, 18);
            rb_card.TabIndex = 24;
            rb_card.TabStop = true;
            rb_card.Text = "Credit/Debt Card";
            rb_card.UseVisualStyleBackColor = true;
            // 
            // rb_cash
            // 
            rb_cash.Font = new Font("Candara", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rb_cash.Location = new Point(38, 23);
            rb_cash.Name = "rb_cash";
            rb_cash.Size = new Size(144, 18);
            rb_cash.TabIndex = 25;
            rb_cash.TabStop = true;
            rb_cash.Text = "Cash On Delivery";
            rb_cash.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 192, 192);
            groupBox1.Controls.Add(rb_cash);
            groupBox1.Controls.Add(rb_card);
            groupBox1.Font = new Font("Candara", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(9, 455);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(368, 48);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Payment Method";
            // 
            // CardText
            // 
            CardText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CardText.BackColor = Color.Snow;
            CardText.Location = new Point(9, 522);
            CardText.Margin = new Padding(3, 2, 3, 2);
            CardText.Multiline = true;
            CardText.Name = "CardText";
            CardText.PlaceholderText = "Enter Credit/Debt Card No";
            CardText.Size = new Size(368, 27);
            CardText.TabIndex = 27;
            CardText.Text = "\r\n";
            // 
            // card_label
            // 
            card_label.AutoSize = true;
            card_label.Font = new Font("Candara", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            card_label.Location = new Point(9, 506);
            card_label.Name = "card_label";
            card_label.Size = new Size(147, 14);
            card_label.TabIndex = 28;
            card_label.Text = "Enter Credit/Debt Card No:";
            // 
            // label10
            // 
            label10.BackColor = Color.LightCoral;
            label10.Font = new Font("Candara", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ControlLightLight;
            label10.Location = new Point(108, 9);
            label10.Name = "label10";
            label10.Size = new Size(155, 27);
            label10.TabIndex = 30;
            label10.Text = "Order Details";
            // 
            // orderlayoutpanel
            // 
            orderlayoutpanel.AutoScroll = true;
            orderlayoutpanel.BackColor = Color.MistyRose;
            orderlayoutpanel.Controls.Add(pictureBox1);
            orderlayoutpanel.Controls.Add(label11);
            orderlayoutpanel.Controls.Add(label12);
            orderlayoutpanel.Location = new Point(12, 39);
            orderlayoutpanel.Name = "orderlayoutpanel";
            orderlayoutpanel.Size = new Size(368, 134);
            orderlayoutpanel.TabIndex = 31;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 46);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label11
            // 
            label11.Location = new Point(63, 0);
            label11.Name = "label11";
            label11.Size = new Size(257, 21);
            label11.TabIndex = 1;
            label11.Text = "label11";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(3, 52);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 2;
            label12.Text = "label12";
            // 
            // subtotal_label
            // 
            subtotal_label.AutoSize = true;
            subtotal_label.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            subtotal_label.Location = new Point(15, 176);
            subtotal_label.Name = "subtotal_label";
            subtotal_label.Size = new Size(69, 17);
            subtotal_label.TabIndex = 32;
            subtotal_label.Text = "Subtotal :";
            // 
            // tax_label
            // 
            tax_label.AutoSize = true;
            tax_label.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tax_label.Location = new Point(16, 193);
            tax_label.Name = "tax_label";
            tax_label.Size = new Size(69, 17);
            tax_label.TabIndex = 33;
            tax_label.Text = "Subtotal :";
            // 
            // discount_label
            // 
            discount_label.AutoSize = true;
            discount_label.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            discount_label.Location = new Point(16, 210);
            discount_label.Name = "discount_label";
            discount_label.Size = new Size(69, 17);
            discount_label.TabIndex = 34;
            discount_label.Text = "Subtotal :";
            // 
            // total_label
            // 
            total_label.AutoSize = true;
            total_label.BackColor = Color.Snow;
            total_label.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            total_label.Location = new Point(180, 176);
            total_label.Name = "total_label";
            total_label.Size = new Size(83, 19);
            total_label.TabIndex = 35;
            total_label.Text = "Subtotal :";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(392, 587);
            Controls.Add(total_label);
            Controls.Add(discount_label);
            Controls.Add(tax_label);
            Controls.Add(subtotal_label);
            Controls.Add(orderlayoutpanel);
            Controls.Add(label10);
            Controls.Add(card_label);
            Controls.Add(CardText);
            Controls.Add(groupBox1);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(EmailText);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(PhoneText);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(AddressText);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NameText);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2";
            Text = "CheckoutForm";
            groupBox1.ResumeLayout(false);
            orderlayoutpanel.ResumeLayout(false);
            orderlayoutpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NameText;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label6;
        private Label label3;
        private Label label4;
        private TextBox AddressText;
        private Label label5;
        private Label label7;
        private TextBox PhoneText;
        private Label label8;
        private Label label9;
        private TextBox EmailText;
        private RadioButton rb_card;
        private RadioButton rb_cash;
        private GroupBox groupBox1;
        private TextBox CardText;
        private Label card_label;
        private Label label10;
        private FlowLayoutPanel orderlayoutpanel;
        private PictureBox pictureBox1;
        private Label label11;
        private Label label12;
        private Label subtotal_label;
        private Label tax_label;
        private Label discount_label;
        private Label total_label;
    }
}