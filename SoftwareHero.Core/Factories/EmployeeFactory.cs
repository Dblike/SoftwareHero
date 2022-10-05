using SoftwareHero.Core.Extensions;

namespace SoftwareHero.Core.Factories
{
    public class EmployeeFactory
    {
        private const string NamePath = @"";
        private const string MaleNamesFilename = "male.txt";
        private const string FemaleNamesFilename = "female.txt";
        // AKA Benford's Law
        private static readonly short[] KnowledgeCurve = { 30, 18, 12, 10, 8, 7, 6, 5, 4 };

        private readonly Random _rand;
        private readonly CompanyIndustry[] _industries;
        private readonly List<string> _maleNames;
        private readonly List<string> _femaleNames;

        public EmployeeFactory(Random rand)
        {
            _rand = rand;
            _industries = CompanyFactory.CompanyIndustries.ToArray();
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
                Role = role,
                WorkRelationships = new List<WorkRelationship>()
            };

            engineer.Skill = ChooseSkill(engineer.Age);
            engineer.IndustryKnowledge = ChooseKnowledge();

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

        private Dictionary<CompanyIndustry, Skill> ChooseKnowledge()
        {
            var knowledgeDict = new Dictionary<CompanyIndustry, Skill>();
            _industries.Shuffle(_rand);
            for (var idx = 0; idx < KnowledgeCurve.Length; idx++)
            {
                knowledgeDict[_industries[idx]] = new Skill(KnowledgeCurve[idx]);
            }

            return knowledgeDict;
        }

        private string ChooseName(string gender)
        {
            return gender == "Male" ? _maleNames.GetRandom(_rand) : _femaleNames.GetRandom(_rand);
        }

        private Skill ChooseSkill(int age)
        {
            return new Skill((short)_rand.Next(0, 100));
        }

        private static List<string> ParseNamesList(string fileName)
        {
            return File.ReadAllLines(NamePath + fileName).ToList();
        }
    }
}
