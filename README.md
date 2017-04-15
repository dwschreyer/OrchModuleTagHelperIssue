# OrchModuleTagHelperIssue

I attempted a project as per the demo by [Sébastian Ros on On.NET](https://channel9.msdn.com/Shows/On-NET/Sbastien-Ros-Modular-ASPNET-apps). Great demo and works well.

However, it seems that when TagHelpers are defined in an external assembly they do not work with AsModule projects. If the TagHelper is defined in the AsModule project it works fine.

My objective is to allow the TagHelpers to be shared between the modules.

I have created a sample project to illustrate the issue: https://github.com/dwschreyer/OrchModuleTagHelperIssue

Could someone else please attempt to duplicate and confirm this issue?
