using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Dialogue {

    public string[] names;
    [TextArea(1, 7)]
    public string[] sentences;
    public int[] images;
    

}
