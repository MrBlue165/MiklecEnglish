using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCamera : MonoBehaviour
{
    [SerializeField] Vector2 pow = new Vector2(4, 2);
    Vector3 pos;
    float x, y;
    void Start()
    {
        pos = transform.localPosition;
    }
    void Update()
    {
        float targetX = Input.mousePosition.x - Screen.width * 0.75f;
        float dx = targetX - x;
        x += dx * 0.05f;
        float targetY = Input.mousePosition.y - Screen.width * 0.5f;
        float dy = targetY - y;
        y += dy * 0.05f;


        Vector3 dir = new Vector3(-x, -y, 0);
        dir.x *= 1 / 500f * pow.x * 0.1f;
        dir.y *= 1 / 500f * pow.y * 0.1f;
        this.transform.localPosition = pos - dir;
    }
}
