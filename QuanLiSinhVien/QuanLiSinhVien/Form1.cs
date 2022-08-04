using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLiSinhVien;

public partial class Form1 : Form
{
    //tao ket noi
    SqlConnection _connection;
    SqlCommand _command;
    string str = "Data Source=MSI;Initial Catalog=QLSV;Integrated Security=True";
    SqlDataAdaper adaper = new SqlDataAdaper();

    DataTable table = new DataTable();

    void loaddata()
    {
        _command = _connection.CreateCommand();
        _command.CommandText = "select * form ThongTinSinhVien ";
        //_command.ExecuteNonQuery();
        adaper.SelectCommand = _command;
        table.Clear();

        adaper.Fill(table);
        dataGV.DataSource = table;
    }



    public Form1()
    {
        InitializeComponent();
    }

    private void label4_Click(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void Form1_Load(object sender, EventArgs e)
    {
        _connection = new SqlConnection(str);
        _connection.Open(); // mo ket noi

        loaddata();
    }

    private void dataGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        txt_MaSV.ReadOnly = true; // khong cho sua MaSV
        int i;
        i = dataGV.CurrentRow.Index;
        txt_MaSV.Text = dataGV.Row[i].Cells[0].Value.ToString();
        txt_HoSV.Text = dataGV.Row[i].Cells[1].Value.ToString();
        txt_TenSV.Text = dataGV.Row[i].Cells[2].Value.ToString();
        cb_GT.Text = dataGV.Row[i].Cells[4].Value.ToString();
        txt_MaKhoa.Text = dataGV.Row[i].Cells[5].Value.ToString();
        dt_Ngaysinh.Text = dataGV.Row[i].Cells[3].Value.ToString();
    }

    private void btn_Them_Click(object sender, EventArgs e)
    {
        _command = _connection.CreateCommand();
        _command.CommandText = "Insert into ThongTinSinhVien values ('" + txt_MaSV.Text + "','" + txt_HoSV.Text + "' ,'"
            + txt_TenSV.Text + "','" + dt_Ngaysinh.Text + "','" + cb_GT.Text + "','" + txt_MaKhoa.Text + "')";
        _command.ExecuteNonQuery();
        loaddata();
    }

    private void btn_Xoa_Click(object sender, EventArgs e)
    {
        _command = _connection.CreateCommand();
        _command.CommandText = "delete from ThongTinSinhVien where MaSV = '" + txt_MaSV.Text + "'";
        _command.ExecuteNonQuery();
        loaddata();
    }

    private void btn_Sua_Click(object sender, EventArgs e)
    {
        _command = _connection.CreateCommand();
        _command.CommandText = "update ThongTinSinhVien set HoSV = N '" + txt_HoSV.Text + "' , TenSV = N '" + txt_TenSV.Text
            + "',  Ngaysinh = '" + dt_Ngaysinh.Text + "',  Gioitinh = N '" + cb_GT.Text + "', MaKhoa = N '" + txt_MaKhoa.Text + " where MaSV = '" + txt_MaSV + "'";
        _command.ExecuteNonQuery();
        loaddata();
    }

    private void btn_Huy_Click(object sender, EventArgs e)
    {
        txt_MaSV.Text = "";
        txt_HoSV.Text = "";
        txt_TenSV.Text = "";
        dt_Ngaysinh.Text = "1/1/2000";
        cb_GT.Text = "";
        txt_MaKhoa.Text = "";
    }
}