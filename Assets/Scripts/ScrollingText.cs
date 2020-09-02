using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScrollingText : MonoBehaviour
{
    public float duration = 1f;
    public float speed;

    TextMeshPro textMesh;
    Color textColor;
    float startTime;
    void Awake()
    {
        textMesh = GetComponent<TextMeshPro>();
        startTime = Time.time;

    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time - startTime < duration)
        {
            transform.LookAt(Camera.main.transform);
            transform.Translate(Vector3.up * speed * Time.deltaTime);
            textColor.a = (duration - (Time.time - startTime)) + 0.5f;
            textMesh.color = textColor;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetText(string text)
    {
        textMesh.text = text;
    }

    public void SetColor(Color color)
    {
        textColor = color;
        textMesh.color = color;
    }
}
