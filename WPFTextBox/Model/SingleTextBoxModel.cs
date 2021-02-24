using System;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Controls;
using System.Windows.Input;
using WPFTextBox.Common;

namespace WPFTextBox.Model
{
    public class SingleTextBoxModel : NotifyPropertyChanged, IDataErrorInfo
    {
        private string name;
        private string value;
        private string unit;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public string Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = value;
                OnPropertyChanged(nameof(Value));
            }
        }

        public string Unit
        {
            get
            {
                return unit;
            }
            set
            {
                this.unit = value;
                OnPropertyChanged(nameof(Unit));
            }
        }

        private bool isEnabled = true;
        public bool IsEnabled
        {
            get => isEnabled;
            set
            {
                //if (isEnabled != value)
                //{
                //    isEnabled = value;
                //    TriggerValidatorManually();
                //}
                isEnabled = value;
                OnPropertyChanged(nameof(IsEnabled)); // Note:[SelectedIndex="0"] can trigger "PropertyChanged" evet
            }
        }


        private string toolTip;
        public string ToolTip
        {
            get
            {
                return toolTip;
            }
            set
            {

                if (value.Contains(Environment.NewLine))
                {
                    var tps = value.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                    var ss = tps.Select(t => string.Format("· {0}{1}", t, Environment.NewLine)).ToList();
                    this.toolTip = string.Join("", ss).TrimEnd(new char[] { '\r', '\n' });
                }
                else
                {
                    this.toolTip = value;
                }

                OnPropertyChanged(nameof(ToolTip));
            }
        }

        private string errorMsg;
        public string ErrorMsg
        {
            get
            {
                return errorMsg;
            }
            set
            {
                this.errorMsg = value;
                OnPropertyChanged(nameof(ErrorMsg));
            }
        }

        public string PreviewTextInputRegex { get; set; }


        public void SingleTextBox_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }

        public void SingleTextBox_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            if (string.IsNullOrEmpty(PreviewTextInputRegex))
            {
                e.Handled = false;
                return;
            }
            Regex re = new Regex(PreviewTextInputRegex);
            TextBox txtBox = sender as TextBox;

            bool match = false;
            string srcTxt = txtBox.Text;
            string selTxt = txtBox.SelectedText;
            string inChar = e.Text;

            if (!string.IsNullOrEmpty(selTxt))
            {
                int sl = txtBox.CaretIndex;
                int cl = selTxt.Length;
                int el = srcTxt.Length - cl - sl;
                string ss = srcTxt.Substring(0, sl);
                string es = srcTxt.Substring(sl + cl, el);

                string tryStr = ss + inChar + es;
                match = re.IsMatch(tryStr);
            }
            else
            {
                string txt = txtBox.Text.Insert(txtBox.CaretIndex, e.Text);
                match = re.IsMatch(txt);
            }

            if (match)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public Func<string, Tuple<string, string>> Validator { get; set; }
        public string Error => errorMsg;

        public string this[string columnName]
        {
            get
            {
                ErrorMsg = string.Empty;

                var tp = Validator?.Invoke(value);
                if (tp != null)
                {
                    if (!string.IsNullOrEmpty(tp.Item2))
                    {
                        ErrorMsg += tp.Item2;
                    }

                    ToolTip = tp.Item1;
                }
                return ErrorMsg;
            }
        }
    }
}
