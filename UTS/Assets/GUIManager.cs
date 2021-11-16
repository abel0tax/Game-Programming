using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GUIManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnPlay() {
        SceneManager.LoadScene("PLEY!!!");
    }
    public void OnCredit() {
        SceneManager.LoadScene("TUNTANG");
    }
    public void OnHelp() {
        SceneManager.LoadScene("TOLONG");
    }
    public void OnMenu() {
        SceneManager.LoadScene("SampleScene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
