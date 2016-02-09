using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace SentiosData.Model
{
    public class RSSReader
    {
        private static string _cvpisURL = "http://mw.eviesiejipirkimai.lt/NoticeRss/BTSHTTPReceive.dll?days=3&amp;noticeType=1";
        public static XDocument GetRssFeed()
        {

            XDocument feedXml = XDocument.Load(_cvpisURL);


            return feedXml;

        }
    }
}
