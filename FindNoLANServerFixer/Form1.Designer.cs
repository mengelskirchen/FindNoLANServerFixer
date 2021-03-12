namespace FindNoLANServerFixer {
    partial class Form1 {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.cbx_interfaces = new System.Windows.Forms.ComboBox();
            this.lbl_interface = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(339, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Mach den Rest für mich";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbx_interfaces
            // 
            this.cbx_interfaces.FormattingEnabled = true;
            this.cbx_interfaces.Location = new System.Drawing.Point(15, 30);
            this.cbx_interfaces.Name = "cbx_interfaces";
            this.cbx_interfaces.Size = new System.Drawing.Size(257, 21);
            this.cbx_interfaces.TabIndex = 1;
            // 
            // lbl_interface
            // 
            this.lbl_interface.AutoSize = true;
            this.lbl_interface.Location = new System.Drawing.Point(12, 14);
            this.lbl_interface.Name = "lbl_interface";
            this.lbl_interface.Size = new System.Drawing.Size(342, 13);
            this.lbl_interface.TabIndex = 2;
            this.lbl_interface.Text = "Wähle das Netzwerkinterface über dem du den Server finden möchtest";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(282, 32);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Zeige alle";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 89);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lbl_interface);
            this.Controls.Add(this.cbx_interfaces);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Ich finde den Game Server nicht";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbx_interfaces;
        private System.Windows.Forms.Label lbl_interface;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

