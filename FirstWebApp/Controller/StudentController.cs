using Microsoft.AspNetCore.Mvc;

public class StudentController : Controller
{
  // public JsonResult Get()
  // {
  //   return Json(Repository.GetStudents());
  // }

  public JsonResult Get(int arg = 5)
  {
    return Json(Repository.GetStudents(arg));
  }
}