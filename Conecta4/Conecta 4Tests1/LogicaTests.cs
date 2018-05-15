using Microsoft.VisualStudio.TestTools.UnitTesting;
using Conecta_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conecta_4.Tests
{
    [TestClass()]
    public class LogicaTests
    {
        [TestMethod()]
        public void VerificaGanadorTest()
        {
            //Green
            ILogica logica = new Logica();
            logica.turnotemp = "X";
            logica.Tablero[0, 0] = "X";
            logica.Tablero[1, 1] = "X";
            logica.Tablero[2, 2] = "X";
            logica.Tablero[3, 3] = "X";
            Assert.AreEqual(true, logica.VerificaGanador(1));
        }
        [TestMethod()]
        public void VerificaGanadorTest1()
        {
            //Green
            ILogica logica = new Logica();
            logica.turnotemp = "X";
            logica.Tablero[5, 0] = "X";
            logica.Tablero[5, 1] = "X";
            logica.Tablero[5, 2] = null;
            logica.Tablero[5, 3] = "X";
            Assert.AreEqual(false, logica.VerificaGanador(3));
        }
        [TestMethod()]
        public void VerificaGanadorTest2()
        {
            //Red
            ILogica logica = new Logica();
            logica.turnotemp = "X";
            logica.Tablero[0, 4] = "X";
            logica.Tablero[1, 3] = "X";
            logica.Tablero[2, 2] = "X";
            logica.Tablero[3, 1] = "X";
            Assert.AreEqual(true, logica.VerificaGanador(1));
        }
        [TestMethod()]
        public void VerificaGanadorTest3()
        {
            //Fail
            ILogica logica = new Logica();
            logica.turnotemp = "X";
            logica.Tablero[5, 5] = "X";
            logica.Tablero[5, 1] = "O";
            logica.Tablero[5, 2] = "X";
            logica.Tablero[5, 3] = "O";
            Assert.AreEqual(false, logica.VerificaGanador(1));
        }
        [TestMethod()]
        public void VerificaGanadorTest4()
        {
            //Blue
            ILogica logica = new Logica();
            logica.turnotemp = "X";
            logica.Tablero[1, 5] = "X";
            logica.Tablero[2, 4] = "X";
            logica.Tablero[3, 3] = "X";
            logica.Tablero[4, 2] = "X";
            Assert.AreEqual(true, logica.VerificaGanador(1));
        }
        public void VerificaGanadorTest5()
        {
            //Blue
            ILogica logica = new Logica();
            logica.turnotemp = "X";
            logica.Tablero[2, 0] = "X";
            logica.Tablero[2, 1] = "X";
            logica.Tablero[2, 2] = "X";
            logica.Tablero[2, 3] = "X";
            Assert.AreEqual(true, logica.VerificaGanador(3));
        }
        [TestMethod()]
        public void CambiarTiro_ColocarfichaTest()
        {
            //Blue
            ILogica logica = new Logica();
            for (int i = 0; i < 4; i++)
            {
                logica.ColocarFicha(i);
            }
            Assert.AreEqual("X", logica.Tablero[5,3]);
        }
        [TestMethod()]
        public void CambiarTurnoTest()
        {
            ILogica logica = new Logica();
            logica.turno = "X";
            Assert.AreEqual("O", logica.CambiarTurno());
        }
        [TestMethod()]
        public void GetStringTest()
        {
            Logica logica = new Logica();
            logica.Tablero[0, 0] = "X";
            logica.Tablero[2, 3] = "O";
            Assert.AreEqual("X", logica.GetString(0, 0));
        }
        [TestMethod()]
        public void limpiartest()
        {
            Logica logica = new Logica();
            logica.Tablero[0, 0] = "X";
            logica.Tablero[2, 3] = "O";
            logica.limpiar();
            Assert.AreEqual(null, logica.GetString(0,0));
        }
        [TestMethod()]
        public void ColocarFichaTest()
        {
            Logica logica = new Logica();
            logica.turno = "X";
            logica.ColocarFicha(2);
            Assert.AreEqual("X", logica.GetString(5, 2));
        }
        [TestMethod()]
        public void ColocarFichaTest2()
        {
            Logica logica = new Logica();
            logica.turno = "O";
            logica.Tablero[4, 6] = "O";
            logica.Tablero[5, 6] = "O";
            logica.ColocarFicha(6);
            Assert.AreEqual("O", logica.GetString(3, 6));
        }
        [TestMethod()]
        public void GetString2()
        {
            Logica logica = new Logica();
            logica.turno = "O";
            logica.ColocarFicha(6);
            Assert.AreEqual("O", logica.GetString(5, 6));
        }
    }
}