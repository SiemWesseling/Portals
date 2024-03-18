using UnityEngine;

public class MainCamera : MonoBehaviour {

    Portal[] portals;

    //Find all portals in scene
    void Awake () {
        portals = FindObjectsOfType<Portal> ();
    }

    //Before the camera starts the culling operation, 
    //check the pre-, post- and normal rendering functions of each of the portals in the scene
    void OnPreCull () {

        for (int i = 0; i < portals.Length; i++) {
            portals[i].PrePortalRender ();
        }
        for (int i = 0; i < portals.Length; i++) {
            portals[i].Render ();
        }

        for (int i = 0; i < portals.Length; i++) {
            portals[i].PostPortalRender ();
        }

    }

}