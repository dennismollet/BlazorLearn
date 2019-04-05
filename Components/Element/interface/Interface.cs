using System.Collections.Generic;

namespace Blazor.HtmlElements
{
    public interface IRenderElement
    {
        string RenderElement();
        string Tag { get; }
    }

    public interface ICssClass
    {

    }

    // public interface IAttribute<T>
    //     where T : IHtmlAttributeList
    // {

    // }

    public interface INestableElement : IRenderElement
    {
        void AddElement(IRenderElement element);
        string RenderChildren();
    }

    public interface IValueElement
    {
        string Value { get; }
    }

    public interface IHtmlAttribute
    {
        string BuildAttribute();
        string Key {get;}
    }
}