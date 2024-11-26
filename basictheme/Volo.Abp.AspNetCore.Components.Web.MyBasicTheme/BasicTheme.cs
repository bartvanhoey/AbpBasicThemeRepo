using System;
using Volo.Abp.AspNetCore.Components.Web.MyBasicTheme.Themes.Basic;
using Volo.Abp.AspNetCore.Components.Web.Theming.Layout;
using Volo.Abp.AspNetCore.Components.Web.Theming.Theming;
using Volo.Abp.DependencyInjection;
using MyMainLayout = Volo.Abp.AspNetCore.Components.Web.MyBasicTheme.Themes.Basic.MyMainLayout;

namespace Volo.Abp.AspNetCore.Components.Web.MyBasicTheme;

[ThemeName(Name)]
public class BasicTheme : ITheme, ITransientDependency
{
    public const string Name = "Basic";

    public virtual Type GetLayout(string name, bool fallbackToDefault = true)
    {
        switch (name)
        {
            case StandardLayouts.Application:
            case StandardLayouts.Account:
            case StandardLayouts.Empty:
                return typeof(MyMainLayout);
            default:
                return fallbackToDefault ? typeof(MyMainLayout) : typeof(NullLayout);
        }
    }
}