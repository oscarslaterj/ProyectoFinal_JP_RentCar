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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rRenta));
            this.VehiculosDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Vehiculo = new System.Windows.Forms.Label();
            this.FiltroVehiculoComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FechaRegistroDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FerchaDevueltaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VehiculosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // VehiculosDataGridView
            // 
            this.VehiculosDataGridView.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.VehiculosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VehiculosDataGridView.Location = new System.Drawing.Point(12, 146);
            this.VehiculosDataGridView.Name = "VehiculosDataGridView";
            this.VehiculosDataGridView.Size = new System.Drawing.Size(865, 245);
            this.VehiculosDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 114);
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
            this.FiltroVehiculoComboBox.FormattingEnabled = true;
            this.FiltroVehiculoComboBox.Location = new System.Drawing.Point(15, 69);
            this.FiltroVehiculoComboBox.Name = "FiltroVehiculoComboBox";
            this.FiltroVehiculoComboBox.Size = new System.Drawing.Size(269, 21);
            this.FiltroVehiculoComboBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha Renta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(567, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha Devuelta";
            // 
            // FechaRegistroDateTimePicker
            // 
            this.FechaRegistroDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaRegistroDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaRegistroDateTimePicker.Location = new System.Drawing.Point(340, 70);
            this.FechaRegistroDateTimePicker.Name = "FechaRegistroDateTimePicker";
            this.FechaRegistroDateTimePicker.Size = new System.Drawing.Size(137, 20);
            this.FechaRegistroDateTimePicker.TabIndex = 26;
            // 
            // FerchaDevueltaDateTimePicker
            // 
            this.FerchaDevueltaDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FerchaDevueltaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FerchaDevueltaDateTimePicker.Location = new System.Drawing.Point(570, 66);
            this.FerchaDevueltaDateTimePicker.Name = "FerchaDevueltaDateTimePicker";
            this.FerchaDevueltaDateTimePicker.Size = new System.Drawing.Size(137, 20);
            this.FerchaDevueltaDateTimePicker.TabIndex = 27;
            // 
            // AgregarButton
            // 
            this.AgregarButton.BackColor = System.Drawing.Color.White;
            this.AgregarButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AgregarButton.Image = ((System.Drawing.Image)(resources.GetObject("AgregarButton.Image")));
            this.AgregarButton.Location = new System.Drawing.Point(766, 51);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(90, 39);
            this.AgregarButton.TabIndex = 28;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AgregarButton.UseVisualStyleBackColor = false;
            // 
            // EliminarButton
            // 
            this.EliminarButton.BackColor = System.Drawing.Color.Red;
            this.EliminarButton.Location = new System.Drawing.Point(750, 397);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(117, 23);
            this.EliminarButton.TabIndex = 29;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = false;
            // 
            // rRenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(901, 450);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.FerchaDevueltaDateTimePicker);
            this.Controls.Add(this.FechaRegistroDateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FiltroVehiculoComboBox);
            this.Controls.Add(this.Vehiculo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VehiculosDataGridView);
            this.Name = "rRenta";
            this.Text = "rRenta";
            ((System.ComponentModel.ISupportInitialize)(this.VehiculosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView VehiculosDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Vehiculo;
        private System.Windows.Forms.ComboBox FiltroVehiculoComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker FechaRegistroDateTimePicker;
        private System.Windows.Forms.DateTimePicker FerchaDevueltaDateTimePicker;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Button EliminarButton;
    }
}