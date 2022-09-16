using System;
using Test_Taste_Console_Application.Domain.DataTransferObjects;

namespace Test_Taste_Console_Application.Domain.Objects
{
    public class Moon
    {
        public string Id { get; set; }
        public decimal MassValue { get; set; }
        public decimal MassExponent { get; set; }
        public decimal gravity { get; set; }

        public Moon(MoonDto moonDto)
        {
            Id = moonDto.Id;
            MassValue = moonDto.MassValue;
            MassExponent = moonDto.MassExponent;
            gravity = moonDto.gravity;   // set gravity to each moon from MoonDto
        }

        
    }
}
