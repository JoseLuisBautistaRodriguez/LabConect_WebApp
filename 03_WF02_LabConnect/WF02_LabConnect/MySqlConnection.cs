
namespace WF02_LabConnect
{
    internal class MySqlConnection
    {
        public MySqlConnection(string cadenaConexion)
        {
            CadenaConexion = cadenaConexion;
        }

        public string CadenaConexion { get; }

        internal void Open()
        {
            throw new NotImplementedException();
        }
    }
}