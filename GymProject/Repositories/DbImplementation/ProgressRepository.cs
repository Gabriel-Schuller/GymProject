using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymProject.Models
{
    public class ProgressRepository : IProgressRepository
    {
        private readonly AppDbContext _appDbContext;

        public ProgressRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Progress GetProgressByDay(DateTime day)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Progress> GetUserProgress(int userID)
        {
            throw new NotImplementedException();
        }
    }
}
