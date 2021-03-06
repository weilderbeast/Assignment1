// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Assignment1.Pages.Adults
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\University\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\University\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\University\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\University\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\University\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\University\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\University\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\University\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\University\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Assignment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\University\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Assignment1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\University\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Assignment1.Shared.Components.NavMenu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\University\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Assignment1.Shared.Components.SideBar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\University\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Assignment1.Data.Persistence;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\University\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Assignment1.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\University\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Assignment1.Shared.Components.FamilyList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\University\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Assignment1.Shared.Components.Notifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\University\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Assignment1.Data.Notifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\University\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Assignment1.Data.Notifications.NotificationModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\University\RiderProjects\Assignment1\Assignment1\Pages\Adults\Adults.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Adults")]
    public partial class Adults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 98 "D:\University\RiderProjects\Assignment1\Assignment1\Pages\Adults\Adults.razor"
      
    private string _fname;
    private string _lname;
    private string _age;
    private string _hairColor;
    private string _eyeColor;
    private string _weight;
    private string _height;
    private string _sex;
    private string _job;
    private string _salary;
    private string _street;
    private string _houseNr;

    private async Task Submit()
    {
        var adult = new Adult
        {
            FirstName = _fname,
            LastName = _lname,
            HairColor = _hairColor,
            EyeColor = _eyeColor,
            Age = int.Parse(_age),
            Weight = float.Parse(_weight),
            Height = int.Parse(_height),
            Sex = _sex
        };
        var Job = new Job
        {
            JobTitle = _job,
            Salary = int.Parse(_salary)
        };
        adult.JobTitle = Job;
        
        await FileContextAsync.GetAdultsAsync();
        Console.WriteLine("got to getting the id");
        var id = FileContextAsync.GetCachedAdults().Last().Id;

        var family = new Family(){
            StreetName = _street,
            HouseNumber = int.Parse(_houseNr)
        };

        family.Adults.Add(adult);

        adult.Id = id + 1;
        //ValidateFamily(Family);
        //Notify(adult);
        Clear();
        Console.WriteLine("got here");
        await FileContextAsync.PostAdult(adult);
        Console.WriteLine("posted adult");
        await FileContextAsync.PostFamily(family);
        Console.WriteLine("posted family");
    }

    private async void Notify(Adult Adult){
        var content = "Successfully added " + Adult.FirstName + " " + Adult.LastName + " to the list";
        var title = "Operation finished successfully";
        await NotificationManager.Show(title, content, NotificationType.Success);
    }

    // private void ValidateFamily(Family family){
    //     var families = FileContext.Families;
    //     //if a family with this name already exists, add the adult there, otherwise make it's own family
    //     foreach(var fam in families){
    //         if(fam.Adults[0].FirstName.Equals(family.Adults[0].LastName)){
    //             fam.Adults.Add(family.Adults[0]);
    //         } else{
    //             FileContext.Families.Add(family);
    //         }
    //     }
    //     FileContext.SaveChanges();
    // }

    private void Clear()
    {
        _fname = "";
        _lname = "";
        _age = "";
        _sex = "";
        _hairColor = "";
        _eyeColor = "";
        _height = "";
        _weight = "";
        _job = "";
        _salary = "";
        _street = "";
        _houseNr = "";
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NotificationManager NotificationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FileContextAsync FileContextAsync { get; set; }
    }
}
#pragma warning restore 1591
