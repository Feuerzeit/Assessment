using System;
using System.Reflection;

namespace GEC6.Blog.Yan.WebAPIService.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}