namespace _06_Book_Titles
{
    internal class Book
    {

        //Backing variable for the property Title
        private string title = "";
        
        public string Title
        {

            //Will return the variable when we access the property
            get
            {
                return title;
            }

            //Will set the variable when we assign a value to it
            internal set
            {

                //create a string array with all of the words from the string
                string[] words = value.Split();

                //this variable will count how many iterations we have in the foreach
                int counter = 0;

                //go through all the words in the words array using the variable word
                foreach(string word in words)
                {
                    //this line checks if this is the first iteration of the loop
                    if(counter == 0)
                    {
                        //since this is the first iteration we need to uppercase it everytime
                        //we get the first letter with substring and uppercase it and then add it the rest of the word
                        title = title + " " + word.Substring(0, 1).ToUpper() + word.Substring(1);
                    }
                    else
                    {
                        //since this is not the first iteration anymore we need to check which words to capitalize
                        //takeCareOfTheWord returns the string which will be already taken care of
                        title = title + " " + takeCareOfTheWord(word);
                    }

                    //add one unit to the counter variable for each iteration
                    counter = counter + 1;
                }

                //assign the title variable but first trim it, so it takes out the end spaces and the start spaces.
                title = title.Trim();
            }
        }

        public string takeCareOfTheWord(string wordToTest)
        {
            //string array of words we should not capitalize
            string[] notToCapitalize = { "and", "the", "or", "a", "an", "in", "of" };

            //create a string to return at the end of the method
            string finalWord = "";

            //we need to have a boolean to see if we already changed the word on not
            bool changed = false;

            //is the wordToTest equals to i?
            if(wordToTest == "i")
            {
                //Since it is we need to turn it to Upper
                finalWord = wordToTest.ToUpper();

                //change the value of changed to true, since we changed the finalWord var right now.
                changed = true;
            }

            //this foreach loop will go through every word not to capitalize
            foreach (string wordNotToCapitalize in notToCapitalize)
            {
                //is our word one of the ones we dont want to capitalize??
               if(wordNotToCapitalize == wordToTest)
                {

                    //OH, it is!
                    //So lets just assign it the wordToTest value since we need it the original way (probably lowecased)
                    finalWord = wordToTest;

                    //change the value of changed to true, since we changed the finalWord var right now.
                    changed = true;
                }
            }


            //Oh we got it without changing the variable?
            //This is not one the words we need to change then, we should just uppercase it.
            if(changed == false)
            {
                //we get the first letter with substring and uppercase it and then add it the rest of the word
                finalWord = wordToTest.Substring(0, 1).ToUpper() + wordToTest.Substring(1);
            }

            //Lets just return this word which is now taken care of.
            return finalWord;

        }

    }
}