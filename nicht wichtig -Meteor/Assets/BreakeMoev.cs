using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakeMoev : MonoBehaviour {

   void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Meteor")
        {
            Destroy(col.gameObject);
        }
    }



}
