using System.Data;
using System.Threading.Tasks;
using System;

public class clsTask
{
    private enum enMode { AddNew = 0, Update = 1 };
    private enMode _Mode = enMode.AddNew;

    public int TaskID { get; set; }
    public string TaskTitle { get; set; }
    public string TaskDetails { get; set; }
    public DateTime TaskDate { get; set; }
    public DateTime DueDate { get; set; }
    public string Notes { get; set; }
    public int TaskType { get; set; }
    public int SubjectID { get; set; }

    public clsSubject SubjectInfo { get; set;  }

    public clsTask()
    {
        this.TaskID = -1;
        this.TaskTitle = "";
        this.TaskDetails = "";
        this.TaskDate = DateTime.Now;
        this.DueDate = DateTime.Now;
        this.Notes = "";
        this.TaskType = -1;
        this.SubjectID = -1;
        _Mode = enMode.AddNew;
    }

    private clsTask(int taskID, string taskTitle, string taskDetails, DateTime taskDate, DateTime dueDate, string notes, int taskType, int subjectID)
    {
        _Mode = enMode.Update;
        this.TaskID = taskID;
        this.TaskTitle = taskTitle;
        this.TaskDetails = taskDetails; 
        this.TaskDate = taskDate;
        this.DueDate = dueDate;
        this.Notes = notes;
        this.TaskType = taskType;
        this.SubjectID = subjectID;
        this.SubjectInfo = clsSubject.FindSubjectBySubjectID(subjectID);
    }

    private async Task<bool> _AddNewTaskAsync()
    {
        this.TaskID = await clsTaskData.AddNewTaskAsync(this.TaskTitle, this.TaskDetails, this.TaskDate, this.DueDate, this.Notes, this.TaskType, this.SubjectID);
        return (this.TaskID != -1);
    }

    private async Task<bool> _UpdateTaskAsync()
    {
        return await clsTaskData.UpdateTaskAsync(this.TaskID, this.TaskTitle, this.TaskDetails, this.TaskDate, this.DueDate, this.Notes, this.TaskType, this.SubjectID);
    }

    public async Task<bool> SaveAsync()
    {
        switch (_Mode)
        {
            case enMode.AddNew:
                if (await _AddNewTaskAsync())
                {
                    _Mode = enMode.Update;
                    return true;
                }
                else
                {
                    return false;
                }
            case enMode.Update:
                return await _UpdateTaskAsync();
            default:
                return false;
        }
    }

    public static async Task<DataTable> GetAllTasksAsync()
    {
        return await clsTaskData.GetAllTasksAsync();
    }

    public static  clsTask FindTaskByTaskIDAsync(int taskID)
    {
        string taskTitle = "";
        string taskDetails = "";
        DateTime taskDate = DateTime.Now;
        DateTime dueDate = DateTime.Now;
        string notes = "";
        int taskType = -1;
        int subjectID = -1;
        bool isFound =  clsTaskData.FindTaskByTaskIDAsync(taskID, ref taskTitle, ref taskDetails, ref taskDate, ref dueDate, ref notes, ref taskType, ref subjectID);
        if (isFound)
        {
            return new clsTask(taskID, taskTitle, taskDetails, taskDate, dueDate, notes, taskType, subjectID);
        }
        else
        {
            return null;
        }
    }

    public static async Task<bool> DeleteTaskAsync(int taskID)
    {
        return await clsTaskData.DeleteTaskAsync(taskID);
    }
}
