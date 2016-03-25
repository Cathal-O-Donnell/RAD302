using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using AutoMapper;
using RAD302_S00144297.Models;
using RAD302_S00144297.Models.DTO;

namespace RAD302_S00144297
{
    public static class AutoMapperConfigurations
    {
        private static MapperConfiguration config;
        public static MapperConfiguration Configuration { get { return config; } }

        public static void Configure()
        {
            config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Employee, EmployeeDetail>();
            });
        }
    }
}