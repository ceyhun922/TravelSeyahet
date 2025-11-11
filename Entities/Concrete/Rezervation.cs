using System.ComponentModel.DataAnnotations;
using Entities.Concrete;

namespace EntityLayer.Concrete
{
    public class Rezervation
    {
        public int RezervationID { get; set; }
        public int RezervationCountPerson { get; set; }
        public string? RezervationDescription { get; set; }
        public string? RezervationDestination { get; set; }

        public enum RezervationStatus
        {
            Pending = 0,
            Approved = 1,
            Cancelled =2,
        }
        public RezervationStatus rezervationStatus { get; set; }

        [DataType(DataType.Date)]
        public DateTime RezervationDate { get; set; } = DateTime.Now.Date;
        [DataType(DataType.Time)]
        public TimeOnly RezervationTime { get; set; }
        public double TotalPrice { get; set; }
        public int RemainderCapaCity { get; set; }
        public string? UserId { get; set; }
        public Writer? Writer { get; set; }
        public int DestinationId { get; set; }

        public Tour? Tour { get; set; }


    }
}