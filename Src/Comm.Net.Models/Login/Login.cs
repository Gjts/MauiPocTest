using System.ComponentModel;

namespace Comm.Net.Models.Login
{
    public class Login : IBaseInput
    {
        [DisplayName("instance")]
        public string? Instance { get; set; }

        public string? UserName { get; set; }
        public string? PassWord { get; set; }

        public int IO { get; set; }
        public int lineID { get; set; }
        public int userID { get; set; }
        public int siID { get; set; }

        public int packHeaderID { get; set; }
        public int packingID { get; set; }
        public string? labelType { get; set; }
        public string? mpn { get; set; }
        public string? lotNumber { get; set; }
        public string? mpnString { get; set; }
        public string? qtyString { get; set; }
        public string? cpnString { get; set; }

    }
}