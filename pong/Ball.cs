using System.Windows.Forms;

namespace pong
{
    class Ball
    {
        public int ballx;
        public int bally;
        public PictureBox body;

        public Ball(PictureBox Body)
        {
            body = Body;
            Init();
        }

        public void Init()
        {
            ballx = 5;
            bally = 5;
        }
    }
}
