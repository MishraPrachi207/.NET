using System;
using System.Data;
using System.Data.SqlClient;
class SelectUse{
public static void Main(){
SqlConnection scon;
SqlDataAdapter sda;
DataSet ds;
int cnt,no;
string nm,typ;
double bal;
try
{
scon=new SqlConnection("server=PrachiMishra\\sqlexpress;uid=sa;pwd=microsoft;database=prachidb");
sda= new SqlDataAdapter("select * from accounts;",scon);
ds =new DataSet();
sda.Fill(ds,"acc");
cnt=ds.Tables["acc"].Rows.Count;
Console.WriteLine(cnt);
for(int i=0;i<cnt;i++){
no=Convert.ToInt32(ds.Tables["acc"].Rows[i]["accno"]);
bal=Convert.ToDouble(ds.Tables["acc"].Rows[i]["balance"]);
nm=Convert.ToString(ds.Tables["acc"].Rows[i]["name"]);
typ=Convert.ToString(ds.Tables["acc"].Rows[i]["acctype"]);
Console.WriteLine(no+"\t"+nm+"\t"+typ+"\t"+bal);
}
}
catch(Exception e){
Console.WriteLine(e.Message);
}

}
}