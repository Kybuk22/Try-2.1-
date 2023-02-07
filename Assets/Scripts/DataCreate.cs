using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Data", order = 1)]
public class DataCreate : ScriptableObject
{
    public  float moveDuration;
    public  float destroyBigDuration;
    public  float destroySmallDuration;
}
