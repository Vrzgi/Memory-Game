using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    class GameOptions
    {
        public int[] imageID;
        public int[] RandomID(int lenght)
        {
            Random image = new Random();
            imageID = new int[lenght];
            int randomDigit;
            int i = 0;
            while (i < 16)
            {
                randomDigit = image.Next(0, lenght);
                foreach (int num in imageID)
                {
                    if (num == randomDigit)
                        break;
                    else
                    {
                        imageID[i] = randomDigit;
                        i++;
                    }
                }
            }
            return imageID;
        }
    }
}
