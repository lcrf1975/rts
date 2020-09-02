using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;

// Geocode API Reference
// https://github.com/chadly/Geocoding.net
using Geocoding;
using Geocoding.Google;
using Geocoding.Microsoft;

namespace Geo
{
    class Services
    {
        // Class to support the KML creation process
        public class Location
        {
            public double Lat;
            public double Lon;
            public string Address;
            public string City;
            public string State;
            public string PostalCode;
            public string Complete;
            public string Quality;
        }

        // Find a value into GoogleAddress IEnumerable
        public static string Find_Value(GoogleAddress Obj, string Tag)
        {
            string V = "";

            if (Obj.Components.Count() > 0)
            {
                for (int I = 0; I < Obj.Components.Count(); I++)
                {
                    string[] Results = Obj.Components[I].ToString().Split(':');
                    if (Results[0].Trim().ToUpper() == Tag)
                    {
                        V = Obj.Components[I].ShortName;
                        break;
                    }
                }
            }

            return V;
        }

        // Geocodes an address using the Bing Maps engine
        public static Location Geocode_Bing(string ADDRESS)
        {
            try
            {
                // Calls the Werservice
                BingMapsGeocoder GEOCODER = new BingMapsGeocoder(ConfigurationManager.AppSettings["BingApiKey"]);
                IEnumerable<Address> ADDRESSES = GEOCODER.Geocode(ADDRESS);

                Location R = new Location();

                // Checks if the process returned a valid result
                if (ADDRESSES.Count() > 0)
                {
                    // Selects the firt result
                    BingAddress B = (BingAddress)ADDRESSES.FirstOrDefault();

                    R.Lat = B.Coordinates.Latitude;
                    R.Lon = B.Coordinates.Longitude;
                    R.Address = B.AddressLine; // Street + Number
                    R.City = B.Locality; // City
                    R.State = B.AdminDistrict; // State
                    R.PostalCode = B.PostalCode; // Postal Code
                    R.Quality = B.Confidence.ToString();
                    R.Complete = B.FormattedAddress; // Full Address
                }
                else
                {
                    R.Lat = 0;
                    R.Lon = 0;
                    R.Quality = "Bad";
                }

                return R;
            }
            catch (Exception ERROR)
            {
                throw new Exception(ERROR.Message);
            }
        }

        // Geocodes an address using the Bing Maps engine
        public static Location Geocode_Google(string ADDRESS)
        {
            try
            {
                // Calls the webservice
                GoogleGeocoder GEOCODER = new GoogleGeocoder() { ApiKey = ConfigurationManager.AppSettings["GoogleApiKey"] };
                IEnumerable<Address> addresses = GEOCODER.Geocode(ADDRESS);

                Location R = new Location();

                // Checks if the process returned a valid result
                if (addresses.Count() > 0)
                {
                    // Selects the firt result
                    GoogleAddress G = (GoogleAddress)addresses.FirstOrDefault();

                    R.Lat = G.Coordinates.Latitude;
                    R.Lon = G.Coordinates.Longitude;
                    R.Address = Find_Value(G, "ROUTE") + " " +
                        Find_Value(G, "STREETNUMBER");
                    R.City = Find_Value(G, "ADMINISTRATIVEAREALEVEL2");
                    R.State = Find_Value(G, "ADMINISTRATIVEAREALEVEL1");
                    R.PostalCode = Find_Value(G, "POSTALCODE");
                    R.Quality = G.LocationType.ToString();
                    R.Complete = G.FormattedAddress;
                }
                else
                {
                    R.Lat = 0;
                    R.Lon = 0;
                    R.Quality = "Bad";
                }

                return R;
            }
            catch (Exception ERROR)
            {
                throw new Exception(ERROR.Message);
            }
        }
    }
}