using FlotsBleusLibrary;

namespace FlotsBleusTest;

public class Tests
{
    private static Course _course;
    private static Entreprise _entreprise;
    private static Epreuve _epreuve;
    private static Penalite _penalite;
    private static Personne _personne;
    private static Voilier _voilier;
    private static VoilierEnCourse _voilierEnCourse;
    private static VoilierInscrit _voilierInscrit;
    
    [SetUp]
    public void Setup()
    {
        _course = new Course();
        _entreprise = new Entreprise("EPSI");
        _epreuve = new Epreuve(1, "Epreuve 1", 3);
        _penalite = new Penalite("1010", new TimeSpan(0, 05, 00), "Fautes pas très grave");
        _voilier = new Voilier("ABC");
        _personne = new Personne(1, "Gallien", "Noemi", new DateTime(2000, 02, 11), Personne.Roles.Skipper, _voilier);
        _voilierEnCourse = new VoilierEnCourse("123", "ABC");
        _voilierInscrit = new VoilierInscrit(_voilierEnCourse);
    }

    [Test]
    public void TestCourse()
    {
        _course.AjouterEpreuve(_epreuve);
        Assert.IsNotNull(_course);
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    }
    
}