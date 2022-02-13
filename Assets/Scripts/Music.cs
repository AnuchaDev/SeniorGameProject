using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    // Start is called before the first frame updatepublic static MusicControlScript instance;
    public static Music instance;
    private void Awake()
    {
        if(instance == null){
            instance = this;
        }
        else{
            Destroy(gameObject);
        }
    }
}
