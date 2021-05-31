using Gestionnnaire.connexion;
using Gestionnnaire.modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionnnaire.dal
{
    public class AccesDonnees
    {
        /// <summary>
        /// chaine de connexion à la bdd
        /// </summary>
        private static string connectionString = "server=localhost;user id=adminmlr1;password=password;database=mlr1;SslMode=none";
        /// <summary>
        /// Controle si l'utillisateur a le droit de se connecter (login, pwd)
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public static Boolean ControleAuthentification(string login, string pwd)
        {
            string req = "select * from responsable";
            req += " where login=@login and pwd=SHA2(@pwd, 256);";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@login", login);
            parameters.Add("@pwd", pwd);
            ConnexionBDD curs = ConnexionBDD.GetInstance(connectionString);
            curs.ReqSelect(req, parameters);
            if (curs.Read())
            {
                curs.Close();
                return true;
            }
            else
            {
                curs.Close();
                return false;
            }
        }

        /// <summary>
        /// Récupère et retourne les personnels provenant de la BDD
        /// </summary>
        /// <returns>liste des personnels</returns>
        public static List<Personnel> GetLesPersonnels()
        {
            List<Personnel> lesPersonnels = new List<Personnel>();


            string req = "SELECT idpersonnel, personnel.nom as nom, prenom, tel, mail, idservice, service.nom as service ";
            req += "FROM personnel JOIN service using(idservice);";
            ConnexionBDD curs = ConnexionBDD.GetInstance(connectionString);
            curs.ReqSelect(req, null);
            while (curs.Read())
            {
                Personnel personnel = new Personnel((int)curs.Field("idpersonnel"), (string)curs.Field("nom"), (string)curs.Field("prenom"), (string)curs.Field("tel"), (string)curs.Field("mail"), (int)curs.Field("idservice"), (string)curs.Field("service"));
                lesPersonnels.Add(personnel);
            }
            curs.Close();
            return lesPersonnels;
        }
        /// <summary>
        /// Suppression d'un personnel
        /// </summary>
        /// <param name="personnel">objet personnel à supprimer</param>
        public static void DelPersonnel(int idpersonnel)
        {
            string req = "delete from personnel where idpersonnel = @idpersonnel;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", idpersonnel);
            ConnexionBDD conn = ConnexionBDD.GetInstance(connectionString);
            conn.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Ajoute un personnel
        /// </summary>
        /// <param name="personnel"></param>
        public static void AddPersonnel(Personnel personnel)
        {
            string req = "INSERT INTO personnel(nom, prenom, tel, mail, idservice) ";
            req += "VALUES (@nom, @prenom, @tel, @mail, @idservice);";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@nom", personnel.Nom);
            parameters.Add("@prenom", personnel.Prenom);
            parameters.Add("@tel", personnel.Tel);
            parameters.Add("@mail", personnel.Mail);
            parameters.Add("@idservice", personnel.IdService);
            ConnexionBDD conn = ConnexionBDD.GetInstance(connectionString);
            conn.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Modification d'un personnel
        /// </summary>
        /// <param name="personnel"></param>
        public static void UpdatePersonnel(Personnel personnel)
        {
            string req = "update personnel set nom = @nom, prenom = @prenom, tel = @tel, mail = @mail, idservice = @idservice ";
            req += "where idpersonnel = @idpersonnel;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", personnel.IdPersonnel);
            parameters.Add("@nom", personnel.Nom);
            parameters.Add("@prenom", personnel.Prenom);
            parameters.Add("@tel", personnel.Tel);
            parameters.Add("@mail", personnel.Mail);
            parameters.Add("@idservice", personnel.IdService);
            ConnexionBDD conn = ConnexionBDD.GetInstance(connectionString);
            conn.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Récupère et retourne les profils provenant de la BDD
        /// </summary>
        /// <returns>liste des services</returns>
        public static List<Service> GetLesServices()
        {
            List<Service> lesServices = new List<Service>();
            string req = "SELECT * FROM service ORDER by nom;";
            ConnexionBDD curs = ConnexionBDD.GetInstance(connectionString);
            curs.ReqSelect(req, null);
            while (curs.Read())
            {
                Service service = new Service((int)curs.Field("idservice"), (string)curs.Field("nom"));
                lesServices.Add(service);
            }
            curs.Close();
            return lesServices;
        }


        /// <summary>
        /// Récupère et retourne les absences d'un personnel provenant de la BDD
        /// </summary>
        /// <returns>liste des absences d'un personnel</returns>
        /// <param name="idpersonnel"></param>
        public static List<Absence> GetLesAbsences(int idpersonnel)
        {
            List<Absence> lesAbsences = new List<Absence>();
            string req = "SELECT datedebut , datefin, idmotif, motif.libelle as motif ";
            req += "FROM absence JOIN motif using(idmotif) ";
            req += " WHERE idpersonnel = @idpersonnel;";
            ConnexionBDD curs = ConnexionBDD.GetInstance(connectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", idpersonnel);
            curs.ReqSelect(req, parameters);
            while (curs.Read())
            {
                Absence absence = new Absence(idpersonnel, (DateTime)curs.Field("datedebut"), (DateTime)curs.Field("datefin"), (int)curs.Field("idmotif"),(string)curs.Field("motif"));
                lesAbsences.Add(absence);
            }
            curs.Close(); 
            return lesAbsences;
        }
        /// <summary>
        /// Suppression d'une absence
        /// </summary>
        /// <param name="absence">objet personnel à supprimer</param>
        /// <param name="datedebut"></param>
        public static void DelAbsence(int idpersonnel, DateTime datedebut)
        {
            string req = "delete from absence where idpersonnel = @idpersonnel and datedebut = @datedebut;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", idpersonnel);
            parameters.Add("@datedebut", datedebut);
            ConnexionBDD conn = ConnexionBDD.GetInstance(connectionString);
            conn.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Ajoute une absence à unn personnel
        /// </summary>
        /// <param name="absence"></param>
        public static void AddAbsence(Absence absence)
        {
            string req = "INSERT INTO absence(idpersonnel, datedebut, datefin, idmotif) ";
            req += "VALUES (@idpersonnel, @datedebut, @datefin, @idmotif);";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", absence.IdPersonnel);
            parameters.Add("@datdebut", absence.DateDebut);
            parameters.Add("@datefin", absence.DateFin);
            parameters.Add("@idmotif", absence.IdMotif);
            ConnexionBDD conn = ConnexionBDD.GetInstance(connectionString);
            conn.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Modification d'une absence
        /// </summary>
        /// <param name="datedebutOld"></param>
        /// <param name="absence"></param>
        public static void UpdateAbsence(DateTime datedebutOld, Absence absence)
        {
            string req = "update absence set idpersonnel = @idpersonnel, datedebut = @datedebut, datefin = @datefin, idmotif = @idmotif ";
            req += "where idpersonnel = @idpersonnel and datedebut = @datedebutold";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", absence.IdPersonnel);
            parameters.Add("@datdebut", absence.DateDebut); 
            parameters.Add("@datefin", absence.DateFin);
            parameters.Add("@idmotif", absence.IdMotif);
            parameters.Add("@datedebutold", datedebutOld);
            ConnexionBDD conn = ConnexionBDD.GetInstance(connectionString);
            conn.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Récupère et retourne les motifs provenant de la BDD
        /// </summary>
        /// <returns>liste des motifs</returns>
        public static List<Motif> GetLesMotifs()
        {
            List<Motif> lesMotifs = new List<Motif>();
            string req = "SELECT * FROM motif ORDER by libelle;";
            ConnexionBDD curs = ConnexionBDD.GetInstance(connectionString);
            curs.ReqSelect(req, null);
            while (curs.Read())
            {
                Motif motif = new Motif((int)curs.Field("idmotif"), (string)curs.Field("libelle"));
                lesMotifs.Add(motif);
            }
            curs.Close();
            return lesMotifs;
        }




    }
}
