using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Diagnostics;
using System.Web.Script.Serialization;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;

namespace Enlish_Note
{
    public class YoudaoDictionary
    {

        public delegate void StringHandle(string str);
        public event StringHandle ReceiveEvent;

        public Json.JsonPaser Json;

        string ErrorCodeString = "errorCode";
        string API_Http = "http://openapi.youdao.com/api?appKey";
        string APPKey = "3c0a72612269ebac";
        string AppSecret = "tJN4pmDy34ET8aLZmADUjCIs2YLx0OaS";
        public YoudaoDictionary()
        {
            Json = new Json.JsonPaser();
        }
        public void TestSend()
        {
            string q = "me";
            string appKey = "3c0a72612269ebac";
            string from = "zh-CHS";
            string to = "en";
            string salt = DateTime.Now.Millisecond.ToString();
            string appSecret = "tJN4pmDy34ET8aLZmADUjCIs2YLx0OaS";
            MD5 md5 = new MD5CryptoServiceProvider();
            string md5Str = appKey + q + salt + appSecret;
            byte[] output = md5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(md5Str));
            string sign = BitConverter.ToString(output).Replace("-", "");

            string url = string.Format("http://openapi.youdao.com/api?appKey={0}&q={1}&from={2}&to={3}&sign={4}&salt={5}",
                appKey, System.Web.HttpUtility.UrlDecode(q, System.Text.Encoding.GetEncoding("UTF-8")), from, to, sign, salt);
            WebRequest translationWebRequest = WebRequest.Create(url);

            WebResponse response = null;

            response = translationWebRequest.GetResponse();
            Stream stream = response.GetResponseStream();

            Encoding encode = Encoding.GetEncoding("utf-8");

            StreamReader reader = new StreamReader(stream, encode);
            string result = reader.ReadToEnd();

            //result = GetJsonNode(result, "basic");

            ReceiveEvent?.Invoke(Json.ConvertJsonString(result));
            //Debug.WriteLine(result);
        }

        public void Send(string query)
        {
            Regex regChina = new Regex("^[^\x00-\xFF]");

            Regex regEnglish = new Regex("^[a-zA-Z]");

            string from, to;

            if (regChina.IsMatch(query))
            {
                from = "zh-CHS";
                to = "en";
            }
            else
            {
                from = "en";
                to = "zh-CHS";
            }

            string salt = DateTime.Now.Millisecond.ToString();
            string appSecret = "tJN4pmDy34ET8aLZmADUjCIs2YLx0OaS";
            MD5 md5 = new MD5CryptoServiceProvider();
            string md5Str = APPKey + query + salt + appSecret;
            byte[] output = md5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(md5Str));
            string sign = BitConverter.ToString(output).Replace("-", "");

            string urlDecode = System.Web.HttpUtility.UrlDecode(query, System.Text.Encoding.GetEncoding("UTF-8"));

            string url = string.Format("{0}={1}&q={2}&from={3}&to={4}&sign={5}&salt={6}",
                API_Http,APPKey,urlDecode , from, to, sign, salt);

            WebRequest translationWebRequest = WebRequest.Create(url);

            WebResponse response = null;

            response = translationWebRequest.GetResponse();
            Stream stream = response.GetResponseStream();

            Encoding encode = Encoding.GetEncoding("utf-8");

            StreamReader reader = new StreamReader(stream, encode);
            string result = reader.ReadToEnd();

            string errorCode = GetJsonNode(result, ErrorCodeString);
            
            if (errorCode != "0")
            {
                ReceiveEvent?.Invoke("查询失败");
            }
            else
            {
                string str = Json.ConvertJsonString(result);
                File.WriteAllText("./Tst.txt", str);
                //result = GetJsonNode(result, "basic", "explains");
                result = GetJsonNode(result);
                //ReceiveEvent?.Invoke(Json.ConvertJsonString(result));
                ReceiveEvent?.Invoke(result);
                //File.WriteAllText("./Test.text", Json.ConvertJsonString(result));
            }
           
        }

        #region 格式化Json字符串
        public string GetJsonNode(string json,string node)
        {
            JObject obj = JObject.Parse(json);
            string city = obj[node].ToString();
            return city;
        }
        public string GetJsonNode(string json, string node0,string node1)
        {
            JObject obj = JObject.Parse(json);
            string city = string.Empty;
            if (obj[node0] == null)
            {
                return city;
            }
            city = obj[node0][node1].ToString();
            return city;
        }

        public string GetJsonNode(string json)
        {
            Web web = new Web();

            exp example = new exp();

            JObject obj = JObject.Parse(json);

            string phrase = string.Empty;

            phrase = obj["web"].ToString();

            web.web = Deserialize<List<WebBasic>>(phrase);

            string empt0 = "        ";
            string empt1 = "        ";
            string empt2 = "    ";
            string empt3 = "  ";
            phrase = string.Empty;
            int index = 0;
            foreach (var wb in web.web)
            {
                index++;
                string value = string.Empty;

                foreach (var str in wb.value)
                {
                    value += string.Format("{0}{1}\r\n{2}",empt3, str, empt1);
                }
                
                phrase += string.Format("{0}{1}.类似值：\r\n{2}{3}{4}\r\n{5}翻译：\r\n{6}{7}\r\n",
                    empt3, index, empt3, empt1,wb.key, empt2, empt1, value);
            }
            index = 0;
            string InputStr = obj["query"].ToString();

            string translator = obj["translation"][0].ToString();

            //相似字条
            string Similarity = string.Empty;
            string Simi = string.Empty;
            if (obj["basic"] != null && obj["basic"]["explains"] != null)
            {
                int similaCount = obj["basic"]["explains"].Count();

                Similarity = obj["basic"]["explains"].ToString();

                example.explains = Deserialize<List<string>>(Similarity);

                foreach (var str in example.explains)
                {
                    Simi += string.Format("{0}\r\n{1}",str, empt0);
                }
            }
            string res = string.Format("输入值： {0}\r\n\r\n翻译结果:  {1}\r\n\r\n近似值： {2}\r\n短语：\r\n{3}",
                InputStr, translator, Simi, phrase);

            return res;

        }
        public string GetJsonNode(string json, string node0, string node1,string node2)
        {
            JObject obj = JObject.Parse(json);
            string city = obj[node0][node1][node2].ToString();
            return city;
        }
        public T Deserialize<T>(string json)
        {
            JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
            //执行反序列化
            T obj = jsonSerializer.Deserialize<T>(json);
            return obj;
        }
        #endregion
    }


    public class ReturnDate
    {
        public ReturnDate()
        { }
        public string tSpeakUrl { get; set; }

        public string web { get; set; }

        public string query { get; set; }

        public string translation { get; set; }

        public string errorCode { get; set; }

        public string dict { get; set; }

        public string webdict { get; set; }

        public string basic{ get; set; }

        public string l { get; set; }

        public string speakUrl { get; set; }
    }


    #region web
    public class Web
    {
        public List<WebBasic> web { get; set; }
    }
    public class WebBasic
    {
        public List<string> value { get; set; }

        public string key { get; set; }

    }
    #endregion

    #region dict
    public class urlDict
    {
        public string url { get; set; }
    }
    #endregion

    #region basic
    public class exp
    {
        public List<string> explains { get; set; }

    }
    #endregion
}
