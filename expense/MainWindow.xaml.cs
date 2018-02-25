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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
using System.Windows.Forms.DataVisualization;
using System.Globalization;
namespace expense
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
            string[] expense_category = new string[] { "餐饮", "购物", "服饰", "交通", "娱乐", "通讯", "社交", "居家", "零食", "美容", "运动", "旅行", "数码", "学习", "医疗", "书籍","宠物","彩票","汽车","办公","住房","维修","孩子","长辈","礼物","礼金","还钱","捐增","理财","其他消费"};
            string[] table_name = new string[] { "test_db","expense"};
            cmb.ItemsSource = expense_category;
            table_select.ItemsSource = table_name;
           
        }
        public void clear_all_content() {
            date_picker.Text = null;
            describe.Clear();
            cmb.Text = null;
            money.Clear();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {



            // DateTime dt=Convert.ToDateTime(date_picker.Text);
            //String format = "yyyy-MM-dd";
            //String date;
            //date = dt.ToString(format, DateTimeFormatInfo.InvariantInfo);
            /*上面的注释是对日期进行格式化*/
            if (cmb.SelectedItem == null || date_picker.SelectedDate == null)
                MessageBox.Show("你有数据没有选择好.");
            else
            {
                SqlOperate sql = new SqlOperate();
                using (MySqlConnection connector = sql.connect("localhost", "root", "program", "3306", "1234"))
                {

                    try
                    {
                        connector.Open();
                        MySqlCommand insert_table = sql.insert(table_select.Text, date_picker.Text, describe.Text, cmb.Text, money.Text);
                        if (insert_table.ExecuteNonQuery() > 0)
                            MessageBox.Show("插入成功");

                    }
                    catch (MySqlException E)
                    {
                        throw new Exception(E.Message);

                    }
                    finally
                    {

                        connector.Close();
                        sql = null;
                        clear_all_content();



                    }
                }
            }


            }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window1 nf = new Window1();
            nf.ShowDialog();
            this.Close();
        }
    }

   }
  