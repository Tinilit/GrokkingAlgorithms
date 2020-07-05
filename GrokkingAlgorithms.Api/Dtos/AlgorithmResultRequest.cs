using GrokkingAlgorithms.DataAccess.Entities;
using System.ComponentModel.DataAnnotations;

namespace GrokkingAlgorithms.Api.Dtos
{
    public class AlgorithmResultRequest
    {
        public double ExecutionTime { get; set; }
        public string SearchedValue { get; set; }

        public AlgorithmResult ToEntity() 
        {
            return new AlgorithmResult
            {
                ExecutionTime = ExecutionTime,
                SearchedValue = SearchedValue
            };
        }
    }
}
