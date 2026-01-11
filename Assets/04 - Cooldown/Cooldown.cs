using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class Cooldown : MonoBehaviour
{
    public float interval = 5f;
    public UICooldownBar cooldownBar;

    private void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            StartCoroutine(nameof(CooldownCoroutine));
        }
    }

    private IEnumerator CooldownCoroutine()
    {
        float timer = 0;
        
        while (timer < interval)
        {
            yield return null;

            timer += Time.deltaTime;
            cooldownBar.Progress = timer / interval;
        }
    }
}
