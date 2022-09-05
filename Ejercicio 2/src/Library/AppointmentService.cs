using System;
using System.Text;
using System.Collections;

namespace Library
{
    public class AppointmentService
    {
        //Esta clase utilizá demasiados datos que pueden cambiar, o podrían ser agregados, lo cual no es compatible con SRP
        //Para corregir esto se crean nuevas clases
        //El id puede no ser único porque se pasa como parámetro, sería mejor que lo instancie la misma clase
        //Las validaciones deberían ser realizadas en la clase de instancia
        static Boolean isValid{get; set;}
        static int id=0;
        public static string CreateAppointment(DateTime date, string appointmentPlace, Patient pacient, Doctor doctor)
        {
            id+=1;

            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            isValid=(doctor.Validate() && pacient.Validate() && !string.IsNullOrEmpty(appointmentPlace));

            if (isValid)
            {
                stringBuilder.Append("Appoinment scheduled");
            }
            else{
                stringBuilder.Append("Couldn't schedule the appointment, you must fill all the necessary information.");
            }

            return stringBuilder.ToString();
        }


    }
}
