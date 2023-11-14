using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject menupanel;
    public GameObject infopanel;
    // Start is called before the first frame update
    void Start()
    {
        menupanel.SetActive(true);
<<<<<<< HEAD
        infopanel.SetActive(false);
=======
        infopanel.SetActive(false);  
>>>>>>> eb0dac5f1840f2f47d3d1c677e3310838c3a92c2
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartButton(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }

    public void InfoButton()
    {
        menupanel.SetActive(false);
        infopanel.SetActive(true);
    }

    public void BackButton()
    {
        menupanel.SetActive(true);
        infopanel.SetActive(false);
    }

    public void ExitButton()
    {
        Application.Quit();
    }

}
