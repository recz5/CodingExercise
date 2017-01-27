using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCards
{
    public class Card
    {
        private Suit _suit;

        private Rank _rank;

        private string _name;

        public Card()
        {

        }

        public Card(Suit suit, Rank rank)
        {
            _suit = suit;

            _rank = rank;

            _name = String.Format("{0} of {1}", rank, suit);
        }

        public string Name
        {
            get
            {
                if (String.IsNullOrWhiteSpace(_name))
                    _name = String.Format("{0} of {1}", _rank, _suit);
                return _name;
                
            }
        }

        public Rank CardRank
        {
            get { return _rank; }
            set { _rank = value; }
        }

        public Suit CardSuit
        {
            get { return _suit; }
            set { _suit = value; }
        }

    }
}
