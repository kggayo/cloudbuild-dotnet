using System;
using Xunit;

namespace CloudBuild.Service.Test
{
    public class ValueServiceTest
    {
        [Fact]
        public void GetValues_ListAllValues()
        {
            ValueService valueService = new ValueService();

            var result = valueService.GetValues();

            Assert.NotEmpty(result);
        }
    }
}
