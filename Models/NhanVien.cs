class NhanVien
{
  public static int AutoId = 1;

  public int Id { get; set; }
  public string? HoTen { get; set; }
  public double LuongCanBan { get; set; }

  public NhanVien() { }

  public virtual void NhapThongTin()
  {
    Id = AutoId;
    AutoId++;

    // Console.WriteLine("Nhập id:");
    // Id = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Nhập Họ Tên:");
    HoTen = Console.ReadLine();
    Console.WriteLine("Nhập Lương Căn Bản:");
    LuongCanBan = Convert.ToDouble(Console.ReadLine());
  }

  public void XuatThongTin()
  {
    Console.WriteLine(@$"
    Mã nhân viên: {Id} - {HoTen} - Luong: {TinhLuong()}
    ----------------------------------------------------");
  }

  public virtual double TinhLuong()
  {
    return LuongCanBan;
  }
}