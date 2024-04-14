using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate : MonoBehaviour
{
    public Animator myAnimator;
    private bool keyCollected = false;
    void Update()
    {
        if (keyCollected)
        {
            myAnimator.SetTrigger("Activate");
        }
    }
    public void CollectKey()
    {
        keyCollected = true;
    }
}
