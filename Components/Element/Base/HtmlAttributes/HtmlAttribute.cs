namespace Blazor.HtmlElements
{
    public abstract class HtmlAttribute : IHtmlAttribute
    {
        public HtmlAttribute()
        {
            
        }

        public abstract string Key {get;}

        public abstract string BuildAttribute();
    }
}