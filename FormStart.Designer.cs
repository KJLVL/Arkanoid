
namespace Arkanoid
{
    partial class FormStart
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
            this.startB = new System.Windows.Forms.Button();
            this.cB1 = new System.Windows.Forms.ComboBox();
            this.err = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startB
            // 
            this.startB.BackColor = System.Drawing.Color.Gray;
            this.startB.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.startB.FlatAppearance.BorderSize = 4;
            this.startB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startB.ForeColor = System.Drawing.Color.Maroon;
            this.startB.Location = new System.Drawing.Point(141, 147);
            this.startB.Name = "startB";
            this.startB.Size = new System.Drawing.Size(271, 63);
            this.startB.TabIndex = 4;
            this.startB.Text = "СТАРТ";
            this.startB.UseVisualStyleBackColor = false;
            this.startB.Click += new System.EventHandler(this.startB_Click);
            // 
            // cB1
            // 
            this.cB1.BackColor = System.Drawing.Color.Gray;
            this.cB1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cB1.FormattingEnabled = true;
            this.cB1.Items.AddRange(new object[] {
            "легкий",
            "средний",
            "сложный"});
            this.cB1.Location = new System.Drawing.Point(103, 234);
            this.cB1.Name = "cB1";
            this.cB1.Size = new System.Drawing.Size(348, 30);
            this.cB1.TabIndex = 5;
            this.cB1.Text = "Выберите уровень сложности";
            // 
            // err
            // 
            this.err.AutoSize = true;
            this.err.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.err.Location = new System.Drawing.Point(103, 287);
            this.err.Name = "err";
            this.err.Size = new System.Drawing.Size(0, 20);
            this.err.TabIndex = 6;
            this.err.Visible = false;
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(582, 417);
            this.Controls.Add(this.err);
            this.Controls.Add(this.cB1);
            this.Controls.Add(this.startB);
            this.Name = "FormStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormStart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button startB;
        private System.Windows.Forms.ComboBox cB1;
        private System.Windows.Forms.Label err;
    }
}