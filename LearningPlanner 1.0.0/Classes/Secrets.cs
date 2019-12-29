using System.Linq;
namespace LearningPlanner
{
    class Secrets
    {
        public static string GetEmailSecret()
        {
            using (LearningPlannerDataBaseEntities entities = new LearningPlannerDataBaseEntities())
            {
                return (from Secret  in entities.Secret
                        where Secret.Id.Equals(1)
                        select Secret.Name).SingleOrDefault().ToString();

            }
        }

      
    }
}
