namespace NDP_ODEV2
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
            label1 = new Label();
            label2 = new Label();
            NoktaCemberButton = new RadioButton();
            DikdortgenButton = new RadioButton();
            CemberButton = new RadioButton();
            KureButton = new RadioButton();
            YuzeyPrizmaButton = new RadioButton();
            KurePrizmaButton = new RadioButton();
            NoktaSilindirButton = new RadioButton();
            DikdortgenCemberButton = new RadioButton();
            NoktaPrizmaButton = new RadioButton();
            DikdortgenPrizmaButton = new RadioButton();
            YuzeyKureButton = new RadioButton();
            NoktaKureButton = new RadioButton();
            KureSilindirButton = new RadioButton();
            SilindirButton = new RadioButton();
            NoktaDortgenButton = new RadioButton();
            YuzeySilindirButton = new RadioButton();
            CizButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.MenuHighlight;
            label1.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(542, 28);
            label1.TabIndex = 0;
            label1.Text = "LÜTFEN SEÇİM YAPINIZ VE ÇİZ'E TIKLAYINIZ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Snap ITC", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(586, 33);
            label2.Name = "label2";
            label2.Size = new Size(470, 44);
            label2.TabIndex = 1;
            label2.Text = "ÇARPIŞMA DENETİMİ";
            // 
            // NoktaCemberButton
            // 
            NoktaCemberButton.AutoSize = true;
            NoktaCemberButton.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NoktaCemberButton.ForeColor = Color.DarkRed;
            NoktaCemberButton.Location = new Point(34, 169);
            NoktaCemberButton.Name = "NoktaCemberButton";
            NoktaCemberButton.Size = new Size(312, 31);
            NoktaCemberButton.TabIndex = 3;
            NoktaCemberButton.TabStop = true;
            NoktaCemberButton.Text = "Nokta, çember çarpışma ";
            NoktaCemberButton.UseVisualStyleBackColor = true;
            NoktaCemberButton.CheckedChanged += NoktaCemberButton_CheckedChanged;
            // 
            // DikdortgenButton
            // 
            DikdortgenButton.AutoSize = true;
            DikdortgenButton.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DikdortgenButton.ForeColor = Color.DarkRed;
            DikdortgenButton.Location = new Point(34, 234);
            DikdortgenButton.Name = "DikdortgenButton";
            DikdortgenButton.Size = new Size(405, 31);
            DikdortgenButton.TabIndex = 4;
            DikdortgenButton.TabStop = true;
            DikdortgenButton.Text = "Dikdörtgen, dikdörtgen çarpışma ";
            DikdortgenButton.UseVisualStyleBackColor = true;
            DikdortgenButton.CheckedChanged += DikdortgenButton_CheckedChanged;
            // 
            // CemberButton
            // 
            CemberButton.AutoSize = true;
            CemberButton.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CemberButton.ForeColor = Color.DarkRed;
            CemberButton.Location = new Point(34, 375);
            CemberButton.Name = "CemberButton";
            CemberButton.Size = new Size(335, 31);
            CemberButton.TabIndex = 5;
            CemberButton.TabStop = true;
            CemberButton.Text = "Çember, çember çarpışma ";
            CemberButton.UseVisualStyleBackColor = true;
            CemberButton.CheckedChanged += CemberButton_CheckedChanged;
            // 
            // KureButton
            // 
            KureButton.AutoSize = true;
            KureButton.Font = new Font("Arial Rounded MT Bold", 13.8F);
            KureButton.ForeColor = Color.DarkRed;
            KureButton.Location = new Point(464, 169);
            KureButton.Name = "KureButton";
            KureButton.Size = new Size(266, 31);
            KureButton.TabIndex = 6;
            KureButton.TabStop = true;
            KureButton.Text = "Küre, küre çarpışma ";
            KureButton.UseVisualStyleBackColor = true;
            KureButton.CheckedChanged += KureButton_CheckedChanged;
            // 
            // YuzeyPrizmaButton
            // 
            YuzeyPrizmaButton.AutoSize = true;
            YuzeyPrizmaButton.Font = new Font("Arial Rounded MT Bold", 13.8F);
            YuzeyPrizmaButton.ForeColor = Color.DarkRed;
            YuzeyPrizmaButton.Location = new Point(464, 375);
            YuzeyPrizmaButton.Name = "YuzeyPrizmaButton";
            YuzeyPrizmaButton.Size = new Size(423, 31);
            YuzeyPrizmaButton.TabIndex = 7;
            YuzeyPrizmaButton.TabStop = true;
            YuzeyPrizmaButton.Text = "Yüzey, dikdörtgen prizma çarpışma";
            YuzeyPrizmaButton.UseVisualStyleBackColor = true;
            YuzeyPrizmaButton.CheckedChanged += YuzeyPrizmaButton_CheckedChanged;
            // 
            // KurePrizmaButton
            // 
            KurePrizmaButton.AutoSize = true;
            KurePrizmaButton.Font = new Font("Arial Rounded MT Bold", 13.8F);
            KurePrizmaButton.ForeColor = Color.DarkRed;
            KurePrizmaButton.Location = new Point(464, 516);
            KurePrizmaButton.Name = "KurePrizmaButton";
            KurePrizmaButton.Size = new Size(418, 31);
            KurePrizmaButton.TabIndex = 8;
            KurePrizmaButton.TabStop = true;
            KurePrizmaButton.Text = "Küre, dikdörtgen prizma çarpışma ";
            KurePrizmaButton.UseVisualStyleBackColor = true;
            KurePrizmaButton.CheckedChanged += KurePrizmaButton_CheckedChanged;
            // 
            // NoktaSilindirButton
            // 
            NoktaSilindirButton.AutoSize = true;
            NoktaSilindirButton.Font = new Font("Arial Rounded MT Bold", 13.8F);
            NoktaSilindirButton.ForeColor = Color.DarkRed;
            NoktaSilindirButton.Location = new Point(34, 580);
            NoktaSilindirButton.Name = "NoktaSilindirButton";
            NoktaSilindirButton.Size = new Size(297, 31);
            NoktaSilindirButton.TabIndex = 9;
            NoktaSilindirButton.TabStop = true;
            NoktaSilindirButton.Text = "Nokta, Silindir çarpışma";
            NoktaSilindirButton.UseVisualStyleBackColor = true;
            NoktaSilindirButton.CheckedChanged += NoktaSilindirButton_CheckedChanged;
            // 
            // DikdortgenCemberButton
            // 
            DikdortgenCemberButton.AutoSize = true;
            DikdortgenCemberButton.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DikdortgenCemberButton.ForeColor = Color.DarkRed;
            DikdortgenCemberButton.Location = new Point(34, 308);
            DikdortgenCemberButton.Name = "DikdortgenCemberButton";
            DikdortgenCemberButton.Size = new Size(370, 31);
            DikdortgenCemberButton.TabIndex = 10;
            DikdortgenCemberButton.TabStop = true;
            DikdortgenCemberButton.Text = "Dikdörtgen, çember çarpışma ";
            DikdortgenCemberButton.UseVisualStyleBackColor = true;
            DikdortgenCemberButton.CheckedChanged += DikdortgenCemberButton_CheckedChanged;
            // 
            // NoktaPrizmaButton
            // 
            NoktaPrizmaButton.AutoSize = true;
            NoktaPrizmaButton.Font = new Font("Arial Rounded MT Bold", 13.8F);
            NoktaPrizmaButton.ForeColor = Color.DarkRed;
            NoktaPrizmaButton.Location = new Point(34, 516);
            NoktaPrizmaButton.Name = "NoktaPrizmaButton";
            NoktaPrizmaButton.Size = new Size(429, 31);
            NoktaPrizmaButton.TabIndex = 11;
            NoktaPrizmaButton.TabStop = true;
            NoktaPrizmaButton.Text = "Nokta, dikdörtgen prizma çarpışma ";
            NoktaPrizmaButton.UseVisualStyleBackColor = true;
            NoktaPrizmaButton.CheckedChanged += NoktaPrizmaButton_CheckedChanged;
            // 
            // DikdortgenPrizmaButton
            // 
            DikdortgenPrizmaButton.AutoSize = true;
            DikdortgenPrizmaButton.Font = new Font("Arial Rounded MT Bold", 13.8F);
            DikdortgenPrizmaButton.ForeColor = Color.DarkRed;
            DikdortgenPrizmaButton.Location = new Point(464, 580);
            DikdortgenPrizmaButton.Name = "DikdortgenPrizmaButton";
            DikdortgenPrizmaButton.Size = new Size(563, 31);
            DikdortgenPrizmaButton.TabIndex = 12;
            DikdortgenPrizmaButton.TabStop = true;
            DikdortgenPrizmaButton.Text = "Dikdörtgen prizma, dikdörtgen prizma çarpışma";
            DikdortgenPrizmaButton.UseVisualStyleBackColor = true;
            DikdortgenPrizmaButton.CheckedChanged += DikdortgenPrizmaButton_CheckedChanged;
            // 
            // YuzeyKureButton
            // 
            YuzeyKureButton.AutoSize = true;
            YuzeyKureButton.Font = new Font("Arial Rounded MT Bold", 13.8F);
            YuzeyKureButton.ForeColor = Color.DarkRed;
            YuzeyKureButton.Location = new Point(464, 308);
            YuzeyKureButton.Name = "YuzeyKureButton";
            YuzeyKureButton.Size = new Size(271, 31);
            YuzeyKureButton.TabIndex = 13;
            YuzeyKureButton.TabStop = true;
            YuzeyKureButton.Text = "Yüzey, küre çarpışma";
            YuzeyKureButton.UseVisualStyleBackColor = true;
            YuzeyKureButton.CheckedChanged += YuzeyKureButton_CheckedChanged;
            // 
            // NoktaKureButton
            // 
            NoktaKureButton.AutoSize = true;
            NoktaKureButton.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NoktaKureButton.ForeColor = Color.DarkRed;
            NoktaKureButton.Location = new Point(34, 446);
            NoktaKureButton.Name = "NoktaKureButton";
            NoktaKureButton.Size = new Size(275, 31);
            NoktaKureButton.TabIndex = 14;
            NoktaKureButton.TabStop = true;
            NoktaKureButton.Text = "Nokta, Küre çarpışma";
            NoktaKureButton.UseVisualStyleBackColor = true;
            NoktaKureButton.CheckedChanged += NoktaKureButton_CheckedChanged;
            // 
            // KureSilindirButton
            // 
            KureSilindirButton.AutoSize = true;
            KureSilindirButton.Font = new Font("Arial Rounded MT Bold", 13.8F);
            KureSilindirButton.ForeColor = Color.DarkRed;
            KureSilindirButton.Location = new Point(464, 234);
            KureSilindirButton.Name = "KureSilindirButton";
            KureSilindirButton.Size = new Size(276, 31);
            KureSilindirButton.TabIndex = 15;
            KureSilindirButton.TabStop = true;
            KureSilindirButton.Text = "Küre silindir çarpışma";
            KureSilindirButton.UseVisualStyleBackColor = true;
            KureSilindirButton.CheckedChanged += KureSilindirButton_CheckedChanged;
            // 
            // SilindirButton
            // 
            SilindirButton.AutoSize = true;
            SilindirButton.Font = new Font("Arial Rounded MT Bold", 13.8F);
            SilindirButton.ForeColor = Color.DarkRed;
            SilindirButton.Location = new Point(464, 100);
            SilindirButton.Name = "SilindirButton";
            SilindirButton.Size = new Size(305, 31);
            SilindirButton.TabIndex = 16;
            SilindirButton.TabStop = true;
            SilindirButton.Text = "Silindir, silindir çarpışma";
            SilindirButton.UseVisualStyleBackColor = true;
            SilindirButton.CheckedChanged += SilindirButton_CheckedChanged;
            // 
            // NoktaDortgenButton
            // 
            NoktaDortgenButton.AutoSize = true;
            NoktaDortgenButton.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NoktaDortgenButton.ForeColor = Color.DarkRed;
            NoktaDortgenButton.Location = new Point(34, 100);
            NoktaDortgenButton.Name = "NoktaDortgenButton";
            NoktaDortgenButton.Size = new Size(317, 31);
            NoktaDortgenButton.TabIndex = 17;
            NoktaDortgenButton.TabStop = true;
            NoktaDortgenButton.Text = "Nokta, Dörtgen çarpışma ";
            NoktaDortgenButton.UseVisualStyleBackColor = true;
            NoktaDortgenButton.CheckedChanged += NoktaDortgenButton_CheckedChanged;
            // 
            // YuzeySilindirButton
            // 
            YuzeySilindirButton.AutoSize = true;
            YuzeySilindirButton.Font = new Font("Arial Rounded MT Bold", 13.8F);
            YuzeySilindirButton.ForeColor = Color.DarkRed;
            YuzeySilindirButton.Location = new Point(464, 446);
            YuzeySilindirButton.Name = "YuzeySilindirButton";
            YuzeySilindirButton.Size = new Size(287, 31);
            YuzeySilindirButton.TabIndex = 18;
            YuzeySilindirButton.TabStop = true;
            YuzeySilindirButton.Text = "Yüzey silindir çarpışma";
            YuzeySilindirButton.UseVisualStyleBackColor = true;
            YuzeySilindirButton.CheckedChanged += YuzeySilindirButton_CheckedChanged;
            // 
            // CizButton
            // 
            CizButton.BackColor = Color.Cyan;
            CizButton.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            CizButton.Location = new Point(792, 139);
            CizButton.Name = "CizButton";
            CizButton.Size = new Size(235, 170);
            CizButton.TabIndex = 19;
            CizButton.Text = "Çiz";
            CizButton.UseVisualStyleBackColor = false;
            CizButton.Click += CizButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1079, 640);
            Controls.Add(CizButton);
            Controls.Add(YuzeySilindirButton);
            Controls.Add(NoktaDortgenButton);
            Controls.Add(SilindirButton);
            Controls.Add(KureSilindirButton);
            Controls.Add(NoktaKureButton);
            Controls.Add(YuzeyKureButton);
            Controls.Add(DikdortgenPrizmaButton);
            Controls.Add(NoktaPrizmaButton);
            Controls.Add(DikdortgenCemberButton);
            Controls.Add(NoktaSilindirButton);
            Controls.Add(KurePrizmaButton);
            Controls.Add(YuzeyPrizmaButton);
            Controls.Add(KureButton);
            Controls.Add(CemberButton);
            Controls.Add(DikdortgenButton);
            Controls.Add(NoktaCemberButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private RadioButton NoktaCemberButton;
        private RadioButton DikdortgenButton;
        private RadioButton CemberButton;
        private RadioButton KureButton;
        private RadioButton YuzeyPrizmaButton;
        private RadioButton KurePrizmaButton;
        private RadioButton NoktaSilindirButton;
        private RadioButton DikdortgenCemberButton;
        private RadioButton NoktaPrizmaButton;
        private RadioButton DikdortgenPrizmaButton;
        private RadioButton YuzeyKureButton;
        private RadioButton NoktaKureButton;
        private RadioButton KureSilindirButton;
        private RadioButton SilindirButton;
        private RadioButton NoktaDortgenButton;
        private RadioButton YuzeySilindirButton;
        private Button CizButton;
    }
}
