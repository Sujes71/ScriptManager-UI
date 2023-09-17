namespace ScriptManager
{
    partial class ScriptManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScriptManager));
            this.scriptLabel = new System.Windows.Forms.Label();
            this.ReloadButton = new System.Windows.Forms.Button();
            this.ScriptPanel = new System.Windows.Forms.Panel();
            this.NewButton = new System.Windows.Forms.Button();
            this.PrevButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.scriptsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ScriptPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // scriptLabel
            // 
            this.scriptLabel.AutoSize = true;
            this.scriptLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.scriptLabel.Font = new System.Drawing.Font("Unispace", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scriptLabel.Location = new System.Drawing.Point(273, 14);
            this.scriptLabel.Name = "scriptLabel";
            this.scriptLabel.Size = new System.Drawing.Size(253, 34);
            this.scriptLabel.TabIndex = 4;
            this.scriptLabel.Text = "SCRIPT MANAGER";
            // 
            // ReloadButton
            // 
            this.ReloadButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ReloadButton.Font = new System.Drawing.Font("Unispace", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReloadButton.Location = new System.Drawing.Point(708, 13);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(80, 35);
            this.ReloadButton.TabIndex = 6;
            this.ReloadButton.Text = "Reload";
            this.ReloadButton.UseVisualStyleBackColor = false;
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // ScriptPanel
            // 
            this.ScriptPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ScriptPanel.Controls.Add(this.NewButton);
            this.ScriptPanel.Controls.Add(this.PrevButton);
            this.ScriptPanel.Controls.Add(this.NextButton);
            this.ScriptPanel.Controls.Add(this.scriptsTableLayoutPanel);
            this.ScriptPanel.Location = new System.Drawing.Point(12, 74);
            this.ScriptPanel.Name = "ScriptPanel";
            this.ScriptPanel.Size = new System.Drawing.Size(776, 364);
            this.ScriptPanel.TabIndex = 7;
            // 
            // NewButton
            // 
            this.NewButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.NewButton.Font = new System.Drawing.Font("Unispace", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewButton.Location = new System.Drawing.Point(335, 322);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(111, 34);
            this.NewButton.TabIndex = 9;
            this.NewButton.Text = "New";
            this.NewButton.UseVisualStyleBackColor = false;
            // 
            // PrevButton
            // 
            this.PrevButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PrevButton.Font = new System.Drawing.Font("Unispace", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrevButton.Location = new System.Drawing.Point(572, 322);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(81, 34);
            this.PrevButton.TabIndex = 8;
            this.PrevButton.Text = "Prev";
            this.PrevButton.UseVisualStyleBackColor = false;
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.NextButton.Font = new System.Drawing.Font("Unispace", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(674, 322);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(76, 34);
            this.NextButton.TabIndex = 7;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = false;
            // 
            // scriptsTableLayoutPanel
            // 
            this.scriptsTableLayoutPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.scriptsTableLayoutPanel.ColumnCount = 4;
            this.scriptsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.scriptsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.scriptsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.scriptsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.scriptsTableLayoutPanel.Font = new System.Drawing.Font("Unispace", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scriptsTableLayoutPanel.Location = new System.Drawing.Point(191, 9);
            this.scriptsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.scriptsTableLayoutPanel.Name = "scriptsTableLayoutPanel";
            this.scriptsTableLayoutPanel.RowCount = 10;
            this.scriptsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.scriptsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.scriptsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.scriptsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.scriptsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.scriptsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.scriptsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.scriptsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.scriptsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.scriptsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.scriptsTableLayoutPanel.Size = new System.Drawing.Size(400, 300);
            this.scriptsTableLayoutPanel.TabIndex = 6;
            // 
            // ScriptManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ScriptPanel);
            this.Controls.Add(this.ReloadButton);
            this.Controls.Add(this.scriptLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScriptManager";
            this.Text = "Script Manager";
            this.Load += new System.EventHandler(this.LoadScripts);
            this.ScriptPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label scriptLabel;
        private System.Windows.Forms.Button ReloadButton;
        private System.Windows.Forms.Panel ScriptPanel;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button PrevButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.TableLayoutPanel scriptsTableLayoutPanel;
    }
}

