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
    
    public partial class ConnectionsInfo
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public decimal Arrear { get; set; }
        public string Tariff { get; set; }
        public System.DateTime InstallationDate { get; set; }
    
        public virtual SubscribersInfo SubscribersInfo { get; set; }
        public virtual OperatorsInfo OperatorsInfo { get; set; }
        
    }
}
