using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerStats
{
    /// <summary>
    /// This class receives a player's name and associates to it its highest
    /// score (highScore), played games (playedGames) and won games (wonGames),
    /// as well as its win rate (winRate).
    /// </summary>
    public class Player
    {
        //Initialize the variables
        private float highScore;
        private int playedGames, wonGames;
        
        /// <summary>
        /// Gets the original highscore and replaces it with the most recent
        /// highscore if it is bigger than the current one.
        /// </summary>
        public float HighScore
        {
            get => highScore; //Gets the initial high score

            set
            {
                if (Score(value))
                {
                    highScore = value; //Changes the high score
                }
            }
        }

        //Helping method for HighScore
        //Sees if the score given is greater than the current high score
        private bool Score(float score) => score > highScore; 
                
        public string Name { get; } //Gets the name of the player

        //Gets the percentage of games won by that player
        public float WinRate
        {
            get
            {
                float winRate = 0; //Support variable

                if (playedGames == 0) //If the player hasn't played any games
                {
                    winRate = 0; 
                }
                else
                {   //Gets the percentage of (wonGames / playedGames)
                    winRate = (float)wonGames / playedGames;
                }
                return winRate;
            }
        } 

        /// <summary>
        /// Increments the number of played games of a player each time that
        /// player enters its name.
        /// Increments the number of won games of a player each time that
        /// player has the winning condition, which is win == true.
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
        public Player(string name) //Previously GetName
        {
            //Sets the player's name
            Name = name;
            
            //Sets numeric variables to 0 to "start" the game for a player
            highScore = 0;
            playedGames = 0;
            wonGames = 0;
        }
    }
}