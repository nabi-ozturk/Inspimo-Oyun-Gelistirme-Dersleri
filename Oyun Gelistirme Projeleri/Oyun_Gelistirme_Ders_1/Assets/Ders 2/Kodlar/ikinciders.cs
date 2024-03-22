using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ikinciders : MonoBehaviour



    
{

    public Text helloWorld;
    public Text sayacText;

    public Image sayacResmi;

    public float sayac = 10;
    // Start is called before the first frame update
    void Start()
    {
        helloWorld.text = "Merhaba Dünya!";

        Debug.Log("Oyun Baþladý-START");
    }
    
    // Update is called once per frame
    void Update()
    {
        
        if (sayac>0)
        {
            sayac = sayac - Time.deltaTime;
            sayacText.text = sayac.ToString();
            helloWorld.text = "Ders Baþlýyor...";
        }
        else if(sayac<=0)
        {
            sayac = 0;
            sayacResmi.gameObject.SetActive(false);
            sayacText.text = "";
            helloWorld.text = "Ders Baþladý!..";
        }
        
    }
}
