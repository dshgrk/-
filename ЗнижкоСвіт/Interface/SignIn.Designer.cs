using System.Drawing;

namespace ЗнижкоСвіт
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            this.textBoxUsername = new Krypton.Toolkit.KryptonRichTextBox();
            this.kryptonLabelName = new Krypton.Toolkit.KryptonLabel();
            this.textBoxPassword = new Krypton.Toolkit.KryptonRichTextBox();
            this.LabelToSignUp = new Krypton.Toolkit.KryptonLabel();
            this.buttonSignIn = new Krypton.Toolkit.KryptonButton();
            this.buttonExitLogin = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPictureBox1
            // 
            this.kryptonPictureBox1.BackgroundImage = Image.FromFile("Images/img3.jpg");
            this.kryptonPictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPictureBox1.Image")));
            this.kryptonPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPictureBox1.Name = "kryptonPictureBox1";
            this.kryptonPictureBox1.Size = new System.Drawing.Size(554, 617);
            this.kryptonPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kryptonPictureBox1.TabIndex = 0;
            this.kryptonPictureBox1.TabStop = false;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.CornerRoundingRadius = 17F;
            this.textBoxUsername.CueHint.Color1 = System.Drawing.Color.Gray;
            this.textBoxUsername.CueHint.CueHintText = "Нікнейм";
            this.textBoxUsername.CueHint.Font = new System.Drawing.Font("Montserrat", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUsername.CueHint.Hint = Krypton.Toolkit.PaletteTextHint.ClearTypeGridFit;
            this.textBoxUsername.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.textBoxUsername.CueHint.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.textBoxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxUsername.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.textBoxUsername.Location = new System.Drawing.Point(576, 212);
            this.textBoxUsername.MaxLength = 100;
            this.textBoxUsername.Multiline = false;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(388, 65);
            this.textBoxUsername.StateActive.Content.Font = new System.Drawing.Font("Montserrat", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUsername.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(211)))), ((int)(((byte)(228)))));
            this.textBoxUsername.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(211)))), ((int)(((byte)(228)))));
            this.textBoxUsername.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxUsername.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.textBoxUsername.StateCommon.Border.Rounding = 28F;
            this.textBoxUsername.StateCommon.Border.Width = 5;
            this.textBoxUsername.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.textBoxUsername.StateCommon.Content.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.textBoxUsername.StateCommon.Content.Padding = new System.Windows.Forms.Padding(7, -1, 10, 1);
            this.textBoxUsername.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.textBoxUsername.TabIndex = 1;
            this.textBoxUsername.Text = "";
            this.textBoxUsername.WordWrap = false;
            // 
            // kryptonLabelName
            // 
            this.kryptonLabelName.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel;
            this.kryptonLabelName.Location = new System.Drawing.Point(630, 90);
            this.kryptonLabelName.Name = "kryptonLabelName";
            this.kryptonLabelName.Size = new System.Drawing.Size(281, 68);
            this.kryptonLabelName.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(150)))), ((int)(((byte)(146)))));
            this.kryptonLabelName.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(150)))), ((int)(((byte)(146)))));
            this.kryptonLabelName.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonLabelName.StateCommon.ShortText.Font = new System.Drawing.Font("Comic Sans MS", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabelName.TabIndex = 2;
            this.kryptonLabelName.Values.Text = "Авторизація";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.CornerRoundingRadius = 17F;
            this.textBoxPassword.CueHint.Color1 = System.Drawing.Color.Gray;
            this.textBoxPassword.CueHint.CueHintText = "Пароль";
            this.textBoxPassword.CueHint.Font = new System.Drawing.Font("Montserrat", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.textBoxPassword.CueHint.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.textBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPassword.Location = new System.Drawing.Point(576, 297);
            this.textBoxPassword.MaxLength = 100;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(388, 65);
            this.textBoxPassword.StateActive.Content.Font = new System.Drawing.Font("Montserrat", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(211)))), ((int)(((byte)(228)))));
            this.textBoxPassword.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(211)))), ((int)(((byte)(228)))));
            this.textBoxPassword.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxPassword.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.textBoxPassword.StateCommon.Border.Rounding = 28F;
            this.textBoxPassword.StateCommon.Border.Width = 5;
            this.textBoxPassword.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.textBoxPassword.StateCommon.Content.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.textBoxPassword.StateCommon.Content.Padding = new System.Windows.Forms.Padding(7, -1, 10, 1);
            this.textBoxPassword.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.textBoxPassword.TabIndex = 6;
            this.textBoxPassword.Text = "";
            // 
            // LabelToSignUp
            // 
            this.LabelToSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelToSignUp.Location = new System.Drawing.Point(657, 508);
            this.LabelToSignUp.Name = "LabelToSignUp";
            this.LabelToSignUp.Size = new System.Drawing.Size(232, 23);
            this.LabelToSignUp.StateCommon.ShortText.Color1 = System.Drawing.Color.PaleVioletRed;
            this.LabelToSignUp.StateCommon.ShortText.Color2 = System.Drawing.Color.PaleVioletRed;
            this.LabelToSignUp.StateCommon.ShortText.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelToSignUp.TabIndex = 15;
            this.LabelToSignUp.Values.Text = "Бажаєте створити акаунт?";
            this.LabelToSignUp.Click += new System.EventHandler(this.LabelToSignUp_Click);
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.CornerRoundingRadius = 25F;
            this.buttonSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSignIn.Location = new System.Drawing.Point(674, 447);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(150)))), ((int)(((byte)(146)))));
            this.buttonSignIn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(150)))), ((int)(((byte)(146)))));
            this.buttonSignIn.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonSignIn.OverrideDefault.Border.Rounding = 40F;
            this.buttonSignIn.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.MistyRose;
            this.buttonSignIn.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.MistyRose;
            this.buttonSignIn.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.buttonSignIn.Size = new System.Drawing.Size(194, 55);
            this.buttonSignIn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(150)))), ((int)(((byte)(146)))));
            this.buttonSignIn.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            this.buttonSignIn.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonSignIn.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.buttonSignIn.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.buttonSignIn.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.buttonSignIn.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonSignIn.StateCommon.Border.Rounding = 40F;
            this.buttonSignIn.StateCommon.Border.Width = 1;
            this.buttonSignIn.StateCommon.Content.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.buttonSignIn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.MistyRose;
            this.buttonSignIn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSignIn.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(150)))), ((int)(((byte)(146)))));
            this.buttonSignIn.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(150)))), ((int)(((byte)(146)))));
            this.buttonSignIn.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonSignIn.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonSignIn.StateNormal.Border.Rounding = 40F;
            this.buttonSignIn.StatePressed.Back.Color1 = System.Drawing.Color.LightPink;
            this.buttonSignIn.StatePressed.Back.Color2 = System.Drawing.Color.Crimson;
            this.buttonSignIn.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonSignIn.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonSignIn.StatePressed.Border.Rounding = 35F;
            this.buttonSignIn.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.MistyRose;
            this.buttonSignIn.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.MistyRose;
            this.buttonSignIn.StateTracking.Back.Color1 = System.Drawing.Color.LightPink;
            this.buttonSignIn.StateTracking.Back.Color2 = System.Drawing.Color.HotPink;
            this.buttonSignIn.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonSignIn.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonSignIn.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonSignIn.StateTracking.Border.Rounding = 40F;
            this.buttonSignIn.TabIndex = 14;
            this.buttonSignIn.Values.Text = "Увійти";
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // buttonExitLogin
            // 
            this.buttonExitLogin.CornerRoundingRadius = 25F;
            this.buttonExitLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExitLogin.Location = new System.Drawing.Point(902, 12);
            this.buttonExitLogin.Name = "buttonExitLogin";
            this.buttonExitLogin.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(150)))), ((int)(((byte)(146)))));
            this.buttonExitLogin.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(150)))), ((int)(((byte)(146)))));
            this.buttonExitLogin.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonExitLogin.OverrideDefault.Border.Rounding = 40F;
            this.buttonExitLogin.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.MistyRose;
            this.buttonExitLogin.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.MistyRose;
            this.buttonExitLogin.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.buttonExitLogin.Size = new System.Drawing.Size(71, 71);
            this.buttonExitLogin.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(150)))), ((int)(((byte)(146)))));
            this.buttonExitLogin.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            this.buttonExitLogin.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonExitLogin.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.buttonExitLogin.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.buttonExitLogin.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.buttonExitLogin.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonExitLogin.StateCommon.Border.Rounding = 40F;
            this.buttonExitLogin.StateCommon.Border.Width = 1;
            this.buttonExitLogin.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-19, 12, 15, 0);
            this.buttonExitLogin.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.MistyRose;
            this.buttonExitLogin.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Montserrat SemiBold", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExitLogin.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(150)))), ((int)(((byte)(146)))));
            this.buttonExitLogin.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(150)))), ((int)(((byte)(146)))));
            this.buttonExitLogin.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonExitLogin.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonExitLogin.StateNormal.Border.Rounding = 40F;
            this.buttonExitLogin.StatePressed.Back.Color1 = System.Drawing.Color.LightPink;
            this.buttonExitLogin.StatePressed.Back.Color2 = System.Drawing.Color.Crimson;
            this.buttonExitLogin.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonExitLogin.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonExitLogin.StatePressed.Border.Rounding = 35F;
            this.buttonExitLogin.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.MistyRose;
            this.buttonExitLogin.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.MistyRose;
            this.buttonExitLogin.StateTracking.Back.Color1 = System.Drawing.Color.LightPink;
            this.buttonExitLogin.StateTracking.Back.Color2 = System.Drawing.Color.HotPink;
            this.buttonExitLogin.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonExitLogin.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonExitLogin.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonExitLogin.StateTracking.Border.Rounding = 40F;
            this.buttonExitLogin.TabIndex = 16;
            this.buttonExitLogin.Values.Text = "✖";
            this.buttonExitLogin.Click += new System.EventHandler(this.buttonExitLogin_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(985, 617);
            this.Controls.Add(this.buttonExitLogin);
            this.Controls.Add(this.LabelToSignUp);
            this.Controls.Add(this.buttonSignIn);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.kryptonLabelName);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.kryptonPictureBox1);
            this.CornerRoundingRadius = 20F;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.FormTitleAlign = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.FormCustom1;
            this.GroupBorderStyle = Krypton.Toolkit.PaletteBorderStyle.FormCustom1;
            this.HeaderStyle = Krypton.Toolkit.HeaderStyle.Custom1;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignIn";
            this.ShadowValues.BlurDistance = 0D;
            this.ShadowValues.Colour = System.Drawing.Color.Empty;
            this.ShadowValues.EnableShadows = true;
            this.ShadowValues.ExtraWidth = ((byte)(0));
            this.ShadowValues.Offset = new System.Drawing.Point(0, 0);
            this.ShadowValues.Opacity = 0D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateActive.Back.Color1 = System.Drawing.Color.LightPink;
            this.StateActive.Back.Color2 = System.Drawing.Color.MistyRose;
            this.StateActive.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateActive.Border.Rounding = 20F;
            this.StateCommon.Back.Color1 = System.Drawing.Color.LightPink;
            this.StateCommon.Back.Color2 = System.Drawing.Color.MistyRose;
            this.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(150)))), ((int)(((byte)(146)))));
            this.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(150)))), ((int)(((byte)(146)))));
            this.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Form;
            this.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear25;
            this.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 20F;
            this.StateCommon.Border.Width = 0;
            this.StateCommon.Header.Border.Draw = Krypton.Toolkit.InheritBool.False;
            this.StateCommon.Header.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateInactive.Back.Color1 = System.Drawing.Color.LightPink;
            this.StateInactive.Back.Color2 = System.Drawing.Color.MistyRose;
            this.Text = "Увійти в акаунт";
            this.TitleStyle = Krypton.Toolkit.KryptonFormTitleStyle.Modern;
            this.UseDropShadow = true;
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
        private Krypton.Toolkit.KryptonRichTextBox textBoxUsername;
        private Krypton.Toolkit.KryptonLabel kryptonLabelName;
        private Krypton.Toolkit.KryptonRichTextBox textBoxPassword;
        private Krypton.Toolkit.KryptonLabel LabelToSignUp;
        private Krypton.Toolkit.KryptonButton buttonSignIn;
        private Krypton.Toolkit.KryptonButton buttonExitLogin;
    }
}