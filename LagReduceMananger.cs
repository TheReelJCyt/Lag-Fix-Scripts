using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class LagReduceMananger : MonoBehaviour
{
    public static LagReduceMananger instance;
    public  bool __reduceLag;
    public List<GameObject> laggableObjects = new List<GameObject>();
    public List<Volume> universalRenderPiplines = new List<Volume>();
    public LagReduceMananger lagReduceMananger;
    void Update()
    {
        if (__reduceLag)
        {
            foreach (GameObject lagg in laggableObjects)
            {
                foreach (Volume i in universalRenderPiplines)
                {
                    i.enabled = false;
                }
                lagg.SetActive(false);
            }
        }
        else
        {
            foreach (GameObject lagg in laggableObjects)
            {
                foreach (Volume i in universalRenderPiplines)
                {
                    i.enabled = true;
                }
                lagg.SetActive(true);
            }
        }
    }
}
