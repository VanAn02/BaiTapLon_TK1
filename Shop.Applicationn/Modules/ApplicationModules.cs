﻿using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Shop.Applicationn.Mapping;
using Shop.Applicationn.Services;
using Shop.Infrastructure.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Applicationn.Modules
{
    public static class ApplicationModules
    {
        public static IServiceCollection AddApplicationModules(this IServiceCollection services)
        {
            services.AddInfrastructureModule();
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });
            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
            services.AddScoped<IBaiVietService, BaiVietService>();
            services.AddScoped<IDatTourService, DatTourService>();
            services.AddScoped<ITourService, TourService>();
            services.AddScoped<INguoiDungService, NguoiDungService>();
            services.AddScoped<IHoaDonService, HoaDonService>();
            services.AddScoped<IChiTietHoaDonService, ChiTietHoaDonService>();
            //services.AddScoped<IEmailService, EmailService>();
            return services;
        }    
    }
}
