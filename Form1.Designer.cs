
namespace FlapppyBird
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
            this.components = new System.ComponentModel.Container();
            this.pcbBird = new System.Windows.Forms.PictureBox();
            this.pcbPipe2 = new System.Windows.Forms.PictureBox();
            this.pcbPipe4 = new System.Windows.Forms.PictureBox();
            this.pbGround = new System.Windows.Forms.PictureBox();
            this.pcbPipe1 = new System.Windows.Forms.PictureBox();
            this.pcbPipe3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcbBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPipe2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPipe4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPipe1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPipe3)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbBird
            // 
            this.pcbBird.Image = global::FlapppyBird.Properties.Resources.birdnew;
            this.pcbBird.Location = new System.Drawing.Point(12, 152);
            this.pcbBird.Name = "pcbBird";
            this.pcbBird.Size = new System.Drawing.Size(37, 32);
            this.pcbBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBird.TabIndex = 0;
            this.pcbBird.TabStop = false;
            // 
            // pcbPipe2
            // 
            this.pcbPipe2.Image = global::FlapppyBird.Properties.Resources.pipedown;
            this.pcbPipe2.Location = new System.Drawing.Point(540, -76);
            this.pcbPipe2.Name = "pcbPipe2";
            this.pcbPipe2.Size = new System.Drawing.Size(60, 177);
            this.pcbPipe2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbPipe2.TabIndex = 1;
            this.pcbPipe2.TabStop = false;
            // 
            // pcbPipe4
            // 
            this.pcbPipe4.Image = global::FlapppyBird.Properties.Resources.pipedown;
            this.pcbPipe4.Location = new System.Drawing.Point(775, -9);
            this.pcbPipe4.Name = "pcbPipe4";
            this.pcbPipe4.Size = new System.Drawing.Size(60, 110);
            this.pcbPipe4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPipe4.TabIndex = 2;
            this.pcbPipe4.TabStop = false;
            // 
            // pbGround
            // 
            this.pbGround.Image = global::FlapppyBird.Properties.Resources.ground;
            this.pbGround.Location = new System.Drawing.Point(-8, 380);
            this.pbGround.Name = "pbGround";
            this.pbGround.Size = new System.Drawing.Size(887, 118);
            this.pbGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGround.TabIndex = 3;
            this.pbGround.TabStop = false;
            // 
            // pcbPipe1
            // 
            this.pcbPipe1.Image = global::FlapppyBird.Properties.Resources.pipe;
            this.pcbPipe1.Location = new System.Drawing.Point(406, 242);
            this.pcbPipe1.Name = "pcbPipe1";
            this.pcbPipe1.Size = new System.Drawing.Size(60, 139);
            this.pcbPipe1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPipe1.TabIndex = 4;
            this.pcbPipe1.TabStop = false;
            // 
            // pcbPipe3
            // 
            this.pcbPipe3.Image = global::FlapppyBird.Properties.Resources.pipe;
            this.pcbPipe3.Location = new System.Drawing.Point(635, 242);
            this.pcbPipe3.Name = "pcbPipe3";
            this.pcbPipe3.Size = new System.Drawing.Size(67, 139);
            this.pcbPipe3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPipe3.TabIndex = 5;
            this.pcbPipe3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Score:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblScore.Location = new System.Drawing.Point(72, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 24);
            this.lblScore.TabIndex = 8;
            // 
            // tmrGame
            // 
            this.tmrGame.Enabled = true;
            this.tmrGame.Interval = 20;
            this.tmrGame.Tick += new System.EventHandler(this.tmrGame_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 450);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcbPipe3);
            this.Controls.Add(this.pcbPipe1);
            this.Controls.Add(this.pbGround);
            this.Controls.Add(this.pcbPipe4);
            this.Controls.Add(this.pcbPipe2);
            this.Controls.Add(this.pcbBird);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pcbBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPipe2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPipe4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPipe1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPipe3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbBird;
        private System.Windows.Forms.PictureBox pcbPipe2;
        private System.Windows.Forms.PictureBox pcbPipe4;
        private System.Windows.Forms.PictureBox pbGround;
        private System.Windows.Forms.PictureBox pcbPipe1;
        private System.Windows.Forms.PictureBox pcbPipe3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer tmrGame;
    }
}

