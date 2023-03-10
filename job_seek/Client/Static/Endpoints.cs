using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace job_seek.Client.Static
{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string MakesEndpoint = $"{Prefix}/makes";
        public static readonly string CompanysEndpoint = $"{Prefix}/companys";
        public static readonly string DescriptionsEndpoint = $"{Prefix}/decriptions";
        public static readonly string JobsEndpoint = $"{Prefix}/jobs";
        public static readonly string CustomersEndpoint = $"{Prefix}/customers";
        public static readonly string AppsEndpoint = $"{Prefix}/apps";
        public static readonly string StaffsEndpoint = $"{Prefix}/staffs";

    }
}
