﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UpdateMe.Data.Models
{
    public class Course
    {
        private ICollection<Slide> slides;
        private ICollection<Question> questions;

        public Course()
        {
            this.questions = new HashSet<Question>();

            this.slides = new HashSet<Slide>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        [StringLength(300, MinimumLength = 10)]
        public string Description { get; set; }

        [Range(1, 100)]
        public int PassScore { get; set; }

        public DateTime DateCreated { get; set; }

        public virtual ICollection<Slide> Slides
        {
            get
            {
                return this.slides;
            }
            set
            {
                this.slides = value;
            }
        }

        public virtual ICollection<Question> Questions
        {
            get
            {
                return this.questions;
            }
            set
            {
                this.questions = value;
            }
        }
    }
}
