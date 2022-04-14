using System;
using System.Collections.Generic;
using System.Text;

namespace SolutionTest2.Data.Entities
{
    public class CategoryTranslation
    {
        public int Id { set; get; }
        public int CategoryId { set; get; }
        public string Name { set; get; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }
        public string LanguageId { set; get; }
        public string SeoAlias { set; get; }

        public CategoryTest Category { get; set; }
        //1 to many

        public Language Language { get; set; }
    }
}
