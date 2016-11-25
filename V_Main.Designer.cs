using System;

namespace Progra_3
{
    partial class V_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Main));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_logout = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton_reports = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownButton_help = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem_manual = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_about = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView_main = new System.Windows.Forms.DataGridView();
            this.panel_searchBy = new System.Windows.Forms.Panel();
            this.label_filterBy = new System.Windows.Forms.Label();
            this.button_search = new System.Windows.Forms.Button();
            this.comboBox_columnSearch = new System.Windows.Forms.ComboBox();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel_options = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_selectTable = new System.Windows.Forms.Panel();
            this.label_selectTable = new System.Windows.Forms.Label();
            this.button_goToTable = new System.Windows.Forms.Button();
            this.comboBox_selectTable = new System.Windows.Forms.ComboBox();
            this.panel_functions = new System.Windows.Forms.Panel();
            this.button_function_4 = new System.Windows.Forms.Button();
            this.button_function_3 = new System.Windows.Forms.Button();
            this.button_function_2 = new System.Windows.Forms.Button();
            this.label_functions = new System.Windows.Forms.Label();
            this.button_function_1 = new System.Windows.Forms.Button();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_main)).BeginInit();
            this.panel_searchBy.SuspendLayout();
            this.panel_selectTable.SuspendLayout();
            this.panel_functions.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.AliceBlue;
            this.toolStrip.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_logout,
            this.toolStripDropDownButton_reports,
            this.toolStripDropDownButton_help});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStrip.Size = new System.Drawing.Size(1482, 30);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip";
            // 
            // toolStripButton_logout
            // 
            this.toolStripButton_logout.BackColor = System.Drawing.Color.LightCoral;
            this.toolStripButton_logout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_logout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_logout.Image")));
            this.toolStripButton_logout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_logout.Name = "toolStripButton_logout";
            this.toolStripButton_logout.Size = new System.Drawing.Size(120, 27);
            this.toolStripButton_logout.Text = "Cerrar Sesión";
            this.toolStripButton_logout.Click += new System.EventHandler(this.toolStripButton_logout_Click);
            // 
            // toolStripDropDownButton_reports
            // 
            this.toolStripDropDownButton_reports.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton_reports.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton_reports.Image")));
            this.toolStripDropDownButton_reports.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton_reports.Name = "toolStripDropDownButton_reports";
            this.toolStripDropDownButton_reports.Size = new System.Drawing.Size(95, 27);
            this.toolStripDropDownButton_reports.Text = "Reportes";
            // 
            // toolStripDropDownButton_help
            // 
            this.toolStripDropDownButton_help.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton_help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_manual,
            this.toolStripMenuItem_about});
            this.toolStripDropDownButton_help.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton_help.Image")));
            this.toolStripDropDownButton_help.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton_help.Name = "toolStripDropDownButton_help";
            this.toolStripDropDownButton_help.Size = new System.Drawing.Size(75, 27);
            this.toolStripDropDownButton_help.Text = "Ayuda";
            // 
            // toolStripMenuItem_manual
            // 
            this.toolStripMenuItem_manual.Name = "toolStripMenuItem_manual";
            this.toolStripMenuItem_manual.Size = new System.Drawing.Size(235, 28);
            this.toolStripMenuItem_manual.Text = "Manual de Usuario";
            this.toolStripMenuItem_manual.Click += new System.EventHandler(this.toolStripMenuItem_manual_Click);
            // 
            // toolStripMenuItem_about
            // 
            this.toolStripMenuItem_about.Name = "toolStripMenuItem_about";
            this.toolStripMenuItem_about.Size = new System.Drawing.Size(235, 28);
            this.toolStripMenuItem_about.Text = "Acerca de";
            this.toolStripMenuItem_about.Click += new System.EventHandler(this.toolStripMenuItem_about_Click);
            // 
            // dataGridView_main
            // 
            this.dataGridView_main.AllowUserToAddRows = false;
            this.dataGridView_main.AllowUserToDeleteRows = false;
            this.dataGridView_main.AllowUserToOrderColumns = true;
            this.dataGridView_main.AllowUserToResizeRows = false;
            this.dataGridView_main.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_main.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_main.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_main.Location = new System.Drawing.Point(12, 41);
            this.dataGridView_main.MultiSelect = false;
            this.dataGridView_main.Name = "dataGridView_main";
            this.dataGridView_main.ReadOnly = true;
            this.dataGridView_main.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_main.RowTemplate.Height = 24;
            this.dataGridView_main.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_main.Size = new System.Drawing.Size(1000, 700);
            this.dataGridView_main.TabIndex = 1;
            // 
            // panel_searchBy
            // 
            this.panel_searchBy.BackColor = System.Drawing.Color.Teal;
            this.panel_searchBy.Controls.Add(this.label_filterBy);
            this.panel_searchBy.Controls.Add(this.button_search);
            this.panel_searchBy.Controls.Add(this.comboBox_columnSearch);
            this.panel_searchBy.Controls.Add(this.textBox_search);
            this.panel_searchBy.Location = new System.Drawing.Point(3, 160);
            this.panel_searchBy.Name = "panel_searchBy";
            this.panel_searchBy.Size = new System.Drawing.Size(300, 160);
            this.panel_searchBy.TabIndex = 2;
            // 
            // label_filterBy
            // 
            this.label_filterBy.AutoSize = true;
            this.label_filterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_filterBy.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_filterBy.Location = new System.Drawing.Point(15, 26);
            this.label_filterBy.Name = "label_filterBy";
            this.label_filterBy.Size = new System.Drawing.Size(181, 20);
            this.label_filterBy.TabIndex = 3;
            this.label_filterBy.Text = "Filtrar por elemento:";
            // 
            // button_search
            // 
            this.button_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.Location = new System.Drawing.Point(19, 115);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(92, 38);
            this.button_search.TabIndex = 2;
            this.button_search.Text = "Buscar";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // comboBox_columnSearch
            // 
            this.comboBox_columnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_columnSearch.FormattingEnabled = true;
            this.comboBox_columnSearch.Location = new System.Drawing.Point(19, 81);
            this.comboBox_columnSearch.Name = "comboBox_columnSearch";
            this.comboBox_columnSearch.Size = new System.Drawing.Size(280, 28);
            this.comboBox_columnSearch.TabIndex = 1;
            // 
            // textBox_search
            // 
            this.textBox_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_search.Location = new System.Drawing.Point(19, 49);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(280, 26);
            this.textBox_search.TabIndex = 0;
            // 
            // flowLayoutPanel_options
            // 
            this.flowLayoutPanel_options.AutoScroll = true;
            this.flowLayoutPanel_options.BackColor = System.Drawing.Color.Teal;
            this.flowLayoutPanel_options.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_options.Location = new System.Drawing.Point(1018, 41);
            this.flowLayoutPanel_options.Name = "flowLayoutPanel_options";
            this.flowLayoutPanel_options.Size = new System.Drawing.Size(450, 700);
            this.flowLayoutPanel_options.TabIndex = 3;
            this.flowLayoutPanel_options.WrapContents = false;
            // 
            // panel_selectTable
            // 
            this.panel_selectTable.BackColor = System.Drawing.Color.Teal;
            this.panel_selectTable.Controls.Add(this.label_selectTable);
            this.panel_selectTable.Controls.Add(this.button_goToTable);
            this.panel_selectTable.Controls.Add(this.comboBox_selectTable);
            this.panel_selectTable.Location = new System.Drawing.Point(3, 3);
            this.panel_selectTable.Name = "panel_selectTable";
            this.panel_selectTable.Size = new System.Drawing.Size(300, 130);
            this.panel_selectTable.TabIndex = 3;
            // 
            // label_selectTable
            // 
            this.label_selectTable.AutoSize = true;
            this.label_selectTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_selectTable.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_selectTable.Location = new System.Drawing.Point(15, 26);
            this.label_selectTable.Name = "label_selectTable";
            this.label_selectTable.Size = new System.Drawing.Size(166, 20);
            this.label_selectTable.TabIndex = 3;
            this.label_selectTable.Text = "Seleccionar Tabla:";
            // 
            // button_goToTable
            // 
            this.button_goToTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_goToTable.Location = new System.Drawing.Point(19, 83);
            this.button_goToTable.Name = "button_goToTable";
            this.button_goToTable.Size = new System.Drawing.Size(173, 38);
            this.button_goToTable.TabIndex = 2;
            this.button_goToTable.Text = "Mostrar Tabla";
            this.button_goToTable.UseVisualStyleBackColor = true;
            this.button_goToTable.Click += new System.EventHandler(this.button_goToTable_Click);
            // 
            // comboBox_selectTable
            // 
            this.comboBox_selectTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_selectTable.FormattingEnabled = true;
            this.comboBox_selectTable.Items.AddRange(new object[] {
            "Areas_por_Centro",
            "Bitacoras",
            "Catalogo_Diagnosticos",
            "Catalogo_Tratamientos",
            "Centros_Atencion",
            "Citas",
            "Diagnosticos",
            "Formas_Aplicacion",
            "Funcionarios",
            "Paises",
            "Personas",
            "Telefonos",
            "Tipos_Areas",
            "Tipos_Centros",
            "Tipos_Roles",
            "Tipos_Tratamientos"});
            this.comboBox_selectTable.Location = new System.Drawing.Point(19, 49);
            this.comboBox_selectTable.Name = "comboBox_selectTable";
            this.comboBox_selectTable.Size = new System.Drawing.Size(280, 28);
            this.comboBox_selectTable.Sorted = true;
            this.comboBox_selectTable.TabIndex = 1;
            this.comboBox_selectTable.Text = "Citas";
            // 
            // panel_functions
            // 
            this.panel_functions.BackColor = System.Drawing.Color.Teal;
            this.panel_functions.Controls.Add(this.button_function_4);
            this.panel_functions.Controls.Add(this.button_function_3);
            this.panel_functions.Controls.Add(this.button_function_2);
            this.panel_functions.Controls.Add(this.label_functions);
            this.panel_functions.Controls.Add(this.button_function_1);
            this.panel_functions.Location = new System.Drawing.Point(3, 356);
            this.panel_functions.Name = "panel_functions";
            this.panel_functions.Size = new System.Drawing.Size(300, 245);
            this.panel_functions.TabIndex = 4;
            // 
            // button_function_4
            // 
            this.button_function_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_function_4.Location = new System.Drawing.Point(19, 181);
            this.button_function_4.Name = "button_function_4";
            this.button_function_4.Size = new System.Drawing.Size(280, 38);
            this.button_function_4.TabIndex = 6;
            this.button_function_4.UseVisualStyleBackColor = true;
            this.button_function_4.Click += new System.EventHandler(this.button_function_Click);
            // 
            // button_function_3
            // 
            this.button_function_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_function_3.Location = new System.Drawing.Point(19, 137);
            this.button_function_3.Name = "button_function_3";
            this.button_function_3.Size = new System.Drawing.Size(280, 38);
            this.button_function_3.TabIndex = 5;
            this.button_function_3.UseVisualStyleBackColor = true;
            this.button_function_3.Click += new System.EventHandler(this.button_function_Click);
            // 
            // button_function_2
            // 
            this.button_function_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_function_2.Location = new System.Drawing.Point(19, 93);
            this.button_function_2.Name = "button_function_2";
            this.button_function_2.Size = new System.Drawing.Size(280, 38);
            this.button_function_2.TabIndex = 4;
            this.button_function_2.UseVisualStyleBackColor = true;
            this.button_function_2.Click += new System.EventHandler(this.button_function_Click);
            // 
            // label_functions
            // 
            this.label_functions.AutoSize = true;
            this.label_functions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_functions.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_functions.Location = new System.Drawing.Point(15, 26);
            this.label_functions.Name = "label_functions";
            this.label_functions.Size = new System.Drawing.Size(101, 20);
            this.label_functions.TabIndex = 3;
            this.label_functions.Text = "Funciones:";
            // 
            // button_function_1
            // 
            this.button_function_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_function_1.Location = new System.Drawing.Point(19, 49);
            this.button_function_1.Name = "button_function_1";
            this.button_function_1.Size = new System.Drawing.Size(280, 38);
            this.button_function_1.TabIndex = 2;
            this.button_function_1.UseVisualStyleBackColor = true;
            this.button_function_1.Click += new System.EventHandler(this.button_function_Click);
            // 
            // V_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.flowLayoutPanel_options);
            this.Controls.Add(this.dataGridView_main);
            this.Controls.Add(this.toolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "V_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expediente Médico";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.V_Main_FormClosing);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_main)).EndInit();
            this.panel_searchBy.ResumeLayout(false);
            this.panel_searchBy.PerformLayout();
            this.panel_selectTable.ResumeLayout(false);
            this.panel_selectTable.PerformLayout();
            this.panel_functions.ResumeLayout(false);
            this.panel_functions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButton_logout;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton_reports;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton_help;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_manual;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_about;
        private System.Windows.Forms.DataGridView dataGridView_main;
        private System.Windows.Forms.Panel panel_searchBy;
        private System.Windows.Forms.Label label_filterBy;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.ComboBox comboBox_columnSearch;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_options;
        private System.Windows.Forms.Panel panel_selectTable;
        private System.Windows.Forms.Label label_selectTable;
        private System.Windows.Forms.Button button_goToTable;
        private System.Windows.Forms.ComboBox comboBox_selectTable;
        private System.Windows.Forms.Panel panel_functions;
        private System.Windows.Forms.Button button_function_4;
        private System.Windows.Forms.Button button_function_3;
        private System.Windows.Forms.Button button_function_2;
        private System.Windows.Forms.Label label_functions;
        private System.Windows.Forms.Button button_function_1;
    }
}