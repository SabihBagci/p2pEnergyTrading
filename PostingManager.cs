using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2pEnergyTrading
{
    internal class PostingManager
    {
        private List<Post> posts = new();
        const string fileLoc = "Posts.txt";

        private static PostingManager instance;

        public static PostingManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new PostingManager();
                return instance;
            }
        }
        private PostingManager() {

            var strings = File.ReadAllLines(fileLoc);
            foreach (var s in strings)
            {
                AddPosting(Post.Parse(s));
            }
        }


        public void AddPosting(Post post)
        {
            posts.Add(post);
            Save();
        }

        //TODO: change to user.uid
        public void Buy(Post post, string uid)
        {
            var buyerUser = UserManager.Instance.GetUser(uid);
            var seller=UserManager.Instance.GetUser(post.Uid);
            posts.Remove(post);
            UserManager.Instance.GetUser(uid).Energy += post.Power;
            UserManager.Instance.GetUser(uid).Money -= post.Cost;
            UserManager.Instance.GetUser(post.Uid).Money+= post.Cost;
            UserManager.Instance.GetUser(post.Uid).Energy-= post.Power;

            Save();
            //DONE: usermanager removes money from user and adds energy

        }
        public void Save()
        {
            string text = "";
            foreach (var post in posts)
            {
                text += post.ToString() + '\n';
            }

            File.WriteAllText(fileLoc, text);
        }
         public Post[] Posts(){
            return posts.ToArray();
            }
        ~PostingManager()
        {
            posts.Clear();
           Save();
        }
    }
}

public class Post 
{
    public string Uid { get; set; }
    public float Power { get; set; }
    public float Cost { get; set; } 
    static readonly char split = '~';

    public Post (string uid, string power,string cost) 
    {
        this.Uid = uid;
        this.Power = Int32.Parse(power);
        this.Cost = Int32.Parse(cost);
    }

    public static Post Parse(String s)
    {
        var ss = s.Split(split);
        return new Post(ss[0],ss[1],ss[2]);
        
        
    }
    override public string ToString()
    {
        return Uid + split + Power.ToString() + split + Cost.ToString();
    }

    
    
}