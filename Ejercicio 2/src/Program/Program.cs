using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ya no funciona por los cambios, pero se reutilizan los datos
            string appointmentResult = AppointmentService.CreateAppointment( "5555-555-555", DateTime.Now, "Wall Street", "Armand");
            Console.WriteLine(appointmentResult);

            string appointmentResult2 = AppointmentService.CreateAppointment("Ralf Manson", "", "5555-555-555", DateTime.Now, "Queen Street", "");
            Console.WriteLine(appointmentResult2);
            */
            Patient paciente1 = new Patient("Steven Jhonson", "986782342");
            Doctor doctor1 = new Doctor("Armand");
            string appointmentResult= AppointmentService.CreateAppointment(DateTime.Now, "Wall Street", paciente1, doctor1);

            Patient paciente2 = new Patient("Ralf Manson", "");
            Doctor doctor2 = new Doctor("");
            string appointmentResult2 = AppointmentService.CreateAppointment(DateTime.Now, "Queen Street", paciente2, doctor2);

            Console.WriteLine(appointmentResult);
            Console.WriteLine(appointmentResult2);
        }
    }
}
