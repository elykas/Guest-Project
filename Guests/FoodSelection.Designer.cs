namespace Guests
{
    partial class FoodSelection
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
            FoodItemGridView = new DataGridView();
            ListFoodGridView = new DataGridView();
            GuestNameLabel = new Label();
            CategoryLabel = new Label();
            PreviousButton = new Button();
            NextNutton = new Button();
            AddFoodItemButton = new Button();
            AddFoodItemTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)FoodItemGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ListFoodGridView).BeginInit();
            SuspendLayout();
            // 
            // FoodItemGridView
            // 
            FoodItemGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FoodItemGridView.Location = new Point(211, 72);
            FoodItemGridView.Name = "FoodItemGridView";
            FoodItemGridView.RowHeadersWidth = 51;
            FoodItemGridView.Size = new Size(282, 124);
            FoodItemGridView.TabIndex = 0;
            // 
            // ListFoodGridView
            // 
            ListFoodGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListFoodGridView.Location = new Point(211, 251);
            ListFoodGridView.Name = "ListFoodGridView";
            ListFoodGridView.RowHeadersWidth = 51;
            ListFoodGridView.Size = new Size(282, 147);
            ListFoodGridView.TabIndex = 0;
            // 
            // GuestNameLabel
            // 
            GuestNameLabel.AutoSize = true;
            GuestNameLabel.Location = new Point(394, 24);
            GuestNameLabel.Name = "GuestNameLabel";
            GuestNameLabel.Size = new Size(50, 20);
            GuestNameLabel.TabIndex = 1;
            GuestNameLabel.Text = "label1";
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(226, 24);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(50, 20);
            CategoryLabel.TabIndex = 2;
            CategoryLabel.Text = "label2";
            // 
            // PreviousButton
            // 
            PreviousButton.Location = new Point(376, 415);
            PreviousButton.Name = "PreviousButton";
            PreviousButton.Size = new Size(79, 35);
            PreviousButton.TabIndex = 3;
            PreviousButton.Text = ">>";
            PreviousButton.UseVisualStyleBackColor = true;
            PreviousButton.Click += PreviousCategory_Button;
            // 
            // NextNutton
            // 
            NextNutton.Location = new Point(280, 414);
            NextNutton.Name = "NextNutton";
            NextNutton.Size = new Size(79, 35);
            NextNutton.TabIndex = 3;
            NextNutton.Text = "<<";
            NextNutton.UseVisualStyleBackColor = true;
            NextNutton.Click += NextCategory_Button;
            // 
            // AddFoodItemButton
            // 
            AddFoodItemButton.Location = new Point(376, 202);
            AddFoodItemButton.Name = "AddFoodItemButton";
            AddFoodItemButton.Size = new Size(79, 35);
            AddFoodItemButton.TabIndex = 5;
            AddFoodItemButton.Text = "enter";
            AddFoodItemButton.UseVisualStyleBackColor = true;
            AddFoodItemButton.Click += AddFoodItemButton_Click;
            // 
            // AddFoodItemTextBox
            // 
            AddFoodItemTextBox.Location = new Point(226, 206);
            AddFoodItemTextBox.Name = "AddFoodItemTextBox";
            AddFoodItemTextBox.Size = new Size(133, 27);
            AddFoodItemTextBox.TabIndex = 6;
            // 
            // FoodSelection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 480);
            Controls.Add(AddFoodItemTextBox);
            Controls.Add(AddFoodItemButton);
            Controls.Add(NextNutton);
            Controls.Add(PreviousButton);
            Controls.Add(CategoryLabel);
            Controls.Add(GuestNameLabel);
            Controls.Add(ListFoodGridView);
            Controls.Add(FoodItemGridView);
            Name = "FoodSelection";
            Text = "FoodSelection";
            ((System.ComponentModel.ISupportInitialize)FoodItemGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)ListFoodGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView FoodItemGridView;
        private DataGridView ListFoodGridView;
        private Label GuestNameLabel;
        private Label CategoryLabel;
        private Button PreviousButton;
        private Button NextNutton;
        private Button addButton;
        private Button button4;
        private Button AddFoodItemButton;
        private TextBox AddFoodItemTextBox;
    }
}