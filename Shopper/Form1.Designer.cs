namespace Shopper
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
            Summa = new Label();
            AddButton = new Button();
            SaveButton = new Button();
            LoadButton = new Button();
            ProductList = new ListBox();
            RemoveButton = new Button();
            SuspendLayout();
            // 
            // Summa
            // 
            Summa.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Summa.AutoSize = true;
            Summa.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Summa.Location = new Point(737, 414);
            Summa.Name = "Summa";
            Summa.Padding = new Padding(20);
            Summa.Size = new Size(240, 78);
            Summa.TabIndex = 1;
            Summa.Text = "Summa: 0 Eur";
            Summa.TextAlign = ContentAlignment.MiddleRight;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddButton.Location = new Point(12, 409);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(148, 97);
            AddButton.TabIndex = 2;
            AddButton.Text = "Pievienot";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SaveButton.Location = new Point(352, 409);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(148, 97);
            SaveButton.TabIndex = 3;
            SaveButton.Text = "Saglabāt";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // LoadButton
            // 
            LoadButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LoadButton.Location = new Point(522, 409);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(148, 97);
            LoadButton.TabIndex = 4;
            LoadButton.Text = "Atvērt";
            LoadButton.UseVisualStyleBackColor = true;
            LoadButton.Click += LoadButton_Click;
            // 
            // ProductList
            // 
            ProductList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ProductList.FormattingEnabled = true;
            ProductList.ItemHeight = 25;
            ProductList.Location = new Point(12, 12);
            ProductList.Name = "ProductList";
            ProductList.Size = new Size(965, 379);
            ProductList.TabIndex = 5;
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RemoveButton.Location = new Point(182, 409);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(148, 97);
            RemoveButton.TabIndex = 6;
            RemoveButton.Text = "Dzēst";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 220, 255);
            ClientSize = new Size(989, 518);
            Controls.Add(RemoveButton);
            Controls.Add(ProductList);
            Controls.Add(LoadButton);
            Controls.Add(SaveButton);
            Controls.Add(AddButton);
            Controls.Add(Summa);
            Name = "Form1";
            Text = "Pirkumu grozs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Summa;
        private Button AddButton;
        private Button SaveButton;
        private Button LoadButton;
        private ListBox ProductList;
        private Button RemoveButton;
    }
}