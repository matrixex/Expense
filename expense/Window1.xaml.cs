using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;
using System.Collections.ObjectModel;
using System.Globalization;
namespace expense
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            string[] database = new string[] { "test_db", "expense" };
            cmb.ItemsSource = database;
          

        }
        
        public void UpdateData(DataTable dt,string table_name)
        {
            SqlOperate temp = new SqlOperate();
           // string connect = "server =localhost,user = root,database = program; port = 3306; password = 1234;";
            MySqlConnection conn = temp.connect("localhost","root","program","3306","1234");
                //help.ConnectToSql("localhost", "root", "program", "3306", "1234");
            conn.Open();
            string select_string = "select * from " + table_name;
            MySqlCommand myCommand = new MySqlCommand(select_string, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(myCommand);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);
            DataTable temp_table = new DataTable();
            adapter.Fill(temp_table);
            temp_table = dt;
            adapter.Update(temp_table.GetChanges());
            temp_table.AcceptChanges();
            conn.Close();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

          
            SqlOperate sql = new SqlOperate();
            if (cmb.SelectedItem == null)
            {
                MessageBox.Show("请选择要查询的表");


            }

            else {
                string select = "select * from " + cmb.Text;
                using (MySqlConnection connector = sql.connect("localhost", "root", "program", "3306", "1234"))
                {

                    try
                    {
                        connector.Open();




                        MySqlCommand cmdSel = new MySqlCommand(select, connector);
               
                           
                           
                       // ObservableCollection<Expense> memberData = new ObservableCollection<Expense>();
                            MySqlDataAdapter da = new MySqlDataAdapter(cmdSel);
                            DataSet ds = new DataSet();
                     
                            da.Fill(ds,cmb.Text);
                             
                            DataTable dts = ds.Tables[cmb.Text];
                           
                      
                        // for (int i = 0; i < dts.Rows.Count; i++) {
                        // Expense demon = new Expense();
                        //demon.ID= dts.Rows[i][0].ToString();
                        //.//demon.ComsumeTime = this.Format_time_string(dts.Rows[i][1].ToString());
                        //demon.Describe = dts.Rows[i][2].ToString();
                        //demon.Category= dts.Rows[i][3].ToString();
                        //demon.Money= Decimal.Parse(dts.Rows[i][4].ToString());


                        // memberData.Add(demon);
                        //demon = null;

                        //}
                        //dt.ItemsSource = memberData;

                        dg.ItemsSource = dts.DefaultView;








                    }




                    catch (MySqlException E)
                    {
                        throw new Exception(E.Message);

                    }
                    finally
                    {

                        connector.Close();
                        sql = null;




                    }
                }
            }
            
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow ms = new MainWindow();
            ms.ShowDialog();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            dg.BeginEdit();
            DataTable dts = ((DataView)dg.ItemsSource).Table;
            
            UpdateData(dts,cmb.Text);
            
        }

      
    }
   

}
