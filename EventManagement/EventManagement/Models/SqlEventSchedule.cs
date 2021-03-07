using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventManagement.Models
{
    public class SqlEventSchedule : IEventSchedule
    {
        public SqlEventSchedule(AppDbContext context)
        {
            this.context = context;
        }
    }
}
