using System;
using System.Collections.Generic;
using System.Text;

namespace SdamQuizSystem
{
    class detailes
    {
        List<Student> student1 = new List<Student>();
        List<Teachers> teachers1 = new List<Teachers>();
        List<Examiner> examiner1 = new List<Examiner>();

        public detailes()
        {

            student1.Add(new Student("Alice"));
            student1.Add(new Student("Bob"));
            student1.Add(new Student("Charlie"));
            student1.Add(new Student("Dave"));

            teachers1.Add(new Teachers("Alice"));
            teachers1.Add(new Teachers("Amma"));
            teachers1.Add(new Teachers("Anna"));

            examiner1.Add(new Examiner("Ann"));
            examiner1.Add(new Examiner("mark"));



        }

        List<Question> question1 = new List<Question>()
            {

                new Question("What is the capital of France?", new string[]{"Paris", "London", "Berlin", "Rome"}, 0,10),
                new Question("What is the largest planet in our solar system?", new string[]{"Earth", "Jupiter", "Mars", "Saturn"}, 1,10),
                new Question("Who was the first president of the United States?", new string[]{"George Washington", "John Adams", "Thomas Jefferson", "James Madison"}, 0,10)


            };




        List<QusetionsWithHints> question2 = new List<QusetionsWithHints>()
            {

                new QusetionsWithHints("What is the capital of France?","ifell tower is in that city", new string[]{"Paris", "London", "Berlin", "Rome"}, 0),
                new QusetionsWithHints("What is the largest planet in our solar system?","it has the highest number of moons in the galexy", new string[]{"Earth", "Jupiter", "Mars", "Saturn"}, 1),
                new QusetionsWithHints("Who was the first president of the United States?","he has a lead member of a american revelution", new string[]{"George Washington", "John Adams", "Thomas Jefferson", "James Madison"}, 0)


            };

        List<Question> question3 = new List<Question>()
            {


                new Question("What is the average of first 150 natural numbers?", new string[]{ "70", " 70.5", "75", "75.5"}, 2,10),
                new Question("What is the rate of discount if a car which price was $4,000 was sold for $3,200 ?s", new string[]{"14%", "16%", "18%", "20%"}, 3,10),
                new Question("What is the value of x in the equation 3x – 15 – 6 = 0 ?", new string[]{"7", "8", "9", "-9"}, 0,10)


            };

        List<QusetionsWithHints> question4 = new List<QusetionsWithHints>()
            {


              new QusetionsWithHints("What is the average of first 150 natural numbers?","divide from 2", new string[]{ "70", " 70.5", "75", "75.5"}, 2),
              new QusetionsWithHints("What is the rate of discount if a car which price was $4,000 was sold for $3,200 ?","use persentages", new string[]{"14%", "16%", "18%", "20%"}, 3),
              new QusetionsWithHints("What is the value of x in the equation 3x – 15 – 6 = 0 ?","use this in your calculation ex:(x+3)(x+2x)", new string[]{"7", "8", "9", "-9"}, 0)


            };


        public void StIdvalidation()
        {
            Console.WriteLine("enter the Students id:");
            int id = Convert.ToInt32(Console.ReadLine());
            var st1 = student1.Find(student1 => student1.S_id == id);
            if (st1 != null)
            {
                hints();
            }
            else { Console.WriteLine("Wrong Input"); }
        }

        public void StIdvalidation1()
        {
            Console.WriteLine("enter the Students id:");
            int id = Convert.ToInt32(Console.ReadLine());
            var st1 = student1.Find(student1 => student1.S_id == id);
            if (st1 != null)
            {
                hints1();
            }
            else { Console.WriteLine("Wrong Input"); }
        }

