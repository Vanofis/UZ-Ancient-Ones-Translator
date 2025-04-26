namespace AncientOnesTranslator;

partial class MainWindowForm
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
        TranslatorFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
        InputTextBox = new System.Windows.Forms.TextBox();
        TranslateButton = new System.Windows.Forms.Button();
        OutputTextBox = new System.Windows.Forms.TextBox();
        MainFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
        TranslatorFlowLayoutPanel.SuspendLayout();
        MainFlowLayoutPanel.SuspendLayout();
        SuspendLayout();
        // 
        // TranslatorFlowLayoutPanel
        // 
        TranslatorFlowLayoutPanel.AutoSize = true;
        TranslatorFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        TranslatorFlowLayoutPanel.Controls.Add(InputTextBox);
        TranslatorFlowLayoutPanel.Controls.Add(TranslateButton);
        TranslatorFlowLayoutPanel.Controls.Add(OutputTextBox);
        TranslatorFlowLayoutPanel.Location = new System.Drawing.Point(3, 3);
        TranslatorFlowLayoutPanel.Name = "TranslatorFlowLayoutPanel";
        TranslatorFlowLayoutPanel.Size = new System.Drawing.Size(696, 318);
        TranslatorFlowLayoutPanel.TabIndex = 0;
        // 
        // InputTextBox
        // 
        InputTextBox.AcceptsReturn = true;
        InputTextBox.AcceptsTab = true;
        InputTextBox.AllowDrop = true;
        InputTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
        InputTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
        InputTextBox.Location = new System.Drawing.Point(10, 9);
        InputTextBox.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
        InputTextBox.Multiline = true;
        InputTextBox.Name = "InputTextBox";
        InputTextBox.PlaceholderText = "Enter your text";
        InputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        InputTextBox.Size = new System.Drawing.Size(250, 300);
        InputTextBox.TabIndex = 0;
        // 
        // TranslateButton
        // 
        TranslateButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
        TranslateButton.Cursor = System.Windows.Forms.Cursors.Hand;
        TranslateButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
        TranslateButton.Location = new System.Drawing.Point(273, 125);
        TranslateButton.Margin = new System.Windows.Forms.Padding(3, 125, 3, 125);
        TranslateButton.Name = "TranslateButton";
        TranslateButton.Size = new System.Drawing.Size(150, 50);
        TranslateButton.TabIndex = 1;
        TranslateButton.Text = "Translate";
        TranslateButton.UseVisualStyleBackColor = true;
        TranslateButton.Click += TranslateButton_Click;
        // 
        // OutputTextBox
        // 
        OutputTextBox.AcceptsReturn = true;
        OutputTextBox.AcceptsTab = true;
        OutputTextBox.AllowDrop = true;
        OutputTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        OutputTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
        OutputTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
        OutputTextBox.Location = new System.Drawing.Point(436, 9);
        OutputTextBox.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
        OutputTextBox.Multiline = true;
        OutputTextBox.Name = "OutputTextBox";
        OutputTextBox.PlaceholderText = "The translation will appear here";
        OutputTextBox.ReadOnly = true;
        OutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        OutputTextBox.Size = new System.Drawing.Size(250, 300);
        OutputTextBox.TabIndex = 2;
        // 
        // MainFlowLayoutPanel
        // 
        MainFlowLayoutPanel.AutoSize = true;
        MainFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        MainFlowLayoutPanel.Controls.Add(TranslatorFlowLayoutPanel);
        MainFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
        MainFlowLayoutPanel.Location = new System.Drawing.Point(12, 12);
        MainFlowLayoutPanel.Name = "MainFlowLayoutPanel";
        MainFlowLayoutPanel.Size = new System.Drawing.Size(702, 324);
        MainFlowLayoutPanel.TabIndex = 1;
        // 
        // MainWindowForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        AutoSize = true;
        AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        ClientSize = new System.Drawing.Size(718, 346);
        Controls.Add(MainFlowLayoutPanel);
        Name = "MainWindowForm";
        Text = "MainWindowForm";
        TranslatorFlowLayoutPanel.ResumeLayout(false);
        TranslatorFlowLayoutPanel.PerformLayout();
        MainFlowLayoutPanel.ResumeLayout(false);
        MainFlowLayoutPanel.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private System.Windows.Forms.FlowLayoutPanel TranslatorFlowLayoutPanel;
    private System.Windows.Forms.TextBox InputTextBox;
    private System.Windows.Forms.Button TranslateButton;
    private System.Windows.Forms.TextBox OutputTextBox;
    private System.Windows.Forms.FlowLayoutPanel MainFlowLayoutPanel;
}