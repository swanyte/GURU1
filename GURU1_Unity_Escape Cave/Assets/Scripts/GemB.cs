using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemB : MonoBehaviour
{
    // 레드가 먹은 보석의 갯수
    public static int CountB = 0;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        GemB.CountB = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "GemB")
        {
            // collision.gameObject.SetActive(false);
            Destroy(other.gameObject);
            audioSource.Play();
            CountB++;
            print("째마리");
        }
        else if (other.name.Contains("doorB"))
        {
            // 플레이어가 문앞에 있다.
            DoorB.Instance.isGemBInfrontDoorB = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        print("OnTriggerExit2D.........");
        DoorB.Instance.isGemBInfrontDoorB = false;
    }
}

