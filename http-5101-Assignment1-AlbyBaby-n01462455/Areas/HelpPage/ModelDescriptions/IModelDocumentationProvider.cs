using System;
using System.Reflection;

namespace http_5101_Assignment1_AlbyBaby_n01462455.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}