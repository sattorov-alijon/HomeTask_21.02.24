var Student1=new Student();
Student1.Name="Alijon";
Student1.GradeLevel=11;
Student1.TestScores=new int[5]{100,100,90,90,100};

var Student2=new Student();
Student2.Name="Mansur";
Student2.GradeLevel=10;
Student2.TestScores=new int[5]{90,80,90,90,85};

var Student3=new Student();
Student3.Name="Farrukh";
Student3.GradeLevel=9;
Student3.TestScores=new int[5]{60,60,50,40,35};

if (Student1.GetAverage()>=90)
{
    System.Console.WriteLine($"Congratulations {Student1.Name} on achieving above average scores ({Student1.GetAverage()}) in grade {Student1.GradeLevel}!Keep up the good work! ");
}
else if (Student1.GetAverage()>=75 && Student1.GetAverage()<90)
{
    System.Console.WriteLine($"Congratulations {Student1.Name} on achieving an average score of ({Student1.GetAverage()}) in grade {Student1.GradeLevel}!   Keep working hard for even better results! ");
}
else
{
    System.Console.WriteLine($"Congratulations {Student3.Name} on achieving an average score of ({Student3.GetAverage()}) in grade {Student3.GradeLevel}!   IN SOHA BAROI TOO NEST! ");   
}

if (Student2.GetAverage()>=90)
{
    System.Console.WriteLine($"Congratulations {Student2.Name} on achieving above average scores ({Student2.GetAverage()}) in grade {Student2.GradeLevel}!Keep up the good work! ");
}
else if (Student2.GetAverage()>=75 && Student2.GetAverage()<90)
{
    System.Console.WriteLine($"Congratulations {Student2.Name} on achieving an average score of ({Student2.GetAverage()}) in grade {Student2.GradeLevel}!   Keep working hard for even better results! ");
}
else
{
    System.Console.WriteLine($"Congratulations {Student3.Name} on achieving an average score of ({Student3.GetAverage()}) in grade {Student3.GradeLevel}!   IN SOHA BAROI TOO NEST! ");   
}


if (Student3.GetAverage()>=90)
{
    System.Console.WriteLine($"Congratulations {Student3.Name} on achieving above average scores ({Student3.GetAverage()}) in grade {Student3.GradeLevel}!Keep up the good work! ");
}
else if (Student3.GetAverage()>=75 && Student3.GetAverage()<90)
{
    System.Console.WriteLine($"Congratulations {Student3.Name} on achieving an average score of ({Student3.GetAverage()}) in grade {Student3.GradeLevel}!   Keep working hard for even better results! ");
}
else
{
    System.Console.WriteLine($"Congratulations {Student3.Name} on achieving an average score of ({Student3.GetAverage()}) in grade {Student3.GradeLevel}!   IN SOHA BAROI TOO NEST! ");   
}





class Student
{
    public string Name;
    public int GradeLevel;
    public int[] TestScores;
    public double GetAverage()
    {
        int sum=0;
        for (int i = 0; i < TestScores.Length; i++)
        {
            sum+=TestScores[i];
        }
        return sum/(double)TestScores.Length;
    }
}