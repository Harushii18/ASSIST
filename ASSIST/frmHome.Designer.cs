
namespace ASSIST
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnCheckAssign = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnAddTutor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnCheckAssign);
            this.panel2.Controls.Add(this.btnAddStudent);
            this.panel2.Controls.Add(this.btnAddTutor);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(950, 588);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveForm);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(170)))), ((int)(((byte)(236)))));
            this.panel3.Controls.Add(this.btnMinimize);
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(950, 61);
            this.panel3.TabIndex = 6;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(864, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(34, 35);
            this.btnMinimize.TabIndex = 6;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(904, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 35);
            this.btnClose.TabIndex = 5;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // btnCheckAssign
            // 
            this.btnCheckAssign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(227)))), ((int)(((byte)(250)))));
            this.btnCheckAssign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCheckAssign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckAssign.FlatAppearance.BorderSize = 0;
            this.btnCheckAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckAssign.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCheckAssign.ForeColor = System.Drawing.Color.Black;
            this.btnCheckAssign.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckAssign.Image")));
            this.btnCheckAssign.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckAssign.Location = new System.Drawing.Point(720, 518);
            this.btnCheckAssign.Name = "btnCheckAssign";
            this.btnCheckAssign.Size = new System.Drawing.Size(155, 70);
            this.btnCheckAssign.TabIndex = 5;
            this.btnCheckAssign.Text = "Check Assignments";
            this.btnCheckAssign.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCheckAssign.UseVisualStyleBackColor = false;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(227)))), ((int)(((byte)(250)))));
            this.btnAddStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStudent.FlatAppearance.BorderSize = 0;
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddStudent.ForeColor = System.Drawing.Color.Black;
            this.btnAddStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnAddStudent.Image")));
            this.btnAddStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddStudent.Location = new System.Drawing.Point(404, 518);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(155, 70);
            this.btnAddStudent.TabIndex = 4;
            this.btnAddStudent.Text = "Add student";
            this.btnAddStudent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddStudent.UseVisualStyleBackColor = false;
            // 
            // btnAddTutor
            // 
            this.btnAddTutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(227)))), ((int)(((byte)(250)))));
            this.btnAddTutor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddTutor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTutor.FlatAppearance.BorderSize = 0;
            this.btnAddTutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTutor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddTutor.ForeColor = System.Drawing.Color.Black;
            this.btnAddTutor.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTutor.Image")));
            this.btnAddTutor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTutor.Location = new System.Drawing.Point(78, 518);
            this.btnAddTutor.Name = "btnAddTutor";
            this.btnAddTutor.Size = new System.Drawing.Size(155, 70);
            this.btnAddTutor.TabIndex = 3;
            this.btnAddTutor.Text = "Add tutor";
            this.btnAddTutor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddTutor.UseVisualStyleBackColor = false;
            this.btnAddTutor.Click += new System.EventHandler(this.button1_Click);
            this.btnAddTutor.MouseHover += new System.EventHandler(this.mouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(167)))), ((int)(((byte)(233)))));
            this.label2.Location = new System.Drawing.Point(454, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(455, 99);
            this.label2.TabIndex = 1;
            this.label2.Text = "THE ASSIST";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(61, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME TO";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 588);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveForm);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddTutor;
        private System.Windows.Forms.Button btnCheckAssign;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnClose;
    }
}

