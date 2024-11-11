CongTy cty = new CongTy();

cty.HienThiChucNang();

int Chon = cty.ChonChucNang();

while (true)
{
  switch (Chon)
  {
    case 1:
      {
        cty.ThemNhanVien();
      }; break;

    case 2:
      {
        cty.XuatDanhSachNhanVien();
      }; break;
  }

  cty.HienThiChucNang();

  if (Chon == 8)
  {
    break;
  }
}
