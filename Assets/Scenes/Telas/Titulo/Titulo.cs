using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Titulo : MonoBehaviour
{

    public Animator anim;
    [SerializeField] Fade_close Fade_close;


    public GameObject Fade_out;
    public void Restart(){
        StartCoroutine(Waiter());
    }
    IEnumerator Waiter(){
        anim.SetBool("Animacao",true);
        yield return new WaitForSeconds(1);
        Fade_out.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Begining");
    }
}
