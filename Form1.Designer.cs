namespace PizzaApplication
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
            gbPizzaType = new GroupBox();
            rbHaC = new RadioButton();
            rbHawaian = new RadioButton();
            gbSize = new GroupBox();
            rbLarge = new RadioButton();
            rbMedium = new RadioButton();
            rbSmall = new RadioButton();
            gbCrust = new GroupBox();
            rbThick = new RadioButton();
            rbThin = new RadioButton();
            gpToppings = new GroupBox();
            cbPineapple = new CheckBox();
            cbTomatoe = new CheckBox();
            cbOnion = new CheckBox();
            cbMushroom = new CheckBox();
            cbCheese = new CheckBox();
            btnPO = new Button();
            btnNO = new Button();
            rtxtReceipt = new RichTextBox();
            gbPizzaType.SuspendLayout();
            gbSize.SuspendLayout();
            gbCrust.SuspendLayout();
            gpToppings.SuspendLayout();
            SuspendLayout();
            // 
            // gbPizzaType
            // 
            gbPizzaType.Controls.Add(rbHaC);
            gbPizzaType.Controls.Add(rbHawaian);
            gbPizzaType.Location = new Point(12, 12);
            gbPizzaType.Name = "gbPizzaType";
            gbPizzaType.Size = new Size(381, 83);
            gbPizzaType.TabIndex = 0;
            gbPizzaType.TabStop = false;
            gbPizzaType.Text = "Pizza:";
            // 
            // rbHaC
            // 
            rbHaC.AutoSize = true;
            rbHaC.Location = new Point(226, 32);
            rbHaC.Name = "rbHaC";
            rbHaC.Size = new Size(115, 19);
            rbHaC.TabIndex = 1;
            rbHaC.TabStop = true;
            rbHaC.Text = "Ham and Cheese";
            rbHaC.UseVisualStyleBackColor = true;
            // 
            // rbHawaian
            // 
            rbHawaian.AutoSize = true;
            rbHawaian.Location = new Point(73, 32);
            rbHawaian.Name = "rbHawaian";
            rbHawaian.Size = new Size(74, 19);
            rbHawaian.TabIndex = 0;
            rbHawaian.TabStop = true;
            rbHawaian.Text = "Hawaiian";
            rbHawaian.UseVisualStyleBackColor = true;
            // 
            // gbSize
            // 
            gbSize.Controls.Add(rbLarge);
            gbSize.Controls.Add(rbMedium);
            gbSize.Controls.Add(rbSmall);
            gbSize.Location = new Point(12, 101);
            gbSize.Name = "gbSize";
            gbSize.Size = new Size(381, 85);
            gbSize.TabIndex = 1;
            gbSize.TabStop = false;
            gbSize.Text = "Size:";
            // 
            // rbLarge
            // 
            rbLarge.AutoSize = true;
            rbLarge.Location = new Point(292, 33);
            rbLarge.Name = "rbLarge";
            rbLarge.Size = new Size(54, 19);
            rbLarge.TabIndex = 2;
            rbLarge.TabStop = true;
            rbLarge.Text = "Large";
            rbLarge.UseVisualStyleBackColor = true;
            // 
            // rbMedium
            // 
            rbMedium.AutoSize = true;
            rbMedium.Location = new Point(147, 33);
            rbMedium.Name = "rbMedium";
            rbMedium.Size = new Size(70, 19);
            rbMedium.TabIndex = 1;
            rbMedium.TabStop = true;
            rbMedium.Text = "Medium";
            rbMedium.UseVisualStyleBackColor = true;
            // 
            // rbSmall
            // 
            rbSmall.AutoSize = true;
            rbSmall.Location = new Point(25, 33);
            rbSmall.Name = "rbSmall";
            rbSmall.Size = new Size(54, 19);
            rbSmall.TabIndex = 0;
            rbSmall.TabStop = true;
            rbSmall.Text = "Small";
            rbSmall.UseVisualStyleBackColor = true;
            // 
            // gbCrust
            // 
            gbCrust.Controls.Add(rbThick);
            gbCrust.Controls.Add(rbThin);
            gbCrust.Location = new Point(12, 192);
            gbCrust.Name = "gbCrust";
            gbCrust.Size = new Size(381, 79);
            gbCrust.TabIndex = 2;
            gbCrust.TabStop = false;
            gbCrust.Text = "Crust Type:";
            // 
            // rbThick
            // 
            rbThick.AutoSize = true;
            rbThick.Location = new Point(226, 31);
            rbThick.Name = "rbThick";
            rbThick.Size = new Size(53, 19);
            rbThick.TabIndex = 1;
            rbThick.TabStop = true;
            rbThick.Text = "Thick";
            rbThick.UseVisualStyleBackColor = true;
            // 
            // rbThin
            // 
            rbThin.AutoSize = true;
            rbThin.Location = new Point(73, 31);
            rbThin.Name = "rbThin";
            rbThin.Size = new Size(48, 19);
            rbThin.TabIndex = 0;
            rbThin.TabStop = true;
            rbThin.Text = "Thin";
            rbThin.UseVisualStyleBackColor = true;
            // 
            // gpToppings
            // 
            gpToppings.Controls.Add(cbPineapple);
            gpToppings.Controls.Add(cbTomatoe);
            gpToppings.Controls.Add(cbOnion);
            gpToppings.Controls.Add(cbMushroom);
            gpToppings.Controls.Add(cbCheese);
            gpToppings.Location = new Point(12, 277);
            gpToppings.Name = "gpToppings";
            gpToppings.Size = new Size(381, 107);
            gpToppings.TabIndex = 3;
            gpToppings.TabStop = false;
            gpToppings.Text = "Extra Toppings:";
            // 
            // cbPineapple
            // 
            cbPineapple.AutoSize = true;
            cbPineapple.Location = new Point(226, 69);
            cbPineapple.Name = "cbPineapple";
            cbPineapple.Size = new Size(83, 19);
            cbPineapple.TabIndex = 4;
            cbPineapple.Text = "Pineapples";
            cbPineapple.UseVisualStyleBackColor = true;
            // 
            // cbTomatoe
            // 
            cbTomatoe.AutoSize = true;
            cbTomatoe.Location = new Point(73, 69);
            cbTomatoe.Name = "cbTomatoe";
            cbTomatoe.Size = new Size(77, 19);
            cbTomatoe.TabIndex = 3;
            cbTomatoe.Text = "Tomatoes";
            cbTomatoe.UseVisualStyleBackColor = true;
            // 
            // cbOnion
            // 
            cbOnion.AutoSize = true;
            cbOnion.Location = new Point(292, 32);
            cbOnion.Name = "cbOnion";
            cbOnion.Size = new Size(64, 19);
            cbOnion.TabIndex = 2;
            cbOnion.Text = "Onions";
            cbOnion.UseVisualStyleBackColor = true;
            // 
            // cbMushroom
            // 
            cbMushroom.AutoSize = true;
            cbMushroom.Location = new Point(147, 32);
            cbMushroom.Name = "cbMushroom";
            cbMushroom.Size = new Size(90, 19);
            cbMushroom.TabIndex = 1;
            cbMushroom.Text = "Mushrooms";
            cbMushroom.UseVisualStyleBackColor = true;
            // 
            // cbCheese
            // 
            cbCheese.AutoSize = true;
            cbCheese.Location = new Point(25, 32);
            cbCheese.Name = "cbCheese";
            cbCheese.Size = new Size(93, 19);
            cbCheese.TabIndex = 0;
            cbCheese.Text = "Extra Cheese";
            cbCheese.UseVisualStyleBackColor = true;
            // 
            // btnPO
            // 
            btnPO.Location = new Point(85, 390);
            btnPO.Name = "btnPO";
            btnPO.Size = new Size(96, 35);
            btnPO.TabIndex = 4;
            btnPO.Text = "Process Order";
            btnPO.UseVisualStyleBackColor = true;
            btnPO.Click += btnPO_Click;
            // 
            // btnNO
            // 
            btnNO.Location = new Point(238, 390);
            btnNO.Name = "btnNO";
            btnNO.Size = new Size(95, 35);
            btnNO.TabIndex = 5;
            btnNO.Text = "New Order";
            btnNO.UseVisualStyleBackColor = true;
            btnNO.Click += btnNO_Click;
            // 
            // rtxtReceipt
            // 
            rtxtReceipt.Location = new Point(12, 431);
            rtxtReceipt.Name = "rtxtReceipt";
            rtxtReceipt.Size = new Size(381, 173);
            rtxtReceipt.TabIndex = 6;
            rtxtReceipt.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 616);
            Controls.Add(rtxtReceipt);
            Controls.Add(btnNO);
            Controls.Add(btnPO);
            Controls.Add(gpToppings);
            Controls.Add(gbCrust);
            Controls.Add(gbSize);
            Controls.Add(gbPizzaType);
            Name = "Form1";
            Text = "Pizza App";
            gbPizzaType.ResumeLayout(false);
            gbPizzaType.PerformLayout();
            gbSize.ResumeLayout(false);
            gbSize.PerformLayout();
            gbCrust.ResumeLayout(false);
            gbCrust.PerformLayout();
            gpToppings.ResumeLayout(false);
            gpToppings.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbPizzaType;
        private RadioButton rbHaC;
        private RadioButton rbHawaian;
        private GroupBox gbSize;
        private RadioButton rbLarge;
        private RadioButton rbMedium;
        private RadioButton rbSmall;
        private GroupBox gbCrust;
        private RadioButton rbThin;
        private RadioButton rbThick;
        private GroupBox gpToppings;
        private CheckBox cbPineapple;
        private CheckBox cbTomatoe;
        private CheckBox cbOnion;
        private CheckBox cbMushroom;
        private CheckBox cbCheese;
        private Button btnPO;
        private Button btnNO;
        private RichTextBox rtxtReceipt;
    }
}