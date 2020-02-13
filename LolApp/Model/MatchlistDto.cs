using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolApp.Model
{
    public class MatchlistDto
    {
        public List<MatchReferenceDto> matches { get; set; }
        public int totalGames { get; set; }
        public int startIndex { get; set; }
        public int endIndex { get; set; }
    }
}
