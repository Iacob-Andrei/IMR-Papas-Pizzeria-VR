using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightHandAnimator : MonoBehaviour
{
    private Animator handAnimator;
    void Start()
    {
        handAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        if (handAnimator != null)
        {
            if (Input.GetKeyDown(KeyCode.G))
            {
                if( !handAnimator.GetCurrentAnimatorStateInfo(0).IsName("CloseHand"))
                    handAnimator.SetTrigger("TrClose");
            }
            else if (Input.GetKeyUp(KeyCode.G))
            {
                handAnimator.SetTrigger("TrOpen");
            }
        }
    }
}
