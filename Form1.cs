namespace AccesoDatosWInForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var conn = new AccesoADatosMySQL(
                "localhost", "nwind", "root", "root", 3306);

            var prmts = new Dictionary<string, object>();
            prmts.Add("@categoryname", "Nueva categoria");
            prmts.Add("@description", "Nueva descripción");

            var result = conn.ejecutarSentencia(
                "insert into categories (categoryname, description) " +
                "values (@categoryname, @description)", prmts
                );

            MessageBox.Show($"Filas afectadas {result}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var ad = new AccesoADatosMySQL("localhost", "nwind", "root", "root", 3306))
            {
                var pars = new Dictionary<string, object>();
                pars.Add("@filtro", "C%");

                using (var res = ad.ejecutarQuery(
                    "SELECT * FROM categories WHERE categoryname LIKE @filtro", pars))
                {
                    if (res.HasRows)
                    {
                        while (res.Read())
                        {
                            cboCategory.Items.Add($"{res.GetInt32(0)} - {res.GetString(1)}");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay datos en la consulta.");
                    }
                }
            }

            cargarProductos();
        }

        private void cargarProductos()
        {
            //var ad = new AccesoADatosMySQL("localhost", "nwind",
              //  "root", "root", 3306);
            //var dt = ad.queryTable(
              //  "select * from products", null);

            using (var ad = new AccesoADatosMySQL(
                "localhost", "nwind", "root", "root", 3306))
            {
                var dt = ad.queryTable(
                    "select * from products", null);
                dgvControl.DataSource = dt;
            }
        }

        private async void btnSaveAsync_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Insertando...");
            
            var conn = new AccesoADatosMySQL(
                "localhost", "nwind", "root", "root", 3306);

            var prmts = new Dictionary<string, object>();
            prmts.Add("@categoryname", "Nueva categoria asincorna");
            prmts.Add("@description", "Nueva descripción asincrona");

            var result = await conn.ejecutarSentenciaAsync(
                "insert into categories (categoryname, description) " +
                "values (@categoryname, @description)", prmts);

            MessageBox.Show($"Filas afectadas {result}");
        }
    }
}
