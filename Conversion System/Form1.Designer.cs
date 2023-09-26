namespace Conversion_System
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
            components = new System.ComponentModel.Container();
            bindingSource1 = new BindingSource(components);
            lblBinary = new TextBox();
            txtConverter = new TextBox();
            hex_btn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblDecimal = new TextBox();
            label5 = new Label();
            lblHex = new TextBox();
            btnClear = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // lblBinary
            // 
            lblBinary.Cursor = Cursors.No;
            lblBinary.HideSelection = false;
            lblBinary.Location = new Point(147, 209);
            lblBinary.Name = "lblBinary";
            lblBinary.ReadOnly = true;
            lblBinary.Size = new Size(127, 23);
            lblBinary.TabIndex = 1;
            lblBinary.TextChanged += num2_TextChanged;
            // 
            // txtConverter
            // 
            txtConverter.Cursor = Cursors.IBeam;
            txtConverter.Location = new Point(347, 114);
            txtConverter.Name = "txtConverter";
            txtConverter.Size = new Size(255, 23);
            txtConverter.TabIndex = 2;
            txtConverter.TextChanged += txtConverter_TextChanged;
            // 
            // hex_btn
            // 
            hex_btn.Cursor = Cursors.Hand;
            hex_btn.Location = new Point(147, 281);
            hex_btn.Name = "hex_btn";
            hex_btn.Size = new Size(127, 43);
            hex_btn.TabIndex = 3;
            hex_btn.Text = "Convert";
            hex_btn.UseVisualStyleBackColor = true;
            hex_btn.Click += hex_btn_Click_1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(147, 20);
            label1.Name = "label1";
            label1.Size = new Size(455, 65);
            label1.TabIndex = 5;
            label1.Text = "Conversion System";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(147, 107);
            label2.Name = "label2";
            label2.Size = new Size(160, 30);
            label2.TabIndex = 6;
            label2.Text = "Enter a Number";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(147, 176);
            label3.Name = "label3";
            label3.Size = new Size(70, 30);
            label3.TabIndex = 7;
            label3.Text = "Binary";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(310, 176);
            label4.Name = "label4";
            label4.Size = new Size(88, 30);
            label4.TabIndex = 9;
            label4.Text = "Decimal";
            label4.Click += label4_Click;
            // 
            // lblDecimal
            // 
            lblDecimal.Cursor = Cursors.No;
            lblDecimal.HideSelection = false;
            lblDecimal.Location = new Point(310, 209);
            lblDecimal.Name = "lblDecimal";
            lblDecimal.ReadOnly = true;
            lblDecimal.Size = new Size(127, 23);
            lblDecimal.TabIndex = 8;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(475, 176);
            label5.Name = "label5";
            label5.Size = new Size(132, 30);
            label5.TabIndex = 11;
            label5.Text = "Hexadecimal";
            // 
            // lblHex
            // 
            lblHex.Cursor = Cursors.No;
            lblHex.HideSelection = false;
            lblHex.Location = new Point(475, 209);
            lblHex.Name = "lblHex";
            lblHex.ReadOnly = true;
            lblHex.Size = new Size(127, 23);
            lblHex.TabIndex = 10;
            // 
            // btnClear
            // 
            btnClear.Cursor = Cursors.Hand;
            btnClear.Location = new Point(310, 281);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(127, 43);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += button1_Click;
            // 
            // btnExit
            // 
            btnExit.Cursor = Cursors.Hand;
            btnExit.Location = new Point(475, 281);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(127, 43);
            btnExit.TabIndex = 13;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 561);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(label5);
            Controls.Add(lblHex);
            Controls.Add(label4);
            Controls.Add(lblDecimal);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(hex_btn);
            Controls.Add(txtConverter);
            Controls.Add(lblBinary);
            Name = "Form1";
            Text = "Conversion System";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox lblDecimal;
        private BindingSource bindingSource1;
        private TextBox lblBinary;
        private TextBox txtConverter;
        private Button hex_btn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox lblHex;
        private Button btnClear;
        private Button btnExit;
    }
}