using System.Data;
using System.Threading.Tasks;

public class clsSubject
{
    private enum enMode { AddNew = 0, Update = 1 };
    private enMode _Mode = enMode.AddNew;

    public int SubjectID { get; set; }
    public string SubjectName { get; set; }
    public string TeacherName { get; set; }

    public clsSubject()
    {
        this.SubjectID = -1;
        this.SubjectName = "";
        this.TeacherName = "";
        _Mode = enMode.AddNew;
    }

    private clsSubject(int subjectID, string subjectName, string teacherName)
    {
        _Mode = enMode.Update;
        this.SubjectID = subjectID;
        this.SubjectName = subjectName;
        this.TeacherName = teacherName;
    }

    private async Task<bool> _AddNewSubjectAsync()
    {
        this.SubjectID = await clsSubjectData.AddNewSubjectAsync(this.SubjectName, this.TeacherName);
        return (this.SubjectID != -1);
    }

    private async Task<bool> _UpdateSubjectAsync()
    {
        return await clsSubjectData.UpdateSubjectAsync(this.SubjectID, this.SubjectName, this.TeacherName);
    }

    public async Task<bool> SaveAsync()
    {
        switch (_Mode)
        {
            case enMode.AddNew:
                if (await _AddNewSubjectAsync())
                {
                    _Mode = enMode.Update;
                    return true;
                }
                else
                {
                    return false;
                }
            case enMode.Update:
                return await _UpdateSubjectAsync();
            default:
                return false;
        }
    }

    public static async Task<DataTable> GetAllSubjectsAsync()
    {
        return await clsSubjectData.GetAllSubjectsAsync();
    }

    public static  clsSubject FindSubjectBySubjectID(int subjectID)
    {
        string subjectName = "";
        string teacherName = "";
        bool isFound =  clsSubjectData.FindSubjectBySubjectIDAsync(subjectID, ref subjectName, ref teacherName);
        if (isFound)
        {
            return new clsSubject(subjectID, subjectName, teacherName);
        }
        else
        {
            return null;
        }
    }
    public static  clsSubject FindSubjectBySubjectNameAsync(string subjectName)
    {
        int subjectID = -1;
        string teacherName = "";

        bool isFound = clsSubjectData.FindSubjectBySubjectNameAsync(subjectName, ref subjectID, ref teacherName);

        if (isFound)
        {
            return new clsSubject(subjectID, subjectName, teacherName);
        }
        else
        {
            return null;
        }
    }

    public static async Task<bool> DeleteSubjectAsync(int subjectID)
    {
        return await clsSubjectData.DeleteSubjectAsync(subjectID);
    }
}
