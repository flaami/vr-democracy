using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonshit : MonoBehaviour {

    public GameObject HideThis;
    public GameObject ShowThis;

    public void seuraava_canvas()
    {

        ShowThis.SetActive(true);
        HideThis.SetActive(false);

    }
}


