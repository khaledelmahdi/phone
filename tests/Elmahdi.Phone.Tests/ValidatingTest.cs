using System.Text;
using Xunit;

namespace Elmahdi.Phone.Tests
{
    public class ValidatingTest
    {
        [Fact]
        public void ReturnTrueWhenValid()
        {
            const string numberGB = "014 140 4 0 050";
            const string numberEG = "05 06 850 900";
            
            Assert.True(numberGB.IsValidPhoneNumberFor());
            Assert.True(numberEG.IsValidPhoneNumberFor("EG"));
        }
        
        [Fact]
        public void ReturnFalseWhenInvalid()
        {
            const string numberGB = "014 abc";
            const string numberEG = "0111111111";
            const string empty = null;
            
            Assert.False(numberGB.IsValidPhoneNumberFor());
            Assert.False(numberEG.IsValidPhoneNumberFor("GB"));
            Assert.False(empty.IsValidPhoneNumberFor());
        }
    }
}