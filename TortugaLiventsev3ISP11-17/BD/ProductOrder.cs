//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TortugaLiventsev3ISP11_17.BD
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductOrder
    {
        public int ID { get; set; }
        public Nullable<int> IDProduct { get; set; }
        public Nullable<int> IDOrder { get; set; }
        public Nullable<int> CountProduct { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
