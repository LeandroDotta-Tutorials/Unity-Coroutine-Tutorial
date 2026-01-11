using UnityEngine;

public class Circle
{
    public static void Create(Sprite circleSprite)
    {
        GameObject circle = new("Circle");

        SpriteRenderer renderer = circle.AddComponent<SpriteRenderer>();
        renderer.sprite = circleSprite;
        renderer.color = new Color(Random.value, Random.value, Random.value);

        Camera cam = Camera.main;
        float camHeight = 2f * cam.orthographicSize;
        float camWidth = camHeight * cam.aspect;

        float x = Random.Range(-camWidth / 2f, camWidth / 2f);
        float y = Random.Range(-camHeight / 2f, camHeight / 2f);

        circle.transform.position = new Vector3(x, y, 0);
    }
}
