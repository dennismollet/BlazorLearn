namespace Blazor.HtmlElements
{
    public abstract class HtmlElement : IHtmlElement
    {
        protected HtmlElement() { }
        protected abstract string Tag { get; }
        public abstract string BuildElementString();
    }
}