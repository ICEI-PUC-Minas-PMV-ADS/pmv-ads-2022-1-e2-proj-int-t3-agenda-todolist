using System;
using System.Collections.Generic;

namespace agenda_api.Entities
{
    public class TaskUsersResponse
    {
            public int User_id { get; set; }

            public List<TaskReponse> Tasks { get; set; }
    }
}
