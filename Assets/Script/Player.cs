using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   //引入Unity的UI命名空间
public class Player : MonoBehaviour
{
    //创建刚体接收组件
    public Rigidbody rd;
    // Start is called before the first frame update
    //记录得分的全局变量
    public int score = 0;
    //创建记录分数的文本组件的文本部分
    public Text scoreText;
    //创建判断胜利的文本组件物体本身
    public GameObject winText;
    void Start()
    {
        //开始方法  只有游戏初始化时会运行
        //用于做初始化工作
        #region
        //下行代码在控制台显示语言，
        //即Unity的打印方式，一般是给程序员本人看的，用于检查错误，不会给玩家看
        //Debug.Log("游戏开始了");
        #endregion  测试用代码Debug
        //接收刚体组件
        rd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //用于更新脚本  游戏运营时会不断运行
        //下行代码同上意义
        //Debug.Log("游戏正在运行");
        //给刚体施加力    Vector3:创建3维向量
        //创建后小球会向右运动，默认是大小是1N
        //
        //rd.AddForce( new Vector3(10,0,0));

        //与键盘进行交互
        //得到一个小数
        //GetAxis：键盘上每个键都代表一定的数
        //默认返回值是0
        //Horizontal: 控制水平方向的代码  AD
        //按下A是从0到-1，松开就从-1变回0
        //A和D相反，D是从0到1 
        //Vertical:控制竖直方向的代码  WS
        //按下W是0-1  S是0-（-1）
        //两个都可以用方向键上下左右代替
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        //将h显示在控制台上
        //Debug.Log(h);
        //控制球的运动
        rd.AddForce(new Vector3(h,0,v)*2    );

    }
    //创建碰撞检测的系统事件
    //系统事件：相当于系统信息
    //当发生碰撞时会执行代码
    //private void OnCollisionEnter(Collision collision)
    //{
    //    //参数：保存碰撞信息
    //    //collider:碰撞器
    //    //gameObject:游戏物体
    //    //tag:标签
    //    //上下意义相同    
    //    //通过组件获得标签
    //    //collision.collider.tag
    //    //通过游戏物体获取标签
    //    if (collision.gameObject.tag == "Food")
    //    {
    //        //销毁被碰到的物体
    //        Destroy(collision.gameObject);
    //        //销毁被碰到的物体的碰撞器组件
    //        //Destroy(collision.collider);
    //    }
    //}
    ////当碰撞结束时执行代码
    //private void OnCollisionExit(Collision collision)
    //{

    //}
    ////只要接触就会执行，且一直接触一直执行
    //private void OnCollisionStay(Collision collision)
    //{

    //}

    //创建触发检测的系统事件
    //除为进入触发区域发动外，其余相同
    //stay 在触发区域内持续发动  enter进入时发动 exit出去时发动
    private void OnTriggerEnter(Collider other)
    {
        //参数：碰撞器   
        if (other.tag == "Food")
        {
            //销毁被进入到触发区域的物体
            Destroy(other.gameObject);
            //销毁被碰到的物体的碰撞器组件
            //Destroy(collision.collider);
            //吃到食物加分
            score++;
            //更新UI显示,使文苯组件显示分数
            scoreText.text = "分数："+score;

            if (score == 5)
            {
                //当游戏达到要求时，激活胜利物体 
                winText.SetActive(true);
            }
        }
    }

    //private void OnTriggerExit(Collider other)
    //{
    //}

    //private void OnTriggerStay(Collider other)
    //{
    //}
}
