using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade_close : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Fade_Close;
    public Animator anim;

    void Start()
    {
        StartCoroutine(Waiter());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Waiter(){
            anim.SetBool("Starting",true);
            yield return new WaitForSeconds(1);
            Fade_Close.SetActive(false);
    }
    
}

