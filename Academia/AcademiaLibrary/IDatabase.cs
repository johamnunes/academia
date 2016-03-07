namespace AcademiaLibrary
{
    public interface IDatabase
    {
        int Insert();
        int Update();
        int Delete();
        object Select();
    }
}
