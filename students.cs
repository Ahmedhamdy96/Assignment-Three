// i have written this code in Linux Mint 18.2 using MONO cross platform 
// http://www.mono-project.com
// commands used :  [[ $mcs students.cs ]] to compile  and  [[ $mono students.exe ]] to run the programme
 
using System ;
class school
{
  static void Main(string[] args)
  {
    int n ;                          // number of students 
    int i ;                          // counter
    int choice ;                     // option number selected by the user 
    string s_name ;                  // student named

    Console.WriteLine("Enter Number of Students : ");
    n = int.Parse(Console.ReadLine()); 

    string[] names = new string[n];    // array to store students names  
    double[] degrees = new double[n] ; // array to store students degrees 
    
    for(i = 0 ; i<n ; i++)          // storing every student name and degree 
    {
      Console.WriteLine("Enter Student {0} Name : " ,i+1);
      names[i] = Console.ReadLine() ; 
      Console.WriteLine("Enter His/Her Degree : ");
      degrees[i] = double.Parse(Console.ReadLine());
    }

    Console.WriteLine(" ");
    Console.WriteLine("Choose an option from the following menu : ");
    Console.WriteLine("========================================== ");
    Console.WriteLine("[1] Search For a Student Degree ");
    Console.WriteLine("[2] Get Top Student Name and Degree ");
    Console.WriteLine("[3] Change a Student Name ");
    Console.WriteLine(" ");
    
    Console.WriteLine("Please , enter your choice : ");
    choice = int.Parse(Console.ReadLine());   
    // option [ 1 ]  
    if(choice == 1 )
    {
      int f = 0 ;   // a flag to check if the enterd name is exists in the names' array or not 
      Console.WriteLine("Enter student name : ");
      s_name = Console.ReadLine(); 
      for(int j = 0 ;j<n;j++)
      {
        if(names[j] == s_name)
        {
          f +=1 ;
          Console.WriteLine("Student {0} degree is {1} " , names[j], degrees[j]);
          break ; 
        }
      }
      if(f==0)
      {
        Console.WriteLine("Error , No student called {0} " , s_name);
      }
    }
// ================================================================================================================
    // option [ 2 ]
    else if(choice == 2 )
    {
      String top_name = names[0];   // assuming student one is the top and comparing him with every one  
      double top_deg = degrees[0];

      for(int x = 0 ; x<n ; x++)
      {
        if(degrees[x] > top_deg)
        {
          top_deg = degrees[x] ; 
          top_name = names[x] ; 
          break ;
        }
      } 

      Console.WriteLine("Top Student Name is  : {0} and his/her degree is : {1} " ,top_name ,top_deg );
    } 
// ==================================================================================================================
    // option [ 3 ]
    else if(choice == 3 )
    {
      string old_name ;
      string new_name ;

      Console.WriteLine("Type The Name of Student to be Changed (old name) : "); 
      old_name = Console.ReadLine();
      Console.WriteLine("Enter New Name : "); 
      new_name = Console.ReadLine();

      int k = 0 ; // a  flag to check if the old name exist or not  
      for(int p = 0 ; p<n ; p++)
      {
        if(old_name == names[p])
        {
           k +=1 ; 
          names[p] = new_name ;
          Console.WriteLine("Name Successfuly changed from {0} to {1}" , old_name , new_name ); 
          break ; 
        }
      }
      if(k==0)
      {
        Console.WriteLine("Error , No Student Called {0} " , old_name );
      } 
    }
// ===================================================================================================================       

  }
}
