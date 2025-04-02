// WritingAssignment.cs
public class WritingAssignment : Assignment
{
    // Additional attributes specific to Writing assignments
    private string _title;

    // Constructor that calls the base class constructor and sets Writing-specific properties
    public WritingAssignment(string studentName, string topic, string title) 
        : base(studentName, topic)
    {
        _title = title;
    }

    // Method to return the writing information
    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName()}";
    }
}
