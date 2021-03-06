﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Android_Push_Notifications.Models
{
    public class DeviceModel
    {
        [Required]
        [Display(Name = "Registration Id")]
        [DataType(DataType.Text)]
        public string RegistrationId { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Imei { get; set; }
    }
}