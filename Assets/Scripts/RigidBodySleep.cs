using UnityEngine;

public class RigidBodySleep : MonoBehaviour{
    void Start(){
        Rigidbody rb = GetComponent<Rigidbody>();
        if(rb != null)rb.Sleep();
    }
}
