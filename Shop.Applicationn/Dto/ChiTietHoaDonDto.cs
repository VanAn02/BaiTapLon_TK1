﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Applicationn.Dto
{
    public class ChiTietHoaDonDto
    {
        public int ChiTietHoaDontId { get; set; }
        public int HoaDonId { get; set; }
        public int TourId { get; set; }
        public int SoLuong { get; set; }
        public string Gia { get; set; }
    }
}
