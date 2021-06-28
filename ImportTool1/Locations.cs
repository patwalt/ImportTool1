namespace ImportTool1
{
    class Locations
    {
        public string[] IncidentLocations()
        {
            string locations = "Bombay,Bangalore,New Delhi,Calcutta,Bay of Bengal," +
                               "Colombo,Dhaka,Andaman Sea,Madalay,Bangkok,Phnom Penh," +
                               "Ho Chi Minh City,Hanoi,Haiphong,Gulf of Thailand," +
                               "South China Sea,Kuala Lampur,Padang,Samarinda,Ambon," +
                               "Makassar Strait,Bali Sea,Flores Sea,Banda Sea,Malang," +
                               "Surabaya,Jakarta,Java Sea,Karimata Strait,Adonara," +
                               "Port Moresby,Gulf of Papua,Arafura Sea,Coral Sea," +
                               "Bismarck Sea,Solomon Sea,Brisbane,Sydney,Melbourne," +
                               "Tasman Sea,Adelaide,Perth,Darwin,Timor Sea,York Island," +
                               "Invercargill,Dunedin,Christchurch,Blenheim,Nelson," +
                               "Wellington,Palmerston North,New Plymouth,Hamilton," +
                               "Napier,Gisborne,Cook Strait,Tauranga,Auckland,Sulu Sea," +
                               "San Fernando,Manila,Sibuyan Sea,Camotes Sea,Cebu," +
                               "Calapan,Legaspi,Iloilo,Dumaguete,Cagayan De Oro City," +
                               "Philippine Sea,Zamboanga,Davao,Koror,Nanning,Macao," +
                               "Hong Kong,Guangzhou,Fuzhou,Hangzhao,Nanjing,Shanghai," +
                               "Zhengzhou,Wuhan,Jinan,Bo Hai,Yellow Sea,Taipei,Naha," +
                               "Incheon,Seoul,Gwangju,Busan,Ulsan,Pohang,Daegu," +
                               "Pyongyang,Cheongjin,Kimchaek,Hamhung,Wonsan,Kaesong," +
                               "Sapporo,Aomori,Akita,Fukushima,Saitama,Tokyo,Chiba," +
                               "Yokohama,Kofu,Gifu,Nagoya,Kyoto,Osaka,Kobe,Wakayama," +
                               "Fukuoka,Hiroshima,Nagasaki,Kumamoto,Matsue,Tottori," +
                               "Toyama,Nagano,Niigata,Yamagata,Sendai,Sea of Japan," +
                               "Vladivostok,Khabarovsk,Petropavlovsk-Kamchatskiy," +
                               "Sea of Okhotsk,Kara Sea,Barents Sea,Moscow,Kirov," +
                               "Kazan,Samara,Ufa,Izhevsk,Perm,Ufa,Yekaterinburg," +
                               "Kharkiv,Voronezh,Kyiv,Minsk,Talinn,Riga,Vilnius," +
                               "Warsaw,St. Petersburg,Volgograd,Odesa,Bucharest," +
                               "Sofia,Sarajevo,Tirana,Zagreb,Vienna,Prague,Talinn," +
                               "Murmansk,Helsinki,Stockholm,Oslo,Copenhagen,Malmo," +
                               "Copenhagen,Amsterdam,Brussels,Luxembourg,Brussels," +
                               "Berlin,Hamburg,Dusseldorf,Hanover,Leipzig,Dresden," +
                               "Frankfurt,Nuremberg,Stuttgart,Munich,Antwerp,Paris," +
                               "Calais,Portiers,Toulouse,Montpellier,Marseille,Nice," +
                               "Andorra,Madrid,Bilbao,Zaragoza,Barcelona,Valencia," +
                               "Seville,Gibraltar,Murcia,Lisbon,Porto,Alboran Sea," +
                               "Valencia,Turin,Milan,Genoa,Bologna,Venice,San Marino," +
                               "Florence,Rome,Naples,Bari,Salerno,Palermo,Catania," +
                               "Zagreb,Belgrade,Tirana,Skopje,Varna,Thessaloniki," +
                               "Adriatic Sea,Athens,Corfu,Ioannina,Patras,Sparti," +
                               "Alexandroupoli,Istanbul,Bursa,Izmir,Ankara,Konya," +
                               "Antalya,Tbilisi,Baku,Karagandy,Bishkek,Dushanbe," +
                               "Ashgabat,Kabul,Tehran,Baghdad,Damascas,Beirut,Haifa," +
                               "Jerusalem,Amman,Erbil,Basrah,Karbala,Najaf,Cairo," +
                               "Sharm El-Sheikh,Medina,Riyadh,Dammam,Jeddah,Manama," +
                               "Doha,Sanaa,Abu Dhabi,Dubai,Muscat,Arabian Gulf,Bam," +
                               "Persian Gulf,Gulf of Oman,Karachi,Islamabad,Lahore," +
                               "Mediterranean Sea,Helena,Geneva,Alexandria,Tunis," +
                               "Casablanca,Nasiriyah,South China Sea,Sargasso Sea," +
                               "Atlantic Ocean,Pacific Ocean,Lima,Rio de Janiero," +
                               "Santiago,Tripoli,Kinshasa";

            string[] incidentLocations = locations.Split(',');
            return incidentLocations;
        }
    }
}
