using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enlish_Note.uControl
{
    public partial class ucExam : UserControl
    {
        int _CheckHight = 35;
        int _ScoreCount_Pass = 0;
        int _ScoreCount_Fail = 0;
        int _TimeLong = 0;
        bool _IsTimer = false;
        bool _IsRefresh = false;
        string ButtonStatus_Start = "结束考核";
        string ButtonStatus_End = "开始考核";

        List<CsFaild> _listFailed = new List<CsFaild>();
        eQuestionMode QuestionMode = new eQuestionMode();
        List<Word> _TestWord = new List<Word>();
        List<Word> _ListWord;
        public ucExam()
        {
            InitializeComponent();
        }

        private void ucExam_Load(object sender, EventArgs e)
        {
            QuestionMode = switchButton1.Value ? eQuestionMode.Chinese : eQuestionMode.English;
            buttonX1.Text = ButtonStatus_End;
            checkBoxX1.Checked = _IsRefresh;
        }
        public void Initial(List<Word> word)
        {
            _ListWord = word;
        }
        private void QuestionNum_Enter(object sender, EventArgs e)
        {
            //InitChecked();
        }
        private void InitChecked()
        {
            try
            {
                CheckPanel.Controls.Clear();

                var testCount = int.Parse(QuestionNum.Text);

                AddCheck(testCount);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AddCheck(int count)
        {
            var Temp = _ListWord.ToArray();

            var NgArray = GetNGArray(count);

            foreach (var index in NgArray)
            {
                CheckedSheet Cs = new CheckedSheet();

                CheckSet CsParam = new CheckSet();

                CsParam.Index = NgArray.FindIndex((i) => {
                    if (i == index)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                });

                CsParam.QuestionMode = QuestionMode;

                CsParam.WordSet = Temp[index];

                Cs.Initial(CsParam);

                Cs.Location = new Point(0, _CheckHight * CsParam.Index + 2);

                CheckPanel.Controls.Add(Cs);

                Cs.SendResultEvent += Cs_SendResultEvent;
            }

        }

        private void Cs_SendResultEvent(Word word, string answer, bool IsTrue)
        {
            if (IsTrue)
            {
                labelX1.Text = string.Format("Score: {0}", ++_ScoreCount_Pass);
            }
            else
            {
                _ScoreCount_Fail++;
                CsFaild temp = new CsFaild();
                temp.NG_Word = word;
                temp.NG_Answer = answer;
                _listFailed.Add(temp);
            }
        }

        private List<int> GetNGArray(int count)
        {
            var Temp = _ListWord.ToArray();

            count = count > Temp.Length ? Temp.Length : count;//考核数量不得大于已存数据的数量

            List<int> NgList = new List<int>();

            for (int i = 0; i < count; i++)
            {
                Random rd = new Random();
                int Ng = rd.Next(0, Temp.Length);

                if (NgList.Count > 0 && NgList.Contains(Ng))
                {
                    i--;
                    continue;
                }

                NgList.Add(Ng);
            }

            return NgList;
        }

        private void switchButton1_ValueChanged(object sender, EventArgs e)
        {
            QuestionMode = switchButton1.Value ? eQuestionMode.Chinese : eQuestionMode.English;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (CheckPanel.Controls.Count <= 0 || _IsRefresh)
            {
                InitChecked();
            }

            ManageUI();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_IsTimer)
            {
                labelX3.Text = string.Format("开始时长：{0}", _TimeLong++);
            }
            else
            {
                _TimeLong = 0;
                labelX3.Text = string.Format("开始时长：{0}", _TimeLong);
            }
        }

        private void ManageUI()
        {
            if (buttonX1.Text == ButtonStatus_End)
            {
                switchButton1.Enabled = false;
                QuestionNum.Enabled = false;
                buttonX1.Text = ButtonStatus_Start;
                foreach (var ct in CheckPanel.Controls)
                {
                    var temp = (CheckedSheet)ct;
                    temp.SetEnable(true);
                }
                _IsTimer = true;
            }
            else
            {
                switchButton1.Enabled = true;
                QuestionNum.Enabled = true;
                buttonX1.Text = ButtonStatus_End;
                foreach (var ct in CheckPanel.Controls)
                {
                    var temp = (CheckedSheet)ct;
                    temp.SetEnable(false);
                }
                _IsTimer = false;

                FailedForm form = new FailedForm(_listFailed);
                form.ShowDialog();
            }
        }

        private void checkBoxX1_CheckedChanged(object sender, EventArgs e)
        {
            _IsRefresh = checkBoxX1.Checked;
        }
    }

    public class CsFaild
    {
        public CsFaild()
        {

        }

        public Word NG_Word { get; set; }

        public string NG_Answer { get; set; }
    }
}
