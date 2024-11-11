class NhanVienVanPhong : NhanVien
{

  public string Mota { get; set; }
  public void MoTaCongViec()
  {
    Console.WriteLine("Mô tả công việc: abc");
  }
}