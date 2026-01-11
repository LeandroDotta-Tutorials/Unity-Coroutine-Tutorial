using System.Collections;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();

        StartCoroutine(nameof(BombCoroutine));
    }

    private IEnumerator BombCoroutine()
    {
        animator.Play("Idle");
        yield return new WaitForSeconds(4);
        animator.Play("PulseWeak");
        yield return new WaitForSeconds(2);
        animator.Play("PulseStrong");
        yield return new WaitForSeconds(1);
        animator.Play("Explode");
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }
}
