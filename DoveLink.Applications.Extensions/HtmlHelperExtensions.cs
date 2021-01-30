
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DoveLink.Applications.Extensions
{
    public static class HtmlHelperExtensions
    {
        public static string CurrentController(this IHtmlHelper htmlHelper)
        {
            return htmlHelper.ViewContext.RouteData.Values["controller"] as string;
        }

        public static string CurrentAction(this IHtmlHelper htmlHelper)
        {
            return htmlHelper.ViewContext.RouteData.Values["action"] as string;
        }

        public static string ActiveClass(this IHtmlHelper htmlHelper, string controller, string action = "Index", string cssClass = "active")
        {
            return htmlHelper.IsActive(controller, action) ? cssClass : "";
        }

        public static bool IsActive(this IHtmlHelper htmlHelper, string controller, string action = "Index")
        {
            var isMatch = (string.IsNullOrEmpty(action) || CurrentAction(htmlHelper).ToUpper() == action.ToUpper()) &&
                (string.IsNullOrEmpty(controller) || CurrentController(htmlHelper).ToUpper() == controller.ToUpper());

            return isMatch;
        }

        public static HtmlString If(this IHtmlHelper htmlHelper, bool condition, string then, string _else = "")
        {
            return new HtmlString(condition ? then : _else);
        }

        public static HtmlString IfActive(this IHtmlHelper htmlHelper, string controller, string then, string _else = "")
        {
            var condition = htmlHelper.IsActive(controller);
            return htmlHelper.If(condition, then, _else);
        }

        public static HtmlString IfActive(this IHtmlHelper htmlHelper, string controller, string action, string then, string _else = "")
        {
            var condition = htmlHelper.IsActive(controller, action);
            return htmlHelper.If(condition, then, _else);
        }
    }
}
