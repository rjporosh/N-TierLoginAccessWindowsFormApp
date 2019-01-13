using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using BEL;
using System.Data;
using System.Data.SqlClient;

namespace BAL
{
    public class Operations
    {
        public Dbconnection db = new Dbconnection();
        public Informations info = new Informations();
        // here we declare the queries and db operations needed for the application


        public int insertEmp(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO empRegister VALUES ('"+info.name+"','"+info.gender+"','"+info.dob+"','"+info.address+"','"+info.education+"','"+info.username+"','"+info.password+"','U')";
            return db.ExeNonQuery(cmd);
        }

        public DataTable login(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from empRegister where Username='"+info.username+"' and Password='"+info.password+"'";
            return db.ExeReader(cmd);
        }

        public DataTable viewemployees(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from empRegister where usertype='U'";
            return db.ExeReader(cmd);
           
        }
    }
}
