using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ending : MonoBehaviour
{
    public GameObject go;

    private void OnTriggerStay2D(Collider2D colision)
    {
        if(Input.GetKeyDown(KeyCode.K))
        {
            go.SetActive(true);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
