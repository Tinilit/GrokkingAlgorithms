using System.ComponentModel.DataAnnotations;

namespace GrokkingAlgorithms.DataAccess.Entities
{
    public class AlgorithmResult
    {
        [Key]
        public int Id { get; set; }

        public double ExecutionTime { get; set; }
        public string Complexity { get; set; } = "N/A";
        public string SearchedValue { get; set; }
    }
}
