using HorseHandler.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using static JSON_Extractor.Models.JsonRace;

namespace JsonExtractor
{
    public class JsonExtractor
    {
        public JsonExtractor()
        {
        }

        public List<HorseDto> LoadJson(string filePath)
        {
            try
            {
                string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), filePath);
                var JsonRace = JsonConvert.DeserializeObject<RootObject>(File.ReadAllText(path));
                return ExtractHorsesData(JsonRace);
            }
            catch (Exception e)
            {
                throw new Exception("Json file coud not load: " + e.Message);
            }
           
        }

        private List<HorseDto> ExtractHorsesData(RootObject JsonRace)
        {
            List<HorseDto> ParticipantsList = new List<HorseDto>();

            try
            {

                foreach (var market in JsonRace.RawData.Markets)
                {
                    foreach (var selection in market.Selections)
                    {
                        HorseDto participant = new HorseDto(selection.Tags.participant, selection.Tags.name,
                            selection.Price);
                        ParticipantsList.Add(participant);
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error while parsing JSON file: " + e.Message);
            }

            return ParticipantsList;
        }
    }
}
