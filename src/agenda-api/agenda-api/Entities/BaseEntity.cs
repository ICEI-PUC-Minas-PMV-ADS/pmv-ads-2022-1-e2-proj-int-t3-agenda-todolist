using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace agenda_api.Entities
{
    public class BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Id { get; set; }
    }
}
