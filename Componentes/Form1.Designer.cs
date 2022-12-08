
namespace Componentes
{
    partial class frmfrutas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmfrutas));
            this.gpbfrutas = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblmaca = new System.Windows.Forms.Label();
            this.lblpera = new System.Windows.Forms.Label();
            this.lblmelancia = new System.Windows.Forms.Label();
            this.lblsair = new System.Windows.Forms.Label();
            this.txtselecione = new System.Windows.Forms.TextBox();
            this.lblfrutasselecionada = new System.Windows.Forms.Label();
            this.cdbfrutaslistadas = new System.Windows.Forms.ComboBox();
            this.lblFrutasselecionadas = new System.Windows.Forms.Label();
            this.ltbFrutas = new System.Windows.Forms.ListBox();
            this.lblFrutaslistadas = new System.Windows.Forms.Label();
            this.txtbdigitarfruta = new System.Windows.Forms.TextBox();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.btnselecionar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btninserir = new System.Windows.Forms.Button();
            this.gpbfrutas.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbfrutas
            // 
            this.gpbfrutas.Controls.Add(this.lblsair);
            this.gpbfrutas.Controls.Add(this.lblmelancia);
            this.gpbfrutas.Controls.Add(this.lblpera);
            this.gpbfrutas.Controls.Add(this.lblmaca);
            this.gpbfrutas.Controls.Add(this.label1);
            this.gpbfrutas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbfrutas.Location = new System.Drawing.Point(100, 108);
            this.gpbfrutas.Name = "gpbfrutas";
            this.gpbfrutas.Size = new System.Drawing.Size(140, 198);
            this.gpbfrutas.TabIndex = 2;
            this.gpbfrutas.TabStop = false;
            this.gpbfrutas.Text = "Frutas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "1-Banana";
            // 
            // lblmaca
            // 
            this.lblmaca.AutoSize = true;
            this.lblmaca.Location = new System.Drawing.Point(15, 70);
            this.lblmaca.Name = "lblmaca";
            this.lblmaca.Size = new System.Drawing.Size(72, 24);
            this.lblmaca.TabIndex = 1;
            this.lblmaca.Text = "2-Maçã";
            // 
            // lblpera
            // 
            this.lblpera.AutoSize = true;
            this.lblpera.Location = new System.Drawing.Point(15, 102);
            this.lblpera.Name = "lblpera";
            this.lblpera.Size = new System.Drawing.Size(65, 24);
            this.lblpera.TabIndex = 2;
            this.lblpera.Text = "3-Pera";
            // 
            // lblmelancia
            // 
            this.lblmelancia.AutoSize = true;
            this.lblmelancia.Location = new System.Drawing.Point(15, 132);
            this.lblmelancia.Name = "lblmelancia";
            this.lblmelancia.Size = new System.Drawing.Size(102, 24);
            this.lblmelancia.TabIndex = 3;
            this.lblmelancia.Text = "4-Melancia";
            // 
            // lblsair
            // 
            this.lblsair.AutoSize = true;
            this.lblsair.Location = new System.Drawing.Point(15, 164);
            this.lblsair.Name = "lblsair";
            this.lblsair.Size = new System.Drawing.Size(58, 24);
            this.lblsair.TabIndex = 4;
            this.lblsair.Text = "5-Sair";
            // 
            // txtselecione
            // 
            this.txtselecione.Location = new System.Drawing.Point(80, 353);
            this.txtselecione.Name = "txtselecione";
            this.txtselecione.Size = new System.Drawing.Size(160, 20);
            this.txtselecione.TabIndex = 1;
            // 
            // lblfrutasselecionada
            // 
            this.lblfrutasselecionada.AutoSize = true;
            this.lblfrutasselecionada.Location = new System.Drawing.Point(106, 332);
            this.lblfrutasselecionada.Name = "lblfrutasselecionada";
            this.lblfrutasselecionada.Size = new System.Drawing.Size(98, 13);
            this.lblfrutasselecionada.TabIndex = 4;
            this.lblfrutasselecionada.Text = "Frutas Selecionada";
            // 
            // cdbfrutaslistadas
            // 
            this.cdbfrutaslistadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdbfrutaslistadas.FormattingEnabled = true;
            this.cdbfrutaslistadas.Location = new System.Drawing.Point(474, 332);
            this.cdbfrutaslistadas.Name = "cdbfrutaslistadas";
            this.cdbfrutaslistadas.Size = new System.Drawing.Size(154, 32);
            this.cdbfrutaslistadas.TabIndex = 6;
            // 
            // lblFrutasselecionadas
            // 
            this.lblFrutasselecionadas.AutoSize = true;
            this.lblFrutasselecionadas.Location = new System.Drawing.Point(491, 306);
            this.lblFrutasselecionadas.Name = "lblFrutasselecionadas";
            this.lblFrutasselecionadas.Size = new System.Drawing.Size(101, 13);
            this.lblFrutasselecionadas.TabIndex = 6;
            this.lblFrutasselecionadas.Text = "Frutas selecionadas";
            // 
            // ltbFrutas
            // 
            this.ltbFrutas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbFrutas.FormattingEnabled = true;
            this.ltbFrutas.ItemHeight = 24;
            this.ltbFrutas.Location = new System.Drawing.Point(474, 61);
            this.ltbFrutas.Name = "ltbFrutas";
            this.ltbFrutas.Size = new System.Drawing.Size(180, 220);
            this.ltbFrutas.TabIndex = 7;
            // 
            // lblFrutaslistadas
            // 
            this.lblFrutaslistadas.AutoSize = true;
            this.lblFrutaslistadas.Location = new System.Drawing.Point(491, 32);
            this.lblFrutaslistadas.Name = "lblFrutaslistadas";
            this.lblFrutaslistadas.Size = new System.Drawing.Size(98, 13);
            this.lblFrutaslistadas.TabIndex = 8;
            this.lblFrutaslistadas.Text = "Frutas Selecionada";
            // 
            // txtbdigitarfruta
            // 
            this.txtbdigitarfruta.Location = new System.Drawing.Point(80, 71);
            this.txtbdigitarfruta.Name = "txtbdigitarfruta";
            this.txtbdigitarfruta.Size = new System.Drawing.Size(160, 20);
            this.txtbdigitarfruta.TabIndex = 0;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Location = new System.Drawing.Point(77, 43);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(192, 13);
            this.lbltitulo.TabIndex = 10;
            this.lbltitulo.Text = "Digite o número para selecionar a fruta:";
            // 
            // btnselecionar
            // 
            this.btnselecionar.Location = new System.Drawing.Point(70, 389);
            this.btnselecionar.Name = "btnselecionar";
            this.btnselecionar.Size = new System.Drawing.Size(93, 37);
            this.btnselecionar.TabIndex = 2;
            this.btnselecionar.Text = "Selecionar";
            this.btnselecionar.UseVisualStyleBackColor = true;
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(311, 389);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(93, 37);
            this.btnlimpar.TabIndex = 4;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(419, 389);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(93, 37);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btninserir
            // 
            this.btninserir.Location = new System.Drawing.Point(196, 389);
            this.btninserir.Name = "btninserir";
            this.btninserir.Size = new System.Drawing.Size(93, 37);
            this.btninserir.TabIndex = 3;
            this.btninserir.Text = "Inserir";
            this.btninserir.UseVisualStyleBackColor = true;
            // 
            // frmfrutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btninserir);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnselecionar);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.txtbdigitarfruta);
            this.Controls.Add(this.lblFrutaslistadas);
            this.Controls.Add(this.ltbFrutas);
            this.Controls.Add(this.lblFrutasselecionadas);
            this.Controls.Add(this.cdbfrutaslistadas);
            this.Controls.Add(this.lblfrutasselecionada);
            this.Controls.Add(this.txtselecione);
            this.Controls.Add(this.gpbfrutas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmfrutas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1-Banana";
            this.gpbfrutas.ResumeLayout(false);
            this.gpbfrutas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbfrutas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblsair;
        private System.Windows.Forms.Label lblmelancia;
        private System.Windows.Forms.Label lblpera;
        private System.Windows.Forms.Label lblmaca;
        private System.Windows.Forms.TextBox txtselecione;
        private System.Windows.Forms.Label lblfrutasselecionada;
        private System.Windows.Forms.ComboBox cdbfrutaslistadas;
        private System.Windows.Forms.Label lblFrutasselecionadas;
        private System.Windows.Forms.ListBox ltbFrutas;
        private System.Windows.Forms.Label lblFrutaslistadas;
        private System.Windows.Forms.TextBox txtbdigitarfruta;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Button btnselecionar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btninserir;
    }
}

