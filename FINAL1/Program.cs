using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Serialization;

namespace FINAL1
{
    internal class Program
    {
        static void dem()
        {
            Console.Write("Nhap so luong phan tu cua day: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[n];
            Console.WriteLine("Nhap cac so nguyen:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Number {i + 1}: ");
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }
            int am = 0;
            int duong = 0;
            int tongam = 0;
            int tongduong = 0;

            foreach (int num in nums)
            {
                if (num < 0)
                {
                    am++;
                    tongam += num;
                }
                else if (num > 0)
                {
                    duong++;
                    tongduong += num;
                }
            }
            Console.WriteLine($"So luong so am: {am}");
            Console.WriteLine($"Tong so am: {tongam}");
            Console.WriteLine($"So luong so duong: {duong}");
            Console.WriteLine($"Tong so duong: {tongduong}");
        }

        static void Kytu()
        {
            Console.Write("Nhap chuoi: ");
            string str = Console.ReadLine();
            int hoa = 0;
            int thuong = 0;
            int so = 0;

            foreach (char c in str)
            {
                if (char.IsUpper(c))
                    hoa++;
                else if (char.IsLower(c))
                    thuong++;
                else if (char.IsDigit(c))
                    so++;
            }
            Console.WriteLine($"So chu hoa la {hoa}, so chu thuong la {thuong}, so luong so la {so}");

        }

        static void Dao()
        {
            double a = 5;
            double b = 9;
            Console.WriteLine($"Ban dau: a = {a}, b = {b}");
            double c = a;
            a = b;
            b = c;
            Console.WriteLine($"Sau khi dao: a = {a}, b = {b}");
        }

        static void Create()
        {
            string[] noidung =
            {
            "Cơ sở A: 59C Nguyễn Đình Chiểu - P. Võ Thị Sáu - Q.3",
            "Cơ sở B: 279 Nguyễn Tri Phương - P.5 - Q.10",
            "Cơ sở C: 91 Đường 3/2 - P.11 - Q.10",
            "Cơ sở D: 196 Trần Quang Khải - P. Tân Định - Q.1",
            "Cơ sở E: 54 Nguyễn Văn Thủ - P. Đakao - Q.1",
            "Cơ sở Nguyễn Văn Linh - xã Phong Phú - H. Bình Chánh"
            };
            File.WriteAllLines(@"ueh.txt", noidung);
            // đọc file 
            string[] lines = File.ReadAllLines(@"ueh.txt");
            for (int i = 0; i < lines.Length; i += 2)
            {
                Console.WriteLine($"{lines[i]}");
            }
        }

        static void game()
        {
            int guess;
            Console.WriteLine("Doan so tu 0 den 100");
            Random com_num = new Random();
            int secret_num = com_num.Next(0, 101);
            for (int i = 0; i < 7; i++)
            {
                Console.Write($"Lan {i + 1} - so ban doan la: ");
                while (!int.TryParse(Console.ReadLine(), out guess) || guess < 0 || guess > 100)
                {
                    Console.Write("Nhap lai: ");
                }
                if (guess > secret_num)
                    Console.WriteLine("So ban doan lon hon");
                else if (guess < secret_num)
                    Console.WriteLine("So ban doan nho hon");
                else
                {
                    Console.WriteLine("Ban doan dung");
                    return;
                }
            }
            Console.WriteLine($"So bi mat la: {secret_num}");
        }

        static void hcn()
        {
            Console.Write("Chieu dai của hcn: ");
            int dai = Convert.ToInt32(Console.ReadLine());
            Console.Write("Chieu rong cua hcn: ");
            int rong = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j < rong; j++)
            {

                for (int i = 0; i < dai - 1; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("*");
            }
        }

        static void lon()
        {
            Console.Write($"So lon nuoc khach mua : ");
            int mua = Convert.ToInt32(Console.ReadLine());
            int non = mua / 3;
            int viet = (mua % 3) * 2;
            int tien = mua * 27000;
            Console.WriteLine($"So tien phai tra: {tien}");
            Console.WriteLine($"Duoc thuong {non} cai non, {viet} cay viet");
        }

