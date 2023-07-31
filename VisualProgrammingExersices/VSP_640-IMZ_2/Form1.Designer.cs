
namespace VSP_640_IMZ_2
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonBulgarian = new System.Windows.Forms.Button();
            this.buttonEnglish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonOK.Location = new System.Drawing.Point(148, 148);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(143, 45);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonBulgarian
            // 
            this.buttonBulgarian.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBulgarian.Image = global::VSP_640_IMZ_2.Properties.Resources.BG_Flag;
            this.buttonBulgarian.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBulgarian.Location = new System.Drawing.Point(283, 30);
            this.buttonBulgarian.Name = "buttonBulgarian";
            this.buttonBulgarian.Size = new System.Drawing.Size(120, 45);
            this.buttonBulgarian.TabIndex = 1;
            this.buttonBulgarian.Text = "Bulgarian";
            this.buttonBulgarian.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBulgarian.UseVisualStyleBackColor = true;
            this.buttonBulgarian.Click += new System.EventHandler(this.buttonBulgarian_Click);
            // 
            // buttonEnglish
            // 
            this.buttonEnglish.Image = global::VSP_640_IMZ_2.Properties.Resources.UK_Flag;
            this.buttonEnglish.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEnglish.Location = new System.Drawing.Point(30, 30);
            this.buttonEnglish.Name = "buttonEnglish";
            this.buttonEnglish.Size = new System.Drawing.Size(120, 45);
            this.buttonEnglish.TabIndex = 0;
            this.buttonEnglish.Text = "English";
            this.buttonEnglish.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEnglish.UseVisualStyleBackColor = true;
            this.buttonEnglish.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 226);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonBulgarian);
            this.Controls.Add(this.buttonEnglish);
            this.Name = "Form1";
            this.Text = "English";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEnglish;
        private System.Windows.Forms.Button buttonBulgarian;
        private System.Windows.Forms.Button buttonOK;
    }
}

