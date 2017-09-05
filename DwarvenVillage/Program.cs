using DwarvenVillage.Entities;
using DwarvenVillage.Factories;
using DwarvenVillage.Utils.Loggers;
using DwarvenVillage.Utils.Randomizers;
using System.Collections.Generic;

namespace DwarvenVillage
{
    class Program
    {
        /*
         * Simulation starts at day 1
         * 10 dwarfs are born in hospital
         *  35% - type 1
         *  30% - type 2
         *  25% - type 3
         *  10% - type 4
         * Dwarfs are going to Mine
         *  Each dwarf rools on how much times he must go down to Shaft (1-3 times)
         *  there are 2 Shafts
         *  Each Shaft can contain up to 5 dwarf at one time.
         *  Dwarfs go down and go up in same time.
         *  Dwarfs can dig in Shaft and have chance to dig resources.
         *      50% - nothing
         *      20% - dirty gold
         *      15% - silver
         *      10% - gold
         *      5%  - mithril
         *  If dwarf type is 4 he destroy Shaft along which all dwarves inside.
         *  Dwarf have 5% chance to slip when going out of Shaft and die.
         * When all dwarfs end thier work they are going to sell thier ores to canthine
         *  1g      - dirty gold
         *  1,5g    - silver
         *  5g      - gold
         *  10g     - mithril
         *  Then all ores are stored inside storage.
         *  Dwarves are paid from Village (canthine is inside village)
         * When dwarfs sell thier orbs they are going to shop to buy goods
         *  type 1 - buying food
         *  rest not buying anything that they can eat =(
         *  type 1 - 100% of what he digged goes to store.
         *  type 2 - 75% of what he digged goes to store.
         *  type 3 - 0% of what he digged goes to store.
         *  store money goes to village (it is in village)
         * If dwarf did not ate he begs for food from Village.
         *  Dwarf have 90% chance to get food from base.
         * After day one all cycle repeats but hospital produces only one dwarf which 10% chance.
         * 
         * Simulation conditions
         *  When shaft is destroyed it takes 3 days to rebuild eg (1 shaft in day 1 takes 3 days, 2 shafts in day 1 takes 3 days) - each shaft is rebuilded in 3 days they do not queue
         *  When all dwarves are dead at end of simulation game stops.
         *  When food in base is emptied game stops.
         *  When money in base is emptied game stops.
         *  When 30 day pass on successfully game stops.
         *  After each action log is generated, eg Dwarf x digged y, Dwarf x paid y for z, Dwarf x begged for food etc.
         *  After end of day summary is generated, eg Dwarf has been born, 5 dwarfs died by shaft explosion, 1 dwarf died by slipping, canthine buyed x ores and payed y cash, shop sold x items and gethered y money etc.
         *  
         * */
        static void Main(string[] args)
        {
            Logger.logger = new LogToConsole();
            

            IDwarfTypeRandomizer rand = new DwarfTypeRandomizer();
            List<Dwarf> dwarfs = DwarvenFactory.Create10Dwarfs();
            foreach(Dwarf dwarf in dwarfs)
            {
                Logger.WriteLog(dwarf.ToString());
            }
        }
    }
}
