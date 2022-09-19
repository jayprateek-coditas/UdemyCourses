
using Exercise.Codes;

// Exerice _1 StopWatch 

//char ch = 'y';
//do
//{
//    StopWatch s1 = new StopWatch();

//    Console.WriteLine("To Start Enter  1 : ");
//    int val = Convert.ToInt32(Console.ReadLine());
//    bool flag = false;
//    s1.start();

//    ch = 'n';
//  if(val==1)
//    while (true)
//    {
//            Console.WriteLine("To Start New Timer  Enter 1  : ");
//            Console.WriteLine("To Start            Enter 2  : ");
//            Console.WriteLine("To End              Enter 3  : ");

//            int val_1 = Convert.ToInt32(Console.ReadLine());

//            if (val_1 == 1)
//                break;
//            else if(val_1==2)
//            {
//                if(flag==false)
//                {
//                    Console.WriteLine("You have to STOP first !!\n");
//                    break;
//                }
//                else
//                {
//                     flag = false;
//                    s1.start();
//                }    

//            }
//            else if (val_1 == 3)
//            {
//                if (flag == true)
//                {
//                    Console.WriteLine("You have to START first !!\n");
//                    break;
//                }
//                else
//                {
//                    flag = true;
//                    s1.stop();
//                }

//            }
//        }
//    Console.Write("\n\nTo Continue Enter y : ");
//    ch = Console.ReadLine()[0];

//} while (ch == 'y');


// Exercise 2 StackOverFLow


StackOverFlow s1 = new StackOverFlow();

s1.Title = "C#";
s1.Description = "Working with LINQ ";
s1.setUpVode();
s1.setUpVode();
s1.setDownVode();

s1.created_();
s1.totalVote();
