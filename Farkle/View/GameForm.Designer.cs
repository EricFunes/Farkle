namespace Farkle.View
{
    partial class GameForm
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
            this.btnRoll = new System.Windows.Forms.Button();
            this.btnSelection = new System.Windows.Forms.Button();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblRegles = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(165, 302);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(75, 23);
            this.btnRoll.TabIndex = 12;
            this.btnRoll.Text = "Lancer";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // btnSelection
            // 
            this.btnSelection.Location = new System.Drawing.Point(273, 301);
            this.btnSelection.Name = "btnSelection";
            this.btnSelection.Size = new System.Drawing.Size(75, 23);
            this.btnSelection.TabIndex = 19;
            this.btnSelection.Text = "Selectionner";
            this.btnSelection.UseVisualStyleBackColor = true;
            this.btnSelection.Click += new System.EventHandler(this.btnSelection_Click);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(612, 21);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(45, 13);
            this.lblNom.TabIndex = 20;
            this.lblNom.Text = "Thomas";
            this.lblNom.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(622, 48);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(35, 13);
            this.lblScore.TabIndex = 21;
            this.lblScore.Text = "Score";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblRegles
            // 
            this.lblRegles.AutoSize = true;
            this.lblRegles.Location = new System.Drawing.Point(533, 191);
            this.lblRegles.Name = "lblRegles";
            this.lblRegles.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRegles.Size = new System.Drawing.Size(124, 156);
            this.lblRegles.TabIndex = 22;
            this.lblRegles.Text = "Combinaisons possibles :\n\n5 = 50 pt\n1 = 100 pt\n222 = 200 pt\n333 = 300 pt\n444 = 40" +
    "0 pt\n555 = 500 pt\n666 = 600 pt\n111 = 1000 pt\nTrois paires = 1500 pt\n123456 = 300" +
    "0 pt";
            this.lblRegles.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 356);
            this.Controls.Add(this.lblRegles);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.btnSelection);
            this.Controls.Add(this.btnRoll);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Button btnSelection;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblRegles;
    }
}