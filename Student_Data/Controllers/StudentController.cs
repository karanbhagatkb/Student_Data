using Student_Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Student_Data.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbcontext _context;
        public StudentController()
        {
            _context = new ApplicationDbcontext();
        }
        // GET: Student
        public ActionResult Index(string filter)
        {
            var studenlist = new List<Student>();
            if (string.IsNullOrEmpty(filter))
            {
                studenlist = _context.students.ToList();
            }
            else
            {
                studenlist = _context.students.Where(x => x.Name.Contains(filter)
                                                     || x.LastName.Contains(filter)
                                                     || x.ClassName.Contains(filter)).ToList();
            }
            return View(studenlist);

        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            var studenlist = _context.students.Find(id);
            if (studenlist == null)
                return HttpNotFound();
            return View(studenlist);
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(Student student)
        {
            if (student == null)
                return HttpNotFound();
            _context.students.Add(student);
            _context.SaveChanges();
            return RedirectToAction("Index");


        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            var studentlist = _context.students.Find(id);
            if (studentlist == null)
                return HttpNotFound();
            return View(studentlist);
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(Student student)
        {
            if (student == null)
                return HttpNotFound();
            var studentlist = _context.students.Find(student.Id);
            if (student == null)
                return HttpNotFound();
            studentlist.Id = student.Id;
            studentlist.Name = student.Name;
            studentlist.LastName = student.LastName;
            studentlist.RollNo = student.RollNo;
            studentlist.Precentage = student.Precentage;
            _context.SaveChanges();
            return RedirectToAction("Index");

        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Student/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
