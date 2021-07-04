using System;
using Xunit;

namespace Elmahdi.Phone.Tests
{
    public class FormattingTest
    {
        [Fact]
        public void ReturnsCorrectFormat()
        {
            const string number = "014 140 4 0 050";
            Assert.Equal("0141 404 0050", number.ToLocalPhoneNumber());
            Assert.Equal("+441414040050", number.ToInternationalPhoneNumber());
        }
        
        [Fact]
        public void ReturnsCorrectFormatForInternational()
        {
            const string number = "05 06 850 900";
            Assert.Equal("050 6850900", number.ToLocalPhoneNumber("EG"));
            Assert.Equal("+20506850900", number.ToInternationalPhoneNumber("EG"));
        }
    }
}