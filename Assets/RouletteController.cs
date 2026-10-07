using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RouletteController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    float rotSpeed = 0;
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //按下滑鼠讓輪盤旋轉
        {
            this.rotSpeed = 10;
        }
        transform.Rotate(0, 0, this.rotSpeed);
        this.rotSpeed *= 0.96f;
    }
}
