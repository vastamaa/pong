
namespace pong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ballBody = new System.Windows.Forms.PictureBox();
            this.playerBody = new System.Windows.Forms.PictureBox();
            this.cpuBody = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.playerScore = new System.Windows.Forms.Label();
            this.cpuScore = new System.Windows.Forms.Label();
            this.end = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ballBody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuBody)).BeginInit();
            this.SuspendLayout();
            // 
            // ballBody
            // 
            this.ballBody.BackColor = System.Drawing.Color.Transparent;
            this.ballBody.Image = global::pong.Properties.Resources.ball;
            this.ballBody.Location = new System.Drawing.Point(451, 230);
            this.ballBody.Name = "ballBody";
            this.ballBody.Size = new System.Drawing.Size(50, 25);
            this.ballBody.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ballBody.TabIndex = 0;
            this.ballBody.TabStop = false;
            // 
            // playerBody
            // 
            this.playerBody.BackColor = System.Drawing.Color.Lime;
            this.playerBody.Location = new System.Drawing.Point(12, 186);
            this.playerBody.Name = "playerBody";
            this.playerBody.Size = new System.Drawing.Size(27, 127);
            this.playerBody.TabIndex = 1;
            this.playerBody.TabStop = false;
            // 
            // cpuBody
            // 
            this.cpuBody.BackColor = System.Drawing.Color.Red;
            this.cpuBody.Location = new System.Drawing.Point(897, 230);
            this.cpuBody.Name = "cpuBody";
            this.cpuBody.Size = new System.Drawing.Size(27, 127);
            this.cpuBody.TabIndex = 2;
            this.cpuBody.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.TimerTick);
            // 
            // playerScore
            // 
            this.playerScore.AutoSize = true;
            this.playerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerScore.ForeColor = System.Drawing.Color.Lime;
            this.playerScore.Location = new System.Drawing.Point(105, 9);
            this.playerScore.Name = "playerScore";
            this.playerScore.Size = new System.Drawing.Size(38, 25);
            this.playerScore.TabIndex = 3;
            this.playerScore.Text = "00";
            // 
            // cpuScore
            // 
            this.cpuScore.AutoSize = true;
            this.cpuScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cpuScore.ForeColor = System.Drawing.Color.Red;
            this.cpuScore.Location = new System.Drawing.Point(735, 9);
            this.cpuScore.Name = "cpuScore";
            this.cpuScore.Size = new System.Drawing.Size(38, 25);
            this.cpuScore.TabIndex = 4;
            this.cpuScore.Text = "00";
            // 
            // end
            // 
            this.end.AutoSize = true;
            this.end.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.end.ForeColor = System.Drawing.Color.White;
            this.end.Location = new System.Drawing.Point(430, 307);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(0, 29);
            this.end.TabIndex = 5;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.BackColor = System.Drawing.Color.Transparent;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.result.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.result.Location = new System.Drawing.Point(382, 112);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 25);
            this.result.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(928, 574);
            this.Controls.Add(this.result);
            this.Controls.Add(this.end);
            this.Controls.Add(this.cpuScore);
            this.Controls.Add(this.playerScore);
            this.Controls.Add(this.cpuBody);
            this.Controls.Add(this.playerBody);
            this.Controls.Add(this.ballBody);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pong Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.ballBody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuBody)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ballBody;
        private System.Windows.Forms.PictureBox playerBody;
        private System.Windows.Forms.PictureBox cpuBody;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label playerScore;
        private System.Windows.Forms.Label cpuScore;
        private System.Windows.Forms.Label end;
        private System.Windows.Forms.Label result;
    }
}

