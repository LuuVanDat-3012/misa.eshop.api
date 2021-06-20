﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.ApplicationCore.Entity
{
    /// <summary>
    /// Lớp thông tin tìm kiếm
    /// Các option
    /// 1: Chứa
    /// 2: Bằng
    /// 3: Bắt đầu bằng
    /// 4: Kết thúc bằng
    /// 5: Không chứa
    /// </summary>
    /// CreatedBy: LVDat (19/06/2021)
   public  class ObjectFilter
    {
        /// <summary>
        /// Trạng thái tìm kiếm của thuộc tính mã cửa hàng
        /// </summary>
        public int OptionCode { get; set; }
        /// <summary>
        /// Mã cửa hàng cần tìm kiếm
        /// </summary>
        public string FilterCode { get; set; }
        /// <summary>
        /// Trạng thái tìm kiếm của tên cửa hàng
        /// </summary>
        public int OptionName { get; set; }
        /// <summary>
        /// Tên cửa hàng cần timd kiếm
        /// </summary>
        public string FilterName { get; set; }
        /// <summary>
        /// Trạng thái tìm kiếm theo địa chỉ
        /// </summary>
        public int OptionAddress{ get; set; }
        /// <summary>
        /// Địa chỉ cần tìm kiếm
        /// </summary>
        public string FilterAddress { get; set; }
        /// <summary>
        /// Trạng thái tìm kiếm của thuộc tính mã cửa hàng
        /// </summary>
        public string OptionPhone { get; set; }
        /// <summary>
        /// Số điện thại cần tìm kiếm
        /// </summary>
        public int FilterPhone { get; set; }
        /// <summary>
        /// Trạng thái của cửa ahgnf
        /// </summary>
        public int FilterStatus { get; set; }
        /// <summary>
        /// Vị trí trang
        /// </summary>
        public int PageIndex { get; set; }
        /// <summary>
        /// Số bản ghi trên 1 trang
        /// </summary>
        public int PageSize { get; set; }
    }
}
