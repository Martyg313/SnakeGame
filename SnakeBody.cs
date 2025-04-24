using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    internal class SnakeBody
    {
        public PictureBox snakeRect;            // Visual component of <SnakeBody>
        public SnakeBody nextSegment = null!;   // Undeclared reference for another instance of <SnakeBody>

        /**
         * <SnakeBody> Constructor for modifying <snakeRect>
         */
        public SnakeBody() 
        { 
            snakeRect = new PictureBox();
            snakeRect.Size = new Size(20, 20);
            MainForm.thePanel.Controls.Add(snakeRect);
            snakeRect.Location = new Point(200, 200);
        }
    }
}
