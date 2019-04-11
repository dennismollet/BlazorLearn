using System.Collections.Generic;

namespace Blazor.HtmlElements
{
    public interface IRenderElement
    {
        string RenderElement();
        string Tag { get; }
        string InnerHtmlText { get; }
        IRenderElement SetInnerHtmlText(string text);
    }

    public interface INestableElement : IRenderElement
    {
        INestableElement AddChildElements(IRenderElement[] elements);        
        List<string> ValidChildTags { get; }
        List<IRenderElement> ChildElements { get; }
    }

    public interface IValueElement
    {
        string Value { get; }
    }

    public interface IAttributeElement
    {
        IBuildAttributesString Attributes {get;}
    }

    public interface IBuildAttributesString
    {
        void AddAttribute(IBuildAttributeString attribute);
        string BuildAttributesString();
    }
    public interface IBuildAttributeString
    {
        string BuildAttributeString();
        string Key {get;}
    }

    public interface IMultipleValueAttribute : IBuildAttributeString
    {
        void AddAttributeValues(params string[] values);
    }

    public interface IAreaShape
    {
        IBuildAttributeString BuildAreaAttribute();
    }
    
    public interface IAreaCoordinates
    {
        IBuildAttributeString BuildCoordinatesAttribute();
    }

}