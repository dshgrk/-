using System.Drawing;

namespace ЗнижкоСвіт
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.textBoxPassword = new Krypton.Toolkit.KryptonRichTextBox();
            this.buttonSignUp = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabelName = new Krypton.Toolkit.KryptonLabel();
            this.textBoxUsername = new Krypton.Toolkit.KryptonRichTextBox();
            this.kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            this.labelToSignIn = new Krypton.Toolkit.KryptonLabel();
            this.buttonExitSignup = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.textBoxPassword.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(211)))), ((int)(((byte)(228)))));
            this.textBoxPassword.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(211)))), ((int)(((byte)(228)))));
            this.textBoxPassword.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxPassword.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.textBoxPassword.StateCommon.Border.Rounding = 28F;
            this.textBoxPassword.StateCommon.Border.Width = 5;
            this.textBoxPassword.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.textBoxPassword.StateCommon.Content.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.StateCommon.Content.Padding = new System.Windows.Forms.Padding(7, -1, 10, 1);
            this.textBoxPassword.TabIndex = 12;
            this.textBoxPassword.Text = "";
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.CornerRoundingRadius = 25F;
            this.buttonSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSignUp.Location = new System.Drawing.Point(674, 447);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(150)))), ((int)(((byte)(146)))));
            this.buttonSignUp.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(150)))), ((int)(((byte)(146)))));
            this.buttonSignUp.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonSignUp.OverrideDefault.Border.Rounding = 40F;
            this.buttonSignUp.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.MistyRose;
            this.buttonSignUp.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.MistyRose;
            this.buttonSignUp.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.buttonSignUp.Size = new System.Drawing.Size(194, 55);
            this.buttonSignUp.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(150)))), ((int)(((byte)(146)))));
            this.buttonSignUp.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            this.buttonSignUp.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonSignUp.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.buttonSignUp.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.buttonSignUp.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.buttonSignUp.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonSignUp.StateCommon.Border.Rounding = 40F;
            this.buttonSignUp.StateCommon.Border.Width = 1;
            this.buttonSignUp.StateCommon.Content.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.buttonSignUp.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.MistyRose;
            this.buttonSignUp.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSignUp.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(150)))), ((int)(((byte)(146)))));
            this.buttonSignUp.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(150)))), ((int)(((byte)(146)))));
            this.buttonSignUp.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonSignUp.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonSignUp.StateNormal.Border.Rounding = 40F;
            this.buttonSignUp.StatePressed.Back.Color1 = System.Drawing.Color.LightPink;
            this.buttonSignUp.StatePressed.Back.Color2 = System.Drawing.Color.Crimson;
            this.buttonSignUp.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonSignUp.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonSignUp.StatePressed.Border.Rounding = 35F;
            this.buttonSignUp.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.MistyRose;
            this.buttonSignUp.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.MistyRose;
            this.buttonSignUp.StateTracking.Back.Color1 = System.Drawing.Color.LightPink;
            this.buttonSignUp.StateTracking.Back.Color2 = System.Drawing.Color.HotPink;
            this.buttonSignUp.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonSignUp.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonSignUp.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonSignUp.StateTracking.Border.Rounding = 40F;
            this.buttonSignUp.TabIndex = 10;
            this.buttonSignUp.Values.Text = "Реєстрація";
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // kryptonLabelName
            // 
            this.kryptonLabelName.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel;
            this.kryptonLabelName.Location = new System.Drawing.Point(563, 90);
            this.kryptonLabelName.Name = "kryptonLabelName";
            this.kryptonLabelName.Size = new System.Drawing.Size(423, 68);
            this.kryptonLabelName.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(150)))), ((int)(((byte)(146)))));
            this.kryptonLabelName.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(150)))), ((int)(((byte)(146)))));
            this.kryptonLabelName.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonLabelName.StateCommon.ShortText.Font = new System.Drawing.Font("Comic Sans MS", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonLabelName.TabIndex = 9;
            this.kryptonLabelName.Values.Text = "Створення акаунту";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.CornerRoundingRadius = 17F;
            this.textBoxUsername.CueHint.Color1 = System.Drawing.Color.Gray;
            this.textBoxUsername.CueHint.CueHintText = "Нікнейм";
            this.textBoxUsername.CueHint.Font = new System.Drawing.Font("Montserrat", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUsername.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.textBoxUsername.CueHint.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.textBoxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxUsername.Location = new System.Drawing.Point(576, 212);
            this.textBoxUsername.MaxLength = 100;
            this.textBoxUsername.Multiline = false;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(388, 65);
            this.textBoxUsername.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(211)))), ((int)(((byte)(228)))));
            this.textBoxUsername.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(211)))), ((int)(((byte)(228)))));
            this.textBoxUsername.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxUsername.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.textBoxUsername.StateCommon.Border.Rounding = 28F;
            this.textBoxUsername.StateCommon.Border.Width = 5;
            this.textBoxUsername.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.textBoxUsername.StateCommon.Content.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUsername.StateCommon.Content.Padding = new System.Windows.Forms.Padding(7, -1, 10, 1);
            this.textBoxUsername.TabIndex = 8;
            this.textBoxUsername.Text = "";
            this.textBoxUsername.WordWrap = false;
            // 
            // kryptonPictureBox1
            // 
            this.kryptonPictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kryptonPictureBox1.BackgroundImage")));
            this.kryptonPictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonPictureBox1.Image = Image.FromFile("Images/img3.jpg");
            this.kryptonPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPictureBox1.Name = "kryptonPictureBox1";
            this.kryptonPictureBox1.Size = new System.Drawing.Size(554, 617);
            this.kryptonPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kryptonPictureBox1.TabIndex = 7;
            this.kryptonPictureBox1.TabStop = false;
            // 
            // labelToSignIn
            // 
            this.labelToSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelToSignIn.Location = new System.Drawing.Point(685, 508);
            this.labelToSignIn.Name = "labelToSignIn";
            this.labelToSignIn.Size = new System.Drawing.Size(168, 23);
            this.labelToSignIn.StateCommon.ShortText.Color1 = System.Drawing.Color.PaleVioletRed;
            this.labelToSignIn.StateCommon.ShortText.Color2 = System.Drawing.Color.PaleVioletRed;
            this.labelToSignIn.StateCommon.ShortText.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelToSignIn.TabIndex = 13;
            this.labelToSignIn.Values.Text = "Вже маєте акаунт?";
            this.labelToSignIn.Click += new System.EventHandler(this.labelToSignIn_Click);
            // 
            // buttonExitSignup
            // 
            this.buttonExitSignup.CornerRoundingRadius = 25F;
            this.buttonExitSignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExitSignup.Location = new System.Drawing.Point(902, 12);
            this.buttonExitSignup.Name = "buttonExitSignup";
            this.buttonExitSignup.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(150)))), ((int)(((byte)(146)))));
            this.buttonExitSignup.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(150)))), ((int)(((byte)(146)))));
            this.buttonExitSignup.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonExitSignup.OverrideDefault.Border.Rounding = 40F;
            this.buttonExitSignup.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.MistyRose;
            this.buttonExitSignup.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.MistyRose;
            this.buttonExitSignup.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.buttonExitSignup.Size = new System.Drawing.Size(71, 71);
            this.buttonExitSignup.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(150)))), ((int)(((byte)(146)))));
            this.buttonExitSignup.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            this.buttonExitSignup.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonExitSignup.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.buttonExitSignup.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.buttonExitSignup.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.buttonExitSignup.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonExitSignup.StateCommon.Border.Rounding = 40F;
            this.buttonExitSignup.StateCommon.Border.Width = 1;
            this.buttonExitSignup.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-19, 12, 15, 0);
            this.buttonExitSignup.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.MistyRose;
            this.buttonExitSignup.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Montserrat SemiBold", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExitSignup.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(150)))), ((int)(((byte)(146)))));
            this.buttonExitSignup.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(150)))), ((int)(((byte)(146)))));
            this.buttonExitSignup.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonExitSignup.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonExitSignup.StateNormal.Border.Rounding = 40F;
            this.buttonExitSignup.StatePressed.Back.Color1 = System.Drawing.Color.LightPink;
            this.buttonExitSignup.StatePressed.Back.Color2 = System.Drawing.Color.Crimson;
            this.buttonExitSignup.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonExitSignup.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonExitSignup.StatePressed.Border.Rounding = 35F;
            this.buttonExitSignup.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.MistyRose;
            this.buttonExitSignup.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.MistyRose;
            this.buttonExitSignup.StateTracking.Back.Color1 = System.Drawing.Color.LightPink;
            this.buttonExitSignup.StateTracking.Back.Color2 = System.Drawing.Color.HotPink;
            this.buttonExitSignup.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonExitSignup.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonExitSignup.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonExitSignup.StateTracking.Border.Rounding = 40F;
            this.buttonExitSignup.TabIndex = 17;
            this.buttonExitSignup.Values.Text = "✖";
            this.buttonExitSignup.Click += new System.EventHandler(this.buttonExitSignup_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(985, 617);
            this.Controls.Add(this.buttonExitSignup);
            this.Controls.Add(this.labelToSignIn);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.kryptonLabelName);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.kryptonPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.FormTitleAlign = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.FormCustom1;
            this.GroupBorderStyle = Krypton.Toolkit.PaletteBorderStyle.FormCustom1;
            this.HeaderStyle = Krypton.Toolkit.HeaderStyle.Custom1;
            this.Name = "SignUp";
            this.ShadowValues.BlurDistance = 0D;
            this.ShadowValues.Colour = System.Drawing.Color.Empty;
            this.ShadowValues.EnableShadows = true;
            this.ShadowValues.ExtraWidth = ((byte)(0));
            this.ShadowValues.Offset = new System.Drawing.Point(0, 0);
            this.ShadowValues.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateActive.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateActive.Border.Rounding = 20F;
            this.StateActive.Border.Width = 0;
            this.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Width = 0;
            this.StateInactive.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateInactive.Border.Rounding = 20F;
            this.StateInactive.Border.Width = 0;
            this.TitleStyle = Krypton.Toolkit.KryptonFormTitleStyle.Modern;
            this.UseDropShadow = true;
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonRichTextBox textBoxPassword;
        private Krypton.Toolkit.KryptonButton buttonSignUp;
        private Krypton.Toolkit.KryptonLabel kryptonLabelName;
        private Krypton.Toolkit.KryptonRichTextBox textBoxUsername;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
        private Krypton.Toolkit.KryptonLabel labelToSignIn;
        private Krypton.Toolkit.KryptonButton buttonExitSignup;
    }
}