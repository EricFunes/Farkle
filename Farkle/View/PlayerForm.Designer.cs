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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerForm));
            this.lblPlayerName1 = new System.Windows.Forms.Label();
            this.textNameP1 = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textNameP2 = new System.Windows.Forms.TextBox();
            this.lblPlayerName2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayerName1
            // 
            resources.ApplyResources(this.lblPlayerName1, "lblPlayerName1");
            this.errorProvider1.SetError(this.lblPlayerName1, resources.GetString("lblPlayerName1.Error"));
            this.errorProvider1.SetIconAlignment(this.lblPlayerName1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblPlayerName1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lblPlayerName1, ((int)(resources.GetObject("lblPlayerName1.IconPadding"))));
            this.lblPlayerName1.Name = "lblPlayerName1";
            // 
            // textNameP1
            // 
            resources.ApplyResources(this.textNameP1, "textNameP1");
            this.errorProvider1.SetError(this.textNameP1, resources.GetString("textNameP1.Error"));
            this.errorProvider1.SetIconAlignment(this.textNameP1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textNameP1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.textNameP1, ((int)(resources.GetObject("textNameP1.IconPadding"))));
            this.textNameP1.Name = "textNameP1";
            // 
            // btnStart
            // 
            resources.ApplyResources(this.btnStart, "btnStart");
            this.btnStart.BackColor = System.Drawing.Color.LightCyan;
            this.errorProvider1.SetError(this.btnStart, resources.GetString("btnStart.Error"));
            this.errorProvider1.SetIconAlignment(this.btnStart, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnStart.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.btnStart, ((int)(resources.GetObject("btnStart.IconPadding"))));
            this.btnStart.Name = "btnStart";
            this.btnStart.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.errorProvider1.SetError(this.lblTitle, resources.GetString("lblTitle.Error"));
            this.errorProvider1.SetIconAlignment(this.lblTitle, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblTitle.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lblTitle, ((int)(resources.GetObject("lblTitle.IconPadding"))));
            this.lblTitle.Name = "lblTitle";
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.BackColor = System.Drawing.Color.LightCyan;
            this.errorProvider1.SetError(this.btnSave, resources.GetString("btnSave.Error"));
            this.errorProvider1.SetIconAlignment(this.btnSave, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnSave.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.btnSave, ((int)(resources.GetObject("btnSave.IconPadding"))));
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            resources.ApplyResources(this.errorProvider1, "errorProvider1");
            // 
            // textNameP2
            // 
            resources.ApplyResources(this.textNameP2, "textNameP2");
            this.errorProvider1.SetError(this.textNameP2, resources.GetString("textNameP2.Error"));
            this.errorProvider1.SetIconAlignment(this.textNameP2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textNameP2.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.textNameP2, ((int)(resources.GetObject("textNameP2.IconPadding"))));
            this.textNameP2.Name = "textNameP2";
            // 
            // lblPlayerName2
            // 
            resources.ApplyResources(this.lblPlayerName2, "lblPlayerName2");
            this.errorProvider1.SetError(this.lblPlayerName2, resources.GetString("lblPlayerName2.Error"));
            this.errorProvider1.SetIconAlignment(this.lblPlayerName2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblPlayerName2.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lblPlayerName2, ((int)(resources.GetObject("lblPlayerName2.IconPadding"))));
            this.lblPlayerName2.Name = "lblPlayerName2";
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.errorProvider1.SetError(this.comboBox1, resources.GetString("comboBox1.Error"));
            this.comboBox1.FormattingEnabled = true;
            this.errorProvider1.SetIconAlignment(this.comboBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.comboBox1, ((int)(resources.GetObject("comboBox1.IconPadding"))));
            this.comboBox1.Name = "comboBox1";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            resources.ApplyResources(this.imageList1, "imageList1");
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // PlayerForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblPlayerName2);
            this.Controls.Add(this.textNameP2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.textNameP1);
            this.Controls.Add(this.lblPlayerName1);
            this.Name = "PlayerForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerName1;
        private System.Windows.Forms.TextBox textNameP1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblPlayerName2;
        private System.Windows.Forms.TextBox textNameP2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

