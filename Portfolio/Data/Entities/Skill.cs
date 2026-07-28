namespace Portfolio.Data.Entities
{
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public int MasteryRate { get; set; }


        public int SkillCategoryId { get; set; }
        public SkillCategory SkillCategory { get; set; }
    }
}
