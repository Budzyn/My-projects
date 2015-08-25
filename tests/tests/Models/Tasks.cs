using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.ComponentModel;

namespace tests.Models
{
    [MetadataType(typeof(TasksMetadata))]
    public partial class Tasks
    {
        [Bind(Exclude = "TaskId")]
        public class TasksMetadata
        {
            [ScaffoldColumn(false)]
            public int TaskId { get; set; }
            [DisplayName("Name")]
            [Required(ErrorMessage="Task name is required.")]
            [DisplayFormat(ConvertEmptyStringToNull=false)]
            [StringLength(50)]
            public string Name { get; set; }

            [DisplayName("Article")]
            [Required(ErrorMessage = "Task article is required.")]
            [DisplayFormat(ConvertEmptyStringToNull = false)]
            [StringLength(50)]
            public string Article { get; set; }


        }
    }
}