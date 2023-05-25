namespace Lab7;

partial class Form1 {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        lblOpenKey = new Label();
        label3 = new Label();
        txtResult = new TextBox();
        label2 = new Label();
        btnDecrypt = new Button();
        label4 = new Label();
        label5 = new Label();
        label6 = new Label();
        label7 = new Label();
        textP = new TextBox();
        textG = new TextBox();
        textY = new TextBox();
        textOck = new TextBox();
        textW = new TextBox();
        label1 = new Label();
        SuspendLayout();
        // 
        // lblOpenKey
        // 
        lblOpenKey.AutoSize = true;
        lblOpenKey.Location = new Point(152, 57);
        lblOpenKey.Name = "lblOpenKey";
        lblOpenKey.Size = new Size(0, 20);
        lblOpenKey.TabIndex = 17;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(30, 14);
        label3.Name = "label3";
        label3.Size = new Size(36, 20);
        label3.TabIndex = 16;
        label3.Text = "p = ";
        // 
        // txtResult
        // 
        txtResult.Location = new Point(12, 259);
        txtResult.Multiline = true;
        txtResult.Name = "txtResult";
        txtResult.ReadOnly = true;
        txtResult.Size = new Size(633, 145);
        txtResult.TabIndex = 15;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(12, 236);
        label2.Name = "label2";
        label2.Size = new Size(82, 20);
        label2.TabIndex = 14;
        label2.Text = "Результат: ";
        // 
        // btnDecrypt
        // 
        btnDecrypt.Location = new Point(12, 178);
        btnDecrypt.Name = "btnDecrypt";
        btnDecrypt.Size = new Size(637, 45);
        btnDecrypt.TabIndex = 12;
        btnDecrypt.Text = "Расшифровать";
        btnDecrypt.UseVisualStyleBackColor = true;
        btnDecrypt.Click += BtnDecrypt_Click;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(30, 47);
        label4.Name = "label4";
        label4.Size = new Size(36, 20);
        label4.TabIndex = 18;
        label4.Text = "g = ";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(29, 80);
        label5.Name = "label5";
        label5.Size = new Size(34, 20);
        label5.TabIndex = 19;
        label5.Text = "y = ";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(369, 110);
        label6.Name = "label6";
        label6.Size = new Size(52, 20);
        label6.TabIndex = 20;
        label6.Text = "Ock = ";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(14, 115);
        label7.Name = "label7";
        label7.Size = new Size(52, 20);
        label7.TabIndex = 21;
        label7.Text = "Ock = ";
        // 
        // textP
        // 
        textP.Location = new Point(69, 11);
        textP.Name = "textP";
        textP.Size = new Size(580, 27);
        textP.TabIndex = 22;
        textP.Text = "401132107";
        // 
        // textG
        // 
        textG.Location = new Point(69, 44);
        textG.Name = "textG";
        textG.Size = new Size(580, 27);
        textG.TabIndex = 23;
        textG.Text = "5";
        // 
        // textY
        // 
        textY.Location = new Point(69, 77);
        textY.Name = "textY";
        textY.Size = new Size(580, 27);
        textY.TabIndex = 24;
        textY.Text = "349975032";
        // 
        // textOck
        // 
        textOck.Location = new Point(69, 112);
        textOck.Name = "textOck";
        textOck.Size = new Size(580, 27);
        textOck.TabIndex = 25;
        textOck.Text = "262582374";
        // 
        // textW
        // 
        textW.Location = new Point(69, 145);
        textW.Name = "textW";
        textW.Size = new Size(580, 27);
        textW.TabIndex = 26;
        textW.Text = "17960572";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(25, 148);
        label1.Name = "label1";
        label1.Size = new Size(38, 20);
        label1.TabIndex = 27;
        label1.Text = "w = ";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(666, 427);
        Controls.Add(label1);
        Controls.Add(textW);
        Controls.Add(textOck);
        Controls.Add(textY);
        Controls.Add(textG);
        Controls.Add(textP);
        Controls.Add(label7);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(lblOpenKey);
        Controls.Add(label3);
        Controls.Add(txtResult);
        Controls.Add(label2);
        Controls.Add(btnDecrypt);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblOpenKey;
    private Label label3;
    private TextBox txtResult;
    private Label label2;
    private Button btnDecrypt;
    private Label label4;
    private Label label5;
    private Label label6;
    private Label label7;
    private TextBox textP;
    private TextBox textG;
    private TextBox textY;
    private TextBox textOck;
    private TextBox textW;
    private Label label1;
}