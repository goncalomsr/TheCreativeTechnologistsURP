using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class TexturePrint : MonoBehaviour
{
    public void TexturePrintToImage()
    {
        // Create a texture in RGB24 format the size of the screen
        int width = Screen.width;
        int height = Screen.height;
        Texture2D tex = new Texture2D(width, height, TextureFormat.RGB24, false);

        // Read the screen contents into the texture
        tex.ReadPixels(new Rect(0, 0, width, height), 0, 0);
        tex.Apply();

        // Encode the texture in JPG format
        byte[] bytes = ImageConversion.EncodeToJPG(tex);
        Object.Destroy(tex);

        // Write the returned byte array to a file in the project folder
        File.WriteAllBytes(Application.dataPath + "/../SavedScreen.jpg", bytes);
    }
}
