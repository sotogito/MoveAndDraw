using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHandOnInput : MonoBehaviour
{

    //손가락으로 잡기
    public InputActionProperty pinchAnimationAction;
    //잡기
    public InputActionProperty gripAnimationAction;
    //움직임
    public Animator handAnimator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //vr버튼을 할 수 있음
        float triggerValue = pinchAnimationAction.action.ReadValue<float>();
        handAnimator.SetFloat("Trigger",triggerValue);
        //VR기기 버튼을 누르면 값이 나옴
        //Debug.Log(triggerValue);

        float gripValue = gripAnimationAction.action.ReadValue<float>();
        handAnimator.SetFloat("Grip",gripValue);

    }
}
