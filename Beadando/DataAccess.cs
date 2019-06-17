using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando
{
    public class DataAccess : IDisposable
    {
        OWStatisticsEntities entities = new OWStatisticsEntities();
        public List<Game> GetAllGame()
        {
            return entities.Games.ToList();
        }
        public List<Game> GetAllGame(Character character)
        {
            return entities.Games
                .Where(x=>x.CharacterId==character.Id)
                .ToList();
        }
        public double AverageMMRByTeam(string InputTeam)
        {
            List<Player> TheTeam = new List<Player>();
            foreach (Player j in GetAllPlayer())
            {
                if (j.Team == InputTeam)
                {
                    TheTeam.Add(j);
                }
            }
            double average = 0;
            int index = 0;
            foreach (Game j in GetAllGame())
            {
                foreach (Player x in TheTeam)
                {
                    if (x.Id == j.PlayerId)
                    {
                        index++;
                        average += j.SkillRating;
                    }
                }
            }
            return average / index;
        }
        public List<Game> GetAllGameByMMR(Character character)
        {
            return entities.Games
                .Where(x => x.CharacterId == character.Id && x.SkillRating>=50)
                .ToList();
        }
        public List<Game> GetAllGameByMMR()
        {
            return entities.Games
                .OrderBy(x=>x.SkillRating)
                .ToList();
        }
        public List<Character> GetAllCharacter()
        {
            return entities.Characters.ToList();
        }
        public Character GetCharacterById(decimal InputID)
        {
            return entities.Characters.Where(x=>x.Id == InputID).Single();
        }
        public List<Map> GetAllMap()
        {
            return entities.Maps.ToList();
        }
        public Map GetMostPlayedMap()
        {
            var query = entities.Games
                        .GroupBy(p => new {
                            p.MapId,
                        })
                        .Select(g => new {
                            g.Key.MapId,
                            count = g.Count()
                        })
                        .OrderByDescending(g => g.count)
                        .FirstOrDefault();
            return entities.Maps
                .Where(x=>x.Id == query.MapId )
                .Single();
        }
        public List<Player> GetAllPlayer()
        {
            return entities.Players.ToList();
        }
        public List<Tuple<decimal, decimal>> Chart()
        {
            var query = entities.Games.GroupBy(x => x.CharacterId)
                        .Select(group => new
                        {
                            CharacterId = group.Key,
                            Count = group.Count()
                        })
                        .OrderBy(x => x.Count);
            List<Tuple<decimal, decimal>> result = new List<Tuple<decimal, decimal>>();
            foreach (var x in query)
            {
                result.Add(new Tuple<decimal, decimal>((decimal)x.CharacterId, x.Count));
            }
            return result;
        }
        public void Dispose()
        {
            ((IDisposable)entities).Dispose();
        }
    }
}
