using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataParsing
{
    [Table("data")]
    internal class DataModel : BaseModel
    {
        [PrimaryKey("id", false)]
        public int Id { get; set; }

        [Column("random_date")]
        public DateTime RandomDate { get; set; }

        [Column("vegetable")]
        public string Vegetable { get; set; }

        [Column("image_url")]
        public string ImageUrl { get; set; }

        [Column("boolean_random")]
        public bool BooleanRandom { get; set; }

        [Column("random_number")]
        public int RandomNumber { get; set; }
    }
}
