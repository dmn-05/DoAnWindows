using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO {
  public class InvoiceDTO {
    public int MaHD {  get; set; }
    public int MaKH { get; set; }
    public int MaNV { get; set; }
    public DateTime NgayLapHoaDon { get; set; }
    public string TrangThai { get; set; }
    public string DiaChiGiao { get; set; }
    public double ThanhTien {  get; set; }
  }
}
