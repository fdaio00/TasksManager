using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Threading.Tasks;
using TasksManagerDAL2;

public static class clsSubjectData
{
    private static string connectionString = clsDataAccessSettings.ConnectionString;

    //static clsSubjectData()
    //{
    //    SQLitePCL.Batteries.Init();
    //}

    public static async Task<DataTable> GetAllSubjectsAsync()
    {
        DataTable dt = new DataTable();

        try
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM Subjects", connection))
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
                        clsDataAccessSettings. LogError(ex.Message);
        }

        return dt;
    }

    public static async Task<int> AddNewSubjectAsync(string subjectName, string teacherName)
    {
        try
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string query = "INSERT INTO Subjects (SubjectName, TeacherName) VALUES (@SubjectName, @TeacherName); SELECT last_insert_rowid();";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SubjectName", subjectName);
                    command.Parameters.AddWithValue("@TeacherName", teacherName);

                    await connection.OpenAsync();
                    return Convert.ToInt32(await command.ExecuteScalarAsync());
                }

            }
        }
        catch (Exception ex)
        {
                        clsDataAccessSettings. LogError(ex.Message);
            return -1;
        }
    }

    public static async Task<bool> UpdateSubjectAsync(int subjectID, string subjectName, string teacherName)
    {
        try
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand("UPDATE Subjects SET SubjectName = @SubjectName, TeacherName = @TeacherName WHERE SubjectID = @SubjectID", connection))
            {
                command.Parameters.AddWithValue("@SubjectID", subjectID);
                command.Parameters.AddWithValue("@SubjectName", subjectName);
                command.Parameters.AddWithValue("@TeacherName", teacherName);

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

    public static async Task<bool> DeleteSubjectAsync(int subjectID)
    {
        try
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand("DELETE FROM Subjects WHERE SubjectID = @SubjectID", connection))
            {
                command.Parameters.AddWithValue("@SubjectID", subjectID);

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

    public static bool FindSubjectBySubjectIDAsync(int subjectID, ref string subjectName, ref string teacherName)
    {
        try
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand("SELECT SubjectName, TeacherName FROM Subjects WHERE SubjectID = @SubjectID", connection))
            {
                command.Parameters.AddWithValue("@SubjectID", subjectID);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        subjectName = reader["SubjectName"].ToString();
                        teacherName = reader["TeacherName"].ToString();
                        return true;
                    }
                }
            }
        }
        catch (Exception ex)
        {
                        clsDataAccessSettings. LogError(ex.Message);
        }

        return false;
    }


    public static bool FindSubjectBySubjectNameAsync(string subjectName, ref int subjectID, ref string teacherName)
    {
        try
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand("SELECT SubjectID, TeacherName FROM Subjects WHERE SubjectName = @SubjectName", connection))
            {
                command.Parameters.AddWithValue("@SubjectName", subjectName);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        subjectID = Convert.ToInt32(reader["SubjectID"]);
                        teacherName = reader["TeacherName"].ToString();
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
