using System.Drawing;
using System.Windows.Forms;

namespace Arkanoid
{
    class AddComp
    {
        public Label scoreL = new Label();
        public Label livesL = new Label();
        public Label maxL = new Label();

        public AddComp()
        {
            scoreL.Location = new Point(MapController.mapWidth * 20 + 1, 20);
            livesL.Location = new Point(MapController.mapWidth * 20 + 1, 50);
            maxL.Location = new Point(MapController.mapWidth * 20 + 1, 80);
        }
    }
}
