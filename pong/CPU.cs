using System.Windows.Forms;

namespace pong
{
    class CPU
    {
        public int speed;
        public int point;
        public PictureBox body;

        public CPU(PictureBox Body)
        {
            body = Body;
            Init();
        }

        public void Init()
        {
            speed = 5;
            point = 0;
        }
    }
}
