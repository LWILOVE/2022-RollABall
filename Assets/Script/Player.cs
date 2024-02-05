using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   //����Unity��UI�����ռ�
public class Player : MonoBehaviour
{
    //��������������
    public Rigidbody rd;
    // Start is called before the first frame update
    //��¼�÷ֵ�ȫ�ֱ���
    public int score = 0;
    //������¼�������ı�������ı�����
    public Text scoreText;
    //�����ж�ʤ�����ı�������屾��
    public GameObject winText;
    void Start()
    {
        //��ʼ����  ֻ����Ϸ��ʼ��ʱ������
        //��������ʼ������
        #region
        //���д����ڿ���̨��ʾ���ԣ�
        //��Unity�Ĵ�ӡ��ʽ��һ���Ǹ�����Ա���˿��ģ����ڼ����󣬲������ҿ�
        //Debug.Log("��Ϸ��ʼ��");
        #endregion  �����ô���Debug
        //���ո������
        rd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //���ڸ��½ű�  ��Ϸ��Ӫʱ�᲻������
        //���д���ͬ������
        //Debug.Log("��Ϸ��������");
        //������ʩ����    Vector3:����3ά����
        //������С��������˶���Ĭ���Ǵ�С��1N
        //
        //rd.AddForce( new Vector3(10,0,0));

        //����̽��н���
        //�õ�һ��С��
        //GetAxis��������ÿ����������һ������
        //Ĭ�Ϸ���ֵ��0
        //Horizontal: ����ˮƽ����Ĵ���  AD
        //����A�Ǵ�0��-1���ɿ��ʹ�-1���0
        //A��D�෴��D�Ǵ�0��1 
        //Vertical:������ֱ����Ĵ���  WS
        //����W��0-1  S��0-��-1��
        //�����������÷�����������Ҵ���
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        //��h��ʾ�ڿ���̨��
        //Debug.Log(h);
        //��������˶�
        rd.AddForce(new Vector3(h,0,v)*2    );

    }
    //������ײ����ϵͳ�¼�
    //ϵͳ�¼����൱��ϵͳ��Ϣ
    //��������ײʱ��ִ�д���
    //private void OnCollisionEnter(Collision collision)
    //{
    //    //������������ײ��Ϣ
    //    //collider:��ײ��
    //    //gameObject:��Ϸ����
    //    //tag:��ǩ
    //    //����������ͬ    
    //    //ͨ�������ñ�ǩ
    //    //collision.collider.tag
    //    //ͨ����Ϸ�����ȡ��ǩ
    //    if (collision.gameObject.tag == "Food")
    //    {
    //        //���ٱ�����������
    //        Destroy(collision.gameObject);
    //        //���ٱ��������������ײ�����
    //        //Destroy(collision.collider);
    //    }
    //}
    ////����ײ����ʱִ�д���
    //private void OnCollisionExit(Collision collision)
    //{

    //}
    ////ֻҪ�Ӵ��ͻ�ִ�У���һֱ�Ӵ�һֱִ��
    //private void OnCollisionStay(Collision collision)
    //{

    //}

    //������������ϵͳ�¼�
    //��Ϊ���봥�����򷢶��⣬������ͬ
    //stay �ڴ��������ڳ�������  enter����ʱ���� exit��ȥʱ����
    private void OnTriggerEnter(Collider other)
    {
        //��������ײ��   
        if (other.tag == "Food")
        {
            //���ٱ����뵽�������������
            Destroy(other.gameObject);
            //���ٱ��������������ײ�����
            //Destroy(collision.collider);
            //�Ե�ʳ��ӷ�
            score++;
            //����UI��ʾ,ʹ�ı������ʾ����
            scoreText.text = "������"+score;

            if (score == 5)
            {
                //����Ϸ�ﵽҪ��ʱ������ʤ������ 
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
