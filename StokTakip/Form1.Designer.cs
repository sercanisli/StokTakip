
namespace StokTakip
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.gbx_Update = new System.Windows.Forms.GroupBox();
            this.dgView_Update = new System.Windows.Forms.DataGridView();
            this.gbx_Update_Products = new System.Windows.Forms.GroupBox();
            this.btn_Update_Update = new System.Windows.Forms.Button();
            this.nmrUD_Update_Price = new System.Windows.Forms.NumericUpDown();
            this.lbl_Update_Price = new System.Windows.Forms.Label();
            this.cbx_Update_Category = new System.Windows.Forms.ComboBox();
            this.nmrUD_Update_UnitInStock = new System.Windows.Forms.NumericUpDown();
            this.tbx_Update_ProdductName = new System.Windows.Forms.TextBox();
            this.lbl_Update_UnitInStock = new System.Windows.Forms.Label();
            this.lbl_Update_Category = new System.Windows.Forms.Label();
            this.lbl_Update_ProductName = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbx_Delete_Categories = new System.Windows.Forms.GroupBox();
            this.btn_Delete_Categories = new System.Windows.Forms.Button();
            this.dg_View_Delete_Categories = new System.Windows.Forms.DataGridView();
            this.gbx_Delete_Products = new System.Windows.Forms.GroupBox();
            this.lbl_Delete_Product = new System.Windows.Forms.Label();
            this.cbx_Delete_Products = new System.Windows.Forms.ComboBox();
            this.btn_Delete_DeleteProducts = new System.Windows.Forms.Button();
            this.dgView_Delete_Products = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.groupBoxAddProduct = new System.Windows.Forms.GroupBox();
            this.nmrUD_Add_Price = new System.Windows.Forms.NumericUpDown();
            this.lbl_Add_Price = new System.Windows.Forms.Label();
            this.btn_Add_Add = new System.Windows.Forms.Button();
            this.cmx_Add_ProductCategory = new System.Windows.Forms.ComboBox();
            this.nmrUD_add_UnitInStock = new System.Windows.Forms.NumericUpDown();
            this.tbx_Add_ProductName = new System.Windows.Forms.TextBox();
            this.lbl_Add_UnitInStock = new System.Windows.Forms.Label();
            this.lbl_Add_ProductCategory = new System.Windows.Forms.Label();
            this.lbl_Add_ProductName = new System.Windows.Forms.Label();
            this.groupBoxAddDataView = new System.Windows.Forms.GroupBox();
            this.dgView_Add_Product = new System.Windows.Forms.DataGridView();
            this.groupBoxAddCategory = new System.Windows.Forms.GroupBox();
            this.dgView_Add_Category = new System.Windows.Forms.DataGridView();
            this.btn_Add_Category = new System.Windows.Forms.Button();
            this.tbx_Add_CategoryName = new System.Windows.Forms.TextBox();
            this.lbl_Add_CategoryName = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4.SuspendLayout();
            this.gbx_Update.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView_Update)).BeginInit();
            this.gbx_Update_Products.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUD_Update_Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUD_Update_UnitInStock)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.gbx_Delete_Categories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_View_Delete_Categories)).BeginInit();
            this.gbx_Delete_Products.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView_Delete_Products)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBoxAdd.SuspendLayout();
            this.groupBoxAddProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUD_Add_Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUD_add_UnitInStock)).BeginInit();
            this.groupBoxAddDataView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView_Add_Product)).BeginInit();
            this.groupBoxAddCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView_Add_Category)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.gbx_Update);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(885, 521);
            this.tabPage4.TabIndex = 5;
            this.tabPage4.Text = "Update";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // gbx_Update
            // 
            this.gbx_Update.Controls.Add(this.dgView_Update);
            this.gbx_Update.Controls.Add(this.gbx_Update_Products);
            this.gbx_Update.Location = new System.Drawing.Point(6, 6);
            this.gbx_Update.Name = "gbx_Update";
            this.gbx_Update.Size = new System.Drawing.Size(873, 509);
            this.gbx_Update.TabIndex = 0;
            this.gbx_Update.TabStop = false;
            this.gbx_Update.Text = "Uptade Processes";
            // 
            // dgView_Update
            // 
            this.dgView_Update.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView_Update.Location = new System.Drawing.Point(6, 19);
            this.dgView_Update.Name = "dgView_Update";
            this.dgView_Update.Size = new System.Drawing.Size(861, 367);
            this.dgView_Update.TabIndex = 2;
            this.dgView_Update.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_Update_CellClick);
            // 
            // gbx_Update_Products
            // 
            this.gbx_Update_Products.Controls.Add(this.btn_Update_Update);
            this.gbx_Update_Products.Controls.Add(this.nmrUD_Update_Price);
            this.gbx_Update_Products.Controls.Add(this.lbl_Update_Price);
            this.gbx_Update_Products.Controls.Add(this.cbx_Update_Category);
            this.gbx_Update_Products.Controls.Add(this.nmrUD_Update_UnitInStock);
            this.gbx_Update_Products.Controls.Add(this.tbx_Update_ProdductName);
            this.gbx_Update_Products.Controls.Add(this.lbl_Update_UnitInStock);
            this.gbx_Update_Products.Controls.Add(this.lbl_Update_Category);
            this.gbx_Update_Products.Controls.Add(this.lbl_Update_ProductName);
            this.gbx_Update_Products.Location = new System.Drawing.Point(6, 392);
            this.gbx_Update_Products.Name = "gbx_Update_Products";
            this.gbx_Update_Products.Size = new System.Drawing.Size(861, 111);
            this.gbx_Update_Products.TabIndex = 1;
            this.gbx_Update_Products.TabStop = false;
            this.gbx_Update_Products.Text = "Product Information";
            // 
            // btn_Update_Update
            // 
            this.btn_Update_Update.Location = new System.Drawing.Point(732, 34);
            this.btn_Update_Update.Name = "btn_Update_Update";
            this.btn_Update_Update.Size = new System.Drawing.Size(113, 45);
            this.btn_Update_Update.TabIndex = 9;
            this.btn_Update_Update.Text = "UPDATE";
            this.btn_Update_Update.UseVisualStyleBackColor = true;
            this.btn_Update_Update.Click += new System.EventHandler(this.btn_Update_Update_Click);
            // 
            // nmrUD_Update_Price
            // 
            this.nmrUD_Update_Price.Location = new System.Drawing.Point(476, 64);
            this.nmrUD_Update_Price.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmrUD_Update_Price.Name = "nmrUD_Update_Price";
            this.nmrUD_Update_Price.Size = new System.Drawing.Size(199, 20);
            this.nmrUD_Update_Price.TabIndex = 8;
            this.nmrUD_Update_Price.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_Update_Price
            // 
            this.lbl_Update_Price.AutoSize = true;
            this.lbl_Update_Price.Location = new System.Drawing.Point(384, 66);
            this.lbl_Update_Price.Name = "lbl_Update_Price";
            this.lbl_Update_Price.Size = new System.Drawing.Size(77, 13);
            this.lbl_Update_Price.TabIndex = 7;
            this.lbl_Update_Price.Text = "Product Price :";
            // 
            // cbx_Update_Category
            // 
            this.cbx_Update_Category.FormattingEnabled = true;
            this.cbx_Update_Category.Location = new System.Drawing.Point(476, 19);
            this.cbx_Update_Category.Name = "cbx_Update_Category";
            this.cbx_Update_Category.Size = new System.Drawing.Size(199, 21);
            this.cbx_Update_Category.TabIndex = 5;
            // 
            // nmrUD_Update_UnitInStock
            // 
            this.nmrUD_Update_UnitInStock.Location = new System.Drawing.Point(138, 64);
            this.nmrUD_Update_UnitInStock.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmrUD_Update_UnitInStock.Name = "nmrUD_Update_UnitInStock";
            this.nmrUD_Update_UnitInStock.Size = new System.Drawing.Size(199, 20);
            this.nmrUD_Update_UnitInStock.TabIndex = 4;
            this.nmrUD_Update_UnitInStock.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbx_Update_ProdductName
            // 
            this.tbx_Update_ProdductName.Location = new System.Drawing.Point(138, 19);
            this.tbx_Update_ProdductName.Name = "tbx_Update_ProdductName";
            this.tbx_Update_ProdductName.Size = new System.Drawing.Size(199, 20);
            this.tbx_Update_ProdductName.TabIndex = 3;
            // 
            // lbl_Update_UnitInStock
            // 
            this.lbl_Update_UnitInStock.AutoSize = true;
            this.lbl_Update_UnitInStock.Location = new System.Drawing.Point(36, 66);
            this.lbl_Update_UnitInStock.Name = "lbl_Update_UnitInStock";
            this.lbl_Update_UnitInStock.Size = new System.Drawing.Size(83, 13);
            this.lbl_Update_UnitInStock.TabIndex = 2;
            this.lbl_Update_UnitInStock.Text = "Stock Quantity :";
            // 
            // lbl_Update_Category
            // 
            this.lbl_Update_Category.AutoSize = true;
            this.lbl_Update_Category.Location = new System.Drawing.Point(366, 22);
            this.lbl_Update_Category.Name = "lbl_Update_Category";
            this.lbl_Update_Category.Size = new System.Drawing.Size(95, 13);
            this.lbl_Update_Category.TabIndex = 1;
            this.lbl_Update_Category.Text = "Product Category :";
            // 
            // lbl_Update_ProductName
            // 
            this.lbl_Update_ProductName.AutoSize = true;
            this.lbl_Update_ProductName.Location = new System.Drawing.Point(47, 22);
            this.lbl_Update_ProductName.Name = "lbl_Update_ProductName";
            this.lbl_Update_ProductName.Size = new System.Drawing.Size(81, 13);
            this.lbl_Update_ProductName.TabIndex = 0;
            this.lbl_Update_ProductName.Text = "Product Name :";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbx_Delete_Categories);
            this.tabPage1.Controls.Add(this.gbx_Delete_Products);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(885, 521);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Delete";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gbx_Delete_Categories
            // 
            this.gbx_Delete_Categories.Controls.Add(this.btn_Delete_Categories);
            this.gbx_Delete_Categories.Controls.Add(this.dg_View_Delete_Categories);
            this.gbx_Delete_Categories.Location = new System.Drawing.Point(457, 6);
            this.gbx_Delete_Categories.Name = "gbx_Delete_Categories";
            this.gbx_Delete_Categories.Size = new System.Drawing.Size(422, 509);
            this.gbx_Delete_Categories.TabIndex = 1;
            this.gbx_Delete_Categories.TabStop = false;
            this.gbx_Delete_Categories.Text = "Categories";
            // 
            // btn_Delete_Categories
            // 
            this.btn_Delete_Categories.Location = new System.Drawing.Point(316, 44);
            this.btn_Delete_Categories.Name = "btn_Delete_Categories";
            this.btn_Delete_Categories.Size = new System.Drawing.Size(100, 37);
            this.btn_Delete_Categories.TabIndex = 2;
            this.btn_Delete_Categories.Text = "DELETE";
            this.btn_Delete_Categories.UseVisualStyleBackColor = true;
            this.btn_Delete_Categories.Click += new System.EventHandler(this.btn_Delete_Categories_Click);
            // 
            // dg_View_Delete_Categories
            // 
            this.dg_View_Delete_Categories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_View_Delete_Categories.Location = new System.Drawing.Point(6, 98);
            this.dg_View_Delete_Categories.Name = "dg_View_Delete_Categories";
            this.dg_View_Delete_Categories.Size = new System.Drawing.Size(410, 405);
            this.dg_View_Delete_Categories.TabIndex = 1;
            // 
            // gbx_Delete_Products
            // 
            this.gbx_Delete_Products.Controls.Add(this.lbl_Delete_Product);
            this.gbx_Delete_Products.Controls.Add(this.cbx_Delete_Products);
            this.gbx_Delete_Products.Controls.Add(this.btn_Delete_DeleteProducts);
            this.gbx_Delete_Products.Controls.Add(this.dgView_Delete_Products);
            this.gbx_Delete_Products.Location = new System.Drawing.Point(6, 6);
            this.gbx_Delete_Products.Name = "gbx_Delete_Products";
            this.gbx_Delete_Products.Size = new System.Drawing.Size(418, 509);
            this.gbx_Delete_Products.TabIndex = 0;
            this.gbx_Delete_Products.TabStop = false;
            this.gbx_Delete_Products.Text = "Products";
            // 
            // lbl_Delete_Product
            // 
            this.lbl_Delete_Product.AutoSize = true;
            this.lbl_Delete_Product.Location = new System.Drawing.Point(6, 35);
            this.lbl_Delete_Product.Name = "lbl_Delete_Product";
            this.lbl_Delete_Product.Size = new System.Drawing.Size(89, 13);
            this.lbl_Delete_Product.TabIndex = 3;
            this.lbl_Delete_Product.Text = "List By Category :";
            // 
            // cbx_Delete_Products
            // 
            this.cbx_Delete_Products.FormattingEnabled = true;
            this.cbx_Delete_Products.Location = new System.Drawing.Point(6, 53);
            this.cbx_Delete_Products.Name = "cbx_Delete_Products";
            this.cbx_Delete_Products.Size = new System.Drawing.Size(213, 21);
            this.cbx_Delete_Products.TabIndex = 2;
            this.cbx_Delete_Products.SelectedIndexChanged += new System.EventHandler(this.cbx_Delete_Products_SelectedIndexChanged);
            // 
            // btn_Delete_DeleteProducts
            // 
            this.btn_Delete_DeleteProducts.Location = new System.Drawing.Point(320, 44);
            this.btn_Delete_DeleteProducts.Name = "btn_Delete_DeleteProducts";
            this.btn_Delete_DeleteProducts.Size = new System.Drawing.Size(92, 37);
            this.btn_Delete_DeleteProducts.TabIndex = 1;
            this.btn_Delete_DeleteProducts.Text = "DELETE";
            this.btn_Delete_DeleteProducts.UseVisualStyleBackColor = true;
            this.btn_Delete_DeleteProducts.Click += new System.EventHandler(this.btn_Delete_DeleteProducts_Click_1);
            // 
            // dgView_Delete_Products
            // 
            this.dgView_Delete_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView_Delete_Products.Location = new System.Drawing.Point(6, 98);
            this.dgView_Delete_Products.Name = "dgView_Delete_Products";
            this.dgView_Delete_Products.Size = new System.Drawing.Size(406, 405);
            this.dgView_Delete_Products.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBoxAdd);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(885, 521);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Add";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Controls.Add(this.groupBoxAddProduct);
            this.groupBoxAdd.Controls.Add(this.groupBoxAddDataView);
            this.groupBoxAdd.Controls.Add(this.groupBoxAddCategory);
            this.groupBoxAdd.Location = new System.Drawing.Point(13, 18);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Size = new System.Drawing.Size(866, 497);
            this.groupBoxAdd.TabIndex = 0;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Text = "Add Operations";
            // 
            // groupBoxAddProduct
            // 
            this.groupBoxAddProduct.Controls.Add(this.nmrUD_Add_Price);
            this.groupBoxAddProduct.Controls.Add(this.lbl_Add_Price);
            this.groupBoxAddProduct.Controls.Add(this.btn_Add_Add);
            this.groupBoxAddProduct.Controls.Add(this.cmx_Add_ProductCategory);
            this.groupBoxAddProduct.Controls.Add(this.nmrUD_add_UnitInStock);
            this.groupBoxAddProduct.Controls.Add(this.tbx_Add_ProductName);
            this.groupBoxAddProduct.Controls.Add(this.lbl_Add_UnitInStock);
            this.groupBoxAddProduct.Controls.Add(this.lbl_Add_ProductCategory);
            this.groupBoxAddProduct.Controls.Add(this.lbl_Add_ProductName);
            this.groupBoxAddProduct.Location = new System.Drawing.Point(16, 19);
            this.groupBoxAddProduct.Name = "groupBoxAddProduct";
            this.groupBoxAddProduct.Size = new System.Drawing.Size(421, 216);
            this.groupBoxAddProduct.TabIndex = 0;
            this.groupBoxAddProduct.TabStop = false;
            this.groupBoxAddProduct.Text = "Add For Products";
            // 
            // nmrUD_Add_Price
            // 
            this.nmrUD_Add_Price.Location = new System.Drawing.Point(138, 90);
            this.nmrUD_Add_Price.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmrUD_Add_Price.Name = "nmrUD_Add_Price";
            this.nmrUD_Add_Price.Size = new System.Drawing.Size(199, 20);
            this.nmrUD_Add_Price.TabIndex = 8;
            this.nmrUD_Add_Price.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_Add_Price
            // 
            this.lbl_Add_Price.AutoSize = true;
            this.lbl_Add_Price.Location = new System.Drawing.Point(47, 92);
            this.lbl_Add_Price.Name = "lbl_Add_Price";
            this.lbl_Add_Price.Size = new System.Drawing.Size(77, 13);
            this.lbl_Add_Price.TabIndex = 7;
            this.lbl_Add_Price.Text = "Product Price :";
            // 
            // btn_Add_Add
            // 
            this.btn_Add_Add.Location = new System.Drawing.Point(228, 160);
            this.btn_Add_Add.Name = "btn_Add_Add";
            this.btn_Add_Add.Size = new System.Drawing.Size(109, 34);
            this.btn_Add_Add.TabIndex = 6;
            this.btn_Add_Add.Text = "ADD";
            this.btn_Add_Add.UseVisualStyleBackColor = true;
            this.btn_Add_Add.Click += new System.EventHandler(this.btn_Add_Add_Click);
            // 
            // cmx_Add_ProductCategory
            // 
            this.cmx_Add_ProductCategory.FormattingEnabled = true;
            this.cmx_Add_ProductCategory.Location = new System.Drawing.Point(138, 57);
            this.cmx_Add_ProductCategory.Name = "cmx_Add_ProductCategory";
            this.cmx_Add_ProductCategory.Size = new System.Drawing.Size(199, 21);
            this.cmx_Add_ProductCategory.TabIndex = 5;
            // 
            // nmrUD_add_UnitInStock
            // 
            this.nmrUD_add_UnitInStock.Location = new System.Drawing.Point(138, 121);
            this.nmrUD_add_UnitInStock.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmrUD_add_UnitInStock.Name = "nmrUD_add_UnitInStock";
            this.nmrUD_add_UnitInStock.Size = new System.Drawing.Size(199, 20);
            this.nmrUD_add_UnitInStock.TabIndex = 4;
            this.nmrUD_add_UnitInStock.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbx_Add_ProductName
            // 
            this.tbx_Add_ProductName.Location = new System.Drawing.Point(138, 19);
            this.tbx_Add_ProductName.Name = "tbx_Add_ProductName";
            this.tbx_Add_ProductName.Size = new System.Drawing.Size(199, 20);
            this.tbx_Add_ProductName.TabIndex = 3;
            // 
            // lbl_Add_UnitInStock
            // 
            this.lbl_Add_UnitInStock.AutoSize = true;
            this.lbl_Add_UnitInStock.Location = new System.Drawing.Point(41, 123);
            this.lbl_Add_UnitInStock.Name = "lbl_Add_UnitInStock";
            this.lbl_Add_UnitInStock.Size = new System.Drawing.Size(83, 13);
            this.lbl_Add_UnitInStock.TabIndex = 2;
            this.lbl_Add_UnitInStock.Text = "Stock Quantity :";
            // 
            // lbl_Add_ProductCategory
            // 
            this.lbl_Add_ProductCategory.AutoSize = true;
            this.lbl_Add_ProductCategory.Location = new System.Drawing.Point(29, 60);
            this.lbl_Add_ProductCategory.Name = "lbl_Add_ProductCategory";
            this.lbl_Add_ProductCategory.Size = new System.Drawing.Size(95, 13);
            this.lbl_Add_ProductCategory.TabIndex = 1;
            this.lbl_Add_ProductCategory.Text = "Product Category :";
            // 
            // lbl_Add_ProductName
            // 
            this.lbl_Add_ProductName.AutoSize = true;
            this.lbl_Add_ProductName.Location = new System.Drawing.Point(47, 22);
            this.lbl_Add_ProductName.Name = "lbl_Add_ProductName";
            this.lbl_Add_ProductName.Size = new System.Drawing.Size(81, 13);
            this.lbl_Add_ProductName.TabIndex = 0;
            this.lbl_Add_ProductName.Text = "Product Name :";
            // 
            // groupBoxAddDataView
            // 
            this.groupBoxAddDataView.Controls.Add(this.dgView_Add_Product);
            this.groupBoxAddDataView.Location = new System.Drawing.Point(10, 241);
            this.groupBoxAddDataView.Name = "groupBoxAddDataView";
            this.groupBoxAddDataView.Size = new System.Drawing.Size(845, 245);
            this.groupBoxAddDataView.TabIndex = 2;
            this.groupBoxAddDataView.TabStop = false;
            this.groupBoxAddDataView.Text = "List of Products";
            // 
            // dgView_Add_Product
            // 
            this.dgView_Add_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView_Add_Product.Location = new System.Drawing.Point(6, 25);
            this.dgView_Add_Product.Name = "dgView_Add_Product";
            this.dgView_Add_Product.Size = new System.Drawing.Size(833, 214);
            this.dgView_Add_Product.TabIndex = 0;
            // 
            // groupBoxAddCategory
            // 
            this.groupBoxAddCategory.Controls.Add(this.dgView_Add_Category);
            this.groupBoxAddCategory.Controls.Add(this.btn_Add_Category);
            this.groupBoxAddCategory.Controls.Add(this.tbx_Add_CategoryName);
            this.groupBoxAddCategory.Controls.Add(this.lbl_Add_CategoryName);
            this.groupBoxAddCategory.Location = new System.Drawing.Point(455, 19);
            this.groupBoxAddCategory.Name = "groupBoxAddCategory";
            this.groupBoxAddCategory.Size = new System.Drawing.Size(400, 216);
            this.groupBoxAddCategory.TabIndex = 1;
            this.groupBoxAddCategory.TabStop = false;
            this.groupBoxAddCategory.Text = "Add For Category";
            // 
            // dgView_Add_Category
            // 
            this.dgView_Add_Category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView_Add_Category.Location = new System.Drawing.Point(6, 60);
            this.dgView_Add_Category.Name = "dgView_Add_Category";
            this.dgView_Add_Category.Size = new System.Drawing.Size(388, 150);
            this.dgView_Add_Category.TabIndex = 3;
            // 
            // btn_Add_Category
            // 
            this.btn_Add_Category.Location = new System.Drawing.Point(285, 8);
            this.btn_Add_Category.Name = "btn_Add_Category";
            this.btn_Add_Category.Size = new System.Drawing.Size(109, 34);
            this.btn_Add_Category.TabIndex = 2;
            this.btn_Add_Category.Text = "ADD";
            this.btn_Add_Category.UseVisualStyleBackColor = true;
            this.btn_Add_Category.Click += new System.EventHandler(this.btn_Add_Category_Click);
            // 
            // tbx_Add_CategoryName
            // 
            this.tbx_Add_CategoryName.Location = new System.Drawing.Point(95, 22);
            this.tbx_Add_CategoryName.Name = "tbx_Add_CategoryName";
            this.tbx_Add_CategoryName.Size = new System.Drawing.Size(168, 20);
            this.tbx_Add_CategoryName.TabIndex = 1;
            // 
            // lbl_Add_CategoryName
            // 
            this.lbl_Add_CategoryName.AutoSize = true;
            this.lbl_Add_CategoryName.Location = new System.Drawing.Point(6, 26);
            this.lbl_Add_CategoryName.Name = "lbl_Add_CategoryName";
            this.lbl_Add_CategoryName.Size = new System.Drawing.Size(83, 13);
            this.lbl_Add_CategoryName.TabIndex = 0;
            this.lbl_Add_CategoryName.Text = "Category Name:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(893, 547);
            this.tabControl1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 566);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage4.ResumeLayout(false);
            this.gbx_Update.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgView_Update)).EndInit();
            this.gbx_Update_Products.ResumeLayout(false);
            this.gbx_Update_Products.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUD_Update_Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUD_Update_UnitInStock)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.gbx_Delete_Categories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_View_Delete_Categories)).EndInit();
            this.gbx_Delete_Products.ResumeLayout(false);
            this.gbx_Delete_Products.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView_Delete_Products)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBoxAdd.ResumeLayout(false);
            this.groupBoxAddProduct.ResumeLayout(false);
            this.groupBoxAddProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUD_Add_Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUD_add_UnitInStock)).EndInit();
            this.groupBoxAddDataView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgView_Add_Product)).EndInit();
            this.groupBoxAddCategory.ResumeLayout(false);
            this.groupBoxAddCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView_Add_Category)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox gbx_Update;
        private System.Windows.Forms.DataGridView dgView_Update;
        private System.Windows.Forms.GroupBox gbx_Update_Products;
        private System.Windows.Forms.NumericUpDown nmrUD_Update_Price;
        private System.Windows.Forms.Label lbl_Update_Price;
        private System.Windows.Forms.ComboBox cbx_Update_Category;
        private System.Windows.Forms.NumericUpDown nmrUD_Update_UnitInStock;
        private System.Windows.Forms.TextBox tbx_Update_ProdductName;
        private System.Windows.Forms.Label lbl_Update_UnitInStock;
        private System.Windows.Forms.Label lbl_Update_Category;
        private System.Windows.Forms.Label lbl_Update_ProductName;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox gbx_Delete_Categories;
        private System.Windows.Forms.Button btn_Delete_Categories;
        private System.Windows.Forms.DataGridView dg_View_Delete_Categories;
        private System.Windows.Forms.GroupBox gbx_Delete_Products;
        private System.Windows.Forms.Button btn_Delete_DeleteProducts;
        private System.Windows.Forms.DataGridView dgView_Delete_Products;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.GroupBox groupBoxAddProduct;
        private System.Windows.Forms.NumericUpDown nmrUD_Add_Price;
        private System.Windows.Forms.Label lbl_Add_Price;
        private System.Windows.Forms.Button btn_Add_Add;
        private System.Windows.Forms.ComboBox cmx_Add_ProductCategory;
        private System.Windows.Forms.NumericUpDown nmrUD_add_UnitInStock;
        private System.Windows.Forms.TextBox tbx_Add_ProductName;
        private System.Windows.Forms.Label lbl_Add_UnitInStock;
        private System.Windows.Forms.Label lbl_Add_ProductCategory;
        private System.Windows.Forms.Label lbl_Add_ProductName;
        private System.Windows.Forms.GroupBox groupBoxAddDataView;
        private System.Windows.Forms.DataGridView dgView_Add_Product;
        private System.Windows.Forms.GroupBox groupBoxAddCategory;
        private System.Windows.Forms.DataGridView dgView_Add_Category;
        private System.Windows.Forms.Button btn_Add_Category;
        private System.Windows.Forms.TextBox tbx_Add_CategoryName;
        private System.Windows.Forms.Label lbl_Add_CategoryName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label lbl_Delete_Product;
        private System.Windows.Forms.ComboBox cbx_Delete_Products;
        private System.Windows.Forms.Button btn_Update_Update;
    }
}

