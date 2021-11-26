using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crank : MonoBehaviour
{
    private AudioSource theAudio;

    public Sprite CurrentSprite;
    public Sprite NextSprite;
    private SpriteRenderer SR;
    public EdgeCollider2D Crankcoll;

    public string Color;
    public float barSpeed = 2;
    public string direction;

    // Start is called before the first frame update
    void Start()
    {
        theAudio = GetComponent<AudioSource>();
        SR = gameObject.GetComponent<SpriteRenderer>();
        SR.sprite = CurrentSprite;
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            theAudio.Play();
            SR.sprite = NextSprite;
            if (direction == "right")
            {
                GameObject.Find("bar" + Color).GetComponent<CrankBar>().BarMoveRight();
            }
            if (direction == "left")
            {
                GameObject.Find("bar" + Color).GetComponent<CrankBar>().BarMoveLeft();
            }
            if (direction == "up")
            {
                GameObject.Find("bar" + Color).GetComponent<CrankBar>().BarMoveUp();
            }
            if (direction == "down")
            {
                GameObject.Find("bar" + Color).GetComponent<CrankBar>().BarMoveDown();
            }
            Crankcoll.enabled = false;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
