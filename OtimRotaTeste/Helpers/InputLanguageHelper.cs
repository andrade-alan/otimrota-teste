using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace OtimRotaTeste.Helpers
{
    class InputLanguageHelper
    {
        InputLanguage _brazilianInput;
        InputLanguage _englishInput;


        public InputLanguageHelper()
        {
            _brazilianInput = GetInputLanguageByName("portuguese (brazil)");
            _englishInput = GetInputLanguageByName("english");
        }

        public void SetKeyboardLayout(InputLanguage layout)
        {
            InputLanguage.CurrentInputLanguage = layout;
        }


        public static InputLanguage GetInputLanguageByName(string inputName)
        {
            foreach (InputLanguage lang in InputLanguage.InstalledInputLanguages)
            {
                if (lang.Culture.EnglishName.ToLower().StartsWith(inputName))
                    return lang;
            }
            return null;
        }

        public void LoadBrazilianKeyboardLayout()
        {
            if (_brazilianInput != null)
                InputLanguage.CurrentInputLanguage = _brazilianInput;

            else
                InputLanguage.CurrentInputLanguage = InputLanguage.DefaultInputLanguage;
        }

        public void LoadEnglishKeyboardLayout()
        {
            if (_englishInput != null)
                InputLanguage.CurrentInputLanguage = _englishInput;
            else
                InputLanguage.CurrentInputLanguage = InputLanguage.DefaultInputLanguage;
        }
    }
}