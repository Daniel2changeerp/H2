﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortePer
{
    sealed class CardManager
    {


        private CardText cardNames = new CardText();

        /// <summary>
        /// Contains all cards
        /// </summary>
        public List<DisneyCard> DisneyCards = new List<DisneyCard>();



        //Constructor
        public CardManager()
        {
            DisneyCards = CreateDisneyCards();
            DisneyCards = ShuffleList<DisneyCard>(DisneyCards);

        }

        //Create set of disneycards
        private List<DisneyCard> CreateDisneyCards()
        {
            List<DisneyCard> disCard = new List<DisneyCard>();
            foreach (var name in cardNames.DisneyCardNames)
            {
                if (name == "Sorte Per")
                {
                    disCard.Add(new DisneyCard(name));
                }
                else
                {
                    disCard.Add(new DisneyCard(name));
                    disCard.Add(new DisneyCard(name));
                }
            }


            return disCard;
        }


        private List<E> ShuffleList<E>(List<E> inputList)
        {
            List<E> randomList = new List<E>();

            Random r = new Random();
            int randomIndex = 0;
            while (inputList.Count > 0)
            {
                randomIndex = r.Next(0, inputList.Count); //Choose a random object in the list
                randomList.Add(inputList[randomIndex]); //add it to the new, random list
                inputList.RemoveAt(randomIndex); //remove to avoid duplicates
            }

            return randomList; //return the new random list
        }




    }
}
