namespace MathBlockBuilder_v2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.check_Btn = new System.Windows.Forms.Button();
            this.label_Inst = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.next_Btn = new System.Windows.Forms.PictureBox();
            this.select_Btn = new System.Windows.Forms.PictureBox();
            this.prev_Btn = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.next_Btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.select_Btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prev_Btn)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(12, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(292, 23);
            this.textBox1.TabIndex = 43;
            // 
            // check_Btn
            // 
            this.check_Btn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_Btn.Location = new System.Drawing.Point(942, 26);
            this.check_Btn.Name = "check_Btn";
            this.check_Btn.Size = new System.Drawing.Size(82, 33);
            this.check_Btn.TabIndex = 42;
            this.check_Btn.Text = "Progress";
            this.check_Btn.UseVisualStyleBackColor = true;
            this.check_Btn.Click += new System.EventHandler(this.check_Btn_Click);
            // 
            // label_Inst
            // 
            this.label_Inst.AutoSize = true;
            this.label_Inst.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Inst.Location = new System.Drawing.Point(14, 9);
            this.label_Inst.Name = "label_Inst";
            this.label_Inst.Size = new System.Drawing.Size(376, 24);
            this.label_Inst.TabIndex = 41;
            this.label_Inst.Text = "Build and match with the correct block. ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(540, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 81);
            this.label1.TabIndex = 36;
            this.label1.Text = "=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(231, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 81);
            this.label2.TabIndex = 35;
            this.label2.Text = "+";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(744, 255);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(50, 43);
            this.textBox2.TabIndex = 44;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.next_Btn);
            this.panel1.Controls.Add(this.select_Btn);
            this.panel1.Controls.Add(this.prev_Btn);
            this.panel1.Location = new System.Drawing.Point(944, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(80, 236);
            this.panel1.TabIndex = 45;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(12, 286);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(232, 38);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 46;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::MathBlockBuilder_v2.Properties.Resources.blk_10;
            this.pictureBox3.Location = new System.Drawing.Point(630, 74);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(303, 224);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 37;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::MathBlockBuilder_v2.Properties.Resources.blk_10;
            this.pictureBox2.Location = new System.Drawing.Point(321, 74);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(303, 224);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::MathBlockBuilder_v2.Properties.Resources.blk_9;
            this.pictureBox1.Location = new System.Drawing.Point(12, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // next_Btn
            // 
            this.next_Btn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.next_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.next_Btn.Image = global::MathBlockBuilder_v2.Properties.Resources.next_Btn;
            this.next_Btn.Location = new System.Drawing.Point(3, 3);
            this.next_Btn.Name = "next_Btn";
            this.next_Btn.Size = new System.Drawing.Size(68, 70);
            this.next_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.next_Btn.TabIndex = 39;
            this.next_Btn.TabStop = false;
            this.next_Btn.Click += new System.EventHandler(this.next_Btn_Click);
            // 
            // select_Btn
            // 
            this.select_Btn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.select_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.select_Btn.Image = global::MathBlockBuilder_v2.Properties.Resources.select_Btn;
            this.select_Btn.Location = new System.Drawing.Point(3, 155);
            this.select_Btn.Name = "select_Btn";
            this.select_Btn.Size = new System.Drawing.Size(70, 70);
            this.select_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.select_Btn.TabIndex = 40;
            this.select_Btn.TabStop = false;
            this.select_Btn.Click += new System.EventHandler(this.select_Btn_Click);
            // 
            // prev_Btn
            // 
            this.prev_Btn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.prev_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.prev_Btn.Image = global::MathBlockBuilder_v2.Properties.Resources.prev_Btn;
            this.prev_Btn.Location = new System.Drawing.Point(3, 79);
            this.prev_Btn.Name = "prev_Btn";
            this.prev_Btn.Size = new System.Drawing.Size(68, 70);
            this.prev_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.prev_Btn.TabIndex = 38;
            this.prev_Btn.TabStop = false;
            this.prev_Btn.Click += new System.EventHandler(this.prev_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1032, 327);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.check_Btn);
            this.Controls.Add(this.label_Inst);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Math Block Build v2";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.next_Btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.select_Btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prev_Btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox select_Btn;
        private System.Windows.Forms.PictureBox next_Btn;
        private System.Windows.Forms.PictureBox prev_Btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button check_Btn;
        private System.Windows.Forms.Label label_Inst;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

