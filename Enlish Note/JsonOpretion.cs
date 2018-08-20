/*
    需要添加程序包 Newtonsoft.Json
    程序包管理控制台输入下载：Install-Package Newtonsoft.Json 

    需要添加 System.Web.Extensions 引用
    引用->添加引用->System.Web.Extensions
*/



using System.IO;
using System.Web;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace Json
{
    /// <summary>
    /// json 文件操作类
    /// </summary>
    public class JsonPaser
    {
        string _FilePathName;

        /// <summary>
        /// 设置文件名
        /// </summary>
        public string FilePathName
        {
            get { return _FilePathName; }
            set { _FilePathName = value; }
        }
        
        /// <summary>
        /// 串行化json文件 object-> string ,并保存
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public string Serialize(object obj)
        {
            FileExist();

            JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
            string json = jsonSerializer.Serialize(obj);

            File.WriteAllText(_FilePathName, ConvertJsonString(json));
            return ConvertJsonString(json);
        }

        /// <summary>
        /// 反串行化json文件 读取string-> object,
        /// </summary>
        /// <returns></returns>
        public T Deserialize<T>()
        {
            FileExist();

            string json = File.ReadAllText(_FilePathName);
            JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
            //执行反序列化
            T obj = jsonSerializer.Deserialize<T>(json);
            return obj;
        }
        private void FileExist()
        {
            var DirName = Path.GetDirectoryName(_FilePathName);
            var FilName = Path.GetFileName(_FilePathName);
            if (!Directory.Exists(DirName))
            {
                Directory.CreateDirectory(DirName);
            }
            if (!File.Exists(_FilePathName))
            {
                var stream = File.Create(_FilePathName);
                stream.Close();
            }
        }
        /// <summary>
        /// 格式化json字符串
        /// </summary>
        /// <param name="JsStr"></param>
        /// <returns></returns>
        public string ConvertJsonString(string JsStr)
        {
            //格式化json字符串
            JsonSerializer serializer = new JsonSerializer();
            TextReader tr = new StringReader(JsStr);
            JsonTextReader jtr = new JsonTextReader(tr);
            object obj = serializer.Deserialize(jtr);
            if (obj != null)
            {
                StringWriter textWriter = new StringWriter();
                JsonTextWriter jsonWriter = new JsonTextWriter(textWriter)
                {
                    Formatting = Formatting.Indented,
                    Indentation = 4,
                    IndentChar = ' '
                };
                serializer.Serialize(jsonWriter, obj);
                return textWriter.ToString();
            }
            else
            {
                return JsStr;
            }
        }
    }
}


