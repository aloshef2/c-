namespace test
{
    partial class Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelproduct = new System.Windows.Forms.Panel();
            this.addProduct = new System.Windows.Forms.Button();
            this.productAll = new System.Windows.Forms.Button();
            this.product = new System.Windows.Forms.Button();
            this.panelrecipt = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.AllRicept = new System.Windows.Forms.Button();
            this.recipt = new System.Windows.Forms.Button();
            this.panelapp = new System.Windows.Forms.Panel();
            this.appcreate = new System.Windows.Forms.Button();
            this.allapp = new System.Windows.Forms.Button();
            this.app = new System.Windows.Forms.Button();
            this.otchet = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.Panel();
            this.homePanel = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.panelproduct.SuspendLayout();
            this.panelrecipt.SuspendLayout();
            this.panelapp.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.Black;
            this.panelSideMenu.Controls.Add(this.panelproduct);
            this.panelSideMenu.Controls.Add(this.product);
            this.panelSideMenu.Controls.Add(this.panelrecipt);
            this.panelSideMenu.Controls.Add(this.recipt);
            this.panelSideMenu.Controls.Add(this.panelapp);
            this.panelSideMenu.Controls.Add(this.app);
            this.panelSideMenu.Controls.Add(this.otchet);
            this.panelSideMenu.Controls.Add(this.logo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(20, 60);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(190, 481);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panelproduct
            // 
            this.panelproduct.Controls.Add(this.addProduct);
            this.panelproduct.Controls.Add(this.productAll);
            this.panelproduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelproduct.Location = new System.Drawing.Point(0, 476);
            this.panelproduct.Name = "panelproduct";
            this.panelproduct.Size = new System.Drawing.Size(173, 109);
            this.panelproduct.TabIndex = 7;
            // 
            // addProduct
            // 
            this.addProduct.BackColor = System.Drawing.Color.DimGray;
            this.addProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.addProduct.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.addProduct.FlatAppearance.BorderSize = 0;
            this.addProduct.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProduct.ForeColor = System.Drawing.Color.White;
            this.addProduct.Location = new System.Drawing.Point(0, 45);
            this.addProduct.Name = "addProduct";
            this.addProduct.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.addProduct.Size = new System.Drawing.Size(173, 45);
            this.addProduct.TabIndex = 1;
            this.addProduct.Text = "Добавить продукт";
            this.addProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addProduct.UseVisualStyleBackColor = false;
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // productAll
            // 
            this.productAll.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.productAll.BackColor = System.Drawing.Color.DimGray;
            this.productAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.productAll.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.productAll.FlatAppearance.BorderSize = 0;
            this.productAll.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.productAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productAll.ForeColor = System.Drawing.Color.White;
            this.productAll.Location = new System.Drawing.Point(0, 0);
            this.productAll.Name = "productAll";
            this.productAll.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.productAll.Size = new System.Drawing.Size(173, 45);
            this.productAll.TabIndex = 0;
            this.productAll.Text = "Все продукты";
            this.productAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productAll.UseVisualStyleBackColor = false;
            this.productAll.Click += new System.EventHandler(this.productAll_Click);
            // 
            // product
            // 
            this.product.Dock = System.Windows.Forms.DockStyle.Top;
            this.product.FlatAppearance.BorderSize = 0;
            this.product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.product.ForeColor = System.Drawing.Color.White;
            this.product.Location = new System.Drawing.Point(0, 421);
            this.product.Name = "product";
            this.product.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.product.Size = new System.Drawing.Size(173, 55);
            this.product.TabIndex = 6;
            this.product.Text = "Продукты";
            this.product.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.product.UseVisualStyleBackColor = true;
            this.product.Click += new System.EventHandler(this.product_Click);
            // 
            // panelrecipt
            // 
            this.panelrecipt.Controls.Add(this.button1);
            this.panelrecipt.Controls.Add(this.AllRicept);
            this.panelrecipt.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelrecipt.Location = new System.Drawing.Point(0, 350);
            this.panelrecipt.Name = "panelrecipt";
            this.panelrecipt.Size = new System.Drawing.Size(173, 71);
            this.panelrecipt.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 45);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(173, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "Создать";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AllRicept
            // 
            this.AllRicept.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.AllRicept.BackColor = System.Drawing.Color.DimGray;
            this.AllRicept.Dock = System.Windows.Forms.DockStyle.Top;
            this.AllRicept.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.AllRicept.FlatAppearance.BorderSize = 0;
            this.AllRicept.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AllRicept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllRicept.ForeColor = System.Drawing.Color.White;
            this.AllRicept.Location = new System.Drawing.Point(0, 0);
            this.AllRicept.Name = "AllRicept";
            this.AllRicept.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.AllRicept.Size = new System.Drawing.Size(173, 45);
            this.AllRicept.TabIndex = 0;
            this.AllRicept.Text = "Все заявки";
            this.AllRicept.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AllRicept.UseVisualStyleBackColor = false;
            this.AllRicept.Click += new System.EventHandler(this.button2_Click);
            // 
            // recipt
            // 
            this.recipt.Dock = System.Windows.Forms.DockStyle.Top;
            this.recipt.FlatAppearance.BorderSize = 0;
            this.recipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recipt.ForeColor = System.Drawing.Color.White;
            this.recipt.Location = new System.Drawing.Point(0, 295);
            this.recipt.Name = "recipt";
            this.recipt.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.recipt.Size = new System.Drawing.Size(173, 55);
            this.recipt.TabIndex = 4;
            this.recipt.Text = "Рецепты";
            this.recipt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.recipt.UseVisualStyleBackColor = true;
            this.recipt.Click += new System.EventHandler(this.recipt_Click);
            // 
            // panelapp
            // 
            this.panelapp.Controls.Add(this.appcreate);
            this.panelapp.Controls.Add(this.allapp);
            this.panelapp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelapp.Location = new System.Drawing.Point(0, 229);
            this.panelapp.Name = "panelapp";
            this.panelapp.Size = new System.Drawing.Size(173, 66);
            this.panelapp.TabIndex = 3;
            // 
            // appcreate
            // 
            this.appcreate.BackColor = System.Drawing.Color.DimGray;
            this.appcreate.Dock = System.Windows.Forms.DockStyle.Top;
            this.appcreate.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.appcreate.FlatAppearance.BorderSize = 0;
            this.appcreate.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.appcreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appcreate.ForeColor = System.Drawing.Color.White;
            this.appcreate.Location = new System.Drawing.Point(0, 30);
            this.appcreate.Name = "appcreate";
            this.appcreate.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.appcreate.Size = new System.Drawing.Size(173, 33);
            this.appcreate.TabIndex = 1;
            this.appcreate.Text = "Создать";
            this.appcreate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.appcreate.UseVisualStyleBackColor = false;
            this.appcreate.Click += new System.EventHandler(this.appcreate_Click);
            // 
            // allapp
            // 
            this.allapp.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.allapp.BackColor = System.Drawing.Color.DimGray;
            this.allapp.Dock = System.Windows.Forms.DockStyle.Top;
            this.allapp.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.allapp.FlatAppearance.BorderSize = 0;
            this.allapp.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.allapp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allapp.ForeColor = System.Drawing.Color.White;
            this.allapp.Location = new System.Drawing.Point(0, 0);
            this.allapp.Name = "allapp";
            this.allapp.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.allapp.Size = new System.Drawing.Size(173, 30);
            this.allapp.TabIndex = 0;
            this.allapp.Text = "Все заявки";
            this.allapp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.allapp.UseVisualStyleBackColor = false;
            this.allapp.Click += new System.EventHandler(this.allapp_Click);
            // 
            // app
            // 
            this.app.Dock = System.Windows.Forms.DockStyle.Top;
            this.app.FlatAppearance.BorderSize = 0;
            this.app.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.app.ForeColor = System.Drawing.Color.White;
            this.app.Location = new System.Drawing.Point(0, 189);
            this.app.Name = "app";
            this.app.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.app.Size = new System.Drawing.Size(173, 40);
            this.app.TabIndex = 2;
            this.app.Text = "Заявка";
            this.app.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.app.UseVisualStyleBackColor = true;
            this.app.Click += new System.EventHandler(this.app_Click);
            // 
            // otchet
            // 
            this.otchet.Dock = System.Windows.Forms.DockStyle.Top;
            this.otchet.FlatAppearance.BorderSize = 0;
            this.otchet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.otchet.ForeColor = System.Drawing.Color.White;
            this.otchet.Location = new System.Drawing.Point(0, 149);
            this.otchet.Name = "otchet";
            this.otchet.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.otchet.Size = new System.Drawing.Size(173, 40);
            this.otchet.TabIndex = 1;
            this.otchet.Text = "Отчет";
            this.otchet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.otchet.UseVisualStyleBackColor = true;
            // 
            // logo
            // 
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.logo.Size = new System.Drawing.Size(173, 149);
            this.logo.TabIndex = 0;
            this.logo.Paint += new System.Windows.Forms.PaintEventHandler(this.logo_Paint);
            // 
            // homePanel
            // 
            this.homePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homePanel.Location = new System.Drawing.Point(210, 60);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(504, 481);
            this.homePanel.TabIndex = 1;
            this.homePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.homePanel_Paint);
            // 
            // Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(734, 561);
            this.Controls.Add(this.homePanel);
            this.Controls.Add(this.panelSideMenu);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelproduct.ResumeLayout(false);
            this.panelrecipt.ResumeLayout(false);
            this.panelapp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelapp;
        private System.Windows.Forms.Button appcreate;
        private System.Windows.Forms.Button allapp;
        private System.Windows.Forms.Button app;
        private System.Windows.Forms.Button otchet;
        public System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Panel panelrecipt;
        private System.Windows.Forms.Button AllRicept;
        private System.Windows.Forms.Button recipt;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Panel panelproduct;
        private System.Windows.Forms.Button addProduct;
        private System.Windows.Forms.Button productAll;
        private System.Windows.Forms.Button product;
        private System.Windows.Forms.Button button1;
    }
}

