
namespace AdminUIForm
{
    partial class UserForm
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
            this.topBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCheckout = new FontAwesome.Sharp.IconButton();
            this.btnAbout = new FontAwesome.Sharp.IconButton();
            this.btnCart = new FontAwesome.Sharp.IconButton();
            this.btnShop = new FontAwesome.Sharp.IconButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabShop = new System.Windows.Forms.TabPage();
            this.itemsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tabCart = new System.Windows.Forms.TabPage();
            this.btnProceedToCheckout = new System.Windows.Forms.Button();
            this.btnClearCart = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cartItemsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tabCheckout = new System.Windows.Forms.TabPage();
            this.btnProceed = new FontAwesome.Sharp.IconButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBackToCart = new FontAwesome.Sharp.IconButton();
            this.lblTotalCheckout = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.topBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabShop.SuspendLayout();
            this.tabCart.SuspendLayout();
            this.tabCheckout.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // topBar
            // 
            this.topBar.BackColor = System.Drawing.SystemColors.Highlight;
            this.topBar.Controls.Add(this.btnMinimize);
            this.topBar.Controls.Add(this.btnClose);
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(1280, 36);
            this.topBar.TabIndex = 0;
            this.topBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topBar_MouseMove);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinimize.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 30;
            this.btnMinimize.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimize.Location = new System.Drawing.Point(1202, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(36, 36);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnClose.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 30;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.Location = new System.Drawing.Point(1244, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 36);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.btnCheckout);
            this.panel1.Controls.Add(this.btnAbout);
            this.panel1.Controls.Add(this.btnCart);
            this.panel1.Controls.Add(this.btnShop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 684);
            this.panel1.TabIndex = 1;
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCheckout.FlatAppearance.BorderSize = 0;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.btnCheckout.IconColor = System.Drawing.Color.Black;
            this.btnCheckout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCheckout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckout.Location = new System.Drawing.Point(6, 158);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(225, 70);
            this.btnCheckout.TabIndex = 2;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.btnAbout.IconColor = System.Drawing.Color.Black;
            this.btnAbout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAbout.Location = new System.Drawing.Point(6, 634);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(225, 50);
            this.btnAbout.TabIndex = 2;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnCart
            // 
            this.btnCart.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCart.FlatAppearance.BorderSize = 0;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCart.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btnCart.IconColor = System.Drawing.Color.Black;
            this.btnCart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCart.Location = new System.Drawing.Point(6, 82);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(225, 70);
            this.btnCart.TabIndex = 2;
            this.btnCart.Text = "Cart";
            this.btnCart.UseVisualStyleBackColor = false;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnShop
            // 
            this.btnShop.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnShop.FlatAppearance.BorderSize = 0;
            this.btnShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShop.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShop.IconChar = FontAwesome.Sharp.IconChar.Scroll;
            this.btnShop.IconColor = System.Drawing.Color.Black;
            this.btnShop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShop.Location = new System.Drawing.Point(6, 6);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(225, 70);
            this.btnShop.TabIndex = 2;
            this.btnShop.Text = "Shop";
            this.btnShop.UseVisualStyleBackColor = false;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabShop);
            this.tabControl1.Controls.Add(this.tabCart);
            this.tabControl1.Controls.Add(this.tabCheckout);
            this.tabControl1.Location = new System.Drawing.Point(231, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1049, 708);
            this.tabControl1.TabIndex = 2;
            // 
            // tabShop
            // 
            this.tabShop.Controls.Add(this.itemsPanel);
            this.tabShop.Location = new System.Drawing.Point(4, 22);
            this.tabShop.Name = "tabShop";
            this.tabShop.Padding = new System.Windows.Forms.Padding(3);
            this.tabShop.Size = new System.Drawing.Size(1041, 658);
            this.tabShop.TabIndex = 3;
            this.tabShop.Text = "Shop";
            this.tabShop.UseVisualStyleBackColor = true;
            // 
            // itemsPanel
            // 
            this.itemsPanel.AutoScroll = true;
            this.itemsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsPanel.Location = new System.Drawing.Point(3, 3);
            this.itemsPanel.Name = "itemsPanel";
            this.itemsPanel.Size = new System.Drawing.Size(1035, 652);
            this.itemsPanel.TabIndex = 0;
            // 
            // tabCart
            // 
            this.tabCart.Controls.Add(this.btnProceedToCheckout);
            this.tabCart.Controls.Add(this.btnClearCart);
            this.tabCart.Controls.Add(this.lblTotal);
            this.tabCart.Controls.Add(this.label4);
            this.tabCart.Controls.Add(this.label3);
            this.tabCart.Controls.Add(this.cartItemsPanel);
            this.tabCart.Location = new System.Drawing.Point(4, 22);
            this.tabCart.Name = "tabCart";
            this.tabCart.Padding = new System.Windows.Forms.Padding(3);
            this.tabCart.Size = new System.Drawing.Size(1041, 682);
            this.tabCart.TabIndex = 1;
            this.tabCart.Text = "Cart";
            this.tabCart.UseVisualStyleBackColor = true;
            // 
            // btnProceedToCheckout
            // 
            this.btnProceedToCheckout.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnProceedToCheckout.FlatAppearance.BorderSize = 0;
            this.btnProceedToCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProceedToCheckout.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceedToCheckout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProceedToCheckout.Location = new System.Drawing.Point(711, 549);
            this.btnProceedToCheckout.Name = "btnProceedToCheckout";
            this.btnProceedToCheckout.Size = new System.Drawing.Size(267, 65);
            this.btnProceedToCheckout.TabIndex = 3;
            this.btnProceedToCheckout.Text = "Proceed to Checkout";
            this.btnProceedToCheckout.UseVisualStyleBackColor = false;
            this.btnProceedToCheckout.Click += new System.EventHandler(this.btnProceedToCheckout_Click);
            // 
            // btnClearCart
            // 
            this.btnClearCart.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnClearCart.FlatAppearance.BorderSize = 0;
            this.btnClearCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearCart.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearCart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClearCart.Location = new System.Drawing.Point(22, 388);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(137, 50);
            this.btnClearCart.TabIndex = 3;
            this.btnClearCart.Text = "Clear All";
            this.btnClearCart.UseVisualStyleBackColor = false;
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(745, 441);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(153, 42);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "0.00 BGN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(643, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 42);
            this.label4.TabIndex = 2;
            this.label4.Text = "Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "Items in cart:";
            // 
            // cartItemsPanel
            // 
            this.cartItemsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartItemsPanel.AutoScroll = true;
            this.cartItemsPanel.AutoSize = true;
            this.cartItemsPanel.Location = new System.Drawing.Point(6, 60);
            this.cartItemsPanel.Name = "cartItemsPanel";
            this.cartItemsPanel.Size = new System.Drawing.Size(1038, 336);
            this.cartItemsPanel.TabIndex = 0;
            this.cartItemsPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.cartItemsPanel_ControlAdded);
            this.cartItemsPanel.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.cartItemsPanel_ControlRemoved);
            // 
            // tabCheckout
            // 
            this.tabCheckout.Controls.Add(this.btnProceed);
            this.tabCheckout.Controls.Add(this.label12);
            this.tabCheckout.Controls.Add(this.label11);
            this.tabCheckout.Controls.Add(this.label10);
            this.tabCheckout.Controls.Add(this.label9);
            this.tabCheckout.Controls.Add(this.label8);
            this.tabCheckout.Controls.Add(this.dateBirthday);
            this.tabCheckout.Controls.Add(this.txtAddress);
            this.tabCheckout.Controls.Add(this.txtPhone);
            this.tabCheckout.Controls.Add(this.txtEmail);
            this.tabCheckout.Controls.Add(this.txtName);
            this.tabCheckout.Controls.Add(this.panel2);
            this.tabCheckout.Location = new System.Drawing.Point(4, 22);
            this.tabCheckout.Name = "tabCheckout";
            this.tabCheckout.Padding = new System.Windows.Forms.Padding(3);
            this.tabCheckout.Size = new System.Drawing.Size(1041, 658);
            this.tabCheckout.TabIndex = 2;
            this.tabCheckout.Text = "Checkout";
            this.tabCheckout.UseVisualStyleBackColor = true;
            // 
            // btnProceed
            // 
            this.btnProceed.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnProceed.FlatAppearance.BorderSize = 0;
            this.btnProceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProceed.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProceed.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            this.btnProceed.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProceed.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProceed.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnProceed.Location = new System.Drawing.Point(428, 530);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(188, 67);
            this.btnProceed.TabIndex = 4;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProceed.UseVisualStyleBackColor = false;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(362, 415);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 31);
            this.label12.TabIndex = 3;
            this.label12.Text = "Birthday";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(221, 328);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(263, 62);
            this.label11.TabIndex = 3;
            this.label11.Text = "Address\r\n(incl. city, address)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(283, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(207, 31);
            this.label10.TabIndex = 3;
            this.label10.Text = "Phone Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(283, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(201, 31);
            this.label9.TabIndex = 3;
            this.label9.Text = "Email Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(394, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 31);
            this.label8.TabIndex = 3;
            this.label8.Text = "Name";
            // 
            // dateBirthday
            // 
            this.dateBirthday.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBirthday.Location = new System.Drawing.Point(550, 409);
            this.dateBirthday.Name = "dateBirthday";
            this.dateBirthday.Size = new System.Drawing.Size(240, 40);
            this.dateBirthday.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(550, 339);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(240, 40);
            this.txtAddress.TabIndex = 1;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(550, 269);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(240, 40);
            this.txtPhone.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(550, 199);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(240, 40);
            this.txtEmail.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(550, 129);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(240, 40);
            this.txtName.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.btnBackToCart);
            this.panel2.Controls.Add(this.lblTotalCheckout);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1035, 51);
            this.panel2.TabIndex = 0;
            // 
            // btnBackToCart
            // 
            this.btnBackToCart.FlatAppearance.BorderSize = 0;
            this.btnBackToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToCart.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToCart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBackToCart.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.btnBackToCart.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBackToCart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBackToCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackToCart.Location = new System.Drawing.Point(3, 3);
            this.btnBackToCart.Name = "btnBackToCart";
            this.btnBackToCart.Size = new System.Drawing.Size(219, 46);
            this.btnBackToCart.TabIndex = 2;
            this.btnBackToCart.Text = "Back to cart";
            this.btnBackToCart.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnBackToCart.UseVisualStyleBackColor = true;
            this.btnBackToCart.Click += new System.EventHandler(this.btnBackToCart_Click);
            // 
            // lblTotalCheckout
            // 
            this.lblTotalCheckout.AutoSize = true;
            this.lblTotalCheckout.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCheckout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotalCheckout.Location = new System.Drawing.Point(787, 9);
            this.lblTotalCheckout.Name = "lblTotalCheckout";
            this.lblTotalCheckout.Size = new System.Drawing.Size(120, 33);
            this.lblTotalCheckout.TabIndex = 1;
            this.lblTotalCheckout.Text = "0.00 BGN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(695, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 33);
            this.label5.TabIndex = 1;
            this.label5.Text = "Total:";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.topBar);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.UserUIForm_Load);
            this.topBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabShop.ResumeLayout(false);
            this.tabCart.ResumeLayout(false);
            this.tabCart.PerformLayout();
            this.tabCheckout.ResumeLayout(false);
            this.tabCheckout.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topBar;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnShop;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnAbout;
        private FontAwesome.Sharp.IconButton btnCart;
        private FontAwesome.Sharp.IconButton btnCheckout;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCart;
        private System.Windows.Forms.TabPage tabCheckout;
        private System.Windows.Forms.TabPage tabShop;
        private System.Windows.Forms.FlowLayoutPanel itemsPanel;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel cartItemsPanel;
        private System.Windows.Forms.Button btnProceedToCheckout;
        private System.Windows.Forms.Button btnClearCart;
        private FontAwesome.Sharp.IconButton btnProceed;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateBirthday;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnBackToCart;
        private System.Windows.Forms.Label lblTotalCheckout;
        private System.Windows.Forms.Label label5;
    }
}

