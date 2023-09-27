using System.Text.RegularExpressions;

namespace DemoMVC.Models.Process
{
    public class StringProcess
    {
        public string AutoGenerateCode(string strInput)
        {
        string strResult = "", numPart = "", strPart = "";
        //tach phan tu so
        numPart = Regex.Match(strInput,@"/d+").Value;
        //tach phan tu chu tu stsrInput
        strPart = Regex.Match(strInput, @"\D+").Value;
        //TACH PHAN SO LEN MOT DON VI
        int intPart = (Convert.ToInt32(numPart)+1);
        //bo sung cac ki tu 0 con thieu
        for (int i = 0; i <numPart.Length - intPart.ToString().Length; i++)
        {
            strPart += "0";
        }
        strResult = strPart + intPart;
        return strResult;
        }
    }
}