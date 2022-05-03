using System;
using agenda_api.Entities;

namespace agenda_api
{
    public class Task : BaseEntity
    {


        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime TodoDate { get; set; }

    }
}
