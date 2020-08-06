using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Splash : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Splash1());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Splash1()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Game_Menu");


    }
}
