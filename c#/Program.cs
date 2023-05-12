using System;
using System.Net;
using System.Net.Http;
using System.IO;

// 주제 : ﻿통합대기환경지수 나쁨 이상 측정소 목록조회

namespace ConsoleApp1
{
    class Program
    {
        static HttpClient client = new HttpClient();
        static void Main(string[] args)
        {
            string url = "http://apis.data.go.kr/B552584/ArpltnInforInqireSvc/getUnityAirEnvrnIdexSnstiveAboveMsrstnList"; // URL
            url += "?ServiceKey=" + "HKZUYn2Be7GXesHpAOsUTJ6EZfTowGBpBvhkBe6%2BfJaINIiZGQmf%2BVVjlg3umyQQFCr6DQp9tLzMx3qrDzvSdQ%3D%3D"; // Service Key
            url += "&returnType=json";
            url += "&numOfRows=100";
            url += "&pageNo=1";

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            string results = string.Empty;
            HttpWebResponse response;
            using (response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                results = reader.ReadToEnd();
            }

            Console.WriteLine(results);
        }
    }
}