        public void TutorIdValidation()
        {
            Console.WriteLine("enter the tutor id:");
            int id = Convert.ToInt32(Console.ReadLine());
            var st1 = teachers1.Find(teachers1 => teachers1.tId == id);
            if (st1 != null)
            {
                Console.WriteLine("press 1 if you wants to take quiz");
                Console.WriteLine("press 2 if you wants to edit the quiz");
                Console.WriteLine("press 3 if you wants to Main menu");
                int answer = Convert.ToInt32(Console.ReadLine());
                switch (answer)
                {
                    case 1:
                        hints();
                        break;
                    case 2:
                        giveHints();
                        break;
                    case 3:
                        break;

                }


            }
            else { Console.WriteLine("Wrong Input"); }
        }

        public void TutorIdValidation1()
        {
            Console.WriteLine("enter the tutor id:");
            int id = Convert.ToInt32(Console.ReadLine());
            var st1 = teachers1.Find(teachers1 => teachers1.tId == id);
            if (st1 != null)
            {
                Console.WriteLine("press 1 if you wants to take quiz");
                Console.WriteLine("press 2 if you wants to edit the quiz");
                Console.WriteLine("press 3 if you wants to Main menu");
                int answer = Convert.ToInt32(Console.ReadLine());
                switch (answer)
                {
                    case 1:
                        hints1();
                        break;
                    case 2:
                        giveHints1();
                        break;
                    case 3:
                        break;

                }


            }
            else { Console.WriteLine("Wrong Input"); }
        }

        public void examinerIdValidation()
        {
            Console.WriteLine("enter the examiner id:");
            int id = Convert.ToInt32(Console.ReadLine());
            var st1 = examiner1.Find(examiner1 => examiner1.eId == id);
            if (st1 != null)
            {
                Console.WriteLine("press 1 if you wants to take quiz");
                Console.WriteLine("press 2 if you wants to remove qusetions from the quiz");
                Console.WriteLine("press 3 if you wants to Main menu");
                int answer = Convert.ToInt32(Console.ReadLine());
                switch (answer)
                {
                    case 1:
                        hints();
                        break;
                    case 2:
                        removeQusetion();
                        break;
                    case 3:
                        break;



                }


            }
            else { Console.WriteLine("Wrong Input"); }
        }

        
        public void examinerIdValidation1()
        {
            Console.WriteLine("enter the examiner id:");
            int id = Convert.ToInt32(Console.ReadLine());
            var st1 = examiner1.Find(examiner1 => examiner1.eId == id);
            if (st1 != null)
            {
                Console.WriteLine("press 1 if you wants to take quiz");
                Console.WriteLine("press 2 if you wants to remove qusetions from the quiz");
                Console.WriteLine("press 3 if you wants to Main menu");
                int answer = Convert.ToInt32(Console.ReadLine());
                switch (answer)
                {
                    case 1:
                        hints1();
                        break;
                    case 2:
                        removeQusetion1();
                        break;
                    case 3:
                        break;



                }


            }
            else { Console.WriteLine("Wrong Input"); }
        }



        public void QandA()
        {

            int score = 0;
            int currentQuestion = 0;
            int qNo = 1;
            int ans = 0;
            // Loop through all the questions
            while (currentQuestion < question1.Count)
            {
                // Display the current question and answers
                Console.WriteLine(qNo + ")" + question1[currentQuestion].Questions);
                for (int i = 0; i < question1[currentQuestion].Answer.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {question1[currentQuestion].Answer[i]}");
                }
                ans = question1[currentQuestion].Marks + ans;
                // Get the user's answer
                Console.Write("Enter your answer: ");
                int userAnswer = Convert.ToInt32(Console.ReadLine()) - 1;

                // Check if the user's answer is correct
                if (userAnswer == question1[currentQuestion].CorrectAnswerIndex)
                {
                    Console.WriteLine("Correct!");
                    score=score+10;
                   
                }
                else
                {
                    Console.WriteLine("Incorrect.");
                }

                currentQuestion++;
                qNo++;
            }

            // Display the final score
            Console.WriteLine($"Your final score is: {score}/{ans}");
            if (score == 0)
            {
                Console.WriteLine("You have a F Pass");
            }
            else if (score == 1)
            {
                Console.WriteLine("You have a C Pass");
            }
            else if (score == 2)
            {
                Console.WriteLine("You have a B Pass");
            }
            else if (score == 3)
            {
                Console.WriteLine("You have a A Pass");
            }


        }

