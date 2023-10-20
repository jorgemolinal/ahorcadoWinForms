namespace ahorcado
{
    partial class Juego
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
            label3 = new Label();
            vidasLabel = new Label();
            buttonSiguiente = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(321, 170);
            label3.Name = "label3";
            label3.Size = new Size(179, 20);
            label3.TabIndex = 0;
            label3.Text = "Pulsa siguiente para jugar";
            label3.Click += label3_Click;
            // 
            // vidasLabel
            // 
            vidasLabel.AutoSize = true;
            vidasLabel.Location = new Point(306, 90);
            vidasLabel.Name = "vidasLabel";
            vidasLabel.Size = new Size(233, 20);
            vidasLabel.TabIndex = 4;
            vidasLabel.Text = "Bienvenido al juego del ahorcado";
            vidasLabel.Click += vidasLabel_Click;
            // 
            // buttonSiguiente
            // 
            buttonSiguiente.Location = new Point(346, 208);
            buttonSiguiente.Name = "buttonSiguiente";
            buttonSiguiente.Size = new Size(127, 29);
            buttonSiguiente.TabIndex = 5;
            buttonSiguiente.Text = "Siguiente";
            buttonSiguiente.UseVisualStyleBackColor = true;
            buttonSiguiente.Click += buttonSiguiente_Click;
            // 
            // Juego
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSiguiente);
            Controls.Add(vidasLabel);
            Controls.Add(label3);
            Name = "Juego";
            Text = "Juego";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox textBox1;
        private Label label1;
        private Label vidasLabel;
        private Button buttonSiguiente;
    }
}