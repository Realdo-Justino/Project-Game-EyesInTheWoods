using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndStage_Cabriola : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] string cena;
    void Start()
    {
        SceneManager.LoadScene(cena);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
