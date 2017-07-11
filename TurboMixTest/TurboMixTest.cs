using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ejercicio11;

namespace TurboMixTest
{
    [TestClass]
    public class TurboMixTest
    {
        [TestMethod]
        public void TestTurboMix()
        {
            ITurboMix turboMix = new TurboMix();
            Plato plato = turboMix.Cocina(new Alimento(), new Alimento());
            Assert.IsNotNull(plato);
             
        }

    }
}
