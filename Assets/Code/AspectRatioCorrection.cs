using UnityEngine;

public class AspectRatioCorrection : MonoBehaviour
{
    public float targetAspectWidth = 16.0f; // Target aspect width
    public float targetAspectHeight = 9.0f; // Target aspect height

    void Start()
    {
        AdjustAspectRatio();
    }

    void AdjustAspectRatio()
    {
        // Calculate the target aspect ratio
        float targetAspect = targetAspectWidth / targetAspectHeight;

        // Calculate the current screen aspect ratio
        float screenAspect = (float)Screen.width / Screen.height;

        // Calculate the scaling needed to fit the target aspect ratio
        float scaleHeight = screenAspect / targetAspect;

        Camera camera = GetComponent<Camera>();

        if (scaleHeight < 1.0f)
        {
            // Add black bars (letterboxing) at the top and bottom
            Rect rect = camera.rect;
            rect.width = 1.0f;
            rect.height = scaleHeight;
            rect.x = 0;
            rect.y = (1.0f - scaleHeight) / 2.0f;
            camera.rect = rect;
        }
        else
        {
            // Add black bars (pillarboxing) on the sides
            float scaleWidth = 1.0f / scaleHeight;
            Rect rect = camera.rect;
            rect.width = scaleWidth;
            rect.height = 1.0f;
            rect.x = (1.0f - scaleWidth) / 2.0f;
            rect.y = 0;
            camera.rect = rect;
        }
    }
}