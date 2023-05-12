using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class ConnectToModel : MonoBehaviour
{
    /*
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Request());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Request()
    {
        //IMPORTANTE
        string json = "{\"message\":\"" + msg + "\"}";
        Debug.Log(json);
        byte[] bodyRaw = System.Text.Encoding.UTF8.GetBytes(json);

        // create the UnityWebRequest object
        UnityWebRequest request = UnityWebRequest.PostWwwForm(url_connect, "POST");
        request.uploadHandler = new UploadHandlerRaw(bodyRaw);
        request.downloadHandler = new DownloadHandlerBuffer();
        request.SetRequestHeader("Content-Type", "application/json");

        // send the request and wait for a response
        yield return request.SendWebRequest();

        if (request.result != UnityWebRequest.Result.Success)
        {
            Debug.LogError(request.error);
        }
        else
        {
            Debug.Log("Request sent successfully!");
            Debug.Log(request.downloadHandler.text);
        }
    }
    */
}
