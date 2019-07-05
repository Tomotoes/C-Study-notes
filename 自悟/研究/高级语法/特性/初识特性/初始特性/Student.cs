using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 初始特性
{
    /// <summary>
    /// 1.什么是 attribute，和注释有什么区别
    /// 2.声明和使用 attribute
    /// 3.一个使用的特性扩展
    /// </summary>
    // [Obsolete("已经过时了！你不能用！", true)]//会报错，报错信息就是 " 已经过时了！你不能用！"
    // [Obsolete("已经过时了！你不能用！")]//会警告，警告信息就是 " 已经过时了！你不能用！",默认是 false，默认警告。
    //[Obsolete]//可以用于升级，提示用户
    //[Obsolete("",true)]
    [Mj("SHAZI", Liulin = "XIAOPIHAI")]
    class Student
    {
        public string Name { get; set; }
    }
}
