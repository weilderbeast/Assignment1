#pragma checksum "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Pages\Adults\Adults.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffaee48efdccf47d3fd0ed90bfe7a205f87bda1d"
// <auto-generated/>
#pragma warning disable 1591
namespace Assignment1.Pages.Adults
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Assignment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Assignment1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Assignment1.Shared.Components.NavMenu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Assignment1.Shared.Components.SideBar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Assignment1.Data.Persistence;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Assignment1.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Assignment1.Shared.Components.FamilyList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Assignment1.Shared.Components.Notifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Assignment1.Data.Notifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Assignment1.Data.Notifications.NotificationModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Pages\Adults\Adults.razor"
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "adults-main");
            __builder.AddAttribute(2, "b-wohj4zlpcx");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "adults");
            __builder.AddAttribute(5, "b-wohj4zlpcx");
            __builder.AddMarkupContent(6, "<div class=\"adults-title\" b-wohj4zlpcx>\r\n            Adults\r\n        </div>\r\n        ");
            __builder.OpenElement(7, "form");
            __builder.AddAttribute(8, "class", "adult-form");
            __builder.AddAttribute(9, "b-wohj4zlpcx");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "adult-form-fields");
            __builder.AddAttribute(12, "b-wohj4zlpcx");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "form-section");
            __builder.AddAttribute(15, "b-wohj4zlpcx");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "form-group");
            __builder.AddAttribute(18, "b-wohj4zlpcx");
            __builder.AddMarkupContent(19, "<label class=\"label\" for=\"fname\" b-wohj4zlpcx>First name</label>\r\n                        ");
            __builder.OpenElement(20, "input");
            __builder.AddAttribute(21, "class", "input");
            __builder.AddAttribute(22, "type", "text");
            __builder.AddAttribute(23, "id", "fname");
            __builder.AddAttribute(24, "name", "fname");
            __builder.AddAttribute(25, "placeholder", "first name...");
            __builder.AddAttribute(26, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Pages\Adults\Adults.razor"
                                             _fname

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _fname = __value, _fname));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(28, "b-wohj4zlpcx");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "form-group");
            __builder.AddAttribute(32, "b-wohj4zlpcx");
            __builder.AddMarkupContent(33, "<label class=\"label\" for=\"lname\" b-wohj4zlpcx>Last name</label>\r\n                        ");
            __builder.OpenElement(34, "input");
            __builder.AddAttribute(35, "class", "input");
            __builder.AddAttribute(36, "type", "text");
            __builder.AddAttribute(37, "id", "lname");
            __builder.AddAttribute(38, "name", "lname");
            __builder.AddAttribute(39, "placeholder", "last name...");
            __builder.AddAttribute(40, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Pages\Adults\Adults.razor"
                                             _lname

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _lname = __value, _lname));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(42, "b-wohj4zlpcx");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                    ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "form-group");
            __builder.AddAttribute(46, "b-wohj4zlpcx");
            __builder.AddMarkupContent(47, "<label class=\"label\" for=\"age\" b-wohj4zlpcx>Age</label>\r\n                        ");
            __builder.OpenElement(48, "input");
            __builder.AddAttribute(49, "class", "input");
            __builder.AddAttribute(50, "type", "number");
            __builder.AddAttribute(51, "id", "age");
            __builder.AddAttribute(52, "name", "age");
            __builder.AddAttribute(53, "placeholder", "age...");
            __builder.AddAttribute(54, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Pages\Adults\Adults.razor"
                                                                                                                  _age

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(55, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _age = __value, _age, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(56, "b-wohj4zlpcx");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                    ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "form-group");
            __builder.AddAttribute(60, "b-wohj4zlpcx");
            __builder.AddMarkupContent(61, "<label class=\"label\" for=\"sex\" b-wohj4zlpcx>Sex</label>\r\n                        \r\n                        ");
            __builder.OpenElement(62, "select");
            __builder.AddAttribute(63, "class", "input");
            __builder.AddAttribute(64, "style", "width: 212px; height: 34px;");
            __builder.AddAttribute(65, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 35 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Pages\Adults\Adults.razor"
                                                                                          _sex

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(66, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _sex = __value, _sex));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(67, "b-wohj4zlpcx");
            __builder.OpenElement(68, "option");
            __builder.AddAttribute(69, "value");
            __builder.AddAttribute(70, "b-wohj4zlpcx");
            __builder.AddMarkupContent(71, "\r\n                                Select sex\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                            ");
            __builder.OpenElement(73, "option");
            __builder.AddAttribute(74, "value", "M");
            __builder.AddAttribute(75, "b-wohj4zlpcx");
            __builder.AddMarkupContent(76, "\r\n                                M\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                            ");
            __builder.OpenElement(78, "option");
            __builder.AddAttribute(79, "value", "F");
            __builder.AddAttribute(80, "b-wohj4zlpcx");
            __builder.AddMarkupContent(81, "\r\n                                F\r\n                            ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n                ");
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "class", "form-section");
            __builder.AddAttribute(85, "b-wohj4zlpcx");
            __builder.OpenElement(86, "div");
            __builder.AddAttribute(87, "class", "form-group");
            __builder.AddAttribute(88, "b-wohj4zlpcx");
            __builder.AddMarkupContent(89, "<label class=\"label\" for=\"hair-color\" b-wohj4zlpcx>Hair color</label>\r\n                        ");
            __builder.OpenElement(90, "input");
            __builder.AddAttribute(91, "class", "input");
            __builder.AddAttribute(92, "type", "text");
            __builder.AddAttribute(93, "id", "hair-color");
            __builder.AddAttribute(94, "name", "hair-color");
            __builder.AddAttribute(95, "placeholder", "hair color...");
            __builder.AddAttribute(96, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 53 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Pages\Adults\Adults.razor"
                                             _hairColor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(97, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _hairColor = __value, _hairColor));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(98, "b-wohj4zlpcx");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n                    ");
            __builder.OpenElement(100, "div");
            __builder.AddAttribute(101, "class", "form-group");
            __builder.AddAttribute(102, "b-wohj4zlpcx");
            __builder.AddMarkupContent(103, "<label class=\"label\" for=\"eye-color\" b-wohj4zlpcx>Eye color</label>\r\n                        ");
            __builder.OpenElement(104, "input");
            __builder.AddAttribute(105, "class", "input");
            __builder.AddAttribute(106, "type", "text");
            __builder.AddAttribute(107, "id", "eye-color");
            __builder.AddAttribute(108, "name", "eye-color");
            __builder.AddAttribute(109, "placeholder", "eye color...");
            __builder.AddAttribute(110, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 58 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Pages\Adults\Adults.razor"
                                             _eyeColor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(111, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _eyeColor = __value, _eyeColor));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(112, "b-wohj4zlpcx");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n                    ");
            __builder.OpenElement(114, "div");
            __builder.AddAttribute(115, "class", "form-group");
            __builder.AddAttribute(116, "b-wohj4zlpcx");
            __builder.AddMarkupContent(117, "<label class=\"label\" for=\"height\" b-wohj4zlpcx>Height</label>\r\n                        ");
            __builder.OpenElement(118, "input");
            __builder.AddAttribute(119, "class", "input");
            __builder.AddAttribute(120, "type", "text");
            __builder.AddAttribute(121, "id", "height");
            __builder.AddAttribute(122, "name", "height");
            __builder.AddAttribute(123, "placeholder", "height...");
            __builder.AddAttribute(124, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 63 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Pages\Adults\Adults.razor"
                                             _height

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(125, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _height = __value, _height));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(126, "b-wohj4zlpcx");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n                    ");
            __builder.OpenElement(128, "div");
            __builder.AddAttribute(129, "class", "form-group");
            __builder.AddAttribute(130, "b-wohj4zlpcx");
            __builder.AddMarkupContent(131, "<label class=\"label\" for=\"weight\" b-wohj4zlpcx>Weight</label>\r\n                        ");
            __builder.OpenElement(132, "input");
            __builder.AddAttribute(133, "class", "input");
            __builder.AddAttribute(134, "type", "text");
            __builder.AddAttribute(135, "id", "weight");
            __builder.AddAttribute(136, "name", "weight");
            __builder.AddAttribute(137, "placeholder", "weight...");
            __builder.AddAttribute(138, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 68 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Pages\Adults\Adults.razor"
                                             _weight

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(139, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _weight = __value, _weight));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(140, "b-wohj4zlpcx");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(141, "\r\n                ");
            __builder.OpenElement(142, "div");
            __builder.AddAttribute(143, "class", "form-section");
            __builder.AddAttribute(144, "b-wohj4zlpcx");
            __builder.OpenElement(145, "div");
            __builder.AddAttribute(146, "class", "form-group");
            __builder.AddAttribute(147, "b-wohj4zlpcx");
            __builder.AddMarkupContent(148, "<label class=\"label\" for=\"job\" b-wohj4zlpcx>Job</label>\r\n                        ");
            __builder.OpenElement(149, "input");
            __builder.AddAttribute(150, "class", "input");
            __builder.AddAttribute(151, "type", "text");
            __builder.AddAttribute(152, "id", "job");
            __builder.AddAttribute(153, "name", "job");
            __builder.AddAttribute(154, "placeholder", "job...");
            __builder.AddAttribute(155, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 74 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Pages\Adults\Adults.razor"
                                                                                                                _job

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(156, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _job = __value, _job));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(157, "b-wohj4zlpcx");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(158, "\r\n                    ");
            __builder.OpenElement(159, "div");
            __builder.AddAttribute(160, "class", "form-group");
            __builder.AddAttribute(161, "b-wohj4zlpcx");
            __builder.AddMarkupContent(162, "<label class=\"label\" for=\"salary\" b-wohj4zlpcx>Salary</label>\r\n                        ");
            __builder.OpenElement(163, "input");
            __builder.AddAttribute(164, "class", "input");
            __builder.AddAttribute(165, "type", "text");
            __builder.AddAttribute(166, "id", "salary");
            __builder.AddAttribute(167, "name", "salary");
            __builder.AddAttribute(168, "placeholder", "salary...");
            __builder.AddAttribute(169, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 79 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Pages\Adults\Adults.razor"
                                             _salary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(170, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _salary = __value, _salary));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(171, "b-wohj4zlpcx");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(172, "\r\n                    ");
            __builder.OpenElement(173, "div");
            __builder.AddAttribute(174, "class", "form-group");
            __builder.AddAttribute(175, "b-wohj4zlpcx");
            __builder.AddMarkupContent(176, "<label class=\"label\" for=\"street\" b-wohj4zlpcx>Street name</label>\r\n                        ");
            __builder.OpenElement(177, "input");
            __builder.AddAttribute(178, "class", "input");
            __builder.AddAttribute(179, "type", "text");
            __builder.AddAttribute(180, "id", "street");
            __builder.AddAttribute(181, "name", "street");
            __builder.AddAttribute(182, "placeholder", "street name...");
            __builder.AddAttribute(183, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 83 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Pages\Adults\Adults.razor"
                                                                                                                              _street

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(184, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _street = __value, _street));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(185, "b-wohj4zlpcx");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(186, "\r\n                    ");
            __builder.OpenElement(187, "div");
            __builder.AddAttribute(188, "class", "form-group");
            __builder.AddAttribute(189, "b-wohj4zlpcx");
            __builder.AddMarkupContent(190, "<label class=\"label\" for=\"house-nr\" b-wohj4zlpcx>House nr</label>\r\n                        ");
            __builder.OpenElement(191, "input");
            __builder.AddAttribute(192, "class", "input");
            __builder.AddAttribute(193, "type", "number");
            __builder.AddAttribute(194, "id", "house-nr");
            __builder.AddAttribute(195, "name", "house-nr");
            __builder.AddAttribute(196, "placeholder", "house nr...");
            __builder.AddAttribute(197, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 88 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Pages\Adults\Adults.razor"
                                             _houseNr

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(198, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _houseNr = __value, _houseNr, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(199, "b-wohj4zlpcx");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(200, "\r\n            ");
            __builder.OpenElement(201, "button");
            __builder.AddAttribute(202, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 92 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Pages\Adults\Adults.razor"
                              Submit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddEventPreventDefaultAttribute(203, "onclick", 
#nullable restore
#line 92 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Pages\Adults\Adults.razor"
                                                               true

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(204, "b-wohj4zlpcx");
            __builder.AddContent(205, "Submit");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 98 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Pages\Adults\Adults.razor"
      
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
