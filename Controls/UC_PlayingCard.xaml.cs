using System.Windows.Controls;

namespace LearningAglorithms.Controls
{
    public partial class UC_PlayingCard : UserControl
    {
        private readonly Base.Base_PlayingCard _baseCard = new Base.Base_PlayingCard();

        public UC_PlayingCard()
        {
            InitializeComponent();
        }

        public int CardNumber
        {
            get { return _baseCard.CardNumber; }
            set
            {
                _baseCard.CardNumber = value;
                // If needed, you can trigger additional UI updates here
            }
        }
    }
}

