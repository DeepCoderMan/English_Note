using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Enlish_Note
{
    public partial class CheckedSheet : UserControl
    {
        CheckSet _CheckSet;

        public delegate void SendResult(Word word, string answer,bool IsTrue);

        public event SendResult SendResultEvent;
        public CheckedSheet()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 添加控件后必须初始化
        /// </summary>
        /// <param name="checkSet"></param>
        public void Initial(CheckSet checkSet)
        {
            _CheckSet = checkSet;

            IndexLabel.Text = _CheckSet.Index.ToString();

            QuestionTabel.Text = _CheckSet.QuestionMode == eQuestionMode.Chinese ? _CheckSet.WordSet.Chinese : _CheckSet.WordSet.English;
        }
        private void switchButton1_ValueChanged(object sender, EventArgs e)
        {
            if (switchButton1.Value == true)
            {
                var rtn = JudgeAnser(AnswerText.Text);
                if (rtn == 2)
                {
                    switchButton1.Value = false;
                    //balloonTip1.Enabled = true;
                    return;
                }
                switchButton1.Enabled = false;
                if (rtn == 0)
                {
                    ResLight.BackColor = Color.Red;
                }
                else
                {
                    ResLight.BackColor = Color.Green;
                }
                AnswerText.Enabled = false;
                SendResultEvent?.Invoke(_CheckSet.WordSet,AnswerText.Text,rtn == 0 ? false : true);
            }
        }
        void ShowBalloon(Control control, string caption, string text)
        {
            //balloonTip1.SetBalloonCaption(control, caption);
            //balloonTip1.SetBalloonText(control,Text);
            //balloonTip1.ShowBalloon(control);
        }

        /// <summary>
        /// 判断结果 0 错误，1 正确 2 格式不对
        /// </summary>
        /// <param name="answer"></param>
        /// <returns></returns>
        int JudgeAnser(string answer)
        {
            if(answer == string.Empty)
            {
                return 0;
            }

            Regex regChina = new Regex("^[^\x00-\xFF]");

            Regex regEnglish = new Regex("^[a-zA-Z]");

            int rtn = 0;

            switch (_CheckSet.QuestionMode)
            {
                case  eQuestionMode.Chinese:
                    if (regEnglish.IsMatch(answer))
                    {
                        if (answer.ToLower() == _CheckSet.WordSet.English.ToLower())
                        {
                            rtn = 1;
                        }
                        else
                        {
                            rtn = 0;
                        }
                    }
                    else
                    {
                        rtn = 2;
                    }
                    break;

                case eQuestionMode.English:
                    if (regChina.IsMatch(answer))
                    {
                        if (_CheckSet.WordSet.Chinese.Contains(answer) && answer.Length > _CheckSet.WordSet.Chinese.Length - 1)
                        {
                            rtn = 1;
                        }
                        else
                        {
                            rtn = 0;
                        }
                    }
                    else
                    {
                        rtn = 2;
                    }
                    break;
            }

            return rtn;
        }

        public void SetEnable(bool isEnable)
        {
            switchButton1.Enabled = isEnable;
            AnswerText.Enabled = isEnable;
        }
    }

    public enum eQuestionMode
    {
        English,
        Chinese
    }

    public class CheckSet
    {
        public eQuestionMode QuestionMode { get; set; }

        public int Index { get; set; }

        public Word WordSet { get; set; }
    }
}
