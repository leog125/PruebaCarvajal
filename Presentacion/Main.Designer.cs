
namespace Presentacion
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aerolineaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ciudadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarInformacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_crear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_estados = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_aerolineas = new System.Windows.Forms.ComboBox();
            this.dt_horallegada = new System.Windows.Forms.DateTimePicker();
            this.dt_fechallegada = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dt_horasalida = new System.Windows.Forms.DateTimePicker();
            this.dt_fechasalida = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_ciudaddestino = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_ciudadorigen = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gv_vuelos = new System.Windows.Forms.DataGridView();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_vuelos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem,
            this.actualizarInformacionToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(809, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aerolineaToolStripMenuItem,
            this.ciudadesToolStripMenuItem,
            this.estadosToolStripMenuItem});
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.crearToolStripMenuItem.Text = "Crear";
            // 
            // aerolineaToolStripMenuItem
            // 
            this.aerolineaToolStripMenuItem.Name = "aerolineaToolStripMenuItem";
            this.aerolineaToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.aerolineaToolStripMenuItem.Text = "Aerolinea";
            this.aerolineaToolStripMenuItem.Click += new System.EventHandler(this.aerolineaToolStripMenuItem_Click);
            // 
            // ciudadesToolStripMenuItem
            // 
            this.ciudadesToolStripMenuItem.Name = "ciudadesToolStripMenuItem";
            this.ciudadesToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.ciudadesToolStripMenuItem.Text = "Ciudades";
            this.ciudadesToolStripMenuItem.Click += new System.EventHandler(this.ciudadesToolStripMenuItem_Click);
            // 
            // estadosToolStripMenuItem
            // 
            this.estadosToolStripMenuItem.Name = "estadosToolStripMenuItem";
            this.estadosToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.estadosToolStripMenuItem.Text = "Estados";
            this.estadosToolStripMenuItem.Click += new System.EventHandler(this.estadosToolStripMenuItem_Click);
            // 
            // actualizarInformacionToolStripMenuItem
            // 
            this.actualizarInformacionToolStripMenuItem.Name = "actualizarInformacionToolStripMenuItem";
            this.actualizarInformacionToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.actualizarInformacionToolStripMenuItem.Text = "Actualizar Informacion";
            this.actualizarInformacionToolStripMenuItem.Click += new System.EventHandler(this.actualizarInformacionToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_crear);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cb_estados);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cb_aerolineas);
            this.groupBox1.Controls.Add(this.dt_horallegada);
            this.groupBox1.Controls.Add(this.dt_fechallegada);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dt_horasalida);
            this.groupBox1.Controls.Add(this.dt_fechasalida);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_ciudaddestino);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cb_ciudadorigen);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 330);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear Vuelo";
            // 
            // btn_crear
            // 
            this.btn_crear.Location = new System.Drawing.Point(111, 267);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(75, 23);
            this.btn_crear.TabIndex = 15;
            this.btn_crear.Text = "Crear";
            this.btn_crear.UseVisualStyleBackColor = true;
            this.btn_crear.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Estado Vuelo";
            // 
            // cb_estados
            // 
            this.cb_estados.FormattingEnabled = true;
            this.cb_estados.Location = new System.Drawing.Point(133, 223);
            this.cb_estados.Name = "cb_estados";
            this.cb_estados.Size = new System.Drawing.Size(202, 21);
            this.cb_estados.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Aerolinea";
            // 
            // cb_aerolineas
            // 
            this.cb_aerolineas.FormattingEnabled = true;
            this.cb_aerolineas.Location = new System.Drawing.Point(133, 185);
            this.cb_aerolineas.Name = "cb_aerolineas";
            this.cb_aerolineas.Size = new System.Drawing.Size(202, 21);
            this.cb_aerolineas.TabIndex = 11;
            // 
            // dt_horallegada
            // 
            this.dt_horallegada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dt_horallegada.Location = new System.Drawing.Point(237, 148);
            this.dt_horallegada.Name = "dt_horallegada";
            this.dt_horallegada.ShowUpDown = true;
            this.dt_horallegada.Size = new System.Drawing.Size(98, 20);
            this.dt_horallegada.TabIndex = 10;
            // 
            // dt_fechallegada
            // 
            this.dt_fechallegada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_fechallegada.Location = new System.Drawing.Point(133, 148);
            this.dt_fechallegada.Name = "dt_fechallegada";
            this.dt_fechallegada.Size = new System.Drawing.Size(98, 20);
            this.dt_fechallegada.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha/Hora LLegada";
            // 
            // dt_horasalida
            // 
            this.dt_horasalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dt_horasalida.Location = new System.Drawing.Point(237, 111);
            this.dt_horasalida.Name = "dt_horasalida";
            this.dt_horasalida.ShowUpDown = true;
            this.dt_horasalida.Size = new System.Drawing.Size(98, 20);
            this.dt_horasalida.TabIndex = 7;
            // 
            // dt_fechasalida
            // 
            this.dt_fechasalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_fechasalida.Location = new System.Drawing.Point(133, 111);
            this.dt_fechasalida.Name = "dt_fechasalida";
            this.dt_fechasalida.Size = new System.Drawing.Size(98, 20);
            this.dt_fechasalida.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha/Hora Salida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ciudad Destino";
            // 
            // cb_ciudaddestino
            // 
            this.cb_ciudaddestino.FormattingEnabled = true;
            this.cb_ciudaddestino.Location = new System.Drawing.Point(133, 70);
            this.cb_ciudaddestino.Name = "cb_ciudaddestino";
            this.cb_ciudaddestino.Size = new System.Drawing.Size(202, 21);
            this.cb_ciudaddestino.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ciudad Origen";
            // 
            // cb_ciudadorigen
            // 
            this.cb_ciudadorigen.FormattingEnabled = true;
            this.cb_ciudadorigen.Location = new System.Drawing.Point(133, 34);
            this.cb_ciudadorigen.Name = "cb_ciudadorigen";
            this.cb_ciudadorigen.Size = new System.Drawing.Size(202, 21);
            this.cb_ciudadorigen.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gv_vuelos);
            this.groupBox2.Location = new System.Drawing.Point(393, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 330);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles Vuelos";
            // 
            // gv_vuelos
            // 
            this.gv_vuelos.AllowUserToAddRows = false;
            this.gv_vuelos.AllowUserToDeleteRows = false;
            this.gv_vuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_vuelos.Location = new System.Drawing.Point(6, 19);
            this.gv_vuelos.Name = "gv_vuelos";
            this.gv_vuelos.ReadOnly = true;
            this.gv_vuelos.Size = new System.Drawing.Size(392, 286);
            this.gv_vuelos.TabIndex = 0;
            this.gv_vuelos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_vuelos_CellContentDoubleClick);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 381);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_vuelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ciudadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadosToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem actualizarInformacionToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dt_horasalida;
        private System.Windows.Forms.DateTimePicker dt_fechasalida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_ciudaddestino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_ciudadorigen;
        private System.Windows.Forms.ToolStripMenuItem aerolineaToolStripMenuItem;
        private System.Windows.Forms.Button btn_crear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_estados;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_aerolineas;
        private System.Windows.Forms.DateTimePicker dt_horallegada;
        private System.Windows.Forms.DateTimePicker dt_fechallegada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gv_vuelos;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
    }
}