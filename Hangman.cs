using System;

namespace HangmanKata
{
    public enum GuessResult
    {
        Invalid,
        Incorrect,
    }

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

        public GuessResult Guess(char letter)
        {

            if (!Char.IsLetter(Char.ToUpper(letter)))
            { 
                return GuessResult.Invalid;
            }

            return GuessResult.Incorrect;
        }
    }
}