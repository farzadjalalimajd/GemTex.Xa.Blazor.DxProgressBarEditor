using DevExpress.ExpressApp.Blazor.Components.Models;
using DevExpress.ExpressApp.Blazor.Editors;
using DevExpress.ExpressApp.Model;
using GemTex.ExpressApp.Blazor.Editors.Models;
using Microsoft.AspNetCore.Components;

namespace GemTex.ExpressApp.Blazor.Editors;

public class DxProgressBarPropertyEditor : BlazorPropertyEditorBase
{
    public DxProgressBarPropertyEditor(Type objectType, IModelMemberViewItem model) : base(objectType, model) { }

    public override DxProgressBarModel ComponentModel => (DxProgressBarModel)base.ComponentModel;

    protected override IComponentModel CreateComponentModel() => new DxProgressBarModel() { CssClass = "w-100" };

    protected override RenderFragment CreateViewComponentCore(object dataContext)
    {
        var componentModel = new DxProgressBarModel
        {
            Value = (double)(this.GetPropertyValue(dataContext) ?? 0),
            Thickness = "4px",
            ShowLabel = false,
            CssClass = "w-100",
            SizeMode = DevExpress.Blazor.SizeMode.Small
        };

        return componentModel.GetComponentContent();
    }

    protected override void ReadValueCore()
    {
        base.ReadValueCore();
        ComponentModel.Value = (double)PropertyValue;
    }
}
