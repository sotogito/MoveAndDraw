using UnityEngine;
using UnityEngine.Events;

//창 collider
public class Canvas2 : MonoBehaviour
{
    public UnityEvent OnEnter;
    public UnityEvent OnExit;

    private void OnTriggerEnter(Collider other)
    {
        //Canvas3에 인스턴스를 변수 currentCollider를 생성하고를 GetComponent로 반환한다. 
        Canvas3.instance.currentCollider = GetComponent<Canvas2>();
        OnEnter.Invoke();
    }

}
