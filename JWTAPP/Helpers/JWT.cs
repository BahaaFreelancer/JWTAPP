﻿namespace JWTAPP.Helpers
{
    public class JWT
    {
        public string Key { get; set; }
        public string Issuer { get; set; }
        public string Audiance { get; set; }
        public string DurationInDays { get; set; }
    }
}
