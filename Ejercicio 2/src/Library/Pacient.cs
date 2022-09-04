
namespace Library
{
    public class Pacient{
        public string Name{get; set;}
        public string PhoneNumber{get; set;}

        public Pacient(string name, string phoneNumber){

            this.Name=name;
            this.PhoneNumber=phoneNumber;
        }

        public bool Validate(){
            return !string.IsNullOrEmpty(this.Name) && !string.IsNullOrEmpty(this.PhoneNumber);
        }

    }
}