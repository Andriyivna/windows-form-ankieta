namespace laboInf4
{
    partial class FormFirst
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
            this.buttonChangeLabel = new System.Windows.Forms.Button();
            this.labelNumberCounter = new System.Windows.Forms.Label();
            this.Picture = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonChangeLabel
            // 
            this.buttonChangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeLabel.Location = new System.Drawing.Point(183, 298);
            this.buttonChangeLabel.Name = "buttonChangeLabel";
            this.buttonChangeLabel.Size = new System.Drawing.Size(133, 47);
            this.buttonChangeLabel.TabIndex = 0;
            this.buttonChangeLabel.Text = "Zmień napis";
            this.buttonChangeLabel.UseVisualStyleBackColor = true;
            this.buttonChangeLabel.Click += new System.EventHandler(this.buttonChangeLabel_Click);
            // 
            // labelNumberCounter
            // 
            this.labelNumberCounter.AutoSize = true;
            this.labelNumberCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumberCounter.Location = new System.Drawing.Point(176, 29);
            this.labelNumberCounter.Name = "labelNumberCounter";
            this.labelNumberCounter.Size = new System.Drawing.Size(433, 39);
            this.labelNumberCounter.TabIndex = 1;
            this.labelNumberCounter.Text = "jeszcze nie zaczołeś liczyć";
            // 
            // Picture
            // 
            this.Picture.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Picture.Location = new System.Drawing.Point(422, 298);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(121, 47);
            this.Picture.TabIndex = 2;
            this.Picture.Text = "Picture";
            this.Picture.UseVisualStyleBackColor = true;
            this.Picture.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormFirst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Picture);
            this.Controls.Add(this.labelNumberCounter);
            this.Controls.Add(this.buttonChangeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormFirst";
            this.Text = "FirstAplication";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonChangeLabel;
        private System.Windows.Forms.Label labelNumberCounter;
        private System.Windows.Forms.Button Picture;
    }
}

