using RealEstate.Core.Pricers;
using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstate.Core.Assets
{
    public class RealEstateProperty : Asset
    {
        public override IPricer GetPricer()
        {
            return new RealEstatePropertyPricer(this);
        }

        public double Surface { get; set; }
        public double MarketPrice { get; set; }
        public double Rent { get; set; }
        public double RealEstateTaxes { get; set; }
        public double PropertyInsurance { get; set; }
        public double MaintenanceAndRepairs { get; set; }
        public double VacancyRate { get; set; }
    }
}
