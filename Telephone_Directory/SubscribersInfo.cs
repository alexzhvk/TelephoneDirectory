//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Telephone_Directory
{
    using System;
    using System.Collections.Generic;
    
    public partial class SubscribersInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SubscribersInfo()
        {
            this.ConnectionsInfo = new HashSet<ConnectionsInfo>();
        }
    
        public int Id { get; set; }
        public string PassportData { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConnectionsInfo> ConnectionsInfo { get; set; }
    }
}
