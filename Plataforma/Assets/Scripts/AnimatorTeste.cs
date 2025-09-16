using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorTeste : MonoBehaviour
{
    public Animator animator;

    public KeyCode KeyToTrigger = KeyCode.A;
    public KeyCode KeyToExit = KeyCode.S;
    public string triggerToPlay = "Fly";

    private void OnValidate()
    {
        if (animator = null) animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyToTrigger))
        {
            animator.SetBool(triggerToPlay, !animator.GetBool(triggerToPlay));
          
        }
        
    }

}
