using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerStats
{
    /// <summary>
    /// 
    /// </summary>
    public class Player
    {
        //Initialize the variables
        private float highScore;
        private int playedGames;
        private int wonGames;

        /// <summary>
        /// Gets the original highscore and replaces it with the most recent
        /// highscore if it is bigger than the current one.
        /// </summary>
        public float HighScore
        {
            get => highScore;

            set
            {
                highScore = value;
                if (value < highScore)
                {
                    highScore = value;
                }
            }
        }
    }
}