using System.Collections;
using UnityEngine;

public class CircleSpawner : MonoBehaviour
{
    public float delay = 2;
    public Sprite circleSprite;

    #region Com Corrotina
    private void Start()
    {
        StartCoroutine(nameof(SpawnCircleCoroutine));
    }

    private IEnumerator SpawnCircleCoroutine()
    {
        yield return new WaitForSeconds(delay);
        Circle.Create(circleSprite);
    }
    #endregion    

    #region Sem Corrotina
    // private float timer;
    // private bool created;

    // private void Update()
    // {
    //     if (created)
    //         return;

    //     if (timer >= delay)
    //     {
    //         Circle.Create(circleSprite);
    //         created = true;
    //     }

    //     timer += Time.deltaTime;
    // }
    #endregion

    #region Com o Método Invoke
    // private void Start()
    // {
    //     Invoke(nameof(SpawnCircle), delay);
    // }

    // private void SpawnCircle()
    // {
    //     Circle.Create(circleSprite);
    // }
    #endregion
}
