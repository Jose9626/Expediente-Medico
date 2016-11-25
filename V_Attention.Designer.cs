namespace Progra_3
{
    partial class V_Attention
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Attention));
            this.label1 = new System.Windows.Forms.Label();
            this.label_treatment = new System.Windows.Forms.Label();
            this.label_diagnosis_nameFilter = new System.Windows.Forms.Label();
            this.textBox_diagnosis_nameFilter = new System.Windows.Forms.TextBox();
            this.button_diagnosis_filter = new System.Windows.Forms.Button();
            this.listBox_diagnosis = new System.Windows.Forms.ListBox();
            this.listBox_addedDiagnosis = new System.Windows.Forms.ListBox();
            this.label_addedDiagnosis = new System.Windows.Forms.Label();
            this.button_addDiagnosis = new System.Windows.Forms.Button();
            this.button_deleteDiagnosis = new System.Windows.Forms.Button();
            this.button_deleteTreatment = new System.Windows.Forms.Button();
            this.button_addTreatment = new System.Windows.Forms.Button();
            this.label_addedTreatment = new System.Windows.Forms.Label();
            this.listBox_addedTreatment = new System.Windows.Forms.ListBox();
            this.listBox_treatment = new System.Windows.Forms.ListBox();
            this.button_treatment_filter = new System.Windows.Forms.Button();
            this.label_treatment_nameFilter = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label_treatment_typeFilter = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label_treatment_formFilter = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "DIAGNOSTICO:";
            // 
            // label_treatment
            // 
            this.label_treatment.AutoSize = true;
            this.label_treatment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_treatment.Location = new System.Drawing.Point(522, 29);
            this.label_treatment.Name = "label_treatment";
            this.label_treatment.Size = new System.Drawing.Size(144, 20);
            this.label_treatment.TabIndex = 3;
            this.label_treatment.Text = "TRATAMIENTO:";
            // 
            // label_diagnosis_nameFilter
            // 
            this.label_diagnosis_nameFilter.AutoSize = true;
            this.label_diagnosis_nameFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_diagnosis_nameFilter.Location = new System.Drawing.Point(45, 100);
            this.label_diagnosis_nameFilter.Name = "label_diagnosis_nameFilter";
            this.label_diagnosis_nameFilter.Size = new System.Drawing.Size(144, 17);
            this.label_diagnosis_nameFilter.TabIndex = 4;
            this.label_diagnosis_nameFilter.Text = "Filtrar por nombre:";
            // 
            // textBox_diagnosis_nameFilter
            // 
            this.textBox_diagnosis_nameFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_diagnosis_nameFilter.Location = new System.Drawing.Point(195, 97);
            this.textBox_diagnosis_nameFilter.Name = "textBox_diagnosis_nameFilter";
            this.textBox_diagnosis_nameFilter.Size = new System.Drawing.Size(261, 23);
            this.textBox_diagnosis_nameFilter.TabIndex = 5;
            // 
            // button_diagnosis_filter
            // 
            this.button_diagnosis_filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_diagnosis_filter.Location = new System.Drawing.Point(195, 126);
            this.button_diagnosis_filter.Name = "button_diagnosis_filter";
            this.button_diagnosis_filter.Size = new System.Drawing.Size(261, 37);
            this.button_diagnosis_filter.TabIndex = 6;
            this.button_diagnosis_filter.Text = "Filtrar diagnosticos";
            this.button_diagnosis_filter.UseVisualStyleBackColor = true;
            this.button_diagnosis_filter.Click += new System.EventHandler(this.button_diagnosis_filter_Click);
            // 
            // listBox_diagnosis
            // 
            this.listBox_diagnosis.FormattingEnabled = true;
            this.listBox_diagnosis.HorizontalScrollbar = true;
            this.listBox_diagnosis.ItemHeight = 16;
            this.listBox_diagnosis.Location = new System.Drawing.Point(48, 215);
            this.listBox_diagnosis.Name = "listBox_diagnosis";
            this.listBox_diagnosis.Size = new System.Drawing.Size(408, 148);
            this.listBox_diagnosis.Sorted = true;
            this.listBox_diagnosis.TabIndex = 7;
            this.listBox_diagnosis.DoubleClick += new System.EventHandler(this.button_addDiagnosis_Click);
            // 
            // listBox_addedDiagnosis
            // 
            this.listBox_addedDiagnosis.FormattingEnabled = true;
            this.listBox_addedDiagnosis.HorizontalScrollbar = true;
            this.listBox_addedDiagnosis.ItemHeight = 16;
            this.listBox_addedDiagnosis.Location = new System.Drawing.Point(48, 469);
            this.listBox_addedDiagnosis.Name = "listBox_addedDiagnosis";
            this.listBox_addedDiagnosis.Size = new System.Drawing.Size(408, 132);
            this.listBox_addedDiagnosis.Sorted = true;
            this.listBox_addedDiagnosis.TabIndex = 8;
            this.listBox_addedDiagnosis.SelectedIndexChanged += new System.EventHandler(this.listBox_addedDiagnosis_SelectedIndexChanged);
            this.listBox_addedDiagnosis.DoubleClick += new System.EventHandler(this.button_deleteDiagnosis_Click);
            // 
            // label_addedDiagnosis
            // 
            this.label_addedDiagnosis.AutoSize = true;
            this.label_addedDiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_addedDiagnosis.Location = new System.Drawing.Point(44, 429);
            this.label_addedDiagnosis.Name = "label_addedDiagnosis";
            this.label_addedDiagnosis.Size = new System.Drawing.Size(218, 20);
            this.label_addedDiagnosis.TabIndex = 9;
            this.label_addedDiagnosis.Text = "Diagnosticos agregados:";
            // 
            // button_addDiagnosis
            // 
            this.button_addDiagnosis.BackColor = System.Drawing.Color.LightCoral;
            this.button_addDiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addDiagnosis.Location = new System.Drawing.Point(195, 369);
            this.button_addDiagnosis.Name = "button_addDiagnosis";
            this.button_addDiagnosis.Size = new System.Drawing.Size(261, 37);
            this.button_addDiagnosis.TabIndex = 10;
            this.button_addDiagnosis.Text = "Agregar diagnostico";
            this.button_addDiagnosis.UseVisualStyleBackColor = false;
            this.button_addDiagnosis.Click += new System.EventHandler(this.button_addDiagnosis_Click);
            // 
            // button_deleteDiagnosis
            // 
            this.button_deleteDiagnosis.BackColor = System.Drawing.Color.PaleGreen;
            this.button_deleteDiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_deleteDiagnosis.Location = new System.Drawing.Point(195, 607);
            this.button_deleteDiagnosis.Name = "button_deleteDiagnosis";
            this.button_deleteDiagnosis.Size = new System.Drawing.Size(261, 37);
            this.button_deleteDiagnosis.TabIndex = 11;
            this.button_deleteDiagnosis.Text = "Quitar diagnostico";
            this.button_deleteDiagnosis.UseVisualStyleBackColor = false;
            this.button_deleteDiagnosis.Click += new System.EventHandler(this.button_deleteDiagnosis_Click);
            // 
            // button_deleteTreatment
            // 
            this.button_deleteTreatment.BackColor = System.Drawing.Color.LightCoral;
            this.button_deleteTreatment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_deleteTreatment.Location = new System.Drawing.Point(673, 607);
            this.button_deleteTreatment.Name = "button_deleteTreatment";
            this.button_deleteTreatment.Size = new System.Drawing.Size(261, 37);
            this.button_deleteTreatment.TabIndex = 19;
            this.button_deleteTreatment.Text = "Quitar tratamiento";
            this.button_deleteTreatment.UseVisualStyleBackColor = false;
            this.button_deleteTreatment.Click += new System.EventHandler(this.button_deleteTreatment_Click);
            // 
            // button_addTreatment
            // 
            this.button_addTreatment.BackColor = System.Drawing.Color.PaleGreen;
            this.button_addTreatment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addTreatment.Location = new System.Drawing.Point(673, 369);
            this.button_addTreatment.Name = "button_addTreatment";
            this.button_addTreatment.Size = new System.Drawing.Size(261, 37);
            this.button_addTreatment.TabIndex = 18;
            this.button_addTreatment.Text = "Agregar tratamiento";
            this.button_addTreatment.UseVisualStyleBackColor = false;
            this.button_addTreatment.Click += new System.EventHandler(this.button_addTreatment_Click);
            // 
            // label_addedTreatment
            // 
            this.label_addedTreatment.AutoSize = true;
            this.label_addedTreatment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_addedTreatment.Location = new System.Drawing.Point(522, 429);
            this.label_addedTreatment.Name = "label_addedTreatment";
            this.label_addedTreatment.Size = new System.Drawing.Size(218, 20);
            this.label_addedTreatment.TabIndex = 17;
            this.label_addedTreatment.Text = "Tratamientos agregados:";
            // 
            // listBox_addedTreatment
            // 
            this.listBox_addedTreatment.FormattingEnabled = true;
            this.listBox_addedTreatment.HorizontalScrollbar = true;
            this.listBox_addedTreatment.ItemHeight = 16;
            this.listBox_addedTreatment.Location = new System.Drawing.Point(526, 469);
            this.listBox_addedTreatment.Name = "listBox_addedTreatment";
            this.listBox_addedTreatment.Size = new System.Drawing.Size(408, 132);
            this.listBox_addedTreatment.Sorted = true;
            this.listBox_addedTreatment.TabIndex = 16;
            this.listBox_addedTreatment.DoubleClick += new System.EventHandler(this.button_deleteTreatment_Click);
            // 
            // listBox_treatment
            // 
            this.listBox_treatment.FormattingEnabled = true;
            this.listBox_treatment.HorizontalScrollbar = true;
            this.listBox_treatment.ItemHeight = 16;
            this.listBox_treatment.Location = new System.Drawing.Point(526, 215);
            this.listBox_treatment.Name = "listBox_treatment";
            this.listBox_treatment.Size = new System.Drawing.Size(408, 148);
            this.listBox_treatment.Sorted = true;
            this.listBox_treatment.TabIndex = 15;
            this.listBox_treatment.DoubleClick += new System.EventHandler(this.button_addTreatment_Click);
            // 
            // button_treatment_filter
            // 
            this.button_treatment_filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_treatment_filter.Location = new System.Drawing.Point(673, 157);
            this.button_treatment_filter.Name = "button_treatment_filter";
            this.button_treatment_filter.Size = new System.Drawing.Size(261, 37);
            this.button_treatment_filter.TabIndex = 14;
            this.button_treatment_filter.Text = "Filtrar tratamientos";
            this.button_treatment_filter.UseVisualStyleBackColor = true;
            this.button_treatment_filter.Click += new System.EventHandler(this.button_treatment_filter_Click);
            // 
            // label_treatment_nameFilter
            // 
            this.label_treatment_nameFilter.AutoSize = true;
            this.label_treatment_nameFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_treatment_nameFilter.Location = new System.Drawing.Point(523, 71);
            this.label_treatment_nameFilter.Name = "label_treatment_nameFilter";
            this.label_treatment_nameFilter.Size = new System.Drawing.Size(144, 17);
            this.label_treatment_nameFilter.TabIndex = 20;
            this.label_treatment_nameFilter.Text = "Filtrar por nombre:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(673, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(261, 23);
            this.textBox2.TabIndex = 21;
            // 
            // label_treatment_typeFilter
            // 
            this.label_treatment_typeFilter.AutoSize = true;
            this.label_treatment_typeFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_treatment_typeFilter.Location = new System.Drawing.Point(523, 100);
            this.label_treatment_typeFilter.Name = "label_treatment_typeFilter";
            this.label_treatment_typeFilter.Size = new System.Drawing.Size(117, 17);
            this.label_treatment_typeFilter.TabIndex = 22;
            this.label_treatment_typeFilter.Text = "Filtrar por tipo:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(673, 97);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(261, 24);
            this.comboBox1.TabIndex = 23;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(737, 127);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(197, 24);
            this.comboBox2.TabIndex = 25;
            // 
            // label_treatment_formFilter
            // 
            this.label_treatment_formFilter.AutoSize = true;
            this.label_treatment_formFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_treatment_formFilter.Location = new System.Drawing.Point(522, 130);
            this.label_treatment_formFilter.Name = "label_treatment_formFilter";
            this.label_treatment_formFilter.Size = new System.Drawing.Size(209, 17);
            this.label_treatment_formFilter.TabIndex = 24;
            this.label_treatment_formFilter.Text = "Filtrar por forma aplicación:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 682);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(958, 59);
            this.button1.TabIndex = 26;
            this.button1.Text = "GUARDAR CONSULTA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // V_Attention
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label_treatment_formFilter);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label_treatment_typeFilter);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label_treatment_nameFilter);
            this.Controls.Add(this.button_deleteTreatment);
            this.Controls.Add(this.button_addTreatment);
            this.Controls.Add(this.label_addedTreatment);
            this.Controls.Add(this.listBox_addedTreatment);
            this.Controls.Add(this.listBox_treatment);
            this.Controls.Add(this.button_treatment_filter);
            this.Controls.Add(this.button_deleteDiagnosis);
            this.Controls.Add(this.button_addDiagnosis);
            this.Controls.Add(this.label_addedDiagnosis);
            this.Controls.Add(this.listBox_addedDiagnosis);
            this.Controls.Add(this.listBox_diagnosis);
            this.Controls.Add(this.button_diagnosis_filter);
            this.Controls.Add(this.textBox_diagnosis_nameFilter);
            this.Controls.Add(this.label_diagnosis_nameFilter);
            this.Controls.Add(this.label_treatment);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "V_Attention";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expediente Médico: Consulta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.V_Attention_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_treatment;
        private System.Windows.Forms.Label label_diagnosis_nameFilter;
        private System.Windows.Forms.TextBox textBox_diagnosis_nameFilter;
        private System.Windows.Forms.Button button_diagnosis_filter;
        private System.Windows.Forms.ListBox listBox_diagnosis;
        private System.Windows.Forms.ListBox listBox_addedDiagnosis;
        private System.Windows.Forms.Label label_addedDiagnosis;
        private System.Windows.Forms.Button button_addDiagnosis;
        private System.Windows.Forms.Button button_deleteDiagnosis;
        private System.Windows.Forms.Button button_deleteTreatment;
        private System.Windows.Forms.Button button_addTreatment;
        private System.Windows.Forms.Label label_addedTreatment;
        private System.Windows.Forms.ListBox listBox_addedTreatment;
        private System.Windows.Forms.ListBox listBox_treatment;
        private System.Windows.Forms.Button button_treatment_filter;
        private System.Windows.Forms.Label label_treatment_nameFilter;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label_treatment_typeFilter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label_treatment_formFilter;
        private System.Windows.Forms.Button button1;
    }
}