using SSFleetCommandModels.Enums;

namespace SSFleetCommandModels.Models
{
    public class ResourceType
    {
        public ElementGrade Grade { get; set; }
        public ElementType Type { get; set; }

        public override string ToString()
        {
            var gradeString = Grade != ElementGrade.None ? "Grade " + Grade.ToString() + " " : "";
            return $"{gradeString}{Type.ToString()}";
        }
    }
}