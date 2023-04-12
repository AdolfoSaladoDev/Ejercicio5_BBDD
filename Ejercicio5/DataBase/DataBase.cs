

namespace Ejercicio5.DataBase
{
    internal class DataBase
    {

        private static string RandomAuthorNameGenerator()
        {
            string[] arrayOfNames = { "Juan", "José", "Antonio", "Laura", "María", "Luciana",
            "Martina", "Rocío", "Claudio", "Claudia", "Christian", "Inmaculada", "Sergio"};

            string[] arrayOfLastNames = {"Salado", "Iniesta", "Contreras", "López", "Ronaldo", "Martínez",
            "Pulpo"};

            string randomName = arrayOfNames[new Random().Next(arrayOfLastNames.Length)];
            string randomLastName = arrayOfLastNames[new Random().Next(arrayOfLastNames.Length)];

            return $"{randomName} {randomLastName}";
        }

        private static string RandomPublisherNameGenerator()
        {
            string[] arrayOfPublisherNames = { "Perro", "Gato", "Gaviota", "Ratón", "Loro", "Cocodrilo" };

            return arrayOfPublisherNames[new Random().Next(arrayOfPublisherNames.Length)];
        }

        private static string RandomBookNameGenerator()
        {
            string[] arrayOfBookNames = {"La luna", "El perro", "Las canicas", "Las luciérnagas",
            "La tortuga", "El caniche", "La serpiente", "Dama de noche"};

            string[] arrayOfAdjectives = {"amable", "feliz", "caliente", "triste", "agradable",
                "artista", "pobre", "lúgubre"};

            string randomName = arrayOfBookNames[new Random().Next(arrayOfBookNames.Length)];
            string randomAdjective = arrayOfAdjectives[new Random().Next(arrayOfBookNames.Length)];

            return $"{randomName} {randomAdjective}";
        }

    }


}
