using HorseHandler.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HorseHandler
{
    public class HorseHandler
    {
        public HorseHandler()
        {
        }

        public void SortAndDisplayHorseList(List<HorseDto> HorsesList)
        {
            try
            {
                List<HorseDto> SortedParticipantList = HorsesList.OrderBy(p => p.Price).ToList();

                int index = 1;
                foreach (HorseDto participant in SortedParticipantList)
                {
                    Console.WriteLine("{0}. Horse: {1} - Price: {2}", index, participant.Name, participant.Price);
                    index++;
                }
            }
            catch (Exception e)
            { 
                throw new Exception("Error while sorting or displaying list: " + e.Message);
            }
            
        }
    }
}
