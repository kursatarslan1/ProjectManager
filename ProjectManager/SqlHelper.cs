using ProjectManager.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManager
{
    class SqlHelper
    {
        string connectionString;
        readonly SqlConnection con = new SqlConnection();
        SqlDataReader dr;
        SqlCommand cmd;

        public SqlHelper()
        {
            connectionString = "data source=.;Initial Catalog=Tpm;Integrated Security=True;";
            con.ConnectionString = connectionString;
        }

        public bool Login(User user)
        {
            if(string.IsNullOrEmpty(user.Username) || string.IsNullOrEmpty(user.Password))
            {
                MessageBox.Show("Fields cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                cmd = new SqlCommand("SELECT * FROM users WHERE username=@username and password=@password", con);
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@password", user.Password);

                con.Open();

                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    con.Close();
                    return true;
                }
                else
                {
                    MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                    return false;
                }
            }
        }

        public User GetData(User user)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM employee WHERE username=@username", con);
            cmd.Parameters.AddWithValue("@username", user.Username);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                user.Username = Convert.ToString(dr["Username"]);
                user.Name = Convert.ToString(dr["Name"]);
                user.LastName = Convert.ToString(dr["LastName"]);
                user.Role = Convert.ToString(dr["Role"]);
                user.Explaination = Convert.ToString(dr["Explaination"]);
                user.Birthday = Convert.ToDateTime(dr["Birthday"]);
                user.Photo = (byte[])dr["Photo"];
                user.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
            }
            dr.Close();
            return user;
        }

        public void Create(User user)
        {
            string createQuery = "INSERT INTO employee (username, Name, LastName,Role,Explaination,Birthday,Photo,PhoneNumber) VALUES (@username, @Name, @LastName, @Role, @Explaination, @Birthday, @Photo, @PhoneNumber)";
            string createUserQuery = "INSERT INTO users (username, password) VALUES(@username,@password)";
            SqlCommand cmd = new SqlCommand(createQuery, con);
            SqlCommand cmd2 = new SqlCommand(createUserQuery, con);
            cmd2.Parameters.AddWithValue("@username", user.Username);
            cmd2.Parameters.AddWithValue("@password", "tpm123");
            cmd.Parameters.AddWithValue("@username", user.Username);
            cmd.Parameters.AddWithValue("@Name", user.Name);
            cmd.Parameters.AddWithValue("@LastName", user.LastName);
            cmd.Parameters.AddWithValue("@Role", user.Role);
            cmd.Parameters.AddWithValue("@Explaination", user.Explaination);
            cmd.Parameters.AddWithValue("@Birthday", user.Birthday);
            cmd.Parameters.AddWithValue("@Photo", user.Photo);
            cmd.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber);
            con.Open();
            //try
            //{
            //    cmd.ExecuteNonQuery();
            //    SqlCommand cmnd = new SqlCommand(logQuery, con);
            //    cmnd.Parameters.AddWithValue("IpAddress", GetLocalIPAddress());
            //    cmnd.Parameters.AddWithValue("Process", "Create");
            //    cmnd.Parameters.AddWithValue("ChangeDate", dateTime);
            //    cmnd.Parameters.AddWithValue("Change", people.Id);
            //    cmnd.ExecuteNonQuery();
            //}
            //catch (Exception ex)
            //{
            //    string error = ex.Message;
            //    if (error.Contains("PRIMARY KEY"))
            //        MessageBox.Show("Already Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    else
            //    {
            //        MessageBox.Show("" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    con.Close();
            //}
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            con.Close();
        }

        public List<Tasks> GetTasks(string user)
        {
            con.Close();
            con.Open();
            cmd = new SqlCommand("SELECT * FROM Tasks WHERE TASK_OWNER=@TASK_OWNER AND NOT TASK_STATUS = 'Done'", con);
            cmd.Parameters.AddWithValue("@TASK_OWNER", user);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Tasks> tasks = new List<Tasks>();
            while (dr.Read())
            {
                tasks.Add(new Tasks
                {
                    TaskId = Convert.ToInt32(dr["TASK_ID"]),
                    TaskName = Convert.ToString(dr["TASK_NAME"]),
                    TaskCreateDate = Convert.ToDateTime(dr["TASK_CREATE_DATE"]),
                    TaskAuthor = Convert.ToString(dr["TASK_AUTHOR"]),
                    TaskStatus = Convert.ToString(dr["TASK_STATUS"]),
                    TaskDueDate = Convert.ToDateTime(dr["TASK_DUE_DATE"]),
                    TaskPriority = Convert.ToString(dr["TASK_PRIORITY"]),
                    TaskOwner = Convert.ToString(dr["TASK_OWNER"]),
                    TaskProject = Convert.ToString(dr["TASK_PROJECT"])
                });


            }
            dr.Close();
            con.Close();
            return tasks;
        }

        public List<User> GetUsers()
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM users", con);
            SqlDataReader reader = cmd.ExecuteReader();
            List<User> users = new List<User>();

            while (reader.Read())
            {
                users.Add(new User
                {
                    Username = Convert.ToString(reader["username"])
                });
            }
            con.Close();
            return users;
        }

        public List<Projects> GetProjects()
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM Project", con);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Projects> projects = new List<Projects>();

            while (reader.Read())
            {
                projects.Add(new Projects
                {
                    ProjectName = Convert.ToString(reader["PROJECT_NAME"]),
                    ProjectContent = Convert.ToString(reader["PROJECT_CONTENT"]),
                    TaskCount = Convert.ToInt32(reader["TASK_COUNT"])

                });
            }
            reader.Close();
            con.Close();
            return projects;
        }

        public int GetDoneTasks(string stat)
        {
            int count;
            if (stat == "All")
            {
                con.Open();
                cmd = new SqlCommand("SELECT COUNT(*) FROM Tasks", con);
                count = (int)cmd.ExecuteScalar();
                con.Close();
                return count;
            }
            else
            {
                con.Open();
                cmd = new SqlCommand("SELECT COUNT(*) FROM Tasks WHERE TASK_STATUS = '" + stat + "'", con);
                count = (int)cmd.ExecuteScalar();
                con.Close();
                return count;
            }
            
        }


        public bool CreateTask(Tasks task)
        {
            try
            {
                string createQuery = "INSERT INTO Tasks (TASK_NAME, TASK_CREATE_DATE, TASK_AUTHOR,TASK_STATUS,TASK_DUE_DATE,TASK_PRIORITY,TASK_OWNER,TASK_PROJECT) VALUES (@TASK_NAME, @TASK_CREATE_DATE, @TASK_AUTHOR, @TASK_STATUS, @TASK_DUE_DATE, @TASK_PRIORITY, @TASK_OWNER, @TASK_PROJECT)";
                string projectQuery = "UPDATE Project SET TASK_COUNT = TASK_COUNT + 1 WHERE PROJECT_NAME = @TASK_PROJECT";
                SqlCommand cmd = new SqlCommand(createQuery, con);
                SqlCommand cmd2 = new SqlCommand(projectQuery, con);
                cmd2.Parameters.AddWithValue("@TASK_PROJECT", task.TaskProject);
                cmd.Parameters.AddWithValue("@TASK_NAME", task.TaskName);
                cmd.Parameters.AddWithValue("@TASK_CREATE_DATE", task.TaskCreateDate);
                cmd.Parameters.AddWithValue("@TASK_AUTHOR", task.TaskAuthor);
                cmd.Parameters.AddWithValue("@TASK_STATUS", task.TaskStatus);
                cmd.Parameters.AddWithValue("@TASK_DUE_DATE", task.TaskDueDate);
                cmd.Parameters.AddWithValue("@TASK_PRIORITY", task.TaskPriority);
                cmd.Parameters.AddWithValue("@TASK_OWNER", task.TaskOwner);
                cmd.Parameters.AddWithValue("@TASK_PROJECT", task.TaskProject);
                con.Open();
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Task created Successfully.","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return false;
            }
        }
        public void UpdateTask(Tasks task)
        {
            try
            {
                string query = "UPDATE Tasks SET TASK_NAME=@TASK_NAME, TASK_CREATE_DATE=@TASK_CREATE_DATE, TASK_AUTHOR=@TASK_AUTHOR, TASK_STATUS=@TASK_STATUS, TASK_DUE_DATE=@TASK_DUE_DATE, TASK_PRIORITY=@TASK_PRIORITY, TASK_OWNER=@TASK_OWNER,TASK_PROJECT=@TASK_PROJECT WHERE TASK_ID=@TASK_ID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@TASK_ID", task.TaskId);
                cmd.Parameters.AddWithValue("@TASK_NAME", task.TaskName);
                cmd.Parameters.AddWithValue("@TASK_CREATE_DATE", task.TaskCreateDate);
                cmd.Parameters.AddWithValue("@TASK_AUTHOR", task.TaskAuthor);
                cmd.Parameters.AddWithValue("@TASK_STATUS", task.TaskStatus);
                cmd.Parameters.AddWithValue("@TASK_DUE_DATE", task.TaskDueDate);
                cmd.Parameters.AddWithValue("@TASK_PRIORITY", task.TaskPriority);
                cmd.Parameters.AddWithValue("@TASK_OWNER", task.TaskOwner);
                cmd.Parameters.AddWithValue("@TASK_PROJECT", task.TaskProject);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Task Updated Successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }
        public void DeleteTask(Tasks task)
        {
            try
            {
                string deleteQuery = "DELETE FROM Tasks WHERE TASK_ID = @TASK_ID";
                string projectQuery = "UPDATE Project SET TASK_COUNT = TASK_COUNT - 1 WHERE PROJECT_NAME = @TASK_PROJECT";
                SqlCommand cmd = new SqlCommand(deleteQuery, con);
                SqlCommand cmd2 = new SqlCommand(projectQuery, con);
                cmd.Parameters.AddWithValue("@TASK_ID", task.TaskId);
                cmd2.Parameters.AddWithValue("@TASK_PROJECT", task.TaskProject);
                con.Open();
                cmd2.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Task Deleted Successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        public DataTable LoadData()
        {
            string query = "SELECT * FROM Tasks";
            using (con)
            {
                con.Open();
                using (DataTable dt = new DataTable("task"))
                {
                    SqlDataAdapter adptr = new SqlDataAdapter(query, con);
                    adptr.Fill(dt);
                    con.Close();
                    return dt;
                }
            }
        }

        public void CreateProject(Projects projects)
        {
            string query = "INSERT INTO Project(PROJECT_NAME, TASK_COUNT,PROJECT_CONTENT) VALUES(@PROJECT_NAME, @TASK_COUNT,@PROJECT_CONTENT)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@PROJECT_NAME", projects.ProjectName);
            cmd.Parameters.AddWithValue("@TASK_COUNT", Convert.ToInt32(projects.TaskCount));
            cmd.Parameters.AddWithValue("@PROJECT_CONTENT", projects.ProjectContent);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public Tasks GetTaskDetail(string TaskContent)
        {
            con.Open();
            string query = "SELECT * FROM Tasks WHERE TASK_NAME = @TASK_NAME";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@TASK_NAME", TaskContent);
            SqlDataReader reader = cmd.ExecuteReader();
            Tasks task = new Tasks();
            while (reader.Read())
            {
                task.TaskId = Convert.ToInt32(reader["TASK_ID"]);
                task.TaskName = Convert.ToString(reader["TASK_NAME"]);
                task.TaskCreateDate = Convert.ToDateTime(reader["TASK_CREATE_DATE"]);
                task.TaskAuthor = Convert.ToString(reader["TASK_AUTHOR"]);
                task.TaskStatus = Convert.ToString(reader["TASK_STATUS"]);
                task.TaskDueDate = Convert.ToDateTime(reader["TASK_DUE_DATE"]);
                task.TaskPriority = Convert.ToString(reader["TASK_PRIORITY"]);
                task.TaskOwner = Convert.ToString(reader["TASK_OWNER"]);
                task.TaskProject = Convert.ToString(reader["TASK_PROJECT"]);

            }
            reader.Close();
            cmd.ExecuteNonQuery();
            
            con.Close();
            return task;
        }

    }
}
