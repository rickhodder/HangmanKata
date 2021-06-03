using System;
using Xunit;

namespace HangmanKata
{
    public class HangmanTests
    {
        [Fact]
        public void Ctor_InProgress()
        {
            var sut = new Hangman("allcaps", 3);
            Assert.True(sut.InProgress);
        }
        
        [Fact]
        public void Guess_InvalidCharacterGivesInvalidResult()
        {
            var sut= new Hangman("secret",3);
            Assert.False(sut.Guess('1'));
        }
    }
}
