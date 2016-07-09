using UnityEngine;
using UnityEngine.Advertisements;
using System.Collections;


/// <summary>
/// Projeto para estudo de ADS da propria unity
/// </summary>
public class AdsBehaviour : MonoBehaviour
{

	// Use this for initialization
	void Start () {

        // se o anuncio esta pronto
        if (Advertisement.IsReady())
        {
            ChamaAnuncio();
        }
	}
	
	// Update is called once per frame
	void Update () {

        // se não tive anuncio continua jogando....
        if (!Advertisement.isShowing)
        {
            Debug.Log("Rodando");
        }
        	
	}

    // anuncio chamdo pelo click do btn
    public void ChamaAnuncio()
    {
        
            Advertisement.Show();
  
    }
}
