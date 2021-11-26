using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorR : MonoBehaviour
{
    private AudioSource theAudioR;

    // 맵에 등장한 보석의 갯수
    public int gem;
    public static DoorR Instance;
    void Awake()
    {
        Instance = this;
    }
    public bool ready;

    Vector3 origin;
    Vector3 openPosition;
    public bool isGemRInfrontDoorR;
    public bool isOpenAnimation;

    Vector3 camOrigin;
    // Start is called before the first frame update
    void Start()
    {
        theAudioR = GetComponent<AudioSource>();
        origin = transform.position;
        openPosition = origin + Vector3.up * 2;
        ready = false;

        camOrigin = Camera.main.transform.position;
    }


    float currentTime = 0;
    float openTime = 1;
    // Update is called once per frame
    void Update()
    {
        if (ready)
        {
            return;
        }

        if (isOpenAnimation)
        {
            currentTime += Time.deltaTime;
            transform.position = Vector3.Lerp(origin, openPosition, currentTime / openTime);
            Camera.main.transform.position = camOrigin + Random.insideUnitSphere * 0.1f;
            if (currentTime >= openTime)
            {
                // 준비완료...
                ready = true;
                Camera.main.transform.position = camOrigin;
                // GemR이를 못움직이게 혹은 화면에서 보이지않게처리..
            }
            return;
        }


        // 문앞에 GemR이가 서 있다면
        if (isGemRInfrontDoorR)
        {
            // 현재 맵에 등장한 모든 레드젬알을 먹었고, K 키를 누르면
            if (GemR.CountR == gem && Input.GetKeyDown(KeyCode.K))
            {
                // 문을 열자.
                isOpenAnimation = true;
                theAudioR.Play();
                
            }
        }
    }
}
