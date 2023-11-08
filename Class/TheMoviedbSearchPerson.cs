using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace TheMoviesHub.Class
{
    public static class TheMoviedbSearchPerson
    {
        public static MvcHtmlString PageLinks(this HtmlHelper html, PagingInfo pagingInfo, Func<int, string> pageUrl)
        {
            StringBuilder result = new StringBuilder();
            string anchorInnerHtml = "";
            for(int i = 1; i <= pagingInfo.Totalpages; i++)
            {
                TagBuilder tag = new TagBuilder("a");
                anchorInnerHtml = AnchorInnerHtml(i, pagingInfo);
                if (anchorInnerHtml == "..")
                    tag.MergeAttribute("href", "#");
                else 
                    tag.MergeAttribute("href",pageUrl(i));
                tag.InnerHtml = anchorInnerHtml;
                if (i == pagingInfo.CurrentPage)
                {
                    tag.AddCssClass("active");
                }
                tag.AddCssClass("padding");
                if(anchorInnerHtml != "")
                    result.Append(anchorInnerHtml);
            }
            return MvcHtmlString.Create(result.ToString());
        }
        public static string AnchorInnerHtml(int i, PagingInfo pagingInfo)
        {
            string anchorInnerHtml = "";
            if (pagingInfo.TotalPages <= 10)
                anchorInnerHtml = i.ToString();
        }
    }
}