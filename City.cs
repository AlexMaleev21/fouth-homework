using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4
{
    internal class City
    {
        public int CitizenAmount { get; set; }

        public City(int citizenAmount)
        {
            this.CitizenAmount = citizenAmount;
        }

        public static City operator +(City city, int addition)
        {
            city.CitizenAmount += addition;
            return city;
        }

        public static City operator -(City city, int decrease)
        {
            city.CitizenAmount -= decrease;
            return city;
        }

        public static bool operator ==(City city1, City city2)
        {
            if (city1.CitizenAmount.Equals(city2.CitizenAmount))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(City city1, City city2)
        {
            if (city1.CitizenAmount.Equals(city2.CitizenAmount))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool operator >(City city1, City city2)
        {
            if (city1.CitizenAmount > city2.CitizenAmount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <(City city1, City city2)
        {
            if (city1.CitizenAmount < city2.CitizenAmount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool Equals(Object? obj)
        {
            var item = obj as City;
            return this.CitizenAmount.Equals(item.CitizenAmount);
        }

        public override int GetHashCode()
        {
            return this.CitizenAmount.GetHashCode();
        }
    }
}
