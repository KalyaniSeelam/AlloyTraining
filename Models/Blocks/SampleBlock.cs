using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations;

namespace AlloyTraining.Models.Blocks
{
    [ContentType(DisplayName = "Sample Block", GUID = "d64f81ef-457a-4c2e-82a7-3d35c9298a9c", Description = "This is a Sample Block.")]
    public class SampleBlock : BlockData
    {
        
                [CultureSpecific]
                [Display(
                    Name = "Name",
                    Description = "Name field's description",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual string Name { get; set; }

        [Display(
             Name = "Content",
             Description = "Content field's description",
             GroupName = SystemTabNames.Content,
             Order = 1)]
        public virtual XhtmlString Content { get; set; }

    }
}