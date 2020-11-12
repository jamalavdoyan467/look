namespace test
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Список станков")]
    public partial class Список_станков
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Список_станков()
        {
            Заказ = new HashSet<Заказ>();
        }

        [Key]
        [Column("№ станка")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int C__станка { get; set; }

        [Column("№ фирмы-владельца")]
        public int C__фирмы_владельца { get; set; }

        [Column("вид станка")]
        [Required]
        [StringLength(50)]
        public string вид_станка { get; set; }

        [Column("марка станка")]
        [Required]
        [StringLength(50)]
        public string марка_станка { get; set; }

        [Required]
        [StringLength(50)]
        public string производитель { get; set; }

        [Column("год выпуска", TypeName = "date")]
        public DateTime год_выпуска { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Заказ> Заказ { get; set; }
    }
}
