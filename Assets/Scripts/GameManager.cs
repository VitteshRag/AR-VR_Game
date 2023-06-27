using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Animator fanAC, fanAC2;

    public void FanCtrl(string sts)
    {
        if (sts == "On")
        {
            if (fanAC.GetCurrentAnimatorStateInfo(0).IsName("Idle") && fanAC2.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
            {
                fanAC.SetTrigger(sts);
                fanAC2.SetTrigger(sts);
            }

        }
        else if (sts == "Off")
        {
            if (fanAC.GetCurrentAnimatorStateInfo(0).IsName("Anim") && fanAC2.GetCurrentAnimatorStateInfo(0).IsName("Anim"))
            {
                fanAC.SetTrigger(sts);
                fanAC2.SetTrigger(sts);
            }
        }
    }
}