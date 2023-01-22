using System.Collections.Generic;

namespace RLTrading.Model
{
    /// <summary>
    /// Zertifizierung Mocking
    /// </summary>
    public static class CertificationMocking
    {

        private static List<Certification> certifications;

        public static List<Certification> getCertifications()
        {

            if (certifications is null)
            {
                certifications = new()
                {
                    new Certification("None"),
                    new Certification("Striker"),
                    new Certification("Sweeper"),
                    new Certification("Tactician"),
                    new Certification("Acrobat"),
                    new Certification("Aviator"),
                    new Certification("Goalkeeper"),
                    new Certification("Guardian"),
                    new Certification("Juggler"),
                    new Certification("Playmaker"),
                    new Certification("Scorer"),
                    new Certification("Show-Off"),
                    new Certification("Sniper"),
                    new Certification("Turtle"),
                    new Certification("Paragon"),
                    new Certification("Victor")
                };
            }

            return certifications;
        }

    }
}
