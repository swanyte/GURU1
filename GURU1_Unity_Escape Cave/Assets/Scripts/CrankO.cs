//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class CrankO : MonoBehaviour
//{
//    private AudioSource theAudioC0;

//    public Sprite CurrentSprite;
//    public Sprite NextSprite;
//    private SpriteRenderer SR;
//    public string direction;
//    //bar 콜라이더
//    public EdgeCollider2D barcoll;
//    // Start is called before the first frame update
//    void Start()
//    {
//        theAudioC0 = GetComponent<AudioSource>();

//        SR = gameObject.GetComponent<SpriteRenderer>();
//        SR.sprite = CurrentSprite;
//    }

//    private void OnCollisionEnter2D(Collision2D other)
//    {
//        if (other.gameObject.tag == "Player")
//        {
//            theAudioC0.Play();
//            SR.sprite = NextSprite;
//            if (direction == "right")
//            {
//                GameObject.Find("barO").GetComponent<Bar>().BarMoveRight();
//            }
//            else if (direction == "left")
//            {
//                GameObject.Find("barO").GetComponent<Bar>().BarMoveLeft();
//            }
//        }
//        barcoll.enabled = false;
//    }
//    // Update is called once per frame
//    void Update()
//    {

//    }
//}
