﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Lil_Notes.Data
{
    /// <summary>
    ///     Contains functions for querying data from DataNotes.Notes.
    /// </summary>
    public static class DataProvider
    {
        /// <summary>
        ///     Queryies notes by their name using a string.
        /// </summary>
        public static ObservableCollection<Note> QueryNotesByString(string _name)
        {
            return new ObservableCollection<Note>(DataNotes.Notes.Where(note => note.Name.ToLower().Contains(_name.ToLower())).ToList());
        }
    }
}
