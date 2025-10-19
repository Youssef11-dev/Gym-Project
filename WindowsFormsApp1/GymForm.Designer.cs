namespace WindowsFormsApp1
{
    partial class GymForm
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picSearchMember = new System.Windows.Forms.PictureBox();
            this.picNewMember = new System.Windows.Forms.PictureBox();
            this.picDeleteMember = new System.Windows.Forms.PictureBox();
            this.picLogout = new System.Windows.Forms.PictureBox();
            this.picNewStaff = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNewMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeleteMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNewStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(24, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(180, 42);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "What do you want to do?";
            // 
            // picSearchMember
            // 
            this.picSearchMember.Image = global::WindowsFormsApp1.Properties.Resources.Add_a_subheading;
            this.picSearchMember.Location = new System.Drawing.Point(54, 156);
            this.picSearchMember.Name = "picSearchMember";
            this.picSearchMember.Size = new System.Drawing.Size(156, 121);
            this.picSearchMember.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSearchMember.TabIndex = 2;
            this.picSearchMember.TabStop = false;
            this.picSearchMember.Click += new System.EventHandler(this.picSearchMember_Click);
            // 
            // picNewMember
            // 
            this.picNewMember.Image = global::WindowsFormsApp1.Properties.Resources.Add_a_heading;
            this.picNewMember.Location = new System.Drawing.Point(255, 156);
            this.picNewMember.Name = "picNewMember";
            this.picNewMember.Size = new System.Drawing.Size(151, 121);
            this.picNewMember.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNewMember.TabIndex = 3;
            this.picNewMember.TabStop = false;
            this.picNewMember.Click += new System.EventHandler(this.picNewMember_Click);
            // 
            // picDeleteMember
            // 
            this.picDeleteMember.Image = global::WindowsFormsApp1.Properties.Resources.Add_a_subheading_1;
            this.picDeleteMember.Location = new System.Drawing.Point(436, 156);
            this.picDeleteMember.Name = "picDeleteMember";
            this.picDeleteMember.Size = new System.Drawing.Size(153, 121);
            this.picDeleteMember.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDeleteMember.TabIndex = 4;
            this.picDeleteMember.TabStop = false;
            this.picDeleteMember.Click += new System.EventHandler(this.picDeleteMember_Click);
            // 
            // picLogout
            // 
            this.picLogout.BackColor = System.Drawing.Color.Transparent;
            this.picLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picLogout.Image = global::WindowsFormsApp1.Properties.Resources._4790504_small1;
            this.picLogout.InitialImage = null;
            this.picLogout.Location = new System.Drawing.Point(699, 377);
            this.picLogout.Name = "picLogout";
            this.picLogout.Size = new System.Drawing.Size(82, 81);
            this.picLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogout.TabIndex = 5;
            this.picLogout.TabStop = false;
            this.picLogout.Click += new System.EventHandler(this.picLogout_Click);
            // 
            // picNewStaff
            // 
            this.picNewStaff.Image = global::WindowsFormsApp1.Properties.Resources.Add_a_subheading_2;
            this.picNewStaff.Location = new System.Drawing.Point(634, 156);
            this.picNewStaff.Name = "picNewStaff";
            this.picNewStaff.Size = new System.Drawing.Size(147, 121);
            this.picNewStaff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNewStaff.TabIndex = 6;
            this.picNewStaff.TabStop = false;
            this.picNewStaff.Click += new System.EventHandler(this.picNewStaff_Click);
            // 
            // GymForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.pngtree_the_gym_scene_where_people_are_sitting_in_a_gym_picture_image_3108802;
            this.ClientSize = new System.Drawing.Size(815, 470);
            this.ControlBox = false;
            this.Controls.Add(this.picNewStaff);
            this.Controls.Add(this.picLogout);
            this.Controls.Add(this.picDeleteMember);
            this.Controls.Add(this.picNewMember);
            this.Controls.Add(this.picSearchMember);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GymForm";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.picSearchMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNewMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeleteMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNewStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picSearchMember;
        private System.Windows.Forms.PictureBox picNewMember;
        private System.Windows.Forms.PictureBox picDeleteMember;
        private System.Windows.Forms.PictureBox picLogout;
        private System.Windows.Forms.PictureBox picNewStaff;
    }
}