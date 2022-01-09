using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;



namespace p2pEnergyTrading { 
    class UserManager
    {
        private List<User> users = new();
        static private UserManager instance;

        public static UserManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new UserManager();
                return instance;
            }
        }
        const string fileLoc = "User_info.txt";
        private UserManager()
        {
            var ss=File.ReadAllLines(fileLoc);
            foreach(string line in ss)
            {
             users.Add(User.Parse(line));   
            }
        }

        public void addUser(User user)
        {
            users.Add(user);
        }
        public User GetUser(string uid)
        {
            var user = users.Single(u => u.Uid == uid);

            return user;

        }
        public void Save()
        {
            string s = "";
            foreach (User user in users)
            {
                s += user.ToString() + '\n';
            }
            File.WriteAllText(fileLoc, s);
        }
        ~UserManager()
        {
            Save();
        }

    }

    public class User
    {
        public string Name { get; set; }
        public string Uid { get; set; }
        public float Energy { get; set; }
        public float Money { get; set; }
        const char split = '~';

        public User(string uid,string name,string energy,string money)
        {
            Name = name;
            Uid = uid;
            Energy = float.Parse(energy);
            Money = float.Parse(money);
        }
        public static User Parse(string s)
        {
            var ss=s.Split(split);
            return new User(ss[0], ss[1], ss[2], ss[3]);
            
        }
        override public string ToString()
        {
                return Uid+split+Name+split+Energy.ToString()+split+Money.ToString();
        }
         
    }
}
