using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LegacyData.Test
{
    [CollectionDefinition("LegacyDataTests")]
    public class LegacyDataCollection : ICollectionFixture<LegacyDataFixture>
    {
    }
}
