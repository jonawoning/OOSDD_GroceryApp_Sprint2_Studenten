
namespace Grocery.Core.Models
{
    public partial class Client : Model
    {
        public int NewId { get; set; }
        // public string NewName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        
        public Client(int id, string name, string emailAddress, string password) : base(id, name)
        {
            // NewId = id;
            // NewName = name;
            EmailAddress = emailAddress;
            Password = password;
        }
    }
}
