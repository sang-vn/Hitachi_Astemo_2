using System;
using System.IO;
using System.Windows;

namespace Hitachi_Astemo.Models
{
    public class FileTXT : IDisposable
    {
        private StreamReader sr;
        private StreamWriter sw;
        private bool disposed = false; // Để kiểm tra xem đối tượng đã được giải phóng hay chưa

        //Ghi file
        public bool WriteFile(double index, string maSP)
        {
            try
            {
                string path = AppDomain.CurrentDomain.BaseDirectory + "Text_Document.txt";

                //Doi tuong ghi File
                using (sw = new StreamWriter(path, true)) // 'true' để thêm nội dung thay vì ghi đè
                {
                    string line = index.ToString() + "-" + maSP;
                    sw.WriteLine(line);
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Doc file
        public bool ReadFile(double index, out string maSp)
        {
            maSp = null; // Khởi tạo giá trị cho maSp
            try
            {
                string path = AppDomain.CurrentDomain.BaseDirectory + "Text_Document.txt";
                //Doi tuong doc File
                using (sr = new StreamReader(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] arr = line.Split('-');
                        if (arr.Length == 2) // Đảm bảo có đúng 2 phần tử sau khi tách
                        {
                            if (double.TryParse(arr[0], out double fileIndex) && fileIndex == index)
                            {
                                maSp = arr[1].Trim();
                                return true;
                            }
                        }
                    }
                }
                return false; // Không tìm thấy giá trị
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        // Triển khai phương thức Dispose để giải phóng tài nguyên
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this); // Ngăn việc thu dọn đối tượng thông qua bộ thu gom rác
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Giải phóng tài nguyên quản lý (managed resources)
                    sr?.Dispose();
                    sw?.Dispose();
                }

                disposed = true;
            }
        }

        ~FileTXT()
        {
            Dispose(false);
        }
    }
}
