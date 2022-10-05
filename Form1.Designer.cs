
namespace semana10_mysql
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bprimero = new System.Windows.Forms.Button();
            this.banterior = new System.Windows.Forms.Button();
            this.bsiguiente = new System.Windows.Forms.Button();
            this.bultimo = new System.Windows.Forms.Button();
            this.bnuevo = new System.Windows.Forms.Button();
            this.beliminar = new System.Windows.Forms.Button();
            this.bmodificar = new System.Windows.Forms.Button();
            this.bsalir = new System.Windows.Forms.Button();
            this.bguardar = new System.Windows.Forms.Button();
            this.bactualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.bbuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstnivel = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bprimero
            // 
            this.bprimero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bprimero.Location = new System.Drawing.Point(23, 226);
            this.bprimero.Name = "bprimero";
            this.bprimero.Size = new System.Drawing.Size(100, 36);
            this.bprimero.TabIndex = 0;
            this.bprimero.Text = "PRIMERO";
            this.bprimero.UseVisualStyleBackColor = true;
            // 
            // banterior
            // 
            this.banterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.banterior.Location = new System.Drawing.Point(151, 226);
            this.banterior.Name = "banterior";
            this.banterior.Size = new System.Drawing.Size(100, 36);
            this.banterior.TabIndex = 1;
            this.banterior.Text = "ANTERIOR";
            this.banterior.UseVisualStyleBackColor = true;
            // 
            // bsiguiente
            // 
            this.bsiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsiguiente.Location = new System.Drawing.Point(279, 226);
            this.bsiguiente.Name = "bsiguiente";
            this.bsiguiente.Size = new System.Drawing.Size(100, 36);
            this.bsiguiente.TabIndex = 2;
            this.bsiguiente.Text = "SIGUIENTE";
            this.bsiguiente.UseVisualStyleBackColor = true;
            // 
            // bultimo
            // 
            this.bultimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bultimo.Location = new System.Drawing.Point(400, 226);
            this.bultimo.Name = "bultimo";
            this.bultimo.Size = new System.Drawing.Size(100, 36);
            this.bultimo.TabIndex = 3;
            this.bultimo.Text = "ULTIMO";
            this.bultimo.UseVisualStyleBackColor = true;
            // 
            // bnuevo
            // 
            this.bnuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnuevo.Location = new System.Drawing.Point(23, 281);
            this.bnuevo.Name = "bnuevo";
            this.bnuevo.Size = new System.Drawing.Size(100, 36);
            this.bnuevo.TabIndex = 4;
            this.bnuevo.Text = "NUEVO";
            this.bnuevo.UseVisualStyleBackColor = true;
            this.bnuevo.Click += new System.EventHandler(this.bnuevo_Click);
            // 
            // beliminar
            // 
            this.beliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beliminar.Location = new System.Drawing.Point(151, 281);
            this.beliminar.Name = "beliminar";
            this.beliminar.Size = new System.Drawing.Size(100, 36);
            this.beliminar.TabIndex = 5;
            this.beliminar.Text = "ELIMINAR";
            this.beliminar.UseVisualStyleBackColor = true;
            this.beliminar.Click += new System.EventHandler(this.beliminar_Click);
            // 
            // bmodificar
            // 
            this.bmodificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmodificar.Location = new System.Drawing.Point(279, 281);
            this.bmodificar.Name = "bmodificar";
            this.bmodificar.Size = new System.Drawing.Size(100, 36);
            this.bmodificar.TabIndex = 6;
            this.bmodificar.Text = "MODIFICAR";
            this.bmodificar.UseVisualStyleBackColor = true;
            this.bmodificar.Click += new System.EventHandler(this.bmodificar_Click_1);
            // 
            // bsalir
            // 
            this.bsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsalir.Location = new System.Drawing.Point(400, 281);
            this.bsalir.Name = "bsalir";
            this.bsalir.Size = new System.Drawing.Size(100, 36);
            this.bsalir.TabIndex = 7;
            this.bsalir.Text = "SALIR";
            this.bsalir.UseVisualStyleBackColor = true;
            this.bsalir.Click += new System.EventHandler(this.bsalir_Click);
            // 
            // bguardar
            // 
            this.bguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bguardar.Location = new System.Drawing.Point(23, 332);
            this.bguardar.Name = "bguardar";
            this.bguardar.Size = new System.Drawing.Size(100, 36);
            this.bguardar.TabIndex = 8;
            this.bguardar.Text = "GUARDAR";
            this.bguardar.UseVisualStyleBackColor = true;
            this.bguardar.Click += new System.EventHandler(this.bguardar_Click_1);
            // 
            // bactualizar
            // 
            this.bactualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bactualizar.Location = new System.Drawing.Point(279, 332);
            this.bactualizar.Name = "bactualizar";
            this.bactualizar.Size = new System.Drawing.Size(100, 36);
            this.bactualizar.TabIndex = 9;
            this.bactualizar.Text = "ACTUALIZAR";
            this.bactualizar.UseVisualStyleBackColor = true;
            this.bactualizar.Click += new System.EventHandler(this.bactualizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "Contraseña ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(142, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nivel";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(257, 41);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(163, 20);
            this.txtusuario.TabIndex = 13;
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(257, 92);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(163, 20);
            this.txtclave.TabIndex = 14;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(475, 35);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(163, 20);
            this.txtbuscar.TabIndex = 16;
            // 
            // bbuscar
            // 
            this.bbuscar.Location = new System.Drawing.Point(655, 26);
            this.bbuscar.Name = "bbuscar";
            this.bbuscar.Size = new System.Drawing.Size(100, 36);
            this.bbuscar.TabIndex = 17;
            this.bbuscar.Text = "BUSCAR";
            this.bbuscar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(422, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(393, 134);
            this.dataGridView1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::semana10_mysql.Properties.Resources.usuario1;
            this.pictureBox1.Location = new System.Drawing.Point(24, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // lstnivel
            // 
            this.lstnivel.FormattingEnabled = true;
            this.lstnivel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.lstnivel.Location = new System.Drawing.Point(257, 142);
            this.lstnivel.Name = "lstnivel";
            this.lstnivel.Size = new System.Drawing.Size(163, 17);
            this.lstnivel.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 450);
            this.Controls.Add(this.lstnivel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bbuscar);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bactualizar);
            this.Controls.Add(this.bguardar);
            this.Controls.Add(this.bsalir);
            this.Controls.Add(this.bmodificar);
            this.Controls.Add(this.beliminar);
            this.Controls.Add(this.bnuevo);
            this.Controls.Add(this.bultimo);
            this.Controls.Add(this.bsiguiente);
            this.Controls.Add(this.banterior);
            this.Controls.Add(this.bprimero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bprimero;
        private System.Windows.Forms.Button banterior;
        private System.Windows.Forms.Button bsiguiente;
        private System.Windows.Forms.Button bultimo;
        private System.Windows.Forms.Button bnuevo;
        private System.Windows.Forms.Button beliminar;
        private System.Windows.Forms.Button bmodificar;
        private System.Windows.Forms.Button bsalir;
        private System.Windows.Forms.Button bguardar;
        private System.Windows.Forms.Button bactualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Button bbuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lstnivel;
    }
}

