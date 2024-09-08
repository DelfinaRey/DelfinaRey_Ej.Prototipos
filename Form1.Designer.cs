namespace DelfinaRey_Ej.Prototipos
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
            contextMenuStrip1 = new ContextMenuStrip(components);
            textBoxDNI = new TextBox();
            textBoxNombre = new TextBox();
            textBoxApellido = new TextBox();
            textBoxFechaNac = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            buttonDNI = new Button();
            buttonNombre = new Button();
            buttonApellido = new Button();
            buttonFecha = new Button();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // textBoxDNI
            // 
            textBoxDNI.BackColor = SystemColors.ControlDark;
            textBoxDNI.Location = new Point(285, 111);
            textBoxDNI.Name = "textBoxDNI";
            textBoxDNI.Size = new Size(315, 23);
            textBoxDNI.TabIndex = 5;
            textBoxDNI.TextChanged += textBoxDNI_TextChanged;
            // 
            // textBoxNombre
            // 
            textBoxNombre.BackColor = SystemColors.ControlDark;
            textBoxNombre.ForeColor = SystemColors.ActiveCaptionText;
            textBoxNombre.Location = new Point(285, 170);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(315, 23);
            textBoxNombre.TabIndex = 6;
            textBoxNombre.TextChanged += textBox1_TextChanged;
            // 
            // textBoxApellido
            // 
            textBoxApellido.BackColor = SystemColors.ControlDark;
            textBoxApellido.Location = new Point(285, 242);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(315, 23);
            textBoxApellido.TabIndex = 7;
            // 
            // textBoxFechaNac
            // 
            textBoxFechaNac.BackColor = SystemColors.ControlDark;
            textBoxFechaNac.Location = new Point(285, 312);
            textBoxFechaNac.Name = "textBoxFechaNac";
            textBoxFechaNac.Size = new Size(315, 23);
            textBoxFechaNac.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 111);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 9;
            label1.Text = "Ingrese su Documento";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 178);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 10;
            label2.Text = "Ingrese su Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(95, 312);
            label4.Name = "label4";
            label4.Size = new Size(172, 15);
            label4.TabIndex = 12;
            label4.Text = "Ingrese su Fecha de Nacmiento";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(95, 245);
            label5.Name = "label5";
            label5.Size = new Size(107, 15);
            label5.TabIndex = 13;
            label5.Text = "Ingrese su Apellido";
            // 
            // buttonDNI
            // 
            buttonDNI.BackColor = SystemColors.ControlDarkDark;
            buttonDNI.ForeColor = SystemColors.ButtonHighlight;
            buttonDNI.Location = new Point(651, 111);
            buttonDNI.Name = "buttonDNI";
            buttonDNI.Size = new Size(107, 23);
            buttonDNI.TabIndex = 14;
            buttonDNI.Text = "VALIDAR";
            buttonDNI.UseVisualStyleBackColor = false;
            buttonDNI.Click += buttonDNI_Click;
            // 
            // buttonNombre
            // 
            buttonNombre.BackColor = SystemColors.ControlDarkDark;
            buttonNombre.ForeColor = SystemColors.ButtonHighlight;
            buttonNombre.Location = new Point(651, 170);
            buttonNombre.Name = "buttonNombre";
            buttonNombre.Size = new Size(107, 23);
            buttonNombre.TabIndex = 15;
            buttonNombre.Text = "VALIDAR";
            buttonNombre.UseVisualStyleBackColor = false;
            // 
            // buttonApellido
            // 
            buttonApellido.BackColor = SystemColors.ControlDarkDark;
            buttonApellido.ForeColor = SystemColors.ButtonHighlight;
            buttonApellido.Location = new Point(651, 245);
            buttonApellido.Name = "buttonApellido";
            buttonApellido.Size = new Size(107, 23);
            buttonApellido.TabIndex = 16;
            buttonApellido.Text = "VALIDAR";
            buttonApellido.UseVisualStyleBackColor = false;
            // 
            // buttonFecha
            // 
            buttonFecha.BackColor = SystemColors.ControlDarkDark;
            buttonFecha.ForeColor = SystemColors.ButtonHighlight;
            buttonFecha.Location = new Point(651, 312);
            buttonFecha.Name = "buttonFecha";
            buttonFecha.Size = new Size(107, 23);
            buttonFecha.TabIndex = 17;
            buttonFecha.Text = "VALIDAR";
            buttonFecha.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonFecha);
            Controls.Add(buttonApellido);
            Controls.Add(buttonNombre);
            Controls.Add(buttonDNI);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxFechaNac);
            Controls.Add(textBoxApellido);
            Controls.Add(textBoxNombre);
            Controls.Add(textBoxDNI);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private TextBox textBoxDNI;
        private TextBox textBoxNombre;
        private TextBox textBoxApellido;
        private TextBox textBoxFechaNac;
        private Label label2;
        private Label label4;
        private Label label5;
        public Label label1;
        private Button buttonDNI;
        private Button buttonNombre;
        private Button buttonApellido;
        private Button buttonFecha;
    }
}
