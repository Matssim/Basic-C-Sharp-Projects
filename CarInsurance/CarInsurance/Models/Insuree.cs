﻿namespace CarInsurance.Models
{
    public class Insuree
    {
        public Guid Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public string? EmailAddress { get; set; }
        public required DateOnly DateofBirth { get; set; }
        public required int CarYear { get; set; }
        public required string CarMake { get; set; }
        public required string CarModel { get; set; }
        public required bool DUI { get; set; }
        public required int SpeedingTickets { get; set; }
        public required string CoverageType { get; set; }
        public decimal? Quote { get; set; }
    }
}
