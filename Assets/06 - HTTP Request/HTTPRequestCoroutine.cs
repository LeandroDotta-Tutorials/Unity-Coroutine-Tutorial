using System;
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Networking;
using UnityEngine.UI;

public class HTTPRequestCoroutine : MonoBehaviour
{
    public Text label;

    private void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            StartCoroutine(MakeRequestCoroutine());
        }
    }

    private IEnumerator MakeRequestCoroutine()
    {
        UnityWebRequest request = UnityWebRequest.Get("https://meowfacts.herokuapp.com/");
        yield return request.SendWebRequest();

        if (request.result == UnityWebRequest.Result.Success)
        {
            var facts = JsonUtility.FromJson<CatFacts>(request.downloadHandler.text);
            label.text = facts.data[0];
        }
        else
        {
            Debug.LogError(request.error);
        }
    }

    [Serializable]
    private struct CatFacts
    {
        public string[] data;
    }
}
