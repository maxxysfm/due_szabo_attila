using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data;
//using System.Globalization;

namespace KözvelemenyKutatas
{
    public class DataAccess : IDisposable
    {
        /// <summary>
        /// Adatokhoz való hozzáférés és módosítás.
        /// Forrás:
        /// https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/sql/linq/
        /// </summary>
        DatabaseKozvelemenyEntities entities = new DatabaseKozvelemenyEntities();
        //Adat listázás
        public List<KUTATASOK> GetAllKutatas()
        {
            return entities.KUTATASOKs.ToList();
        }
        public List<LEADOTTVALASZOK> GetAllLEADOTTVALASZOK()
        {
            return entities.LEADOTTVALASZOKs.ToList();
        }
        public List<KERDESEK> GetAllKERDESEK()
        {
            return entities.KERDESEKs.ToList();
        }
        public List<VALASZOK> GetAllVALASZOK()
        {
            return entities.VALASZOKs.ToList();
        }
        public List<FELHASZNALOIADATOK> GetAllFELHASZNALOIADATOK()
        {
            return entities.FELHASZNALOIADATOKs.ToList();
        }
        //Érték visszakapás
        //Lehet át kéne írni jobbra? mert .Max ugyan ezt csinálja, és ha felszabadul egy ID akkor nem azt adja vissza kövezkezőnek.
        //2017.12.02 Done
        public decimal GetNextKERDESID()
        {
            //var result = ((from KERDESEKs in entities.KERDESEKs
            //               orderby
            //                 KERDESEKs.KERDESID descending
            //               select new
            //               {
            //                   KERDESEKs.KERDESID
            //               }).Take(1)).Single();
            //return result.KERDESID + 1;
            var result = ((from KERDESEKs in entities.KERDESEKs
                           orderby
                             KERDESEKs.KERDESID //descending
                           select new
                           {
                               KERDESEKs.KERDESID
                           }));
            SortedList<decimal, string> list = new SortedList<decimal, string>();
            foreach (var j in result)
            {
                list.Add(j.KERDESID,"");
            }
            decimal nextID = 1;
            foreach (var item in list.Keys)
            {
                if (nextID != item) break;
                else nextID++;
            }
            return nextID;
        }
        public decimal GetNextVALASZID()
        {
            //var result = ((from VALASZOKs in entities.VALASZOKs
            //               orderby
            //                 VALASZOKs.VALASZID descending
            //               select new
            //               {
            //                   VALASZOKs.VALASZID
            //               }).Take(1)).Single();
            //return result.VALASZID + 1;
            var result = ((from VALASZOKs in entities.VALASZOKs
                           orderby
                             VALASZOKs.VALASZID //descending
                           select new
                           {
                               VALASZOKs.VALASZID
                           }));
            SortedList<decimal, string> list = new SortedList<decimal, string>();
            foreach (var j in result)
            {
                list.Add(j.VALASZID, "");
            }
            decimal nextID = 1;
            foreach (var item in list.Keys)
            {
                if (nextID != item) break;
                else nextID++;
            }
            return nextID;
        }
        public decimal GetNextLEADOTTID()
        {
            //var result = ((from LEADOTTVALASZOKs in entities.LEADOTTVALASZOKs
            //               orderby
            //                 LEADOTTVALASZOKs.LEADOTTID descending
            //               select new
            //               {
            //                   LEADOTTVALASZOKs.LEADOTTID
            //               }).Take(1)).Single();
            //return result.LEADOTTID + 1;
            var result = ((from LEADOTTVALASZOKs in entities.LEADOTTVALASZOKs
                           orderby
                             LEADOTTVALASZOKs.LEADOTTID //descending
                           select new
                           {
                               LEADOTTVALASZOKs.LEADOTTID
                           }));
            SortedList<decimal, string> list = new SortedList<decimal, string>();
            foreach (var j in result)
            {
                list.Add(j.LEADOTTID, "");
            }
            decimal nextID = 1;
            foreach (var item in list.Keys)
            {
                if (nextID != item) break;
                else nextID++;
            }
            return nextID;
        }
        //Adatok listázása bizonyos filterekkel.
        public List<KUTATASOK> GetAllAvailableKutatas()
        {
            return entities.KUTATASOKs
                //.Where(e => e.KUTATASLOCK == true) Mindig true lesz.
                .Where(e => e.KEZDODATE < Variables.CurrentDate)
                .Where(e => e.VEGZODATE > Variables.CurrentDate)
                .ToList();
        }
        public List<KUTATASOK> GetAllUnavailableKutatas()
        {
            return entities.KUTATASOKs
                .Where(e => (e.KEZDODATE < Variables.CurrentDate && e.VEGZODATE < Variables.CurrentDate) 
                || 
                (e.KEZDODATE > Variables.CurrentDate && e.VEGZODATE > Variables.CurrentDate))
                .ToList();
        }
        public List<KUTATASOK> GetAllExpiredKutatas()
        {
            return entities.KUTATASOKs
                .Where(e => (e.KEZDODATE < Variables.CurrentDate && e.VEGZODATE < Variables.CurrentDate) && e.KUTATASLOCK == true)
                .ToList();
        }
        public List<KUTATASOK> GetAllLockedKutatas()
        {
            return entities.KUTATASOKs
                .Where(e => e.KUTATASLOCK == true)
                .ToList();
        }
        public List<KUTATASOK> GetAllUnlockedKutatas()
        {
            return entities.KUTATASOKs
                .Where(e => e.KUTATASLOCK == false)
                .ToList();
        }
        public List<KERDESEK> GetAllKerdesForResearch(KUTATASOK kutatas)
        {
            return entities.KERDESEKs
                //.Where(e => e.KUTATASLOCK == true) Mindig true lesz.
                .Where(e => e.KUTATASNEV == kutatas.KUTATASNEV)
                .ToList();
        }
        public List<VALASZOK> GetAllValaszForResearch(KUTATASOK kutatas)
        {
            string Query =
                $" SELECT C.KERDESID,C.VALASZID,C.LEIRAS FROM KUTATASOK A" +
                $" left JOIN KERDESEK B" +
                $" on A.KUTATASNEV = B.KUTATASNEV" +
                $" left JOIN VALASZOK C" +
                $" on B.KERDESID = c.KERDESID" +
                $" WHERE A.KUTATASNEV = '{kutatas.KUTATASNEV}'";
            return entities.Database.SqlQuery<VALASZOK>(Query).ToList();
        }
        public List<LEADOTTVALASZOK> GetAllLeadottvalaszForResearch(KUTATASOK kutatas)
        {
            string Query =
                $" SELECT C.LEADOTTID,C.EMAIL,C.KERDESID,C.VALASZID FROM KUTATASOK A" +
                $" left JOIN KERDESEK B" +
                $" on A.KUTATASNEV = B.KUTATASNEV" +
                $" left JOIN LEADOTTVALASZOK C" +
                $" on B.KERDESID = c.KERDESID" +
                $" WHERE A.KUTATASNEV = '{kutatas.KUTATASNEV}'";
            return entities.Database.SqlQuery<LEADOTTVALASZOK>(Query).ToList();
        }
        public List<KUTATASOK> GetAllAvailableKutatasToUser(FELHASZNALOIADATOK newUser)
        {
            //pain
            try
            {
                //string DateFix = Convert.ToString(DateTime.ParseExact(Convert.ToString(Variables.CurrentDate),CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern,CultureInfo.CurrentCulture));
                //  2017-11-28 10:34:09
                //  YYYY-MM-DD HH:MM.SS
                // Miért rakjuk ide? Mert ha megváltoztatjuk a dátumot menet közbe, akkor is megfelelően működik
                //DateTime date = DateTime.ParseExact(Convert.ToString(Variables.CurrentDate), "yyyy.MM.dd. HH:mm:ss", CultureInfo.CurrentCulture);
                string DateFix = Variables.CurrentDate.ToString("yyyy-MM-dd HH:mm:ss");
                string Query = 
                    $" SELECT k.KUTATASNEV,k.KEZDODATE,k.VEGZODATE,k.FOLIMIT,k.KUTATASLOCK FROM" +
                    $" (SELECT A.KUTATASNEV, A.KEZDODATE, A.VEGZODATE, A.FOLIMIT, A.KUTATASLOCK, COALESCE((nullif(count(c.KERDESID), 0) / nullif(count(distinct B.KERDESID), 0)), 0) AS 'RSZ' FROM KUTATASOK A" +
                    $" left JOIN KERDESEK B" +
                    $" on A.KUTATASNEV = B.KUTATASNEV" +
                    $" left JOIN LEADOTTVALASZOK C" +
                    $" on B.KERDESID = c.KERDESID" +
                    $" WHERE C.KERDESID not IN(SELECT KERDESID FROM LEADOTTVALASZOK WHERE KERDESID LIKE C.KERDESID AND EMAIL LIKE '{newUser.EMAIL}')" +
                    $" AND A.KEZDODATE < '{DateFix}'" +
                    $" AND A.VEGZODATE > '{DateFix}'" +
                    $" GROUP BY A.KUTATASNEV, A.KEZDODATE, A.VEGZODATE, A.FOLIMIT, A.KUTATASLOCK) K" +
                    $" WHERE k.RSZ < k.FOLIMIT";
                return entities.Database.SqlQuery<KUTATASOK>(Query).ToList();
                //List<KUTATASOK> kut = new List<KUTATASOK>();
                //foreach (KUTATASOK kutatas in result)
                //{
                //    var x = new KUTATASOK();
                //    x.KUTATASNEV = kutatas.KUTATASNEV;
                //    x.KEZDODATE = kutatas.KEZDODATE;
                //    x.VEGZODATE = kutatas.VEGZODATE;
                //    x.FOLIMIT = kutatas.FOLIMIT;
                //    x.KUTATASLOCK = kutatas.KUTATASLOCK;
                //    kut.Add(x);
                //}
                //return kut;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Hiba történt a listázás során: {e}");
                return GetAllAvailableKutatas();
            }
        }
        public int GetAllAvailableSlotsNumber(KUTATASOK newKutatas)
        {
            try
            {
                string Query =
                    $"SELECT k.RSZ FROM " +
                    $"(SELECT A.KUTATASNEV, A.KEZDODATE, A.VEGZODATE, A.FOLIMIT, A.KUTATASLOCK, COALESCE((nullif(count(c.KERDESID), 0) / nullif(count(distinct B.KERDESID), 0)), 0) AS 'RSZ' FROM KUTATASOK A " +
                    $"left JOIN KERDESEK B " +
                    $"on A.KUTATASNEV = B.KUTATASNEV " +
                    $"left JOIN LEADOTTVALASZOK C " +
                    $"on B.KERDESID = c.KERDESID " +
                    $"GROUP BY A.KUTATASNEV, A.KEZDODATE, A.VEGZODATE, A.FOLIMIT, A.KUTATASLOCK) K " +
                    $"WHERE k.KUTATASNEV = '{newKutatas.KUTATASNEV}'";
                var SlotNumber = entities.Database.SqlQuery<int>(Query).SingleOrDefault();
                return SlotNumber;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Hiba történt a létszám vizsgálata során: {e}");
                return 0;
            }
        }
        //Adatok törlése
        public bool DeleteDB()
        {
            try
            {
                //Biztos lehetne szebben is
                //Injection miatt nem a legjobb, ha stringet illesztünk bele.
                string deleteSql = 
                    "DELETE FROM LEADOTTVALASZOK;" +
                    "DELETE FROM VALASZOK;" +
                    "DELETE FROM KERDESEK;" +
                    "DELETE FROM FELHASZNALOIADATOK;" +
                    "DELETE FROM KUTATASOK";
                entities.Database.ExecuteSqlCommand(deleteSql);
                entities.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Hiba történt az adatbázis törlése során: {e}");
                return false;
            }
        }
        public bool DeleteAllKutatas()
        {
            try
            {
                //Biztos lehetne szebben is
                //Injection miatt nem a legjobb, ha stringet illesztünk bele.
                string deleteSql =
                    "DELETE FROM LEADOTTVALASZOK;" +
                    "DELETE FROM VALASZOK;" +
                    "DELETE FROM KERDESEK;" +
                    "DELETE FROM KUTATASOK";
                entities.Database.ExecuteSqlCommand(deleteSql);
                entities.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Hiba történt az adatbázis törlése során: {e}");
                return false;
            }
        }
        public bool DeleteAllUser()
        {
            try
            {
                //Biztos lehetne szebben is
                //Injection miatt nem a legjobb, ha stringet illesztünk bele.
                string deleteSql =
                    "DELETE FROM LEADOTTVALASZOK;" +
                    "DELETE FROM FELHASZNALOIADATOK;";
                entities.Database.ExecuteSqlCommand(deleteSql);
                entities.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Hiba történt a felhasználók törlése során: {e}");
                return false;
            }
        }
        public bool DeleteUser(FELHASZNALOIADATOK newUser)
        {
            // Miből kell törölni:
            //LEADOTTVALASZOk
            //FELHASZNALOIADATOK
            try
            {
                string deleteUserSql =
                    $"DELETE FROM LEADOTTVALASZOK WHERE EMAIL = '{newUser.EMAIL}';" +
                    $"DELETE FROM FELHASZNALOIADATOK WHERE EMAIL = '{newUser.EMAIL}';";
                entities.Database.ExecuteSqlCommand(deleteUserSql);
                entities.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Hiba történt az új felhasználó hozzáadása során: {e}");
                return false;
            }
        }
        //ADAT TÖRLÉSEK
        public bool DeleteKutatas(KUTATASOK kutatas)
        {
            // Miből kell törölni:
            //LEADOTTVALASZOK
            //VALASZOK
            //KERDESEK
            //KUTATASOK
            try
            {
                //1.
                if (GetAllAvailableSlotsNumber(kutatas) != 0)
                {
                    foreach (LEADOTTVALASZOK j in GetAllLeadottvalaszForResearch(kutatas))
                    {
                        DeleteLeadottvalaszok(j);
                    }
                }
                //2.
                foreach (VALASZOK j in GetAllValaszForResearch(kutatas))
                {
                    DeleteValaszok(j);
                }
                //3.
                DeleteKerdesek(kutatas);
                //4.
                string deleteKutatasSql =
                    $"DELETE FROM KUTATASOK WHERE KUTATASNEV = '{kutatas.KUTATASNEV}';";
                entities.Database.ExecuteSqlCommand(deleteKutatasSql);
                entities.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Hiba történt a kutatás törlése során: {e}");
                return false;
            }
        }
        public bool DeleteKerdesek(KUTATASOK kutatas)
        {
            try
            {
                string deleteKutatasSql =
                    $"DELETE FROM KERDESEK WHERE KUTATASNEV = '{kutatas.KUTATASNEV}';";
                entities.Database.ExecuteSqlCommand(deleteKutatasSql);
                entities.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Hiba történt a kutatás törlése során: {e}");
                return false;
            }
        }
        public bool DeleteValaszok(VALASZOK valasz)
        {
            try
            {
                string deleteKutatasSql =
                    $"DELETE FROM VALASZOK WHERE KERDESID = '{valasz.KERDESID}';";
                entities.Database.ExecuteSqlCommand(deleteKutatasSql);
                entities.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Hiba történt a kutatás törlése során: {e}");
                return false;
            }
        }
        public bool DeleteLeadottvalaszokByKerdesek(KERDESEK kerdes)
        {
            try
            {
                string deleteKutatasSql =
                    $"DELETE FROM LEADOTTVALASZOK WHERE KERDESID = '{kerdes.KERDESID}';";
                entities.Database.ExecuteSqlCommand(deleteKutatasSql);
                entities.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Hiba történt a kutatás törlése során: {e}");
                return false;
            }
        }
        public bool DeleteLeadottvalaszok(LEADOTTVALASZOK leadott)
        {
            try
            {
                string deleteKutatasSql =
                    $"DELETE FROM LEADOTTVALASZOK WHERE KERDESID = '{leadott.KERDESID}';";
                entities.Database.ExecuteSqlCommand(deleteKutatasSql);
                entities.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Hiba történt a kutatás törlése során: {e}");
                return false;
            }
        }
        //Hozzáadások
        public bool AddNewUser(FELHASZNALOIADATOK newUser)
        {
            try
            {
                entities.FELHASZNALOIADATOKs.Add(newUser);
                entities.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Hiba történt az új felhasználó hozzáadása során: {e}");
                return false;
            }
        }
        public bool AddNewKutatas(KUTATASOK newKutatas)
        {
            try
            {
                entities.KUTATASOKs.Add(newKutatas);
                entities.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Hiba történt az új kutatás hozzáadása során: {e}");
                return false;
            }
        }
        public bool AddNewKerdes(KERDESEK newKerdes)
        {
            try
            {
                //entities.KERDESEKs.Add(newKerdes);
                //entities.SaveChanges();
                //return true;
                entities.Database.ExecuteSqlCommand($"INSERT INTO KERDESEK VALUES({newKerdes.KERDESID},'{newKerdes.KUTATASNEV}','{newKerdes.LEIRAS}');");
                entities.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Hiba történt az új kérdés hozzáadása során: {e}");
                return false;
            }
        }
        public bool AddNewValasz(VALASZOK newValasz)
        {
            try
            {
                //entities.VALASZOKs.Add(newValasz);
                //entities.SaveChanges();
                //return true;
                entities.Database.ExecuteSqlCommand($"INSERT INTO VALASZOK VALUES({newValasz.KERDESID},'{newValasz.VALASZID}','{newValasz.LEIRAS}');");
                entities.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Hiba történt az új válasz hozzáadása során: {e}");
                return false;
            }
        }
        public bool AddNewLeadottvalasz(LEADOTTVALASZOK newLeadottvalasz)
        {
            try
            {
                entities.LEADOTTVALASZOKs.Add(newLeadottvalasz);
                entities.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Hiba történt az új kérdés hozzáadása során: {e}");
                return false;
            }
        }
        // Több ellenörzés
        public bool UserExists(FELHASZNALOIADATOK newUser)
        {
            try
            {
                int Count = entities.FELHASZNALOIADATOKs
                .Where(e => e.EMAIL == newUser.EMAIL)
                .Select(e => e.EMAIL)
                .Count();
                if (Count==0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Hiba történt az ellenörzés során: {e}");
                return false;
            }
        }
        // Admin form része
        public bool KutatasExists(KUTATASOK newKutatas)
        {
            try
            {
                int Count = entities.KUTATASOKs
                .Where(e => e.KUTATASNEV == newKutatas.KUTATASNEV)
                .Select(e => e.KUTATASNEV)
                .Count();
                if (Count == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Hiba történt az ellenörzés során: {e}");
                return false;
            }
        }
        public bool RefreshUser(FELHASZNALOIADATOK newUser)
        {
            try
            {
                entities.FELHASZNALOIADATOKs.Attach(newUser);
                var UserUpdate = entities.Entry(newUser);
                //Meg lehet szabni, milyen adatokat módosíthat a felhasználó a már meglévő adazbázisban!
                UserUpdate.Property(e => e.VEGZETTSEG).IsModified =true;
                UserUpdate.Property(e => e.NEM).IsModified = true;
                UserUpdate.Property(e => e.KOR).IsModified = true;
                entities.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Hiba történt a felhasználó frissítése során: {e}");
                return false;
            }
        }
        public bool KutatasLockCheckByDate()
        {
            //Összes kutatást ellenörzi és zárolja, ha aktívvá válik. Lezárja azokat a kutatásokat is, amik meghaladták a vegző dátumot.
            try
            {
                //Lehetne ToList-el is?
                var query =
                    entities.KUTATASOKs
                    .Where(e => e.KEZDODATE < Variables.CurrentDate)
                    .Where(e => e.VEGZODATE > Variables.CurrentDate)
                    .ToList();
                foreach (KUTATASOK kutatas in query)
                {
                    kutatas.KUTATASLOCK = true;
                }
                entities.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Hiba történt a dátum ellenözrés során: {e}");
                return false;
            }
        }
        //DIAGRAM
        //1. kutatásra összes adat szűrés nélkül
        public List<Tuple<string, decimal>> Diagramm(KUTATASOK kutatasname,decimal korMin,decimal korMax)
        {
            try
            {
                var query = from A in entities.KUTATASOKs
                            join B in entities.KERDESEKs on A.KUTATASNEV equals B.KUTATASNEV
                            join V in entities.VALASZOKs on B.KERDESID equals V.KERDESID
                            join C in entities.LEADOTTVALASZOKs on V.VALASZID equals C.VALASZID
                            join D in entities.FELHASZNALOIADATOKs on C.EMAIL equals D.EMAIL
                            where 
                            (
                            A.KUTATASNEV == kutatasname.KUTATASNEV && 
                            D.KOR >= korMin && 
                            D.KOR <= korMax
                            )
                            group V by V.LEIRAS;
                List<Tuple<string, decimal>> result = new List<Tuple<string, decimal>>();

                foreach (IGrouping<string, VALASZOK> grouping in query)
                {
                    result.Add(new Tuple<string, decimal>(grouping.Key, grouping.Count()));
                }
                return result;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Hiba történt: {e}");
                return null;
            }
        }
        public List<Tuple<string, decimal>> DiagrammGendreOnly(KUTATASOK kutatasname, decimal korMin, decimal korMax,string gender)
        {
            try
            {
                var query = from A in entities.KUTATASOKs
                            join B in entities.KERDESEKs on A.KUTATASNEV equals B.KUTATASNEV
                            join V in entities.VALASZOKs on B.KERDESID equals V.KERDESID
                            join C in entities.LEADOTTVALASZOKs on V.VALASZID equals C.VALASZID
                            join D in entities.FELHASZNALOIADATOKs on C.EMAIL equals D.EMAIL
                            where
                            (
                            A.KUTATASNEV == kutatasname.KUTATASNEV &&
                            D.KOR >= korMin &&
                            D.KOR <= korMax &&
                            D.NEM == gender
                            )
                            group V by V.LEIRAS;
                List<Tuple<string, decimal>> result = new List<Tuple<string, decimal>>();

                foreach (IGrouping<string, VALASZOK> grouping in query)
                {
                    result.Add(new Tuple<string, decimal>(grouping.Key, grouping.Count()));
                }
                return result;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Hiba történt: {e}");
                return null;
            }
        }
        public List<Tuple<string, decimal>> DiagrammVegzettsegOnly(KUTATASOK kutatasname, decimal korMin, decimal korMax,string vegzettseg)
        {
            try
            {
                var query = from A in entities.KUTATASOKs
                            join B in entities.KERDESEKs on A.KUTATASNEV equals B.KUTATASNEV
                            join V in entities.VALASZOKs on B.KERDESID equals V.KERDESID
                            join C in entities.LEADOTTVALASZOKs on V.VALASZID equals C.VALASZID
                            join D in entities.FELHASZNALOIADATOKs on C.EMAIL equals D.EMAIL
                            where
                            (
                            A.KUTATASNEV == kutatasname.KUTATASNEV &&
                            D.KOR >= korMin &&
                            D.KOR <= korMax &&
                            D.VEGZETTSEG == vegzettseg
                            )
                            group V by V.LEIRAS;
                List<Tuple<string, decimal>> result = new List<Tuple<string, decimal>>();

                foreach (IGrouping<string, VALASZOK> grouping in query)
                {
                    result.Add(new Tuple<string, decimal>(grouping.Key, grouping.Count()));
                }
                return result;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Hiba történt: {e}");
                return null;
            }
        }
        public List<Tuple<string, decimal>> DiagrammAll(KUTATASOK kutatasname, decimal korMin, decimal korMax,string gender,string vegzettseg)
        {
            try
            {
                var query = from A in entities.KUTATASOKs
                            join B in entities.KERDESEKs on A.KUTATASNEV equals B.KUTATASNEV
                            join V in entities.VALASZOKs on B.KERDESID equals V.KERDESID
                            join C in entities.LEADOTTVALASZOKs on V.VALASZID equals C.VALASZID
                            join D in entities.FELHASZNALOIADATOKs on C.EMAIL equals D.EMAIL
                            where
                            (
                            A.KUTATASNEV == kutatasname.KUTATASNEV &&
                            D.KOR >= korMin &&
                            D.KOR <= korMax &&
                            D.NEM == gender &&
                            D.VEGZETTSEG == vegzettseg
                            )
                            group V by V.LEIRAS;
                List<Tuple<string, decimal>> result = new List<Tuple<string, decimal>>();

                foreach (IGrouping<string, VALASZOK> grouping in query)
                {
                    result.Add(new Tuple<string, decimal>(grouping.Key, grouping.Count()));
                }
                return result;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Hiba történt: {e}");
                return null;
            }
        }
        public void Dispose()
        {
            ((IDisposable)entities).Dispose();
        }
    }
}
