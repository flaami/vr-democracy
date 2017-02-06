using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseInfoBtnFunc : MonoBehaviour {

    public GameObject HideThis;

    public GameObject HideThisToo;

    public void info_pois()
    {

        HideThis.SetActive(false);


        HideThisToo.SetActive(false);


    }
}
