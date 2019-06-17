using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando
{
    public partial class Character
    {
        public override string ToString()
        {
            return $"[{Id}] {Name} Category:{Category} MinSkillRating:{MinSkillRating}";
        }
    }
    public partial class Game
    {
        public override string ToString()
        {
            return $"[{Id}] Player:{Player.Name} Character:{Character.Name} Map:{Map.Name} MMR:{SkillRating}";
        }
    }
    public partial class Map
    {
        public override string ToString()
        {
            return $"[{Id}] {Name} Category:{Category}";
        }
    }
    public partial class Player
    {
        public override string ToString()
        {
            return $"[{Id}]: {Name} Team:{Team}";
        }
    }
}
