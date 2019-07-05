using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TreeNode node3 ;
        public void output(string log)
        {
            //如果日志信息长度超过100行，则自动清空
            if (textBox3.GetLineFromCharIndex(textBox3.Text.Length) > 100)
            {
                textBox3.Text = "";
            }
            //添加日志
            textBox3.AppendText(DateTime.Now.ToString("HH:mm:ss  ") + log + "\r\n");
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int i1 = Convert.ToInt32(textBox1.Text);//获取父节点的个数
            int i2 = Convert.ToInt32(textBox2.Text);
            for (int i = 0; i < i1; ++i)
            {
                TreeNode node1 = treeView1.Nodes.Add("父节点" + (i + 1).ToString());
                output("添加父节点：" + (i + 1).ToString());
                for (int j = 0; j < i2; ++j)
                {
                    TreeNode node2 = new TreeNode("子节点" + (j + 1).ToString());
                    output("添加子节点：" + (j + 1).ToString());
                    node1.Nodes.Add(node2);
                }
            }
          
            /*
                没有显示，迷
                TreeNode A = new TreeNode();
                TreeNode B = new TreeNode();
                A.Nodes.Add(B);
             */
            node3 = treeView1.Nodes.Add("New Node");
            TreeNode C = node3.Nodes.Add("C");

            TreeView P = new TreeView();//新森林的祖宗
            TreeNode Q = P.Nodes.Add("Q");//新森林的祖宗的根节点之一
            TreeNode q = Q.Nodes.Add("q");//新森林的祖宗的根节点的子节点
            /*
                node3.Nodes.Add(Q);
                TreeNode p = Q.Nodes.Add("p");
             *  玩把花的
             *  然后发现 Q节点并没有显示 在node3的子孙节点中，显示的却是 Q的子孙节点
             */
           
            this.Controls.Add(P);//将其添加到窗体

            /*
             * 总结：
             * 1.创建TreeNode的方式：
             * TreeNode A = new TreeNode(string text);
             * 创建一个新的节点，并且 与其他节点没有直接关系
             * 
             * TreeNode A = treeView1.Nodes.Add(string text);
             * 创建一个新的节点，并且 是treeView1控件的子节点 相当于森林中的根节点
             * 
             * TreeNode C = new TreeNode("C");
             * A.Nodes.Add(C);
             * 创建一个新的节点 并且与森林中的根节点A 联系，新节点 C 成为 根节点A 的子孙，
             * 也会在treeView1控件上显示
             * 
             * 2.treeView1的含义
             * 首先 我们都知道 是TreeView 类的实例化对象，而此对象的具体功能也便是 控件的具体功能
             * 在窗体的控件中 有格式的显示，把它看成森林的模板，地基。
             * 
             * 而如何显示？
             * 先创建森林中的根节点，挂在 treeView1 上,注意 要明确节点的类型 TreeNode
             * 格式： TreeNode A = treeView1.Nodes.Add(string text);
             * 
             * 然后在创建 A的子孙 
             * TreeNode a = A.Nodes.Add("string text"); 是不是很像 创建根节点的格式
             * 所以 我们可以更明确 treeView1 的具体含义 ，它就是祖宗！抽象成所有根节点的唯一根节点！
             * 
             * 或者创建 A的同伴
             * TreeNode B = treeView1.Nodes.Add(string text);
             * 在显示时 ， 就成为了第二个根节点 与 A 同级
             * 
             * 试想 treeView1 的类型 ？
             * 我的假设 TreeNode类 是 TreeView类 的派生类。
             * treeView1 同样的具有 TreeNode的功能方法,只不过比TreeNode的优先级更高
             */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //treeView1.Nodes.Clear();
            node3.Nodes.Clear();
            output("删除所有节点");
            
        }

        //清除所选节点
        private void button3_Click(object sender, EventArgs e)
        {
            //删除所选节点
            output("删除所选节点:" + treeView1.SelectedNode.Text);
            treeView1.Nodes.Remove(treeView1.SelectedNode);
            /*
             * 如果调用Remove方法 会删除 该节点 并且 该节点的所有子孙节点 也会被删除。
             */

            //treeView1.SelectedNode.Nodes.Clear();
            //如果调用Clear() 方法，删除清空 是此节点的子孙节点 ，并不 包括该节点
        }

        //需要值得注意的是 该控件 具有很多特色事件，并且 也富有很多乱七八糟的属性
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            output("所选节点为：" + e.Node.Text);
        }
    }
}
