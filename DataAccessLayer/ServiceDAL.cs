using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repository;

namespace DataAccessLayer
{
    public class ServiceDAL
    {
        List<int> r = new List<int>();
        public void InsertImportSerivceAndTime(List<tblservice> objService)
        {
            try
            {
                SpaPracticeEntities context = new SpaPracticeEntities();

                foreach (tblservice tls in objService)
                {
                    context.tblservices.Add(tls);
                    context.SaveChanges();
                    r.Add(tls.ServiceId);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void InsertImportRateAndEffectiveDate(List<tblmapservice> objMapService)
        {
            try
            {
                SpaPracticeEntities context = new SpaPracticeEntities();

                    int i=0;
                    foreach (tblmapservice tls in objMapService)
                    {
                        while (i < r.Count)
                        {
                            tls.FK_ServiceId = (r[i] == 0 ? 0 : r[i]);
                            context.tblmapservices.Add(tls);
                            context.SaveChanges();
                            break;
                        }
                        i++;
                    }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
