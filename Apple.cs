using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    internal class Apple
    {
        private PictureBox appleRect;   // Visual component of <apple>

        /**
         * <Apple> Constructor for modifying <appleRect>
         */
        public Apple() 
        { 
            appleRect = new PictureBox();
            appleRect.Size = new Size(20, 20);
            appleRect.BackColor = Color.DarkRed;
            MainForm.thePanel.Controls.Add(appleRect);
            appleRect.Location = RandomApplePosition();
        }

        /**
         * Determines a random location for this <apple> during initialization
         */
        private Point RandomApplePosition()
        {
            Random random = new Random();
            return new Point(random.Next(0, 21) * 20, random.Next(0, 21) * 20);
        }

        /**
         * Delete the apple's visual control; that is, the red box
         */
        public void DeleteApple()
        {
            appleRect.Dispose();
        }

        /**
         * Returns the bounds of this <apple> 
         */
        public Rectangle GetAppleBounds()
        {
            return appleRect.Bounds;
        }
    }
}
