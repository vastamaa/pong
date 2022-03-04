using System.Windows.Forms;

namespace pong
{
    class Player
    {
        public bool goUp;
        public bool goDown;
        public int point;
        public int speed;
        public PictureBox body;

        public Player(PictureBox Body)
        {
            body = Body;
            Init();
        }

        public void Init()
        {
            point = 0;
            speed = 8;
            goUp = false;
            goDown = false;
        }
    }
}
