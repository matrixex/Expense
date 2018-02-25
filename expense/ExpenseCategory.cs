using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expense
{
    class ExpenseCategory : List<string>
    {
        private List<string> items;
        public List<string> Items { get { return items; } }
        public ExpenseCategory()
        {

            this.Add("餐饮");
            this.Add("购物");
            this.Add("服饰");
            this.Add("交通");
            this.Add("娱乐");
            this.Add("社交");
            this.Add("居家");
            this.Add("通讯");
            this.Add("零食");
            this.Add("美容");
            this.Add("运动");
            this.Add("旅行");
            this.Add("数码");
            this.Add("学习");
            this.Add("医疗");
            this.Add("书籍");
            this.Add("宠物");
            this.Add("彩票");
            this.Add("汽车");
            this.Add("办公");
            this.Add("住房");
            this.Add("维修");
            this.Add("孩子");
            this.Add("长辈");
            this.Add("礼物");
            this.Add("礼金");
            this.Add("还钱");
            this.Add("捐增");
            this.Add("理财");
            this.Add("其他消费");

        }

    }
}
