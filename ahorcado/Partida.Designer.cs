namespace ahorcado
{
    partial class Partida
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
            buttonProbar = new Button();
            vidasLabel = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            labelInfo = new Label();
            palabraLabel = new Label();
            SuspendLayout();
            // 
            // buttonProbar
            // 
            buttonProbar.Location = new Point(436, 309);
            buttonProbar.Name = "buttonProbar";
            buttonProbar.Size = new Size(64, 29);
            buttonProbar.TabIndex = 11;
            buttonProbar.Text = "Probar";
            buttonProbar.UseVisualStyleBackColor = true;
            buttonProbar.Click += buttonProbar_Click;
            // 
            // vidasLabel
            // 
            vidasLabel.AutoSize = true;
            vidasLabel.Location = new Point(366, 70);
            vidasLabel.Name = "vidasLabel";
            vidasLabel.Size = new Size(64, 20);
            vidasLabel.TabIndex = 10;
            vidasLabel.Text = "Vidas : 5";
            vidasLabel.Click += vidasLabel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(328, 286);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 9;
            label1.Text = "Introduce una letra";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(300, 309);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(130, 27);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Location = new Point(358, 361);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(71, 20);
            labelInfo.TabIndex = 7;
            labelInfo.Text = "infoLabel";
            labelInfo.Click += labelInfo_Click;
            // 
            // palabraLabel
            // 
            palabraLabel.AutoSize = true;
            palabraLabel.Location = new Point(368, 170);
            palabraLabel.Name = "palabraLabel";
            palabraLabel.Size = new Size(50, 20);
            palabraLabel.TabIndex = 6;
            palabraLabel.Text = "label1";
            palabraLabel.Click += palabraLabel_Click;
            // 
            // Partida
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonProbar);
            Controls.Add(vidasLabel);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(labelInfo);
            Controls.Add(palabraLabel);
            Name = "Partida";
            Text = "Partida";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonProbar;
        private Label vidasLabel;
        private Label label1;
        private TextBox textBox1;
        private Label labelInfo;
        private Label palabraLabel;
    }
}