namespace test
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Список_клиентов
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Column("название фирмы-клиента")]
        [Required]
        public string название_фирмы_клиента { get; set; }

        [Required]
        public string адрес { get; set; }

        [Column("ФИО контактного лица")]
        [Required]
        public string ФИО_контактного_лица { get; set; }

        [Required]
        [StringLength(50)]
        public string телефон { get; set; }

        [Column("e-mail")]
        [Required]
        [StringLength(50)]
        public string e_mail { get; set; }
    }
}
