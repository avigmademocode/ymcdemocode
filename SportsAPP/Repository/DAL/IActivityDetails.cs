using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsAPP.Models;

namespace SportsAPP.Repository.DAL
{
    interface IActivityDetails
    {
        List<dynamic> AddActivity(ActivityDetailsUI activityDetailsUI);
            
            
    }
}
