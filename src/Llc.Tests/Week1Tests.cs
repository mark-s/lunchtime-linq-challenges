using System;
using Xunit;
using Llc;
using Shouldly;

namespace Llc.Tests
{
    public class Week1Tests
    {
        [Fact]
        public void Week1_Task1()
        {
            var nameList = "Davis, Clyne, Fonte, Hooiveld, Shaw, Davis, Schneiderlin, Cork, Lallana, Rodriguez, Lambert";

            var expected = "1. Davis, 2. Clyne, 3. Fonte, 4. Hooiveld, 5. Shaw, 6. Davis, 7. Schneiderlin, 8. Cork, 9. Lallana, 10. Rodriguez, 11. Lambert";

            var result = Week1.Task1(nameList, ',');

            result.ShouldBe(expected);
        }
    }
}
