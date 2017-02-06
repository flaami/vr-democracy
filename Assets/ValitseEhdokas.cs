using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValitseEhdokas : MonoBehaviour {

    public GameObject Ehdokas;
    public GameObject NaytaEhdokas;
    //public string nimi;
    public GameObject HideThis;
    public GameObject ShowThis;

    public void lue_ehdokas() {
        
        //nimi = Ehdokas.ToString();
        NaytaEhdokas.GetComponentInChildren<Text>().text = Ehdokas.ToString();
        ShowThis.SetActive(true);
        HideThis.SetActive(false);

    }


}
