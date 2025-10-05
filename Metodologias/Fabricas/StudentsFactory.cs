using Metodologias.Adapter;
using Metodologias.Decorator;
using Metodologias.Objetos;
using Metodologias.Otros;
using Metodologias.Práctica_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiComparable = Metodologias.Objetos.IComparable;

namespace Metodologias.Fabricas
{
    public class StudentsFactory : FabricaDeComparables //Ejercicio 7 (Práctica 4) Implemente la fábrica concreta StudentsFactory que cree alumnos normales y muy estudiosos decorados y adaptados
    {
        private static int contador = 1;
        
        public override MiComparable crearAleatorio()
        {
            FabricaDeAlumnosNormales fNor = new FabricaDeAlumnosNormales();
            FabricaDeAlumnosMuyEstudiosos fEst = new FabricaDeAlumnosMuyEstudiosos();

            IAlumno alu;
            if (GeneradorDeDatos.ObtenerEnteroAleatorio(0, 2) == 0)
            {
                alu = (AlumnoNormal)fNor.crearAleatorio();
            }
            else
            {
                alu = (AlumnoMuyEstudioso)fEst.crearAleatorio();
            }

            IAlumno decorado = new DecoradorConRecuadro(
            new DecoradorPromocion(
                new DecoradorConLegajo(
                    new DecoradorNotaEnLetras(
                        new DecoradorConOrden(alu, contador++)))));

            return (MiComparable)new AlumnoAdapter(decorado);
        }

        public override MiComparable crearPorTeclado()
        {
            throw new NotImplementedException();
        }
    }
}
