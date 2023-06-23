using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mailbox : MonoBehaviour
{
    

    public RectTransform uiGroup;
    public Animator anim;

    //네임스페이스 이름, 사용자 레벨하고 그림 그린 개 수 받아오면 될듯, 여기서 변지 생성할 거니까???
    camera entercamera;

    public Canvas uiCanvas; // UI를 담을 Canvas 객체


    void Start()
    {
        uiCanvas.gameObject.SetActive(false);
    }


    public void Enter()
    {
        uiCanvas.gameObject.SetActive(true);
    }
    public void Exit()
    {
        uiCanvas.gameObject.SetActive(false);
    }


    void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
           Enter();
        }
            
    }
    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
           Exit();
        }
    }


    


    
    

}
