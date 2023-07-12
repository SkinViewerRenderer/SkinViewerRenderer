using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.Net;
using System.IO;
using System;
using System.Text;

public class FileManager : MonoBehaviour
{
    public Renderer[] ModelRenderers;
    private string host = "ftp://183.100.89.162/";
    private string user = "svr_master";
    private string pass = "wnsvlrtmghd";

    string path;
    public RawImage image;

    public void OpenExplorer()
    {
        path = EditorUtility.OpenFilePanel("Overwirte with png", "", "png");
        Debug.Log(path);
        GetImage();
    }

    void GetImage()
    {
        if (image != null)
        {
            UpdateImage();
        }

        //image pixel check 64x64

        void UpdateImage()
        {
            Debug.Log(path);
            WWW www = new WWW("file://" + path);
            //image.texture = www.texture;
        }
    }

    public void FileUpload()
    {
        string[] pathSplit = path.Split("/");
        string pathName = pathSplit[pathSplit.Length -1];

        Debug.Log(pathName);

        WebClient wc = new WebClient();

        wc.Credentials = new NetworkCredential(user, pass);
        wc.UploadFile(host + pathName, path);

        Debug.Log("UPload");
    Texture2D SkinTexture = LoadTextureFromFile(path);
    SkinTexture.filterMode = FilterMode.Point;
    // 모든 모델에 대해 텍스처 교체
    foreach (Renderer modelRenderer in ModelRenderers)
    {
        modelRenderer.material.mainTexture = SkinTexture;
    }
}

    private Texture2D LoadTextureFromFile(string path)
    {

        byte[] fileData = File.ReadAllBytes(path);
        Texture2D texture = new Texture2D(2, 2);
        texture.LoadImage(fileData);

        return texture;
    }
}