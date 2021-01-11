using RealEstate.Core.Assets;
using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstate.Core.Pricers
{
    public class RealEstatePropertyPricer : AssetPricer
    {
        public RealEstatePropertyPricer(IAsset asset) : base(asset) { }

        public RealEstateProperty Property => Asset as RealEstateProperty;

        public double ComputeMarketPricePerSurface()
        {
            if (Math.Abs(Property.Surface) < double.Epsilon)
            {
                return 0.0;
            }
            return Property.MarketPrice / Property.Surface;
        }

        public override double ComputeYearlyCashIn()
        {
            return Property.Rent * 12;
        }

        public override double ComputeYearlyCashOut()
        {
            return Property.RealEstateTaxes + Property.PropertyInsurance + Property.MaintenanceAndRepairs;
        }

        public double ComputeVacancyAllowance()
        {
            return Property.Rent * 12 * Property.VacancyRate;
        }

        public double ComputeGrossScheduledIncome()
        {
            return Property.Rent * 12;
        }

        public double ComputeGrossOperatingIncome()
        {
            return ComputeGrossScheduledIncome() - ComputeVacancyAllowance();
        }

        public double ComputeNetOperatingIncome()
        {
            return ComputeGrossOperatingIncome() - ComputeYearlyCashOut();
        }
    }
}
