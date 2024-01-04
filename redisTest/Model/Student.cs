using System.ComponentModel.DataAnnotations;

namespace redisTest.Model
{
	public class Student
	{
		[Key]
		public int Id { get; set; }

		[Display(Name = "Student number")]
		[Required(ErrorMessage = "Student number is required")]
		[StringLength(maximumLength:6, MinimumLength =2)]
		public string? studentNumber { get; set; }

		[Display(Name = "Name of student")]
		[Required(ErrorMessage = "Student name is required")]
		[MaxLength(50)]
		[MinLength(2)]
		public string? studentName { get; set; }

		[Display(Name = "Gender of student")]
		[Required(ErrorMessage = "Gender is required")]
		[StringLength(maximumLength:6, MinimumLength =1)]
		public string? Gender { get; set; }
	}

	public class StudentCreateVM
	{
		[Key]
		public int Id { get; set; }

		[Display(Name = "Student number")]
		[Required(ErrorMessage = "Student number is required")]
		[StringLength(maximumLength: 6, MinimumLength = 2)]
		public string? studentNumber { get; set; }

		[Display(Name = "Name of student")]
		[Required(ErrorMessage = "Student name is required")]
		[MaxLength(50)]
		[MinLength(2)]
		public string? studentName { get; set; }

		[Display(Name = "Gender of student")]
		[Required(ErrorMessage = "Gender is required")]
		[StringLength(maximumLength: 6, MinimumLength = 1)]
		public string? Gender { get; set; }
	}
}
