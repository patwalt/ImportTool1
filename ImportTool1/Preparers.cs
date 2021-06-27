namespace ImportTool1
{
    class Preparers
    {
        public string[] Preppers()
        {
            string preparers = "Gloria Prince,David Besler,Bobby Almeida,Anthony Pentecost," +
                               "Alfred Martinez,Alexandar Parham,Ann Aull,Andrew Zezula," +
                               "John Brown,Elaine Pollack,Bruce Johnson,Luis Papps, Carol Castro," +
                               "Graham Kelty,Joseph Drozeski,John Gaines,Thomas Trevor," +
                               "Luis Edwards,Cedric Castro,Dale Lloyd,Christian Petersen," +
                               "Graham Kelty,Daniel Drozeski,Joseph Trevor,Steve Smith," +
                               "Mike Etelamaki,Scott Arrington,Curtis Jones,Dale Douglas," +
                               "Linda Jones,Curtis Thompson,Dave Reagan,Daniel Skalicky," +
                               "Douglas Riviera,Nicole Snowden,Edward Huddleston,Frank Smothers," +
                               "Douglas Foster,Edward Manchas,Ted Robinson,Duane Prince," +
                               "Ernest Reagan,Erin Jones,Kent Reagan,Frank Fujiwara,Don Logsdon," +
                               "Gene Terrel,Garven Wilkins,Henry Brown,Ivan Munoz,Ken Lauritzen," +
                               "Ivan Waters,Herbert Diggs,James Williams,Jameson Hayden," +
                               "Duane Earle,Jeffery Willing,John Reagan,Henry Crittenden";

            string[] prepPeople = preparers.Split(',');
            return prepPeople;
        }
    }
}
