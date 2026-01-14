using System.Collections;
using UnityEngine;

public class MultipleCoroutines : MonoBehaviour
{
    public Animator animator;
    public SpriteRenderer spriteRenderer;

    private void OnEnable()
    {
        StartCoroutine(ChangeColorCoroutine());
        StartCoroutine(ChangeScaleCoroutine());
        StartCoroutine(BounceCoroutine());
    }
    
    private void OnDisable()
    {
        StopAllCoroutines();
    }

    private IEnumerator ChangeColorCoroutine()
    {
        float duration = 2f;

        while (true)
        {
            Color startColor = spriteRenderer.color;
            Color endColor = Random.ColorHSV();

            float timer = 0f;
            while (timer < 1f)
            {
                timer += Time.deltaTime / duration;
                spriteRenderer.color = Color.Lerp(startColor, endColor, timer);
                yield return null;
            }
        }
    }

    private IEnumerator ChangeScaleCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);

            float newScale = Random.Range(1f, 10f);
            transform.localScale = Vector3.one * newScale;
        }
    }

    private IEnumerator BounceCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(5f);
            animator.SetTrigger("bounce");
        }
    }
}
