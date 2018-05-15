using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conecta_4
{
    public interface ILogica
    {
        string[,] Tablero { get; } 

        bool VerificaGanador(int c);

        void limpiar();

        void Marcador(int Col);

        string GetString(int i, int j);

        string turnotemp { get; set; }

        string turno { get; set; }

        void ReiniciarMarcador();

        bool ColocarFicha(int columna);

        string CambiarTurno();

        Int32 Marca_O { get; set; }

        Int32 Marca_X { get; set; }
    }
}
