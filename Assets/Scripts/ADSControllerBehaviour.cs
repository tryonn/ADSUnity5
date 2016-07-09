using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;
using System.Collections;
using System;

public class ADSControllerBehaviour : MonoBehaviour {

    private int idRecompensa; // 0, 1, 2
    public Text textResult;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    public void ShowAds(string zoneId)
    {
        if (string.IsNullOrEmpty(zoneId)) { zoneId = null; }

        ShowOptions showOptions = new ShowOptions();
        showOptions.resultCallback = HandleShowAdsResult;

        Advertisement.Show(zoneId, showOptions);
    }

    /// <summary>
    /// recebe e trata o result do anuncio
    /// </summary>
    /// <param name="result"></param>
    private void HandleShowAdsResult(ShowResult result)
    {
        switch (result)
        {
            // quando o anuncio não iniciar            
            case ShowResult.Failed:
                textResult.text = "Anuncio não funciona";
                break;
            // quando o anuncio finalizar
            case ShowResult.Finished:
                switch (idRecompensa)
                {
                    case 0:
                        textResult.text = "Ganhou mais 2 vidas";
                        break;
                    case 1:
                        textResult.text = "Ganhou mais 20 moedas";
                        break;
                    case 2:
                        textResult.text = "PowerUp atingido...";
                        break;
                }
                break;
            // quando o anuncio é pulado
            case ShowResult.Skipped:
                textResult.text = "Anuncio foi Skipped";
                break;
        }
    }

    public void setIdRecompensa(int _idRecompensa)
    {
        this.idRecompensa = _idRecompensa;
    }
}
