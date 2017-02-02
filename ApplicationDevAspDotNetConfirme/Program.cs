using System.Diagnostics;

namespace ApplicationDevAspDotNetConfirme
{
    class Program
    {
        static void Main(string[] args)
        {
            Candidat laurentDecamps = new Candidat()
            {
                AnneesExperience = 12,
                Passion = "Informatique",
                Technos = ".NET",
                Lang = "ASP .NET MVC5",
                Motivation = "Rejoindre un Pure Player Microsoft " +
                    "Rejoindre une structure à taille humaine" +
                    "Nouveaux defis",
               PosteRecherche = Candidat.DeveloppeurDotNETConfirme

            };

            if (laurentDecamps.AnneesExperience >= 2
               && laurentDecamps.Passion.Contains(@"Informatique")
               && laurentDecamps.Technos.Contains(@".NET")
               && laurentDecamps.Lang.Contains(@"ASP .NET MVC")
               && laurentDecamps.Motivation.Contains(@"Rejoindre un Pure Player Microsoft")
               && laurentDecamps.Motivation.Contains(@"Rejoindre une structure à taille humaine")
               && laurentDecamps.Motivation.Contains(@"Nouveaux defis")
               && laurentDecamps.PosteRecherche == Candidat.DeveloppeurDotNETConfirme
               )
            {
                PostulerChezDELSSI();
            }
        }

        /// <summary>
        /// Postuler la société DELSSI en affichant 
        /// </summary>
        private static void PostulerChezDELSSI()
        {
            ProcessStartInfo start = new ProcessStartInfo();            
            start.FileName = "CVDecampsLaurent.doc";

            start.WindowStyle = ProcessWindowStyle.Hidden;
            start.CreateNoWindow = true;
            
            using (Process proc = Process.Start(start))
            {
                proc.WaitForExit();
            }
        }
    }
}
