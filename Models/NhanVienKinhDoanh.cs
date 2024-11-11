class NhanVienKinhDoanh : NhanVien
{
  public int PhanTramHoaHong { get; set; }

  public override void NhapThongTin()
  {
    base.NhapThongTin();
    Console.WriteLine("Nhập phần trăm hoa hồng: ");
    PhanTramHoaHong = Convert.ToInt32(Console.ReadLine());
  }

  public override double TinhLuong()
  {
    double LuongCB = base.TinhLuong();
    double TongLuong = LuongCB + (LuongCB * PhanTramHoaHong);
    return TongLuong;
  }
}