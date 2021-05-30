
namespace Contact_Tracing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_Vorname = new System.Windows.Forms.TextBox();
            this.txt_Nachname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Liste = new System.Windows.Forms.TextBox();
            this.btn_hinzufügen = new System.Windows.Forms.Button();
            this.btn_ListeLöschen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Anwesenheit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Vorname
            // 
            this.txt_Vorname.Location = new System.Drawing.Point(249, 71);
            this.txt_Vorname.Name = "txt_Vorname";
            this.txt_Vorname.Size = new System.Drawing.Size(100, 23);
            this.txt_Vorname.TabIndex = 0;
            // 
            // txt_Nachname
            // 
            this.txt_Nachname.Location = new System.Drawing.Point(249, 135);
            this.txt_Nachname.Name = "txt_Nachname";
            this.txt_Nachname.Size = new System.Drawing.Size(100, 23);
            this.txt_Nachname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vorname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nachname:";
            // 
            // txt_Liste
            // 
            this.txt_Liste.AcceptsReturn = true;
            this.txt_Liste.Location = new System.Drawing.Point(452, 71);
            this.txt_Liste.Multiline = true;
            this.txt_Liste.Name = "txt_Liste";
            this.txt_Liste.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Liste.Size = new System.Drawing.Size(160, 190);
            this.txt_Liste.TabIndex = 4;
            // 
            // btn_hinzufügen
            // 
            this.btn_hinzufügen.Location = new System.Drawing.Point(249, 186);
            this.btn_hinzufügen.Name = "btn_hinzufügen";
            this.btn_hinzufügen.Size = new System.Drawing.Size(99, 23);
            this.btn_hinzufügen.TabIndex = 5;
            this.btn_hinzufügen.Text = "Hinzufügen";
            this.btn_hinzufügen.UseVisualStyleBackColor = true;
            this.btn_hinzufügen.Click += new System.EventHandler(this.btn_hinzufügen_Click);
            // 
            // btn_ListeLöschen
            // 
            this.btn_ListeLöschen.Location = new System.Drawing.Point(249, 238);
            this.btn_ListeLöschen.Name = "btn_ListeLöschen";
            this.btn_ListeLöschen.Size = new System.Drawing.Size(98, 23);
            this.btn_ListeLöschen.TabIndex = 6;
            this.btn_ListeLöschen.Text = "Liste löschen";
            this.btn_ListeLöschen.UseVisualStyleBackColor = true;
            this.btn_ListeLöschen.Click += new System.EventHandler(this.btn_ListeLöschen_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            // 
            // lbl_Anwesenheit
            // 
            this.lbl_Anwesenheit.AutoSize = true;
            this.lbl_Anwesenheit.Location = new System.Drawing.Point(310, 388);
            this.lbl_Anwesenheit.Name = "lbl_Anwesenheit";
            this.lbl_Anwesenheit.Size = new System.Drawing.Size(33, 15);
            this.lbl_Anwesenheit.TabIndex = 9;
            this.lbl_Anwesenheit.Text = "hallo";
            this.lbl_Anwesenheit.Click += new System.EventHandler(this.lbl_Anwesenheit);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Anwesenheit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_ListeLöschen);
            this.Controls.Add(this.btn_hinzufügen);
            this.Controls.Add(this.txt_Liste);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Nachname);
            this.Controls.Add(this.txt_Vorname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Vorname;
        private System.Windows.Forms.TextBox txt_Nachname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Liste;
        private System.Windows.Forms.Button btn_hinzufügen;
        private System.Windows.Forms.Button btn_ListeLöschen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Anwesenheit;
    }
}

