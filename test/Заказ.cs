namespace test
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Заказ
    {
        [Key]
        [Column("№ заказа")]
        public int C__заказа { get; set; }

        [Column("№ станка")]
        public int C__станка { get; set; }

        [Column("вид ремонта")]
        [Required]
        [StringLength(50)]
        public string вид_ремонта { get; set; }

        [Column("№ бригады")]
        public int C__бригады { get; set; }

        [Column("дата сдачи в ремонт", TypeName = "date")]
        public DateTime дата_сдачи_в_ремонт { get; set; }

        [Column("дата возврата из ремонта (по плану)", TypeName = "date")]
        public DateTime дата_возврата_из_ремонта__по_плану_ { get; set; }

        [Column("дата возврата из ремонта (фактическая)", TypeName = "date")]
        public DateTime дата_возврата_из_ремонта__фактическая_ { get; set; }

        public virtual Список_бригад Список_бригад { get; set; }

        public virtual список_видов_ремонта список_видов_ремонта { get; set; }

        public virtual Список_станков Список_станков { get; set; }
    }
}
