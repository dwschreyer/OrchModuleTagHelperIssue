# OrchModuleTagHelperIssue

I attempted a project as per the demo by [Sébastian Ros on On.NET](https://channel9.msdn.com/Shows/On-NET/Sbastien-Ros-Modular-ASPNET-apps). Great demo and works well.

The AsModule feature is a great solutions for 

My objectives are as follows:

- TagHelpers to be shared between modules.
- Services (E.g. Repositories) to be shared between modules.
- Base controllers to be shared between modules.

So far I am able to share services and base controllers.

However, it seems that when TagHelpers are defined in an external assembly they do not work with AsModule projects. If the TagHelper is defined in the AsModule project it works fine.

This issue is currently being tracked here: https://github.com/OrchardCMS/Orchard2/issues/696
