namespace Farkle.View
{
    partial class PlayerForm
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
            this.components = new System.ComponentModel.Container();
            this.lblPlayerName1 = new System.Windows.Forms.Label();
            this.textNameP1 = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.radioFrench = new System.Windows.Forms.RadioButton();
            this.radioEnglish = new System.Windows.Forms.RadioButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textNameP2 = new System.Windows.Forms.TextBox();
            this.lblPlayerName2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayerName1
            // 
            this.lblPlayerName1.AutoSize = true;
            this.lblPlayerName1.Location = new System.Drawing.Point(21, 156);
            this.lblPlayerName1.Name = "lblPlayerName1";
            this.lblPlayerName1.Size = new System.Drawing.Size(56, 25);
            this.lblPlayerName1.TabIndex = 0;
            this.lblPlayerName1.Text = "Nom";
            // 
            // textNameP1
            // 
            this.textNameP1.Location = new System.Drawing.Point(94, 153);
            this.textNameP1.Name = "textNameP1";
            this.textNameP1.Size = new System.Drawing.Size(196, 31);
            this.textNameP1.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.AutoSize = true;
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(506, 211);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(94, 35);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Jouer";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // radioFrench
            // 
            this.radioFrench.AutoSize = true;
            this.radioFrench.Checked = true;
            this.radioFrench.Location = new System.Drawing.Point(486, 18);
            this.radioFrench.Name = "radioFrench";
            this.radioFrench.Size = new System.Drawing.Size(126, 29);
            this.radioFrench.TabIndex = 3;
            this.radioFrench.TabStop = true;
            this.radioFrench.Text = "Français";
            this.radioFrench.UseVisualStyleBackColor = true;
            // 
            // radioEnglish
            // 
            this.radioEnglish.AutoSize = true;
            this.radioEnglish.Location = new System.Drawing.Point(486, 62);
            this.radioEnglish.Name = "radioEnglish";
            this.radioEnglish.Size = new System.Drawing.Size(114, 29);
            this.radioEnglish.TabIndex = 4;
            this.radioEnglish.Text = "English";
            this.radioEnglish.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(33, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(72, 25);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Farkle";
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(486, 153);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 35);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // textNameP2
            // 
            this.textNameP2.Location = new System.Drawing.Point(94, 214);
            this.textNameP2.Name = "textNameP2";
            this.textNameP2.Size = new System.Drawing.Size(196, 31);
            this.textNameP2.TabIndex = 9;
            // 
            // lblPlayerName2
            // 
            this.lblPlayerName2.AutoSize = true;
            this.lblPlayerName2.Location = new System.Drawing.Point(21, 220);
            this.lblPlayerName2.Name = "lblPlayerName2";
            this.lblPlayerName2.Size = new System.Drawing.Size(56, 25);
            this.lblPlayerName2.TabIndex = 10;
            this.lblPlayerName2.Text = "Nom";
            // 
            // PlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 290);
            this.Controls.Add(this.lblPlayerName2);
            this.Controls.Add(this.textNameP2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.radioEnglish);
            this.Controls.Add(this.radioFrench);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.textNameP1);
            this.Controls.Add(this.lblPlayerName1);
            this.Name = "PlayerForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerName1;
        private System.Windows.Forms.TextBox textNameP1;
        private System.Windows.Forms.Button btnStart;
        protected System.Windows.Forms.RadioButton radioFrench;
        private System.Windows.Forms.RadioButton radioEnglish;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblPlayerName2;
        private System.Windows.Forms.TextBox textNameP2;
    }
}

