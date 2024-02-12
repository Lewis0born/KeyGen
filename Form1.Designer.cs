namespace KeyGen
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
            userIDBox = new TextBox();
            keyGen = new TextBox();
            generateKey = new Button();
            enterUser = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // userIDBox
            // 
            userIDBox.Location = new Point(356, 89);
            userIDBox.Name = "userIDBox";
            userIDBox.Size = new Size(87, 23);
            userIDBox.TabIndex = 0;
            // 
            // keyGen
            // 
            keyGen.Location = new Point(196, 324);
            keyGen.Name = "keyGen";
            keyGen.Size = new Size(397, 23);
            keyGen.TabIndex = 1;
            // 
            // generateKey
            // 
            generateKey.Location = new Point(328, 265);
            generateKey.Name = "generateKey";
            generateKey.Size = new Size(147, 23);
            generateKey.TabIndex = 2;
            generateKey.Text = "button1";
            generateKey.UseVisualStyleBackColor = true;
            // 
            // enterUser
            // 
            enterUser.AutoSize = true;
            enterUser.Location = new Point(385, 56);
            enterUser.Name = "enterUser";
            enterUser.Size = new Size(38, 15);
            enterUser.TabIndex = 3;
            enterUser.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(368, 267);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(enterUser);
            Controls.Add(keyGen);
            Controls.Add(userIDBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userIDBox;
        private TextBox keyGen;
        private Button generateKey;
        private Label enterUser;
        private Button button1;
    }
}
