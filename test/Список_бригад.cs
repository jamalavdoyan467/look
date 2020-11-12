namespace test
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Список бригад")]
    public partial class Список_бригад
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Список_бригад()
        {
            Заказ = new HashSet<Заказ>();
        }

        [Key]
        [Column("№ бригады")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int C__бригады { get; set; }

        [Column("ФИО начальника бригады")]
        [Required]
        public string ФИО_начальника_бригады { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Заказ> Заказ { get; set; }
    }
}
