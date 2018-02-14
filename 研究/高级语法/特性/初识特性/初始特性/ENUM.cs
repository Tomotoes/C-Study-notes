using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 初始特性
{
    public static class RemarkExtention
    {
        // UserState.Deleted.GetRemark("Name")此时，扩展函数的第一个参数默认是 Deleted
        public static string GetRemark(this UserState enumValue, string Name)
        //这个扩展方法的类型 是UserState，所以说 是往 UserState里加了一个方法，
        //其中参数 this UserState enumValue 代表了 此方法调用时的具体发出者，也就是本文中的 Deleted
        //所以说，在调用此方法时，我们不必写出第一个参数，因为第一个参数，是方法的发出者！
        //而在，第二个参数 string Name 变成了 调用扩展方法的第一个参数！且符合 函数调用规则，必须添加！
        {

            /*
             * 通过反射，获取对象
             * 找到 RemarkAttribute
             * 调用GetDeccription方法
             * 返回描述
             */

            //获取 UserState的类型
            Type AC = typeof(UserState);

           //获取当前调用者的类型 别看是一个数组 名字是enumValue.ToString() 只有一个成员，也就是本例中的Deleted
            System.Reflection.MemberInfo[] QWE = AC.GetMember(enumValue.ToString());

            //获取当前调用者的所有特性，也只有一个特性
            object[] ASD = QWE[0].GetCustomAttributes(typeof(RemarkAttribute), true);
            
            return ((RemarkAttribute)ASD[0]).GetDescription();//调用方法

        }

    }
    public class RemarkAttribute : Attribute
    {
        public string Description { get; set; }
        public RemarkAttribute(string description)
        {
            this.Description = description;
        }

        public string GetDescription()
        {
            return this.Description;
        }
    }
    [Remark("错误状态")]
    public enum UserState
    {
        /// <summary>
        /// 正常状态
        /// </summary>
        [Remark("正常状态")]
        Normal = 0,
        /// <summary>
        /// 冻结状态
        /// </summary>
        [Remark("冻结状态")]
        Frozen = 1,
        /// <summary>
        /// 删除状态
        /// </summary>
        [Remark("删除状态")]
        Deleted = 2
    }

}
