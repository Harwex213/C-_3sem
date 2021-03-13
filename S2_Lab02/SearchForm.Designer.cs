using System.ComponentModel;

namespace S2_Lab02
{
    partial class SearchForm
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
            this.SearchByGroup = new System.Windows.Forms.GroupBox();
            this.SearchTypePassengersSeats = new System.Windows.Forms.RadioButton();
            this.SearchTypeLoadCapacity = new System.Windows.Forms.RadioButton();
            this.SearchTypeType = new System.Windows.Forms.RadioButton();
            this.SearchTypeModel = new System.Windows.Forms.RadioButton();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchMenuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuItemSort = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDateRelease = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDateTechService = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSaveSearchResults = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchInput = new System.Windows.Forms.TextBox();
            this.SearchResultDataView = new System.Windows.Forms.TextBox();
            this.SearchInputExample = new System.Windows.Forms.Label();
            this.SearchInputGroup = new System.Windows.Forms.GroupBox();
            this.SearchByGroup.SuspendLayout();
            this.SearchMenuStrip.SuspendLayout();
            this.SearchInputGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchByGroup
            // 
            this.SearchByGroup.Controls.Add(this.SearchTypePassengersSeats);
            this.SearchByGroup.Controls.Add(this.SearchTypeLoadCapacity);
            this.SearchByGroup.Controls.Add(this.SearchTypeType);
            this.SearchByGroup.Controls.Add(this.SearchTypeModel);
            this.SearchByGroup.Location = new System.Drawing.Point(12, 27);
            this.SearchByGroup.Name = "SearchByGroup";
            this.SearchByGroup.Size = new System.Drawing.Size(205, 144);
            this.SearchByGroup.TabIndex = 1;
            this.SearchByGroup.TabStop = false;
            this.SearchByGroup.Text = "Поиск по";
            // 
            // SearchTypePassengersSeats
            // 
            this.SearchTypePassengersSeats.Location = new System.Drawing.Point(6, 111);
            this.SearchTypePassengersSeats.Name = "SearchTypePassengersSeats";
            this.SearchTypePassengersSeats.Size = new System.Drawing.Size(178, 24);
            this.SearchTypePassengersSeats.TabIndex = 3;
            this.SearchTypePassengersSeats.TabStop = true;
            this.SearchTypePassengersSeats.Text = "Кол-ву пасс. мест";
            this.SearchTypePassengersSeats.UseVisualStyleBackColor = true;
            // 
            // SearchTypeLoadCapacity
            // 
            this.SearchTypeLoadCapacity.Location = new System.Drawing.Point(6, 81);
            this.SearchTypeLoadCapacity.Name = "SearchTypeLoadCapacity";
            this.SearchTypeLoadCapacity.Size = new System.Drawing.Size(193, 24);
            this.SearchTypeLoadCapacity.TabIndex = 2;
            this.SearchTypeLoadCapacity.TabStop = true;
            this.SearchTypeLoadCapacity.Text = "Грузоподъёмности";
            this.SearchTypeLoadCapacity.UseVisualStyleBackColor = true;
            // 
            // SearchTypeType
            // 
            this.SearchTypeType.Location = new System.Drawing.Point(6, 51);
            this.SearchTypeType.Name = "SearchTypeType";
            this.SearchTypeType.Size = new System.Drawing.Size(104, 24);
            this.SearchTypeType.TabIndex = 1;
            this.SearchTypeType.TabStop = true;
            this.SearchTypeType.Text = "Типу";
            this.SearchTypeType.UseVisualStyleBackColor = true;
            // 
            // SearchTypeModel
            // 
            this.SearchTypeModel.Location = new System.Drawing.Point(6, 21);
            this.SearchTypeModel.Name = "SearchTypeModel";
            this.SearchTypeModel.Size = new System.Drawing.Size(104, 24);
            this.SearchTypeModel.TabIndex = 0;
            this.SearchTypeModel.TabStop = true;
            this.SearchTypeModel.Text = "Модели";
            this.SearchTypeModel.UseVisualStyleBackColor = true;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(6, 84);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(225, 51);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchMenuStrip
            // 
            this.SearchMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.MenuItemSort, this.MenuItemSaveSearchResults});
            this.SearchMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.SearchMenuStrip.Name = "SearchMenuStrip";
            this.SearchMenuStrip.Size = new System.Drawing.Size(473, 28);
            this.SearchMenuStrip.TabIndex = 4;
            this.SearchMenuStrip.Text = "menuStrip1";
            // 
            // MenuItemSort
            // 
            this.MenuItemSort.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.MenuItemDateRelease, this.MenuItemDateTechService});
            this.MenuItemSort.Name = "MenuItemSort";
            this.MenuItemSort.Size = new System.Drawing.Size(126, 24);
            this.MenuItemSort.Text = "Сортировка по";
            // 
            // MenuItemDateRelease
            // 
            this.MenuItemDateRelease.Name = "MenuItemDateRelease";
            this.MenuItemDateRelease.Size = new System.Drawing.Size(244, 24);
            this.MenuItemDateRelease.Text = "Дате выпуска";
            this.MenuItemDateRelease.Click += new System.EventHandler(this.MenuItemDateRelease_Click);
            // 
            // MenuItemDateTechService
            // 
            this.MenuItemDateTechService.Name = "MenuItemDateTechService";
            this.MenuItemDateTechService.Size = new System.Drawing.Size(244, 24);
            this.MenuItemDateTechService.Text = "Дате тех. обслуживания";
            this.MenuItemDateTechService.Click += new System.EventHandler(this.MenuItemDateTechService_Click);
            // 
            // MenuItemSaveSearchResults
            // 
            this.MenuItemSaveSearchResults.Name = "MenuItemSaveSearchResults";
            this.MenuItemSaveSearchResults.Size = new System.Drawing.Size(205, 24);
            this.MenuItemSaveSearchResults.Text = "Сохранить данные поиска";
            this.MenuItemSaveSearchResults.Click += new System.EventHandler(this.MenuItemSaveSearchResults_Click);
            // 
            // SearchInput
            // 
            this.SearchInput.Enabled = false;
            this.SearchInput.Location = new System.Drawing.Point(6, 21);
            this.SearchInput.Name = "SearchInput";
            this.SearchInput.Size = new System.Drawing.Size(225, 22);
            this.SearchInput.TabIndex = 5;
            // 
            // SearchResultDataView
            // 
            this.SearchResultDataView.Location = new System.Drawing.Point(12, 177);
            this.SearchResultDataView.Multiline = true;
            this.SearchResultDataView.Name = "SearchResultDataView";
            this.SearchResultDataView.ReadOnly = true;
            this.SearchResultDataView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SearchResultDataView.Size = new System.Drawing.Size(448, 261);
            this.SearchResultDataView.TabIndex = 6;
            // 
            // SearchInputExample
            // 
            this.SearchInputExample.Location = new System.Drawing.Point(6, 46);
            this.SearchInputExample.Name = "SearchInputExample";
            this.SearchInputExample.Size = new System.Drawing.Size(225, 35);
            this.SearchInputExample.TabIndex = 7;
            this.SearchInputExample.Text = "Вид поиска:";
            // 
            // SearchInputGroup
            // 
            this.SearchInputGroup.Controls.Add(this.SearchInput);
            this.SearchInputGroup.Controls.Add(this.SearchInputExample);
            this.SearchInputGroup.Controls.Add(this.SearchButton);
            this.SearchInputGroup.Location = new System.Drawing.Point(223, 27);
            this.SearchInputGroup.Name = "SearchInputGroup";
            this.SearchInputGroup.Size = new System.Drawing.Size(237, 144);
            this.SearchInputGroup.TabIndex = 8;
            this.SearchInputGroup.TabStop = false;
            this.SearchInputGroup.Text = "Ввод данных";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 450);
            this.Controls.Add(this.SearchInputGroup);
            this.Controls.Add(this.SearchResultDataView);
            this.Controls.Add(this.SearchByGroup);
            this.Controls.Add(this.SearchMenuStrip);
            this.MainMenuStrip = this.SearchMenuStrip;
            this.MaximumSize = new System.Drawing.Size(491, 497);
            this.MinimumSize = new System.Drawing.Size(491, 497);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.SearchByGroup.ResumeLayout(false);
            this.SearchMenuStrip.ResumeLayout(false);
            this.SearchMenuStrip.PerformLayout();
            this.SearchInputGroup.ResumeLayout(false);
            this.SearchInputGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem MenuItemSaveSearchResults;

        private System.Windows.Forms.ToolStripMenuItem MenuItemDateTechService;

        private System.Windows.Forms.ToolStripMenuItem MenuItemDateRelease;

        private System.Windows.Forms.ToolStripMenuItem MenuItemSort;

        private System.Windows.Forms.GroupBox SearchInputGroup;

        private System.Windows.Forms.Label SearchInputExample;

        private System.Windows.Forms.TextBox SearchResultDataView;

        private System.Windows.Forms.TextBox SearchInput;

        private System.Windows.Forms.RadioButton SearchTypeType;
        private System.Windows.Forms.RadioButton SearchTypeLoadCapacity;
        private System.Windows.Forms.RadioButton SearchTypePassengersSeats;

        private System.Windows.Forms.MenuStrip SearchMenuStrip;

        private System.Windows.Forms.Button SearchButton;

        private System.Windows.Forms.RadioButton SearchTypeModel;

        private System.Windows.Forms.GroupBox SearchByGroup;

        #endregion
    }
}