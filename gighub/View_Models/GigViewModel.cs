
using System.Collections;

namespace gighub.View_Models
{
    public class GigViewModel
    {
        public string Venue { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public byte Genre { get; set; }
        public IEnumerable Genres { get; set; }
    }
}