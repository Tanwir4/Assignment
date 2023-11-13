using Assignment_v1.DAL;
using Assignment_v1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_v1.Services
{
    public class TrainingService : ITrainingService
    {
        private readonly ITrainingDAL _trainingDal;

        public TrainingService(ITrainingDAL trainingDAL) 
        { 
            _trainingDal = trainingDAL;
        }

        public bool Add(Training training)
        {
            return _trainingDal.Add(training);
        }

        public bool Delete(Training training)
        {
            throw new NotImplementedException();
        }

        public Training Get(int trainingId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Training> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Training training)
        {
            throw new NotImplementedException();
        }
    }
}
