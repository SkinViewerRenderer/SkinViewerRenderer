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
        wc.Credentials = new NetworkCredential("���̵�", "��й�ȣ");
        wc.UploadFile("ftp://example.com/img.png", "D:/example/img.png"); // ��ȣ�� ù��°�� ���ε��ų �� �ּ�, �ι�°�� ���ε��� ������ ���� �ּ�
        Debug.Log("UPload");


        wc.Credentials = new NetworkCredential("���̵�", "��й�ȣ");
        wc.DownloadFile("ftp://example.com/img.png", "D:/example/img.png"); // ��ȣ�� ù��°�� �ٿ�ε��� ������ �� �ּ�, �ι�°�� �ٿ�ε�޾Ƽ� ������ ���� ���� ��ġ
        Debug.Log("Download");
    }
}