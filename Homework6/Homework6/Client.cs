using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    public class Client
    {
        public string ClientName { get; set; }
        public Client() { }
        public Client(string clientName = null)
        {
            this.ClientName = clientName;
        }
        public override string ToString()
        {
            return $"client name:{ClientName}";
        }

        public override bool Equals(object obj)
        {
            return obj is Client client &&
                   ClientName == client.ClientName;
        }

        public override int GetHashCode()
        {
            return -1215057659 + EqualityComparer<string>.Default.GetHashCode(ClientName);
        }
    }
}
