using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ЗнижкоСвіт
{
    public class CardManager : ICard
    {
        private readonly List<Card> cards;

        public CardManager()
        {
            cards = new List<Card>();
        }

        public void AddCard(Card card)
        {
            cards.Add(card);
        }

        public void RemoveCard(Card card)
        {
            cards.Remove(card);
        }

        public List<Card> GetCards()
        {
            return cards;
        }

        public void AddToFavorites(Card card)
        {
            if (UserManager.CurrentUser is SignInUser user)
            {
                if (!user.FavCards.Any(c => c.Id == card.Id))
                {
                    user.FavCards.Add(card);
                    card.IsFavorite = true;
                    UserManager.SaveUsers();
                }
                else
                {
                    throw new InvalidOperationException($"{card.Name} is already in your favorites.");
                }
            }
            else
            {
                throw new UnauthorizedAccessException("Only registered users can add to favorites.");
            }
        }

    }


}
