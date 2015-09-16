namespace AgendaDesign.view
{
    partial class InfoContato
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.idTbx = new System.Windows.Forms.TextBox();
            this.nomeTbx = new System.Windows.Forms.TextBox();
            this.telefoneTbx = new System.Windows.Forms.TextBox();
            this.emailTbx = new System.Windows.Forms.TextBox();
            this.notaTbx = new System.Windows.Forms.TextBox();
            this.salvarBtn = new System.Windows.Forms.Button();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nota";
            // 
            // idTbx
            // 
            this.idTbx.Location = new System.Drawing.Point(83, 34);
            this.idTbx.Name = "idTbx";
            this.idTbx.ReadOnly = true;
            this.idTbx.Size = new System.Drawing.Size(64, 20);
            this.idTbx.TabIndex = 0;
            this.idTbx.TabStop = false;
            // 
            // nomeTbx
            // 
            this.nomeTbx.Location = new System.Drawing.Point(83, 66);
            this.nomeTbx.Name = "nomeTbx";
            this.nomeTbx.Size = new System.Drawing.Size(203, 20);
            this.nomeTbx.TabIndex = 6;
            // 
            // telefoneTbx
            // 
            this.telefoneTbx.Location = new System.Drawing.Point(83, 100);
            this.telefoneTbx.Name = "telefoneTbx";
            this.telefoneTbx.Size = new System.Drawing.Size(203, 20);
            this.telefoneTbx.TabIndex = 7;
            // 
            // emailTbx
            // 
            this.emailTbx.Location = new System.Drawing.Point(83, 133);
            this.emailTbx.Name = "emailTbx";
            this.emailTbx.Size = new System.Drawing.Size(203, 20);
            this.emailTbx.TabIndex = 8;
            // 
            // notaTbx
            // 
            this.notaTbx.Location = new System.Drawing.Point(83, 170);
            this.notaTbx.Multiline = true;
            this.notaTbx.Name = "notaTbx";
            this.notaTbx.Size = new System.Drawing.Size(203, 147);
            this.notaTbx.TabIndex = 9;
            // 
            // salvarBtn
            // 
            this.salvarBtn.Location = new System.Drawing.Point(192, 323);
            this.salvarBtn.Name = "salvarBtn";
            this.salvarBtn.Size = new System.Drawing.Size(94, 57);
            this.salvarBtn.TabIndex = 10;
            this.salvarBtn.Text = "Salvar";
            this.salvarBtn.UseVisualStyleBackColor = true;
            this.salvarBtn.Click += new System.EventHandler(this.salvarBtn_Click);
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Location = new System.Drawing.Point(83, 323);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(93, 57);
            this.cancelarBtn.TabIndex = 11;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // InfoContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(311, 392);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.salvarBtn);
            this.Controls.Add(this.notaTbx);
            this.Controls.Add(this.emailTbx);
            this.Controls.Add(this.telefoneTbx);
            this.Controls.Add(this.nomeTbx);
            this.Controls.Add(this.idTbx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InfoContato";
            this.Load += new System.EventHandler(this.InfoContato_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idTbx;
        private System.Windows.Forms.TextBox nomeTbx;
        private System.Windows.Forms.TextBox telefoneTbx;
        private System.Windows.Forms.TextBox emailTbx;
        private System.Windows.Forms.TextBox notaTbx;
        private System.Windows.Forms.Button salvarBtn;
        private System.Windows.Forms.Button cancelarBtn;
    }
}