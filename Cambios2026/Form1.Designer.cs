namespace Cambios2026
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            TextBoxValor = new TextBox();
            label2 = new Label();
            label3 = new Label();
            ComboBoxOrigem = new ComboBox();
            ComboBoxDestino = new ComboBox();
            ButtonConverter = new Button();
            LabelResultado = new Label();
            LabelStatus = new Label();
            ProgressBar1 = new ProgressBar();
            ButtonTroca = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 92);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 0;
            label1.Text = "Valor:";
            // 
            // TextBoxValor
            // 
            TextBoxValor.Location = new Point(93, 92);
            TextBoxValor.Name = "TextBoxValor";
            TextBoxValor.Size = new Size(569, 23);
            TextBoxValor.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 207);
            label2.Name = "label2";
            label2.Size = new Size(151, 21);
            label2.TabIndex = 2;
            label2.Text = "Moeda de destino:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 149);
            label3.Name = "label3";
            label3.Size = new Size(149, 21);
            label3.TabIndex = 3;
            label3.Text = "Moeda de origem:";
            // 
            // ComboBoxOrigem
            // 
            ComboBoxOrigem.FormattingEnabled = true;
            ComboBoxOrigem.Location = new Point(187, 151);
            ComboBoxOrigem.Name = "ComboBoxOrigem";
            ComboBoxOrigem.Size = new Size(475, 23);
            ComboBoxOrigem.TabIndex = 4;
            // 
            // ComboBoxDestino
            // 
            ComboBoxDestino.FormattingEnabled = true;
            ComboBoxDestino.Location = new Point(188, 209);
            ComboBoxDestino.Name = "ComboBoxDestino";
            ComboBoxDestino.Size = new Size(474, 23);
            ComboBoxDestino.TabIndex = 5;
            // 
            // ButtonConverter
            // 
            ButtonConverter.Enabled = false;
            ButtonConverter.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonConverter.Location = new Point(691, 92);
            ButtonConverter.Name = "ButtonConverter";
            ButtonConverter.Size = new Size(146, 62);
            ButtonConverter.TabIndex = 6;
            ButtonConverter.Text = "Converter";
            ButtonConverter.UseVisualStyleBackColor = true;
            ButtonConverter.Click += ButtonConverter_Click;
            // 
            // LabelResultado
            // 
            LabelResultado.AutoSize = true;
            LabelResultado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelResultado.Location = new Point(188, 283);
            LabelResultado.Name = "LabelResultado";
            LabelResultado.Size = new Size(356, 21);
            LabelResultado.TabIndex = 7;
            LabelResultado.Text = "Escolha um valor, moeda de origem e destino";
            // 
            // LabelStatus
            // 
            LabelStatus.AutoSize = true;
            LabelStatus.Location = new Point(44, 345);
            LabelStatus.Name = "LabelStatus";
            LabelStatus.Size = new Size(38, 15);
            LabelStatus.TabIndex = 8;
            LabelStatus.Text = "status";
            // 
            // ProgressBar1
            // 
            ProgressBar1.Location = new Point(603, 345);
            ProgressBar1.Name = "ProgressBar1";
            ProgressBar1.Size = new Size(234, 23);
            ProgressBar1.TabIndex = 9;
            // 
            // ButtonTroca
            // 
            ButtonTroca.BackgroundImage = (Image)resources.GetObject("ButtonTroca.BackgroundImage");
            ButtonTroca.BackgroundImageLayout = ImageLayout.Zoom;
            ButtonTroca.Enabled = false;
            ButtonTroca.Location = new Point(691, 160);
            ButtonTroca.Name = "ButtonTroca";
            ButtonTroca.Size = new Size(146, 79);
            ButtonTroca.TabIndex = 10;
            ButtonTroca.UseVisualStyleBackColor = true;
            ButtonTroca.Click += ButtonTroca_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 429);
            Controls.Add(ButtonTroca);
            Controls.Add(ProgressBar1);
            Controls.Add(LabelStatus);
            Controls.Add(LabelResultado);
            Controls.Add(ButtonConverter);
            Controls.Add(ComboBoxDestino);
            Controls.Add(ComboBoxOrigem);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TextBoxValor);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Cambios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TextBoxValor;
        private Label label2;
        private Label label3;
        private ComboBox ComboBoxOrigem;
        private ComboBox ComboBoxDestino;
        private Button ButtonConverter;
        private Label LabelResultado;
        private Label LabelStatus;
        private ProgressBar ProgressBar1;
        private Button ButtonTroca;
    }
}
