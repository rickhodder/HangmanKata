using System;
using Xunit;

namespace HangmanKata
{
    public class HangmanTests
    {
        [Fact]
        public void Ctor_Settings()
        {
            var sut = new Hangman("allcaps", 3);
        }
    }
}
