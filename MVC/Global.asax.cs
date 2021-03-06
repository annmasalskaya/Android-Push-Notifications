﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using AutoMapper;
using Android_Push_Notifications.Models;
using System.Web.Optimization;
using BLL.Entites;



namespace Android_Push_Notifications
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            Mapper.CreateMap<User, UserModel>();
            Mapper.CreateMap<UserModel, User>();
            Mapper.CreateMap<Device, DeviceModel>();
            Mapper.CreateMap<DeviceModel, Device>();
            BundleConfig.RegisterBundles(BundleTable.Bundles);

        }
    }
}
