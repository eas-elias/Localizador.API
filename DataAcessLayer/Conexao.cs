namespace DataAccess
{
    using System;
    using System.Data.SqlClient;

    public class Conexao : IDisposable
    {
        private string _ConnectionString;
        private SqlConnection _oConnection;

        /// <summary>
        /// Construtor  da classe
        /// </summary>
        /// <param name="ConnectionString"></param>
        public Conexao(string ConnectionString)
        {
            this._ConnectionString = ConnectionString;
        }

        /// <summary>
        /// Get e Set da ConnectionString
        /// </summary>
        public string ConnectionString
        {
            get { return _ConnectionString; }
            set { _ConnectionString = value; }
        }

        /// <summary>
        /// Get e Set da oConnection
        /// </summary>
        public SqlConnection oConnection
        {
            get { return _oConnection; }
            set { _oConnection = value; }
        }


        #region IDisposable

        // Flag: Has Dispose already been called?
        bool disposed = false;

        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                // Free any other managed objects here.
                //
            }

            disposed = true;
        }

        #endregion
    }
}
