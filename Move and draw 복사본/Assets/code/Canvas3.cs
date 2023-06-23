using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvas3 : MonoBehaviour
{
    public static Canvas3 instance;

    [HideInInspector]
    public Canvas2 currentCollider; 

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    private void OnDisable()
    {
        currentCollider.OnExit.Invoke();
    }
    
}
