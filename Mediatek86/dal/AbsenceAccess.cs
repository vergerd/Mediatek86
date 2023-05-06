﻿using Mediatek86.modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatek86.dal
{
    /// <summary>
    /// Classe permettant de gérer les demandes concernant les absences
    /// </summary>
    public class AbsenceAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;
        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public AbsenceAccess()
        {
            access = Access.GetInstance();
        }
        /// <summary>
        /// Récupère et retourne les absences concernant le personnel passé en paramètre
        /// </summary>
        /// <param name="personnel"></param>
        /// <returns></returns>
        public List<Absence> GetLesAbsences(Personnel personnel)
        {
            List<Absence> lesAbsences = new List<Absence>();
            if (access.Manager != null)
            {
                string req = "SELECT p.idpersonnel as idpersonnel, a.datedebut as datedebut, a.datefin as datefin, a.idmotif as idmotif, m.libelle as motif ";
                req += "FROM personnel p JOIN absence a ON (p.idpersonnel = a.idpersonnel) JOIN motif m ON (a.idmotif = m.idmotif) ";
                req += "WHERE p.idpersonnel = @idpersonnel ";
                req += "ORDER BY a.datedebut DESC;";
                Dictionary<string, Object> parameters = new Dictionary<string, Object>();
                parameters.Add("@idpersonnel", personnel.Idpersonnel);
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req, parameters);
                    if (records != null)
                    {
                        foreach (Object[] record in records)
                        {
                            Motif motif = new Motif((int)record[3], (string)record[4]);
                            Absence absence = new Absence((int)record[0], (DateTime)record[1], (DateTime)record[2], motif);
                            lesAbsences.Add(absence);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
            return lesAbsences;
        }

    }
}