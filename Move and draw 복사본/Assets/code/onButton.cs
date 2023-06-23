using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onButton : MonoBehaviour
{
    public GameObject button;

    public void Button_Medium_A_clicked()
    {
        button.SetActive(false);
    }
}
