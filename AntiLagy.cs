using UnityEngine;

public class AntiLagy : MonoBehaviour
{
    [SerializeField] private int antiAliasingLevel = 2;
    [SerializeField] private int maxTextureLevel = 1; // Adjusted variable name

    void Start()
    {
        QualitySettings.antiAliasing = antiAliasingLevel;

        QualitySettings.maxQueuedFrames = maxTextureLevel; // Adjusted property name

        if (transform.rotation.eulerAngles.x > 70 && transform.rotation.eulerAngles.x < 90)
        {
            foreach (var renderer in FindObjectsOfType<Renderer>())
            {
                renderer.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
            }
        }
    }
}
