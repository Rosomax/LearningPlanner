using System.Linq;
namespace LearningPlanner
{
    class Secrets
    {
        public static string GetEmailSecret()
        {
            using (EntitiesModel entities = new EntitiesModel())
            {
                return (from Secret in entities.Secret
                        where Secret.Id.Equals(1)
                        select Secret.Name).SingleOrDefault().ToString();

            }
        }

      
    }
}
