using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using System;
using System.ComponentModel.DataAnnotations;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "Demo Page", GUID = "ffc2b5dd-847f-46da-a405-ce74cc168e95", Description = "")]
    public class DemoPage : PageData
    {
        
                [CultureSpecific]
                [Display(
                    Name = "Main body",
                    Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual XhtmlString MainBody { get; set; }


              [CultureSpecific]
              [Display(
                  Name = "Heading",
                  Description = "The  heading will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                  GroupName = SystemTabNames.Content,
                  Order = 1)]
           public virtual String Heading  { get; set; }

    }
}