        static void heso()
        {
            Console.WriteLine("Cho phuong trinh: ax + b = 0");
            Console.Write("Nhap so a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap so b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Phuong trinh vo so nghiem");
                }
                else
                {
                    Console.WriteLine("Pt vo nghiem");
                }
            }
            else
            {
                double x = -b / a;
                Console.WriteLine($"KET QUA: {x:F5}");
            }
        }

        static void diennuoc()
        {
            Console.Write("Nhap ho va ten: ");
            string name = Console.ReadLine();
            Console.Write("Chi so dien ke thang truoc:");
            double truoc = Convert.ToDouble(Console.ReadLine());
            Console.Write("Chi so dien ke thang nay: ");
            double nay = Convert.ToDouble(Console.ReadLine());
            double tien = (nay - truoc) * 452.45;
            Console.WriteLine(@$"Hóa đơn tiền điện
Khách hàng {name}
Chỉ số cũ: {truoc}
Chỉ số mới: {nay}
Tiêu thụ: {nay - truoc}
Tien dien: {tien}
Tiền thuê điện kế 12426 đ/tháng
Tiền phụ thu 10% tiền điện
Tổng tiền phải trả: {((tien + 12426) * 1.1):F2}
Yêu cầu tiết kiệm điện
------------------------------------------

");

        }
        static void txt()
        {
            Console.Write("Nhập họ và tên: ");
            string name = Console.ReadLine();
            Console.Write("Mã số nhân viên: ");
            string ma = Console.ReadLine();
            Console.Write("Chức vụ: ");
            string chuc = Console.ReadLine();
            Console.Write("Ngày vào làm (dd/mm/yyyy): ");
            string vao_lam = Console.ReadLine();

            string[] noidung = {$"Họ tên: {name} ",
                $"Mã nhân viên: {ma}",
                $"Chức vụ: {chuc}",
                $"Ngày vào làm (dd/mm/yyyy): {vao_lam}"};
            File.WriteAllLines(@"thong_tin_nhan_vien", noidung);
            string[] lines = File.ReadAllLines("thong_tin_nhan_vien");
            int nam = int.Parse(lines[3].Substring(lines[3].Length - 4));
            int thamNien = DateTime.Now.Year - nam;

            Console.WriteLine(@$"Mã nhân viên: {ma}
Họ tên: {name}
Chức vụ: {chuc}
Thâm niên: {thamNien} năm");
        }

        static void thongke()
        {
            Console.Write("Số lượng số nguyên trong mảng : ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n < 2)
            {
                Console.WriteLine("Mang phai co it nhat 2 so!");
            }
            int[] mang = new int[n];
            for (int i = 0; i < mang.Length; i++)
            {
                Console.Write($"Nhap so thu {i + 1}: ");
                mang[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max = mang[0];
            int min = mang[0];
            double tong = 0;
            foreach (int k in mang)
            {
                if (k > max)
                {
                    max = k;
                }
                if (k < min)
                {
                    min = k;
                }
                tong += k;
            }
            double avg = (tong / n);
            Console.WriteLine("Sô lon nhat: " + max);
            Console.WriteLine("Số nhỏ nhất: " + min);
            Console.WriteLine($"Trung bình của mảng: {avg:F4}");
        }

        static void dem2()
        {
            Console.Write("Nhap chuoi: ");
            string chuoi = Console.ReadLine();
            int chu = 0;
            int so = 0;
            int db = 0;
            foreach (char c in chuoi)
            {
                if (char.IsLetter(c))
                {
                    chu += 1;
                }
                else if (char.IsDigit(c))
                {
                    so += 1;
                }
                else
                {
                    db++;
                }
            }
            Console.WriteLine("So chu trong chuoi " + chu);
            Console.WriteLine("So luong so trong chuoi " + so);
            Console.WriteLine("So luong ki tu dac biet trong chuoi: " + db);
        }

        static bool nguyento(int x)
        {
            if (x < 2)
            { return false; }
            for (int i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x % i == 0)
                    return false;
            }
            return true;
        }

        static void matrix()
        {
            Console.Write("Nhap số cột: ");
            int cot = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap số dòng: ");
            int dong = Convert.ToInt32(Console.ReadLine());
            int[,] matran = new int[dong, cot];
            Random rnd = new Random();
            for (int i = 0; i < dong; i++)
                for (int j = 0; j < cot; j++)
                {
                    Console.Write($"Nhap so dòng {i + 1}, cột {j + 1}: ");
                    matran[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            for (int i = 0; i < dong; i++)
                for (int j = 0; j < cot; j++)
                    if (nguyento(matran[i, j]))
                    {
                        Console.WriteLine($"Số nguyên tố trong ma trận là: {matran[i, j]}");
                    }
        }

        static void chuot()
        {
            Console.OutputEncoding = Encoding.UTF8;
            string ten = "UEH";

            int x = 20; // tọa độ ngang (bất kỳ)
            int y = Console.WindowHeight - 1;

            for (; y >= 0; y--)
            {
                Console.Clear();
                Console.SetCursorPosition(x, y);
                Console.Write(ten);
                Thread.Sleep(288);
            }
        }

        static void nhuan()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập năm cần kiểm tra: ");
            int year;
            while (!int.TryParse(Console.ReadLine(), out year) || year < 0 || year > 3000)
            {
                Console.WriteLine("Năm phải là số nguyên > 0 và < 3000");
            }
            if (year % 4 == 0)
                Console.WriteLine(year + " là năm nhuận");
            else
                Console.WriteLine(year + " không là năm nhuận");
        }

        static void boi()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Kiểm tra xem có phải là bội của 7 và 9 không!");
            Console.Write("Nhập số bất kì để kiểm tra: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 7 == 0 && num % 9 == 0)
            {
                Console.WriteLine(num + " là bội của 7 và 9");
            }
            else
                Console.WriteLine(num + " không là bội của 7 và 9");
        }

        static void diem()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập họ và tên: ");
            string name = Console.ReadLine();
            Console.Write("Nhập điểm giữa kì: ");
            double gk;
            while (!double.TryParse(Console.ReadLine(), out gk) || gk < 0 || gk > 10)
            {
                Console.WriteLine("Điểm phải nằm trong khoảng 0 đến 10!");
            }
            Console.Write("Nhập điểm cuối kì: ");
            double ck;
            while (!double.TryParse(Console.ReadLine(), out ck) || ck < 0 || ck > 10)
            {
                Console.WriteLine("Điểm phải nằm trong khoảng 0 đến 10!");
            }
            double avg = gk * 0.4 + ck * 0.6;
            string ketqua;
            if (avg >= 5)
                ketqua = "Đậu";
            else
                ketqua = "Rớt";

            Console.WriteLine($@"
*****************************
Họ tên sinh viên : {name}
Điểm giữa kỳ : {gk}
Điểm cuối kỳ: {ck}
Điểm trung bình: {avg}
Kết quả: {ketqua:F2}
*****************************");
        }

        static void bai1()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập họ tên: ");
            string name = Console.ReadLine();
            Console.Write("Ngày đi [chỉ cần nhập ngày]: ");
            int di = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ngày đến [chỉ cần nhập ngày]: ");
            int den;
            while (!int.TryParse(Console.ReadLine(), out den) || di < den)
            {
                Console.Write("Nhập lại ngày đi: ");
            }
            double gia = 100.000;
            if (di - den < 3)
            {
                gia = 100.000;
            }
            else gia = gia * 0.9;
            Console.WriteLine($@"
*************************************************
Khách hàng: {name}
Ngày đến: {den} (Chỉ cần nhập ngày. Ví dụ: 12)
Ngày đi: {di} (Chỉ cần nhập ngày. Ví dụ: 15)
Giá phòng: 100.000 
Số tiền phải trả: {gia:F3}
***********************************************************

");
        }

        static void bai2()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.Write("Nhập số nguyên bất kỳ: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine(num + " là số chẵn");
            else Console.WriteLine(num + " là số lẻ");
        }

        static void bai3()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.Write("Nhập tháng: ");
            int month;
            while (!int.TryParse(Console.ReadLine(), out month) || month > 12 || month < 1)
            {
                Console.Write("Nhập lại tháng: ");
            }
            if (month == 1 || month == 3 || month == 5 ||
                month == 7 || month == 8 || month == 10 || month == 12)
            {
                Console.WriteLine("tháng " + month + " có 31 ngày ");
            }
            else if (month == 2)
                Console.WriteLine("Nếu là năm nhuận tháng 2 có 29 ngày, năm không nhuận thì có 28 ngày!)");
            else Console.WriteLine("tháng " + month + " có 30 ngày");
        }

        static void bai4()
        {
            Console.InputEncoding = Encoding.UTF8;
            string name = "Phan Minh Khuê";
            int x = Console.WindowWidth - 1;
            int y = 10;
            for (; x > 0; x--)
            {
                Console.Clear();
                Console.SetCursorPosition(x, y);
                Console.Write(name);
                Thread.Sleep(200);
            }
        }

        static void bai5()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            int diem_com = 0;
            int diem_human = 0;
            Random random = new Random();

            Console.WriteLine("CHƠI KÉO BÚA BAO");
            Console.WriteLine(@"*****************
VỚI 1 LÀ  KÉO
VỚI 2 LÀ  BÚA 
VỚI 3 LÀ BAO 
");
            while (diem_com < 5 && diem_human < 5)
            {
                int play = random.Next(1, 4);
                Console.Write("Người chơi ra 1,2,3 tương ứng với kéo, búa, bao [chỉ nhập số]: ");
                int human;
                while (!int.TryParse(Console.ReadLine(), out human) || human < 1 || human > 3)
                {
                    Console.Write("Nhập lại [1,2.3]: ");
                }
                if (play == human)
                {
                    Console.WriteLine("Huề nhau !!");
                    Console.WriteLine("Tỷ số bây giờ là [máy - người]: " + diem_com + " - " + diem_human);
                }
                else if ((play == 1 && human == 3) || (play == 2 && human == 1) || (play == 3 && human == 2))
                {
                    Console.WriteLine($"Máy thắng");
                    diem_com++;
                    Console.WriteLine("Tỷ số bây giờ là [máy - người]: " + diem_com + " - " + diem_human);
                }
                else
                {
                    Console.WriteLine("Bạn thắng");
                    diem_human++;
                    Console.WriteLine("Tỷ số bây giờ là [máy - người]: " + diem_com + " - " + diem_human);
                }

            }
            if (diem_com == 5)
            {
                Console.WriteLine("Người chiến thắng chung cuộc là máy tính");

            }
            else if (diem_human == 5) Console.WriteLine("Chúc mừng! Bạn đã thắng");
        }

        static void bai6()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Bạn muốn tạo ma trận vuông cấp mấy: ");
            int cap = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập số m: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Số lượng số nguyên trong ma trận chia hết cho m");
            int[,] matrix = new int[cap, cap];
            Random random = new Random();
            int dem = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(0, 255);
                    if (matrix[i, j] % m == 0)
                    {
                        dem++;
                    }
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}   ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Số lượng số nguyên chia hết cho {m} là {dem}");
        }

        static void bai7()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập chuỗi của bạn: ");
            string chuoi = Console.ReadLine();
            int so = 0;
            int hoa = 0;
            int thuong = 0;
            foreach (char c in chuoi)
            {
                if (char.IsDigit(c))
                {
                    so++;
                }
                else if (char.IsUpper(c))
                {
                    hoa++;
                }
                else if (char.IsLower(c))
                {
                    thuong++;
                }
            }
            Console.WriteLine($"Sô lượng số trong chuỗi là {so}");
            Console.WriteLine($"Số lượng chữ hoa trong chuỗi là {hoa}");
            Console.WriteLine($"Số lượng chữ thường trong chuỗi là {thuong}");
        }

        static bool bai9(int n, out double so)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int demsai = 0;
            while (demsai < n)
            {
                Console.Write("Nhập 1 số thực: ");
                if (double.TryParse(Console.ReadLine(), out so))
                {
                    return true;
                }
                demsai++;
                Console.WriteLine($"Nhập sai. Bạn còn {n - demsai} lần ");
            }
            so = 0;
            return false;
        }

        static void bai10()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập họ và tên của bạn: ");
            string name = Console.ReadLine();
            Console.Write("Nhập lớp của bạn: ");
            string lop = Console.ReadLine();
            Console.Write("Nhập mã số sinh viên của bạn: ");
            string mssv = Console.ReadLine();
            Console.Write("Nhập ngày tháng năm sinh [dd/mm/yyyy]: ");
            string ngays = Console.ReadLine();
            string noidung =
 @$"Họ và tên: {name}
