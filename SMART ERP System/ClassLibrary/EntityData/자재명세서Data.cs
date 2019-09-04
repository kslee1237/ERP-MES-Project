using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EntityData
{
    public class 자재명세서Data : EntityData<자재명세서>
    {
        public List<string> Get자재List(string 자재번호)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.자재명세서
                            select x;

                return query.Select(x => x.자재번호).Distinct().ToList();
            }
        }

        public List<자재명세서> Get자재명세서(string 제품번호)
        {
            using (ERPEntities context = new ERPEntities())
            {
                var query = from x in context.자재명세서
                            where x.제품번호 == 제품번호
                            select x;

                return query.ToList();
            }
        }

        public List<제품> SearchByCode(string text)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                return entities.제품.Where(x => x.제품번호.StartsWith(text)).ToList();
            }
        }
    }
}
