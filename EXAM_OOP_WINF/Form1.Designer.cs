namespace EXAM_OOP_WINF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabPageAuth = new TabPage();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            btnExit = new Button();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            size_array_team = new Button();
            btnExit1 = new Button();
            tabPage2 = new TabPage();
            textfdg = new TextBox();
            button_create = new Button();
            button_dell_team = new Button();
            btnExit2 = new Button();
            button_add_team = new Button();
            listBox_team = new ListBox();
            tabPage3 = new TabPage();
            label1 = new Label();
            btnExit3 = new Button();
            form1BindingSource = new BindingSource(components);
            tabPageAuth.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)form1BindingSource).BeginInit();
            SuspendLayout();
            // 
            // tabPageAuth
            // 
            tabPageAuth.BackgroundImage = (Image)resources.GetObject("tabPageAuth.BackgroundImage");
            tabPageAuth.Controls.Add(textBox3);
            tabPageAuth.Controls.Add(textBox2);
            tabPageAuth.Controls.Add(textBox1);
            tabPageAuth.Controls.Add(btnExit);
            tabPageAuth.Controls.Add(btnLogin);
            tabPageAuth.Controls.Add(txtPassword);
            tabPageAuth.Controls.Add(txtUsername);
            tabPageAuth.Location = new Point(4, 24);
            tabPageAuth.Name = "tabPageAuth";
            tabPageAuth.Padding = new Padding(3);
            tabPageAuth.Size = new Size(801, 426);
            tabPageAuth.TabIndex = 0;
            tabPageAuth.Text = "Login";
            tabPageAuth.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Khaki;
            textBox3.Location = new Point(9, 15);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(125, 80);
            textBox3.TabIndex = 6;
            textBox3.Text = "!!! Внимание !!!\r\nТак как это тестовое приложение\r\nЛогин: admin\r\nПароль: admin";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(260, 101);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(189, 23);
            textBox2.TabIndex = 5;
            textBox2.Text = "Введите пароль";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(260, 43);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(189, 23);
            textBox1.TabIndex = 4;
            textBox1.Text = "Введите логин";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.ForeColor = SystemColors.InfoText;
            btnExit.Location = new Point(693, 371);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(83, 37);
            btnExit.TabIndex = 3;
            btnExit.Text = "Выход";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.SpringGreen;
            btnLogin.BackgroundImageLayout = ImageLayout.Center;
            btnLogin.Location = new Point(308, 174);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(93, 45);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(260, 132);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(189, 23);
            txtPassword.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(260, 72);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(189, 23);
            txtUsername.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageAuth);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(-1, 6);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(809, 454);
            tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.BackgroundImage = (Image)resources.GetObject("tabPage1.BackgroundImage");
            tabPage1.Controls.Add(size_array_team);
            tabPage1.Controls.Add(btnExit1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(801, 426);
            tabPage1.TabIndex = 1;
            tabPage1.Text = "Введение количетсва команд";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // size_array_team
            // 
            size_array_team.BackColor = Color.Orange;
            size_array_team.Location = new Point(291, 166);
            size_array_team.Name = "size_array_team";
            size_array_team.Size = new Size(185, 64);
            size_array_team.TabIndex = 5;
            size_array_team.Text = "Нажмите чтобы ввести\r\nколичество команд и продолжить";
            size_array_team.UseVisualStyleBackColor = false;
            size_array_team.Click += size_array_team_Click;
            // 
            // btnExit1
            // 
            btnExit1.BackColor = Color.Red;
            btnExit1.Location = new Point(689, 360);
            btnExit1.Name = "btnExit1";
            btnExit1.Size = new Size(96, 35);
            btnExit1.TabIndex = 4;
            btnExit1.Text = "Выход";
            btnExit1.UseVisualStyleBackColor = false;
            btnExit1.Click += btnExit1_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackgroundImage = (Image)resources.GetObject("tabPage2.BackgroundImage");
            tabPage2.Controls.Add(textfdg);
            tabPage2.Controls.Add(button_create);
            tabPage2.Controls.Add(button_dell_team);
            tabPage2.Controls.Add(btnExit2);
            tabPage2.Controls.Add(button_add_team);
            tabPage2.Controls.Add(listBox_team);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(801, 426);
            tabPage2.TabIndex = 2;
            tabPage2.Text = "Заполнение названий команд";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // textfdg
            // 
            textfdg.Location = new Point(317, 29);
            textfdg.Name = "textfdg";
            textfdg.ReadOnly = true;
            textfdg.Size = new Size(145, 23);
            textfdg.TabIndex = 8;
            textfdg.Text = "Список команд";
            textfdg.TextAlign = HorizontalAlignment.Center;
            // 
            // button_create
            // 
            button_create.BackColor = Color.Orange;
            button_create.Location = new Point(299, 337);
            button_create.Name = "button_create";
            button_create.Size = new Size(163, 23);
            button_create.TabIndex = 7;
            button_create.Text = "Создать список туров";
            button_create.UseVisualStyleBackColor = false;
            button_create.Click += button_create_Click;
            // 
            // button_dell_team
            // 
            button_dell_team.BackColor = Color.Red;
            button_dell_team.Location = new Point(380, 308);
            button_dell_team.Name = "button_dell_team";
            button_dell_team.Size = new Size(138, 23);
            button_dell_team.TabIndex = 6;
            button_dell_team.Text = "Удалить команду";
            button_dell_team.UseVisualStyleBackColor = false;
            button_dell_team.Click += button_dell_team_Click;
            // 
            // btnExit2
            // 
            btnExit2.BackColor = Color.Red;
            btnExit2.Location = new Point(710, 375);
            btnExit2.Name = "btnExit2";
            btnExit2.Size = new Size(75, 33);
            btnExit2.TabIndex = 5;
            btnExit2.Text = "Выход";
            btnExit2.UseVisualStyleBackColor = false;
            btnExit2.Click += btnExit2_Click;
            // 
            // button_add_team
            // 
            button_add_team.BackColor = Color.Lime;
            button_add_team.Location = new Point(236, 308);
            button_add_team.Name = "button_add_team";
            button_add_team.Size = new Size(138, 23);
            button_add_team.TabIndex = 3;
            button_add_team.Text = "Добавить команду";
            button_add_team.UseVisualStyleBackColor = false;
            button_add_team.Click += button_add_team_Click;
            // 
            // listBox_team
            // 
            listBox_team.BackColor = SystemColors.MenuBar;
            listBox_team.FormattingEnabled = true;
            listBox_team.ItemHeight = 15;
            listBox_team.Location = new Point(317, 58);
            listBox_team.Name = "listBox_team";
            listBox_team.Size = new Size(145, 244);
            listBox_team.TabIndex = 2;
            // 
            // tabPage3
            // 
            tabPage3.BackgroundImage = (Image)resources.GetObject("tabPage3.BackgroundImage");
            tabPage3.Controls.Add(label1);
            tabPage3.Controls.Add(btnExit3);
            tabPage3.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(801, 426);
            tabPage3.TabIndex = 3;
            tabPage3.Text = "Схема туров";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(33, 31);
            label1.Name = "label1";
            label1.Size = new Size(59, 22);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // btnExit3
            // 
            btnExit3.BackColor = Color.Red;
            btnExit3.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit3.Location = new Point(696, 374);
            btnExit3.Name = "btnExit3";
            btnExit3.Size = new Size(89, 34);
            btnExit3.TabIndex = 0;
            btnExit3.Text = "Выход";
            btnExit3.UseVisualStyleBackColor = false;
            btnExit3.Click += btnExit3_Click;
            // 
            // form1BindingSource
            // 
            form1BindingSource.DataSource = typeof(Form1);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabPageAuth.ResumeLayout(false);
            tabPageAuth.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)form1BindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPageAuth;
        private Button btnExit;
        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnExit1;
        private Button size_array_team;
        private TabPage tabPage2;
        private Button button_add_team;
        private ListBox listBox_team;
        private Button btnExit2;
        private Button button_dell_team;
        private TabPage tabPage3;
        private Button btnExit3;
        private Button button_create;
        private BindingSource form1BindingSource;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textfdg;
        private Button button1;
    }
}