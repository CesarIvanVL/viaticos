namespace Viaticos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_NºEmp = new System.Windows.Forms.Label();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.lbl_depto = new System.Windows.Forms.Label();
            this.lbl_folio = new System.Windows.Forms.Label();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.lblSP = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.txtNumEmpleado = new System.Windows.Forms.TextBox();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDpto = new System.Windows.Forms.TextBox();
            this.btnNumEmpleado = new System.Windows.Forms.Button();
            this.btnFolio = new System.Windows.Forms.Button();
            this.txtSP = new System.Windows.Forms.TextBox();
            this.cboEstatus = new System.Windows.Forms.ComboBox();
            this.gboComision = new System.Windows.Forms.GroupBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblObs = new System.Windows.Forms.Label();
            this.lblKms = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.rdbViajeRedondo = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dgvComision = new System.Windows.Forms.DataGridView();
            this.txtKms = new System.Windows.Forms.TextBox();
            this.txtTotalSolicitud = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnAsociarGto = new System.Windows.Forms.Button();
            this.lblTarifa = new System.Windows.Forms.Label();
            this.cboTarifa = new System.Windows.Forms.ComboBox();
            this.lblConcepto = new System.Windows.Forms.Label();
            this.cboConcepto = new System.Windows.Forms.ComboBox();
            this.btnGenerarComision = new System.Windows.Forms.Button();
            this.btnEliminarComision = new System.Windows.Forms.Button();
            this.btnEliminarConcepto = new System.Windows.Forms.Button();
            this.btnGenerarConcepto = new System.Windows.Forms.Button();
            this.rbo_agregarTodasComisiones = new System.Windows.Forms.RadioButton();
            this.dgvConceptosGasto = new System.Windows.Forms.DataGridView();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtObservacionesConcepto = new System.Windows.Forms.TextBox();
            this.gboComision.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConceptosGasto)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_NºEmp
            // 
            this.lbl_NºEmp.AutoSize = true;
            this.lbl_NºEmp.Location = new System.Drawing.Point(14, 13);
            this.lbl_NºEmp.Name = "lbl_NºEmp";
            this.lbl_NºEmp.Size = new System.Drawing.Size(43, 13);
            this.lbl_NºEmp.TabIndex = 0;
            this.lbl_NºEmp.Text = "Nº Emp";
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Location = new System.Drawing.Point(13, 38);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(44, 13);
            this.lbl_nom.TabIndex = 1;
            this.lbl_nom.Text = "Nombre";
            // 
            // lbl_depto
            // 
            this.lbl_depto.AutoSize = true;
            this.lbl_depto.Location = new System.Drawing.Point(21, 64);
            this.lbl_depto.Name = "lbl_depto";
            this.lbl_depto.Size = new System.Drawing.Size(36, 13);
            this.lbl_depto.TabIndex = 2;
            this.lbl_depto.Text = "Depto";
            // 
            // lbl_folio
            // 
            this.lbl_folio.AutoSize = true;
            this.lbl_folio.Location = new System.Drawing.Point(276, 14);
            this.lbl_folio.Name = "lbl_folio";
            this.lbl_folio.Size = new System.Drawing.Size(29, 13);
            this.lbl_folio.TabIndex = 3;
            this.lbl_folio.Text = "Folio";
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.Location = new System.Drawing.Point(509, 14);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(42, 13);
            this.lblEstatus.TabIndex = 4;
            this.lblEstatus.Text = "Estatus";
            // 
            // lblSP
            // 
            this.lblSP.AutoSize = true;
            this.lblSP.Location = new System.Drawing.Point(530, 38);
            this.lblSP.Name = "lblSP";
            this.lblSP.Size = new System.Drawing.Size(27, 13);
            this.lblSP.TabIndex = 5;
            this.lblSP.Text = "S.P.";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(6, 27);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(38, 13);
            this.lblOrigen.TabIndex = 6;
            this.lblOrigen.Text = "Origen";
            // 
            // txtNumEmpleado
            // 
            this.txtNumEmpleado.Location = new System.Drawing.Point(62, 10);
            this.txtNumEmpleado.Name = "txtNumEmpleado";
            this.txtNumEmpleado.Size = new System.Drawing.Size(74, 20);
            this.txtNumEmpleado.TabIndex = 7;
            // 
            // txtFolio
            // 
            this.txtFolio.Location = new System.Drawing.Point(311, 9);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(69, 20);
            this.txtFolio.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(62, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(358, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // txtDpto
            // 
            this.txtDpto.Location = new System.Drawing.Point(62, 61);
            this.txtDpto.Name = "txtDpto";
            this.txtDpto.Size = new System.Drawing.Size(358, 20);
            this.txtDpto.TabIndex = 10;
            // 
            // btnNumEmpleado
            // 
            this.btnNumEmpleado.Location = new System.Drawing.Point(142, 10);
            this.btnNumEmpleado.Name = "btnNumEmpleado";
            this.btnNumEmpleado.Size = new System.Drawing.Size(34, 21);
            this.btnNumEmpleado.TabIndex = 11;
            this.btnNumEmpleado.Text = "...";
            this.btnNumEmpleado.UseVisualStyleBackColor = true;
            // 
            // btnFolio
            // 
            this.btnFolio.Location = new System.Drawing.Point(386, 7);
            this.btnFolio.Name = "btnFolio";
            this.btnFolio.Size = new System.Drawing.Size(34, 21);
            this.btnFolio.TabIndex = 12;
            this.btnFolio.Text = "...";
            this.btnFolio.UseVisualStyleBackColor = true;
            // 
            // txtSP
            // 
            this.txtSP.Location = new System.Drawing.Point(563, 35);
            this.txtSP.Name = "txtSP";
            this.txtSP.Size = new System.Drawing.Size(91, 20);
            this.txtSP.TabIndex = 13;
            // 
            // cboEstatus
            // 
            this.cboEstatus.FormattingEnabled = true;
            this.cboEstatus.Location = new System.Drawing.Point(564, 10);
            this.cboEstatus.Name = "cboEstatus";
            this.cboEstatus.Size = new System.Drawing.Size(90, 21);
            this.cboEstatus.TabIndex = 14;
            // 
            // gboComision
            // 
            this.gboComision.Controls.Add(this.txtObservacionesConcepto);
            this.gboComision.Controls.Add(this.lblObservaciones);
            this.gboComision.Controls.Add(this.dgvConceptosGasto);
            this.gboComision.Controls.Add(this.rbo_agregarTodasComisiones);
            this.gboComision.Controls.Add(this.btnGenerarConcepto);
            this.gboComision.Controls.Add(this.btnEliminarConcepto);
            this.gboComision.Controls.Add(this.btnEliminarComision);
            this.gboComision.Controls.Add(this.btnGenerarComision);
            this.gboComision.Controls.Add(this.cboConcepto);
            this.gboComision.Controls.Add(this.lblConcepto);
            this.gboComision.Controls.Add(this.cboTarifa);
            this.gboComision.Controls.Add(this.lblTarifa);
            this.gboComision.Controls.Add(this.txtTotalSolicitud);
            this.gboComision.Controls.Add(this.txtKms);
            this.gboComision.Controls.Add(this.dgvComision);
            this.gboComision.Controls.Add(this.dtpFechaFin);
            this.gboComision.Controls.Add(this.dtpFechaInicio);
            this.gboComision.Controls.Add(this.textBox1);
            this.gboComision.Controls.Add(this.rdbViajeRedondo);
            this.gboComision.Controls.Add(this.lblTotal);
            this.gboComision.Controls.Add(this.lblKms);
            this.gboComision.Controls.Add(this.lblObs);
            this.gboComision.Controls.Add(this.lblFechaFin);
            this.gboComision.Controls.Add(this.lblFecha);
            this.gboComision.Controls.Add(this.comboBox3);
            this.gboComision.Controls.Add(this.comboBox2);
            this.gboComision.Controls.Add(this.comboBox1);
            this.gboComision.Controls.Add(this.lblDestino);
            this.gboComision.Controls.Add(this.lblTipo);
            this.gboComision.Controls.Add(this.lblOrigen);
            this.gboComision.Location = new System.Drawing.Point(24, 96);
            this.gboComision.Name = "gboComision";
            this.gboComision.Size = new System.Drawing.Size(731, 465);
            this.gboComision.TabIndex = 15;
            this.gboComision.TabStop = false;
            this.gboComision.Text = "Comision";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(21, 82);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 7;
            this.lblTipo.Text = "Tipo";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(6, 54);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(43, 13);
            this.lblDestino.TabIndex = 8;
            this.lblDestino.Text = "Destino";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(50, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(102, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(50, 78);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(102, 21);
            this.comboBox2.TabIndex = 17;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(50, 51);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(102, 21);
            this.comboBox3.TabIndex = 18;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(332, 21);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(64, 13);
            this.lblFecha.TabIndex = 19;
            this.lblFecha.Text = "Fecha inicio";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(345, 47);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(51, 13);
            this.lblFechaFin.TabIndex = 20;
            this.lblFechaFin.Text = "Fecha fin";
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(11, 126);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(29, 13);
            this.lblObs.TabIndex = 21;
            this.lblObs.Text = "Obs.";
            // 
            // lblKms
            // 
            this.lblKms.AutoSize = true;
            this.lblKms.Location = new System.Drawing.Point(207, 233);
            this.lblKms.Name = "lblKms";
            this.lblKms.Size = new System.Drawing.Size(27, 13);
            this.lblKms.TabIndex = 22;
            this.lblKms.Text = "Kms";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(469, 233);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(72, 13);
            this.lblTotal.TabIndex = 23;
            this.lblTotal.Text = "Total solicitud";
            // 
            // rdbViajeRedondo
            // 
            this.rdbViajeRedondo.AutoSize = true;
            this.rdbViajeRedondo.Location = new System.Drawing.Point(350, 69);
            this.rdbViajeRedondo.Name = "rdbViajeRedondo";
            this.rdbViajeRedondo.Size = new System.Drawing.Size(90, 17);
            this.rdbViajeRedondo.TabIndex = 24;
            this.rdbViajeRedondo.TabStop = true;
            this.rdbViajeRedondo.Text = "Viaje redondo";
            this.rdbViajeRedondo.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 123);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(597, 20);
            this.textBox1.TabIndex = 16;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(402, 15);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(103, 20);
            this.dtpFechaInicio.TabIndex = 25;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(402, 43);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(103, 20);
            this.dtpFechaFin.TabIndex = 26;
            // 
            // dgvComision
            // 
            this.dgvComision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComision.Location = new System.Drawing.Point(24, 149);
            this.dgvComision.Name = "dgvComision";
            this.dgvComision.Size = new System.Drawing.Size(611, 80);
            this.dgvComision.TabIndex = 27;
            // 
            // txtKms
            // 
            this.txtKms.Location = new System.Drawing.Point(240, 230);
            this.txtKms.Name = "txtKms";
            this.txtKms.Size = new System.Drawing.Size(38, 20);
            this.txtKms.TabIndex = 16;
            // 
            // txtTotalSolicitud
            // 
            this.txtTotalSolicitud.Location = new System.Drawing.Point(547, 230);
            this.txtTotalSolicitud.Name = "txtTotalSolicitud";
            this.txtTotalSolicitud.Size = new System.Drawing.Size(88, 20);
            this.txtTotalSolicitud.TabIndex = 28;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(130, 568);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(102, 25);
            this.btnNuevo.TabIndex = 18;
            this.btnNuevo.Text = "Nueva";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(346, 567);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(102, 25);
            this.btnImprimir.TabIndex = 29;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(238, 567);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(102, 25);
            this.btnGuardar.TabIndex = 30;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(571, 567);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(102, 25);
            this.btnCerrar.TabIndex = 31;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnAsociarGto
            // 
            this.btnAsociarGto.Location = new System.Drawing.Point(454, 567);
            this.btnAsociarGto.Name = "btnAsociarGto";
            this.btnAsociarGto.Size = new System.Drawing.Size(111, 25);
            this.btnAsociarGto.TabIndex = 32;
            this.btnAsociarGto.Text = "Asociar Gto x Comp";
            this.btnAsociarGto.UseVisualStyleBackColor = true;
            // 
            // lblTarifa
            // 
            this.lblTarifa.AutoSize = true;
            this.lblTarifa.Location = new System.Drawing.Point(10, 284);
            this.lblTarifa.Name = "lblTarifa";
            this.lblTarifa.Size = new System.Drawing.Size(34, 13);
            this.lblTarifa.TabIndex = 33;
            this.lblTarifa.Text = "Tarifa";
            // 
            // cboTarifa
            // 
            this.cboTarifa.FormattingEnabled = true;
            this.cboTarifa.Location = new System.Drawing.Point(50, 281);
            this.cboTarifa.Name = "cboTarifa";
            this.cboTarifa.Size = new System.Drawing.Size(102, 21);
            this.cboTarifa.TabIndex = 34;
            // 
            // lblConcepto
            // 
            this.lblConcepto.AutoSize = true;
            this.lblConcepto.Location = new System.Drawing.Point(197, 284);
            this.lblConcepto.Name = "lblConcepto";
            this.lblConcepto.Size = new System.Drawing.Size(53, 13);
            this.lblConcepto.TabIndex = 35;
            this.lblConcepto.Text = "Concepto";
            // 
            // cboConcepto
            // 
            this.cboConcepto.FormattingEnabled = true;
            this.cboConcepto.Location = new System.Drawing.Point(254, 281);
            this.cboConcepto.Name = "cboConcepto";
            this.cboConcepto.Size = new System.Drawing.Size(129, 21);
            this.cboConcepto.TabIndex = 36;
            // 
            // btnGenerarComision
            // 
            this.btnGenerarComision.Location = new System.Drawing.Point(425, 92);
            this.btnGenerarComision.Name = "btnGenerarComision";
            this.btnGenerarComision.Size = new System.Drawing.Size(102, 25);
            this.btnGenerarComision.TabIndex = 37;
            this.btnGenerarComision.Text = "Generar comision";
            this.btnGenerarComision.UseVisualStyleBackColor = true;
            // 
            // btnEliminarComision
            // 
            this.btnEliminarComision.Location = new System.Drawing.Point(533, 92);
            this.btnEliminarComision.Name = "btnEliminarComision";
            this.btnEliminarComision.Size = new System.Drawing.Size(102, 25);
            this.btnEliminarComision.TabIndex = 38;
            this.btnEliminarComision.Text = "Eliminar comision";
            this.btnEliminarComision.UseVisualStyleBackColor = true;
            // 
            // btnEliminarConcepto
            // 
            this.btnEliminarConcepto.Location = new System.Drawing.Point(533, 278);
            this.btnEliminarConcepto.Name = "btnEliminarConcepto";
            this.btnEliminarConcepto.Size = new System.Drawing.Size(102, 25);
            this.btnEliminarConcepto.TabIndex = 39;
            this.btnEliminarConcepto.Text = "Eliminar concepto";
            this.btnEliminarConcepto.UseVisualStyleBackColor = true;
            // 
            // btnGenerarConcepto
            // 
            this.btnGenerarConcepto.Location = new System.Drawing.Point(425, 277);
            this.btnGenerarConcepto.Name = "btnGenerarConcepto";
            this.btnGenerarConcepto.Size = new System.Drawing.Size(102, 25);
            this.btnGenerarConcepto.TabIndex = 40;
            this.btnGenerarConcepto.Text = "Generar concepto";
            this.btnGenerarConcepto.UseVisualStyleBackColor = true;
            // 
            // rbo_agregarTodasComisiones
            // 
            this.rbo_agregarTodasComisiones.AutoSize = true;
            this.rbo_agregarTodasComisiones.Location = new System.Drawing.Point(473, 308);
            this.rbo_agregarTodasComisiones.Name = "rbo_agregarTodasComisiones";
            this.rbo_agregarTodasComisiones.Size = new System.Drawing.Size(162, 17);
            this.rbo_agregarTodasComisiones.TabIndex = 41;
            this.rbo_agregarTodasComisiones.TabStop = true;
            this.rbo_agregarTodasComisiones.Text = "Agregar todas las comisiones";
            this.rbo_agregarTodasComisiones.UseVisualStyleBackColor = true;
            // 
            // dgvConceptosGasto
            // 
            this.dgvConceptosGasto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConceptosGasto.Location = new System.Drawing.Point(38, 328);
            this.dgvConceptosGasto.Name = "dgvConceptosGasto";
            this.dgvConceptosGasto.Size = new System.Drawing.Size(611, 80);
            this.dgvConceptosGasto.TabIndex = 42;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(11, 417);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(78, 13);
            this.lblObservaciones.TabIndex = 43;
            this.lblObservaciones.Text = "Observaciones";
            // 
            // txtObservacionesConcepto
            // 
            this.txtObservacionesConcepto.Location = new System.Drawing.Point(95, 414);
            this.txtObservacionesConcepto.Name = "txtObservacionesConcepto";
            this.txtObservacionesConcepto.Size = new System.Drawing.Size(554, 20);
            this.txtObservacionesConcepto.TabIndex = 44;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 605);
            this.Controls.Add(this.gboComision);
            this.Controls.Add(this.cboEstatus);
            this.Controls.Add(this.txtSP);
            this.Controls.Add(this.btnFolio);
            this.Controls.Add(this.btnNumEmpleado);
            this.Controls.Add(this.txtDpto);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtFolio);
            this.Controls.Add(this.txtNumEmpleado);
            this.Controls.Add(this.lblSP);
            this.Controls.Add(this.lblEstatus);
            this.Controls.Add(this.lbl_folio);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAsociarGto);
            this.Controls.Add(this.lbl_depto);
            this.Controls.Add(this.lbl_nom);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lbl_NºEmp);
            this.Controls.Add(this.btnNuevo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gboComision.ResumeLayout(false);
            this.gboComision.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConceptosGasto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_NºEmp;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.Label lbl_depto;
        private System.Windows.Forms.Label lbl_folio;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.Label lblSP;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.TextBox txtNumEmpleado;
        private System.Windows.Forms.TextBox txtFolio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDpto;
        private System.Windows.Forms.Button btnNumEmpleado;
        private System.Windows.Forms.Button btnFolio;
        private System.Windows.Forms.TextBox txtSP;
        private System.Windows.Forms.ComboBox cboEstatus;
        private System.Windows.Forms.GroupBox gboComision;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rdbViajeRedondo;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblKms;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.DataGridView dgvComision;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.TextBox txtKms;
        private System.Windows.Forms.TextBox txtObservacionesConcepto;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.DataGridView dgvConceptosGasto;
        private System.Windows.Forms.RadioButton rbo_agregarTodasComisiones;
        private System.Windows.Forms.Button btnGenerarConcepto;
        private System.Windows.Forms.Button btnEliminarConcepto;
        private System.Windows.Forms.Button btnEliminarComision;
        private System.Windows.Forms.Button btnGenerarComision;
        private System.Windows.Forms.ComboBox cboConcepto;
        private System.Windows.Forms.Label lblConcepto;
        private System.Windows.Forms.ComboBox cboTarifa;
        private System.Windows.Forms.Label lblTarifa;
        private System.Windows.Forms.TextBox txtTotalSolicitud;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnAsociarGto;
    }
}

