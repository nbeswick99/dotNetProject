#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TaskManager.Models;
public class ToDo
{
  [Key]
  public int TaskId {get;set;}
  [Required(ErrorMessage = "Task is required")]
  public string TaskName {get;set;}

  public bool Frequent {get;set;} = false; 

  public DateTime CreatedAt {get;set;} = DateTime.Now;
  public DateTime UpdatedAt {get;set;} = DateTime.Now;

  public int UserId {get;set;}
  public User? TaskUser{get;set;}
}