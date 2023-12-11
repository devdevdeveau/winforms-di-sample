namespace DISample;

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
        CreateForm2Button = new Button();
        button1 = new Button();
        SuspendLayout();
        // 
        // CreateForm2Button
        // 
        CreateForm2Button.Location = new Point(499, 151);
        CreateForm2Button.Name = "CreateForm2Button";
        CreateForm2Button.Size = new Size(132, 23);
        CreateForm2Button.TabIndex = 0;
        CreateForm2Button.Text = "Create Form 2";
        CreateForm2Button.UseVisualStyleBackColor = true;
        CreateForm2Button.Click += CreateForm2Button_Click;
        // 
        // button1
        // 
        button1.Location = new Point(455, 256);
        button1.Name = "button1";
        button1.Size = new Size(75, 23);
        button1.TabIndex = 1;
        button1.Text = "button1";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(button1);
        Controls.Add(CreateForm2Button);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
    }

    #endregion

    private Button CreateForm2Button;
    private Button button1;
}
