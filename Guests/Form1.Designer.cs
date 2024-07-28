namespace Guests
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
            EnterGuestNameTextBox = new TextBox();
            GuestsListBox = new ListBox();
            EnterGuestButton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(309, 31);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 0;
            label1.Text = "Welcome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(287, 78);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 0;
            label2.Text = "Enter Guest Name";
            // 
            // EnterGuestNameTextBox
            // 
            EnterGuestNameTextBox.Location = new Point(292, 124);
            EnterGuestNameTextBox.Name = "EnterGuestNameTextBox";
            EnterGuestNameTextBox.Size = new Size(125, 27);
            EnterGuestNameTextBox.TabIndex = 1;
            EnterGuestNameTextBox.Click += GuestsListBox_SelectedIndexChanged;
            EnterGuestNameTextBox.TextChanged += OnGuestTextBoxChange;
            // 
            // GuestsListBox
            // 
            GuestsListBox.FormattingEnabled = true;
            GuestsListBox.Location = new Point(287, 176);
            GuestsListBox.Name = "GuestsListBox";
            GuestsListBox.Size = new Size(171, 164);
            GuestsListBox.TabIndex = 2;
            GuestsListBox.SelectedIndexChanged += GuestsListBox_SelectedIndexChanged;
            // 
            // EnterGuestButton
            // 
            EnterGuestButton.Location = new Point(442, 117);
            EnterGuestButton.Name = "EnterGuestButton";
            EnterGuestButton.Size = new Size(110, 34);
            EnterGuestButton.TabIndex = 3;
            EnterGuestButton.Text = "Add Guest";
            EnterGuestButton.UseVisualStyleBackColor = true;
            EnterGuestButton.Click += OnAddClick;
            // 
            // button1
            // 
            button1.Location = new Point(309, 360);
            button1.Name = "button1";
            button1.Size = new Size(95, 51);
            button1.TabIndex = 4;
            button1.Text = "ok";
            button1.UseVisualStyleBackColor = true;
            button1.Click += OnApproveClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(EnterGuestButton);
            Controls.Add(GuestsListBox);
            Controls.Add(EnterGuestNameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox EnterGuestNameTextBox;
        private ListBox GuestsListBox;
        private Button EnterGuestButton;
        private Button button1;
    }
}
