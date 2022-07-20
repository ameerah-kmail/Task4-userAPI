using Task4_userAPI.Models;
namespace Task4_userAPI.Repo
{
    public class userRepo
    {
        static List<user> users { get; set; }

        static userRepo() {
            users = new List<user>()
            {
                new user(){ Id = 1 ,fname="ameerah",lname="kmail"},
                new user(){Id = 2 ,fname="aseel",lname="kmail"}
            };

        }

        public static List<user> getAll()
        {
            return users;
        }//end of getAll
        public static user get(int id)
        {
            return users.FirstOrDefault(user=>user.Id==id);
        }//end of get by id
        public static void delete(int id)
        {
            var _user = get(id);
                if(_user == null )
                users.Remove( _user );
        }//end of delete
        public static void update(user _user)
        {
            var index=users.FindIndex(user=>user.Id==_user.Id);
            if (index !=-1)
                users[index] = _user;     
        }//end of update
        public static void add(user _user)
        {
            users.Add( _user );

        }//end of add

    }//end of class userRepo
}//end of namespace Task4_userAPI.Repo
