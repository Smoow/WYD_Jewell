namespace WYD_Jewell
{
    partial class RenewConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RenewConfig));
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.btnCancelConfig = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.possibleKeys = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.possibleTimes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.Location = new System.Drawing.Point(17, 116);
            this.btnSaveConfig.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(100, 34);
            this.btnSaveConfig.TabIndex = 0;
            this.btnSaveConfig.Text = "Salvar";
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // btnCancelConfig
            // 
            this.btnCancelConfig.Location = new System.Drawing.Point(149, 116);
            this.btnCancelConfig.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelConfig.Name = "btnCancelConfig";
            this.btnCancelConfig.Size = new System.Drawing.Size(100, 34);
            this.btnCancelConfig.TabIndex = 1;
            this.btnCancelConfig.Text = "Cancelar";
            this.btnCancelConfig.UseVisualStyleBackColor = true;
            this.btnCancelConfig.Click += new System.EventHandler(this.btnCancelConfig_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Slot que ficará a jóia:";
            // 
            // possibleKeys
            // 
            this.possibleKeys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.possibleKeys.FormattingEnabled = true;
            this.possibleKeys.Items.AddRange(new object[] {
            "e",
            "r",
            "t"});
            this.possibleKeys.Location = new System.Drawing.Point(174, 18);
            this.possibleKeys.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.possibleKeys.Name = "possibleKeys";
            this.possibleKeys.Size = new System.Drawing.Size(75, 27);
            this.possibleKeys.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tempo para renovação:";
            // 
            // possibleTimes
            // 
            this.possibleTimes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.possibleTimes.FormattingEnabled = true;
            this.possibleTimes.Items.AddRange(new object[] {
            "05m",
            "10m",
            "15m",
            "20m",
            "25m",
            "30m",
            "35m",
            "40m",
            "45m",
            "50m",
            "55m",
            "59m"});
            this.possibleTimes.Location = new System.Drawing.Point(174, 57);
            this.possibleTimes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.possibleTimes.Name = "possibleTimes";
            this.possibleTimes.Size = new System.Drawing.Size(75, 27);
            this.possibleTimes.TabIndex = 5;
            // 
            // RenewConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 162);
            this.Controls.Add(this.possibleTimes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.possibleKeys);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelConfig);
            this.Controls.Add(this.btnSaveConfig);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RenewConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.Button btnCancelConfig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox possibleKeys;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox possibleTimes;
    }
}