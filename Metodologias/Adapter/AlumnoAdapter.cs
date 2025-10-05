using Metodologias.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using MiComparable = Metodologias.Objetos.IComparable;
using StudentMDPI = Metodologias.MDPI.MDPI.Student;


namespace Metodologias.Adapter
{
    public class AlumnoAdapter :StudentMDPI, MiComparable //Ejercicio 3 (Práctica 4) Implementar la clase MDPI provista por la cátedra e implementar el patrón Adapter
    {
        private IAlumno alumno;
        private int score;

        public AlumnoAdapter(IAlumno alumno)
        {
            this.alumno = alumno;
        }

        public IAlumno getAlumno()
        {
            return this.alumno;
        }

        public bool equals(StudentMDPI student)
        {
            var other = student as AlumnoAdapter;
            if (other == null) return false;
            return this.alumno.SosIgual(other.alumno);
        }

        public string getName()
        {
            return this.alumno.getNombre();
        }

        public bool greaterThan(StudentMDPI student)
        {
            var other = student as AlumnoAdapter;
            if (other == null) return false;
            return this.alumno.SosMayor(other.alumno);
        }

        public bool lessThan(StudentMDPI student)
        {
            var other = student as AlumnoAdapter;
            if (other == null) return false;
            return this.alumno.SosMenor(other.alumno);
        }

        public void setScore(int score)
        {
            this.score = score;
            this.alumno.setCalificacion(score);
        }

        public string showResult()
        {
            return this.alumno.mostrarCalificacion();
        }

        public int yourAnswerIs(int question)
        {
            return this.alumno.responderPregunta(question);
        }

        public bool SosIgual(MiComparable i)
        {
            return this.alumno.SosIgual(i);
        }

        public bool SosMenor(MiComparable i)
        {
            return this.alumno.SosMenor(i);
        }

        public bool SosMayor(MiComparable i)
        {
            return this.alumno.SosMayor(i);
        }
    }
}
