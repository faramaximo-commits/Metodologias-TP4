using Metodologias.Colecciones;
using Metodologias.Estrategias;
using Metodologias.Objetos;
using Metodologias.Otros;
using Metodologias.Práctica_3;
using Metodologias.MDPI;
using StudentMDPI = Metodologias.MDPI.MDPI.Student;
using TeacherMDPI = Metodologias.MDPI.MDPI.Teacher;
using System;
using Metodologias.Adapter;
using Metodologias.Decorator;
using MiComparable = Metodologias.Objetos.IComparable;
using Metodologias.Fabricas;



namespace Metodologias
{
    class Program
    {
        static void Main(string[] args)
        {
            //----Ejercicio 4 (Práctica 4) implemente una funcion Main que instancie un TeacherMDPI y le haga dar una clase a 20 alumnos (10 normales y 10 muy estudiosos) usando la clase AlumnoAdapter

            //TeacherMDPI teacher = new TeacherMDPI();
            //FabricaDeAlumnosMuyEstudiosos fabricaMuyEstudiosos = new FabricaDeAlumnosMuyEstudiosos();
            //FabricaDeAlumnosNormales fabricaNormales = new FabricaDeAlumnosNormales();
            //StudentMDPI student;
            //for (int i = 0; i < 20; i++)
            //{
            //    if(i < 10)
            //    {
            //        student = new AlumnoAdapter((AlumnoNormal)fabricaNormales.crearAleatorio());
            //    }
            //    else
            //    {
            //        student = new AlumnoAdapter((AlumnoMuyEstudioso)fabricaMuyEstudiosos.crearAleatorio());
            //    }
            //    teacher.goToClass(student);
            //}
            //teacher.teachingAClass();

            
            
            //---------------------------------------------------------------------------------------------------------------------------------------------------------------
            //---Ejercicio 8 (Práctica 4) Ejecute la función main del ejercicio 4 y compruebe la correcta impresión del listado de calificaciones (El alumno y los decorados)

            TeacherMDPI teacher = new TeacherMDPI();
            StudentsFactory fabricaStudents = new StudentsFactory();

            for (int i = 0; i < 20; i++)
            {
                StudentMDPI student = (StudentMDPI)fabricaStudents.crearAleatorio();
                teacher.goToClass(student);

            }

            teacher.teachingAClass();
        }
    }
}