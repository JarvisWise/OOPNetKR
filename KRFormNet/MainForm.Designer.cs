namespace KRFormNet
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.windows = new System.Windows.Forms.TabControl();
            this.ShopTab = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SearchByName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ShopTable = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Minus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BasketTab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TotalNumberLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.WithDiscount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.WithoutDiscount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BuyButton = new System.Windows.Forms.Button();
            this.Basket = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShopInfoTab = new System.Windows.Forms.TabPage();
            this.DOBTextBox = new System.Windows.Forms.RichTextBox();
            this.TNameTextBox = new System.Windows.Forms.RichTextBox();
            this.SNameTextBox = new System.Windows.Forms.RichTextBox();
            this.FNameTextBox = new System.Windows.Forms.RichTextBox();
            this.DInfoTextBox = new System.Windows.Forms.RichTextBox();
            this.EndTimeTextBox = new System.Windows.Forms.RichTextBox();
            this.StartTimeTextBox = new System.Windows.Forms.RichTextBox();
            this.ShopNameTextBox = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.windows.SuspendLayout();
            this.ShopTab.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShopTable)).BeginInit();
            this.BasketTab.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Basket)).BeginInit();
            this.ShopInfoTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // windows
            // 
            this.windows.Controls.Add(this.ShopTab);
            this.windows.Controls.Add(this.BasketTab);
            this.windows.Controls.Add(this.ShopInfoTab);
            this.windows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.windows.Location = new System.Drawing.Point(0, 0);
            this.windows.Name = "windows";
            this.windows.SelectedIndex = 0;
            this.windows.Size = new System.Drawing.Size(815, 450);
            this.windows.TabIndex = 1;
            // 
            // ShopTab
            // 
            this.ShopTab.AutoScroll = true;
            this.ShopTab.Controls.Add(this.panel2);
            this.ShopTab.Controls.Add(this.ShopTable);
            this.ShopTab.Location = new System.Drawing.Point(4, 22);
            this.ShopTab.Name = "ShopTab";
            this.ShopTab.Padding = new System.Windows.Forms.Padding(3);
            this.ShopTab.Size = new System.Drawing.Size(807, 424);
            this.ShopTab.TabIndex = 0;
            this.ShopTab.Text = "Shop";
            this.ShopTab.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SearchByName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(8, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(791, 34);
            this.panel2.TabIndex = 1;
            // 
            // SearchByName
            // 
            this.SearchByName.Location = new System.Drawing.Point(138, 9);
            this.SearchByName.Name = "SearchByName";
            this.SearchByName.Size = new System.Drawing.Size(638, 20);
            this.SearchByName.TabIndex = 1;
            this.SearchByName.TextChanged += new System.EventHandler(this.SearchByName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search by product name: ";
            // 
            // ShopTable
            // 
            this.ShopTable.AllowUserToAddRows = false;
            this.ShopTable.AllowUserToDeleteRows = false;
            this.ShopTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ShopTable.BackgroundColor = System.Drawing.Color.White;
            this.ShopTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.ShopTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ShopTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.ShopTable.ColumnHeadersHeight = 17;
            this.ShopTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ShopTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ProductName,
            this.Price,
            this.ProductNumber,
            this.Plus,
            this.Number,
            this.Minus,
            this.Add});
            this.ShopTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ShopTable.EnableHeadersVisualStyles = false;
            this.ShopTable.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShopTable.Location = new System.Drawing.Point(3, 47);
            this.ShopTable.Name = "ShopTable";
            this.ShopTable.ReadOnly = true;
            this.ShopTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ShopTable.RowHeadersVisible = false;
            this.ShopTable.Size = new System.Drawing.Size(801, 374);
            this.ShopTable.TabIndex = 0;
            this.ShopTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShopTable_CellClick);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 40;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 99;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 55;
            // 
            // ProductNumber
            // 
            this.ProductNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProductNumber.HeaderText = "Number of product";
            this.ProductNumber.Name = "ProductNumber";
            this.ProductNumber.ReadOnly = true;
            this.ProductNumber.Width = 119;
            // 
            // Plus
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Crimson;
            this.Plus.DefaultCellStyle = dataGridViewCellStyle9;
            this.Plus.HeaderText = " ";
            this.Plus.MinimumWidth = 20;
            this.Plus.Name = "Plus";
            this.Plus.ReadOnly = true;
            // 
            // Number
            // 
            this.Number.HeaderText = " ";
            this.Number.MinimumWidth = 20;
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // Minus
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Crimson;
            this.Minus.DefaultCellStyle = dataGridViewCellStyle10;
            this.Minus.HeaderText = "";
            this.Minus.MinimumWidth = 20;
            this.Minus.Name = "Minus";
            this.Minus.ReadOnly = true;
            // 
            // Add
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.OrangeRed;
            this.Add.DefaultCellStyle = dataGridViewCellStyle11;
            this.Add.HeaderText = " ";
            this.Add.Name = "Add";
            this.Add.ReadOnly = true;
            // 
            // BasketTab
            // 
            this.BasketTab.Controls.Add(this.panel1);
            this.BasketTab.Controls.Add(this.Basket);
            this.BasketTab.Cursor = System.Windows.Forms.Cursors.Default;
            this.BasketTab.Location = new System.Drawing.Point(4, 22);
            this.BasketTab.Name = "BasketTab";
            this.BasketTab.Padding = new System.Windows.Forms.Padding(3);
            this.BasketTab.Size = new System.Drawing.Size(807, 424);
            this.BasketTab.TabIndex = 1;
            this.BasketTab.Text = "Basket";
            this.BasketTab.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TotalNumberLabel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.WithDiscount);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.WithoutDiscount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BuyButton);
            this.panel1.Location = new System.Drawing.Point(8, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 36);
            this.panel1.TabIndex = 1;
            // 
            // TotalNumberLabel
            // 
            this.TotalNumberLabel.AutoSize = true;
            this.TotalNumberLabel.Location = new System.Drawing.Point(152, 12);
            this.TotalNumberLabel.Name = "TotalNumberLabel";
            this.TotalNumberLabel.Size = new System.Drawing.Size(13, 13);
            this.TotalNumberLabel.TabIndex = 8;
            this.TotalNumberLabel.Text = "[]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Total number of products:";
            // 
            // WithDiscount
            // 
            this.WithDiscount.AutoSize = true;
            this.WithDiscount.Location = new System.Drawing.Point(579, 12);
            this.WithDiscount.Name = "WithDiscount";
            this.WithDiscount.Size = new System.Drawing.Size(13, 13);
            this.WithDiscount.TabIndex = 6;
            this.WithDiscount.Text = "[]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(477, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cost with discount:";
            // 
            // WithoutDiscount
            // 
            this.WithoutDiscount.AutoSize = true;
            this.WithoutDiscount.Location = new System.Drawing.Point(372, 12);
            this.WithoutDiscount.Name = "WithoutDiscount";
            this.WithoutDiscount.Size = new System.Drawing.Size(13, 13);
            this.WithoutDiscount.TabIndex = 4;
            this.WithoutDiscount.Text = "[]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cost without discount:";
            // 
            // BuyButton
            // 
            this.BuyButton.Location = new System.Drawing.Point(675, 7);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(75, 23);
            this.BuyButton.TabIndex = 2;
            this.BuyButton.Text = "Buy";
            this.BuyButton.UseVisualStyleBackColor = true;
            this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // Basket
            // 
            this.Basket.AllowUserToAddRows = false;
            this.Basket.AllowUserToDeleteRows = false;
            this.Basket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Basket.BackgroundColor = System.Drawing.Color.White;
            this.Basket.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.Basket.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Basket.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.Basket.ColumnHeadersHeight = 17;
            this.Basket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Basket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7});
            this.Basket.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Basket.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Basket.EnableHeadersVisualStyles = false;
            this.Basket.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Basket.Location = new System.Drawing.Point(3, 48);
            this.Basket.Name = "Basket";
            this.Basket.ReadOnly = true;
            this.Basket.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Basket.RowHeadersVisible = false;
            this.Basket.Size = new System.Drawing.Size(801, 373);
            this.Basket.TabIndex = 0;
            this.Basket.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Basket_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "Product Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.HeaderText = "Price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 36;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.HeaderText = "Number of product";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewTextBoxColumn5.HeaderText = " Total Price";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 20;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Crimson;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewTextBoxColumn7.HeaderText = "";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 20;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ShopInfoTab
            // 
            this.ShopInfoTab.Controls.Add(this.DOBTextBox);
            this.ShopInfoTab.Controls.Add(this.TNameTextBox);
            this.ShopInfoTab.Controls.Add(this.SNameTextBox);
            this.ShopInfoTab.Controls.Add(this.FNameTextBox);
            this.ShopInfoTab.Controls.Add(this.DInfoTextBox);
            this.ShopInfoTab.Controls.Add(this.EndTimeTextBox);
            this.ShopInfoTab.Controls.Add(this.StartTimeTextBox);
            this.ShopInfoTab.Controls.Add(this.ShopNameTextBox);
            this.ShopInfoTab.Controls.Add(this.label14);
            this.ShopInfoTab.Controls.Add(this.label13);
            this.ShopInfoTab.Controls.Add(this.label12);
            this.ShopInfoTab.Controls.Add(this.label11);
            this.ShopInfoTab.Controls.Add(this.label10);
            this.ShopInfoTab.Controls.Add(this.label9);
            this.ShopInfoTab.Controls.Add(this.label8);
            this.ShopInfoTab.Controls.Add(this.label7);
            this.ShopInfoTab.Controls.Add(this.label6);
            this.ShopInfoTab.Controls.Add(this.label4);
            this.ShopInfoTab.Location = new System.Drawing.Point(4, 22);
            this.ShopInfoTab.Name = "ShopInfoTab";
            this.ShopInfoTab.Size = new System.Drawing.Size(807, 424);
            this.ShopInfoTab.TabIndex = 2;
            this.ShopInfoTab.Text = "Information";
            this.ShopInfoTab.UseVisualStyleBackColor = true;
            // 
            // DOBTextBox
            // 
            this.DOBTextBox.Location = new System.Drawing.Point(124, 336);
            this.DOBTextBox.Name = "DOBTextBox";
            this.DOBTextBox.ReadOnly = true;
            this.DOBTextBox.Size = new System.Drawing.Size(100, 22);
            this.DOBTextBox.TabIndex = 17;
            this.DOBTextBox.Text = "";
            // 
            // TNameTextBox
            // 
            this.TNameTextBox.Location = new System.Drawing.Point(124, 302);
            this.TNameTextBox.Name = "TNameTextBox";
            this.TNameTextBox.ReadOnly = true;
            this.TNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.TNameTextBox.TabIndex = 16;
            this.TNameTextBox.Text = "";
            // 
            // SNameTextBox
            // 
            this.SNameTextBox.Location = new System.Drawing.Point(124, 270);
            this.SNameTextBox.Name = "SNameTextBox";
            this.SNameTextBox.ReadOnly = true;
            this.SNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.SNameTextBox.TabIndex = 15;
            this.SNameTextBox.Text = "";
            // 
            // FNameTextBox
            // 
            this.FNameTextBox.Location = new System.Drawing.Point(124, 239);
            this.FNameTextBox.Name = "FNameTextBox";
            this.FNameTextBox.ReadOnly = true;
            this.FNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.FNameTextBox.TabIndex = 14;
            this.FNameTextBox.Text = "";
            // 
            // DInfoTextBox
            // 
            this.DInfoTextBox.Location = new System.Drawing.Point(149, 154);
            this.DInfoTextBox.Name = "DInfoTextBox";
            this.DInfoTextBox.ReadOnly = true;
            this.DInfoTextBox.Size = new System.Drawing.Size(368, 50);
            this.DInfoTextBox.TabIndex = 13;
            this.DInfoTextBox.Text = "";
            // 
            // EndTimeTextBox
            // 
            this.EndTimeTextBox.Location = new System.Drawing.Point(107, 122);
            this.EndTimeTextBox.Name = "EndTimeTextBox";
            this.EndTimeTextBox.ReadOnly = true;
            this.EndTimeTextBox.Size = new System.Drawing.Size(100, 22);
            this.EndTimeTextBox.TabIndex = 12;
            this.EndTimeTextBox.Text = "";
            // 
            // StartTimeTextBox
            // 
            this.StartTimeTextBox.Location = new System.Drawing.Point(107, 87);
            this.StartTimeTextBox.Name = "StartTimeTextBox";
            this.StartTimeTextBox.ReadOnly = true;
            this.StartTimeTextBox.Size = new System.Drawing.Size(100, 22);
            this.StartTimeTextBox.TabIndex = 11;
            this.StartTimeTextBox.Text = "";
            // 
            // ShopNameTextBox
            // 
            this.ShopNameTextBox.Location = new System.Drawing.Point(107, 53);
            this.ShopNameTextBox.Name = "ShopNameTextBox";
            this.ShopNameTextBox.ReadOnly = true;
            this.ShopNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.ShopNameTextBox.TabIndex = 10;
            this.ShopNameTextBox.Text = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(43, 339);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "DOB:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(43, 305);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "ThirdName:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(43, 273);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "SecondName:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 242);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "FirstName:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(159, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Customer information";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Detailed information:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "End time:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Start time:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Shop name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Store information";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 450);
            this.Controls.Add(this.windows);
            this.Name = "MainForm";
            this.Text = "Store";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.windows.ResumeLayout(false);
            this.ShopTab.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShopTable)).EndInit();
            this.BasketTab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Basket)).EndInit();
            this.ShopInfoTab.ResumeLayout(false);
            this.ShopInfoTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl windows;
        private System.Windows.Forms.TabPage ShopTab;
        private System.Windows.Forms.TabPage ShopInfoTab;
        private System.Windows.Forms.TabPage BasketTab;
        private System.Windows.Forms.DataGridView ShopTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Minus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Add;
        private System.Windows.Forms.DataGridView Basket;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BuyButton;
        private System.Windows.Forms.Label WithDiscount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label WithoutDiscount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TotalNumberLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox SearchByName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox DOBTextBox;
        private System.Windows.Forms.RichTextBox TNameTextBox;
        private System.Windows.Forms.RichTextBox SNameTextBox;
        private System.Windows.Forms.RichTextBox FNameTextBox;
        private System.Windows.Forms.RichTextBox DInfoTextBox;
        private System.Windows.Forms.RichTextBox EndTimeTextBox;
        private System.Windows.Forms.RichTextBox StartTimeTextBox;
        private System.Windows.Forms.RichTextBox ShopNameTextBox;
        private System.Windows.Forms.Label label14;
    }
}

