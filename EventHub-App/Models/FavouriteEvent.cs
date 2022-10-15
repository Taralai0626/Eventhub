namespace EventHub_App.Models
{
    public class FavouriteEvent
    {

        public int id { get; set; }

        public string FavouriteEventName { get; set; }

        public string FavouriteEventDate { get; set; }

        public string FavouriteEventTime { get; set; }

        public int FavouriteEventPriceMin { get; set; }
        public int FavouriteEventPriceMax { get; set; }
        public string FavouriteEventPriceCurrency { get; set; }
        public string FavouriteEventUrl { get; set; }


        public string FavouriteEventVenue { get; set; }




        public FavouriteEvent()
        {

        }

    }
}

