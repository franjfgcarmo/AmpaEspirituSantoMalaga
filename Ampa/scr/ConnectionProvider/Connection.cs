using System;
using System.Data;
using System.Data.OleDb;

namespace Ampa.ConnectionProvider
{
    public class Connection
    {
        #region" Región de declaración de variables."

        /// <summary>
        ///     Representa un conjunto de comandos de datos y una conexión de base de
        ///     datos que se utilizan para rellenar un DataSet
        /// </summary>
        private OleDbDataAdapter _miDataAdapter;

        #endregion;

        #region [Properties and Constructor]

        /// <summary>
        ///     Método constructor de la clase conexión
        /// </summary> 
        public Connection()
        {
            var sConectionString =
                @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\AppData\Ampa.mdb;Encrypt Password=False;Mask Password=False";
            DbConnection = new OleDbConnection {ConnectionString = sConectionString};
            // this.oConnection.Open();
        }

        /// <summary>
        ///     Obtiene el objeto oConnection.
        /// </summary>
        public OleDbConnection DbConnection { get; private set; }

        /// <summary>
        ///     Indica el estado de la conexión de la base de datos.
        /// </summary>
        /// <returns>Devuelve un tipo ConnectionState que indica el estado de la conexión.</returns>
        internal ConnectionState Status()
        {
            return DbConnection.State;
        }

        /// <summary>
        ///     Abre la conexión a la base datos.
        /// </summary>
        public void DbOpen()
        {
            if (DbConnection.State == ConnectionState.Closed)
            {
                DbConnection.Open();
            }
        }

        /// <summary>
        ///     Cierra la conexión a la base datos.
        /// </summary>
        public void DbClose()
        {
            if (DbConnection.State == ConnectionState.Open)
            {
                DbConnection.Close();
            }
        }

        /// <summary>
        ///     Executa una instrucción DML (Insert, Delete, Update).
        /// </summary>
        /// <param name="sSql">Instrucción DML</param>
        /// <returns>Devuelve el número de registro afectados.</returns>
        public int Execute(string sSql)
        {
            var iCount = 0;
            var oCmd = DbConnection.CreateCommand();

            oCmd.CommandText = sSql;
            oCmd.CommandTimeout = 120;

            iCount = oCmd.ExecuteNonQuery();
            return iCount;
        }

        /// <summary>
        ///     Ejecuta una instrucción Select
        /// </summary>
        /// <param name="sQuery">Instrucción Select.</param>
        /// <returns>Devuelve un objeto DataSet.</returns>
        public DataSet InitDataAdapter(string sQuery)
        {
            var dsRes = new DataSet();
            try
            {
                _miDataAdapter = new OleDbDataAdapter(sQuery, DbConnection);

                _miDataAdapter.Fill(dsRes);
                _miDataAdapter = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return dsRes;
        }

        /// <summary>
        ///     Ejecuta una instrucción Select
        /// </summary>
        /// <param name="sQuery">Instrucción Select.</param>
        /// <returns>Devuelve un objeto DataSet.</returns>
        public OleDbDataReader DataReader(string sQuery)
        {
            var command = new OleDbCommand(sQuery, DbConnection);
            if (Status() == ConnectionState.Closed)
                DbOpen();
            var reader = command.ExecuteReader();

            return reader;
        }

        #endregion;
    }
}