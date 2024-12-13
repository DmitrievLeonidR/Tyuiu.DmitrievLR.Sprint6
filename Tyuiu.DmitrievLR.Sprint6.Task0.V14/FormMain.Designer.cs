namespace Tyuiu.DmitrievLR.Sprint6.Task0.V14;
            
partial class FormMain
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
        label1 = new Label();
        ButnCLickResult = new Button();
        InputTexBox = new TextBox();
        label2 = new Label();
        contextMenuStrip1 = new ContextMenuStrip(components);
        pictureBox1 = new PictureBox();
        groupBox1 = new GroupBox();
        LabelUsl = new Label();
        groupBox2 = new GroupBox();
        ResultGBox = new GroupBox();
        TextBoxResult = new TextBox();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        ResultGBox.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(12, 9);
        label1.Name = "label1";
        label1.Size = new Size(0, 15);
        label1.TabIndex = 0;
        label1.Click += label1_Click;
        // 
        // ButnCLickResult
        // 
        ButnCLickResult.Location = new Point(7, 93);
        ButnCLickResult.Name = "ButnCLickResult";
        ButnCLickResult.Size = new Size(396, 84);
        ButnCLickResult.TabIndex = 1;
        ButnCLickResult.Text = "Вычислить";
        ButnCLickResult.UseVisualStyleBackColor = true;
        ButnCLickResult.Click += ButnCLick_Click;
        // 
        // InputTexBox
        // 
        InputTexBox.Location = new Point(7, 33);
        InputTexBox.Name = "InputTexBox";
        InputTexBox.Size = new Size(396, 23);
        InputTexBox.TabIndex = 2;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(7, 59);
        label2.Name = "label2";
        label2.Size = new Size(114, 15);
        label2.TabIndex = 3;
        label2.Text = "Введите значение X";
        // 
        // contextMenuStrip1
        // 
        contextMenuStrip1.Name = "contextMenuStrip1";
        contextMenuStrip1.Size = new Size(61, 4);
        // 
        // pictureBox1
        // 
        pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        pictureBox1.Location = new Point(232, 21);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(123, 56);
        pictureBox1.TabIndex = 4;
        pictureBox1.TabStop = false;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(LabelUsl);
        groupBox1.Controls.Add(pictureBox1);
        groupBox1.Location = new Point(13, 13);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(402, 163);
        groupBox1.TabIndex = 5;
        groupBox1.TabStop = false;
        groupBox1.Text = "Условие";
        // 
        // LabelUsl
        // 
        LabelUsl.AutoSize = true;
        LabelUsl.Location = new Point(6, 45);
        LabelUsl.Name = "LabelUsl";
        LabelUsl.Size = new Size(188, 15);
        LabelUsl.TabIndex = 5;
        LabelUsl.Text = "Вычислить значение выражения";
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(InputTexBox);
        groupBox2.Controls.Add(ButnCLickResult);
        groupBox2.Controls.Add(label2);
        groupBox2.Location = new Point(12, 269);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(403, 184);
        groupBox2.TabIndex = 6;
        groupBox2.TabStop = false;
        groupBox2.Text = "Решение";
        // 
        // ResultGBox
        // 
        ResultGBox.Controls.Add(TextBoxResult);
        ResultGBox.Location = new Point(12, 182);
        ResultGBox.Name = "ResultGBox";
        ResultGBox.Size = new Size(403, 81);
        ResultGBox.TabIndex = 7;
        ResultGBox.TabStop = false;
        ResultGBox.Text = "Результат";
        // 
        // TextBoxResult
        // 
        TextBoxResult.AccessibleRole = AccessibleRole.None;
        TextBoxResult.Location = new Point(9, 28);
        TextBoxResult.Name = "TextBoxResult";
        TextBoxResult.Size = new Size(383, 23);
        TextBoxResult.TabIndex = 0;
        // 
        // FormMain
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(444, 465);
        Controls.Add(ResultGBox);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Controls.Add(label1);
        Name = "FormMain";
        Text = "Спринт 6 | Таск 0 | Дмитриев Л.Р.";
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        ResultGBox.ResumeLayout(false);
        ResultGBox.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Button ButnCLickResult;
    private TextBox InputTexBox;
    private Label label2;
    private ContextMenuStrip contextMenuStrip1;
    private PictureBox pictureBox1;
    private GroupBox groupBox1;
    private Label LabelUsl;
    private GroupBox groupBox2;
    private GroupBox ResultGBox;
    private TextBox TextBoxResult;
}