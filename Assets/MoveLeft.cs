using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveLeft : MonoBehaviour
{
    public float speed = 2f;

    private void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
