using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrankBar : MonoBehaviour
{
    Vector3 origin;
    Vector3 PositionRight;
    Vector3 PositionLeft;
    Vector3 PositionDown;
    Vector3 PositionUp;
    public float distance;
    // Start is called before the first frame update
    void Start()
    {
        origin = transform.position;
        PositionRight = origin + Vector3.right * distance;
        PositionLeft = origin + Vector3.left * distance;
        PositionDown = origin + Vector3.down * distance;
        PositionUp = origin + Vector3.up * distance;
    }
  
    public void BarMoveRight()
    {
        transform.position = Vector3.Lerp(origin, PositionRight, 10 * Time.deltaTime);
    }
    public void BarMoveLeft()
    {
        transform.position = Vector3.Lerp(origin, PositionLeft, 10 * Time.deltaTime);
    }
    public void BarMoveDown()
    {
        transform.position = Vector3.Lerp(origin, PositionDown, 10 * Time.deltaTime);
    }
    public void BarMoveUp()
    {
        transform.position = Vector3.Lerp(origin, PositionUp, 10 * Time.deltaTime);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
