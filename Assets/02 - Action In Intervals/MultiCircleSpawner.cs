using System.Collections;
using UnityEngine;

public class MultiCircleSpawner : MonoBehaviour
{
    public float interval = 1;
    public Sprite circleSprite;

    private void Start()
    {
        

        // InvokeRepeating(nameof(SpawnCircle), interval, interval);
    }

    private void OnEnable()
    {
        StartCoroutine("SpawnCircleCoroutine");
    }

    private void OnDisable()
    {
        StopCoroutine("SpawnCircleCoroutine");
    }

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

    // private void SpawnCircle()
    // {
    //     Circle.Create(circleSprite);
    // }

    private IEnumerator SpawnCircleCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(interval);
            Circle.Create(circleSprite);
        }
    }
}
