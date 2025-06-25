using MySql.Data.MySqlClient;
using System.Data;

namespace AccesoDatosWInForms
{
    public class AccesoADatosMySQL : IDisposable
    {
        MySqlConnection _connection;
        MySqlCommand _command;
        MySqlDataReader _reader;
        MySqlDataAdapter _adapter;
        private bool disposedValue;

        public AccesoADatosMySQL(string host, string db, string user, string password, int port)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = host;
            builder.Database = db;
            builder.UserID = user;
            builder.Password = password;
            builder.Port = (uint)port;

            string connectionString = builder.ConnectionString;
            _connection = new MySqlConnection(connectionString);
            _connection.Open();
        }

        public void inicializarCommand(string query, Dictionary<string, object> prmts)
        {
            _command = new MySqlCommand(query, _connection);
            if (prmts != null && prmts.Count > 0)
            {
                foreach (var prm in prmts)
                {
                    _command.Parameters.AddWithValue(prm.Key, prm.Value);
                }
            }
        }

        public int ejecutarSentencia(string sentencia, Dictionary<String, object> prmts)
        {
            if (_connection == null)
            {
                throw new InvalidOperationException("La conexión no está inicializada.");
            }
            _command = new MySqlCommand(sentencia, _connection);

            inicializarCommand(sentencia, prmts);

            return _command.ExecuteNonQuery();
        }
        public async Task<int> ejecutarSentenciaAsync(string sentencia, 
            Dictionary<String, object> prmts)
        {
            if (_connection == null)
            {
                throw new InvalidOperationException("La conexión no está inicializada.");
            }
            _command = new MySqlCommand(sentencia, _connection);

            inicializarCommand(sentencia, prmts);

            return await _command.ExecuteNonQueryAsync();
        }

        public MySqlDataReader ejecutarQuery(string consulta, Dictionary<string, object> prmts)
        {
            if (_connection == null)
                throw new InvalidOperationException("La conexión no está inicializada.");

            if (string.IsNullOrWhiteSpace(consulta))
                throw new ArgumentException("La consulta está vacía o es nula.", nameof(consulta));

            _command = new MySqlCommand(consulta, _connection);

            if (prmts != null && prmts.Count > 0)
            {
                foreach (var prm in prmts)
                {
                    _command.Parameters.AddWithValue(prm.Key, prm.Value ?? DBNull.Value);
                }
            }

            try
            {
                return _command.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar la consulta: " + ex.Message, ex);
            }
        }

        public DataTable queryTable(String query, Dictionary<string, object> prmtrs)
        {
            _command = new MySqlCommand(query, _connection);
            _adapter = new MySqlDataAdapter(_command);
            var dataTable = new DataTable();
            _adapter.Fill(dataTable);
            return dataTable;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: eliminar el estado administrado (objetos administrados)
                    if (_reader != null)
                    {
                        _reader.Close();
                        _reader.Dispose();
                        _reader = null;
                    }
                    if (_command != null)
                    {
                        _command.Dispose();
                        _command = null;
                    }
                    if (_adapter != null)
                    {
                        _adapter.Dispose();
                        _adapter = null;
                    }
                    if (_connection != null)
                    {
                        _connection.Close();
                        _connection.Dispose();
                        _connection = null;
                    }
                }

                // TODO: liberar los recursos no administrados (objetos no administrados) y reemplazar el finalizador
                // TODO: establecer los campos grandes como NULL
                disposedValue = true;
            }
        }

        // // TODO: reemplazar el finalizador solo si "Dispose(bool disposing)" tiene código para liberar los recursos no administrados
        // ~AccesoADatosMySQL()
        // {
        //     // No cambie este código. Coloque el código de limpieza en el método "Dispose(bool disposing)".
        //     Dispose(disposing: false);
        // }

        void IDisposable.Dispose()
        {
            // No cambie este código. Coloque el código de limpieza en el método "Dispose(bool disposing)".
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
