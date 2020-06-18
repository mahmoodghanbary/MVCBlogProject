﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
   public class PageCommentRepository:IPageCommentRepository
   {
       private MyCmsContext db;

       public PageCommentRepository(MyCmsContext context)
       {
           db = context;
       }
       public IEnumerable<PageComment> GetCommentByNewsId(int pageId)
       {
           return db.PageComments.Where(c => c.PageID == pageId);
       }

       public bool AddComment(PageComment comment)
       {
           try
           {
                db.PageComments.Add(comment);
                db.SaveChanges();
                return true;
           }
           catch (Exception)
           {

               return false;
           }
       }
    }
}
