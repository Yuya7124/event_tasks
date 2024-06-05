using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Tasks.task_lists
{

    internal class tasks_db
    {
        string connectString = "Data Source=WIN-DN6B589V2SO\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
        
        private void database_insert()
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                try
                {
                    // データベース接続開始
                    connection.Open();

                    var query = String.Format("INSERT INTO [dbo].[task] ([id], [user_id], [task_title], [due_date], [priority]) VALUES ('{0}','{1}','{2}','{3}')");
                    using (var transaction = connection.BeginTransaction())
                    using (SqlCommand cmd = new SqlCommand() { Connection = connection, Transaction = transaction })
                    {
                        // データベースコマンドセット
                        try
                        {
                            // コマンドセット
                            cmd.CommandText = query;
                            // コマンド実行
                            cmd.ExecuteNonQuery();
                            // コミット
                            transaction.Commit();
                        }
                        catch
                        {
                            // ロールバック
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }
                finally
                {
                    // データベース接続終了
                    connection.Close();
                }
            }
        }
    }
}
