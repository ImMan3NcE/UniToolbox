﻿using SQLite;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnisoftTest.MVVM.Models
{
    [Table("AutoItScripts")]
    public class AutoItScript
    {
        [PrimaryKey, AutoIncrement]
        public int ScriptId { get; set; }
        public string ScriptName {  get; set; }
        public string ScriptPath {  get; set; }
        public string ScriptResults {  get; set; }
        public string ImgFav {  get; set; }
        public bool IsFavorite {  get; set; }
        public DateTime ScriptCreatedAt {  get; set; }
        public DateTime ScriptUpdatedAt {  get; set; }
    }
}
