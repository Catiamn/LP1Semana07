using System;

namespace PlayerStats
{
    public class Player
    {
        private int matches;
        private int wins;
        private float highScore;
        public float HighScore
        {
            get => highScore;
            set
            {
               //Se o "input" for maior que o HighScore, substitui o highscore atual pelo novo valor mais alto (o input)
                if (value > highScore)
                {
                    highScore = value;
                }
            }
        }
            public string Name { get; }

        /// <summary>
        /// WinRate divide as wines pelos matches, dando depois uma percetangem equivalente a winrate do jogador
        /// </summary>
        public float WinRate
        {
            get
            {
                if (matches == 0)
                {
                    return 0;
                }
 
                return (float) wins / matches;
             }
        }
        //Mete todos os parametros a 0 para depois ir adicionando nos outros parametros 
        public Player(string name)
         {
             Name = name;
             highScore = 0;
             matches = 0;
             wins = 0;
         }


        /// <summary>
        /// Adiciona o match ao total de "matches" e caso win (= true) adiciona ao total de "wins"
        /// </summary>
        /// <param name="win">Win como parametro que depois define o WinRate do jogador</param>
         public void PlayGame(bool win)
         {
             matches++;
             if (win)
             {
                 wins++;
             }
         }




    }
}