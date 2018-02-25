using System;
using MySql.Data.MySqlClient;
namespace expense
{
    class SqlOperate
    {
       private  MySqlConnection conn;
       private  MySqlCommand command;
       private  string operate_string;
        //对数据库进行连接
        public MySqlConnection   connect(string servername,string user,string database,string port,string password) {
            this.operate_string = "server="+servername+";user="+user+";database="+database+";port="+port+";password="+password+";";
            using (conn = new MySqlConnection(this.operate_string))
                return conn;
        }
      //对数据库进行数据插入操作
        public MySqlCommand insert(string table_name,string column_1,string column_2,string column_3,string column_4) {
            this.operate_string = "insert into program."+table_name+"(时间,描述, 类别, 金额) values('" + column_1 + "','" + column_2 + "','" + column_3 + "',' " + Decimal.Parse(column_4) + "');";
            command = new MySqlCommand(this.operate_string,conn);
            return command;
        }
        //对数据库进行删除
        public MySqlCommand delete() {


            return command;
        }
        public MySqlCommand  slect() {


            return command;
        }
        public MySqlCommand update() {


            return command;
        }
       





    }
}
