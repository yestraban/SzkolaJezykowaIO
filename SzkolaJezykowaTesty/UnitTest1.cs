using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SzkolaJezykowaIO;

namespace SzkolaJezykowaTesty
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPanelu()
        {
            PanelLogowania a=new PanelLogowania();

            var element = a.listaUczniow;

        }
    }
}
