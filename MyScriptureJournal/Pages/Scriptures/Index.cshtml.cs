using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Data;
using MyScriptureJournal.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MyScriptureJournal
{
    public class IndexModel : PageModel
    {
        private readonly MyScriptureJournal.Data.MyScriptureJournalContext _context;

        public IndexModel(MyScriptureJournal.Data.MyScriptureJournalContext context)
        {
            _context = context;
        }
        //Variables needed to sort by book and date
        public string BookSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }
        public IList<Scripture> Scripture { get;set; }
        [BindProperty(SupportsGet = true)]
        public IList<Scripture> BookList { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList Books { get; set; }
        [BindProperty(SupportsGet = true)]
        public string ScriptureBooks { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchStringBooks { get; set; }



        public async Task OnGetAsync(string sortOrder)
        {
            BookSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";

            IQueryable<Scripture> id = from s in _context.Scripture
                                       select s;
            switch(sortOrder)
            {
                case "name_desc":
                    id = id.OrderByDescending(s => s.Book);
                    break;
                case "Date":
                    id = id.OrderBy(s => s.DateAdded);
                    break;
                case "date_desc":
                    id = id.OrderByDescending(s => s.DateAdded);
                    break;
                default:
                    id = id.OrderBy(s => s.DateAdded);
                    break;
            }
            //Filters sort by date added/book
            Scripture = await id.AsNoTracking().ToListAsync();



            IQueryable<string> scriptureQuery = from m in _context.Scripture
                                           orderby m.Book
                                           select m.Book;

            var scriptures = from m in _context.Scripture
                             select m;
           
            Books = new SelectList(await scriptureQuery.Distinct().ToListAsync());

            if (!string.IsNullOrEmpty(SearchString))
            {
                scriptures = scriptures.Where(s => s.Notes.Contains(SearchString));
                Scripture = await scriptures.ToListAsync();
            }
            if (!string.IsNullOrEmpty(SearchStringBooks))
            {
                scriptures = scriptures.Where(s => s.Book == SearchStringBooks);
            }
            if (!string.IsNullOrEmpty(ScriptureBooks))
            {
                scriptures = scriptures.Where(x => x.Book == ScriptureBooks);
            }
            
            if (!string.IsNullOrEmpty(ScriptureBooks))
                {
                
                Scripture = await scriptures.ToListAsync();
            }
         
            //Filters search by book





        }
    }
}
