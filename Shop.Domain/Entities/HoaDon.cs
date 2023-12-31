﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.Entities
{
    public class HoaDon
        
    {
        public int HoaDonId { get; set; }
        public int NguoiDungId { get; set; }
        public string TongTien { get; set; }
        public string HoaDonSdt { get; set; }
        public string NgayTao { get; set; }
        public int TrangThai { get; set; }
        public string HoVaTen { get; set; }
        public string DiaChi { get; set; }
        public string GhiChu { get; set; }
        public NguoiDung NguoiDung { get; set; }
        public ICollection<ChiTietHoaDon> ChiTietHoaDon { get; set; }
    }
}
