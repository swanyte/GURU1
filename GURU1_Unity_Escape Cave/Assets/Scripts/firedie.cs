using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class firedie : MonoBehaviour
{
    private void Awake()
    {
        gameOverUI.SetActive(false);
    }
    public GameObject gameOverUI;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Water")
        {
            StartCoroutine("UnBeatTime");

            SpriteRenderer renderer = gameObject.GetComponentInChildren<SpriteRenderer>();
            renderer.flipY = true;
            CapsuleCollider2D coll = gameObject.GetComponent<CapsuleCollider2D>();
            coll.enabled = false;

            Rigidbody2D rigid = gameObject.GetComponent<Rigidbody2D>();
            Vector2 dieVelocity = new Vector2(0, 20f);
            rigid.AddForce(dieVelocity, ForceMode2D.Impulse);

            // collision.gameObject.SetActive(false);
            if (gameOverUI.activeSelf == false)
            {
                gameOverUI.SetActive(true);
                AudioSource aknkh = gameOverUI.GetComponent<AudioSource>();
                aknkh.Play();
            }
        }

    }
    IEnumerator UnBeatTime()
    {
        int countTime = 0;
        SpriteRenderer renderer = gameObject.GetComponentInChildren<SpriteRenderer>();

        while (countTime < 5)
        {

            if (countTime % 2 == 0)
                renderer.color = new Color32(0, 0, 200, 90);
            else
                renderer.color = new Color32(255, 255, 255, 180);
            yield return new WaitForSeconds(0.2f);
            countTime++;
        }
        renderer.color = new Color32(255, 255, 255, 255);
    }

}
