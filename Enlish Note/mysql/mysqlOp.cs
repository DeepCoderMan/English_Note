using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using Json;
using Other;
using System.Threading;

namespace Enlish_Note.mysql
{
    public class mysqlOp
    {
        protected Logs _log = new Logs("./log/mysql","op");

        protected string _Con;

        protected string _JsonPathFile = "./json/ConSqlInfo.json";

        protected ConnectSqlInfo _ConInfo;

        protected MySqlConnection _conn;

        protected MySqlCommand _command;

        protected MySqlDataReader _reader;

        private bool _connected;

        public delegate void StringHandle(string log);

        public delegate void BooleanHandle(bool b);

        public event StringHandle LogEvent;

        public event StringHandle ErrorMessage;

        public event BooleanHandle ConnetedHandle;

        public event BooleanHandle ShowWait;

        public bool Connected {
            get { return _connected; }
            set {
                if (_connected != value)
                {
                    _connected = value;
                    ConnetedHandle?.Invoke(_connected);
                }
            }
        }

        public mysqlOp()
        {
            _log.Log("- - - - - - - - 数据库系统开始初始化 - - - - - - -");
            ReadConfig();
            Connect();
        }

        protected void ReadConfig()
        {
            JsonPaser jp = new JsonPaser();
            jp.FilePathName = _JsonPathFile;
            _ConInfo = jp.Deserialize<ConnectSqlInfo>();

            _Con = _ConInfo.ToString();

            Writelog("加载本地数据：" + _Con);
        }

        protected void Connect()
        {
            _conn = new MySqlConnection(_Con);
            try
            {
                _conn.Open();
                _command = _conn.CreateCommand();
                Connected = true;
                Writelog("数据库连接成功");
            }
            catch (Exception e)
            {
                Connected = false;
                WriteError("数据库连接异常：" + e.Message);
            }
            finally
            {
                //_conn.Close();
                //_connected = false;
            }

        }

        public void reStart()
        {
            Connect();
        }

        public void InsertWord(Word word)
        {
            try
            {
                var tu = DateTime.Now;

                string comm = string.
                    Format("INSERT INTO `{0}`.`{1}` (`english`, `chinese`, `date`, `search_count`) VALUES ('{2}', '{3}', '{4}', '{5}');",
                    _ConInfo.DataBase,_ConInfo.table,word.English,word.Chinese,word.Date,word.SearchCount);

                _command.CommandText = comm;

                _command.ExecuteNonQuery();

                Writelog("插入数据：" + word.English);

                _log.Log((DateTime.Now - tu).ToString());
            }
            catch (Exception e)
            {
                Writelog("插入数据：" + word.Chinese + " -- " + word.English + "失败");
                Writelog(e.Message);
            }
            finally
            {

            }
        }

        public void InsertWord(string english,string chinese)
        {
            Word wd = new Word()
            {
                English = english,
                Chinese = chinese,
                Date = DateTime.Now.ToString(),
                SearchCount = 0
            };
            InsertWord(wd);
        }

