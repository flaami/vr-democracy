using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserPointer : MonoBehaviour {

    private SteamVR_TrackedObject trackedObj;//helper code
    // 1
    public GameObject laserPrefab;
    // 2
    private GameObject laser;
    // 3
    private Transform laserTransform;
    // 4
    private Vector3 hitPoint;

    /*
    1 This is a reference to the Laser’s prefab.
    2 laser stores a reference to an instance of the laser.
    3 The transform component is stored for ease of use.
    4 This is the position where the laser hits. */


    private SteamVR_Controller.Device Controller //helper code
    {
        get { return SteamVR_Controller.Input((int)trackedObj.index); }
    }

    void Awake()//helper code
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
    }

    private void ShowLaser(RaycastHit hit)
    {
        // 1
        laser.SetActive(true);
        // 2
        laserTransform.position = Vector3.Lerp(trackedObj.transform.position, hitPoint, .5f);
        // 3
        laserTransform.LookAt(hitPoint);
        // 4
        laserTransform.localScale = new Vector3(laserTransform.localScale.x, laserTransform.localScale.y,
            hit.distance);

        /*
        1 Show the laser.
        2 Position the laser between the controller and the point where the raycast hits. You use Lerp because you can give it two positions and the percent it should travel. If you pass it 0.5f, which is 50%, it returns the precise middle point.
        3 Point the laser at the position where the raycast hit.
        4 Scale the laser so it fits perfectly between the two positions.*/
    }
    
    void Start () {
        // 1
        laser = Instantiate(laserPrefab);
        // 2
        laserTransform = laser.transform;
    }
	
	
	void Update () {
        // 1
        if (Controller.GetPress(SteamVR_Controller.ButtonMask.Touchpad))
        {
            RaycastHit hit;

            // 2
            if (Physics.Raycast(trackedObj.transform.position, transform.forward, out hit, 100))
            {
                hitPoint = hit.point;
                ShowLaser(hit);
            }
        }
        else // 3
        {
            laser.SetActive(false);
        } /*         
            1 If the touchpad is held down…
            2 Shoot a ray from the controller. If it hits something, make it store the point where it hit and show the laser.
            3 Hide the laser when the player released the touchpad.   
         */
    }
}
