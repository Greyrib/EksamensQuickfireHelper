using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EksamensQuickfireHelper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> subjectsProgrammering;
        List<string> subjectsSystemudvikling;

        public MainWindow ()
        {
            InitializeComponent ();

            Create_SubjectLists ();
        }

        void Create_SubjectLists ()
        {
            subjectsProgrammering = new List<string> () {
            "OOP Principles",
            "C# Class",
            "C# Object",
            "Data Representation",
            "Data type",
            "Data handling",
            "Program Flow",
            "Application Structure",
            "DCD",
            "SD",
            "Traceability",

            "Architectural Patterns (MVVM)",
            "Layering",
            "GRASP",
            "Controller",
            "Low Coupling",
            "High Cohesion",
            "SOLID",
            "Single Responsibility",
            "Testing (Unit Test)",
            "Coding (Adaptive)",
            "Versioning (Git)",
            "Modeling (UML)",
            "Assuring Quality",
            "SQL Database",
            "Text Files (OS)",
            "Persistance",
            "Repository",
            "C# Interface",
            "Console, GUI (WPF), Class Library",

            "Database Model",
            "Normalization",
            "LINQ",
            "Lambda",
            "Delegates & Events",
            "Computational Thinking",
            "Package Diagram",
            "Observer",
            "Processes & Threads",
            "Memory (OS)"
            };

            subjectsSystemudvikling = new List<string> () {
                "Artefakter & Sporbarhed",
                "Objektmodel",
                "Domænemodel",
                "Use Cases",
                "SSD",
                "OC",

                "Kvalitet",
                "FML",
                "Business Case",
                "Projektstyring / Scrum",

                "Interessentanalyse",
                "Test af brugergrænseflader",
                "Design af brugergrænseflader",
                "GDPR", // Databeskyttelsesforordningen
                "IT Sikkerhed",
                "Risikovurdering",
                "Informationssystemer",
                "Eksperimenter",
                "Innovation",
                "KPI",
                "Teamsamarbejde",
                "Forandringsledelse",
                "Organisationsformer",
                "Implementering",
                "BPMN",
                "FURPS+",
                "Bæredygtighed",
                "Kommunikationsplan",
                "Pitch",
                "Rapportskrivning"
            };
        }

        private void Btn_NewSubjectPls_Click (object sender, RoutedEventArgs e)
        {
            // Pool all subjects
            List<string> subjectsPool = new List<string> ();
            foreach (string subject in subjectsProgrammering)
                subjectsPool.Add (subject);
            foreach (string subject in subjectsSystemudvikling)
                subjectsPool.Add (subject);

            // TODO Sort pooling based on choice (to-be-implemented) in window!

            Random rand = new Random ();
            //Lbl_Emne.Text = subjectsPool[rand.Next (0, subjectsPool.Count)];
        }
    }
}