        public Word FindFromChinese(string chinese)
        {
            try
            {
                var tu = DateTime.Now;
                string strComm = string.Format("select english,chinese,date,search_count from {0} where chinese='{1}'"
                    , _ConInfo.table, chinese);

                _command.CommandText = strComm;

                _command.ExecuteNonQuery();

                _reader = _command.ExecuteReader();

                Writelog("发送查询 ：" + chinese);

                if (_reader.Read())
                {
                    string str = _reader.GetString("english");

                    string str1 = _reader.GetString("chinese");

                    string str2 = _reader.GetString("date");

                    string str3 = _reader.GetString("search_count");

                    Word wd = new Word();

                    wd.Chinese = str1;

                    wd.English = str;

                    wd.Date = str2;

                    wd.SearchCount = int.Parse(str3);

                    _reader.Close();

                    Writelog("获取结果成功");

                    _log.Log((DateTime.Now - tu).ToString());

                    return wd;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception e)
            {
                Writelog(e.Message);

                _reader.Close();

                return null;
            }

        }

        public Word FindFromEnglish(string english)
        {
            try
            {
                var tu = DateTime.Now;
                string strComm = string.Format("select english,chinese,date,search_count from {0} where english='{1}'"
                    , _ConInfo.table, english);

                _command.CommandText = strComm;

                _command.ExecuteNonQuery();

                _reader = _command.ExecuteReader();

                Writelog("发送查询 ：" + english);

                if (_reader.Read())
                {
                    string str = _reader.GetString("english");

                    string str1 = _reader.GetString("chinese");

                    string str2 = _reader.GetString("date");

                    string str3 = _reader.GetString("search_count");

                    Word wd = new Word();

                    wd.Chinese = str1;

                    wd.English = str;

                    wd.Date = str2;

                    wd.SearchCount = int.Parse(str3);

                    _reader.Close();

                    Writelog("获取结果成功");

                    _log.Log((DateTime.Now - tu).ToString());

                    return wd;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception e)
            {
                Writelog(e.Message);

                _reader.Close();

                return null;
            }

        }

        public List<Word> LoadDataFromDataBase()
        {

            try
            {
                ShowWait?.Invoke(true);

                List<Word> Lw = new List<Word>();
                var tu = DateTime.Now;
                string strComm = string.Format("select english,chinese,date,search_count from {0}"
                    , _ConInfo.table);

                _command.CommandText = strComm;

                _command.ExecuteNonQuery();

                _reader = _command.ExecuteReader();

                Writelog("发送查询整个表");

                while (_reader.Read())
                {
                    string str = _reader.GetString("english");

                    string str1 = _reader.GetString("chinese");

                    string str2 = _reader.GetString("date");

                    string str3 = _reader.GetString("search_count");

                    Word wd = new Word();

                    wd.Chinese = str1;

                    wd.English = str;

                    wd.Date = str2;

                    wd.SearchCount = int.Parse(str3);

                    Lw.Add(wd);
                }

                _reader.Close();

                Writelog("获取结果成功");

                _log.Log((DateTime.Now - tu).ToString());

                ShowWait?.Invoke(false);

                return Lw;
            }
            catch (Exception e)
            {
                Writelog(e.Message);

                _reader.Close();

                ShowWait?.Invoke(false);

                return null;
            }
        }

        public void UnloadToDataBase(List<Word> Lw)
        {
            Thread th = new Thread(new ThreadStart(() =>
            {
                try
                {
                    ShowWait?.Invoke(true);

                    var tu = DateTime.Now;

                    string OldTable = _ConInfo.table + "_old";

                    if (TabelExists(OldTable))
                    {
                        DropTable(OldTable);
                    }

                    string strComm = string.Format(" CREATE TABLE {0} LIKE {1}", OldTable, _ConInfo.table);

                    _command.CommandText = strComm;

                    _command.ExecuteNonQuery();

                    strComm = string.Format("INSERT INTO {0} SELECT * FROM {1}", OldTable, _ConInfo.table);

                    _command.CommandText = strComm;

                    _command.ExecuteNonQuery();

                    strComm = string.Format("truncate table {0}", _ConInfo.table);

                    _command.CommandText = strComm;

                    _command.ExecuteNonQuery();

                    foreach (var wd in Lw)
                    {
                        InsertWord(wd);
                    }

                    Writelog("数据上传到数据库完成");

                    _log.Log((DateTime.Now - tu).ToString());

                    ShowWait?.Invoke(false);
                }
                catch (Exception e)
                {
                    WriteError("数据上传到数据库失败\r\n" + e.Message);
                    ShowWait?.Invoke(false);
                }
            }));
            th.IsBackground = true;
            th.Start();
        }

        public bool TabelExists(string tableName)
        {
            string strComm = string.Format("SELECT table_name FROM information_schema.TABLES WHERE table_name ='{0}'",
                tableName);

            _command.CommandText = strComm;

            _command.ExecuteNonQuery();

            Writelog("查询表是否存在 " + tableName);

            _reader = _command.ExecuteReader();

            bool rtn = _reader.Read();

            _reader.Close();

            return rtn;
        }

        public void DropTable(string tableName)
        {
            string strComm = string.Format("DROP TABLE {0}", tableName);

            _command.CommandText = strComm;

            _command.ExecuteNonQuery();

            Writelog("删除表 " + tableName);
        }
        public void Writelog(string log)
        {
            _log.Log(log);
            LogEvent?.Invoke(log);
        }

        public void WriteError(string error)
        {
            Writelog(error);

            ErrorMessage?.Invoke(error);
        }
    }

    public class ConnectSqlInfo
    {
        #region 属性
        public string DataBase { get; set; }

        public string ConIp { get; set; }

        public string userId { get; set; }

        public string password { get; set; }

        public string charset { get; set; }

        public string table { get; set; }
        #endregion

        public override string ToString()
        {
            string str = string.
                Format("server = {0}; User Id = {1}; password = {2}; Database = {3};Old Guids=true;",
                ConIp,userId,password,DataBase);
            return str;
        }
    }
}
