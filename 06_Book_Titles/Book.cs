namespace _06_Book_Titles
{
    internal class Book
    {
        private string wordsToReturn = "";
        public string Title
        {
            get
            {
                return wordsToReturn;
            }
            internal set
            {
                string[] words = value.Split();
                int counter = 0;

                foreach(string word in words)
                {
                    if(0 != counter)
                    {
                        if ("the" == word)
                        {
                            wordsToReturn = wordsToReturn + " " + word;
                        }
                        else if ("a" == word)
                        {
                            wordsToReturn = wordsToReturn + " " + word;
                        }
                        else if ("an" == word)
                        {
                            wordsToReturn = wordsToReturn + " " + word;
                        }
                        else if ("and" == word)
                        {
                            wordsToReturn = wordsToReturn + " " + word;
                        }
                        else if ("in" == word)
                        {
                            wordsToReturn = wordsToReturn + " " + word;
                        }
                        else if ("of" == word)
                        {
                            wordsToReturn = wordsToReturn + " " + word;
                        }
                        else if ("i" == word)
                        {
                            wordsToReturn = wordsToReturn + " " + word.ToUpper();
                        }
                        else
                        {
                            wordsToReturn = wordsToReturn + " " + word.Substring(0, 1).ToUpper() + word.Substring(1);
                        }
                    }
                    else
                    {
                        wordsToReturn = wordsToReturn + " " + word.Substring(0, 1).ToUpper() + word.Substring(1);
                    }
                    counter = counter + 1;
                }

                wordsToReturn = wordsToReturn.Trim();
            }
        }
    }
}