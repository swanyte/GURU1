using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar : MonoBehaviour
{
    Vector3 originA;
    Vector3 originB;
    Vector3 dest;
    Vector3 dir;

    public float barDistance;
    Button.eDirInfo dirInfo;

    // Start is called before the first frame update
    void Start()
    {
        dest = originA = transform.position;
    }

    public void Init(Button.eDirInfo dirInfo, float dist)
    {
        dist=barDistance;
        this.dirInfo = dirInfo;

        dir = GetDir();
        originB = originA + dir * barDistance;
    }

    private Vector3 GetDir()
    {
        switch(dirInfo)
        {
            case Button.eDirInfo.left:
                return Vector3.left;
            case Button.eDirInfo.right:
                return Vector3.right;
            case Button.eDirInfo.down:
                return Vector3.down;
        }
        return Vector3.up;
    }

    public void GoMove()
    {
        dest = originB;
    }

    public void ComeBack()
    {
        dest = originA;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, dest, 5 * Time.deltaTime);
    }


}
