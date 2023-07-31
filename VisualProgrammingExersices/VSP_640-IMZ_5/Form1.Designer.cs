
namespace VSP_640_IMZ_5
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.labelSize = new System.Windows.Forms.Label();
            this.buttonCentre = new System.Windows.Forms.Button();
            this.buttonItalic = new System.Windows.Forms.Button();
            this.buttonUnderline = new System.Windows.Forms.Button();
            this.buttonBold = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBoxText = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.buttonLoad);
            this.panel1.Controls.Add(this.textBoxSize);
            this.panel1.Controls.Add(this.labelSize);
            this.panel1.Controls.Add(this.buttonCentre);
            this.panel1.Controls.Add(this.buttonItalic);
            this.panel1.Controls.Add(this.buttonUnderline);
            this.panel1.Controls.Add(this.buttonBold);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 40);
            this.panel1.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(582, 8);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(490, 8);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 6;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // textBoxSize
            // 
            this.textBoxSize.Location = new System.Drawing.Point(380, 10);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(67, 20);
            this.textBoxSize.TabIndex = 5;
            this.textBoxSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSize_KeyPress);
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(347, 14);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(27, 13);
            this.labelSize.TabIndex = 4;
            this.labelSize.Text = "Size";
            // 
            // buttonCentre
            // 
            this.buttonCentre.Location = new System.Drawing.Point(263, 8);
            this.buttonCentre.Name = "buttonCentre";
            this.buttonCentre.Size = new System.Drawing.Size(75, 23);
            this.buttonCentre.TabIndex = 3;
            this.buttonCentre.Text = "Centre";
            this.buttonCentre.UseVisualStyleBackColor = true;
            this.buttonCentre.Click += new System.EventHandler(this.buttonCentre_Click);
            // 
            // buttonItalic
            // 
            this.buttonItalic.Location = new System.Drawing.Point(178, 8);
            this.buttonItalic.Name = "buttonItalic";
            this.buttonItalic.Size = new System.Drawing.Size(75, 23);
            this.buttonItalic.TabIndex = 2;
            this.buttonItalic.Text = "Italic";
            this.buttonItalic.UseVisualStyleBackColor = true;
            this.buttonItalic.Click += new System.EventHandler(this.buttonItalic_Click);
            // 
            // buttonUnderline
            // 
            this.buttonUnderline.Location = new System.Drawing.Point(93, 8);
            this.buttonUnderline.Name = "buttonUnderline";
            this.buttonUnderline.Size = new System.Drawing.Size(75, 23);
            this.buttonUnderline.TabIndex = 1;
            this.buttonUnderline.Text = "Underline";
            this.buttonUnderline.UseVisualStyleBackColor = true;
            this.buttonUnderline.Click += new System.EventHandler(this.buttonUnderline_Click);
            // 
            // buttonBold
            // 
            this.buttonBold.Location = new System.Drawing.Point(8, 8);
            this.buttonBold.Name = "buttonBold";
            this.buttonBold.Size = new System.Drawing.Size(75, 23);
            this.buttonBold.TabIndex = 0;
            this.buttonBold.Text = "Bold";
            this.buttonBold.UseVisualStyleBackColor = true;
            this.buttonBold.Click += new System.EventHandler(this.buttonBold_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.richTextBoxText);
            this.panel2.Location = new System.Drawing.Point(12, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(676, 360);
            this.panel2.TabIndex = 1;
            // 
            // richTextBoxText
            // 
            this.richTextBoxText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxText.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxText.Name = "richTextBoxText";
            this.richTextBoxText.Size = new System.Drawing.Size(676, 360);
            this.richTextBoxText.TabIndex = 0;
            this.richTextBoxText.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(716, 489);
            this.Name = "Form1";
            this.Text = "Елементарен текстов редактор";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.TextBox textBoxSize;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Button buttonCentre;
        private System.Windows.Forms.Button buttonItalic;
        private System.Windows.Forms.Button buttonUnderline;
        private System.Windows.Forms.Button buttonBold;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBoxText;
        const string MyFile = "Test.rtf";
    }
}

