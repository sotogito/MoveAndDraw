using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    
    public float speed;
    float hAxis;
    float vAxis;
    GameObject nearObject;
    Vector3 moveVec;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frameㅑㅑ
    void Update()
    {
        GetInput();
        Move();
        Turn();
        //Interaction();
    

    }

    void GetInput()
    {
        hAxis = Input.GetAxisRaw("Horizontal");
        vAxis = Input.GetAxisRaw("Vertical");

    }
    void Move(){
        moveVec = new Vector3(hAxis,0,vAxis).normalized;
        transform.position += moveVec*speed*Time.deltaTime;
    }
    void Turn(){
        transform.LookAt(transform.position + moveVec);
    }




    /*

    void Interaction()
    {
        //메일 박스에 입장
        //반드시 nearObject의 상태가 null인지 아닌지 조건에 두는게 좋음
        if(nearObject != null && nearObject.tag == "MailBox")
        {
            //만약 player의nearObject(현재의 위치)가 mailbox면 스트립트 mailbox의 enter을 가져온다
            mailbox Mailbox1 = nearObject.GetComponent<mailbox>();
            Mailbox1.Enter(this);
        }
   
    }



    
        //Mailbox 감지하기 (버튼을 띄우기 위한), 현재 위치 알아오기 자세한 동작은 interaction에서
    void OnTriggerStay(Collider other)
    {
        if(other.tag == "MailBox")
        {
            nearObject = other.gameObject;

            Debug.Log("inininininin");
        }
            
    }
    void OnTriggerExit(Collider other)
    {
        //메일 박스에 퇴장
        if(other.tag == "MailBox")
        {
            mailbox Mailbox1 = nearObject.GetComponent<mailbox>();
            Mailbox1.Exit();
            nearObject = null;
            Debug.Log("outoutoutout");
        }
    }
    */






    
    
    


    
    
    


    
     
}
