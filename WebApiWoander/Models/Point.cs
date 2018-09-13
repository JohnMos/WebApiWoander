using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiWoander.Models
{
    public class Point
    {
        public int Id { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Longtitude { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Latitude { get; set; }
        public long Description { get; set; }
        public int Sequence_no { get; set; }
        public string Title { get; set; }
        public string Picture { get; set; }
        public string Arrival_time_to_point { get; set; }
        public string Duration_at_point { get; set; }
        public string Time_to_next_point { get; set; }
    }
}
