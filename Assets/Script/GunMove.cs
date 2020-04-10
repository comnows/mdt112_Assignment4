using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunMove : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0f,1f,0f) * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0f,-1f,0f) * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-1f,0f,0f) * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(1f,0f,0f) * Time.deltaTime;
        }
    }
}
