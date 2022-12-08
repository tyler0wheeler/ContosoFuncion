using System;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;
using Microsoft.OpenApi.Models;
namespace Contoso.PrioritZ
{
public class TopicItemModel
{
public string Choice { get; set; }
public string Photo { get; set; }
}
public class TopicModel
{
[OpenApiProperty(Nullable = false, Description = "This is a topic")]
public string Topic { get; set; }
public string Details { get; set; }
public DateTime RespondBy { get; set; }
public string MyNotes { get; set; }
public string Photo { get; set; }
public TopicItemModel[] Choices {get;set;}
}
}