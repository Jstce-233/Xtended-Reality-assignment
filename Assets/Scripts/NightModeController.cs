using UnityEngine;

public class NightModeController : MonoBehaviour
{
    public Light directionalLight;          // Sun/main light
    public Material daySkybox;
    public Material nightSkybox;
    public Color dayAmbient = Color.white;
    public Color nightAmbient = Color.gray;
    public float dayIntensity = 1.0f;
    public float nightIntensity = 0.2f;

    private bool isNight = false;

    public void ToggleNightMode()
    {
        isNight = !isNight;

        if (isNight)
        {
            RenderSettings.skybox = nightSkybox;
            RenderSettings.ambientLight = nightAmbient;
            if (directionalLight != null)
                directionalLight.intensity = nightIntensity;
        }
        else
        {
            RenderSettings.skybox = daySkybox;
            RenderSettings.ambientLight = dayAmbient;
            if (directionalLight != null)
                directionalLight.intensity = dayIntensity;
        }
    }
}