Lớp: {lop}
MSSV: {mssv}
Ngày sinh: {ngays}
";
            File.WriteAllText("mssv.txt", noidung);
            string[] lines = File.ReadAllLines("mssv.txt");
            string hoten = lines[0].Split(':')[1].Trim();
            string lopHoc = lines[1].Split(':')[1].Trim();
            string mssv2 = lines[2].Split(':')[1].Trim();
            string ngaySinh = lines[3].Split(':')[1].Trim();
            string namSinh = ngaySinh.Split('/')[2];

            Console.WriteLine($"{mssv2} - {hoten} - {lopHoc} - {namSinh}");
        }

        static void hat()
        {
            Console.OutputEncoding = Encoding.UTF8;
            //DateTime now = DateTime.Now;
            //Console.Write("Ngày giờ hiện tại: " + now);
            Console.Write("Nhập ngày tháng năm sinh [dd/mm/yyyy]: ");
            string sinh = Console.ReadLine();
            int nam = Convert.ToInt32(sinh.Substring(sinh.Length - 4));
            int tuoi = (DateTime.Now.Year - nam);
            Console.WriteLine("Năm nay bạn " + tuoi + " tuổi");
        }

        static void dont()
        {
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.OutputEncoding = Encoding.UTF8;
                Console.Title = "Xin chào các bạn !";
                Console.Clear();
                bool a = Console.CapsLock;
                string kq = a ? " bat" : " tat";
                Console.SetCursorPosition(15, 20);
                Console.WriteLine("Phim Capslock dang" + kq);
                Console.Beep(1000, 200);
                Console.WriteLine("Ấn 1 phím đi !");
                ConsoleKeyInfo cik = Console.ReadKey();
            }
        }
        static void abc()
        {
            Console.WriteLine("Bảng mã ASCII:");
            for (int i = 0; i <= 255; i++)
            {
                Console.WriteLine($"ASCII {i}: {(char)i}");
            }

        }

        static void a()
        {
            Console.OutputEncoding = Encoding.UTF8;
            string[] thapcan = { "Canh", "Tân",
"Nhâm", "Quý", "Giáp", "Ất", "Bính", "Đinh",
"Mậu", "Kỷ" };
            string[] thapnhichi = { "Tý", "Sửu", "Dần",
"Mão", "Thìn", "Tỵ", "Ngọ", "Mùi", "Thân",
"Dậu", "Tuất", "Hợi" };
            Console.Write("Nhập năm sinh dương lịch của bạn(sau năm 1900): ");
            int year = int.Parse(Console.ReadLine());
            if (year < 1900)
            {

                Console.WriteLine("Năm sinh phải hơn 1900!");
                return;
            }
            int thapcanIndex = (year - 1900) % 10;
            int thapnhichiIndex = (year - 1900) % 12;
            Console.WriteLine($"Năm {year} là năm âm lịch: {thapcan[thapcanIndex]}  {thapnhichi[thapnhichiIndex]} ");
        }

        static void ky()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập năm sinh của nam: ");
            int namsinh1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập năm sinh của nữ: ");
            int namsinh2 = Convert.ToInt32(Console.ReadLine());
            string[] giap = { "Thân", "Dậu", "Tuất", "Hợi", "Tý", "Sửu", "Dần", "Mẹo", "Thìn", "Tỵ", "Ngọ", "Mùi" };
            string giapnam = giap[namsinh1 % 12];
            string giapnu = giap[namsinh2 % 12];
            bool ky = false;
            if ((namsinh1 % 12 - namsinh2 % 12 + 12) % 12 == 3 || (namsinh2 % 12 - namsinh1 % 12 + 12) % 12 == 3)
            {
                ky = true;
            }
            if (ky)
            {
                Console.WriteLine($"Hai người bị kỵ tuổi - do con giáp của nam là {giapnam}, giáp của nữ là {giapnu}");
            }

            else Console.WriteLine($"Hai người không bị kỵ tuổi - do con giáp của nam là {giapnam}, giáp của nữ là {giapnu}");
        }

        static bool IsHappy(int n)
        {
            while (n != 1 && n != 4)
            {
                int tong = 0;
                while (n > 0)
                {
                    int d = n % 10;
                    tong += d * d;
                    n /= 10;
                }
                n = tong;
            }
            return n == 1;
        }


        static void order()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] chuoi = new int[10];
            Random random = new Random();
            for (int i = 0; i < chuoi.Length; i++)
            {
                chuoi[i] = random.Next(0, 101);
            }
            for (int i = 0; i < chuoi.Length - 1; i++)
            {
                for (int j = 0; j < chuoi.Length - 1 - i; j++)
                {
                    if (chuoi[j] > chuoi[j + 1])
                    {
                        int temp = chuoi[j];
                        chuoi[j] = chuoi[j + 1];
                        chuoi[j + 1] = temp;
                    }

                }
            }
            for (int k = 0; k < chuoi.Length; k++)
            {
                Console.Write(chuoi[k] + "\t");
            }
            Console.WriteLine("\n Số lớn thứ hai trong chuỗi là: " + chuoi[chuoi.Length - 2]);
        }

        static void tong()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[,] matrix = new int[2, 3];
            Random rnd = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(0, 101);
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }


            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                int sum = 0;
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    sum += matrix[j  , i];
                }
                Console.WriteLine($"Tổng cột thứ  {i + 1} là: " + sum); 
            }
        }
            static void Main(string[] args)
            {
                tong();
                //order();
                //Console.Write("Nhap so: ");
                // int n = int.Parse(Console.ReadLine());

                //   if (IsHappy(n))
                //     Console.WriteLine("Happy Number");
                //else
                //  Console.WriteLine("Khong phai Happy Number");

                //ky(); 
                //a(); 
                //abc(); 
                //dont();
                //hat(); 
                //dem();
                //Kytu(); 
                //Dao(); 
                //Create(); 
                //game();
                //hcn ();
                //lon();
                //heso(); 
                //diennuoc(); 
                //txt();
                //thongke(); 
                //dem2(); 
                //matrix();
                //chuot(); 
                //nhuan(); 
                //boi(); 
                //diem(); 
                //bai1(); 
                //bai2 ();
                //bai3(); 
                //bai4(); 
                //bai5(); 
                //bai6(); 
                //bai7(); 
                //double x;

                //   if (bai9(3, out x))

                //     Console.WriteLine("Bạn nhập đúng số thực " + x);

                //else Console.WriteLine("Bạn nhập sai quá số lần cho phép");
                //bai10(); 

            }
        

    }
}
