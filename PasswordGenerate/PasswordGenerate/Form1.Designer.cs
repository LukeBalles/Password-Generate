namespace PasswordGenerate
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.passwordBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.generate = new System.Windows.Forms.Button();
            this.uppercase = new System.Windows.Forms.CheckBox();
            this.numberBox = new System.Windows.Forms.NumericUpDown();
            this.number = new System.Windows.Forms.CheckBox();
            this.symbols = new System.Windows.Forms.CheckBox();
            this.exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numberBox)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordBox.ForeColor = System.Drawing.Color.Ivory;
            this.passwordBox.FormattingEnabled = true;
            this.passwordBox.Location = new System.Drawing.Point(7, 7);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(144, 260);
            this.passwordBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(165, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Characters";
            // 
            // generate
            // 
            this.generate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generate.ForeColor = System.Drawing.Color.Ivory;
            this.generate.Location = new System.Drawing.Point(173, 233);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(120, 27);
            this.generate.TabIndex = 2;
            this.generate.Text = "Generate";
            this.generate.UseVisualStyleBackColor = false;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // uppercase
            // 
            this.uppercase.AutoSize = true;
            this.uppercase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uppercase.ForeColor = System.Drawing.Color.Ivory;
            this.uppercase.Location = new System.Drawing.Point(168, 92);
            this.uppercase.Name = "uppercase";
            this.uppercase.Size = new System.Drawing.Size(86, 19);
            this.uppercase.TabIndex = 3;
            this.uppercase.Text = "Uppercase";
            this.uppercase.UseVisualStyleBackColor = true;
            // 
            // numberBox
            // 
            this.numberBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.numberBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numberBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numberBox.ForeColor = System.Drawing.Color.Ivory;
            this.numberBox.Location = new System.Drawing.Point(168, 45);
            this.numberBox.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numberBox.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(120, 16);
            this.numberBox.TabIndex = 4;
            this.numberBox.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number.ForeColor = System.Drawing.Color.Ivory;
            this.number.Location = new System.Drawing.Point(168, 139);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(71, 19);
            this.number.TabIndex = 5;
            this.number.Text = "Number";
            this.number.UseVisualStyleBackColor = true;
            // 
            // symbols
            // 
            this.symbols.AutoSize = true;
            this.symbols.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symbols.ForeColor = System.Drawing.Color.Ivory;
            this.symbols.Location = new System.Drawing.Point(166, 184);
            this.symbols.Name = "symbols";
            this.symbols.Size = new System.Drawing.Size(73, 19);
            this.symbols.TabIndex = 6;
            this.symbols.Text = "Symbols";
            this.symbols.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exit.Location = new System.Drawing.Point(286, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(25, 25);
            this.exit.TabIndex = 7;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(313, 272);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.symbols);
            this.Controls.Add(this.number);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.uppercase);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numberBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox passwordBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.CheckBox uppercase;
        private System.Windows.Forms.NumericUpDown numberBox;
        private System.Windows.Forms.CheckBox number;
        private System.Windows.Forms.CheckBox symbols;
        private System.Windows.Forms.Button exit;
    }
}

