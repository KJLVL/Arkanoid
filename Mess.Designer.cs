
namespace Arkanoid
{
    partial class Mess
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
            this.label1 = new System.Windows.Forms.Label();
            this.yesB = new System.Windows.Forms.Button();
            this.noB = new System.Windows.Forms.Button();
            this.rec = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Начать заново?";
            // 
            // yesB
            // 
            this.yesB.BackColor = System.Drawing.Color.Gray;
            this.yesB.FlatAppearance.BorderSize = 3;
            this.yesB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yesB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yesB.Location = new System.Drawing.Point(39, 84);
            this.yesB.Name = "yesB";
            this.yesB.Size = new System.Drawing.Size(75, 51);
            this.yesB.TabIndex = 1;
            this.yesB.Text = "да";
            this.yesB.UseVisualStyleBackColor = false;
            this.yesB.Click += new System.EventHandler(this.yesB_Click);
            // 
            // noB
            // 
            this.noB.BackColor = System.Drawing.Color.Gray;
            this.noB.FlatAppearance.BorderSize = 3;
            this.noB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noB.Location = new System.Drawing.Point(137, 84);
            this.noB.Name = "noB";
            this.noB.Size = new System.Drawing.Size(75, 51);
            this.noB.TabIndex = 2;
            this.noB.Text = "нет";
            this.noB.UseVisualStyleBackColor = false;
            this.noB.Click += new System.EventHandler(this.noB_Click);
            // 
            // rec
            // 
            this.rec.AutoSize = true;
            this.rec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rec.ForeColor = System.Drawing.Color.Maroon;
            this.rec.Location = new System.Drawing.Point(34, 155);
            this.rec.Name = "rec";
            this.rec.Size = new System.Drawing.Size(133, 22);
            this.rec.TabIndex = 3;
            this.rec.Text = "Ваш рекорд: ";
            // 
            // Mess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(252, 194);
            this.Controls.Add(this.rec);
            this.Controls.Add(this.noB);
            this.Controls.Add(this.yesB);
            this.Controls.Add(this.label1);
            this.Name = "Mess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button yesB;
        private System.Windows.Forms.Button noB;
        private System.Windows.Forms.Label rec;
    }
}