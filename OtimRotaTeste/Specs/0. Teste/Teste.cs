using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OtimRotaTeste.Specs._0._Teste
{
    [TestClass]
    public class Teste
    {
        [TestMethod]
        public void Teste01()
        {
            App app = new App();
            app.Run();
            app.ClicarBotaoPocosReservatorios();
            app.Quit();
        }
    }
}
