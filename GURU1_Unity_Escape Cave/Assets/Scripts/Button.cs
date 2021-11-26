using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public enum eDirInfo
    {
        up,
        down,
        right,
        left
    }
    public eDirInfo direction;
    public Bar bar;
    public float barSpeed;

    Vector3 barorigin;
    Vector3 BarPositionDown;
    Vector3 dest;

    // Start is called before the first frame update
    void Start()
    {
        dest = barorigin = transform.position;
        BarPositionDown = barorigin + Vector3.down * 0.3f;
        InitBar();
    }

    public void InitBar()
    {
        bar.Init(direction, barSpeed);
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            dest = BarPositionDown;
            bar.GoMove();
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            dest = barorigin;
            bar.ComeBack();
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, dest, 10 * Time.deltaTime);
    }
}
