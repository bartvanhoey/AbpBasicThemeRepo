using AbpTest.Localization;
using Volo.Abp.AspNetCore.Components;

namespace AbpTest.Blazor.Client;

public abstract class AbpTestComponentBase : AbpComponentBase
{
    protected AbpTestComponentBase()
    {
        LocalizationResource = typeof(AbpTestResource);
    }
}
