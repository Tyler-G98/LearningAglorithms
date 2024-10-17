using System.ComponentModel;

namespace LearningAglorithms.Base
{
    public class Base_PlayingCard : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // Example of a DependencyProperty-like property for the card number
        private int _cardNumber;
        public int CardNumber
        {
            get { return _cardNumber; }
            set
            {
                if (_cardNumber != value)
                {
                    _cardNumber = value;
                    OnPropertyChanged(nameof(CardNumber));
                }
            }
        }
    }
}


