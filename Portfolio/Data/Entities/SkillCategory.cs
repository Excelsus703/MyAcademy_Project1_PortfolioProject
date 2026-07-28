namespace Portfolio.Data.Entities
{
    public class SkillCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public ICollection<Skill> Skills { get; set; }
    }
}
