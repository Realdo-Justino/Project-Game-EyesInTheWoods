using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skip1 : MonoBehaviour
{
    // Start is called before the first frame update
    // Start is called before the first frame update
    [SerializeField]GameObject EndStage;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            EndStage.SetActive(true);
        }
    }
}
