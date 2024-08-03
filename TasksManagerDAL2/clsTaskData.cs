using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Threading.Tasks;
using TasksManagerDAL2;

public static class clsTaskData
{
    private static string connectionString = clsDataAccessSettings.ConnectionString;

    //static clsTaskData()
    //{
    //    SQLitePCL.Batteries.Init();
    //}


    public static async Task<DataTable> GetAllTasksAsync()
    {
        DataTable dt = new DataTable();

        try
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM Tasks", connection))
            {
                await connection.OpenAsync();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (reader.HasRows)
                    {
                        dt.Load(reader);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            clsDataAccessSettings  . LogError(ex.Message);
        }

        return dt;
    }

    public static async Task<int> AddNewTaskAsync(string taskTitle, string taskDetails, DateTime taskDate, DateTime dueDate, string notes, int taskType, int subjectID)
    {
        const string query = @"
        INSERT INTO Tasks (TaskTitle, TaskDetails, TaskDate, DueDate, Notes, TaskType, SubjectID) 
        VALUES (@TaskTitle, @TaskDetails, @TaskDate, @DueDate, @Notes, @TaskType, @SubjectID); 
        SELECT last_insert_rowid();";

        try
        {
            using (var connection = new SQLiteConnection(connectionString))
            using (var command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@TaskTitle", taskTitle);
                command.Parameters.AddWithValue("@TaskDetails", taskDetails);
                command.Parameters.AddWithValue("@TaskDate", taskDate);
                command.Parameters.AddWithValue("@DueDate", dueDate);
                command.Parameters.AddWithValue("@Notes", notes);
                command.Parameters.AddWithValue("@TaskType", taskType);
                command.Parameters.AddWithValue("@SubjectID", subjectID);

                await connection.OpenAsync();
                return Convert.ToInt32(await command.ExecuteScalarAsync());
            }
        }
        catch (Exception ex)
        {
            clsDataAccessSettings.LogError(ex.Message);
            return -1;
        }
    }

    public static async Task<bool> UpdateTaskAsync(int taskID, string taskTitle, string taskDetails, DateTime taskDate, DateTime dueDate, string notes, int taskType, int subjectID)
    {
        const string query = @"
        UPDATE Tasks 
        SET TaskTitle = @TaskTitle, 
        TaskDetails = @TaskDetails, 
        TaskDate = @TaskDate,
        DueDate = @DueDate, 
        Notes = @Notes, 
        TaskType = @TaskType, 
        SubjectID = @SubjectID 
        WHERE TaskID = @TaskID";

        try
        {
            using (var connection = new SQLiteConnection(connectionString))
            using (var command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@TaskID", taskID);
                command.Parameters.AddWithValue("@TaskTitle", taskTitle);
                command.Parameters.AddWithValue("@TaskDetails", taskDetails);
                command.Parameters.AddWithValue("@TaskDate", taskDate);
                command.Parameters.AddWithValue("@DueDate", dueDate);
                command.Parameters.AddWithValue("@Notes", notes);
                command.Parameters.AddWithValue("@TaskType", taskType);
                command.Parameters.AddWithValue("@SubjectID", subjectID);

                await connection.OpenAsync();
                int rowsAffected = await command.ExecuteNonQueryAsync();
                return (rowsAffected > 0);
            }
        }
        catch (Exception ex)
        {
            clsDataAccessSettings.LogError(ex.Message);
            return false;
        }
    }

    public static async Task<bool> DeleteTaskAsync(int taskID)
    {
        try
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand("DELETE FROM Tasks WHERE TaskID = @TaskID", connection))
            {
                command.Parameters.AddWithValue("@TaskID", taskID);

                await connection.OpenAsync();
                int rowsAffected = await command.ExecuteNonQueryAsync();
                return (rowsAffected > 0);
            }
        }
        catch (Exception ex)
        {
                        clsDataAccessSettings. LogError(ex.Message);
            return false;
        }
    }

    public static  bool FindTaskByTaskIDAsync(int taskID, ref string taskTitle, ref string taskDetails, ref DateTime taskDate, ref DateTime dueDate, ref string notes, ref int taskType, ref int subjectID)
    {
        const string query = @"
        SELECT TaskTitle, TaskDetails, TaskDate, DueDate, Notes, TaskType, SubjectID 
        FROM Tasks 
        WHERE TaskID = @TaskID";

        try
        {
            using (var connection = new SQLiteConnection(connectionString))
            using (var command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@TaskID", taskID);

                 connection.Open();
                using (SQLiteDataReader reader =  command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        taskTitle = reader["TaskTitle"].ToString();
                        taskDetails = reader["TaskDetails"].ToString();
                        taskDate = Convert.ToDateTime(reader["TaskDate"]);
                        dueDate = Convert.ToDateTime(reader["DueDate"]);
                        notes = reader["Notes"].ToString();
                        taskType = Convert.ToInt32(reader["TaskType"]);
                        subjectID = Convert.ToInt32(reader["SubjectID"]);
                        return true;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            clsDataAccessSettings.LogError(ex.Message);
        }

        return false;
    }

}
