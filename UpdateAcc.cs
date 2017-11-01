using System;
using System.Data;
using System.Data.SqlClient;

class UpdateAcc{
public static void Main(){
SqlConnection scon;
SqlDataAdapter sda;
DataSet ds;

scon=new SqlConnection("server=PrachiMishra\\sqlexpress;uid=sa;pwd=microsoft;database=prachidb");
sda= new SqlDataAdapter("exec updbalance;",scon);
ds =new DataSet();
sda.Fill(ds);
Console.WriteLine("Account Updated Successfully");

}
}