using System;

namespace CourseEnumExercicio.Entities
{
    class Departament
    {
        public String Name { get; set; }

        public Departament()
        {

        }

        public Departament(String name)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Nome invalido!");
            }
            else
            {
                name = name.ToUpper();
                name = name.Trim();
                name = name.Replace(',', ' ');
                name = name.Replace('.', ' ');
                Name = name;
            }
        }
    }
}
