using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity_framework_v2
{
    public class Reservation
    {
        public int reservationId {  get; set; }
        public DateTime ReservationDate {  get; set; }
        public string ReservationStatus {  get; set; }
        
              
        public int clientId {  get; set; }
        public Client Client {  get; set; }
           
        public int tripID {  get; set; }
        public Trip trip { get; set; }

    }
}
