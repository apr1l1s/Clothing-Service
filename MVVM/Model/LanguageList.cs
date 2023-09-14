using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clothing_Service
{
    static class LanguageList
    {
        public enum LanguageTag
        {
            RU, EN
        }
        public enum WordTag
        {
            Login, Password, AppTitle
        }
        public class LanguageListElem
        {
            public LanguageTag language;
            public WordTag word;
            public string data;
        }
        public static List<LanguageListElem> list = new List<LanguageListElem>()
        {
            new LanguageListElem(){
                language = LanguageTag.RU,
                word = WordTag.Login,
                data = "Логин"
            },
            new LanguageListElem(){
                language = LanguageTag.RU,
                word = WordTag.Password,
                data = "Пароль"
            },
            new LanguageListElem(){
                language = LanguageTag.RU,
                word = WordTag.AppTitle,
                data = "Вещевая служба"
            },
            new LanguageListElem(){
                language = LanguageTag.EN,
                word = WordTag.Login,
                data = "Login"
            },
            new LanguageListElem(){
                language = LanguageTag.EN,
                word = WordTag.Password,
                data = "Password"
            },
            new LanguageListElem(){
                language = LanguageTag.EN,
                word = WordTag.AppTitle,
                data = "Clothing Service"
            },
        };
    }
}
