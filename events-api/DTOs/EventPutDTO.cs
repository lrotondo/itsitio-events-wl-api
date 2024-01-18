﻿namespace events_api.DTOs
{
    public class EventPutDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateUTC { get; set; }
        public string Banner { get; set; }
        public string Subtitle { get; set; }
        public string PrimaryColor { get; set; }
        public string ArenaId { get; set; }
        public string StreamId { get; set; }
        public bool Live { get; set; }
    }
}
