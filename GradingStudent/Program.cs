

List<int> grades = new List<int>() { 4,73,67,38,33};



List<int> result = gradingStudents(grades);

Console.WriteLine(string.Join(",", result.ToArray()));

static List<int> gradingStudents(List<int> grades)
{
    var roundedGrades = new List<int>();

    for (int i = 0; i < grades.Count; i++)
    {
        if (grades[i] < 38)
        {
            roundedGrades.Add(grades[i]);
        }
        else if (grades[i] % 5 == 3)
        {
            roundedGrades.Add(grades[i] + 2);
        }
        else if (grades[i] % 5 == 4)
        {
            roundedGrades.Add(grades[i] + 1);
        }
        else
        {
            roundedGrades.Add(grades[i]);
        }
    }
    return roundedGrades;
}