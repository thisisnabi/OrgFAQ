namespace OrgFAQ.API.Infrastructure.Repositories
{
    public class QuestionRepository : Repository<Question> , IQuestionRepository
    {
        public QuestionRepository(OrgFAQContext orgFAQContext) : base(orgFAQContext)
        {

        }
    }
}
