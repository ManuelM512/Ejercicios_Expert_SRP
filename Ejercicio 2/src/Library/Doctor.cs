
namespace Library
{
    public class Doctor{
        public string DoctorName{get; set;}

        public Doctor(string doctorName){
            this.DoctorName=doctorName;
        }

        public bool Validate(){
            return !string.IsNullOrEmpty(this.DoctorName);
        }

    }
}