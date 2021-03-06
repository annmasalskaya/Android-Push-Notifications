﻿using Android_Push_Notifications.Models;
using BLL.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL.Entites;

namespace Android_Push_Notifications.Controllers
{
    public class UserController : Controller
    {
       // [Inject]
        IDeviceService _deviceService;
        //[Inject]
        IUserService _userService;

        public UserController(IDeviceService deviceService, IUserService userService)
        {
            _deviceService = deviceService;
            _userService = userService;
        }
        
        // GET: User
        public ActionResult Index()
        {
            var users = _userService.GetAll();
            var usersModel = AutoMapper.Mapper.Map<IEnumerable<User>, IEnumerable<UserModel>>(users);
            return View(usersModel);
        }
        
        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "Login,Password")] UserModel userModel)
        {
            if(ModelState.IsValid)
            {
                var user = AutoMapper.Mapper.Map<User>(userModel);
                _userService.Create(user,userModel.Password);
                
            }
            return RedirectToAction("Index");
        }

        
    }
}
