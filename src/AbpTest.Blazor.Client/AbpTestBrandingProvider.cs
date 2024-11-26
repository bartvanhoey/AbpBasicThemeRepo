using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;
using Microsoft.Extensions.Localization;
using AbpTest.Localization;

namespace AbpTest.Blazor.Client;

public class AbpTestBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<AbpTestResource> _localizer;

    public AbpTestBrandingProvider(IStringLocalizer<AbpTestResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
