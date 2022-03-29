namespace EagerLoadingApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserPassword
    {
        public int Id { get; set; }

        [Required]
        public string Password1 { get; set; }

        [Required]
        public string Password2 { get; set; }

        [Required]
        public string Password3 { get; set; }
    }
}
