using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Json;
using Enlish_Note.mysql;

namespace Enlish_Note
{
    public class CsCore
    {
        #region 字段
        private static object _lock = new object();

        private static CsCore _Instal;

        private const string jsFilePath = "./json/LearnHistory.json";

        private Youdao _YoudaoForm;

        public ProgressForm pgForm;

        private List<Word> _ListWord;

        private mysqlOp _Sql;

        public delegate void TriggerHandle();

        public event TriggerHandle TriggerEvent;
        #endregion

        #region 属性
        public static CsCore Instal {
            get
            {
                lock (_lock)
                {
                    if (_Instal == null)
                    {
                        _Instal = new CsCore();
                    }
                    return _Instal;
                }
            }
        }

        public List<Word> ListWord { get { return _ListWord; } set { _ListWord = value; } }


        public Youdao YoudaoForm {
            get { return _YoudaoForm; }
            set { _YoudaoForm = value; }
        }

        public mysqlOp Sql
        {
            get { return _Sql; }
        }
        #endregion


        #region 初始化
        public CsCore()
        {
            LoadSetting();
            _YoudaoForm = new Youdao();
            _YoudaoForm.Show();
            _YoudaoForm.Hide();
        }

        private void LoadSetting()
        {
            JsonPaser js = new JsonPaser();
            js.FilePathName = jsFilePath;

            _ListWord = js.Deserialize<List<Word>>();
            if (_ListWord == null)
            {
                _ListWord = new List<Word>();
            }

            _Sql = new mysqlOp();
            
        }
        #endregion

        #region 方法
        public void AddWord(Word word)
        {
            _ListWord.Add(word);
            TriggerEvent?.Invoke();
        }

        public void AddWord(string english, string chinese)
        {
            var word = new Word()
            {
                Date = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"),
                English = english,
                Chinese = chinese,
                SearchCount = 0
            };

            AddWord(word);
        }

        public Word SeachWordOfEnglish(string English)
        {
            if (_ListWord == null)
                return null;

            bool bExits = _ListWord.Exists((e) =>
            {
                if (e.English == English)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            });

            if (!bExits)
            {
                return null;
            }

            var rtn = _ListWord.Find((e) =>
            {
                if (e.English == English)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            });
            return rtn;
        }

        public Word SeachWordOfChinese(string Chinese)
        {
            if (_ListWord == null)
                return null;

            bool bExits = _ListWord.Exists((e) =>
            {
                if (e.Chinese == Chinese)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            });

            if (!bExits)
            {
                return null;
            }

            var rtn = _ListWord.Find((e) =>
            {
                if (e.Chinese == Chinese)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            });
            return rtn;
        }

        public List<string> MatchingEnlish(string English)
        {
            List<string> rtn = new List<string>();
            foreach (var v in _ListWord)
            {
                if (v.English.ToLower().StartsWith(English.ToLower()) && English != string.Empty)
                {
                    rtn.Add(v.English);
                }
            }
            return rtn;
        }

        public List<Word> SeachWordOfDate(DateTime date)
        {
            if (_ListWord == null)
                return null;
            List<Word> rtn = _ListWord.FindAll((e) =>
            {
                if (Convert.ToDateTime(e.Date) - date < TimeSpan.FromDays(1) && 
                date - Convert.ToDateTime(e.Date) < TimeSpan.FromDays(1) &&
                Convert.ToDateTime(e.Date).Day == date.Day)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            });
            return rtn;
        }
        public void ChangeWord(Word objective, Word newWord)
        {
            _ListWord.Remove(objective);
            _ListWord.Add(newWord);
            TriggerEvent?.Invoke();
        }

        public void RemoveWord(Word word)
        {
            _ListWord.Remove(word);
            TriggerEvent?.Invoke();
        }
        public void SeveSetting()
        {
            JsonPaser js = new JsonPaser();
            js.FilePathName = jsFilePath;
            js.Serialize(_ListWord);
        }
        #endregion
    }

    public class Word
    {
        public string Date { get; set; }

        public string English { get; set; }

        public string Chinese { get; set; }

        public int SearchCount { get; set; }
    }
}
