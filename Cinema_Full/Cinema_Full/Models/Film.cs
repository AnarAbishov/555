//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cinema_Full.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Film
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int MovieLength { get; set; }
        public System.DateTime ReleaseYear { get; set; }
        public string Language { get; set; }
        public string Rejissor { get; set; }
        public string Janrs { get; set; }
        public int HallsId { get; set; }
    
        public virtual Hall Hall { get; set; }
    }
}