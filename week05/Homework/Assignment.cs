// Assignment.cs
public class Assignment
{
    // Common attributes for both types of assignments
    private string _studentName;
    private string _topic;

    // Constructor to initialize the common properties
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Method to return a summary of the assignment
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    // Getter for the student name (if needed by derived classes)
    public string GetStudentName()
    {
        return _studentName;
    }
}
