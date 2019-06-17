using KisGepKolcsonzoXKQCNV;
using KisGepKolcsonzo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisGepKolcsonzo
{
    public class DataAccess : IDisposable
    {
        KisGepKolcsonzoEntities entities = new KisGepKolcsonzoEntities();
        public List<Gep> GetAllGep()
        {
            return entities.Geps.ToList();
        }
        public List<Kolcsonze> GetAllKolcsonzes()
        {
            return entities.Kolcsonzes.ToList();
        }
        public List<Kolcsonze> GetAllKolcsonzes(Ugyfel ugyfel)
        {
            return entities.Kolcsonzes
                .Where(x=>x.UgyfelId == ugyfel.Id)
                .ToList();
        }
        public List<Ugyfel> GetAllUgyfel()
        {
            return entities.Ugyfels.ToList();
        }
        public int GetKolcsonzesAra(Kolcsonze kolcs)
        {
            var result = entities.Geps
                .Where(x => x.Id == kolcs.GepId).Single();
            return result.KolcsonzesAra;
        }
        public List<Ugyfel> GetAllUgyfel(decimal min)
        {
            return entities.Ugyfels
                .Where(x=>x.Kedvezmeny >= min)
                .ToList();
        }
        //public List<Tuple<string, decimal>> Chart()
        //{
        //    try
        //    {
        //        var query = entities.Ugyfels.ToList();
        //        List<Tuple<string, decimal>> result = new List<Tuple<string, decimal>>();
        //        foreach (IGrouping<string, Ugyfel> grouping in query)
        //        {
        //            /* Elég problémás, a chart állandóan elszáll.
        //             * Erre nem volt időm mert 3x újra csináltam a projectet :(
        //            */
        //            //result.Add(new Tuple<string, decimal>(grouping.Key,(decimal)grouping.Select(x=>x.Kedvezmeny)));
        //            result.Add(new Tuple<string, decimal>(grouping.Key, 5));
        //        }
        //        return result;
        //    }
        //    catch (Exception e)
        //    {
        //        return null;
        //    }
        //}
        public List<double> Chart()
        {
            try
            {
                var query = entities.Ugyfels.ToList();
                List<double> result = new List<double>();
                foreach (Ugyfel j in query)
                {
                    // Nem teljesen olyan, de majdnem.
                    // Nem csoportosítja a dupla értékeket.
                    result.Add((double)j.Kedvezmeny);
                }
                return result;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public void Dispose()
        {
            ((IDisposable)entities).Dispose();
        }
    }
}
