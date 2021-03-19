using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace WindowsFormsApp_Football_Team
{
    public static class CountriesHelper
    {
        public static List<string> GetAllCountries()
        {
            List<string> cultureList = new List<string>();
            CultureInfo[] getCultureInfo = CultureInfo.GetCultures(CultureTypes.SpecificCultures);

            foreach (var culture in getCultureInfo)
            {
                RegionInfo regionInfo = new RegionInfo(culture.LCID);
                if (!(cultureList.Contains(regionInfo.EnglishName)))
                {
                    cultureList.Add(regionInfo.EnglishName);
                }
            }

            cultureList.Sort();

            return cultureList;
        }

        public static Dictionary<string, string> GetCountriesNameAndCode()
        {
            Dictionary<string, string> countriesNameAndCodes = CultureInfo.GetCultures(CultureTypes.SpecificCultures)
                .Select(x => new RegionInfo(x.LCID))
                .Select(x => new[] { new { Name = x.DisplayName, Code = x.Name },
                                     new { Name = x.NativeName, Code = x.Name }
                                    })
                .SelectMany(x => x)
                .Distinct()
                .ToDictionary(x => x.Name, x => x.Code, StringComparer.InvariantCultureIgnoreCase);

            return countriesNameAndCodes;
        }

    }

    

}
