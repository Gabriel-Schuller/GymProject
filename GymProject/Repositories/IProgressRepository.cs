using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymProject.Models
{
    public interface IProgressRepository
    {
        IEnumerable<Progress> GetUserProgress(int userID);
        Progress GetProgressByDay(DateTime day);
    }
}
