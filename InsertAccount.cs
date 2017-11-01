using System;
using System.Data;
using System.Data.SqlClient;

class InsertAccount{
public static void Main()
{
int no;
double bal;
string nm,typ;
SqlConnection scon;
SqlCommand scmd;
SqlDataAdapter sda;
DataSet ds;
try{

Console.WriteLine("Enter Account Number");
no=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter AccountHolder's Name");
nm=Console.ReadLine();
Console.WriteLine("Enter Account Type");
typ=Console.ReadLine();
Console.WriteLine("Enter Balance");
bal=Convert.ToDouble(Console.ReadLine());

scon=new SqlConnection("server=PrachiMishra\\sqlexpress;uid=sa;pwd=microsoft;database=prachidb");

scmd = new SqlCommand("insert into accounts values(@a,@b,@c,@d);",scon);
scmd.Parameters.AddWithValue("a",no);
scmd.Parameters.AddWithValue("b",nm);
scmd.Parameters.AddWithValue("c",typ);
scmd.Parameters.AddWithValue("d",bal);

sda=new SqlDataAdapter(scmd);
ds=new DataSet();
sda.Fill(ds);
Console.WriteLine("Account created successfully");
}
catch(Exception e){
Console.WriteLine(e.Message);
}
}
}