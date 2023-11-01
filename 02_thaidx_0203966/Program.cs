using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_thaidx_0203966
{
    class LopMH
    {
        String maLop;
        String tenLop;
        String ghiChu;
        public LopMH(string maLop, string tenLop, string ghiChu)
        {
            this.maLop = maLop;
            this.tenLop = tenLop;
            this.ghiChu = ghiChu;
        }
        public String getMaLop() { return maLop; }
        public String getTenLop() { return tenLop; }
        public String getGhiChu() { return ghiChu; }

        public void setMaLop(string maLop) { this.maLop = maLop; }
        public void setTenLop(string tenLop) { this.tenLop = tenLop; }
        public void setGhiChu(string ghiChu) { this.ghiChu = ghiChu; }
        public void display(int stt)
        {
            Console.WriteLine(String.Format("|{0,-5}|{1,-15}|{2,-30}|{3,-30}|", stt, maLop, tenLop, ghiChu));
        }
    }
    class SinhVien
    {
        String maSV;
        String tenSV;
        String maLop;
        public double diemTichLuy;
        String ghiChu;
        public SinhVien(string maSV, string tenLop, string maLop, double diemTichLuy, string ghiChu)
        {
            this.maLop = maLop;
            this.tenSV = tenLop;
            this.maSV = maSV;
            this.diemTichLuy = diemTichLuy;
            this.ghiChu = ghiChu;
        }
        public String getMaSV() { return maSV; }
        public String getTenSV() { return tenSV; }
        public String getMaLop() { return maLop; }
        public String getGhiChu() { return ghiChu; }
        public Double getDiemTichLuy() {  return diemTichLuy; }
        public void setMaSV(string maSV) { this.maSV = maSV; }
        public void setTenSV(string tenSV) { this.tenSV = tenSV; }
        public void setMaLop(string maLop) { this.maLop = maLop; }
        public void setGhiChu(string ghiChu) { this.ghiChu = ghiChu; }
        public void setDiemTichLuy(double diemTichLuy)
        {
            this.diemTichLuy = diemTichLuy;
        }
        public void display(int stt)
        {
            Console.WriteLine(String.Format("|{0,-5}|{1,-15}|{2,-30}|{3,-15}|{4,-10}|{5,-30}|", stt, maSV, tenSV, maLop, diemTichLuy, ghiChu));
        }
    }
    public class Program{
        static void Main(string[] args){
            string menu = "******************************************************\n******************************************************\n**     1. Quan ly Lop Mon Hoc                       **\n**     2. Quan ly Sinh Vien                         **\n**     3. Sap Xep Sinh Vien theo Diem Tich Luy      **\n**     4. Tim kiem chinh xac Sinh Vien              **\n**     5. Tim kiem gan dung Sinh Vien               **\n**     0. Thoat                                     **\n******************************************************\n******************************************************\n";
            string menuQuanLyLop = "******************************************\n*******      Quan Ly Lop MH        *******\n******************************************\n*******      1. Them Lop           *******\n*******      2. Sua Lop            *******\n*******      3. Xoa Lop            *******\n*******      0. Thoat              *******\n******************************************\n******************************************\n";
            string menuQuanLySV = "******************************************\n*******      Quan Ly Sinh Vien     *******\n******************************************\n*******      1. Them Sinh Vien     *******\n*******      2. Sua Sinh Vien      *******\n*******      3. Xoa Sinh Vien      *******\n*******      0. Thoat              *******\n******************************************\n******************************************\n";
            List<LopMH> listLopMH = new List<LopMH>();
            List<SinhVien> listSinhVien = new List<SinhVien>();

            int chonMenu = 1;
            while (chonMenu != 0) {
                Console.WriteLine(menu);
                Console.WriteLine("Nhap Lua Chon: ");
                chonMenu = Convert.ToInt32(Console.ReadLine());
                switch (chonMenu)
                {
                    case 0:
                        break;
                    case 1:
                        int chonQuanLyMonHoc = 1;
                        while (chonQuanLyMonHoc != 0)
                        {
                            Console.WriteLine(menuQuanLyLop);
                            Console.WriteLine("Nhap lua chon: ");
                            chonQuanLyMonHoc = Convert.ToInt32(Console.ReadLine());
                            switch (chonQuanLyMonHoc)
                            {
                                case 0:
                                    break;
                                case 1:
                                    Console.WriteLine("Nhap Ma Lop: ");
                                    string maLop = Console.ReadLine();
                                    Console.WriteLine("Nhap Ten Lop: ");
                                    string tenLop = Console.ReadLine();
                                    Console.WriteLine("Nhap Ghi Chu Cho Lop Mon Hoc: ");
                                    string ghiChuMH = Console.ReadLine();
                                    listLopMH.Add(new LopMH(maLop, tenLop, ghiChuMH));
                                    break;
                                case 2:
                                    string menuSuaLopMH = "***************************************\n***************************************\n****       1. Sua Ma Lop           ****\n****       2. Sua Ten Lop          ****\n****       3. Sua Ghi Chu          ****\n****       4. Thoat                ****\n***************************************\n***************************************\n";
                                    int lengthListLopMH = listLopMH.Count();
                                    if (lengthListLopMH <= 0)
                                    {
                                        Console.WriteLine("Khong co lop nao de sua!!!");
                                    }
                                    else
                                    {
                                        Console.WriteLine(String.Format("|{0,-5}|{1,-15}|{2,-30}|{3,-30}|", "STT", "Ma Lop", "Ten Lop", "Ghi Chu"));
                                        Console.WriteLine(String.Format("|{0,-5}|{1,-15}|{2,-30}|{3,-30}|", "-----", "---------------", "------------------------------", "------------------------------"));
                                        for (int i = 0; i < lengthListLopMH; i++)
                                        {
                                            listLopMH[i].display(i + 1);
                                        }
                                        Console.WriteLine();
                                        Console.Write("Nhap STT muon sua: ");
                                        int chonSuaMH = Convert.ToInt32(Console.ReadLine());
                                        if (chonSuaMH > lengthListLopMH || chonSuaMH <= 0)
                                        {
                                            Console.WriteLine("Nhap sai!!!");
                                        }
                                        else
                                        {
                                            Console.WriteLine(menuSuaLopMH);
                                            Console.Write("Nhap Lua Chon: ");
                                            int luaChonSua = Convert.ToInt32(Console.ReadLine());
                                            switch (luaChonSua)
                                            {
                                                case 0:
                                                    break;
                                                case 1:
                                                    Console.WriteLine("Nhap Ma Lop Moi: ");
                                                    string newMaLop = Console.ReadLine();
                                                    listLopMH[chonSuaMH - 1].setMaLop(newMaLop);
                                                    break;
                                                case 2:
                                                    Console.WriteLine("Nhap Ten Lop Moi: ");
                                                    string newTenLop = Console.ReadLine();
                                                    listLopMH[chonSuaMH - 1].setTenLop(newTenLop);
                                                    break;
                                                case 3:
                                                    Console.WriteLine("Nhap Ghi Chu Moi Cho Lop: ");
                                                    string newGhiChuMH = Console.ReadLine();
                                                    listLopMH[chonSuaMH - 1].setGhiChu(newGhiChuMH);
                                                    break;
                                                default:
                                                    break;
                                            }
                                        }
                                    }
                                    break;
                                case 3:
                                    int lengthListLopMH2 = listLopMH.Count();
                                    if (lengthListLopMH2 <= 0)
                                    {
                                        Console.WriteLine("Khong co lop nao de xoa!!!");
                                    }
                                    else
                                    {
                                        Console.WriteLine(String.Format("|{0,-5}|{1,-15}|{2,-30}|{3,-30}|", "STT", "Ma Lop", "Ten Lop", "Ghi Chu"));
                                        Console.WriteLine(String.Format("|{0,-5}|{1,-15}|{2,-30}|{3,-30}|", "-----", "---------------", "------------------------------", "------------------------------"));
                                        for (int i = 0; i < lengthListLopMH2; i++)
                                        {
                                            listLopMH[i].display(i + 1);
                                        }
                                        Console.WriteLine();
                                        Console.Write("Nhap STT muon xoa: ");
                                        int chonXoaMH = Convert.ToInt32(Console.ReadLine());
                                        if (chonXoaMH > lengthListLopMH2 || chonXoaMH <= 0)
                                        {
                                            Console.WriteLine("Nhap sai!!!");
                                        }
                                        else
                                        {
                                            listLopMH.Remove(listLopMH[chonXoaMH - 1]);
                                        }
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Nhap sai!!!");
                                    break;
                            }
                        }
                        break;
                    case 2:
                        int chonQuanLySinhVien = 1;
                        while (chonQuanLySinhVien != 0)
                        {
                            Console.WriteLine(menuQuanLySV);
                            Console.WriteLine("Nhap lua chon: ");
                            chonQuanLySinhVien = Convert.ToInt32(Console.ReadLine());
                            switch (chonQuanLySinhVien)
                            {
                                case 0:
                                    break;
                                case 1:
                                    Console.Write("Nhap Ma Sinh Vien: ");
                                    string maSV = Console.ReadLine();
                                    Console.Write("Nhap Ten Sinh Vien: ");
                                    string tenSV = Console.ReadLine();
                                    Console.Write("Nhap Ma Lop: ");
                                    string maLop = Console.ReadLine();
                                    Console.Write("Nhap Diem Tich Luy: ");
                                    double diemTichLuy = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Nhap Ghi Chu Cho Sinh Vien: ");
                                    string ghiChu = Console.ReadLine();
                                    listSinhVien.Add(new SinhVien(maSV, tenSV, maLop, diemTichLuy, ghiChu));
                                    break; 
                                case 2:
                                    string menuSuaSV = "***************************************\r\n***************************************\r\n****       1. Sua Ma Sinh Vien     ****\r\n****       2. Sua Ten Sinh Vien    ****\r\n****       3. Sua Ma Lop MH        ****\r\n****       4. Sua Diem Tich Luy    ****\r\n****       5. Sua Ghi Chu          ****\r\n****       4. Thoat                ****\r\n***************************************\r\n***************************************";
                                    int lengthListSV = listSinhVien.Count();
                                    if(lengthListSV <= 0)
                                    {
                                        Console.WriteLine("Chua co sinh vien nao de sua");
                                    }
                                    else
                                    {
                                        Console.WriteLine(String.Format("|{0,-5}|{1,-15}|{2,-30}|{3,-15}|{4,-10}|{5,-30}|", "STT", "Ma Sinh Vien", "Ten Sinh Vien", "Ma Lop", "Diem", "Ghi Chu"));
                                        Console.WriteLine(String.Format("|{0,-5}|{1,-15}|{2,-30}|{3,-15}|{4,-10}|{5,-30}|", "-----", "---------------", "------------------------------", "---------------", "----------", "------------------------------"));
                                        for(int i = 0; i < listSinhVien.Count(); i++)
                                        {
                                            listSinhVien[i].display(i + 1);

                                        }
                                        Console.WriteLine();
                                        Console.Write("Nhap STT muon sua: ");
                                        int chonSua = Convert.ToInt32(Console.ReadLine());
                                        if (chonSua > lengthListSV || chonSua <= 0)
                                        {
                                            Console.WriteLine("Nhap sai!!!");
                                        }
                                        else
                                        {
                                            Console.WriteLine(menuSuaSV);
                                            Console.Write("Nhap Lua Chon: ");
                                            int luaChonSua = Convert.ToInt32(Console.ReadLine());
                                            switch (luaChonSua)
                                            {
                                                case 0:
                                                    break;
                                                case 1:
                                                    Console.Write("Nhap Ma Sinh Vien Moi: ");
                                                    string newMaSV = Console.ReadLine();
                                                    listSinhVien[chonSua - 1].setMaSV(newMaSV);
                                                    break;
                                                case 2:
                                                    Console.Write("Nhap Ten Sinh Vien Moi: ");
                                                    string newSV = Console.ReadLine();
                                                    listSinhVien[chonSua - 1].setTenSV(newSV);
                                                    break;
                                                case 3:
                                                    Console.Write("Nhap Ma Lop Moi: ");
                                                    string newMaLop = Console.ReadLine();
                                                    listSinhVien[chonSua - 1].setMaLop(newMaLop);
                                                    break;
                                                case 4:
                                                    Console.Write("Nhap Diem Tich Luy Moi: ");
                                                    double newDiem = Convert.ToDouble(Console.ReadLine());
                                                    listSinhVien[chonSua - 1].setDiemTichLuy(newDiem);
                                                    break;
                                                case 5:
                                                    Console.Write("Nhap Ghi Chu Moi: ");
                                                    string newGhiChu = Console.ReadLine();
                                                    listSinhVien[chonSua - 1].setGhiChu(newGhiChu);
                                                    break;
                                                default:
                                                    break;
                                            }
                                        }
                                    }
                                    break;
                                case 3:
                                    lengthListSV = listSinhVien.Count();
                                    if (lengthListSV <= 0)
                                    {
                                        Console.WriteLine("Khong co sinh vien nao de xoa!!!");
                                    }
                                    else
                                    {
                                        Console.WriteLine(String.Format("|{0,-5}|{1,-15}|{2,-30}|{3,-15}|{4,-10}|{5,-30}|", "STT", "Ma Sinh Vien", "Ten Sinh Vien", "Ma Lop", "Diem", "Ghi Chu"));
                                        Console.WriteLine(String.Format("|{0,-5}|{1,-15}|{2,-30}|{3,-15}|{4,-10}|{5,-30}|", "-----", "---------------", "------------------------------", "---------------", "----------", "------------------------------"));
                                        for (int i = 0; i < listSinhVien.Count(); i++)
                                        {
                                            listSinhVien[i].display(i + 1);

                                        }
                                        Console.WriteLine();
                                        Console.Write("Nhap STT muon xoa: ");
                                        int chonXoa = Convert.ToInt32(Console.ReadLine());
                                        if (chonXoa > lengthListSV || chonXoa <= 0)
                                        {
                                            Console.WriteLine("Nhap sai!!!");
                                        }
                                        else
                                        {
                                            listSinhVien.Remove(listSinhVien[chonXoa - 1]);
                                        }
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Nhap sai!!!");
                                    break;
                            }

                        }

                        break;
                    case 3:
                        List<SinhVien> newList = new List<SinhVien>();
                        newList = listSinhVien.OrderBy(SV => SV.diemTichLuy).ToList();
                        Console.WriteLine(String.Format("|{0,-5}|{1,-15}|{2,-30}|{3,-15}|{4,-10}|{5,-30}|", "STT", "Ma Sinh Vien", "Ten Sinh Vien", "Ma Lop", "Diem", "Ghi Chu"));
                        Console.WriteLine(String.Format("|{0,-5}|{1,-15}|{2,-30}|{3,-15}|{4,-10}|{5,-30}|", "-----", "---------------", "------------------------------", "---------------", "----------", "------------------------------"));
                        for (int i = 0; i < newList.Count(); i++)
                        {
                            newList[i].display(i + 1);
                        }
                        break;
                    case 4:
                        int lengthSV = listSinhVien.Count();
                        if(lengthSV <= 0)
                        {
                            Console.WriteLine("Khong co Sinh Vien nao");
                        }
                        else
                        {
                            Console.Write("Nhap Ma Lop: ");
                            string malop = Console.ReadLine();
                            Console.Write("Nhap Ma Sinh Vien: ");
                            string maSinhVien = Console.ReadLine();
                            Console.WriteLine(String.Format("|{0,-5}|{1,-15}|{2,-30}|{3,-15}|{4,-10}|{5,-30}|", "STT", "Ma Sinh Vien", "Ten Sinh Vien", "Ma Lop", "Diem", "Ghi Chu"));
                            Console.WriteLine(String.Format("|{0,-5}|{1,-15}|{2,-30}|{3,-15}|{4,-10}|{5,-30}|", "-----", "---------------", "------------------------------", "---------------", "----------", "------------------------------"));
                            int stt = 1;
                            for (int i = 0; i < lengthSV; i++)
                            {
                                if (listSinhVien[i].getMaSV() == maSinhVien && listSinhVien[i].getMaLop() == malop)
                                {
                                    listSinhVien[i].display(stt);
                                    stt++;
                                }
                            }
                            if(stt == 1)
                            {
                                Console.WriteLine("Khong co sinh vien nao thoa man");
                            }
                        }
                        break;
                    case 5:
                        int lengthListSV1 = listSinhVien.Count();
                        if (lengthListSV1 <= 0)
                        {
                            Console.WriteLine("Khong co Sinh Vien nao");
                        }
                        else
                        {
                            Console.Write("Nhap Ten Sinh Vien: ");
                            string tenSinhVien = Console.ReadLine();
                            Console.WriteLine(String.Format("|{0,-5}|{1,-15}|{2,-30}|{3,-15}|{4,-10}|{5,-30}|", "STT", "Ma Sinh Vien", "Ten Sinh Vien", "Ma Lop", "Diem", "Ghi Chu"));
                            Console.WriteLine(String.Format("|{0,-5}|{1,-15}|{2,-30}|{3,-15}|{4,-10}|{5,-30}|", "-----", "---------------", "------------------------------", "---------------", "----------", "------------------------------"));
                            int stt = 1;
                            for (int i = 0; i < lengthListSV1; i++)
                            {
                                if (listSinhVien[i].getTenSV().Contains(tenSinhVien))
                                {
                                    listSinhVien[i].display(stt);
                                    stt++;
                                }
                            }
                            if (stt == 1)
                            {
                                Console.WriteLine("Khong co sinh vien nao thoa man");
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Nhap Sai!!!");
                        break;
                }
            }
        }
    }
}
