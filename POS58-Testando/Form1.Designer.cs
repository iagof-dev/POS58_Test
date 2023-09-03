namespace POS58_Testando
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chbox_smash = new System.Windows.Forms.CheckBox();
            this.num_smash = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chbox_chopp = new System.Windows.Forms.CheckBox();
            this.num_chopp = new System.Windows.Forms.NumericUpDown();
            this.lbl_total = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_smash)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_chopp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_Calcular.Location = new System.Drawing.Point(282, 493);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(216, 60);
            this.btn_Calcular.TabIndex = 0;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Enabled = false;
            this.btn_imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_imprimir.Location = new System.Drawing.Point(587, 493);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(216, 60);
            this.btn_imprimir.TabIndex = 1;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // btn_new
            // 
            this.btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_new.Location = new System.Drawing.Point(25, 23);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(216, 60);
            this.btn_new.TabIndex = 2;
            this.btn_new.Text = "Novo Pedido";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::POS58_Testando.Properties.Resources._Downloader_la__64f3be6c11234_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(456, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chbox_smash);
            this.groupBox1.Controls.Add(this.num_smash);
            this.groupBox1.Location = new System.Drawing.Point(63, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 237);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lanches";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "R$10,00";
            // 
            // chbox_smash
            // 
            this.chbox_smash.AutoSize = true;
            this.chbox_smash.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.chbox_smash.Location = new System.Drawing.Point(33, 39);
            this.chbox_smash.Name = "chbox_smash";
            this.chbox_smash.Size = new System.Drawing.Size(183, 30);
            this.chbox_smash.TabIndex = 5;
            this.chbox_smash.Text = "Smash Burguer";
            this.chbox_smash.UseVisualStyleBackColor = true;
            // 
            // num_smash
            // 
            this.num_smash.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.num_smash.Location = new System.Drawing.Point(212, 39);
            this.num_smash.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_smash.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_smash.Name = "num_smash";
            this.num_smash.Size = new System.Drawing.Size(52, 32);
            this.num_smash.TabIndex = 6;
            this.num_smash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_smash.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.chbox_chopp);
            this.groupBox2.Controls.Add(this.num_chopp);
            this.groupBox2.Location = new System.Drawing.Point(613, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 237);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bebidas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(299, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "R$10,00";
            // 
            // chbox_chopp
            // 
            this.chbox_chopp.AutoSize = true;
            this.chbox_chopp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.chbox_chopp.Location = new System.Drawing.Point(33, 39);
            this.chbox_chopp.Name = "chbox_chopp";
            this.chbox_chopp.Size = new System.Drawing.Size(95, 30);
            this.chbox_chopp.TabIndex = 5;
            this.chbox_chopp.Text = "Chopp";
            this.chbox_chopp.UseVisualStyleBackColor = true;
            // 
            // num_chopp
            // 
            this.num_chopp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.num_chopp.Location = new System.Drawing.Point(212, 39);
            this.num_chopp.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_chopp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_chopp.Name = "num_chopp";
            this.num_chopp.Size = new System.Drawing.Size(52, 32);
            this.num_chopp.TabIndex = 6;
            this.num_chopp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_chopp.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.Green;
            this.lbl_total.Location = new System.Drawing.Point(465, 444);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(154, 25);
            this.lbl_total.TabIndex = 8;
            this.lbl_total.Text = "Total: R$0,00";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(299, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "R$10,00";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.checkBox1.Location = new System.Drawing.Point(33, 85);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(150, 30);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Refrigerante";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.numericUpDown1.Location = new System.Drawing.Point(212, 85);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(52, 32);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 650);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.btn_Calcular);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_smash)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_chopp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbox_smash;
        private System.Windows.Forms.NumericUpDown num_smash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chbox_chopp;
        private System.Windows.Forms.NumericUpDown num_chopp;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

