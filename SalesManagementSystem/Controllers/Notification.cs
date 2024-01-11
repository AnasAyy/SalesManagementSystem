

using SalesManagementSystem.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SalesManagementSystem.Controllers
{
    internal class Notification
    {
        public static void GetDataForNotificationAsync()
        {
            var db = new DataBaseContext();
            try
            {
                var conn = new SqlConnection(db.Database.Connection.ConnectionString);
                NotificationForm notification = new NotificationForm();
                DataTable dt = new DataTable();
                dt.Clear();

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand comm = new SqlCommand()
                {
                    Connection = conn,
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "GetDataForNotification"
                };

                var reader = comm.ExecuteReader();
                dt.Load(reader);

                if (dt.Rows.Count > 0)
                {
                    notification.Show();
                    notification.dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
