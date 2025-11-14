using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public player player;
    
    private void OnCollisionEnter(Collision collision) {
        Destroy(this.gameObject);
        player.Blockcount -= 1;
    }
    
}
