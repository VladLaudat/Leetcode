public class Twitter
{
    int timestamp = 0;
    IList<Tuple<int, List<Tuple<int, int>>>> database;
    IList<Tuple<int, int>> followings;
    public Twitter()
    {
        database = new List<Tuple<int, List<Tuple<int, int>>>>();
        followings = new List<Tuple<int, int>>();
    }

    public void PostTweet(int userId, int tweetId)
    {
        if(!database.Any(t => t.Item1 == userId))
        {
            database.Add(new Tuple<int, List<Tuple<int, int>>>(userId, new List<Tuple<int, int>>()));
        }
        var user = database.Where(t => t.Item1 == userId).FirstOrDefault();
        user.Item2.Add(new Tuple<int, int>(tweetId, timestamp));
        /*if(user.Item2.Count>10)
            user.Item2.RemoveAt(0);*/
        timestamp--;
    }

    public IList<int> GetNewsFeed(int userId)
    {
        if (!database.Any(t => t.Item1 == userId))
        {
            database.Add(new Tuple<int, List<Tuple<int, int>>>(userId, new List<Tuple<int, int>>()));
        }
        var user = database.Where(t => t.Item1 == userId).FirstOrDefault();
        if (user == null) return new List<int>() { 99999};

        List<int> follows = new List<int>();
        foreach(var x in followings)
        {
            if(x.Item1 == user.Item1)
                follows.Add(x.Item2);
        }

        PriorityQueue<int, int> priorityQueue = new PriorityQueue<int, int>();
        //Add the tweets from user
        foreach(var x in user.Item2)
        {
            priorityQueue.Enqueue(x.Item1, x.Item2);
        }

        //Add all tweets from all his followings
        foreach(var x in follows)
        {
            var user_follows = database.Where(t => t.Item1 == x).FirstOrDefault();
            if(user_follows!=null)
            {
                foreach(var y in user_follows.Item2)
                {
                    priorityQueue.Enqueue(y.Item1, y.Item2);
                }
            }
        }
        List<int> posts = new List<int>();int nrOfPosts = 0;
        while (priorityQueue.Count > 0 && nrOfPosts<10)
        {
            posts.Add(priorityQueue.Dequeue());
            nrOfPosts++;
        }
        return posts;
    }

    public void Follow(int followerId, int followeeId)
    {
        if (!database.Any(t => t.Item1 == followerId))
        {
            database.Add(new Tuple<int, List<Tuple<int, int>>>(followerId, new List<Tuple<int, int>>()));
        }
        if (!database.Any(t => t.Item1 == followeeId))
        {
            database.Add(new Tuple<int, List<Tuple<int, int>>>(followeeId, new List<Tuple<int, int>>()));
        }
        if (!followings.Any(t => t.Item1 == followerId && t.Item2 == followeeId))
        {
            followings.Add(new Tuple<int, int>(followerId, followeeId));
        }
    }

    public void Unfollow(int followerId, int followeeId)
    {
        if (!database.Any(t => t.Item1 == followerId))
        {
            database.Add(new Tuple<int, List<Tuple<int, int>>>(followerId, new List<Tuple<int, int>>()));
        }
        if (!database.Any(t => t.Item1 == followeeId))
        {
            database.Add(new Tuple<int, List<Tuple<int, int>>>(followeeId, new List<Tuple<int, int>>()));
        }
        if (followings.Any(t => t.Item1 == followerId && t.Item2 == followeeId))
        {
            followings.Remove(followings.FirstOrDefault(t=> t.Item1 == followerId && t.Item2 == followeeId));
        }
    }
}

/**
 * Your Twitter object will be instantiated and called as such:
 * Twitter obj = new Twitter();
 * obj.PostTweet(userId,tweetId);
 * IList<int> param_2 = obj.GetNewsFeed(userId);
 * obj.Follow(followerId,followeeId);
 * obj.Unfollow(followerId,followeeId);
 */