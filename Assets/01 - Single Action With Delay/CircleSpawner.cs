using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class CircleSpawner : MonoBehaviour
{
    public float delay = 2;
    public Sprite circleSprite;

    private void Start()
    {
        StartCoroutine(nameof(SpawnCircleCoroutine));

        // Invoke(nameof(SpawnCircle), delay);
    }

    // private float timer;
    // private bool created;

    private void Update()
    {
        // if (created)
        //     return;

        // if (timer >= delay)
        // {
        //     Circle.Create(circleSprite);
        //     created = true;
        // }

        // timer += Time.deltaTime;

        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            StartCoroutine(nameof(SpawnCircleCoroutine));
        }
    }

    // private void SpawnCircle()
    // {
    //     Circle.Create(circleSprite);
    // }

    

    private IEnumerator SpawnCircleCoroutine()
    {
        yield return new WaitForSeconds(delay);
        Circle.Create(circleSprite);
    }
}
