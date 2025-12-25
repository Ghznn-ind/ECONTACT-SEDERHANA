using System.Data;
using System.Data.SqlClient;

namespace Econtact
{
    public partial class Econtact : Form
    {
        Koneksi conn = new Koneksi();
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader dr;

        public Econtact()
        {
            InitializeComponent();
        }
        void munculJenis()
        {
            cbGender.Items.Add("MALE");
            cbGender.Items.Add("FEMALE");
        }

        void kondisiAwal()
        {
            txtId.Text = "";
            txtFname.Text = "";
            txtLname.Text = "";
            txtNo.Text = "";
            txtAddres.Text = "";
            txtSearch.Text = "";
            cbGender.Text = "";
        }

        void munculDataKontak()
        {
            SqlConnection Conn = conn.GetConn();
            Conn.Open();
            cmd = new SqlCommand("SELECT * FROM tbl_contact", Conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "tbl_contact");
            dgvContact.DataSource = ds;
            dgvContact.DataMember = "tbl_contact";
            dgvContact.AllowUserToAddRows = false;
            dgvContact.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvContact.Refresh();

        }

        void cariKontak()
        {
            SqlConnection Conn = conn.GetConn();
            try
            {
                Conn.Open();
                cmd = new SqlCommand("SELECT * FROM tbl_contact WHERE ContactID like '%" + txtSearch.Text + "%' or FirstName like '%" + txtSearch.Text + "%' ", Conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "tbl_contact");
                dgvContact.DataSource = ds;
                dgvContact.DataMember = "tbKontak";
                dgvContact.AllowUserToAddRows = false;
                dgvContact.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvContact.Refresh();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                Conn.Close();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Econtact_Load(object sender, EventArgs e)
        {
            kondisiAwal();
            munculJenis();
            munculDataKontak();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim() == "" || txtFname.Text.Trim() == "" ||
                txtLname.Text.Trim() == "" || txtNo.Text.Trim() == "" || txtAddres.Text.Trim() == "" ||
                cbGender.Text.Trim() == "")
            {
                MessageBox.Show("Pastikan Semua Data Sudah Terisi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection Conn = null;
                try
                {
                    Conn = conn.GetConn();
                    // 1. Definisikan query dengan placeholder parameter
                    string query = "INSERT INTO  tbl_contact (FirstName, LastName, ContactNo, Addres, Gender)" + "VALUES (@Fname, @Lname, @No, @addres, @Gender)";
                    SqlCommand cmd = new SqlCommand(query, Conn);
                    // 2. Tambahkan parameter ke objek SqlCommand
                    //cmd.Parameters.AddWithValue("@Id", txtId.Text.Trim());
                    cmd.Parameters.AddWithValue("@Fname", txtFname.Text.Trim());
                    cmd.Parameters.AddWithValue("@Lname", txtLname.Text.Trim());
                    cmd.Parameters.AddWithValue("@No", txtNo.Text.Trim());
                    cmd.Parameters.AddWithValue("@Addres", txtAddres.Text.Trim());
                    cmd.Parameters.AddWithValue("@Gender", cbGender.Text.Trim());
                    Conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Di Simpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    munculDataKontak();
                    kondisiAwal();
                }
                catch (SqlException sqlex)
                {
                    MessageBox.Show("Error Database:" + sqlex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi Kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                finally 
                {
                    if (Conn != null && Conn.State == ConnectionState.Open)
                    {
                        Conn.Close();
                    } 
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            kondisiAwal();
        }

        private void dgvContact_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgvContact.Rows[e.RowIndex];
                txtId.Text = row.Cells["ContactID"].Value.ToString();
                txtFname.Text = row.Cells["FirstName"].Value.ToString();
                txtLname.Text = row.Cells["LastName"].Value.ToString();
                txtNo.Text = row.Cells["ContactNo"].Value.ToString();
                txtAddres.Text = row.Cells["Addres"].Value.ToString();
                cbGender.Text = row.Cells["Gender"].Value.ToString();
                btnAdd.Enabled = false;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim() == "" || txtFname.Text.Trim() == "" ||
                txtLname.Text.Trim() == "" || txtNo.Text.Trim() == "" || txtAddres.Text.Trim() == "" ||
                cbGender.Text.Trim() == "")
            {
                MessageBox.Show("Pastikan Semua Data Sudah Terisi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection Conn = null;
                try
                {
                    Conn = conn.GetConn();
                    // 1. Definisikan query dengan placeholder parameter
                    string query = "UPDATE tbl_contact SET (FirstName, LastName, ContactNo, Addres, Gender)" + "VALUES (@Fname, @Lname, @No, @addres, @Gender)";
                    SqlCommand cmd = new SqlCommand(query, Conn);
                    // 2. Tambahkan parameter ke objek SqlCommand
                    //cmd.Parameters.AddWithValue("@Id", txtId.Text.Trim());
                    cmd.Parameters.AddWithValue("@Fname", txtFname.Text.Trim());
                    cmd.Parameters.AddWithValue("@Lname", txtLname.Text.Trim());
                    cmd.Parameters.AddWithValue("@No", txtNo.Text.Trim());
                    cmd.Parameters.AddWithValue("@Addres", txtAddres.Text.Trim());
                    cmd.Parameters.AddWithValue("@Gender", cbGender.Text.Trim());
                    Conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Di Update", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    munculDataKontak();
                    kondisiAwal();
                }
                catch (SqlException sqlex)
                {
                    MessageBox.Show("Error Database:" + sqlex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi Kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (Conn != null && Conn.State == ConnectionState.Open)
                    {
                        Conn.Close();
                    }
                    btnAdd.Enabled = true;
                }
            }
            //else
            //{
            //    SqlConnection Conn = conn.GetConn();
            //    cmd = new SqlCommand("UPDATE tbl_contact SET FirstName = '" + txtFname.Text + "', LastName = " +
            //        "'" + txtLname.Text + "', ContactNo = '" + txtNo.Text + "', Addres = '" + txtAddres.Text + "'," +
            //        "Gender = '" + cbGender.Text + "' WHERE ContactID = '" + txtId.Text + "'", Conn);
            //    Conn.Open();
            //    cmd.ExecuteNonQuery();
            //    MessageBox.Show("Data Berhasil Di Update", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    kondisiAwal();
            //    munculDataKontak();
            //    
            //}
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim() == "" || txtFname.Text.Trim() == "" ||
                txtLname.Text.Trim() == "" || txtNo.Text.Trim() == "" || txtAddres.Text.Trim() == "" ||
                cbGender.Text.Trim() == "")
            {
                MessageBox.Show("Pastikan Semua Data Sudah Terisi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection Conn = conn.GetConn();
                cmd = new SqlCommand("DELETE tbl_contact WHERE ContactID = '" + txtId.Text + "'", Conn);
                Conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Di Hapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                kondisiAwal();
                munculDataKontak();
                btnAdd.Enabled = true;
            }

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SqlConnection Conn = conn.GetConn();
                cmd = new SqlCommand("SELECT * FROM tbl_contact WHERE ContactID = '" + txtSearch.Text + "'", Conn);
                Conn.Open();
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtId.Text = dr[0].ToString();
                    txtFname.Text = dr[1].ToString();
                    txtLname.Text = dr[2].ToString();
                    txtNo.Text = dr[3].ToString();
                    txtAddres.Text = dr[4].ToString();
                    cbGender.Text = dr[5].ToString();
                }
                else
                {
                    MessageBox.Show("Data Tidak Ada", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSearch.Text = "";
                }
                btnAdd.Enabled = false;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            cariKontak();
        }
    }
}
