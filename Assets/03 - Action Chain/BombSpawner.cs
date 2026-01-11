using UnityEngine;
using UnityEngine.InputSystem;

public class BombSpawner : MonoBehaviour
{
    public Bomb bombPrefab;

    private void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            SpawnBomb();
        }
    }

    private void SpawnBomb()
    {
        Vector3 position = Camera.main.ScreenToWorldPoint(Mouse.current.position.value);
        position.z = 0;

        Instantiate(bombPrefab, position, Quaternion.identity);
    }
}
