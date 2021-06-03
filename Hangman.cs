namespace HangmanKata
{
    public class Hangman
    {
        private readonly string _secretWord;
        private readonly int _incorrectGuesses;
        public bool InProgress { get; set; } = true;

        public Hangman(string secretWord, int incorrectGuesses)
        {
            _secretWord = secretWord.ToUpper();
            _incorrectGuesses = incorrectGuesses;
        }
    }
}