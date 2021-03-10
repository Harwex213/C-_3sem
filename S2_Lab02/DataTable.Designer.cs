using System.ComponentModel;
using System.Windows.Forms;

namespace S2_Lab02
{
    partial class DataTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnDataRelease = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnDataTechService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnLoadCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnCrewAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.dataGridViewTextBoxColumnID, this.dataGridViewTextBoxColumnType, this.dataGridViewTextBoxColumnModel, this.dataGridViewTextBoxColumnDataRelease, this.dataGridViewTextBoxColumnDataTechService, this.dataGridViewTextBoxColumnLoadCapacity, this.dataGridViewTextBoxColumnCrewAmount});
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.dataGridView.MinimumSize = new System.Drawing.Size(100, 100);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(709, 475);
            this.dataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumnID
            // 
            this.dataGridViewTextBoxColumnID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumnID.HeaderText = "ID";
            this.dataGridViewTextBoxColumnID.Name = "dataGridViewTextBoxColumnID";
            this.dataGridViewTextBoxColumnID.Width = 45;
            // 
            // dataGridViewTextBoxColumnType
            // 
            this.dataGridViewTextBoxColumnType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumnType.HeaderText = "Type";
            this.dataGridViewTextBoxColumnType.Name = "dataGridViewTextBoxColumnType";
            this.dataGridViewTextBoxColumnType.Width = 64;
            // 
            // dataGridViewTextBoxColumnModel
            // 
            this.dataGridViewTextBoxColumnModel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumnModel.HeaderText = "Model";
            this.dataGridViewTextBoxColumnModel.Name = "dataGridViewTextBoxColumnModel";
            this.dataGridViewTextBoxColumnModel.Width = 70;
            // 
            // dataGridViewTextBoxColumnDataRelease
            // 
            this.dataGridViewTextBoxColumnDataRelease.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumnDataRelease.HeaderText = "DataRelease";
            this.dataGridViewTextBoxColumnDataRelease.Name = "dataGridViewTextBoxColumnDataRelease";
            this.dataGridViewTextBoxColumnDataRelease.Width = 113;
            // 
            // dataGridViewTextBoxColumnDataTechService
            // 
            this.dataGridViewTextBoxColumnDataTechService.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumnDataTechService.HeaderText = "DataTechService";
            this.dataGridViewTextBoxColumnDataTechService.Name = "dataGridViewTextBoxColumnDataTechService";
            this.dataGridViewTextBoxColumnDataTechService.Width = 138;
            // 
            // dataGridViewTextBoxColumnLoadCapacity
            // 
            this.dataGridViewTextBoxColumnLoadCapacity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumnLoadCapacity.HeaderText = "LoadCapacity";
            this.dataGridViewTextBoxColumnLoadCapacity.Name = "dataGridViewTextBoxColumnLoadCapacity";
            this.dataGridViewTextBoxColumnLoadCapacity.Width = 116;
            // 
            // dataGridViewTextBoxColumnCrewAmount
            // 
            this.dataGridViewTextBoxColumnCrewAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumnCrewAmount.HeaderText = "CrewAmount";
            this.dataGridViewTextBoxColumnCrewAmount.Name = "dataGridViewTextBoxColumnCrewAmount";
            this.dataGridViewTextBoxColumnCrewAmount.Width = 107;
            // 
            // DataTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 499);
            this.Controls.Add(this.dataGridView);
            this.Name = "DataTable";
            this.Text = "DataTable";
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnDataRelease;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnDataTechService;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnLoadCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnCrewAmount;

        private System.Windows.Forms.DataGridView dataGridView;

        #endregion
    }
}