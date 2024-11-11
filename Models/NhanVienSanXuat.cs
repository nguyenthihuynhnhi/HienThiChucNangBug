class NhanVienSanXuat : NhanVien
{
  public int SoLuongSanPham { get; set; }

  public override void NhapThongTin()
  {
    // Gọi phương thức của class cha
    base.NhapThongTin();

    //Code thêm phần riêng của class con
    Console.WriteLine("Nhập số lượng sản phẩm sản xuất: ");
    SoLuongSanPham = Convert.ToInt32(Console.ReadLine());
  }

  public override double TinhLuong()
  {
    double LuongCB = base.TinhLuong();
    double TongLuong = LuongCB * SoLuongSanPham;
    return TongLuong;
  }
}