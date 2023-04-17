namespace Student_Management_System_v1.models
{
    public interface IStudent
    {
        string firstName { get; }
        string lastName { get; }
        string DOB { get; }
        string addressNo { get; }
        string addressStreet { get; }
        string addressCity { get; }
        string stdNo { get; }
    }
}
