using System.Collections;
using UnityEngine;

public class MultiCircleSpawner : MonoBehaviour
{
    public float interval = 1;
    public Sprite circleSprite;

    #region Com Corrotina
    private void OnEnable()
    {
        StartCoroutine(nameof(SpawnCircleCoroutine));
    }

    private void OnDisable()
    {
        StopCoroutine(nameof(SpawnCircleCoroutine));
    }

    private IEnumerator SpawnCircleCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(interval);
            Circle.Create(circleSprite);
        }
    }
    #endregion

    #region Com InvokeRepeating
    // private void Start()
    // {
    //     InvokeRepeating(nameof(SpawnCircle), interval, interval);
    // }

    // private void SpawnCircle()
    // {
    //     Circle.Create(circleSprite);
    // }
    #endregion

    #region Sem Corrotina
    // private float timer;

    // private void Update()
    // {
    //     if (timer >= interval)
    //     {
    //         Circle.Create(circleSprite);
    //         timer -= interval;
    //     }

    //     timer += Time.deltaTime;
    // }
    #endregion
}
