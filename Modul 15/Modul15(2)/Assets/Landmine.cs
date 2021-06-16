using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Landmine : MonoBehaviour
{
    public float range = 2f;
    public float force = 2f;
    public float up = 4f;
    private bool active = true;

    void OnTriggerEnter (Collider collison){
        if(collison.gameObject.tag == "Player" && active) {
            active = false;
            StartCoroutine(Reactive());
            collison.gameObject.GetComponent<RagdollCharacter>().ActiveRagdoll();
            Vector3 explosionPos = transform.position;
            Collider[] colliders = Physics.OverlapSphere(explosionPos, range);
            foreach (Collider hit in colliders) {
                if(hit.GetComponent<Rigidbody>())
                    hit.GetComponent<Rigidbody>().AddExplosionForce(force, explosionPos, range, up);
            }
        }
    }
    IEnumerator Reactive(){
        yield return new WaitForSeconds(2);
        active = true;
    }
}
