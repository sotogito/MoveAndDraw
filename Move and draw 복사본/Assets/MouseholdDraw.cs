using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class MouseholdDraw : MonoBehaviour
{
    /*
    public GameObject Drawer; 
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    
    
    void Update()
    {

        //그림그리는 씬  이 분 VR 기기 Trgger로 변견한면 됨
        //기존에 있던 VR Toolkit 도 되는데 오큘러스 사용할거면 오큘러스 명령어 쓰면 됨
    
        if(Input.GetMouseButtonDown(0))
        {
            Drawer.GetComponent<TrailRenderer>().emitting = true;
        }
        if(Input.GetMouseButtonUp(0))
        {
            Drawer.GetComponent<TrailRenderer>().emitting = false;
        }
    }
    */

    public GameObject Drawer;
    // Start is called before the first frame update

    private XRController controller;
    void Start()
    {
        controller = GetComponent<XRController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Drawer.GetComponent<TrailRenderer>().emitting = true;
        }
        if(Input.GetButtonUp("Fire1"))
        {
            Drawer.GetComponent<TrailRenderer>().emitting = false;
        }
    }


}

