//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class CrankBR : MonoBehaviour
//{
//    private AudioSource theAudioBR;

//    public Sprite CurrentSprite;
//    public Sprite NextSprite;
//    private SpriteRenderer SR;
//    public string direction;
//    //bar 콜라이더
//    public EdgeCollider2D barcoll;

//    // Start is called before the first frame update
//    void Start()
//    {
//        theAudioBR = GetComponent<AudioSource>();

//        SR = gameObject.GetComponent<SpriteRenderer>();
//        SR.sprite = CurrentSprite;
//    }

//    private void OnCollisionEnter2D(Collision2D other)
//    {
//        if (other.gameObject.tag == "Player")
//        {
//            theAudioBR.Play();
//            SR.sprite = NextSprite;
//            if (direction == "right")
//            {
//                GameObject.Find("barBR").GetComponent<Bar>().BarMoveRight();
//            }
//            else if (direction == "left")
//            {
//                GameObject.Find("barBR").GetComponent<Bar>().BarMoveLeft();
//            }
//            else if (direction=="down")
//            {
//                GameObject.Find("barBR").GetComponent<Bar>().BarMoveDown();
//            }
//            barcoll.enabled = false;
//        }

//    }
//    // Update is called once per frame
//    void Update()
//    {

//    }
//}
