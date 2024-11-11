using System.Text.Json;

class CongTy
{
  public List<NhanVien> lstNhanVien = new List<NhanVien>();

  public int chon { get; set; }

  public void HienThiChucNang()
  {
    Console.WriteLine(@"
            1/ Thêm nhân viên.
            2/ Hiển thị danh sách nhân viên.
            8/ Thoát
    ");
  }
  public void ThemNhanVien()
  {
    Console.WriteLine(@"
    Chọn thêm nhân viên:
    1/ Nhân viên văn phòng
    2/ Nhân viên sản xuất
    3/ Nhân viên kinh doanh
    ");

    int chonLoaiNhanVien = Convert.ToInt16(Console.ReadLine());

    NhanVien nv = new NhanVien();

    switch (chonLoaiNhanVien)
    {
      case 1:
        {
          nv = new NhanVienVanPhong();
        }; break;
      case 2:
        {
          nv = new NhanVienSanXuat();
        }; break;
      case 3:
        {
          nv = new NhanVienKinhDoanh();
        }; break;
    }
    nv.NhapThongTin();
    lstNhanVien.Add(nv);
  }

  public int ChonChucNang()
  {
    Console.WriteLine("Hãy chọn chức năng: ");
    chon = Convert.ToInt32(Console.ReadLine());
    return chon;
  }

  public void XuatDanhSachNhanVien()
  {
    foreach (NhanVien nv in lstNhanVien)
    {
      nv.XuatThongTin();
      if (nv is NhanVienVanPhong nvVp)
      {
        nvVp.MoTaCongViec();
      }
    }
  }

}