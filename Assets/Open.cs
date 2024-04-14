using UnityEngine;

public class Open : StateMachineBehaviour
{
    public Animator doorAnimator; 
    private bool keyDestroyed = false; 

    void Update()
    {
        if (!keyDestroyed)
        {
            GameObject key = GameObject.FindGameObjectWithTag("Key");
            if (key == null)
            {
                keyDestroyed = true;
              
                if (doorAnimator != null)
                {
                    doorAnimator.SetTrigger("Open");
                }
            }
        }
    }

}
