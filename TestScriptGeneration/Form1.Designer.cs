namespace TestScriptGeneration
{
    partial class Form1
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
            this.filepath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btBrowse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btGenerateTC = new System.Windows.Forms.Button();
            this.txtDestFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btSelectFolder = new System.Windows.Forms.Button();
            this.pathgenerator = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stoppingCondition = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btTestScriptGen = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMappingFile = new System.Windows.Forms.TextBox();
            this.bt_MappingFile = new System.Windows.Forms.Button();
            this.txtDestTS = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // filepath
            // 
            this.filepath.Location = new System.Drawing.Point(221, 137);
            this.filepath.Name = "filepath";
            this.filepath.ReadOnly = true;
            this.filepath.Size = new System.Drawing.Size(525, 22);
            this.filepath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Model File Path (TC/TS):";
            // 
            // btBrowse
            // 
            this.btBrowse.Location = new System.Drawing.Point(752, 137);
            this.btBrowse.Name = "btBrowse";
            this.btBrowse.Size = new System.Drawing.Size(105, 23);
            this.btBrowse.TabIndex = 2;
            this.btBrowse.Text = "Browse";
            this.btBrowse.UseVisualStyleBackColor = true;
            this.btBrowse.Click += new System.EventHandler(this.btBrowse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btGenerateTC
            // 
            this.btGenerateTC.Location = new System.Drawing.Point(221, 392);
            this.btGenerateTC.Name = "btGenerateTC";
            this.btGenerateTC.Size = new System.Drawing.Size(241, 24);
            this.btGenerateTC.TabIndex = 3;
            this.btGenerateTC.Text = "Generate Json Format Test cases";
            this.btGenerateTC.UseVisualStyleBackColor = true;
            this.btGenerateTC.Click += new System.EventHandler(this.btGenerateTC_Click);
            // 
            // txtDestFolder
            // 
            this.txtDestFolder.Location = new System.Drawing.Point(221, 263);
            this.txtDestFolder.Name = "txtDestFolder";
            this.txtDestFolder.ReadOnly = true;
            this.txtDestFolder.Size = new System.Drawing.Size(526, 22);
            this.txtDestFolder.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Destination Folder (TC/TS):";
            // 
            // btSelectFolder
            // 
            this.btSelectFolder.Location = new System.Drawing.Point(752, 263);
            this.btSelectFolder.Name = "btSelectFolder";
            this.btSelectFolder.Size = new System.Drawing.Size(105, 23);
            this.btSelectFolder.TabIndex = 6;
            this.btSelectFolder.Text = "Select Folder";
            this.btSelectFolder.UseVisualStyleBackColor = true;
            this.btSelectFolder.Click += new System.EventHandler(this.btSelectFolder_Click);
            // 
            // pathgenerator
            // 
            this.pathgenerator.FormattingEnabled = true;
            this.pathgenerator.Items.AddRange(new object[] {
            "random"});
            this.pathgenerator.Location = new System.Drawing.Point(222, 179);
            this.pathgenerator.Name = "pathgenerator";
            this.pathgenerator.Size = new System.Drawing.Size(202, 24);
            this.pathgenerator.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Path Generator (TC):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(430, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Stopping Condition (TC):";
            // 
            // stoppingCondition
            // 
            this.stoppingCondition.FormattingEnabled = true;
            this.stoppingCondition.Items.AddRange(new object[] {
            "edge_coverage(100)",
            "vertex_coverage(100)",
            "requirement_coverage(100)",
            "length(100)"});
            this.stoppingCondition.Location = new System.Drawing.Point(589, 179);
            this.stoppingCondition.Name = "stoppingCondition";
            this.stoppingCondition.Size = new System.Drawing.Size(157, 24);
            this.stoppingCondition.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Excluding Test Data",
            "Include Test Data"});
            this.comboBox1.Location = new System.Drawing.Point(221, 221);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(203, 24);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(430, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(293, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "(Select include test data if generating scripts)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Level of Detail in TC:";
            // 
            // btTestScriptGen
            // 
            this.btTestScriptGen.Location = new System.Drawing.Point(504, 392);
            this.btTestScriptGen.Name = "btTestScriptGen";
            this.btTestScriptGen.Size = new System.Drawing.Size(242, 23);
            this.btTestScriptGen.TabIndex = 16;
            this.btTestScriptGen.Text = "Generate C# Test Script";
            this.btTestScriptGen.UseVisualStyleBackColor = true;
            this.btTestScriptGen.Click += new System.EventHandler(this.btTestScriptGen_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Signals Mapping File (TS):";
            // 
            // txtMappingFile
            // 
            this.txtMappingFile.Location = new System.Drawing.Point(221, 305);
            this.txtMappingFile.Name = "txtMappingFile";
            this.txtMappingFile.ReadOnly = true;
            this.txtMappingFile.Size = new System.Drawing.Size(525, 22);
            this.txtMappingFile.TabIndex = 18;
            // 
            // bt_MappingFile
            // 
            this.bt_MappingFile.Location = new System.Drawing.Point(752, 305);
            this.bt_MappingFile.Name = "bt_MappingFile";
            this.bt_MappingFile.Size = new System.Drawing.Size(105, 23);
            this.bt_MappingFile.TabIndex = 19;
            this.bt_MappingFile.Text = "Browse";
            this.bt_MappingFile.UseVisualStyleBackColor = true;
            this.bt_MappingFile.Click += new System.EventHandler(this.bt_MappingFile_Click);
            // 
            // txtDestTS
            // 
            this.txtDestTS.Location = new System.Drawing.Point(221, 346);
            this.txtDestTS.Name = "txtDestTS";
            this.txtDestTS.ReadOnly = true;
            this.txtDestTS.Size = new System.Drawing.Size(525, 22);
            this.txtDestTS.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(752, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Select Folder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Destination Folder (TS):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 479);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDestTS);
            this.Controls.Add(this.bt_MappingFile);
            this.Controls.Add(this.txtMappingFile);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btTestScriptGen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.stoppingCondition);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pathgenerator);
            this.Controls.Add(this.btSelectFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDestFolder);
            this.Controls.Add(this.btGenerateTC);
            this.Controls.Add(this.btBrowse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filepath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox filepath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btGenerateTC;
        private System.Windows.Forms.TextBox txtDestFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSelectFolder;
        private System.Windows.Forms.ComboBox pathgenerator;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox stoppingCondition;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btTestScriptGen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMappingFile;
        private System.Windows.Forms.Button bt_MappingFile;
        private System.Windows.Forms.TextBox txtDestTS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
    }
}

