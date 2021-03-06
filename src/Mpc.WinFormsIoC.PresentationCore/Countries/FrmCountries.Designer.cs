﻿namespace Mpc.WinFormsIoC.PresentationCore.Countries
{
    partial class FrmCountryList
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
            this.dgvCountries = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCountries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryDtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCountries
            // 
            this.dgvCountries.AutoGenerateColumns = false;
            this.dgvCountries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCountries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dgvCountries.DataSource = this.countryDtoBindingSource;
            this.dgvCountries.Location = new System.Drawing.Point(8, 8);
            this.dgvCountries.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCountries.Name = "dgvCountries";
            this.dgvCountries.RowTemplate.Height = 28;
            this.dgvCountries.Size = new System.Drawing.Size(517, 277);
            this.dgvCountries.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // countryDtoBindingSource
            // 
            this.countryDtoBindingSource.DataSource = typeof(Mpc.WinFormsIoC.Application.Dto.CountryDto);
            // 
            // FrmCountryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.dgvCountries);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCountryList";
            this.Text = "FrmCountries";
            this.Load += new System.EventHandler(this.FrmCountryList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCountries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryDtoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCountries;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource countryDtoBindingSource;
    }
}