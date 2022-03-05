namespace OOP2V1exercise
{
    class StackOverflowPost
    {
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string desc;

        public string Description
        {
            get { return desc; }
            set { desc = value; }
        }

        private string date;

        public string CreationDate
        {
            get { return date; }
            set { date = value; }
        }

        private int score = 0;

        public int Vote
        {
            get { return score; }
            //set { score = value; }
        }

        public void Upvote()
        {
            score++;
        }

        public void Downvote()
        {
            score--;
        }

        public StackOverflowPost()
        {
            this.title = "Title Example";
            this.desc = "Description Example Text";
            this.date = "2022.03.05";
        }

        public override string ToString()
        {
            return $"Post with title: {Title} created {date} has {score}"; 
        }
    }
}
