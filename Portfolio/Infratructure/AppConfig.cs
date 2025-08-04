﻿namespace Portfolio.Infratructure
{
    public class AppConfig
    {
        public TinyMCE TinyMCE { get; set; } = new TinyMCE();
        public Company Company { get; set; } = new Company();
    }
    public class TinyMCE
    {
        public string? APIKey { get; set; }
    }

    public class Company
    {
        public string? CompanyName { get; set; }
        public string? CompanyNumber { get; set; }
        public string? CompanyShortNumber { get; set; }

        public string? CompanyEmail { get; set; }
    }
}
