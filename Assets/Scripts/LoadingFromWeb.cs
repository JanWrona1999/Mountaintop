using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class LoadingFromWeb : MonoBehaviour
{
   

    [Header("id Obiektu")]
    public int id = 0;
    public int id_scena = 0;
    public Shader shader;

    IEnumerator DownloadTexture(string textureurl)
    {
        UnityWebRequest request = UnityWebRequestTexture.GetTexture(textureurl);
        yield return request.SendWebRequest();
        if (request.result != UnityWebRequest.Result.Success) {
            Debug.Log(request.error);
        }
        else
            this.gameObject.GetComponent<Renderer>().material.mainTexture = DownloadHandlerTexture.GetContent(request);;
            this.gameObject.GetComponent<Renderer>().material.shader = shader;
        
    }
    IEnumerator setTextureFromWeb()
    {
     
        string IP = DataKeeper.IP;
     
        string textureurl = "";
        textureurl = "http://" + IP + "/unity/scene"+ id_scena +"/images/image" + (id) + ".jpg";
      

        yield return StartCoroutine(DownloadTexture(textureurl));
    }

    void Start()
    {
       StartCoroutine(setTextureFromWeb());
       shader = Shader.Find("Standard");
    }
   
}
