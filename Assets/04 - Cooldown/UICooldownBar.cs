using UnityEngine;
using UnityEngine.UI;

public class UICooldownBar : MonoBehaviour
{
    public Image imageProgress;
    private Animator animator;

    public float Progress
    {
        get => imageProgress.fillAmount;
        set
        {
            imageProgress.fillAmount = value;

            if (imageProgress.fillAmount >= 1)
            {
                animator.Play("Complete");
            }

            imageProgress.enabled = value < 1;
        }
    }

    private void Start()
    {
        animator = GetComponent<Animator>();    
    }
}
