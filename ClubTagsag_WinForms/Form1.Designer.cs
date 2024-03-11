namespace ClubTagsag_WinForms
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
            this.listBox_Members = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.textBox_Fullname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Entry = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Raiting = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_torol = new System.Windows.Forms.Button();
            this.button_modosit = new System.Windows.Forms.Button();
            this.button_uj = new System.Windows.Forms.Button();
            this.button_frissit = new System.Windows.Forms.Button();
            this.comboBox_Interest = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listBox_Members
            // 
            this.listBox_Members.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_Members.FormattingEnabled = true;
            this.listBox_Members.ItemHeight = 16;
            this.listBox_Members.Location = new System.Drawing.Point(0, 0);
            this.listBox_Members.Name = "listBox_Members";
            this.listBox_Members.Size = new System.Drawing.Size(255, 450);
            this.listBox_Members.TabIndex = 0;
            this.listBox_Members.SelectedIndexChanged += new System.EventHandler(this.listBox_Members_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            // 
            // textBox_Id
            // 
            this.textBox_Id.Enabled = false;
            this.textBox_Id.Location = new System.Drawing.Point(296, 58);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(100, 22);
            this.textBox_Id.TabIndex = 2;
            // 
            // textBox_Fullname
            // 
            this.textBox_Fullname.Location = new System.Drawing.Point(486, 58);
            this.textBox_Fullname.Name = "textBox_Fullname";
            this.textBox_Fullname.Size = new System.Drawing.Size(150, 22);
            this.textBox_Fullname.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(483, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fullname";
            // 
            // textBox_Entry
            // 
            this.textBox_Entry.Location = new System.Drawing.Point(296, 138);
            this.textBox_Entry.Name = "textBox_Entry";
            this.textBox_Entry.Size = new System.Drawing.Size(150, 22);
            this.textBox_Entry.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Entry";
            // 
            // textBox_Raiting
            // 
            this.textBox_Raiting.Location = new System.Drawing.Point(486, 138);
            this.textBox_Raiting.Name = "textBox_Raiting";
            this.textBox_Raiting.Size = new System.Drawing.Size(150, 22);
            this.textBox_Raiting.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(483, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Raiting";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(483, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Interest";
            // 
            // button_torol
            // 
            this.button_torol.Location = new System.Drawing.Point(509, 367);
            this.button_torol.Margin = new System.Windows.Forms.Padding(4);
            this.button_torol.Name = "button_torol";
            this.button_torol.Size = new System.Drawing.Size(100, 35);
            this.button_torol.TabIndex = 16;
            this.button_torol.Text = "Töröl";
            this.button_torol.UseVisualStyleBackColor = true;
            this.button_torol.Click += new System.EventHandler(this.button_torol_Click);
            // 
            // button_modosit
            // 
            this.button_modosit.Location = new System.Drawing.Point(319, 367);
            this.button_modosit.Margin = new System.Windows.Forms.Padding(4);
            this.button_modosit.Name = "button_modosit";
            this.button_modosit.Size = new System.Drawing.Size(100, 35);
            this.button_modosit.TabIndex = 15;
            this.button_modosit.Text = "Módosít";
            this.button_modosit.UseVisualStyleBackColor = true;
            this.button_modosit.Click += new System.EventHandler(this.button_modosit_Click);
            // 
            // button_uj
            // 
            this.button_uj.Location = new System.Drawing.Point(319, 283);
            this.button_uj.Margin = new System.Windows.Forms.Padding(4);
            this.button_uj.Name = "button_uj";
            this.button_uj.Size = new System.Drawing.Size(100, 35);
            this.button_uj.TabIndex = 14;
            this.button_uj.Text = "Új";
            this.button_uj.UseVisualStyleBackColor = true;
            this.button_uj.Click += new System.EventHandler(this.button_uj_Click);
            // 
            // button_frissit
            // 
            this.button_frissit.Location = new System.Drawing.Point(509, 283);
            this.button_frissit.Margin = new System.Windows.Forms.Padding(4);
            this.button_frissit.Name = "button_frissit";
            this.button_frissit.Size = new System.Drawing.Size(100, 35);
            this.button_frissit.TabIndex = 13;
            this.button_frissit.Text = "Frissít";
            this.button_frissit.UseVisualStyleBackColor = true;
            this.button_frissit.Click += new System.EventHandler(this.button_frissit_Click);
            // 
            // comboBox_Interest
            // 
            this.comboBox_Interest.FormattingEnabled = true;
            this.comboBox_Interest.Location = new System.Drawing.Point(486, 202);
            this.comboBox_Interest.Name = "comboBox_Interest";
            this.comboBox_Interest.Size = new System.Drawing.Size(150, 24);
            this.comboBox_Interest.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 450);
            this.Controls.Add(this.comboBox_Interest);
            this.Controls.Add(this.button_torol);
            this.Controls.Add(this.button_modosit);
            this.Controls.Add(this.button_uj);
            this.Controls.Add(this.button_frissit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Raiting);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Entry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Fullname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_Members);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Members;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.TextBox textBox_Fullname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Entry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Raiting;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_torol;
        private System.Windows.Forms.Button button_modosit;
        private System.Windows.Forms.Button button_uj;
        private System.Windows.Forms.Button button_frissit;
        private System.Windows.Forms.ComboBox comboBox_Interest;
    }
}

