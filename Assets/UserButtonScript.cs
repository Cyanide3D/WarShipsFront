using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserButtonScript : MonoBehaviour
{
    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    private void OnMouseDown()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.blue;
    }
}
