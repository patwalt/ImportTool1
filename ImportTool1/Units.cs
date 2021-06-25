namespace ImportTool1
{
    class Units
    {
        public string[] OrgUnits()
        {
            string orgunits = "101st Airborne, 82nd Airborne, Texian Volunteers, " +
                              "Regimental Special Troops Battalion, Regimental Military Intelligence Battalion, " +
                              "1st Ranger Battalion, 2nd Ranger Battalion, 3rd Ranger Battalion, " +
                              "Air Defense Battalion, Tank Battalion, Infantry Battalion, " +
                              "1st Recon/5th Marines, 1st Recon/1st Marines, Alpha Company/2nd Recon, " +
                              "USS Abraham Lincoln, USS Mobile Bay, USS Lake Champlain, USS Dewey" +
                              "USS Spruance, USS Decatur, USS Stockdale, Carrier Fighter Squadron 14 (VFA-14), " +
                              "Strike Fighter Squadron 41 (VFA-41), Marine Fighter Attack Squadron 314 (VMFA-314), " +
                              "Electronic Attack Squadron 133 (VAQ-133), Helicopter Sea Combat Squadron (HSC-14), " +
                              "41st Electronic Combat Squadron, 42d Electronic Combat Squadron, " +
                              "388th Electronic Combat Squadron, 422d Test and Evaluation Squadron, " +
                              "357th Fighter Squadron, 355th Fighter Squadron, 94th Fighter Squadron";

            string[] orgUnits = orgunits.Split(',');
            return orgUnits;
        }
    }
}
