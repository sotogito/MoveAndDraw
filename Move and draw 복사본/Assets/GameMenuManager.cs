using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameMenuManager : MonoBehaviour
{


    //Wold space UI 창에 공통적으로 들어가야함.
    
    public Transform head;
    public float spawnDistance = 2;

    public GameObject menu;
    public InputActionProperty showbutton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    //왼쪽 버튼을 눌렀을 때 나옴(메뉴창이면 될듯 왼손에 고정해두고)
    void Update()
    {
        if(showbutton.action.WasPressedThisFrame())
        {
            menu.SetActive(!menu.activeSelf);

            //사용자 시선 앞에 생김
            menu.transform.position = head.position + new Vector3(head.forward.x , 0 , head.forward.z).normalized * spawnDistance;
        }
        //사용자 눈앞에 생기는 창을 정면으로하게 함 , 근데 반대로 보임
        menu.transform.LookAt(new Vector3 (head.position.x , menu.transform.position.y , head.position.z));
        //그래서 바로 돌려줌 .
        menu.transform.forward *= -1;
    }
}
