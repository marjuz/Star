using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using SentiosData.Model;
using System.Net;
using System;
using System.IO;
using System.Text;

namespace SentiosService.Service
{
    public class RSSService
    {
        public static IEnumerable<RSS> ReturnRSSfeed()
        {
            var feedXml = SentiosData.Model.RSSReader.GetRssFeed();
            //
            var feeds = from feed in feedXml.Descendants("item")
                        select new RSS
                        {
                            Title = feed.Element("title").Value,
                            Link = feed.Element("link").Value,
                            Description = feed.Element("description").Value,//Regex.Match(feed.Element("description").Value, @"^.{1,180}\b(?<!\s)").Value,
                            SomeText = FindDate(feed.Element("description").Value)//html(feed.Element("link").Value).ToString()



                        };
        
         
            
            
            return feeds;
        }

        private static string FindDate(string html) 
        { 

            try{
            Regex rgx = new Regex(@"\d{2}/\d{2}/\d{4}");
            Match mat = rgx.Match(html);
            return mat.ToString();

            }
            catch (Exception ex)
            {
                return "Nepateikta";
            }

            
        }

        //private static string html(string url)
        //{
  
        //    Uri siteUri = new Uri(url);
        //    HttpWebRequest webReq = (HttpWebRequest)HttpWebRequest.Create(siteUri);
        //    try
        //        {
        //            webReq.CookieContainer = new CookieContainer();
        //            webReq.Method = "GET";
        //            using (WebResponse response = webReq.GetResponse())
        //            {
        //                using (Stream stream = response.GetResponseStream())
        //                {
        //                   StreamReader reader = new StreamReader(stream);
        //                   string htmlCode1 = reader.ReadToEnd();

        //                   string htmlCode = html2(htmlCode1); 
                            
        //                   return htmlCode;
        //                }
        //            }

        //        }
        //    catch (Exception ex)
        //    {
        //        return "Nepateikta";
        //    }
            
        //}
        //private static string html2(string url)
        //{
        //    string url2 = "https://pirkimai.eviesiejipirkimai.lt/app/rfq/publicpurchase.asp?PID=" + 
        //        getBetween(url, "/app/rfq/publicpurchase_header.asp?PID=","&amp;HL=0&amp;PP=&amp;B=&amp;PS=1&amp;HR=")+"&HL=0&PS=1&PP=";

        //    Uri siteUri = new Uri(url2);
        //    HttpWebRequest webReq = (HttpWebRequest)HttpWebRequest.Create(siteUri);
        //    try
        //    {
        //        webReq.CookieContainer = new CookieContainer();
        //        webReq.Method = "GET";
        //        using (WebResponse response = webReq.GetResponse())
        //        {
        //            using (Stream stream = response.GetResponseStream())
        //            {
        //                StreamReader reader = new StreamReader(stream);
        //                string htmlCode5 = reader.ReadToEnd().Trim();
        //                string htmlCode = getBetween2(htmlCode5, "(EET)\r\n                      </span><br>", "</td><td class=\"tblcell\" width=\"20%\"><span class=\"celllbl\">Transaction");
        //                return htmlCode;
        //            }
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        return "No Link";
        //    }

        //}



        //public static string getBetween(string strSource, string strStart, string strEnd)
        //{
        //    int Start, End;
        //    if (strSource.Contains(strStart) && strSource.Contains(strEnd))
        //    {
        //        Start = strSource.IndexOf(strStart, 0) + strStart.Length;
        //        End = strSource.IndexOf(strEnd, Start);
        //        return strSource.Substring(Start, End - Start);
        //    }
        //    else
        //    {
        //        return "";
        //    }
        //}
        //public static string getBetween2(string strSource2, string strStart2, string strEnd2)
        //{
        //    int Start, End;
        //    if (strSource2.Contains(strStart2) && strSource2.Contains(strEnd2))
        //    {
        //        Start = strSource2.IndexOf(strStart2, 0) + strStart2.Length;
        //        End = strSource2.IndexOf(strEnd2, Start);
        //        return strSource2.Substring(Start, End - Start);
        //    }
        //    else
        //    {
        //        return "";
        //    }
        //}

    }
}
