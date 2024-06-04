using System.Drawing;

namespace ЗнижкоСвіт
{
    partial class AppSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppSettings));
            this.panelCenter = new System.Windows.Forms.Panel();
            this.textBoxUsername = new Krypton.Toolkit.KryptonTextBox();
            this.labelNickname = new Krypton.Toolkit.KryptonLabel();
            this.labelAccSett = new Krypton.Toolkit.KryptonLabel();
            this.kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            this.labelTheme = new Krypton.Toolkit.KryptonLabel();
            this.comboBoxTheme = new Krypton.Toolkit.KryptonComboBox();
            this.labelSettingsInterface = new Krypton.Toolkit.KryptonLabel();
            this.labelLanguage = new Krypton.Toolkit.KryptonLabel();
            this.comboBoxLanguage = new Krypton.Toolkit.KryptonComboBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonSignIn = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pictureBoxSettings = new System.Windows.Forms.PictureBox();
            this.pictureBoxHome = new System.Windows.Forms.PictureBox();
            this.pictureBoxFav = new System.Windows.Forms.PictureBox();
            this.buttonSettings = new Krypton.Toolkit.KryptonButton();
            this.buttonHome = new Krypton.Toolkit.KryptonButton();
            this.buttonFav = new Krypton.Toolkit.KryptonButton();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxLanguage)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSignIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonExit)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFav)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCenter
            // 
            this.panelCenter.BackColor = System.Drawing.Color.LavenderBlush;
            this.panelCenter.Controls.Add(this.textBoxUsername);
            this.panelCenter.Controls.Add(this.labelNickname);
            this.panelCenter.Controls.Add(this.labelAccSett);
            this.panelCenter.Controls.Add(this.kryptonPictureBox1);
            this.panelCenter.Controls.Add(this.labelTheme);
            this.panelCenter.Controls.Add(this.comboBoxTheme);
            this.panelCenter.Controls.Add(this.labelSettingsInterface);
            this.panelCenter.Controls.Add(this.labelLanguage);
            this.panelCenter.Controls.Add(this.comboBoxLanguage);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(294, 120);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(1626, 960);
            this.panelCenter.TabIndex = 6;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxUsername.Location = new System.Drawing.Point(312, 235);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.ReadOnly = true;
            this.textBoxUsername.Size = new System.Drawing.Size(434, 50);
            this.textBoxUsername.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxUsername.StateCommon.Border.Rounding = 10F;
            this.textBoxUsername.StateCommon.Content.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUsername.TabIndex = 8;
            this.textBoxUsername.Text = "Guest";
            this.textBoxUsername.Click += new System.EventHandler(this.textBoxUsername_Click);
            // 
            // labelNickname
            // 
            this.labelNickname.Location = new System.Drawing.Point(106, 240);
            this.labelNickname.Name = "labelNickname";
            this.labelNickname.Size = new System.Drawing.Size(172, 47);
            this.labelNickname.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.labelNickname.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.labelNickname.StateCommon.ShortText.Font = new System.Drawing.Font("Montserrat Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNickname.TabIndex = 7;
            this.labelNickname.Values.Text = "Нікнейм";
            // 
            // labelAccSett
            // 
            this.labelAccSett.Location = new System.Drawing.Point(106, 90);
            this.labelAccSett.Name = "labelAccSett";
            this.labelAccSett.Size = new System.Drawing.Size(585, 61);
            this.labelAccSett.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(150)))), ((int)(((byte)(146)))));
            this.labelAccSett.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(150)))), ((int)(((byte)(146)))));
            this.labelAccSett.StateCommon.ShortText.Font = new System.Drawing.Font("Montserrat", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAccSett.TabIndex = 6;
            this.labelAccSett.Values.Text = "Налаштування акаунту";
            // 
            // kryptonPictureBox1
            // 
            this.kryptonPictureBox1.Image = Image.FromFile("Images/sh.png");
            this.kryptonPictureBox1.Location = new System.Drawing.Point(769, -322);
            this.kryptonPictureBox1.Name = "kryptonPictureBox1";
            this.kryptonPictureBox1.Size = new System.Drawing.Size(1270, 1270);
            this.kryptonPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kryptonPictureBox1.TabIndex = 5;
            this.kryptonPictureBox1.TabStop = false;
            // 
            // labelTheme
            // 
            this.labelTheme.Location = new System.Drawing.Point(106, 703);
            this.labelTheme.Name = "labelTheme";
            this.labelTheme.Size = new System.Drawing.Size(108, 47);
            this.labelTheme.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.labelTheme.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.labelTheme.StateCommon.ShortText.Font = new System.Drawing.Font("Montserrat Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTheme.TabIndex = 4;
            this.labelTheme.Values.Text = "Тема";
            // 
            // comboBoxTheme
            // 
            this.comboBoxTheme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTheme.DropDownWidth = 235;
            this.comboBoxTheme.IntegralHeight = false;
            this.comboBoxTheme.Items.AddRange(new object[] {
            "Світла",
            "Темна"});
            this.comboBoxTheme.Location = new System.Drawing.Point(260, 700);
            this.comboBoxTheme.Name = "comboBoxTheme";
            this.comboBoxTheme.Size = new System.Drawing.Size(239, 42);
            this.comboBoxTheme.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.comboBoxTheme.StateCommon.ComboBox.Border.Rounding = 5F;
            this.comboBoxTheme.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxTheme.TabIndex = 3;
            this.comboBoxTheme.Text = "Світла";
            // 
            // labelSettingsInterface
            // 
            this.labelSettingsInterface.Location = new System.Drawing.Point(106, 448);
            this.labelSettingsInterface.Name = "labelSettingsInterface";
            this.labelSettingsInterface.Size = new System.Drawing.Size(673, 61);
            this.labelSettingsInterface.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(150)))), ((int)(((byte)(146)))));
            this.labelSettingsInterface.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(150)))), ((int)(((byte)(146)))));
            this.labelSettingsInterface.StateCommon.ShortText.Font = new System.Drawing.Font("Montserrat", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSettingsInterface.TabIndex = 2;
            this.labelSettingsInterface.Values.Text = "Налаштування інтерфейсу";
            // 
            // labelLanguage
            // 
            this.labelLanguage.Location = new System.Drawing.Point(106, 607);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(114, 47);
            this.labelLanguage.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.labelLanguage.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.labelLanguage.StateCommon.ShortText.Font = new System.Drawing.Font("Montserrat Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLanguage.TabIndex = 1;
            this.labelLanguage.Values.Text = "Мова";
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLanguage.DropDownWidth = 235;
            this.comboBoxLanguage.IntegralHeight = false;
            this.comboBoxLanguage.Items.AddRange(new object[] {
            "Українська",
            "English"});
            this.comboBoxLanguage.Location = new System.Drawing.Point(260, 602);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(239, 42);
            this.comboBoxLanguage.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.comboBoxLanguage.StateCommon.ComboBox.Border.Rounding = 5F;
            this.comboBoxLanguage.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxLanguage.TabIndex = 0;
            this.comboBoxLanguage.Text = "Українська";
            this.comboBoxLanguage.SelectedIndexChanged += new System.EventHandler(this.comboBoxLanguage_SelectedIndexChanged);
            this.comboBoxTheme.SelectedIndexChanged += new System.EventHandler(this.comboBoxTheme_SelectedIndexChanged);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(150)))), ((int)(((byte)(146)))));
            this.panelTop.Controls.Add(this.buttonSignIn);
            this.panelTop.Controls.Add(this.buttonExit);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(294, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1626, 120);
            this.panelTop.TabIndex = 5;
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSignIn.Image = Image.FromFile("Images/userr.png");
            this.buttonSignIn.Location = new System.Drawing.Point(1404, 25);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(70, 70);
            this.buttonSignIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonSignIn.TabIndex = 0;
            this.buttonSignIn.TabStop = false;
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.Image = Image.FromFile("Images/ext.png");
            this.buttonExit.Location = new System.Drawing.Point(1527, 25);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(70, 70);
            this.buttonExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonExit.TabIndex = 1;
            this.buttonExit.TabStop = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(211)))), ((int)(((byte)(228)))));
            this.panelMenu.Controls.Add(this.pictureBoxSettings);
            this.panelMenu.Controls.Add(this.pictureBoxHome);
            this.panelMenu.Controls.Add(this.pictureBoxFav);
            this.panelMenu.Controls.Add(this.buttonSettings);
            this.panelMenu.Controls.Add(this.buttonHome);
            this.panelMenu.Controls.Add(this.buttonFav);
            this.panelMenu.Controls.Add(this.pictureBoxLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(294, 1080);
            this.panelMenu.TabIndex = 4;
            // 
            // pictureBoxSettings
            // 
            this.pictureBoxSettings.BackColor = System.Drawing.Color.LightPink;
            this.pictureBoxSettings.Image = Image.FromFile("Images/set.png");
            this.pictureBoxSettings.Location = new System.Drawing.Point(116, 792);
            this.pictureBoxSettings.Name = "pictureBoxSettings";
            this.pictureBoxSettings.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSettings.TabIndex = 7;
            this.pictureBoxSettings.TabStop = false;
            // 
            // pictureBoxHome
            // 
            this.pictureBoxHome.BackColor = System.Drawing.Color.LightPink;
            this.pictureBoxHome.Image = Image.FromFile("Images/free-icon-home.png");
            this.pictureBoxHome.Location = new System.Drawing.Point(116, 378);
            this.pictureBoxHome.Name = "pictureBoxHome";
            this.pictureBoxHome.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHome.TabIndex = 5;
            this.pictureBoxHome.TabStop = false;
            // 
            // pictureBoxFav
            // 
            this.pictureBoxFav.BackColor = System.Drawing.Color.LightPink;
            this.pictureBoxFav.Image = Image.FromFile("Images/fav.png");
            this.pictureBoxFav.Location = new System.Drawing.Point(116, 585);
            this.pictureBoxFav.Name = "pictureBoxFav";
            this.pictureBoxFav.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxFav.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFav.TabIndex = 6;
            this.pictureBoxFav.TabStop = false;
            // 
            // buttonSettings
            // 
            this.buttonSettings.CornerRoundingRadius = 25F;
            this.buttonSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSettings.Location = new System.Drawing.Point(24, 772);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.OverrideDefault.Back.Color1 = System.Drawing.Color.LightPink;
            this.buttonSettings.OverrideDefault.Back.Color2 = System.Drawing.Color.HotPink;
            this.buttonSettings.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.buttonSettings.Size = new System.Drawing.Size(243, 134);
            this.buttonSettings.StateCommon.Back.Color1 = System.Drawing.Color.LightPink;
            this.buttonSettings.StateCommon.Back.Color2 = System.Drawing.Color.MistyRose;
            this.buttonSettings.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            this.buttonSettings.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonSettings.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(150)))), ((int)(((byte)(146)))));
            this.buttonSettings.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(150)))), ((int)(((byte)(146)))));
            this.buttonSettings.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonSettings.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonSettings.StateCommon.Border.Rounding = 25F;
            this.buttonSettings.StateCommon.Border.Width = 5;
            this.buttonSettings.StateCommon.Content.Padding = new System.Windows.Forms.Padding(8, 55, -1, -1);
            this.buttonSettings.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSettings.StateNormal.Back.Color1 = System.Drawing.Color.LightPink;
            this.buttonSettings.StateNormal.Back.Color2 = System.Drawing.Color.HotPink;
            this.buttonSettings.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonSettings.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonSettings.StatePressed.Back.Color1 = System.Drawing.Color.LightPink;
            this.buttonSettings.StatePressed.Back.Color2 = System.Drawing.Color.Crimson;
            this.buttonSettings.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonSettings.StateTracking.Back.Color1 = System.Drawing.Color.LightPink;
            this.buttonSettings.StateTracking.Back.Color2 = System.Drawing.Color.HotPink;
            this.buttonSettings.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonSettings.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonSettings.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonSettings.TabIndex = 4;
            this.buttonSettings.Values.Text = "Налаштування";
            // 
            // buttonHome
            // 
            this.buttonHome.CornerRoundingRadius = 25F;
            this.buttonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHome.Location = new System.Drawing.Point(24, 360);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.OverrideDefault.Back.Color1 = System.Drawing.Color.LightPink;
            this.buttonHome.OverrideDefault.Back.Color2 = System.Drawing.Color.MistyRose;
            this.buttonHome.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.buttonHome.Size = new System.Drawing.Size(243, 134);
            this.buttonHome.StateCommon.Back.Color1 = System.Drawing.Color.LightPink;
            this.buttonHome.StateCommon.Back.Color2 = System.Drawing.Color.MistyRose;
            this.buttonHome.StateCommon.Back.ColorAngle = 90F;
            this.buttonHome.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            this.buttonHome.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonHome.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(150)))), ((int)(((byte)(146)))));
            this.buttonHome.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(150)))), ((int)(((byte)(146)))));
            this.buttonHome.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonHome.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonHome.StateCommon.Border.Rounding = 25F;
            this.buttonHome.StateCommon.Border.Width = 5;
            this.buttonHome.StateCommon.Content.Padding = new System.Windows.Forms.Padding(8, 55, -1, -1);
            this.buttonHome.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHome.StateNormal.Back.Color1 = System.Drawing.Color.LightPink;
            this.buttonHome.StateNormal.Back.Color2 = System.Drawing.Color.MistyRose;
            this.buttonHome.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonHome.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonHome.StatePressed.Back.Color1 = System.Drawing.Color.LightPink;
            this.buttonHome.StatePressed.Back.Color2 = System.Drawing.Color.Crimson;
            this.buttonHome.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonHome.StateTracking.Back.Color1 = System.Drawing.Color.LightPink;
            this.buttonHome.StateTracking.Back.Color2 = System.Drawing.Color.HotPink;
            this.buttonHome.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonHome.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonHome.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonHome.TabIndex = 2;
            this.buttonHome.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.buttonHome.Values.Text = "Головна";
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonFav
            // 
            this.buttonFav.CornerRoundingRadius = 25F;
            this.buttonFav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFav.Location = new System.Drawing.Point(24, 568);
            this.buttonFav.Name = "buttonFav";
            this.buttonFav.OverrideDefault.Back.Color1 = System.Drawing.Color.LightPink;
            this.buttonFav.OverrideDefault.Back.Color2 = System.Drawing.Color.MistyRose;
            this.buttonFav.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.buttonFav.Size = new System.Drawing.Size(243, 134);
            this.buttonFav.StateCommon.Back.Color1 = System.Drawing.Color.LightPink;
            this.buttonFav.StateCommon.Back.Color2 = System.Drawing.Color.MistyRose;
            this.buttonFav.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            this.buttonFav.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonFav.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(150)))), ((int)(((byte)(146)))));
            this.buttonFav.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(150)))), ((int)(((byte)(146)))));
            this.buttonFav.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonFav.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonFav.StateCommon.Border.Rounding = 25F;
            this.buttonFav.StateCommon.Border.Width = 5;
            this.buttonFav.StateCommon.Content.Padding = new System.Windows.Forms.Padding(8, 55, -1, -1);
            this.buttonFav.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFav.StateNormal.Back.Color1 = System.Drawing.Color.LightPink;
            this.buttonFav.StateNormal.Back.Color2 = System.Drawing.Color.MistyRose;
            this.buttonFav.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonFav.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonFav.StatePressed.Back.Color1 = System.Drawing.Color.LightPink;
            this.buttonFav.StatePressed.Back.Color2 = System.Drawing.Color.Crimson;
            this.buttonFav.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonFav.StateTracking.Back.Color1 = System.Drawing.Color.LightPink;
            this.buttonFav.StateTracking.Back.Color2 = System.Drawing.Color.HotPink;
            this.buttonFav.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonFav.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonFav.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonFav.TabIndex = 3;
            this.buttonFav.Values.Text = "Улюблене";
            this.buttonFav.Click += new System.EventHandler(this.buttonFav_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLogo.Image = Image.FromFile("Images/newicon2.png");
            this.pictureBoxLogo.Location = new System.Drawing.Point(21, 21);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(237, 229);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click);
            // 
            // AppSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AppSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AppSettings";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelCenter.ResumeLayout(false);
            this.panelCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxLanguage)).EndInit();
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonSignIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonExit)).EndInit();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFav)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox buttonSignIn;
        private System.Windows.Forms.PictureBox buttonExit;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox pictureBoxSettings;
        private System.Windows.Forms.PictureBox pictureBoxHome;
        private System.Windows.Forms.PictureBox pictureBoxFav;
        private Krypton.Toolkit.KryptonButton buttonSettings;
        private Krypton.Toolkit.KryptonButton buttonHome;
        private Krypton.Toolkit.KryptonButton buttonFav;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private Krypton.Toolkit.KryptonLabel labelLanguage;
        private Krypton.Toolkit.KryptonComboBox comboBoxLanguage;
        private Krypton.Toolkit.KryptonLabel labelSettingsInterface;
        private Krypton.Toolkit.KryptonLabel labelTheme;
        private Krypton.Toolkit.KryptonComboBox comboBoxTheme;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
        private Krypton.Toolkit.KryptonLabel labelAccSett;
        private Krypton.Toolkit.KryptonLabel labelNickname;
        private Krypton.Toolkit.KryptonTextBox textBoxUsername;
    }
}