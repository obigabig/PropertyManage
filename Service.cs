using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManager
{
    public class Service
    {
        static string text = System.IO.File.ReadAllText(@"C:\AssetConnect.txt");
        static string backup_text = System.IO.File.ReadAllText(@"C:\backupAsset.txt");
        public SqlConnection con = new SqlConnection(text);
        public SqlCommand cmd = new SqlCommand();

        public bool insertContract(Contract contract)
        {
            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(text))
            {
                using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand())
                {
                    cmd.Connection = con;
                    con.Open();

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "spInsertContract";
                    cmd.Parameters.AddWithValue("@id", contract.ContractID);
                    cmd.Parameters.AddWithValue("@Title", contract.Title);
                    cmd.Parameters.AddWithValue("@ContractDate", contract.ContractDate);
                    cmd.Parameters.AddWithValue("@Value", contract.TotalValue);
                    cmd.Parameters.AddWithValue("@StatusID", contract.StatusID);
                    cmd.Parameters.AddWithValue("@ContractTypeId", contract.ContracTypeID);
                    cmd.Parameters.AddWithValue("@ActiveFlag", 'A');
                    cmd.Parameters.AddWithValue("@SignCount", contract.SignCount);

                    IAsyncResult result = cmd.BeginExecuteNonQuery();
                    cmd.EndExecuteNonQuery(result);
                    con.Close();
                    return result.IsCompleted;
                }
            }
        }

        public bool insertContractDate(ContractDate contractDate)
        {
            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(text))
            {
                using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand())
                {
                    cmd.Connection = con;
                    con.Open();

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "spInsertContractDate";
                    cmd.Parameters.AddWithValue("@ContractId", contractDate.ContractID);
                    cmd.Parameters.AddWithValue("@No", contractDate.No); 
                    if (contractDate.RedeemDate == null){
                        cmd.Parameters.AddWithValue("@RedeemDate", DBNull.Value);
                    }
                    else{
                        cmd.Parameters.AddWithValue("@RedeemDate", contractDate.RedeemDate);
                    }
                    if (contractDate.SignDate == null)
                    {
                        cmd.Parameters.AddWithValue("@SignDate", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@SignDate", contractDate.SignDate);
                    }


                    IAsyncResult result = cmd.BeginExecuteNonQuery();
                    cmd.EndExecuteNonQuery(result);
                    con.Close();
                    return result.IsCompleted;
                }
            }
        }

        public bool insertContractMember(ContractMember contractMember)
        {
            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(text))
            {
                using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand())
                {
                    cmd.Connection = con;
                    con.Open();

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "spInsertContractMember";
                    cmd.Parameters.AddWithValue("@CONTRACTID", contractMember.ContractID);
                    cmd.Parameters.AddWithValue("@MEMBERID", contractMember.MemberID);
                    cmd.Parameters.AddWithValue("@VALUE", contractMember.Value);

                    IAsyncResult result = cmd.BeginExecuteNonQuery();
                    cmd.EndExecuteNonQuery(result);
                    con.Close();
                    return result.IsCompleted;
                }
            }
        }

        public bool UpdateContract(Contract contract)
        {
            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(text))
            {
                using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand())
                {
                    cmd.Connection = con;
                    con.Open();

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "spUpdateContract";
                    cmd.Parameters.AddWithValue("@id", contract.ContractID);
                    cmd.Parameters.AddWithValue("@Title", contract.Title);
                    cmd.Parameters.AddWithValue("@ContractDate", contract.ContractDate);
                    cmd.Parameters.AddWithValue("@Value", contract.TotalValue);
                    cmd.Parameters.AddWithValue("@StatusID", contract.StatusID);
                    cmd.Parameters.AddWithValue("@ContractTypeId", contract.ContracTypeID);
                    cmd.Parameters.AddWithValue("@ActiveFlag", 'A');
                    cmd.Parameters.AddWithValue("@SignCount", contract.SignCount);

                    IAsyncResult result = cmd.BeginExecuteNonQuery();
                    cmd.EndExecuteNonQuery(result);
                    con.Close();
                    return result.IsCompleted;
                }
            }
        }

        public bool InsertContract(Contract Contract)
        {
            return insertContract(Contract);
        }

        public bool InsertContractDate(ContractDate ContractDate)
        {
            return insertContractDate(ContractDate);
        }

        public bool InsertContractMember(ContractMember ContractMember)
        {
            return insertContractMember(ContractMember);
        }

       
        public bool deleteContract(int id)
        {
            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(text))
            {
                using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand())
                {
                    cmd.Connection = con;
                    con.Open();

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "spDeleteContract";
                    cmd.Parameters.AddWithValue("@id", id);

                    IAsyncResult result = cmd.BeginExecuteNonQuery();
                    cmd.EndExecuteNonQuery(result);
                    con.Close();
                    return result.IsCompleted;
                }
            }
        }

        public bool deleteContractDate(int id)
        {
            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(text))
            {
                using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand())
                {
                    cmd.Connection = con;
                    con.Open();

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "spDeleteContractDate";
                    cmd.Parameters.AddWithValue("@id", id);

                    IAsyncResult result = cmd.BeginExecuteNonQuery();
                    cmd.EndExecuteNonQuery(result);
                    con.Close();
                    return result.IsCompleted;
                }
            }
        }

        public bool deleteContractMember(int id)
        {
            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(text))
            {
                using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand())
                {
                    cmd.Connection = con;
                    con.Open();

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "spDeleteContractMember";
                    cmd.Parameters.AddWithValue("@id", id);

                    IAsyncResult result = cmd.BeginExecuteNonQuery();
                    cmd.EndExecuteNonQuery(result);
                    con.Close();
                    return result.IsCompleted;
                }
            }
        }

        public bool updateContractStatus(int id)
        {
            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(text))
            {
                using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand())
                {
                    cmd.Connection = con;
                    con.Open();

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "spUpdateContractStatus";
                    cmd.Parameters.AddWithValue("@id", id);

                    IAsyncResult result = cmd.BeginExecuteNonQuery();
                    cmd.EndExecuteNonQuery(result);
                    con.Close();
                    return result.IsCompleted;
                }
            }

        }

        public DataTable getAllContract()
        {
            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(text))
            {
                using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand())
                {
                    cmd.CommandText = "spGetAllContract";
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    System.Data.SqlClient.SqlDataAdapter adapter = new System.Data.SqlClient.SqlDataAdapter(cmd);

                    DataTable dt = new DataTable("Contract");
                    adapter.Fill(dt);

                    conn.Close();
                    return dt;
                }
            }
        }

        public DataTable getAllContractMember()
        {
            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(text))
            {
                using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand())
                {
                    cmd.CommandText = "spGetMemberDetail";
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    System.Data.SqlClient.SqlDataAdapter adapter = new System.Data.SqlClient.SqlDataAdapter(cmd);

                    DataTable dt = new DataTable("ContractMember");
                    adapter.Fill(dt);

                    conn.Close();
                    return dt;
                }
            }
        }

        public DataTable getAllContractDate()
        {
            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(text))
            {
                using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand())
                {
                    cmd.CommandText = "spGetContractDateDetail";
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    System.Data.SqlClient.SqlDataAdapter adapter = new System.Data.SqlClient.SqlDataAdapter(cmd);

                    DataTable dt = new DataTable("ContractDate");
                    adapter.Fill(dt);

                    conn.Close();
                    return dt;
                }
            }
        }

        public DataTable getAllMember()
        {
            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(text))
            {
                using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand())
                {
                    cmd.CommandText = "spGetAllMember";
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    System.Data.SqlClient.SqlDataAdapter adapter = new System.Data.SqlClient.SqlDataAdapter(cmd);

                    DataTable dt = new DataTable("Member");
                    adapter.Fill(dt);

                    conn.Close();
                    return dt;
                }
            }
        }

        public DataTable getStatus()
        {
            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(text))
            {
                using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand())
                {
                    cmd.CommandText = "spGetStatus";
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    System.Data.SqlClient.SqlDataAdapter adapter = new System.Data.SqlClient.SqlDataAdapter(cmd);

                    DataTable dt = new DataTable("Status");
                    adapter.Fill(dt);

                    conn.Close();
                    return dt;
                }
            }
        }

        public DataTable getAssetType()
        {
            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(text))
            {
                using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand())
                {
                    cmd.CommandText = "spGetAssetType";
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    System.Data.SqlClient.SqlDataAdapter adapter = new System.Data.SqlClient.SqlDataAdapter(cmd);

                    DataTable dt = new DataTable("AssetType");
                    adapter.Fill(dt);

                    conn.Close();
                    return dt;
                }
            }
        }

        public DataTable getContractType()
        {
            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(text))
            {
                using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand())
                {
                    cmd.CommandText = "spGetContractType";
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    System.Data.SqlClient.SqlDataAdapter adapter = new System.Data.SqlClient.SqlDataAdapter(cmd);

                    DataTable dt = new DataTable("ContractType");
                    adapter.Fill(dt);

                    conn.Close();
                    return dt;
                }
            }
        }

        public DataTable getLastContractID()
        {
            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(text))
            {
                using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand())
                {
                    cmd.CommandText = "spGetLastestID";
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    System.Data.SqlClient.SqlDataAdapter adapter = new System.Data.SqlClient.SqlDataAdapter(cmd);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    conn.Close();
                    return dt;
                }
            }
        }

        public DataTable getContractbyId(int id)
        {
            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(text))
            {
                using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand())
                {
                    cmd.CommandText = "spGetContractbyId";
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id);
                    conn.Open();

                    System.Data.SqlClient.SqlDataAdapter adapter = new System.Data.SqlClient.SqlDataAdapter(cmd);

                    DataTable dt = new DataTable("Contract");
                    adapter.Fill(dt);

                    conn.Close();
                    return dt;
                }
            }
        }

        public DataTable getContractDatebyId(int id)
        {
            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(text))
            {
                using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand())
                {
                    cmd.CommandText = "spGetContractDatebyId";
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id);
                    conn.Open();

                    System.Data.SqlClient.SqlDataAdapter adapter = new System.Data.SqlClient.SqlDataAdapter(cmd);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    conn.Close();
                    return dt;
                }
            }
        }

        public DataTable getContractMemberbyId(int id)
        {
            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(text))
            {
                using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand())
                {
                    cmd.CommandText = "spGetContractMemberbyId";
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id);
                    conn.Open();

                    System.Data.SqlClient.SqlDataAdapter adapter = new System.Data.SqlClient.SqlDataAdapter(cmd);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    conn.Close();
                    return dt;
                }
            }
        }

        public DataTable getSummaryMemberValue()
        {
            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(text))
            {
                using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand())
                {
                    cmd.CommandText = "spGetSummaryMemberValue";
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    System.Data.SqlClient.SqlDataAdapter adapter = new System.Data.SqlClient.SqlDataAdapter(cmd);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    conn.Close();
                    return dt;
                }
            }
        }

        public DataTable getSignDateAlert()
        {
            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(text))
            {
                using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand())
                {
                    cmd.CommandText = "spGetSignDateAlert";
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    System.Data.SqlClient.SqlDataAdapter adapter = new System.Data.SqlClient.SqlDataAdapter(cmd);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    conn.Close();
                    return dt;
                }
            }
        }

        public bool dbFullBackUp()
        {
            //con is the connection string
            con.Open();
            string str = "USE ASSETMANAGER;";
            string str1 = backup_text;
            SqlCommand cmd1 = new SqlCommand(str, con);
            SqlCommand cmd2 = new SqlCommand(str1, con);
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();

            con.Close();
            return true;
        }
        
    }
}
