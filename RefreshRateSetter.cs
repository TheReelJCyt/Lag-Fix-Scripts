using UnityEngine;

public class RefreshRateSetter : MonoBehaviour
{
    [Header("Made by Glithed Cat Studios, please give credits!")]
    [Space]

    public RefreshRate Default = RefreshRate._90Hz;
    [Space(15)]
    public RefreshRate quest2 = RefreshRate._72Hz;
    public RefreshRate questPro = RefreshRate._90Hz;
    public RefreshRate quest3 = RefreshRate._90Hz;
    public RefreshRate quest3S = RefreshRate._90Hz;

    private string model;


    private void Awake()
    {
        model = OVRPlugin.productName;
        if (model == null) { model = "Unity Editor"; }

        if (model.Contains("Quest 2"))
        {
            switch (quest2)
            {
                case RefreshRate._60Hz:
                    OVRPlugin.systemDisplayFrequency = 60.0f;
                    Application.targetFrameRate = 60;
                    break;

                case RefreshRate._72Hz:
                    OVRPlugin.systemDisplayFrequency = 72.0f;
                    Application.targetFrameRate = 72;
                    break;

                case RefreshRate._90Hz:
                    OVRPlugin.systemDisplayFrequency = 90.0f;
                    Application.targetFrameRate = 90;
                    break;

                case RefreshRate._120Hz:
                    OVRPlugin.systemDisplayFrequency = 120.0f;
                    Application.targetFrameRate = 120;
                    break;
            }
        }
        else if (model.Contains("Quest Pro"))
        {
            switch (questPro)
            {
                case RefreshRate._60Hz:
                    OVRPlugin.systemDisplayFrequency = 60.0f;
                    Application.targetFrameRate = 60;
                    break;

                case RefreshRate._72Hz:
                    OVRPlugin.systemDisplayFrequency = 72.0f;
                    Application.targetFrameRate = 72;
                    break;

                case RefreshRate._90Hz:
                    OVRPlugin.systemDisplayFrequency = 90.0f;
                    Application.targetFrameRate = 90;
                    break;

                case RefreshRate._120Hz:
                    OVRPlugin.systemDisplayFrequency = 120.0f;
                    Application.targetFrameRate = 120;
                    break;
            }
        }
        else if (model.Contains("Quest 3S"))
        {
            switch (quest3S)
            {
                case RefreshRate._60Hz:
                    OVRPlugin.systemDisplayFrequency = 60.0f;
                    Application.targetFrameRate = 60;
                    break;

                case RefreshRate._72Hz:
                    OVRPlugin.systemDisplayFrequency = 72.0f;
                    Application.targetFrameRate = 72;
                    break;

                case RefreshRate._90Hz:
                    OVRPlugin.systemDisplayFrequency = 90.0f;
                    Application.targetFrameRate = 90;
                    break;

                case RefreshRate._120Hz:
                    OVRPlugin.systemDisplayFrequency = 120.0f;
                    Application.targetFrameRate = 120;
                    break;
            }
        }
        else if (model.Contains("Quest 3"))
        {
            switch (quest3)
            {
                case RefreshRate._60Hz:
                    OVRPlugin.systemDisplayFrequency = 60.0f;
                    Application.targetFrameRate = 60;
                    break;

                case RefreshRate._72Hz:
                    OVRPlugin.systemDisplayFrequency = 72.0f;
                    Application.targetFrameRate = 72;
                    break;

                case RefreshRate._90Hz:
                    OVRPlugin.systemDisplayFrequency = 90.0f;
                    Application.targetFrameRate = 90;
                    break;

                case RefreshRate._120Hz:
                    OVRPlugin.systemDisplayFrequency = 120.0f;
                    Application.targetFrameRate = 120;
                    break;
            }
        }
        else
        {
            switch (Default)
            {
                case RefreshRate._60Hz:
                    OVRPlugin.systemDisplayFrequency = 60.0f;
                    if (!Application.isEditor) { Application.targetFrameRate = 60; }
                    break;

                case RefreshRate._72Hz:
                    OVRPlugin.systemDisplayFrequency = 72.0f;
                    if (!Application.isEditor) { Application.targetFrameRate = 72; }
                    break;

                case RefreshRate._90Hz:
                    OVRPlugin.systemDisplayFrequency = 90.0f;
                    if (!Application.isEditor) { Application.targetFrameRate = 90; }
                    break;

                case RefreshRate._120Hz:
                    OVRPlugin.systemDisplayFrequency = 120.0f;
                    if (!Application.isEditor) { Application.targetFrameRate = 120; }
                    break;
            }
        }
    }


    #region Types

    public enum RefreshRate
    {
        _60Hz = 60,
        _72Hz = 72,
        _90Hz = 90,
        _120Hz = 120
    }
    #endregion
}
