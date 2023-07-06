using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Net;

public class FTPTesttt : MonoBehaviour
{
    void Start()
    {
        WebClient wc = new WebClient();
        wc.Credentials = new NetworkCredential("아이디", "비밀번호");
        wc.UploadFile("ftp://example.com/img.png", "D:/example/img.png"); // 괄호안 첫번째는 업로드시킬 웹 주소, 두번째는 업로드할 파일의 로컬 주소
        Debug.Log("UPload");


        wc.Credentials = new NetworkCredential("아이디", "비밀번호");
        wc.DownloadFile("ftp://example.com/img.png", "D:/example/img.png"); // 괄호안 첫번째는 다운로드할 파일의 웹 주소, 두번째는 다운로드받아서 저장할 로컬 파일 위치
        Debug.Log("Download");
    }
}