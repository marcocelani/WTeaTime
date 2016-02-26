namespace WTeaTime.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TeaEntity")]
    public partial class TeaEntityRow
    {
        [Key]
        [StringLength(256)]
        public string Title { get; set; }

        public int Min { get; set; }

        public int Sec { get; set; }

        [StringLength(512)]
        public string Message { get; set; }

        [StringLength(512)]
        public string Action { get; set; }

        public bool Beep { get; set; }

        public bool ShowMex { get; set; }

        public bool RunAction { get; set; }
    }
}
