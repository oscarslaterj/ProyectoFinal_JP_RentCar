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
            this.EliminarButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.RentarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VehiculosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // VehiculosDataGridView
            // 
            this.VehiculosDataGridView.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.VehiculosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VehiculosDataGridView.Location = new System.Drawing.Point(12, 193);
            this.VehiculosDataGridView.Name = "VehiculosDataGridView";
            this.VehiculosDataGridView.Size = new System.Drawing.Size(865, 245);
            this.VehiculosDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 176);
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
            // FerchaDevueltaDateTimePicker
            // 
            this.FerchaDevueltaDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FerchaDevueltaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FerchaDevueltaDateTimePicker.Location = new System.Drawing.Point(99, 130);
            this.FerchaDevueltaDateTimePicker.Name = "FerchaDevueltaDateTimePicker";
            this.FerchaDevueltaDateTimePicker.Size = new System.Drawing.Size(137, 20);
            this.FerchaDevueltaDateTimePicker.TabIndex = 27;
            // 
            // EliminarButton
            // 
            this.EliminarButton.BackColor = System.Drawing.Color.Red;
            this.EliminarButton.Location = new System.Drawing.Point(760, 444);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(117, 23);
            this.EliminarButton.TabIndex = 29;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = false;
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(99, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(269, 21);
            this.comboBox1.TabIndex = 31;
            // 
            // RentarButton
            // 
            this.RentarButton.BackColor = System.Drawing.Color.White;
            this.RentarButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RentarButton.Image = ((System.Drawing.Image)(resources.GetObject("RentarButton.Image")));
            this.RentarButton.Location = new System.Drawing.Point(406, 32);
            this.RentarButton.Name = "RentarButton";
            this.RentarButton.Size = new System.Drawing.Size(144, 85);
            this.RentarButton.TabIndex = 28;
            this.RentarButton.Text = "Rentar";
            this.RentarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.RentarButton.UseVisualStyleBackColor = false;
            // 
            // rRenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(901, 474);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.RentarButton);
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
        private System.Windows.Forms.Button RentarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}