namespace Shopper
{
    partial class Form2
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
            NosaukumsFld = new TextBox();
            CenaNum = new NumericUpDown();
            PievienotBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)CenaNum).BeginInit();
            SuspendLayout();
            // 
            // NosaukumsFld
            // 
            NosaukumsFld.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            NosaukumsFld.Location = new Point(145, 12);
            NosaukumsFld.Name = "NosaukumsFld";
            NosaukumsFld.Size = new Size(337, 31);
            NosaukumsFld.TabIndex = 0;
            // 
            // CenaNum
            // 
            CenaNum.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            CenaNum.DecimalPlaces = 2;
            CenaNum.Location = new Point(145, 49);
            CenaNum.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            CenaNum.Name = "CenaNum";
            CenaNum.Size = new Size(337, 31);
            CenaNum.TabIndex = 1;
            CenaNum.ThousandsSeparator = true;
            // 
            // PievienotBtn
            // 
            PievienotBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PievienotBtn.Location = new Point(12, 86);
            PievienotBtn.Name = "PievienotBtn";
            PievienotBtn.Size = new Size(470, 34);
            PievienotBtn.TabIndex = 2;
            PievienotBtn.Text = "Pievienot";
            PievienotBtn.UseVisualStyleBackColor = true;
            PievienotBtn.Click += PievienotBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 3;
            label1.Text = "Nosaukums";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 51);
            label2.Name = "label2";
            label2.Size = new Size(51, 25);
            label2.TabIndex = 4;
            label2.Text = "Cena";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 133);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PievienotBtn);
            Controls.Add(CenaNum);
            Controls.Add(NosaukumsFld);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            Text = "Pievienot...";
            FormClosing += Form2_FormClosing;
            ((System.ComponentModel.ISupportInitialize)CenaNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NosaukumsFld;
        private NumericUpDown CenaNum;
        private Button PievienotBtn;
        private Label label1;
        private Label label2;
    }
}