        public void QandA1()
        {

            int score = 0;
            int currentQuestion = 0;
            int qNo = 1;
            // Loop through all the questions
            while (currentQuestion < question3.Count)
            {
                // Display the current question and answers
                Console.WriteLine(qNo + ")" + question3[currentQuestion].Questions);
                for (int i = 0; i < question3[currentQuestion].Answer.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {question3[currentQuestion].Answer[i]}");

                }

                // Get the user's answer
                Console.Write("Enter your answer: ");
                int userAnswer = Convert.ToInt32(Console.ReadLine()) - 1;

                // Check if the user's answer is correct
                if (userAnswer == question3[currentQuestion].CorrectAnswerIndex)
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect.");
                }

                currentQuestion++;
                qNo++;

            }

            // Display the final score
            Console.WriteLine($"Your final score is: {score}/{question3.Count}");
            if (score == 0)
            {
                Console.WriteLine("You have a F Pass");
            }
            else if (score == 1)
            {
                Console.WriteLine("You have a C Pass");
            }
            else if (score == 2)
            {
                Console.WriteLine("You have a B Pass");
            }
            else if (score == 3)
            {
                Console.WriteLine("You have a A Pass");
            }


        }

        public void QandAwithHints1()
        {

            int score = 0;
            int currentQuestion = 0;
            int qNo = 1;
            // Loop through all the questions
            while (currentQuestion < question4.Count)
            {
                // Display the current question and answers
                Console.WriteLine(qNo + ")" + question4[currentQuestion].Questions + "Hints:" + question4[currentQuestion].Hint);
                for (int i = 0; i < question4[currentQuestion].Answer.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {question4[currentQuestion].Answer[i]}");
                }

                // Get the user's answer
                Console.Write("Enter your answer: ");
                int userAnswer = Convert.ToInt32(Console.ReadLine()) - 1;

                // Check if the user's answer is correct
                if (userAnswer == question4[currentQuestion].CorrectAnswerIndex)
                {
                    Console.WriteLine("Correct!");
                    score=score+20;
                }
                else
                {
                    Console.WriteLine("Incorrect.");
                }

                currentQuestion++;
                qNo++;

            }

            // Display the final score
            Console.WriteLine($"Your final score is: {score}/{question4.Count}");
            if (score == 0)
            {
                Console.WriteLine("You have a F Pass");
            }
            else if (score == 1)
            {
                Console.WriteLine("You have a C Pass");
            }
            else if (score == 2)
            {
                Console.WriteLine("You have a B Pass");
            }
            else if (score == 3)
            {
                Console.WriteLine("You have a A Pass");
            }


        }

        public void QandAwithHints()
        {

            int score = 0;
            int currentQuestion = 0;

            // Loop through all the questions
            while (currentQuestion < question2.Count)
            {
                // Display the current question and answers
                Console.WriteLine(question2[currentQuestion].Questions+"Hints:"+question2[currentQuestion].Hint);
                for (int i = 0; i < question2[currentQuestion].Answer.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {question2[currentQuestion].Answer[i]}");
                }

                // Get the user's answer
                Console.Write("Enter your answer: ");
                int userAnswer = Convert.ToInt32(Console.ReadLine()) - 1;

                // Check if the user's answer is correct
                if (userAnswer == question2[currentQuestion].CorrectAnswerIndex)
                {
                    Console.WriteLine("Correct!");
                    score=score+20;
                }
                else
                {
                    Console.WriteLine("Incorrect.");
                }

                currentQuestion++;
            }

            // Display the final score
            Console.WriteLine($"Your final score is: {score}/{question2.Count}");
            if (score==0)
            {
                Console.WriteLine("You have a F Pass");
            }else if (score==1)
            {
                Console.WriteLine("You have a C Pass");
            }
            else if (score==2)
            {
                Console.WriteLine("You have a B Pass");
            }
            else if (score>=3)
            {
                Console.WriteLine("You have a A Pass");
            }
           
            

        }



