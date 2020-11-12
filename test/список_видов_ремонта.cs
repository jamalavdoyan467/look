namespace test
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("список видов ремонта")]
    public partial class список_видов_ремонта
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public список_видов_ремонта()
        {
            Заказ = new HashSet<Заказ>();
        }

        [Key]
        [Column("вид ремонта")]
        [StringLength(50)]
        public string вид_ремонта { get; set; }

        [Column("стоимость работ (руб.)", TypeName = "money")]
        public decimal стоимость_работ__руб__ { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Заказ> Заказ { get; set; }
    }
}
