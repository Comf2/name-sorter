namespace name_sorter
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
            this.btnSort = new System.Windows.Forms.Button();
            this.lstName = new System.Windows.Forms.ListBox();
            this.lstAlph = new System.Windows.Forms.ListBox();
            this.lstRvrsAlph = new System.Windows.Forms.ListBox();
            this.lstLastName = new System.Windows.Forms.ListBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtALph = new System.Windows.Forms.TextBox();
            this.txtRvrsAlpha = new System.Windows.Forms.TextBox();
            this.txtLastNames = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSort
            // 
            this.btnSort.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSort.Location = new System.Drawing.Point(62, 12);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(88, 42);
            this.btnSort.TabIndex = 0;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // lstName
            // 
            this.lstName.FormattingEnabled = true;
            this.lstName.ItemHeight = 15;
            this.lstName.Location = new System.Drawing.Point(62, 113);
            this.lstName.Name = "lstName";
            this.lstName.Size = new System.Drawing.Size(267, 544);
            this.lstName.TabIndex = 1;
            // 
            // lstAlph
            // 
            this.lstAlph.FormattingEnabled = true;
            this.lstAlph.ItemHeight = 15;
            this.lstAlph.Location = new System.Drawing.Point(382, 113);
            this.lstAlph.Name = "lstAlph";
            this.lstAlph.Size = new System.Drawing.Size(267, 544);
            this.lstAlph.TabIndex = 2;
            // 
            // lstRvrsAlph
            // 
            this.lstRvrsAlph.FormattingEnabled = true;
            this.lstRvrsAlph.ItemHeight = 15;
            this.lstRvrsAlph.Location = new System.Drawing.Point(721, 113);
            this.lstRvrsAlph.Name = "lstRvrsAlph";
            this.lstRvrsAlph.Size = new System.Drawing.Size(267, 544);
            this.lstRvrsAlph.TabIndex = 3;
            // 
            // lstLastName
            // 
            this.lstLastName.FormattingEnabled = true;
            this.lstLastName.ItemHeight = 15;
            this.lstLastName.Location = new System.Drawing.Point(1081, 113);
            this.lstLastName.Name = "lstLastName";
            this.lstLastName.Size = new System.Drawing.Size(267, 544);
            this.lstLastName.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(62, 75);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(100, 29);
            this.txtName.TabIndex = 5;
            this.txtName.Text = "Names";
            // 
            // txtALph
            // 
            this.txtALph.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtALph.Location = new System.Drawing.Point(382, 75);
            this.txtALph.Name = "txtALph";
            this.txtALph.ReadOnly = true;
            this.txtALph.Size = new System.Drawing.Size(107, 29);
            this.txtALph.TabIndex = 6;
            this.txtALph.Text = "Alphabetically";
            // 
            // txtRvrsAlpha
            // 
            this.txtRvrsAlpha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRvrsAlpha.Location = new System.Drawing.Point(721, 75);
            this.txtRvrsAlpha.Name = "txtRvrsAlpha";
            this.txtRvrsAlpha.ReadOnly = true;
            this.txtRvrsAlpha.Size = new System.Drawing.Size(163, 29);
            this.txtRvrsAlpha.TabIndex = 7;
            this.txtRvrsAlpha.Text = "Reverse Alphabetically";
            // 
            // txtLastNames
            // 
            this.txtLastNames.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLastNames.Location = new System.Drawing.Point(1081, 75);
            this.txtLastNames.Name = "txtLastNames";
            this.txtLastNames.ReadOnly = true;
            this.txtLastNames.Size = new System.Drawing.Size(100, 29);
            this.txtLastNames.TabIndex = 8;
            this.txtLastNames.Text = "Last Names";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 812);
            this.Controls.Add(this.txtLastNames);
            this.Controls.Add(this.txtRvrsAlpha);
            this.Controls.Add(this.txtALph);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lstLastName);
            this.Controls.Add(this.lstRvrsAlph);
            this.Controls.Add(this.lstAlph);
            this.Controls.Add(this.lstName);
            this.Controls.Add(this.btnSort);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSort;
        private ListBox lstName;
        private ListBox lstAlph;
        private ListBox lstRvrsAlph;
        private ListBox lstLastName;
        private TextBox txtName;
        private TextBox txtALph;
        private TextBox txtRvrsAlpha;
        private TextBox txtLastNames;
    }
}