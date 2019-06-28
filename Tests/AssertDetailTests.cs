using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Tests
{
    [Trait("Assertions", "Détails")]
    public class AssertDetailTests
    {
        [Fact]
        public void EqualIndiqueDifferencesEntreDeuxObjetsComplexesInegaux()
        {
            var attendu = new Groupe<DepotCourrier>(
                "C000",
                new DepotCourrier[]
                {
                    new DepotCourrier("C010", "1134 1er étage"),
                    new DepotCourrier("C011", "1134 1er étage"),
                    new DepotCourrier("C012", "1134 1er étage"),
                    new DepotCourrier("C013", "1134 1er étage"),
                });

            var reel = new Groupe<DepotCourrier>(
                "C000",
                new DepotCourrier[]
                {
                    new DepotCourrier("C010", "1134 1er étage"),
                    new DepotCourrier("C011", "1134 1er étage"),
                    new DepotCourrier("C012", "1134 1er étage"),
                    new DepotCourrier("C014", "1134 1er étage"),
                });

            Assert.Equal(attendu, reel);
        }
    }
}
