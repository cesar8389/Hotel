using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Aplication
{
    public abstract class Reserva
    {
        public String BookingID { get; set; }
        public String CustumerCPF { get; set; }
        public DateTime StartBookingDate { get; set; }
        public DateTime EndBookingDate { get; set; }
        public String TypeRoom { get; set; }
    }
}
