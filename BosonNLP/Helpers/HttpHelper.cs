///This code is written by https://github.com/hupo376787
///Please add this comment when you change my code
///Thanks, happy coding!!!

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Windows.Web;
using System.IO;
using BosonNLP.Helpers;
using System.Text.RegularExpressions;
using System.Net.Http.Headers;
using System.Net.Http;

namespace BosonNLP.Helpers
{
    public class HttpHelper
    {
        public static async Task<string> SendPostAsync(string url, string data, Encoding encoding = null)
        {
            if (encoding == null)
                encoding = Encoding.UTF8;

            try
            {
                HttpClient client = new HttpClient();
                //client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("X-Token", Constants.ApiToken);

                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, url);
                request.Content = new StringContent("\"" + data + "\"", encoding, "application/json");

                try
                {
                    return await client.SendAsync(request).ContinueWith(responseTask =>
                    {
                        HttpResponseMessage response = responseTask.Result;
                        // 确认响应成功，否则抛出异常
                        response.EnsureSuccessStatusCode();

                        // 异步读取响应为字符串
                        return response.Content.ReadAsStringAsync().ContinueWith(readTask =>
                        {
                            return readTask.Result;
                        });
                    }).Unwrap();
                }
                catch { }

                return null;
            }
            catch (WebException e)
            {
                throw new WebException(e.Message);
            }
        }

        public static async Task<string> SendPostAsync1(string url, string data, Encoding encoding = null)
        {
            if (encoding == null)
                encoding = Encoding.UTF8;

            try
            {
                HttpClient client = new HttpClient();
                //client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("X-Token", Constants.ApiToken);

                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, url);
                //request.Content = new StringContent("\"" + data + "\"", encoding, "application/json");
                request.Content = new StringContent(data);

                try
                {
                    return await client.SendAsync(request).ContinueWith(responseTask =>
                    {
                        HttpResponseMessage response = responseTask.Result;
                        // 确认响应成功，否则抛出异常
                        response.EnsureSuccessStatusCode();

                        // 异步读取响应为字符串
                        return response.Content.ReadAsStringAsync().ContinueWith(readTask =>
                        {
                            return readTask.Result;
                        });
                    }).Unwrap();
                }
                catch { }

                return null;
            }
            catch (WebException e)
            {
                throw new WebException(e.Message);
            }
        }

        public static async Task<string> SendGetAsync(string url)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("X-Token", Constants.ApiToken);

                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url);

                return await client.SendAsync(request).ContinueWith(responseTask =>
                {
                    HttpResponseMessage response = responseTask.Result;
                    // 确认响应成功，否则抛出异常
                    response.EnsureSuccessStatusCode();

                    // 异步读取响应为字符串
                    return response.Content.ReadAsStringAsync().ContinueWith(readTask =>
                    {
                        return readTask.Result;
                    });
                }).Unwrap();
            }
            catch (WebException e)
            {
                throw new WebException(e.Message);
            }
        }
    }
}
