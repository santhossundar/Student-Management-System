namespace Student_Management_System_v1.views
{
    public interface IUiRegisterView
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string DOB { get; set; }
        string AddressNo { get; set; }
        string AddressStreet { get; set; }
        string AddressCity { get; set; }
        string StdNo { get; set; }
    }
}
