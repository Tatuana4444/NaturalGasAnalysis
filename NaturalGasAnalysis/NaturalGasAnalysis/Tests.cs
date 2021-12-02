using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalGasAnalysis.Tests
{
    public class Tests
    {
        [Test]
        public void NaturalGasLoader_WithCorrectUri()
            => Assert.IsNotNull(NaturalGasLoader.GetNaturalGasObject("https://pkgstore.datahub.io/core/natural-gas/daily_json/data/2e630ca50c39a1a3cf6c3aff57a1b132/daily_json.json"));

        [Test]
        public void NaturalGasLoader_EmptyUriString_InvalidOperationException()
            => Assert.Throws<InvalidOperationException>(
                () => NaturalGasLoader.GetNaturalGasObject(string.Empty));

        [Test]
        public void NaturalGasLoader_NonexistingUriString_AggregateException()
            => Assert.Throws<AggregateException>(
                () => NaturalGasLoader.GetNaturalGasObject(@"https://njdnskjdnvkn/"));
    }
}
