using System.Net.NetworkInformation;
using System.Security.Policy;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using OpenQA.Selenium.Appium.Service.Options;
//using UniqueId.UniqueId;

namespace OtimRotaTeste.PageObjects
{
    public static class Util
    {
        //UniqueId UId;

        /// <summary>
        /// Classe que define o UniqueId para obter a ID única de determinada classe
        /// </summary>
        /// <param name="Utility"></param>
        /// <returns></returns>

        //public static string GetId(string widgetName)
        //{
        //    var id = new UId(widgetName);
        //    return ((int)id.GetId()).ToString();
        //}

        //public static string GetId(UId id)
        //{
        //    return ((int)id.GetId()).ToString();
        //}
    }

    public class OtimRotaMainControls
    {
        #region Public Variables

        /// <summary>
        /// Relativas à árvore contida no objeto "tr-main.cpp"
        /// </summary>

        public const string OtimRotaMainGUIButtonClose = "Close";
        public const string OtimRotaMainGUIButtonNoSave = "";
        public const string OtimRotaItemPocRes = "Poços/Reservatórios";
        public const string OtimRotaItemPocos = "Poços";
        public const string OtimRotaMainGUIButtonNovo = "⏷  Novo";
        public const string OtimRotaItemProdutor = "Produtor";
        public const string OtimRotaMainGUIButtonOk = "Ok";
        #endregion
    }

    public class OtimRotaRunControls
    {
        #region Accessors

        public string PauseCaseId { get; }
        public string SelectCaseId { get; }
        public string RunId { get; }
        public string CloseId { get; }

        #endregion

        #region Construtor

        public OtimRotaRunControls()
        {
            //PauseCaseId = Util.GetId("tg_pause_all_cases");
            //SelectCaseId = Util.GetId("lst_run_cases");
            //RunId = Util.GetId("bt_run_anflex_xml");
            //CloseId = Util.GetId("bt_run_close");
        }

        #endregion
    }
}