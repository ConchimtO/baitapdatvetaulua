using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BaiTapDatVe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (cbxNam.IsChecked == true)
                cbxNu.IsChecked = false;
        }

        private void cbxNu_Checked(object sender, RoutedEventArgs e)
        {
            if (cbxNu.IsChecked == true)
                cbxNam.IsChecked = false;
        }

        private void cbxGiuong_Checked(object sender, RoutedEventArgs e)
        {
            if (cbxGiuong.IsChecked == true)
                cbxGhe.IsChecked = false;
        }

        private void cbxGhe_Checked(object sender, RoutedEventArgs e)
        {
            if (cbxGhe.IsChecked == true)
                cbxGiuong.IsChecked = false;
        }

        private void cbxVND_Checked(object sender, RoutedEventArgs e)
        {
            if (cbxVND.IsChecked == true)
                cbxUSD.IsChecked = false;
        }

        private void cbxUSD_Checked(object sender, RoutedEventArgs e)
        {
            if (cbxUSD.IsChecked == true)
                cbxVND.IsChecked = false;
        }

        private String QuocTich()
        {
            if (lstbQuocTich.SelectedIndex == 0)

                return "Viet Nam";
            else if (lstbQuocTich.SelectedIndex == 1)
                return "Phap";
            else if (lstbQuocTich.SelectedIndex == 2)
                return "Anh";
            else if (lstbQuocTich.SelectedIndex == 3)
                return "Canada";
            
            return null;
            
                
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String ten = "Ten : " + txbTen.Text + "\n";
            String sdt = "So Dien Thoai : " + txbSDT.Text + "\n";
            String gioiTinh;
            if (cbxNam.IsChecked == true)
                gioiTinh = "Gioi Tinh : Nam" + "\n";
            else
                gioiTinh = "Gioi Tinh : Nu" +"\n" ;
            String loaiVe;
            if (cbxGiuong.IsChecked == true)
                loaiVe = "Loai Ve : Giuong" + "\n";
            else
                loaiVe = "Loai ve : Ghe" + "\n";

            String quocTich = null;

            quocTich = QuocTich();

            String thanhToan;
            if (cbxUSD.IsChecked == true)
                thanhToan = "USD";
            else
                thanhToan = "VND";

            float tienVNDGhe = 200000;
            float tienUSDGhe = 200000/20000;
            float tienVNDGiuong = 500000;
            float tienUSDGiuong = 500000/20000;

            float tienGiamGheVND = (tienVNDGhe * 80) / 100;
            float tienGiamGiuongUSD = (tienUSDGiuong * 80) / 100;

            String tongTien = null;
            


            if (cbxNam.IsChecked == false && cbxNu.IsChecked == false )
                MessageBox.Show("Loi chua chon du chuc nang");
            
            else if(cbxUSD.IsChecked == false && cbxVND.IsChecked == false )
                
                MessageBox.Show("Loi chua chon du chuc nang");
            
            else if(cbxGiuong.IsChecked == false && cbxGhe.IsChecked == false)
               
                MessageBox.Show("Loi chua chon du chuc nang");
            else if (quocTich == null)
            {
                MessageBox.Show("Loi chua chon du chuc nang");
            }
            else if (txbSDT.Text.Equals(""))
            {
                MessageBox.Show("Loi chua chon du chuc nang");
            }

            else if (txbTen.Text.Equals(""))
            {
                MessageBox.Show("Loi chua chon du chuc nang");
            }
            else
            {
                String hienThi = ten + sdt + gioiTinh + loaiVe + "Quoc Tich : " + quocTich + "\n" + "Thanh Toan : " + thanhToan + "\n"
                                   + "Tong Tien : " + tongTien + "\n";
                txblHienThi.Text = hienThi;
            }


           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
         //   ListBox list = sender as ListBox;
           // txblHienThi.Text = list.SelectedIndex.ToString();
        ///}

   





    }
}
