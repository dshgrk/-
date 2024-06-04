using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ЗнижкоСвіт
{
    public class FavoriteManager : ICard
    {
        private SignInUser currentUser;

        public FavoriteManager(SignInUser user)
        {
            currentUser = user;
        }

        public List<Card> GetCards()
        {
            return currentUser.FavCards;
        }

        public void RemoveCardFromFavorites(Card card)
        {
            if (currentUser.FavCards.Contains(card))
            {
                currentUser.FavCards.Remove(card);
                UserManager.SaveUsers();
            }
            else
            {
                throw new InvalidOperationException($"{card.Name} is not in your favorites.");
            }
        }
    }
}
