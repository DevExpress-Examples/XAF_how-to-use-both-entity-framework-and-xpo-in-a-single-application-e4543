<!-- default file list -->
*Files to look at*:

* [EntityFrameworkSampleObject.cs](./CS/MultipleORMsExample.Module/BusinessObjects/EntityFrameworkSampleObject.cs) (VB: [EntityFrameworkSampleObject.vb](./VB/MultipleORMsExample.Module/BusinessObjects/EntityFrameworkSampleObject.vb))
* [XpoSampleObject.cs](./CS/MultipleORMsExample.Module/BusinessObjects/XpoSampleObject.cs) (VB: [XpoSampleObject.vb](./VB/MultipleORMsExample.Module/BusinessObjects/XpoSampleObject.vb))
* [Updater.cs](./CS/MultipleORMsExample.Module/DatabaseUpdate/Updater.cs) (VB: [Updater.vb](./VB/MultipleORMsExample.Module/DatabaseUpdate/Updater.vb))
* [WebApplication.cs](./CS/MultipleORMsExample.Web/WebApplication.cs) (VB: [WebApplication.vb](./VB/MultipleORMsExample.Web/WebApplication.vb))
* **[WinApplication.cs](./CS/MultipleORMsExample.Win/WinApplication.cs) (VB: [WinApplication.vb](./VB/MultipleORMsExample.Win/WinApplication.vb))**
<!-- default file list end -->
# How to: Use both Entity Framework and XPO in a Single Application


<p>This example demonstrates how to create a simple XAF application that uses both Entity Framework (EF) and eXpress Persistent Objects (XPO) business models. For instance, this approach can be required if you want to reuse the Entity Framework model from a non-XAF application in your existing XPO-based XAF project. As a result, your application will access two databases, the first one via XPO and the second - via EF.</p><p>The complete description is available in the <a href="http://documentation.devexpress.com/#Xaf/CustomDocument3476"><u>How to: Use both Entity Framework and XPO in a Single Application</u></a> topic.</p><br />
<p><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-use-both-entity-framework-and-xpo-in-a-single-application-e4543/13.1.5+/media/6316e026-5868-492b-9687-c12ad1d08118.png"><br />
<strong>See also:</strong> <br />
<a href="https://www.devexpress.com/Support/Center/p/E1150">How to prevent altering the legacy database schema when creating an XAF application</a><u><br />
</u><a href="https://www.devexpress.com/Support/Center/p/E4896">How to implement XPO data models connected to different databases within a single application</a></p>

<br/>


