namespace TaskerManager
{
    partial class TaskerManager
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.scriptsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.NextButton = new System.Windows.Forms.Button();
            this.PrevButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NewButton = new System.Windows.Forms.Button();
            this.ReloadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Script",
            "Work"});
            this.comboBox.Location = new System.Drawing.Point(325, 30);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 24);
            this.comboBox.TabIndex = 0;
            // 
            // scriptsTableLayoutPanel
            // 
            this.scriptsTableLayoutPanel.ColumnCount = 4;
            this.scriptsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.scriptsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.scriptsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.scriptsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.scriptsTableLayoutPanel.Location = new System.Drawing.Point(176, 76);
            this.scriptsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.scriptsTableLayoutPanel.Name = "scriptsTableLayoutPanel";
            this.scriptsTableLayoutPanel.RowCount = 10;
            this.scriptsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.scriptsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.scriptsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.scriptsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.scriptsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.scriptsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.scriptsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.scriptsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.scriptsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.scriptsTableLayoutPanel.Size = new System.Drawing.Size(400, 300);
            this.scriptsTableLayoutPanel.TabIndex = 1;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(684, 400);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 2;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.Next_Click);
            // 
            // PrevButton
            // 
            this.PrevButton.Location = new System.Drawing.Point(587, 400);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(75, 23);
            this.PrevButton.TabIndex = 3;
            this.PrevButton.Text = "Prev";
            this.PrevButton.UseVisualStyleBackColor = true;
            this.PrevButton.Click += new System.EventHandler(this.Prev_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "SCRIPT";
            // 
            // NewButton
            // 
            this.NewButton.Location = new System.Drawing.Point(354, 400);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(75, 23);
            this.NewButton.TabIndex = 5;
            this.NewButton.Text = "New";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // ReloadButton
            // 
            this.ReloadButton.Location = new System.Drawing.Point(713, 13);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(75, 23);
            this.ReloadButton.TabIndex = 6;
            this.ReloadButton.Text = "Reload";
            this.ReloadButton.UseVisualStyleBackColor = true;
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // TaskerManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReloadButton);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrevButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.scriptsTableLayoutPanel);
            this.Controls.Add(this.comboBox);
            this.Name = "TaskerManager";
            this.Text = "Tasker Manager";
            this.Load += new System.EventHandler(this.LoadScripts);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.TableLayoutPanel scriptsTableLayoutPanel;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button PrevButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button ReloadButton;
    }
}

