using System;

namespace SimpleCalculator.ThirdLab
{
    public class Connection
    {
        IConnection _connectionField;

        public IConnection ConnectionProperty { get; set; }

        public Connection()
        {

        }

        public Connection(IConnection connection)
        {
            _connectionField = connection ?? throw new ArgumentNullException();
        }

        public string GetConnection()
        {
            return _connectionField.GetConnection(); 
        }

        public string GetConnectionByProperty()
        {
            return ConnectionProperty.GetConnection();
        }
    }
}
