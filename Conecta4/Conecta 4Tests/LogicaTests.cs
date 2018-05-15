using Xunit;
using Conecta_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conecta_4.Tests
{
    public class LogicaTests
    {
        [Fact()]
        public void limpiarTest()
        {
            Logica logica = new Logica();
            Assert.Equal(true, logica.VerificaGanador(0));
        }
    }
}