﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Applicationn.Dto
{
    public class BaiVietDto
    {
        public int BaiVietId { get; set; }
        public string TieuDe { get; set; }
        public string NoiDung { get; set; }
        public string AnhBaiViet { get; set; }
        public DateTime NgayDang { get; set; }
        public int NguoiDungId { get; set; }
    }
}
