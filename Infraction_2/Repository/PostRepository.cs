using Infraction_2.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Infraction_2.Repository
{
    public class PostRepository
    {
        private SqlConnection con;    
   //To Handle connection related activities    
    private void connection()
    {    
       string constr = ConfigurationManager.ConnectionStrings["master"].ToString();    
        con = new SqlConnection(constr);    
  
    }

        public bool AddPost(PostModel obj)
        {

            connection();
            SqlCommand com = new SqlCommand("AddNewPostDetails", con);
            com.CommandType = CommandType.StoredProcedure;
           
            com.Parameters.AddWithValue("@Title", obj.Title);
            com.Parameters.AddWithValue("@Tags", obj.Tags);
            com.Parameters.AddWithValue("@Subject", obj.Subject);

            con.Open();
            int i = com.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {

                return true;

            }
            else
            {

                return false;
            }


        }

        //To view employee details with generic list     
    public List<PostModel> GetAllPost()
    {    
        connection();    
        List<PostModel> PostList = new List<PostModel>();    
           
  
        SqlCommand com = new SqlCommand("GetPost", con);    
        com.CommandType = CommandType.StoredProcedure;    
        SqlDataAdapter da = new SqlDataAdapter(com);    
        DataTable dt = new DataTable();    
          
        con.Open();    
       da.Fill(dt);    
        con.Close();    
        //Bind EmpModel generic list using dataRow     
        foreach (DataRow dr in dt.Rows)    
        {    
  
            PostList.Add(    
  
                new PostModel {    
  
                    Title =Convert.ToString( dr["Title"]),    
                    Tags = Convert.ToString( dr["Tags"]),    
                    Subject = Convert.ToString(dr["Subject"])    
  
                }    
                    
                    
                );    
  
  
        }    
  
        return PostList;    
  
  
    }    


    }
}