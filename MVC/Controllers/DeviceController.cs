﻿using Android_Push_Notifications.Models;
using BLL.Entites;
using BLL.Interfaces.Services;
using DAL.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Android_Push_Notifications.Controllers
{
    public class DeviceController : Controller
    {
        // [Inject]
        IDeviceService _deviceService;
        INotificationService _notificationService;

        public DeviceController(IDeviceService deviceService, INotificationService notificationService)
        {
            _deviceService = deviceService;
            _notificationService = notificationService;
        }
        
        public ActionResult SendNotification(DeviceModel deviceModel, string message)
        {
            var device = AutoMapper.Mapper.Map<Device>(deviceModel);
            var responce = _notificationService.sendNotification(device, message);
            ViewBag.responce = responce;
            return PartialView("SendNotification", deviceModel);
        }

        public ActionResult AddNotification(DeviceModel device)
        {
           return PartialView("SendNotification", device);
        }

        // GET 
        public ActionResult Devices(UserModel userModel )
        {
            var devices = userModel.Devices;
            return PartialView("Devices",devices);
        }    
    }
}
