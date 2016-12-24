using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScrapySharp.Network;
using HtmlAgilityPack;
using ScrapySharp.Extensions;
using ScrapySharp.Html.Forms;


namespace Webscraping_with_C_
{
    class Program 
    {
        static void Main(string[] args)
        {
            ScrapingBrowser Browser = new ScrapingBrowser();
            Browser.AllowAutoRedirect = true; //Browser has settings you can access in setup
            Browser.AllowMetaRedirect = true;
            WebPage PageResult = Browser.NavigateToPage(new Uri("http://localhost:51621/"));
            HtmlNode TitleNode = PageResult.Html.CssSelect(".navbar-brand").First();
            string PageTitle = TitleNode.InnerText;


            List<string> Names = new List<string>();
            var Table = PageResult.Html.CssSelect("#PersonTable").First();

            foreach (var row in Table.SelectNodes("tbody/tr"))
            {
                foreach(var cell in row.SelectNodes("td[1]"))
                {
                    Names.Add(cell.InnerText);
                }
            }

            Names.ForEach(i => Console.Write("{0}\n", i));
            Console.ReadLine();

            //find a form and send back data
            PageWebForm form = PageResult.FindFormById("dataform");
            //assign values to the form fields 
            form["UserName"] = "AJSON";
            form["Gender"] = "M";
            form.Method = HttpVerb.Post;
            WebPage resultsPage = form.Submit();


        }
    }
}
