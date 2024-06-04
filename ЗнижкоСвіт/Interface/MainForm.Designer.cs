using System.Drawing;

namespace ЗнижкоСвіт
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pictureBoxSettings = new System.Windows.Forms.PictureBox();
            this.pictureBoxHome = new System.Windows.Forms.PictureBox();
            this.pictureBoxFav = new System.Windows.Forms.PictureBox();
            this.buttonSettings = new Krypton.Toolkit.KryptonButton();
            this.buttonHome = new Krypton.Toolkit.KryptonButton();
            this.buttonFav = new Krypton.Toolkit.KryptonButton();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonSignIn = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.PictureBox();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.tablePanelCards = new System.Windows.Forms.TableLayoutPanel();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFav)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSignIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonExit)).BeginInit();
            this.panelCenter.SuspendLayout();
            this.SuspendLayout();
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
            this.panelMenu.TabIndex = 0;
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
            this.buttonSettings.OverrideDefault.Back.Color2 = System.Drawing.Color.MistyRose;
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
            this.buttonSettings.StateNormal.Back.Color2 = System.Drawing.Color.MistyRose;
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
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.CornerRoundingRadius = 25F;
            this.buttonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHome.Location = new System.Drawing.Point(24, 360);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.OverrideDefault.Back.Color1 = System.Drawing.Color.LightPink;
            this.buttonHome.OverrideDefault.Back.Color2 = System.Drawing.Color.HotPink;
            this.buttonHome.OverrideFocus.Back.Color1 = System.Drawing.Color.LightPink;
            this.buttonHome.OverrideFocus.Back.Color2 = System.Drawing.Color.HotPink;
            this.buttonHome.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.buttonHome.Size = new System.Drawing.Size(243, 134);
            this.buttonHome.StateCommon.Back.Color1 = System.Drawing.Color.LightPink;
            this.buttonHome.StateCommon.Back.Color2 = System.Drawing.Color.HotPink;
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
            this.buttonHome.StateNormal.Back.Color2 = System.Drawing.Color.HotPink;
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
            this.panelTop.TabIndex = 1;
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
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.tablePanelCards);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(294, 120);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(1626, 960);
            this.panelCenter.TabIndex = 3;
            // 
            // tablePanelCards
            // 
            this.tablePanelCards.AutoScroll = true;
            this.tablePanelCards.ColumnCount = 4;
            this.tablePanelCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablePanelCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablePanelCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablePanelCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablePanelCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelCards.Location = new System.Drawing.Point(0, 0);
            this.tablePanelCards.Name = "tablePanelCards";
            this.tablePanelCards.RowCount = 1;
            this.tablePanelCards.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelCards.Size = new System.Drawing.Size(1626, 960);
            this.tablePanelCards.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ЗнижкоСвіт";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFav)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonSignIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonExit)).EndInit();
            this.panelCenter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.PictureBox buttonExit;
        private System.Windows.Forms.PictureBox buttonSignIn;
        private Krypton.Toolkit.KryptonButton buttonHome;
        private Krypton.Toolkit.KryptonButton buttonSettings;
        private Krypton.Toolkit.KryptonButton buttonFav;
        private System.Windows.Forms.PictureBox pictureBoxHome;
        private System.Windows.Forms.PictureBox pictureBoxFav;
        private System.Windows.Forms.PictureBox pictureBoxSettings;
        private System.Windows.Forms.TableLayoutPanel tablePanelCards;
    }
}

