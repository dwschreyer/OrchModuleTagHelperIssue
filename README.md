# Orchard AsModule TagHelper Issue

I attempted a project as per the demo by [Sébastian Ros on On.NET](https://channel9.msdn.com/Shows/On-NET/Sbastien-Ros-Modular-ASPNET-apps). Great demo and works well.

The AsModule feature is a great solutions for allowing different development teams within an organisation to plug features into a base solution. 

My objectives with this project is to investigate if:

- Base controllers can be shared between modules.
- Services (E.g. Repositories) can be shared between modules.
- TagHelpers can be shared between modules.

At first I was not able to get TagHelpers working when they were defined in an external project with the intention to be shared between modules. This has now been resolved! You can read how this was solved in the issue: https://github.com/OrchardCMS/Orchard2/issues/696

I will now start a different reference project in which I will describe how to achieve the above objectives as well as complete the following roadmap:

- Base views
- Project templates
- Settings on a per module basis`
- Real world demo application
- Guidance documentation

Will update this repo with the url as soon as there is something to show.
