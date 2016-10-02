﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelBookingUsingMVC.Models
{
    public class Search
    {
        [Required]
        [Display(Name = "City")]
        public string City { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Check In Date")]
        public DateTime CheckInDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Check Out Date")]
        public DateTime CheckOutDate { get; set; }
        [Display(Name = "Number Of Rooms")]
        public int NumberOfRooms { get; set; }
    }
}