using SoftwareHero.Core.Extensions;

namespace SoftwareHero.Core.Factories
{
    public class EmployeeFactory
    {
        private const string NamePath = @"";
        private const string MaleNamesFilename = "male.txt";
        private const string FemaleNamesFilename = "female.txt";

        private readonly Random _rand;
        private readonly List<string> _maleNames;
        private readonly List<string> _femaleNames;

        public EmployeeFactory(Random rand)
        {
            _rand = rand;
            _maleNames = ParseNamesList(MaleNamesFilename);
            _femaleNames = ParseNamesList(FemaleNamesFilename);
        }

        public Employee Make(EmployeeRole role = EmployeeRole.None)
        {
            var gender = _rand.Next() % 2 == 0 ? "Male" : "Female";

            var engineer = new Employee
            {
                Gender = gender,
                Name = ChooseName(gender),
                Age = ChooseAge(),
                Role = role
            };

            engineer.Skill = ChooseSkill(engineer.Age);

            return engineer;
        }

        public Employee[] MakeMany(int count, EmployeeRole role = EmployeeRole.None)
        {
            var engineers = new Employee[count];

            for (var idx = 0; idx < count; idx++)
            {
                engineers[idx] = Make(role);
            }

            return engineers;
        }

        private int ChooseAge()
        {
            return _rand.Next(18, 65);
        }

        private string ChooseName(string gender)
        {
            return gender == "Male" ? _maleNames.GetRandom(_rand) : _femaleNames.GetRandom(_rand);
        }

        private Skill ChooseSkill(int age)
        {
            return new Skill
            {
                Low = -1,
                High = -1,
                Actual = (short)_rand.Next(0, 100)
            };
        }

        private static List<string> ParseNamesList(string fileName)
        {
            return File.ReadAllLines(NamePath + fileName).ToList();
        }
    }
}