        public void hints()
        {
            Console.WriteLine("Do you want hints for each qustions?\n1)yes\n2)no");
            int hint1 = Convert.ToInt32(Console.ReadLine());
            if (hint1 == 1)
            {

                QandAwithHints();

            }
            else if (hint1 == 2)
            {

                QandA();

            }
        }

        public void hints1()
        {
            Console.WriteLine("Do you want hints for each qustions?\n1)yes\n2)no");
            int hint1 = Convert.ToInt32(Console.ReadLine());
            if (hint1 == 1)
            {

                QandAwithHints1();

            }
            else if (hint1 == 2)
            {

                QandA1();

            }
        }

        public void AddQuestion()
        {

            int v = 30;
            do
            {
               
                Console.WriteLine("please enter the qustion:");
                string qustion = Console.ReadLine();
                Console.WriteLine("Enter the answers");
                string answer1 = Console.ReadLine();
                string answer2 = Console.ReadLine();
                string answer3 = Console.ReadLine();
                string answer4 = Console.ReadLine();
                Console.WriteLine("Enter the correct answer:");
                int AnswerIndex = Convert.ToInt32(Console.ReadLine());
                int AnswerIndex1 = AnswerIndex - 1;
                Console.WriteLine("Enter marks:");
                int mark = Convert.ToInt32(Console.ReadLine());
                question1.Add(new Question(qustion, new string[] { answer1, answer2, answer3, answer4 }, AnswerIndex1,mark));
                v= mark + v;
            } while (v<100);

            Console.WriteLine("you have exided the mark limit press enter to continue");
            Console.ReadLine();
            






            int currentQuestion = 0;


            // Loop through all the questions
            while (currentQuestion < question1.Count)
            {
                // Display the current question and answers
                Console.WriteLine(question1[currentQuestion].Questions);
                for (int i = 0; i < question1[currentQuestion].Answer.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {question1[currentQuestion].Answer[i]}");
                }

                currentQuestion++;
            }


        }

        public void AddQuestion1()
        {

            int v = 30;
            do
            {
                Console.WriteLine("please enter the qustion:");
                string qustion = Console.ReadLine();
                Console.WriteLine("Enter the answers");
                string answer1 = Console.ReadLine();
                string answer2 = Console.ReadLine();
                string answer3 = Console.ReadLine();
                string answer4 = Console.ReadLine();
                Console.WriteLine("Enter the correct answer:");
                int AnswerIndex = Convert.ToInt32(Console.ReadLine());
                int AnswerIndex1 = AnswerIndex - 1;
                Console.WriteLine("Enter marks:");
                int mark = Convert.ToInt32(Console.ReadLine());

                question3.Add(new Question(qustion, new string[] { answer1, answer2, answer3, answer4 }, AnswerIndex1,mark));
                v=mark+ v;

            } while (v<=100);
            

            int currentQuestion = 0;

            // Loop through all the questions
            while (currentQuestion < question3.Count)
            {
                // Display the current question and answers
                Console.WriteLine(question3[currentQuestion].Questions);
                for (int i = 0; i < question3[currentQuestion].Answer.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {question3[currentQuestion].Answer[i]}");
                }

                currentQuestion++;
            }


        }

        public void removeQusetion()
        {
            int qNo = 1;
            int currentQuestion = 0;
            Console.WriteLine("which qustions should be removed?**press 0 to tutor menue**");
            while (currentQuestion < question1.Count)
            {
                // Display the current question and answers
                Console.WriteLine(qNo + ")" + question1[currentQuestion].Questions);
                for (int i = 0; i < question1[currentQuestion].Answer.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {question1[currentQuestion].Answer[i]}");
                }

                currentQuestion++;
                qNo++;
            }
            int qNum = Convert.ToInt32(Console.ReadLine());
            if (qNum == 0)
            {
                examinerIdValidation();
            }
            else
            {
                question1.RemoveAt(qNum - 1);
                question2.RemoveAt(qNum - 1);
            }


        }

