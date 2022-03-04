using System;
using System.Windows.Forms;

namespace pong
{
    public partial class Form1 : Form
    {
        readonly Player player;
        readonly CPU cpu;
        readonly Ball ball;

        public Form1()
        {
            InitializeComponent();
            player = new Player(playerBody);
            cpu = new CPU(cpuBody);
            ball = new Ball(ballBody);
        }

        private void Keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) player.goUp = true;

            if (e.KeyCode == Keys.S) player.goDown = true;
        }

        private void Keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) player.goUp = false;

            if (e.KeyCode == Keys.S) player.goDown = false;
        }
        private void TimerTick(object sender, EventArgs e)
        {
            playerScore.Text = $"{player.point}";
            cpuScore.Text = $"{cpu.point}";

            ball.body.Top -= ball.bally;
            ball.body.Left -= ball.ballx;

            cpu.body.Top += cpu.speed;

            PointCheckPlayer(player.point);
            PointCheckCPU(cpu.point);

            if (ballBody.Left < 0)
            {
                ball.body.Left = 434;
                ball.ballx = -ball.ballx;
                ball.ballx -= 1;
                cpu.point++;
            }

            if (ballBody.Left + ballBody.Width > ClientSize.Width)
            {
                ball.body.Left = 434;
                ball.ballx = -ball.ballx;
                ball.ballx += 1;
                player.point++;
            }

            if (ball.body.Top < 0 || ball.body.Top + ball.body.Height > ClientSize.Height) ball.bally = -ball.bally;

            if (ball.body.Bounds.IntersectsWith(player.body.Bounds) || ball.body.Bounds.IntersectsWith(cpu.body.Bounds)) ball.ballx = -ball.ballx;

            if (player.goUp && player.body.Top > 0) player.body.Top -= player.speed;

            if (player.goDown && player.body.Top < 455) player.body.Top += player.speed;
        }

        private void PointCheckPlayer(int point)
        {
            if (point < 10)
                if (cpu.body.Top <= 0 || cpu.body.Top >= 455)
                    cpu.speed = -cpu.speed;

            if (point >= 10)
            {
                result.Text = "Gratulálok, győztél!";
                gameTimer.Stop();

                DialogResult dialogResult = MessageBox.Show("Szeretnél új játékot indítani?", "Új játék", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    cpu.Init();
                    player.Init();
                    ball.Init();
                    ball.body.Top -= ball.bally;
                    ball.body.Left -= ball.ballx;
                    result.Text = "";
                    gameTimer.Start();
                }

                else if (dialogResult == DialogResult.No) Application.Exit();
            }
        }

        private void PointCheckCPU(int point)
        {
            if (point >= 10)
            {
                result.Text = "A CPU nyert, te vesztettél!";
                gameTimer.Stop();

                DialogResult dialogResult = MessageBox.Show("Szeretnél új játékot indítani?", "Új játék", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    cpu.Init();
                    player.Init();
                    ball.body.Top -= ball.bally;
                    ball.body.Left -= ball.ballx;
                    result.Text = "";
                    gameTimer.Start();
                }

                else if (dialogResult == DialogResult.No) Application.Exit();
            }
        }
    }
}
