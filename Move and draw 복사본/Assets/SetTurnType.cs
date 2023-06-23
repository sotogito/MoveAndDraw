using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SetTurnType : MonoBehaviour
{
    public ActionBasedSnapTurnProvider snapTurn;
    public ActionBasedContinuousTurnProvider continuousTurn;

    public void SetTypeFromIndex(int index)
    {
        if(index == 0)
        {
            //게임 사용 설정임. snapTurn은 뚝뚝 끊기면서 continuousTurn은 부드럽게
            snapTurn.enabled = false;
            continuousTurn.enabled = true;
        }
        else if(index == 1)
        {
            snapTurn.enabled = true;
            continuousTurn.enabled = false;
        }
    }

}
