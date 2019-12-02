using HomeWork2019._12._03.AbstractModels;

namespace HomeWork2019._12._03.Models
{
    public class Task : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Tag { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }
    }
}
