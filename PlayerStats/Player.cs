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

        public string Name { get; } //Gets the name of the player

        //Gets the percentage of games won by that player
        public float WinRate => (wonGames/playedGames) * 100; 

        /// <summary>
        /// Increments 
        /// </summary>
        /// <param name="win">Detects if the player won the game or not</param>
        public void PlayGame(bool win)
        {
            //Increments by one game to played games independently of its result
            playedGames++; 

            if (win == true)
            {
                //Increments by one game to won games if the player wins the game
                wonGames++; 
            }
        }

        /// <summary>
        /// Sets the initial variables values to 0, which represents
        /// the start of the game for a specific player.
        /// </summary>
        /// <param name="name">Receives the name of the player</param>
        public void GetName(string name)
        {
            //Sets all variables to 0 to "start" the game for a specific player
            highScore = 0;
            playedGames = 0;
            wonGames = 0;
        }
    }
}