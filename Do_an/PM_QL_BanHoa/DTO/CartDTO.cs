using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO {
	public class CartDTO {
		// Auto-implemented properties
		public int MaSanPham { get; set; }
		public string TenSanPham { get; set; }
		public int SoLuong { get; set; }
		public double DonGia { get; set; }
		public double ThanhTien { get; set; }

		// Constructor mặc định
		public CartDTO() {
			MaSanPham = 0;
			TenSanPham = "";
			SoLuong = 0;
			DonGia = 0;
			ThanhTien = 0;
		}

		// Constructor có tham số
		public CartDTO(int maSanPham, string tenSanPham, int soLuong, double donGia,
									 double thanhTien) {
			MaSanPham = maSanPham;
			TenSanPham = tenSanPham;
			SoLuong = soLuong;
			DonGia = donGia;
			ThanhTien = thanhTien;
		}
	}
}