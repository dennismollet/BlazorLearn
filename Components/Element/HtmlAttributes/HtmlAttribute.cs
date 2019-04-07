namespace Blazor.HtmlElements
{
    public abstract class HtmlAttribute : IBuildAttributeString
    {
        public HtmlAttribute()
        {
            
        }

        public abstract string Key {get;}

        public abstract string BuildAttributeString();
    }
}