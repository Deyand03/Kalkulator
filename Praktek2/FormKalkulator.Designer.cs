namespace Praktek2
{
    partial class Kalkulator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kalkulator));
            buttonplus = new Button();
            buttonminus = new Button();
            buttonkali = new Button();
            buttonbagi = new Button();
            buttonhasil = new Button();
            button0 = new Button();
            button1 = new Button();
            textboxhasil = new TextBox();
            button2 = new Button();
            button3 = new Button();
            buttontitik = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            buttonplusminus = new Button();
            buttondelete = new Button();
            buttondeleteall = new Button();
            buttononoff = new Button();
            SuspendLayout();
            // 
            // buttonplus
            // 
            buttonplus.BackColor = Color.DimGray;
            buttonplus.FlatAppearance.BorderSize = 0;
            buttonplus.FlatStyle = FlatStyle.Flat;
            buttonplus.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonplus.ForeColor = SystemColors.ButtonFace;
            buttonplus.Location = new Point(275, 257);
            buttonplus.Name = "buttonplus";
            buttonplus.Size = new Size(74, 44);
            buttonplus.TabIndex = 0;
            buttonplus.Text = "+";
            buttonplus.UseVisualStyleBackColor = false;
            buttonplus.Click += buttonplus_Click;
            // 
            // buttonminus
            // 
            buttonminus.BackColor = Color.DimGray;
            buttonminus.FlatAppearance.BorderSize = 0;
            buttonminus.FlatStyle = FlatStyle.Flat;
            buttonminus.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonminus.ForeColor = SystemColors.ButtonFace;
            buttonminus.Location = new Point(275, 207);
            buttonminus.Name = "buttonminus";
            buttonminus.Size = new Size(74, 44);
            buttonminus.TabIndex = 1;
            buttonminus.Text = "-";
            buttonminus.UseVisualStyleBackColor = false;
            buttonminus.Click += buttonminus_Click;
            // 
            // buttonkali
            // 
            buttonkali.BackColor = Color.DimGray;
            buttonkali.FlatAppearance.BorderSize = 0;
            buttonkali.FlatStyle = FlatStyle.Flat;
            buttonkali.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonkali.ForeColor = SystemColors.ButtonFace;
            buttonkali.Location = new Point(275, 157);
            buttonkali.Name = "buttonkali";
            buttonkali.Size = new Size(74, 44);
            buttonkali.TabIndex = 2;
            buttonkali.Text = "×";
            buttonkali.UseVisualStyleBackColor = false;
            buttonkali.Click += buttonkali_Click;
            // 
            // buttonbagi
            // 
            buttonbagi.BackColor = Color.DimGray;
            buttonbagi.FlatAppearance.BorderSize = 0;
            buttonbagi.FlatStyle = FlatStyle.Flat;
            buttonbagi.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonbagi.ForeColor = SystemColors.ButtonFace;
            buttonbagi.Location = new Point(275, 107);
            buttonbagi.Name = "buttonbagi";
            buttonbagi.Size = new Size(74, 44);
            buttonbagi.TabIndex = 3;
            buttonbagi.Text = "÷";
            buttonbagi.UseVisualStyleBackColor = false;
            buttonbagi.Click += buttonbagi_Click;
            // 
            // buttonhasil
            // 
            buttonhasil.BackColor = Color.DodgerBlue;
            buttonhasil.FlatAppearance.BorderSize = 0;
            buttonhasil.FlatStyle = FlatStyle.Flat;
            buttonhasil.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonhasil.ForeColor = SystemColors.ButtonFace;
            buttonhasil.Location = new Point(275, 307);
            buttonhasil.Name = "buttonhasil";
            buttonhasil.Size = new Size(74, 44);
            buttonhasil.TabIndex = 4;
            buttonhasil.Text = "=";
            buttonhasil.UseVisualStyleBackColor = false;
            buttonhasil.Click += buttonhasil_Click;
            // 
            // button0
            // 
            button0.BackColor = Color.DimGray;
            button0.FlatAppearance.BorderSize = 0;
            button0.FlatStyle = FlatStyle.Flat;
            button0.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button0.ForeColor = SystemColors.ButtonFace;
            button0.Location = new Point(115, 307);
            button0.Name = "button0";
            button0.Size = new Size(74, 44);
            button0.TabIndex = 5;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = false;
            button0.Click += button0_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(35, 257);
            button1.Name = "button1";
            button1.Size = new Size(74, 44);
            button1.TabIndex = 6;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textboxhasil
            // 
            textboxhasil.BackColor = Color.Black;
            textboxhasil.BorderStyle = BorderStyle.None;
            textboxhasil.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textboxhasil.ForeColor = Color.White;
            textboxhasil.Location = new Point(35, 15);
            textboxhasil.Name = "textboxhasil";
            textboxhasil.ReadOnly = true;
            textboxhasil.RightToLeft = RightToLeft.No;
            textboxhasil.Size = new Size(314, 86);
            textboxhasil.TabIndex = 7;
            textboxhasil.Text = "0";
            textboxhasil.TextAlign = HorizontalAlignment.Right;
            // 
            // button2
            // 
            button2.BackColor = Color.DimGray;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(115, 257);
            button2.Name = "button2";
            button2.Size = new Size(74, 44);
            button2.TabIndex = 8;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DimGray;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(195, 257);
            button3.Name = "button3";
            button3.Size = new Size(74, 44);
            button3.TabIndex = 9;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // buttontitik
            // 
            buttontitik.BackColor = Color.DimGray;
            buttontitik.FlatAppearance.BorderSize = 0;
            buttontitik.FlatStyle = FlatStyle.Flat;
            buttontitik.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttontitik.ForeColor = SystemColors.ButtonFace;
            buttontitik.Location = new Point(195, 307);
            buttontitik.Name = "buttontitik";
            buttontitik.Size = new Size(74, 44);
            buttontitik.TabIndex = 16;
            buttontitik.Text = ".";
            buttontitik.UseVisualStyleBackColor = false;
            buttontitik.Click += buttontitik_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DimGray;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(35, 207);
            button4.Name = "button4";
            button4.Size = new Size(74, 44);
            button4.TabIndex = 17;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.DimGray;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ButtonFace;
            button5.Location = new Point(115, 207);
            button5.Name = "button5";
            button5.Size = new Size(74, 44);
            button5.TabIndex = 18;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.DimGray;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.ButtonFace;
            button6.Location = new Point(195, 207);
            button6.Name = "button6";
            button6.Size = new Size(74, 44);
            button6.TabIndex = 19;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.DimGray;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = SystemColors.ButtonFace;
            button7.Location = new Point(35, 157);
            button7.Name = "button7";
            button7.Size = new Size(74, 44);
            button7.TabIndex = 20;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.DimGray;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = SystemColors.ButtonFace;
            button8.Location = new Point(115, 157);
            button8.Name = "button8";
            button8.Size = new Size(74, 44);
            button8.TabIndex = 21;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.DimGray;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.ForeColor = SystemColors.ButtonFace;
            button9.Location = new Point(195, 157);
            button9.Name = "button9";
            button9.Size = new Size(74, 44);
            button9.TabIndex = 22;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // buttonplusminus
            // 
            buttonplusminus.BackColor = Color.DimGray;
            buttonplusminus.FlatAppearance.BorderSize = 0;
            buttonplusminus.FlatStyle = FlatStyle.Flat;
            buttonplusminus.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonplusminus.ForeColor = SystemColors.ButtonFace;
            buttonplusminus.Location = new Point(35, 307);
            buttonplusminus.Name = "buttonplusminus";
            buttonplusminus.RightToLeft = RightToLeft.No;
            buttonplusminus.Size = new Size(74, 44);
            buttonplusminus.TabIndex = 23;
            buttonplusminus.Text = "+/-";
            buttonplusminus.UseVisualStyleBackColor = false;
            buttonplusminus.Click += buttonplusminus_Click;
            // 
            // buttondelete
            // 
            buttondelete.BackColor = Color.DimGray;
            buttondelete.FlatAppearance.BorderSize = 0;
            buttondelete.FlatStyle = FlatStyle.Flat;
            buttondelete.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttondelete.ForeColor = SystemColors.ButtonFace;
            buttondelete.Location = new Point(195, 107);
            buttondelete.Name = "buttondelete";
            buttondelete.Size = new Size(74, 44);
            buttondelete.TabIndex = 24;
            buttondelete.Text = "DEL";
            buttondelete.UseVisualStyleBackColor = false;
            buttondelete.Click += buttondelete_Click;
            // 
            // buttondeleteall
            // 
            buttondeleteall.BackColor = Color.DimGray;
            buttondeleteall.FlatAppearance.BorderSize = 0;
            buttondeleteall.FlatStyle = FlatStyle.Flat;
            buttondeleteall.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttondeleteall.ForeColor = SystemColors.ButtonFace;
            buttondeleteall.Location = new Point(115, 107);
            buttondeleteall.Name = "buttondeleteall";
            buttondeleteall.Size = new Size(74, 44);
            buttondeleteall.TabIndex = 25;
            buttondeleteall.Text = "C";
            buttondeleteall.UseVisualStyleBackColor = false;
            buttondeleteall.Click += buttondeleteall_Click;
            // 
            // buttononoff
            // 
            buttononoff.BackColor = Color.DimGray;
            buttononoff.FlatAppearance.BorderSize = 0;
            buttononoff.FlatStyle = FlatStyle.Flat;
            buttononoff.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttononoff.ForeColor = SystemColors.ButtonFace;
            buttononoff.Location = new Point(35, 107);
            buttononoff.Name = "buttononoff";
            buttononoff.Size = new Size(74, 44);
            buttononoff.TabIndex = 26;
            buttononoff.Text = "ON/OFF";
            buttononoff.UseVisualStyleBackColor = false;
            buttononoff.Click += buttononoff_Click;
            // 
            // Kalkulator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(382, 379);
            Controls.Add(buttononoff);
            Controls.Add(buttondeleteall);
            Controls.Add(buttondelete);
            Controls.Add(buttonplusminus);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(buttontitik);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textboxhasil);
            Controls.Add(button1);
            Controls.Add(button0);
            Controls.Add(buttonhasil);
            Controls.Add(buttonbagi);
            Controls.Add(buttonkali);
            Controls.Add(buttonminus);
            Controls.Add(buttonplus);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Kalkulator";
            Text = "Kalkulator";
            Load += Kalkulator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonplus;
        private Button buttonminus;
        private Button buttonkali;
        private Button buttonbagi;
        private Button buttonhasil;
        private Button button0;
        private Button button1;
        private TextBox textboxhasil;
        private Button button2;
        private Button button3;
        private Button buttontitik;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button buttonplusminus;
        private Button buttondelete;
        private Button buttondeleteall;
        private Button buttononoff;
    }
}
