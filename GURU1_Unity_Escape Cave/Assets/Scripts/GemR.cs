using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemR : MonoBehaviour
{
           
    // 레드가 먹은 보석의 갯수
    public static int CountR = 0;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        GemR.CountR = 0;
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
        if (other.gameObject.tag == "GemR")
        {
            // collision.gameObject.SetActive(false);
            Destroy(other.gameObject);
            audioSource.Play();
            CountR++;
        }
        else if (other.name.Contains("doorR"))
        {
            // 플레이어가 문앞에 있다.
            DoorR.Instance.isGemRInfrontDoorR = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        DoorR.Instance.isGemRInfrontDoorR = false;
    }
}
