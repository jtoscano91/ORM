namespace MusicAdmin
{
    partial class Form1
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
            this.artistCombo = new System.Windows.Forms.ComboBox();
            this.songsGridView = new System.Windows.Forms.DataGridView();
            this.albumCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.songsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // artistCombo
            // 
            this.artistCombo.FormattingEnabled = true;
            this.artistCombo.Location = new System.Drawing.Point(84, 48);
            this.artistCombo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.artistCombo.Name = "artistCombo";
            this.artistCombo.Size = new System.Drawing.Size(160, 24);
            this.artistCombo.TabIndex = 0;
            this.artistCombo.SelectedIndexChanged += new System.EventHandler(this.artistCombo_SelectedIndexChanged);
            // 
            // songsGridView
            // 
            this.songsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.songsGridView.Location = new System.Drawing.Point(36, 97);
            this.songsGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.songsGridView.Name = "songsGridView";
            this.songsGridView.Size = new System.Drawing.Size(1015, 421);
            this.songsGridView.TabIndex = 1;
            // 
            // albumCombo
            // 
            this.albumCombo.FormattingEnabled = true;
            this.albumCombo.Location = new System.Drawing.Point(337, 48);
            this.albumCombo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.albumCombo.Name = "albumCombo";
            this.albumCombo.Size = new System.Drawing.Size(160, 24);
            this.albumCombo.TabIndex = 2;
            this.albumCombo.SelectedIndexChanged += new System.EventHandler(this.albumCombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Artist";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Album";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.albumCombo);
            this.Controls.Add(this.songsGridView);
            this.Controls.Add(this.artistCombo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.songsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox artistCombo;
        private System.Windows.Forms.DataGridView songsGridView;
        private System.Windows.Forms.ComboBox albumCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

