
namespace Automobile_Information
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtMileage = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.lstCars = new System.Windows.Forms.ListBox();
            this.btnLoadList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mileage";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(145, 103);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(150, 31);
            this.txtYear.TabIndex = 3;
            // 
            // txtMileage
            // 
            this.txtMileage.Location = new System.Drawing.Point(145, 156);
            this.txtMileage.Name = "txtMileage";
            this.txtMileage.Size = new System.Drawing.Size(150, 31);
            this.txtMileage.TabIndex = 4;
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(145, 43);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(150, 31);
            this.txtMake.TabIndex = 5;
            // 
            // lstCars
            // 
            this.lstCars.FormattingEnabled = true;
            this.lstCars.ItemHeight = 25;
            this.lstCars.Location = new System.Drawing.Point(325, 43);
            this.lstCars.Name = "lstCars";
            this.lstCars.Size = new System.Drawing.Size(653, 379);
            this.lstCars.TabIndex = 6;
            this.lstCars.SelectedIndexChanged += new System.EventHandler(this.lstCars_SelectedIndexChanged);
            // 
            // btnLoadList
            // 
            this.btnLoadList.Location = new System.Drawing.Point(65, 362);
            this.btnLoadList.Name = "btnLoadList";
            this.btnLoadList.Size = new System.Drawing.Size(112, 34);
            this.btnLoadList.TabIndex = 7;
            this.btnLoadList.Text = "Load List";
            this.btnLoadList.UseVisualStyleBackColor = true;
            this.btnLoadList.Click += new System.EventHandler(this.btnLoadList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 450);
            this.Controls.Add(this.btnLoadList);
            this.Controls.Add(this.lstCars);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.txtMileage);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Automobile";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtMileage;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.ListBox lstCars;
        private System.Windows.Forms.Button btnLoadList;
    }
}

