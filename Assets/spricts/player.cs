using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    bool isVisible = true;
    public int Blockcount = 9;
    public GameObject gameclear;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow)&& transform.position.x < 6.2){
            transform.position += new Vector3(0.02f,0,0);
        }
        if(Input.GetKey(KeyCode.LeftArrow)&& transform.position.x > -6.84){
            transform.position -= new Vector3(0.02f,0,0);
        }
        if(Blockcount == 0){
           gameclear.SetActive(true);
        }
        if(Input.GetKeyDown(KeyCode.A)){
            if(isVisible == true){
                isVisible = false;
                this.gameObject.transform.localScale = new Vector3(2,1,1);
            }else{
                isVisible = true;
                this.gameObject.transform.localScale = new Vector3(3,1,1);
            }
        }
        
    }
}
