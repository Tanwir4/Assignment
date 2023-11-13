using Assignment_v1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_v1.DAL
{
    public interface ITrainingDAL
    {
        bool Add(Training training);
        bool Update(Training training);
        bool Delete(Training training);
        Training Get(int trainingId);
        IEnumerable<Training> GetAll();
    }
}
