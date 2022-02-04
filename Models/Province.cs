using System.ComponentModel.DataAnnotations;

namespace code1st_delete_me.Models;

    public class Province
    {
        [Key]
        public string? ProvinceCode { get; set; }
        public string? ProvinceName { get; set; }

        public List<City>? Cities { get; set; }

    }
