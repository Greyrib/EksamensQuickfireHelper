using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
//using UnityEngine.UI;

public class SubjectsHandler : MonoBehaviour
{

    [Header ("References")]
    public TextMeshProUGUI subjectText;

    List<string> subjectsProgrammering;
    List<string> subjectsSystemudvikling;

    int lastSubjectChosen = 0;

    void Start ()
    {
        Create_SubjectLists ();

        Get_New_Subject ();
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
            "Assuring Quality (Traceability)",
            "SQL Database",
            "Text Files (OS)",
            "Persistence",
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

    public void Get_New_Subject ()
    {
        // Pool all subjects

        List<string> subjectsPool = new List<string> ();

        foreach (string subject in subjectsProgrammering)
            subjectsPool.Add (subject);

        foreach (string subject in subjectsSystemudvikling)
            subjectsPool.Add (subject);

        int subjectChosen = Random.Range (0, subjectsPool.Count);

        if (subjectChosen == lastSubjectChosen) {
            subjectChosen += 1;

            if (subjectChosen > subjectsPool.Count)
                subjectChosen = 0;
        }

        lastSubjectChosen = subjectChosen;

        if (subjectText != null)
            subjectText.text = subjectsPool[subjectChosen];
    }

}
