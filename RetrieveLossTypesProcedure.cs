using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;


namespace CrawfordInsuranceClaims
{
    public class RetrieveLossTypesProcedure
    {
        public class LossType
        {
            public int LossTypeID;
            public string LossTypeCode;
            public string LossTypeDescription;

        }

        public List<LossType> FoundTypes;

        public RetrieveLossTypesProcedure()
        {
            FoundTypes = new List<LossType>();
            using (SqlConnection connection = new SqlConnection(Program.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT LossTypeId, LossTypeCode, LossTypeDescription FROM LossTypes"))
                {
                    cmd.Connection = connection;
                    connection.Open();

                    Console.WriteLine("Retrieving all loss types...");
                    SqlDataReader reader = null;
                    try
                    {
                        reader = cmd.ExecuteReader();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception during reader execution: " + e.Message);
                        MessageBox.Show("Unable to retrieve loss types.");
                        return;
                    }

                    using (reader)
                    {
                        if (reader.HasRows)
                        {
                            int i = 0;
                            while (reader.Read()) {
                                try
                                {
                                    LossType loss = new LossType()
                                    {
                                        LossTypeID = reader.GetInt32(0),
                                        LossTypeCode = reader.GetString(1),
                                        LossTypeDescription = reader.GetString(2)
                                    };
                                    FoundTypes.Add(loss);

                                    string descriptionQuestion = loss.LossTypeDescription != null ? "Has" : "Doesn't have a";
                                    Console.WriteLine($"Data[{i}] = Id: {loss.LossTypeID} Code: {loss.LossTypeCode} {descriptionQuestion} Description");
                                    i++;
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine($"Exception happening at Data[{i}]: " + e.Message);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
