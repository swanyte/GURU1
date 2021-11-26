using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject ButtonRstart;
    public string loadscene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (DoorB.Instance.ready && DoorR.Instance.ready)
        {
            int curindex = SceneManager.GetActiveScene().buildIndex;
            if (curindex == 3)
            {

                SceneManager.LoadScene("firework");
            }
            else
            {
                SceneManager.LoadScene(curindex + 1);
            }
            
        }
    }
    
    public void PlaySE()
    {
        AudioSource buttonsound = ButtonRstart.GetComponent<AudioSource>();
        buttonsound.Play();
    }
    public void OnClickRestart()
    {
        int curindex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(curindex);
    }
}
