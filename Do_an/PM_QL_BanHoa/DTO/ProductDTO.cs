using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO {
  public class ProductDTO {
    public int MaSP { get; set; }
    public string TenSP { get; set; }
    public double GiaBanLe { get; set; }
    public double GiaNhap { get; set; }
    public double GiaXuat { get; set; }
    public int SoLuongTonKho { get; set; }

    
    public ProductDTO(int maSP = 0, string tenSP = "", double giaBanLe = 0, double giaNhap = 0, double giaXuat = 0, int soLuongTonKho = 0) {
      MaSP = maSP;
      TenSP = tenSP;
      GiaBanLe = giaBanLe;
      GiaNhap = giaNhap;
      GiaXuat = giaXuat;
      SoLuongTonKho = soLuongTonKho;
    }
  }
}
