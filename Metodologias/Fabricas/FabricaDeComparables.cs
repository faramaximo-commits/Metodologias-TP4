using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metodologias.Otros;
using Metodologias.Objetos;
using Metodologias.Estrategias;
using MiComparable = Metodologias.Objetos.IComparable;

namespace Metodologias.Práctica_3
{
    public abstract class FabricaDeComparables 
    {
        //--Ejercicio 4 (Práctica 3)(Clase abstracta FabricaDeComparables, métodos estáticos crearAleatorio(opcion) y crearPorTeclado(opcion))
        public static MiComparable crearAleatorio(int opcion)
        {
            MiComparable c = null;
            switch (opcion)
            {
                case 1:
                    int valor = GeneradorDeDatos.ObtenerEnteroAleatorio(0, 10000000);
                    c = new Numero(valor);
                    break;
                case 2:
                    string nombre = GeneradorDeDatos.ObtenerNombreAleatorio();
                    int dni = GeneradorDeDatos.ObtenerEnteroAleatorio(1, 100000000);
                    int legajo = GeneradorDeDatos.ObtenerEnteroAleatorio(0, 1000);
                    int promedio = GeneradorDeDatos.ObtenerEnteroAleatorio(0, 10);
                    int calificacion = GeneradorDeDatos.ObtenerEnteroAleatorio(1, 10); //Método agregado para el Ejercicio 1 (Práctica 4) Modifique la clase Alumno para que tenga un atributo calificacion
                    IEstrategiaComparacion estrategia = new CompararAlumnoCalificacion();
                    c = new AlumnoNormal(nombre, dni, legajo, promedio, calificacion, estrategia);
                    break;
                case 3:
                    string nombreProfesor = GeneradorDeDatos.ObtenerNombreAleatorio();
                    int dniProfesor = GeneradorDeDatos.ObtenerEnteroAleatorio(1, 100000000);
                    int antiguedad = GeneradorDeDatos.ObtenerEnteroAleatorio(0, 100);
                    c = new Profesor(nombreProfesor, dniProfesor, antiguedad);
                    break;
                case 4:
                    string nom = GeneradorDeDatos.ObtenerNombreAleatorio();
                    int dn = GeneradorDeDatos.ObtenerEnteroAleatorio(1, 100000000);
                    int leg = GeneradorDeDatos.ObtenerEnteroAleatorio(0, 1000);
                    int prom = GeneradorDeDatos.ObtenerEnteroAleatorio(0, 10);
                    int cali = GeneradorDeDatos.ObtenerEnteroAleatorio(1, 10); //Método agregado para el Ejercicio 1 (Práctica 4) Modifique la clase Alumno para que tenga un atributo calificacion
                    IEstrategiaComparacion estrateg = new CompararAlumnoCalificacion();
                    c = new AlumnoMuyEstudioso(nom, dn, leg, prom, cali, estrateg);
                    break;

                default:
                    break;
            }
            return c;
        }

        public static MiComparable crearPorTeclado(int opcion)
        {
            MiComparable c = null;
            switch (opcion)
            {
                case 1:
                    FabricaDeNumeros fNumero = new FabricaDeNumeros();
                    c = fNumero.crearPorTeclado();
                    break;
                case 2:
                    FabricaDeAlumnosNormales fAlumnos = new FabricaDeAlumnosNormales();
                    c = fAlumnos.crearPorTeclado();
                    break;
                case 3:
                    FabricaDeProfesores fProfesores = new FabricaDeProfesores();
                    c = fProfesores.crearPorTeclado();
                    break;
                default:
                    break;
            }
            return c;
        }

        public abstract MiComparable crearAleatorio();
        public abstract MiComparable crearPorTeclado();

        
    }
}
