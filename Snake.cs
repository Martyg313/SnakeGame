using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    internal class Snake
    {
        private int count = 0;                                          // Count/length of this <snake>
        private SnakeBody head = null!;                                 // The head of this <snake>; Alternativly, the first node of the linked list
        private List<Rectangle> boundries = new List<Rectangle>();      // A list of bounds collects from each snake segment or <SnakeBody>

        /**
         * <Snake> Constructor for building this snake as a linked list
         */
        public Snake(int snakeLength)
        {
            for (int i = 0; i < snakeLength; i++)
                AddSegment();
        }

        /**
         * Appends a snake segment <Snakebody> to the end of this snake
         */
        public void AddSegment()
        {
            if (head == null)
            {
                // Give this <snake> a head segment
                head = new SnakeBody();
                SetColor(head);
            }
            else
            {
                // Linked list tarversal to append a new segment to this snake 
                SnakeBody curr = head;
                while (curr.nextSegment != null)
                {
                    curr = curr.nextSegment;
                }

                //Add new segment after traversal
                curr.nextSegment = new SnakeBody();
                curr.nextSegment.snakeRect.Visible = false;     // Fixes visual spawn bug

                //Modifies color of this segment
                SetColor(curr.nextSegment); 
            }
        }

        /**
         * Sets the color for this newly created segment from <addSegment()>
         */
        public void SetColor(SnakeBody segment)
        {
            if (count % 2 == 0)
            {
                segment.snakeRect.BackColor = Color.Green;
            }
            else
            {
                segment.snakeRect.BackColor = Color.GreenYellow;
            }
            count++;
        }

        /**
         * Moves the entires snake and its segments
         */
        public void MoveSnake(bool left, bool right, bool top, bool bottom, int speed)
        {
            boundries = new List<Rectangle>();          // Reset the list to avoid storing outdated bounds
            Point oldLocOne = head.snakeRect.Location;  // Temp varible for first location

            // Sets intial snake direction
            if (left)
                head.snakeRect.Left -= speed;
            if (right)
                head.snakeRect.Left += speed;
            if (top)
                head.snakeRect.Top -= speed;
            if (bottom)
                head.snakeRect.Top += speed;         
            
            Point oldLocTwo;                            // Second temp varible for second location
            SnakeBody curr = head.nextSegment;
            while (curr != null)
            {
                curr.snakeRect.Visible = true;          // Fixes visual spawn bug
                oldLocTwo = curr.snakeRect.Location;    // Updates location
                curr.snakeRect.Location = oldLocOne;
                oldLocOne = oldLocTwo;

                boundries.Add(curr.snakeRect.Bounds);   // Updates list of all segments boundries

                curr = curr.nextSegment;
            }           
        }

        /**
         * Linked list Traversal for disposing each snake segment
         */
        public void DeleteSnake()
        {
            SnakeBody curr = head;
            while (curr != null)
            {
                curr.snakeRect.Dispose();
                curr = curr.nextSegment;
            }
        }
        
        /**
         * Returns the bounds of <head>
         */
        public Rectangle GetHeadBounds()
        {
            return head.snakeRect.Bounds;
        }

        /**
         * Returns the boundries of this <Snake>
         */
        public List<Rectangle> GetBoundries()
        {
            return boundries;
        }
    }
}
