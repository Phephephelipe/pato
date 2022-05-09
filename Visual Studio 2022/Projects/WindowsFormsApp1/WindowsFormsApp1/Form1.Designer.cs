namespace WindowsFormsApp1
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
            this.pp_btn = new System.Windows.Forms.Button();
            this.txt_data = new System.Windows.Forms.Label();
            this.sub_btn = new System.Windows.Forms.Button();
            this.div_btn = new System.Windows.Forms.Button();
            this.mult_btn = new System.Windows.Forms.Button();
            this.inp_d1 = new System.Windows.Forms.TextBox();
            this.inp_d2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pp_btn
            // 
            this.pp_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pp_btn.Location = new System.Drawing.Point(40, 177);
            this.pp_btn.Name = "pp_btn";
            this.pp_btn.Size = new System.Drawing.Size(86, 76);
            this.pp_btn.TabIndex = 0;
            this.pp_btn.Text = "+";
            this.pp_btn.UseVisualStyleBackColor = true;
            this.pp_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_data
            // 
            this.txt_data.AutoSize = true;
            this.txt_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_data.Location = new System.Drawing.Point(34, 68);
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(0, 25);
            this.txt_data.TabIndex = 1;
            this.txt_data.Click += new System.EventHandler(this.label1_Click);
            // 
            // sub_btn
            // 
            this.sub_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub_btn.Location = new System.Drawing.Point(159, 177);
            this.sub_btn.Name = "sub_btn";
            this.sub_btn.Size = new System.Drawing.Size(81, 76);
            this.sub_btn.TabIndex = 2;
            this.sub_btn.Text = "-";
            this.sub_btn.UseVisualStyleBackColor = true;
            this.sub_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // div_btn
            // 
            this.div_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.div_btn.Location = new System.Drawing.Point(40, 269);
            this.div_btn.Name = "div_btn";
            this.div_btn.Size = new System.Drawing.Size(86, 76);
            this.div_btn.TabIndex = 3;
            this.div_btn.Text = "/";
            this.div_btn.UseVisualStyleBackColor = true;
            this.div_btn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // mult_btn
            // 
            this.mult_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mult_btn.Location = new System.Drawing.Point(154, 269);
            this.mult_btn.Name = "mult_btn";
            this.mult_btn.Size = new System.Drawing.Size(86, 76);
            this.mult_btn.TabIndex = 4;
            this.mult_btn.Text = "*";
            this.mult_btn.UseVisualStyleBackColor = true;
            this.mult_btn.Click += new System.EventHandler(this.mult_btn_Click);
            // 
            // inp_d1
            // 
            this.inp_d1.Location = new System.Drawing.Point(40, 371);
            this.inp_d1.Name = "inp_d1";
            this.inp_d1.Size = new System.Drawing.Size(200, 20);
            this.inp_d1.TabIndex = 5;
            this.inp_d1.TextChanged += new System.EventHandler(this.inp_d1_TextChanged);
            // 
            // inp_d2
            // 
            this.inp_d2.Location = new System.Drawing.Point(40, 408);
            this.inp_d2.Name = "inp_d2";
            this.inp_d2.Size = new System.Drawing.Size(200, 20);
            this.inp_d2.TabIndex = 6;
            this.inp_d2.TextChanged += new System.EventHandler(this.inp_d2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 450);
            this.Controls.Add(this.inp_d2);
            this.Controls.Add(this.inp_d1);
            this.Controls.Add(this.mult_btn);
            this.Controls.Add(this.div_btn);
            this.Controls.Add(this.sub_btn);
            this.Controls.Add(this.txt_data);
            this.Controls.Add(this.pp_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pp_btn;
        private System.Windows.Forms.Label txt_data;
        private System.Windows.Forms.Button sub_btn;
        private System.Windows.Forms.Button div_btn;
        private System.Windows.Forms.Button mult_btn;
        private System.Windows.Forms.TextBox inp_d1;
        private System.Windows.Forms.TextBox inp_d2;
    }
}

