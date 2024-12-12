namespace Library.BookManagement
{
    partial class AddBook
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBook));
            this.BookBoard = new System.Windows.Forms.Panel();
            this.catagory = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.Publication = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pages = new System.Windows.Forms.TextBox();
            this.volume = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.TextBox();
            this.ISBN = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BookDate = new System.Windows.Forms.DateTimePicker();
            this.BName = new System.Windows.Forms.TextBox();
            this.Return = new System.Windows.Forms.Button();
            this.OPTION = new System.Windows.Forms.Panel();
            this.English = new System.Windows.Forms.RadioButton();
            this.other = new System.Windows.Forms.RadioButton();
            this.Hindi = new System.Windows.Forms.RadioButton();
            this.OtherLanguage = new System.Windows.Forms.TextBox();
            this.errorInID = new System.Windows.Forms.ErrorProvider(this.components);
            this.block = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPages = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderQuantity = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderAvailableBook = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPublicatioin = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderVolume = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorInName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderAuthor = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPrice = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider10 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SelectedItem = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.errorInISBN = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.MagazineBoard = new Library.Management.AddNewResources.AddNewMagazine.AddMagazine();
            this.NewspaperBoard = new Library.Management.AddNewResources.AddNewsPaper.AddNewspaper();
            this.BookBoard.SuspendLayout();
            this.OPTION.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorInID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAvailableBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPublicatioin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorInName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider10)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorInISBN)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BookBoard
            // 
            this.BookBoard.BackColor = System.Drawing.Color.Silver;
            this.BookBoard.Controls.Add(this.catagory);
            this.BookBoard.Controls.Add(this.AddButton);
            this.BookBoard.Controls.Add(this.Publication);
            this.BookBoard.Controls.Add(this.label14);
            this.BookBoard.Controls.Add(this.label3);
            this.BookBoard.Controls.Add(this.Quantity);
            this.BookBoard.Controls.Add(this.label4);
            this.BookBoard.Controls.Add(this.pages);
            this.BookBoard.Controls.Add(this.volume);
            this.BookBoard.Controls.Add(this.label7);
            this.BookBoard.Controls.Add(this.label10);
            this.BookBoard.Controls.Add(this.Author);
            this.BookBoard.Controls.Add(this.ISBN);
            this.BookBoard.Controls.Add(this.ID);
            this.BookBoard.Controls.Add(this.label2);
            this.BookBoard.Controls.Add(this.label9);
            this.BookBoard.Controls.Add(this.price);
            this.BookBoard.Controls.Add(this.label6);
            this.BookBoard.Controls.Add(this.label12);
            this.BookBoard.Controls.Add(this.label1);
            this.BookBoard.Controls.Add(this.label8);
            this.BookBoard.Controls.Add(this.label5);
            this.BookBoard.Controls.Add(this.BookDate);
            this.BookBoard.Controls.Add(this.BName);
            this.BookBoard.Controls.Add(this.Return);
            this.BookBoard.Controls.Add(this.OPTION);
            this.BookBoard.Controls.Add(this.OtherLanguage);
            this.BookBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BookBoard.Location = new System.Drawing.Point(0, 0);
            this.BookBoard.Name = "BookBoard";
            this.BookBoard.Size = new System.Drawing.Size(781, 493);
            this.BookBoard.TabIndex = 0;
            this.BookBoard.Visible = false;
            // 
            // catagory
            // 
            this.catagory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.catagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catagory.FormattingEnabled = true;
            this.catagory.Items.AddRange(new object[] {
            "Subjective/Acadmic Book",
            "Non-Fiction",
            "Fiction",
            "Comics",
            "Children’s Books",
            "Comics and Graphic Novels",
            "Technology and Computers",
            "Hobbies and Interests",
            "Health and Wellness",
            "Business and Economics",
            "Religious/Spiritual",
            "Other",
            "",
            "",
            ""});
            this.catagory.Location = new System.Drawing.Point(455, 250);
            this.catagory.Name = "catagory";
            this.catagory.Size = new System.Drawing.Size(300, 28);
            this.catagory.TabIndex = 7;
            this.catagory.SelectedIndexChanged += new System.EventHandler(this.catagory_SelectedIndexChanged);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Teal;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(334, 440);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(114, 43);
            this.AddButton.TabIndex = 11;
            this.AddButton.Text = "ADD";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Publication
            // 
            this.Publication.BackColor = System.Drawing.Color.White;
            this.Publication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publication.Location = new System.Drawing.Point(456, 151);
            this.Publication.Name = "Publication";
            this.Publication.Size = new System.Drawing.Size(299, 26);
            this.Publication.TabIndex = 4;
            this.Publication.TextChanged += new System.EventHandler(this.Publication_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.label14.Location = new System.Drawing.Point(175, 278);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 29);
            this.label14.TabIndex = 76;
            this.label14.Text = "Language";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.label3.Location = new System.Drawing.Point(175, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 29);
            this.label3.TabIndex = 51;
            this.label3.Text = "Publication";
            // 
            // Quantity
            // 
            this.Quantity.BackColor = System.Drawing.Color.White;
            this.Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.Location = new System.Drawing.Point(457, 386);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(299, 26);
            this.Quantity.TabIndex = 10;
            this.Quantity.TextChanged += new System.EventHandler(this.Quantity_TextChanged);
            this.Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Quantity_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.label4.Location = new System.Drawing.Point(175, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 29);
            this.label4.TabIndex = 52;
            this.label4.Text = "Buy Date";
            // 
            // pages
            // 
            this.pages.BackColor = System.Drawing.Color.White;
            this.pages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pages.Location = new System.Drawing.Point(456, 215);
            this.pages.Name = "pages";
            this.pages.Size = new System.Drawing.Size(299, 26);
            this.pages.TabIndex = 6;
            this.pages.TextChanged += new System.EventHandler(this.pages_TextChanged);
            this.pages.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pages_KeyPress);
            // 
            // volume
            // 
            this.volume.BackColor = System.Drawing.Color.White;
            this.volume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volume.Location = new System.Drawing.Point(456, 183);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(299, 26);
            this.volume.TabIndex = 5;
            this.volume.TextChanged += new System.EventHandler(this.volume_TextChanged);
            this.volume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.volume_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.label7.Location = new System.Drawing.Point(176, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 29);
            this.label7.TabIndex = 72;
            this.label7.Text = "Book Catagory";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.label10.Location = new System.Drawing.Point(175, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 29);
            this.label10.TabIndex = 72;
            this.label10.Text = "Pages";
            // 
            // Author
            // 
            this.Author.BackColor = System.Drawing.Color.White;
            this.Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Author.Location = new System.Drawing.Point(456, 119);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(299, 26);
            this.Author.TabIndex = 3;
            this.Author.TextChanged += new System.EventHandler(this.Author_TextChanged);
            // 
            // ISBN
            // 
            this.ISBN.BackColor = System.Drawing.Color.White;
            this.ISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBN.Location = new System.Drawing.Point(456, 17);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(299, 26);
            this.ISBN.TabIndex = 0;
            this.ISBN.TextChanged += new System.EventHandler(this.ISBN_TextChanged);
            this.ISBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ISBN_KeyPress);
            this.ISBN.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ID_KeyUp);
            // 
            // ID
            // 
            this.ID.BackColor = System.Drawing.Color.White;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(456, 53);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(299, 26);
            this.ID.TabIndex = 1;
            this.ID.TextChanged += new System.EventHandler(this.ID_TextChanged);
            this.ID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ID_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.label2.Location = new System.Drawing.Point(174, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Author Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.label9.Location = new System.Drawing.Point(175, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 29);
            this.label9.TabIndex = 71;
            this.label9.Text = "Volume";
            // 
            // price
            // 
            this.price.BackColor = System.Drawing.Color.White;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(457, 349);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(299, 26);
            this.price.TabIndex = 9;
            this.price.TextChanged += new System.EventHandler(this.price_TextChanged);
            this.price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.label6.Location = new System.Drawing.Point(176, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 29);
            this.label6.TabIndex = 54;
            this.label6.Text = "Quantity";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.label12.Location = new System.Drawing.Point(176, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 29);
            this.label12.TabIndex = 7;
            this.label12.Text = "ISBN Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(175, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Book Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.label8.Location = new System.Drawing.Point(175, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(255, 29);
            this.label8.TabIndex = 7;
            this.label8.Text = "Accession Number(ID)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.label5.Location = new System.Drawing.Point(176, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 29);
            this.label5.TabIndex = 53;
            this.label5.Text = "Price";
            // 
            // BookDate
            // 
            this.BookDate.CalendarFont = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.BookDate.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlText;
            this.BookDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookDate.Location = new System.Drawing.Point(457, 319);
            this.BookDate.MaxDate = new System.DateTime(2024, 10, 16, 0, 0, 0, 0);
            this.BookDate.Name = "BookDate";
            this.BookDate.Size = new System.Drawing.Size(299, 26);
            this.BookDate.TabIndex = 8;
            this.BookDate.Value = new System.DateTime(2024, 10, 16, 0, 0, 0, 0);
            // 
            // BName
            // 
            this.BName.BackColor = System.Drawing.Color.White;
            this.BName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BName.Location = new System.Drawing.Point(456, 87);
            this.BName.Name = "BName";
            this.BName.Size = new System.Drawing.Size(299, 26);
            this.BName.TabIndex = 2;
            this.BName.TextChanged += new System.EventHandler(this.BName_TextChanged);
            // 
            // Return
            // 
            this.Return.BackColor = System.Drawing.Color.White;
            this.Return.FlatAppearance.BorderSize = 0;
            this.Return.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Return.Image = global::Library.Properties.Resources.Undo;
            this.Return.Location = new System.Drawing.Point(755, 287);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(23, 26);
            this.Return.TabIndex = 82;
            this.Return.UseVisualStyleBackColor = false;
            this.Return.Visible = false;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // OPTION
            // 
            this.OPTION.BackColor = System.Drawing.Color.White;
            this.OPTION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OPTION.Controls.Add(this.English);
            this.OPTION.Controls.Add(this.other);
            this.OPTION.Controls.Add(this.Hindi);
            this.OPTION.Location = new System.Drawing.Point(457, 287);
            this.OPTION.Name = "OPTION";
            this.OPTION.Size = new System.Drawing.Size(299, 26);
            this.OPTION.TabIndex = 7;
            // 
            // English
            // 
            this.English.AutoSize = true;
            this.English.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.English.Location = new System.Drawing.Point(7, 3);
            this.English.Name = "English";
            this.English.Size = new System.Drawing.Size(72, 21);
            this.English.TabIndex = 0;
            this.English.TabStop = true;
            this.English.Text = "English";
            this.English.UseVisualStyleBackColor = true;
            // 
            // other
            // 
            this.other.AutoSize = true;
            this.other.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.other.Location = new System.Drawing.Point(217, 0);
            this.other.Name = "other";
            this.other.Size = new System.Drawing.Size(62, 21);
            this.other.TabIndex = 2;
            this.other.TabStop = true;
            this.other.Text = "Other";
            this.other.UseVisualStyleBackColor = true;
            this.other.CheckedChanged += new System.EventHandler(this.other_CheckedChanged_1);
            // 
            // Hindi
            // 
            this.Hindi.AutoSize = true;
            this.Hindi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hindi.Location = new System.Drawing.Point(119, 3);
            this.Hindi.Name = "Hindi";
            this.Hindi.Size = new System.Drawing.Size(58, 21);
            this.Hindi.TabIndex = 1;
            this.Hindi.TabStop = true;
            this.Hindi.Text = "Hindi";
            this.Hindi.UseVisualStyleBackColor = true;
            // 
            // OtherLanguage
            // 
            this.OtherLanguage.BackColor = System.Drawing.Color.White;
            this.OtherLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OtherLanguage.ForeColor = System.Drawing.Color.Silver;
            this.OtherLanguage.Location = new System.Drawing.Point(457, 287);
            this.OtherLanguage.Name = "OtherLanguage";
            this.OtherLanguage.Size = new System.Drawing.Size(299, 26);
            this.OtherLanguage.TabIndex = 55;
            this.OtherLanguage.Text = "Enter Other Language";
            this.OtherLanguage.Visible = false;
            this.OtherLanguage.Click += new System.EventHandler(this.OtherLanguage_Click);
            this.OtherLanguage.TextChanged += new System.EventHandler(this.pages_TextChanged);
            // 
            // errorInID
            // 
            this.errorInID.BlinkRate = 2;
            this.errorInID.ContainerControl = this;
            this.errorInID.Icon = ((System.Drawing.Icon)(resources.GetObject("errorInID.Icon")));
            // 
            // block
            // 
            this.block.ContainerControl = this;
            // 
            // errorProviderPages
            // 
            this.errorProviderPages.ContainerControl = this;
            // 
            // errorProviderQuantity
            // 
            this.errorProviderQuantity.ContainerControl = this;
            // 
            // errorProviderAvailableBook
            // 
            this.errorProviderAvailableBook.ContainerControl = this;
            // 
            // errorProviderPublicatioin
            // 
            this.errorProviderPublicatioin.ContainerControl = this;
            // 
            // errorProviderVolume
            // 
            this.errorProviderVolume.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // errorInName
            // 
            this.errorInName.ContainerControl = this;
            // 
            // errorProviderAuthor
            // 
            this.errorProviderAuthor.ContainerControl = this;
            // 
            // errorProviderPrice
            // 
            this.errorProviderPrice.ContainerControl = this;
            // 
            // errorProvider10
            // 
            this.errorProvider10.ContainerControl = this;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gainsboro;
            this.panel6.BackgroundImage = global::Library.Properties.Resources.thisIsFinal;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 554);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1039, 120);
            this.panel6.TabIndex = 84;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SelectedItem);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1035, 42);
            this.panel2.TabIndex = 85;
            // 
            // SelectedItem
            // 
            this.SelectedItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectedItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedItem.ForeColor = System.Drawing.Color.Black;
            this.SelectedItem.FormattingEnabled = true;
            this.SelectedItem.Items.AddRange(new object[] {
            "Book",
            "Magazine",
            "NewsPaper",
            "PDF"});
            this.SelectedItem.Location = new System.Drawing.Point(336, 11);
            this.SelectedItem.MaxDropDownItems = 6;
            this.SelectedItem.Name = "SelectedItem";
            this.SelectedItem.Size = new System.Drawing.Size(134, 24);
            this.SelectedItem.TabIndex = 1;
            this.SelectedItem.SelectedIndexChanged += new System.EventHandler(this.SelectedItem_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkRed;
            this.label11.Location = new System.Drawing.Point(3, 2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(328, 39);
            this.label11.TabIndex = 0;
            this.label11.Text = "Add New Resources";
            // 
            // errorInISBN
            // 
            this.errorInISBN.ContainerControl = this;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.NewspaperBoard);
            this.panel3.Controls.Add(this.BookBoard);
            this.panel3.Controls.Add(this.MagazineBoard);
            this.panel3.Location = new System.Drawing.Point(159, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(781, 493);
            this.panel3.TabIndex = 86;
            // 
            // MagazineBoard
            // 
            this.MagazineBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MagazineBoard.Location = new System.Drawing.Point(0, 0);
            this.MagazineBoard.Name = "MagazineBoard";
            this.MagazineBoard.Size = new System.Drawing.Size(781, 493);
            this.MagazineBoard.TabIndex = 1;
            this.MagazineBoard.Visible = false;
            // 
            // NewspaperBoard
            // 
            this.NewspaperBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewspaperBoard.Location = new System.Drawing.Point(0, 0);
            this.NewspaperBoard.Name = "NewspaperBoard";
            this.NewspaperBoard.Size = new System.Drawing.Size(781, 493);
            this.NewspaperBoard.TabIndex = 0;
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel6);
            this.Name = "AddBook";
            this.Size = new System.Drawing.Size(1039, 674);
            this.Load += new System.EventHandler(this.AddBook_Load);
            this.BookBoard.ResumeLayout(false);
            this.BookBoard.PerformLayout();
            this.OPTION.ResumeLayout(false);
            this.OPTION.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorInID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAvailableBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPublicatioin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorInName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider10)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorInISBN)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BookBoard;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox Publication;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pages;
        private System.Windows.Forms.TextBox volume;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Author;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker BookDate;
        private System.Windows.Forms.TextBox BName;
        private System.Windows.Forms.ErrorProvider errorInID;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Panel OPTION;
        private System.Windows.Forms.RadioButton English;
        private System.Windows.Forms.RadioButton other;
        private System.Windows.Forms.RadioButton Hindi;
        private System.Windows.Forms.TextBox OtherLanguage;
        private System.Windows.Forms.ErrorProvider block;
        private System.Windows.Forms.ErrorProvider errorProviderPages;
        private System.Windows.Forms.ErrorProvider errorProviderQuantity;
        private System.Windows.Forms.ErrorProvider errorProviderAvailableBook;
        private System.Windows.Forms.ErrorProvider errorProviderPublicatioin;
        private System.Windows.Forms.ErrorProvider errorProviderVolume;
        private System.Windows.Forms.ErrorProvider errorProvider6;
        private System.Windows.Forms.ErrorProvider errorInName;
        private System.Windows.Forms.ErrorProvider errorProviderAuthor;
        private System.Windows.Forms.ErrorProvider errorProviderPrice;
        private System.Windows.Forms.ErrorProvider errorProvider10;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox catagory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox SelectedItem;
        private System.Windows.Forms.TextBox ISBN;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ErrorProvider errorInISBN;
        private System.Windows.Forms.Panel panel3;
        private Management.AddNewResources.AddNewsPaper.AddNewspaper NewspaperBoard;
        private Management.AddNewResources.AddNewMagazine.AddMagazine MagazineBoard;
    }
}
