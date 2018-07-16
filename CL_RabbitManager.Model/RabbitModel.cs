using System.Collections.Generic;

namespace CL_RabbitManager.Model
{
    public class RabbitModel
    {
        public string Hostname { get; set; }
        public string Virtualname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string Exchangename { get; set; }
        public string Queuename { get; set; }
        public string Routekey { get; set; }

        public Dictionary<string, object> HeaderEchangeOptions { get; set; } = new Dictionary<string, object>();
    }
}