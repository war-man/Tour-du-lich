﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using tour.Models;

namespace tour.ViewModels
{
    public class ChiTietTourVM
    {
        public int TourId { get; set; }

        [Required]
        public string TenTour { get; set; }

        [Required]
        public string Mota { get; set; }

        [Required]
        public string IdDiaDiem { get; set; }
        public string TenDiaDiem{ get; set; }

        [Required]
        public int IdLoai { get; set; }
        public string TenLoai { get; set; }
    }
}
