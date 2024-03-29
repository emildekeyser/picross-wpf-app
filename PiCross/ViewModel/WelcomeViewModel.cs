﻿using PiCross;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DataStructures;

namespace ViewModel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public class WelcomeViewModel
    {
        public WelcomeViewModel(ICommand startPuzzle, IEnumerable<IPuzzleLibraryEntry> puzzleEntries)
        {
            this.StartPuzzle = startPuzzle;
            this.PuzzleEntries = puzzleEntries;
        }

        public ICommand StartPuzzle { get; }
        public IEnumerable<IPuzzleLibraryEntry> PuzzleEntries { get; private set; }
    }
}
