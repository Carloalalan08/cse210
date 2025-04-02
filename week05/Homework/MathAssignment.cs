// MathAssignment.cs
public class MathAssignment : Assignment
{
    // Additional attributes specific to Math assignments
    private string _section;
    private string _problems;

    // Constructor that calls the base class constructor and sets Math-specific properties
    public MathAssignment(string studentName, string topic, string section, string problems) 
        : base(studentName, topic)
    {
        _section = section;
        _problems = problems;
    }

    // Method to return the Math homework list
    public string GetHomeworkList()
    {
        return $"Section {_section} Problems {_problems}";
    }
}
