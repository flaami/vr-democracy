using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoBackBTN : MonoBehaviour {

    public GameObject HideThis;
    public GameObject ShowThis;

    public void back_btn()
    {
        ShowThis.SetActive(true);
        HideThis.SetActive(false);
    }
}
