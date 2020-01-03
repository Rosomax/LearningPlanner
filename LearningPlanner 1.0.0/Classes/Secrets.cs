using System.Linq;
namespace LearningPlanner
{
    class Secrets
    {
        LearningPlannerDataBaseEntities entities = new LearningPlannerDataBaseEntities();

        public string GetEmailSecret()
        {
          
                return (from Secret in entities.Secret
                        where Secret.Id.Equals(1)
                        select Secret.Name).SingleOrDefault().ToString();

            
        }
        public  string GetApiKey()
        {
           
                return (from Secret in entities.Secret
                        where Secret.Id.Equals(2)
                        select Secret.Name).SingleOrDefault().Trim().ToString();



        }

        public  string GetApiSecretKey()
        {
           
                return (from Secret in entities.Secret
                        where Secret.Id.Equals(3)
                        select Secret.Name).SingleOrDefault().Trim().ToString();


        }

        public  string GetAccessToken()
        {
            
                return (from Secret in entities.Secret
                        where Secret.Id.Equals(4)
                        select Secret.Name).SingleOrDefault().Trim().ToString();


        }

        public  string GetSecretAccessToken()
        {
           
                return (from Secret in entities.Secret
                        where Secret.Id.Equals(5)
                        select Secret.Name).SingleOrDefault().Trim().ToString();

        }

    }
}
