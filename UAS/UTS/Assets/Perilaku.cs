using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Perilaku : MonoBehaviour
{
    public Text PowerText;
    private string PowerNum;

    void OnCollisionEnter2D(Collision2D coll){
if (coll.gameObject.tag == "enemyTag"){
    if(PowerNum == "off"){
        Die();
    }
    else{
        
    }
    }
else if (coll.gameObject.tag == "finishTag"){
    Debug.Log("FINISH");
    Finish();
    }
    }

    // Start is called before the first frame update
    void Start()
    {
        PowerNum = "off";
        PowerText.text = "Power : " +PowerNum;
    }
 private void OnTriggerEnter2D(Collider2D Power){

        if(Power.tag =="powerTag"){

        PowerNum = "on";
        Destroy(Power.gameObject);
        PowerText.text = "Power : " +PowerNum;

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void Die(){
        Debug.Log("GAME OVER");
        SceneManager.LoadScene ("PLEY AGAIN");
    }
    void Finish(){
        Debug.Log("FINISH");
        SceneManager.LoadScene ("FINISH");
    }
    
}
