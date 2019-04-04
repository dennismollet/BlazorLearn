using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Blazor.Components;
using Blazor.HtmlElements;

namespace Blazor.Components
{
    public class SynergyGrid : BlazorComponent
    {
        public SynergyGrid()
        {

        }

        public SynergyGrid(List<GridHeader> headers, List<GridRow> gridRows, List<GridFooter> footers)
        {
            Headers = headers;
            Rows = gridRows;
            Footers = footers;
        }
        public virtual List<GridHeader> Headers { get; set; } = new List<GridHeader>();
        public virtual List<GridRow> Rows { get; set; } = new List<GridRow>();
        public virtual List<GridFooter> Footers { get; set; } = new List<GridFooter>();
    }

    public abstract class GridHeader
    {
        public GridHeader()
        {

        }

        public GridHeader(List<GridHeaderColumn> columns)
        {
            Columns = columns;
        }

        public List<GridHeaderColumn> Columns { get; set; } = new List<GridHeaderColumn>();
    }

    public class SimpleGridHeader : GridHeader
    {
        public SimpleGridHeader()
        {

        }

        public SimpleGridHeader(List<SimpleGridHeaderColumn> columns)
            : base()
        {
            Columns.AddRange(columns);
        }
    }


    public abstract class GridHeaderColumn
    {
        public GridHeaderColumn(string headerText, TableHeaderElement element)
        {
            HeaderText = headerText;
            Element = element;
        }
        public string HeaderText { get; set; }
        public TableHeaderElement Element { get; set; }

        public string BuildElement()
        {
            return "";
            //return $"{Element.BuildElementStartTag()}{HeaderText}{Element.BuildElementEndTag()}";
        }
    }





    public abstract class NormalHtmlElement : HtmlElement
    {
        public NormalHtmlElement()
        {

        }

        public NormalHtmlElement(List<string> cssClasses)
        {
            CssClasses = cssClasses;
        }

        protected List<HtmlElement> Elements { get; set; } = new List<HtmlElement>();
        protected List<string> CssClasses { get; set; } = new List<string>();
        protected abstract string BuildAttributes();
        private string BuildCssClasses() => CssClasses.Count > 0 ? $"class=\"{string.Join(" ", CssClasses)}\"" : "";

        // public virtual string BuildElementStartTag() => $"<{GetElementTag()} {BuildCssClasses()} {BuildAttributes()}>";
        // public virtual string BuildElementEndTag() => $"</{GetElementTag()}>";
        // public virtual string BuildElement() => $"{BuildElementStartTag()}{Elements.Select(e => e.BuildElement())}{BuildElementEndTag()}";

    }

    public class TableHeaderElement : NormalHtmlElement, IHtmlElement
    {
        public TableHeaderElement(string colspan, List<string> cssClasses)
        {
            ColSpan = colspan;
            CssClasses = cssClasses;
        }

        protected override string Tag => throw new System.NotImplementedException();

        string ColSpan { get; set; }

        public override string BuildElementString()
        {
            throw new System.NotImplementedException();
        }

        protected override string BuildAttributes() => ColSpan.Length > 0 ? $"colspan='{ColSpan}'" : "";
        //protected override string GetElementTag() => "th";
    }

    public class SimpleGridHeaderColumn : GridHeaderColumn
    {
        public SimpleGridHeaderColumn(string headerText, TableHeaderElement element)
            : base(headerText, element)
        {

        }
    }

    public abstract class GridRow
    {
        public GridRow()
        {

        }

        public GridRow(List<string> values)
        {
            Values = values;
        }
        public List<string> Values { get; set; }
    }

    public abstract class GridFooter
    {
        public GridFooter()
        {

        }

        public GridFooter(List<string> values)
        {
            Values = values;
        }
        public List<string> Values { get; set; } = new List<string>();
    }

    public class SimpleGridRow : GridRow
    {
        public SimpleGridRow(List<string> values)
            : base(values)
        {

        }
    }

    public class SimpleGridFooter : GridFooter
    {
        public SimpleGridFooter()
            : base()
        {

        }

        public SimpleGridFooter(List<string> values)
            : base(values)
        {

        }
    }
}