using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classic_Snakes_Game
{
    public class Bot
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Bot()
        {
            // Initialize the bot's position
            X = 5;
            Y = 5;
        }

        public void Move(int maxWidth, int maxHeight)
        {
            // Implement the logic for random movement
            // Ensure the bot doesn't go out of bounds

            // Example logic:
            int direction = new Random().Next(4); // 0: Left, 1: Right, 2: Up, 3: Down

            switch (direction)
            {
                case 0:
                    if (X > 0)
                        X--;
                    break;
                case 1:
                    if (X < maxWidth)
                        X++;
                    break;
                case 2:
                    if (Y > 0)
                        Y--;
                    break;
                case 3:
                    if (Y < maxHeight)
                        Y++;
                    break;
            }
        }
    }

}