        public void removeQusetion1()
        {
            int qNo = 1;
            int currentQuestion = 0;
            Console.WriteLine("which qustions should be removed?**press 0 to tutor menue**");
            while (currentQuestion < question3.Count)
            {
                // Display the current question and answers
                Console.WriteLine(qNo + ")" + question3[currentQuestion].Questions);
                for (int i = 0; i < question3[currentQuestion].Answer.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {question3[currentQuestion].Answer[i]}");
                }

                currentQuestion++;
                qNo++;
            }
            int qNum = Convert.ToInt32(Console.ReadLine());
            if (qNum == 0)
            {
                examinerIdValidation1();
            }
            else
            {
                question3.RemoveAt(qNum - 1);
                question4.RemoveAt(qNum - 1);
            }


        }

        public void giveHints()
        {
            Console.WriteLine("do you need to add hints?\n1)yes\n2)no");
            string y=Console.ReadLine();
            if (y=="1")
            {
                addQusetionsWithHints1();
            }
            else
            {

                AddQuestion();


            }
        }

        public void giveHints1()
        {
            Console.WriteLine("do you need to add hints?\n1)yes\n2)no");
            string y = Console.ReadLine();
            if (y == "1")
            {
                addQusetionsWithHints2();
            }
            else
            {

                AddQuestion1();


            }
        }

        public void addQusetionsWithHints1()
        {
     
            Console.WriteLine("please enter the qustion:");
            string qustion = Console.ReadLine();
            Console.WriteLine("Enter the answers");
            string answer1 = Console.ReadLine();
            string answer2 = Console.ReadLine();
            string answer3 = Console.ReadLine();
            string answer4 = Console.ReadLine();
            Console.WriteLine("Enter the correct answer:");
            int AnswerIndex = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Hint:");
            string hint = Console.ReadLine();
            int AnswerIndex1 = AnswerIndex - 1;

            question2.Add(new QusetionsWithHints(qustion,hint, new string[] { answer1, answer2, answer3, answer4 }, AnswerIndex1));

            int currentQuestion = 0;


            // Loop through all the questions
            while (currentQuestion < question2.Count)
            {
                // Display the current question and answers
                Console.WriteLine(question2[currentQuestion].Questions +"Hint:"+ question2[currentQuestion].Hint);
                for (int i = 0; i < question2[currentQuestion].Answer.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {question2[currentQuestion].Answer[i]}");
                }


                currentQuestion++;
            }

        }
        public void addQusetionsWithHints2()
        {
            Console.WriteLine("please enter the qustion:");
            string qustion = Console.ReadLine();
            Console.WriteLine("Enter the answers");
            string answer1 = Console.ReadLine();
            string answer2 = Console.ReadLine();
            string answer3 = Console.ReadLine();
            string answer4 = Console.ReadLine();
            Console.WriteLine("Enter the correct answer:");
            int AnswerIndex = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Hint:");
            string hint = Console.ReadLine();
            int AnswerIndex1 = AnswerIndex - 1;

            question4.Add(new QusetionsWithHints(qustion,hint, new string[] { answer1, answer2, answer3, answer4 }, AnswerIndex1));

            int currentQuestion = 0;
            
            // Loop through all the questions
            while (currentQuestion < question4.Count)
            {
                // Display the current question and answers
                Console.WriteLine(question4[currentQuestion].Questions+"Hint:"+question4[currentQuestion].Hint);
                for (int i = 0; i < question4[currentQuestion].Answer.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {question4[currentQuestion].Answer[i]}");
                    
                }
               
                currentQuestion++;
            }

        }
    }
}
