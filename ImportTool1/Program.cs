using System;

namespace ImportTool1
{
    class Program
    {
        static void Main(string[] args)
        {
            Preparers preparers = new Preparers();
            Units orgunits = new Units();

            string source = ".\\source.xlsx";
            string destination = ".\\IMPORT_FILE_" + DateTime.Now.ToString("yyyyMMddHHmm") + ".xlsx";

            string[] units = orgunits.OrgUnits();
            string[] prepPeople = preparers.Preppers();

            Console.WriteLine("Welcome to the file importing tool.  This will allow you to create");
            Console.WriteLine("one, two, a dozen, or hundreds of records that can be imported from");
            Console.WriteLine("an Excel file.\n");
            Console.Write("How many records would you like? (Creates Excel rows, so less than 2000): ");
            string genNumStr = Console.ReadLine();
            int genNum = Convert.ToInt32(genNumStr);

            string[] selectedUnitName = new string[genNum];
            string[] selectedPreparers = new string[genNum];

            selectedUnitName = CollectionMaker(genNum, units, units.Length);
            selectedPreparers = CollectionMaker(genNum, prepPeople, prepPeople.Length);

        }

        public static string[] CollectionMaker(int items, string[] StringList, int sizeOfCollection)
        {
            Random _random = new Random();
            int selectedOrdinal = 0;
            int itemNumber = items;
            int collectionSize = sizeOfCollection;
            string[] stringList = StringList;
            string[] resultList = new string[itemNumber];

            for (int count = 0; count < itemNumber; count++)
            {
                selectedOrdinal = _random.Next(0, collectionSize);
                resultList[count] = stringList[selectedOrdinal];
            }

            return resultList;
        }
    }
}
