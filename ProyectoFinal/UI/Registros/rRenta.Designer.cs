namespace ProyectoFinal.UI.Registros
{
    partial class rRenta
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rRenta));
            this.DetalleDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Vehiculo = new System.Windows.Forms.Label();
            this.FiltroVehiculoComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FechaRegistroDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FechaDevueltaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EliminarDetalleButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ClientecomboBox = new System.Windows.Forms.ComboBox();
            this.RentarButton = new System.Windows.Forms.Button();
            this.AgregarDetalleButton = new System.Windows.Forms.Button();
            this.DetalleIDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.RentaIDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.PlacaTextBox = new System.Windows.Forms.TextBox();
            this.MarcaTextBox = new System.Windows.Forms.TextBox();
            this.ModeloTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.PrecioNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DateTimePickerF = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.AnioTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleIDnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentaIDnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // DetalleDataGridView
            // 
            this.DetalleDataGridView.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.DetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalleDataGridView.Location = new System.Drawing.Point(12, 224);
            this.DetalleDataGridView.Name = "DetalleDataGridView";
            this.DetalleDataGridView.Size = new System.Drawing.Size(865, 245);
            this.DetalleDataGridView.TabIndex = 0;
            this.DetalleDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VehiculosDataGridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vehiculos Rentados";
            // 
            // Vehiculo
            // 
            this.Vehiculo.AutoSize = true;
            this.Vehiculo.Location = new System.Drawing.Point(12, 38);
            this.Vehiculo.Name = "Vehiculo";
            this.Vehiculo.Size = new System.Drawing.Size(48, 13);
            this.Vehiculo.TabIndex = 3;
            this.Vehiculo.Text = "Vehiculo";
            // 
            // FiltroVehiculoComboBox
            // 
            this.FiltroVehiculoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltroVehiculoComboBox.FormattingEnabled = true;
            this.FiltroVehiculoComboBox.Location = new System.Drawing.Point(99, 30);
            this.FiltroVehiculoComboBox.Name = "FiltroVehiculoComboBox";
            this.FiltroVehiculoComboBox.Size = new System.Drawing.Size(269, 21);
            this.FiltroVehiculoComboBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha Renta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha Devuelta";
            // 
            // FechaRegistroDateTimePicker
            // 
            this.FechaRegistroDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaRegistroDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaRegistroDateTimePicker.Location = new System.Drawing.Point(99, 97);
            this.FechaRegistroDateTimePicker.Name = "FechaRegistroDateTimePicker";
            this.FechaRegistroDateTimePicker.Size = new System.Drawing.Size(137, 20);
            this.FechaRegistroDateTimePicker.TabIndex = 26;
            // 
            // FechaDevueltaDateTimePicker
            // 
            this.FechaDevueltaDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaDevueltaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaDevueltaDateTimePicker.Location = new System.Drawing.Point(99, 130);
            this.FechaDevueltaDateTimePicker.Name = "FechaDevueltaDateTimePicker";
            this.FechaDevueltaDateTimePicker.Size = new System.Drawing.Size(137, 20);
            this.FechaDevueltaDateTimePicker.TabIndex = 27;
            // 
            // EliminarDetalleButton
            // 
            this.EliminarDetalleButton.BackColor = System.Drawing.Color.Red;
            this.EliminarDetalleButton.Location = new System.Drawing.Point(760, 475);
            this.EliminarDetalleButton.Name = "EliminarDetalleButton";
            this.EliminarDetalleButton.Size = new System.Drawing.Size(117, 23);
            this.EliminarDetalleButton.TabIndex = 29;
            this.EliminarDetalleButton.Text = "Eliminar";
            this.EliminarDetalleButton.UseVisualStyleBackColor = false;
            this.EliminarDetalleButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Cliente";
            // 
            // ClientecomboBox
            // 
            this.ClientecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClientecomboBox.FormattingEnabled = true;
            this.ClientecomboBox.Location = new System.Drawing.Point(99, 66);
            this.ClientecomboBox.Name = "ClientecomboBox";
            this.ClientecomboBox.Size = new System.Drawing.Size(269, 21);
            this.ClientecomboBox.TabIndex = 31;
            this.ClientecomboBox.SelectedValueChanged += new System.EventHandler(this.ClientecomboBox_SelectedValueChanged);
            // 
            // RentarButton
            // 
            this.RentarButton.BackColor = System.Drawing.Color.White;
            this.RentarButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RentarButton.Image = ((System.Drawing.Image)(resources.GetObject("RentarButton.Image")));
            this.RentarButton.Location = new System.Drawing.Point(733, 11);
            this.RentarButton.Name = "RentarButton";
            this.RentarButton.Size = new System.Drawing.Size(144, 85);
            this.RentarButton.TabIndex = 28;
            this.RentarButton.Text = "Rentar";
            this.RentarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.RentarButton.UseVisualStyleBackColor = false;
            this.RentarButton.Click += new System.EventHandler(this.RentarButton_Click);
            // 
            // AgregarDetalleButton
            // 
            this.AgregarDetalleButton.Location = new System.Drawing.Point(746, 195);
            this.AgregarDetalleButton.Name = "AgregarDetalleButton";
            this.AgregarDetalleButton.Size = new System.Drawing.Size(131, 23);
            this.AgregarDetalleButton.TabIndex = 32;
            this.AgregarDetalleButton.Text = "Agregar Carro";
            this.AgregarDetalleButton.UseVisualStyleBackColor = true;
            this.AgregarDetalleButton.Click += new System.EventHandler(this.AgregarDetalleButton_Click);
            // 
            // DetalleIDnumericUpDown
            // 
            this.DetalleIDnumericUpDown.Location = new System.Drawing.Point(241, 198);
            this.DetalleIDnumericUpDown.Name = "DetalleIDnumericUpDown";
            this.DetalleIDnumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.DetalleIDnumericUpDown.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "ID Detalle";
            // 
            // RentaIDnumericUpDown
            // 
            this.RentaIDnumericUpDown.Location = new System.Drawing.Point(99, 4);
            this.RentaIDnumericUpDown.Name = "RentaIDnumericUpDown";
            this.RentaIDnumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.RentaIDnumericUpDown.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "REnta ID";
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // PlacaTextBox
            // 
            this.PlacaTextBox.Enabled = false;
            this.PlacaTextBox.Location = new System.Drawing.Point(499, 88);
            this.PlacaTextBox.Name = "PlacaTextBox";
            this.PlacaTextBox.Size = new System.Drawing.Size(119, 20);
            this.PlacaTextBox.TabIndex = 42;
            // 
            // MarcaTextBox
            // 
            this.MarcaTextBox.Enabled = false;
            this.MarcaTextBox.Location = new System.Drawing.Point(499, 30);
            this.MarcaTextBox.Name = "MarcaTextBox";
            this.MarcaTextBox.Size = new System.Drawing.Size(182, 20);
            this.MarcaTextBox.TabIndex = 41;
            // 
            // ModeloTextBox
            // 
            this.ModeloTextBox.Enabled = false;
            this.ModeloTextBox.Location = new System.Drawing.Point(499, 59);
            this.ModeloTextBox.Name = "ModeloTextBox";
            this.ModeloTextBox.Size = new System.Drawing.Size(182, 20);
            this.ModeloTextBox.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(415, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Placa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(415, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Marca";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(415, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Modelo";
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Enabled = false;
            this.DescripcionTextBox.Location = new System.Drawing.Point(499, 114);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(253, 20);
            this.DescripcionTextBox.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(415, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Descripcion";
            // 
            // PrecioNumericUpDown
            // 
            this.PrecioNumericUpDown.Enabled = false;
            this.PrecioNumericUpDown.Location = new System.Drawing.Point(499, 145);
            this.PrecioNumericUpDown.Name = "PrecioNumericUpDown";
            this.PrecioNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.PrecioNumericUpDown.TabIndex = 48;
            // 
            // DateTimePickerF
            // 
            this.DateTimePickerF.CustomFormat = "dd/MM/yyyy";
            this.DateTimePickerF.Enabled = false;
            this.DateTimePickerF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePickerF.Location = new System.Drawing.Point(499, 171);
            this.DateTimePickerF.Name = "DateTimePickerF";
            this.DateTimePickerF.Size = new System.Drawing.Size(118, 20);
            this.DateTimePickerF.TabIndex = 47;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(415, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = "Fecha Registro";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(415, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 45;
            this.label12.Text = "Precio Renta";
            // 
            // AnioTextBox
            // 
            this.AnioTextBox.Enabled = false;
            this.AnioTextBox.Location = new System.Drawing.Point(500, 4);
            this.AnioTextBox.Name = "AnioTextBox";
            this.AnioTextBox.Size = new System.Drawing.Size(119, 20);
            this.AnioTextBox.TabIndex = 50;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(416, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 13);
            this.label13.TabIndex = 49;
            this.label13.Text = "Año";
            // 
            // EliminarButton
            // 
            this.EliminarButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.EliminarButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.Location = new System.Drawing.Point(485, 493);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(89, 52);
            this.EliminarButton.TabIndex = 53;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EliminarButton.UseVisualStyleBackColor = false;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click_1);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.NuevoButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NuevoButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoButton.Image")));
            this.NuevoButton.Location = new System.Drawing.Point(272, 493);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(89, 52);
            this.NuevoButton.TabIndex = 52;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevoButton.UseVisualStyleBackColor = false;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.GuardarButton.BackColor = System.Drawing.Color.White;
            this.GuardarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButton.Image")));
            this.GuardarButton.Location = new System.Drawing.Point(378, 493);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(89, 52);
            this.GuardarButton.TabIndex = 51;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.GuardarButton.UseVisualStyleBackColor = false;
            // 
            // rRenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(901, 555);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.AnioTextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.PrecioNumericUpDown);
            this.Controls.Add(this.DateTimePickerF);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PlacaTextBox);
            this.Controls.Add(this.MarcaTextBox);
            this.Controls.Add(this.ModeloTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RentaIDnumericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DetalleIDnumericUpDown);
            this.Controls.Add(this.AgregarDetalleButton);
            this.Controls.Add(this.ClientecomboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EliminarDetalleButton);
            this.Controls.Add(this.RentarButton);
            this.Controls.Add(this.FechaDevueltaDateTimePicker);
            this.Controls.Add(this.FechaRegistroDateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FiltroVehiculoComboBox);
            this.Controls.Add(this.Vehiculo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DetalleDataGridView);
            this.MaximizeBox = false;
            this.Name = "rRenta";
            this.Text = "rRenta";
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleIDnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentaIDnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DetalleDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Vehiculo;
        private System.Windows.Forms.ComboBox FiltroVehiculoComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker FechaRegistroDateTimePicker;
        private System.Windows.Forms.DateTimePicker FechaDevueltaDateTimePicker;
        private System.Windows.Forms.Button RentarButton;
        private System.Windows.Forms.Button EliminarDetalleButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ClientecomboBox;
        private System.Windows.Forms.Button AgregarDetalleButton;
        private System.Windows.Forms.NumericUpDown DetalleIDnumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown RentaIDnumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.TextBox PlacaTextBox;
        private System.Windows.Forms.TextBox MarcaTextBox;
        private System.Windows.Forms.TextBox ModeloTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown PrecioNumericUpDown;
        private System.Windows.Forms.DateTimePicker DateTimePickerF;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox AnioTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
    }
}