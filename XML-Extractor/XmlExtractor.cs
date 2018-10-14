using HorseHandler.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using static XML_Extractor.Models.XMLRace;

namespace XML_Extractor
{
    public class XmlExtractor
    {
        public XmlExtractor()
        {
        }

        public List<HorseDto> LoadXml(string filePath)
        {
            try
            {
                System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(Meeting));
                using (System.IO.StreamReader file = new System.IO.StreamReader(filePath))
                {
                    Meeting XmlRace = (Meeting)reader.Deserialize(file);
                    file.Close();

                    return ExtractHorsesData(XmlRace);
                }
            }
            catch (Exception e)
            {
                throw new Exception("XML file coud not load: " + e.Message);
            }
           
        }

        private List<HorseDto> ExtractHorsesData(Meeting meeting)
        {
            List<HorseDto> HorseList = new List<HorseDto>();
            try
            {
                foreach (var horseXML in meeting.Races.Race.Horses.Horse)
                {
                    HorseDto horse = new HorseDto();
                    horse.Id = horseXML.Number;
                    horse.Name = horseXML.Name;
                    foreach (var horseXMLPrice in meeting.Races.Race.Prices.Price.Horses.Horse)
                    {
                        if (horseXMLPrice._Number == horse.Id)
                        {
                            horse.Price = Convert.ToDouble(horseXMLPrice.Price);
                            HorseList.Add(horse);
                            break;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error while parsing XML file: " + e.Message);
            }
            return HorseList;
        }
    }
}
